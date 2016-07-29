using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Data.SqlClient;
using CertSQL;

namespace CertDataMgr
{
    public partial class AddServerMachine : Form
    {
        public AddServerMachine()
        {
            InitializeComponent();

            CertSQL.SQLCon a = new SQLCon();
            a.DBConfig.Open();

            a.SQLCMD = new SqlCommand("SELECT szName FROM _Division", a.DBConfig);
            a.SQLReader = a.SQLCMD.ExecuteReader();
            while (a.SQLReader.Read())
            {
                Division.Items.Add(a.SQLReader.GetString(0));
            }
            a.SQLReader.Close();
            a.DBConfig.Close();


            PublicIP.Items.Add("127.0.0.1"); // Use 127.0.0.1 only for Certification Module
            PrivateIP.Items.Add("127.0.0.1"); // Use 127.0.0.1 only for Certification Module
            IPHostEntry Host = Dns.GetHostEntry(Dns.GetHostName()); ;
            foreach (IPAddress IP in Host.AddressList)
            {
                PublicIP.Items.Add(IP.ToString());
                PrivateIP.Items.Add(IP.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Division.Text == "" || MachineName.Text == "" || PublicIP.Text == "" || PrivateIP.Text == "")
                MessageBox.Show("Please fill in the machine data", "WARNING!!!");
            else
            {
                CertSQL.SQLCon a = new SQLCon();
                a.DBConfig.Open();

                object DivisionID = null;

                if (Division.Text == "")
                { DivisionID = 0; }
                else
                {
                    a.SQLCMD = new SqlCommand("SELECT nID FROM _Division WHERE szName = '" + Division.Text + "'", a.DBConfig);
                    a.SQLReader = a.SQLCMD.ExecuteReader();
                    a.SQLReader.Read();
                    DivisionID = a.SQLReader.GetSqlByte(0);
                    a.SQLReader.Close();
                }

                // EXEC _AddServerMachine @DivisionID, @MachineName, @PublicIP, @PrivateIP
                a.SQLCMD = new SqlCommand("_AddServerMachine", a.DBConfig);
                a.SQLCMD.CommandType = CommandType.StoredProcedure;
                if (MachineName.Text == "Certification")
                {
                    a.SQLCMD.Parameters.Add("@DivisionID", SqlDbType.TinyInt).Value = 0;
                    a.SQLCMD.Parameters.Add("@MachineName", SqlDbType.VarChar).Value = MachineName.Text;
                    a.SQLCMD.Parameters.Add("@PublicIP", SqlDbType.VarChar).Value = "127.0.0.1";
                    a.SQLCMD.Parameters.Add("@PrivateIP", SqlDbType.VarChar).Value = "127.0.0.1";
                }
                else
                {
                    a.SQLCMD.Parameters.Add("@DivisionID", SqlDbType.TinyInt).Value = DivisionID;
                    a.SQLCMD.Parameters.Add("@MachineName", SqlDbType.VarChar).Value = MachineName.Text;
                    a.SQLCMD.Parameters.Add("@PublicIP", SqlDbType.VarChar).Value = PublicIP.Text;
                    a.SQLCMD.Parameters.Add("@PrivateIP", SqlDbType.VarChar).Value = PrivateIP.Text;
                }
                a.SQLCMD.ExecuteNonQuery();
                ///

                a.DBConfig.Close();
                MessageBox.Show("Successfully added new Server Machine!\nMachine: " + MachineName.Text + "\nDivision: " + Division.Text + "\nWAN Address: " + PublicIP.Text + "\nLAN Address: " + PrivateIP.Text, "Success");
            }
        }

    }
}
