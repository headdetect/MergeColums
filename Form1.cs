using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MergeTable
{
    public partial class Form1 : Form
    {
        private const string CONNECTION_FORMAT_WINDOWS_AUTH = "Data Source={0};Trusted_Connection=True;";
        private const string CONNECTION_FORMAT_STANDARD_AUTH = "Data Source={0};User Id={1};Password={2};";

        private string connMethod = string.Empty;

        private SqlConnection connLeft, connRight;

        private bool IsDemo { get { return connMethod == "<TEST>"; } }

        private static readonly DemoData[] demoData = new[] {
                new DemoData("Test1", new TableData("Table1", "Col1", "Col2", "Col3"),
                                      new TableData("Table2", "ColA", "ColB", "ColC", "ColD", "ColE"),
                                      new TableData("TableA", "ACol", "BCol", "CCol", "DCol"),
                                      new TableData("TableB", "Col1", "BCol", "CodC", "CodD", "CodE"),
                                      new TableData("TableD", "ACol", "BCol", "CCol", "DCol")),

                new DemoData("TestA", new TableData("DBTbl1", "HColA", "HColB", "HColC"),
                                      new TableData("DBTbl2", "HCol1", "HCol2", "HCol3", "HCol4", "HCol5"),
                                      new TableData("DBTblA", "ACol4", "ACol", "ACol6", "ACol7"),
                                      new TableData("DBTblB", "ACol1", "ACol2", "ACol3", "ACol4", "ACol5"),
                                      new TableData("DBTblD", "ACol", "AColb", "CCol", "ACold")),

                new DemoData("Alpha", new TableData("TBLStuffA", "col1", "HColB", "Col3"),
                                      new TableData("TBLStuffD", "ColAb", "ColBb", "ColCb", "ColDb", "HCol5"),
                                      new TableData("TBLStuff3", "ACol", "BCol", "CCold", "dCol"),
                                      new TableData("TBLStuffW", "Col1", "BCol", "codC", "CodD", "CodE"),
                                      new TableData("TBLStuffM", "ACol", "bCol", "CCol", "DCol")),
        };

        private static readonly Color NO_MATCH = Color.FromArgb(0xFF, 0x9C, 0x9C); // Light Red //
        private static readonly Color LIGHT_NO_MATCH = Color.FromArgb(0xFF, 0xF0, 0xF0); // Light Light Red //
        private static readonly Color SLIGHT_MATCH = Color.FromArgb(0xFF, 0xFC, 0x9C); // Light Yellow //
        private static readonly Color ALL_GOOD = Color.White;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var loginData = LoginForm.CreateLogin();

            if (loginData != null)
            {
                if (loginData == "<TEST>")
                {
                    connMethod = loginData;
                    LoadDemo();
                    return;
                }
                connMethod = loginData;
                using (var con = new SqlConnection(loginData))
                {
                    con.Open();

                    // Get all of the databases //

                    DataTable databases = con.GetSchema("Databases");
                    foreach (DataRow database in databases.Rows)
                    {
                        cmbDatabaseLeft.Items.Add(database.Field<string>("database_name"));
                        cmbDatabaseRight.Items.Add(database.Field<string>("database_name"));
                    }

                    con.Close();
                }
            }
            else
            {
                this.Close();
            }
        }

        private void btnDBConnectLeft_Click(object sender, EventArgs e)
        {
            cmbLeft.Items.Clear();
            lstLeft.Items.Clear();
            cmbLeft.Enabled = false;
            btnRefLeft.Enabled = false;
            btnGoRight.Enabled = false;

            if (IsDemo)
            {
                cmbLeft.Items.Clear();
                foreach (var db in demoData.Where(itm => itm.Database.Equals(cmbDatabaseLeft.Text)))
                {
                    foreach (var tbl in db.Tables)
                        cmbLeft.Items.Add(tbl.Table);
                    cmbLeft.Enabled = true;
                    btnRefLeft.Enabled = true;
                }

                return;
            }

            var method = connMethod + "Database=" + cmbDatabaseLeft.Text + ";";

            try
            {
                connLeft = new SqlConnection(method);
                connLeft.Open();

                // Time to get the tables //
                SqlCommand cmd = new SqlCommand("SELECT TABLE_NAME " +
                                                "FROM INFORMATION_SCHEMA.TABLES " +
                                                "WHERE TABLE_TYPE = 'BASE TABLE'",
                                                connLeft);
                var data = cmd.ExecuteReader();

                // Create a DataTable object to hold all the data returned by the query.
                DataTable dataTable = new DataTable();
                dataTable.Load(data);

                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    cmbLeft.Items.Add(dataTable.Rows[i]["TABLE_NAME"]);
                }
                if (cmbLeft.Items.Count >= 1) cmbLeft.SelectedIndex = 0;

                cmbLeft.Enabled = true;
                btnRefLeft.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                connLeft.Close();
            }
        }

        private void btnDBConnectRight_Click(object sender, EventArgs e)
        {
            cmbRight.Items.Clear();
            lstRight.Items.Clear();
            cmbRight.Enabled = false;
            btnRefRight.Enabled = false;
            btnGoLeft.Enabled = false;

            if (IsDemo)
            {
                cmbRight.Items.Clear();
                foreach (var db in demoData.Where(itm => itm.Database.Equals(cmbDatabaseRight.Text)))
                {
                    foreach (var tbl in db.Tables)
                        cmbRight.Items.Add(tbl.Table);
                    cmbRight.Enabled = true;
                    btnRefRight.Enabled = true;
                }
                return;
            }

            var method = connMethod + "Database=" + cmbDatabaseRight.Text + ";";

            try
            {
                connRight = new SqlConnection(method);
                connRight.Open();

                // Time to get the tables //
                SqlCommand cmd = new SqlCommand("SELECT TABLE_NAME " +
                                                "FROM INFORMATION_SCHEMA.TABLES " +
                                                "WHERE TABLE_TYPE = 'BASE TABLE'",
                                                connRight);
                var data = cmd.ExecuteReader();

                // Create a DataTable object to hold all the data returned by the query.
                DataTable dataTable = new DataTable();
                dataTable.Load(data);

                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    cmbRight.Items.Add(dataTable.Rows[i]["TABLE_NAME"]);
                }
                if (cmbRight.Items.Count >= 1) cmbRight.SelectedIndex = 0;



                cmbRight.Enabled = true;
                btnRefRight.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                connRight.Close();
            }
        }


        private void btnRefLeft_Click(object sender, EventArgs e)
        {
            btnGoRight.Enabled = false;
            var table = cmbLeft.Text;

            if (IsDemo)
            {
                var db = cmbDatabaseLeft.Text;
                lstLeft.Items.Clear();
                foreach (var cols in demoData.Where(itm => itm.Database.Equals(db)))
                {
                    bool breakAgain = false;
                    foreach (var tableData in cols.Tables)
                    {
                        if (tableData.Table.Equals(table))
                        {
                            foreach (var such in tableData.Columns)
                                lstLeft.Items.Add(such);
                            lstLeft.Enabled = true;
                            breakAgain = true;
                            break;
                        }
                        if (breakAgain)
                            break;
                    }

                }
            }
            else
            {
                if (connLeft != null)
                {
                    try
                    {
                        connLeft.Open();

                        // We dont want any data, just the names of the columns //
                        SqlCommand cmd = new SqlCommand("SELECT COLUMN_NAME " +
                                                        "FROM INFORMATION_SCHEMA.COLUMNS " +
                                                        "WHERE TABLE_NAME = '" + table + "'",
                                                        connLeft);

                        var data = cmd.ExecuteReader();

                        // Create a DataTable object to hold all the data returned by the query.
                        DataTable dataTable = new DataTable();
                        dataTable.Load(data);

                        lstLeft.Items.Clear();

                        for (int i = 0; i < dataTable.Rows.Count; i++)
                        {
                            lstLeft.Items.Add(dataTable.Rows[i]["COLUMN_NAME"].ToString());
                        }

                        connLeft.Close();

                        lstLeft.Enabled = true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                    finally
                    {
                        connLeft.Close();
                    }
                }
            }
            Compare();
        }

        private void btnRefRight_Click(object sender, EventArgs e)
        {
            btnGoLeft.Enabled = false;
            var table = cmbRight.Text;

            if (IsDemo)
            {
                var db = cmbDatabaseRight.Text;
                lstRight.Items.Clear();
                foreach (var cols in demoData.Where(itm => itm.Database.Equals(db)))
                {
                    bool breakAgain = false;
                    foreach (var tableData in cols.Tables)
                    {
                        if (tableData.Table.Equals(table))
                        {
                            foreach (var such in tableData.Columns)
                                lstRight.Items.Add(such);
                            lstRight.Enabled = true;
                            breakAgain = true;
                            break;
                        }
                        if (breakAgain)
                            break;
                    }

                }
            }
            else
            {

                if (connLeft != null)
                {
                    try
                    {
                        connRight.Open();

                        // We dont want any data, just the names of the columns //
                        SqlCommand cmd = new SqlCommand("SELECT COLUMN_NAME " +
                                                        "FROM INFORMATION_SCHEMA.COLUMNS " +
                                                        "WHERE TABLE_NAME = '" + table + "'",
                                                        connRight);

                        var data = cmd.ExecuteReader();

                        // Create a DataTable object to hold all the data returned by the query.
                        DataTable dataTable = new DataTable();
                        dataTable.Load(data);

                        lstRight.Items.Clear();

                        for (int i = 0; i < dataTable.Rows.Count; i++)
                        {
                            lstRight.Items.Add(dataTable.Rows[i]["COLUMN_NAME"].ToString());
                        }
                        lstRight.Enabled = true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                    finally
                    {
                        connRight.Close();
                    }
                }
            }
            Compare();
        }


        private void Compare()
        {
            if (!lstLeft.Enabled || !lstRight.Enabled) return;

            // Clean all empty cols first //

            for (int left = 0; left < lstLeft.Items.Count; left++)
                if (string.IsNullOrWhiteSpace(lstLeft.Items[left].Text.Trim()))
                    lstLeft.Items.RemoveAt(left--);

            for (int right = 0; right < lstRight.Items.Count; right++)
                if (string.IsNullOrWhiteSpace(lstRight.Items[right].Text.Trim()))
                    lstRight.Items.RemoveAt(right--);

            // Compare left to right //
            for (int il = 0; il < lstLeft.Items.Count; il++)
            {
                bool found = false;
                ListViewItem left = lstLeft.Items[il];
                for (int ir = 0; ir < lstRight.Items.Count; ir++)
                {
                    ListViewItem right = lstRight.Items[ir];

                    if (left.Text.Equals(right.Text, StringComparison.OrdinalIgnoreCase))
                    {
                        if (left.Text.MatchesTextButNotCase(right.Text))
                        {
                            lstLeft.Items[il].BackColor = SLIGHT_MATCH;
                            lstRight.Items[ir].BackColor = SLIGHT_MATCH;
                        }
                        else
                        {
                            lstLeft.Items[il].BackColor = ALL_GOOD;
                            lstRight.Items[ir].BackColor = ALL_GOOD;
                        }
                        found = true;
                        break;
                    }
                }
                if (!found)
                {
                    lstLeft.Items[il].BackColor = NO_MATCH;
                    lstRight.Items.Insert(il, new ListViewItem(string.Empty) { BackColor = LIGHT_NO_MATCH });
                }
            }

            // Compare right to left //
            for (int ir = 0; ir < lstRight.Items.Count; ir++)
            {
                bool found = false;
                ListViewItem right = lstRight.Items[ir];

                if (String.IsNullOrWhiteSpace(right.Text)) continue;

                for (int il = 0; il < lstLeft.Items.Count; il++)
                {
                    ListViewItem left = lstRight.Items[ir];
                    if (right.Text.Equals(left.Text, StringComparison.OrdinalIgnoreCase))
                    {
                        if (right.Text.MatchesTextButNotCase(left.Text))
                        {
                            lstLeft.Items[il].BackColor = SLIGHT_MATCH;
                            lstRight.Items[ir].BackColor = SLIGHT_MATCH;
                        }
                        else
                        {
                            lstLeft.Items[il].BackColor = ALL_GOOD;
                            lstRight.Items[ir].BackColor = ALL_GOOD;
                        }
                        found = true;
                        break;
                    }
                }
                if (!found)
                {
                    lstRight.Items[ir].BackColor = NO_MATCH;
                    lstLeft.Items.Insert(ir, new ListViewItem(string.Empty) { BackColor = LIGHT_NO_MATCH });
                }
            }
        }

        private void LoadDemo()
        {
            foreach (var entry in demoData)
            {
                cmbDatabaseLeft.Items.Add(entry.Database);
                cmbDatabaseRight.Items.Add(entry.Database);

            }
        }

        private class DemoData
        {
            public string Database;
            public TableData[] Tables;

            public DemoData(string db, params TableData[] data)
            {
                Tables = data;
                Database = db;
            }
        }

        private class TableData
        {
            public string Table;
            public string[] Columns;

            public TableData(string tbl, params string[] cols)
            {
                Table = tbl;
                Columns = cols;
            }
        }

        private void lstLeft_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnGoRight.Enabled = lstLeft.FocusedItem != null;
        }

        private void lstRight_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnGoLeft.Enabled = lstRight.FocusedItem != null;
        }
    }
}
