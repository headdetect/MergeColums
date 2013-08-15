using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MergeTable
{
    public partial class LoginForm : Form
    {
        private const string CONNECTION_FORMAT_WINDOWS_AUTH = "Data Source={0};Trusted_Connection=True;";
        private const string CONNECTION_FORMAT_STANDARD_AUTH = "Data Source={0};User Id={1};Password={2};Trusted_Connection=False;";

        private string _result;

        private LoginForm()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if(cmbAuth.SelectedIndex == -1 || String.IsNullOrWhiteSpace(cmbAuth.Text)) return;

            string method = string.Empty;
            if (cmbAuth.SelectedIndex == 0)
            {
                method = string.Format(CONNECTION_FORMAT_WINDOWS_AUTH, txtServer.Text);
            }
            else if (cmbAuth.SelectedIndex == 1)
            {
                method = string.Format(CONNECTION_FORMAT_STANDARD_AUTH, txtServer.Text, txtLogin.Text, txtPassword.Text);
            }

            try
            {
                using (var connection = new SqlConnection(method))
                {
                    connection.Open();
                    connection.Close();
                }
                _result = method;
                DialogResult = System.Windows.Forms.DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        public static string CreateLogin()
        {
            var login = new LoginForm();
            if (login.ShowDialog() == DialogResult.OK)
                return login._result;
            return null;
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            // Uses native methods. Cannot be used on unix (Like you guys would ever use unix)

            foreach (var server in NativeMethods.ODBCConnections.GetServers())
                txtServer.Items.Add(server);

            cmbAuth.SelectedIndex = 0;

            var windows = WindowsIdentity.GetCurrent();

            txtLogin.Text = windows.Name;
        }

        private void cmbAuth_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnConnect.Enabled = cmbAuth.SelectedIndex > -1;

            txtLogin.Enabled = cmbAuth.SelectedIndex != 0;
            txtPassword.Enabled = cmbAuth.SelectedIndex != 0;

            txtLogin.Clear();
            txtPassword.Clear();

            if (!txtLogin.Enabled)
            {
                var windows = WindowsIdentity.GetCurrent();

                txtLogin.Text = windows.Name;
            }

        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) btnConnect_Click(sender, null);
        }

        private void txtServer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F8)
            {
                _result = "<TEST>";
                DialogResult = System.Windows.Forms.DialogResult.OK;
                Close();
            }
        }
    }

    public class LoginData
    {
        public string Server { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public AuthMethod AuthMethod { get; set; }

        public LoginData(string server, string login, string password, AuthMethod auth)
        {
            Server = server;
            Login = login;
            Password = password;
            AuthMethod = auth;
        }
    }

    public enum AuthMethod
    {
        Windows = 0,
        SQL = 1
    }
}
