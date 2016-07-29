using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using CertSQL;

namespace CertDataMgr
{
    public partial class AddServerBody : Form
    {
        public AddServerBody()
        {
            InitializeComponent();

            CertSQL.SQLCon a = new SQLCon();
            a.DBConfig.Open();

            a.SQLCMD = new SqlCommand("SELECT szModuleName FROM _Module", a.DBConfig);
            a.SQLReader = a.SQLCMD.ExecuteReader();
            while (a.SQLReader.Read())
            {
                Module.Items.Add(a.SQLReader.GetString(0));
            }
            a.SQLReader.Close();

            a.SQLCMD = new SqlCommand("SELECT nID FROM _ServerBody", a.DBConfig);
            a.SQLReader = a.SQLCMD.ExecuteReader();
            while (a.SQLReader.Read())
            {
                Certifier.Items.Add(a.SQLReader.GetInt16(0));
            }
            a.SQLReader.Close();

            a.SQLCMD = new SqlCommand("SELECT szName FROM _Division", a.DBConfig);
            a.SQLReader = a.SQLCMD.ExecuteReader();
            while (a.SQLReader.Read())
            {
                Division.Items.Add(a.SQLReader.GetString(0));
            }
            a.SQLReader.Close();

            a.SQLCMD = new SqlCommand("SELECT szName FROM _Farm", a.DBConfig);
            a.SQLReader = a.SQLCMD.ExecuteReader();
            while (a.SQLReader.Read())
            {
                Farm.Items.Add(a.SQLReader.GetString(0));
            }
            a.SQLReader.Close();

            a.SQLCMD = new SqlCommand("SELECT szName FROM _Shard", a.DBConfig);
            a.SQLReader = a.SQLCMD.ExecuteReader();
            while (a.SQLReader.Read())
            {
                Shard.Items.Add(a.SQLReader.GetString(0));
            }
            a.SQLReader.Close();

            a.SQLCMD = new SqlCommand("SELECT szName FROM _ServerMachine", a.DBConfig);
            a.SQLReader = a.SQLCMD.ExecuteReader();
            while (a.SQLReader.Read())
            {
                Machine.Items.Add(a.SQLReader.GetString(0));
            }
            a.SQLReader.Close();

            a.DBConfig.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Module.Text == "Certification" && Certifier.Text != "" && Division.Text != "" && Farm.Text != "" && Shard.Text != "")
            {
                MessageBox.Show("You can't assign a Certifier-Division-Farm-Shard to Certification!!!", "WARNING!!!");
            }
            else
            {
                CertSQL.SQLCon a = new SQLCon();
                a.DBConfig.Open();

                object ModuleID = null;
                object CertifierID = null;
                object DivisionID = null;
                object FarmID = null;
                object ShardID = null;

                a.SQLCMD = new SqlCommand("SELECT nID FROM _Module WHERE szModuleName = '" + Module.Text + "'", a.DBConfig);
                a.SQLReader = a.SQLCMD.ExecuteReader();
                a.SQLReader.Read();
                ModuleID = a.SQLReader.GetSqlByte(0);
                a.SQLReader.Close();


                if (Certifier.Text == "")
                { CertifierID = 0; }
                else
                {
                    a.SQLCMD = new SqlCommand("SELECT nID FROM _ServerBody WHERE nID = '" + Certifier.Text + "'", a.DBConfig);
                    a.SQLReader = a.SQLCMD.ExecuteReader();
                    a.SQLReader.Read();
                    CertifierID = a.SQLReader.GetInt16(0);
                    a.SQLReader.Close();
                }

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

                if (Farm.Text == "")
                { FarmID = 0; }
                else
                {
                    a.SQLCMD = new SqlCommand("SELECT nID FROM _Farm WHERE szName = '" + Farm.Text + "'", a.DBConfig);
                    a.SQLReader = a.SQLCMD.ExecuteReader();
                    a.SQLReader.Read();
                    FarmID = a.SQLReader.GetSqlByte(0);
                    a.SQLReader.Close();
                }

                if (Shard.Text == "")
                { ShardID = 0; }
                else
                {
                    a.SQLCMD = new SqlCommand("SELECT nID FROM _Shard WHERE szName = '" + Shard.Text + "'", a.DBConfig);
                    a.SQLReader = a.SQLCMD.ExecuteReader();
                    a.SQLReader.Read();
                    ShardID = (a.SQLReader.GetSqlInt16(0));
                    a.SQLReader.Close();
                }

                a.SQLCMD = new SqlCommand("SELECT nID FROM _ServerMachine WHERE szName = '" + Machine.Text + "'", a.DBConfig);
                a.SQLReader = a.SQLCMD.ExecuteReader();
                a.SQLReader.Read();
                var MachineID = a.SQLReader.GetSqlInt32(0);
                a.SQLReader.Close();

                // EXEC _AddServerBody @CertifierID, @DivisionID, @FarmID, @ShardID, @MachineID, @Port
                a.SQLCMD = new SqlCommand("_AddServerBody", a.DBConfig);
                a.SQLCMD.CommandType = CommandType.StoredProcedure;
                a.SQLCMD.Parameters.Add("@ModuleID", SqlDbType.TinyInt).Value = ModuleID;
                if (Module.Text == "Certification")
                {
                    a.SQLCMD.Parameters.Add("@CertifierID", SqlDbType.SmallInt).Value = 0;
                    a.SQLCMD.Parameters.Add("@DivisionID", SqlDbType.TinyInt).Value = 0;
                    a.SQLCMD.Parameters.Add("@FarmID", SqlDbType.TinyInt).Value = 0;
                    a.SQLCMD.Parameters.Add("@ShardID", SqlDbType.SmallInt).Value = 0;
                    a.SQLCMD.Parameters.Add("@MachineID", SqlDbType.Int).Value = MachineID;
                    a.SQLCMD.Parameters.Add("@Port", SqlDbType.SmallInt).Value = Port.Text;

                }
                else
                {
                    a.SQLCMD.Parameters.Add("@CertifierID", SqlDbType.SmallInt).Value = CertifierID;
                    a.SQLCMD.Parameters.Add("@DivisionID", SqlDbType.TinyInt).Value = DivisionID;
                    a.SQLCMD.Parameters.Add("@FarmID", SqlDbType.TinyInt).Value = FarmID;
                    a.SQLCMD.Parameters.Add("@ShardID", SqlDbType.SmallInt).Value = ShardID;
                    a.SQLCMD.Parameters.Add("@MachineID", SqlDbType.Int).Value = MachineID;
                    a.SQLCMD.Parameters.Add("@Port", SqlDbType.SmallInt).Value = Port.Text;
                }
                a.SQLCMD.ExecuteNonQuery();
                ///

                a.DBConfig.Close();
                MessageBox.Show("Successfully added new " + Module.Text + " module it will be certified by " + Certifier.Text + " and run on port: " + Port.Text + " !", "Success");
            }
        }
    }
}
