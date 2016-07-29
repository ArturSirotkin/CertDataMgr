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
    public partial class AddFarm : Form
    {
        public AddFarm()
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

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Division.Text == "" || Farm.Text == "")
                MessageBox.Show("Please fill the farm data!!!", "WARNING!!!");
            else
            {
                CertSQL.SQLCon a = new SQLCon();
                a.DBConfig.Open();

                a.SQLCMD = new SqlCommand("SELECT nID FROM _Division WHERE szName = '" + Division.Text + "'", a.DBConfig);
                a.SQLReader = a.SQLCMD.ExecuteReader();
                a.SQLReader.Read();
                var DivisionID = a.SQLReader.GetSqlByte(0);
                a.SQLReader.Close();

                // EXEC _AddFarm @DivisionID, @FarmName
                a.SQLCMD = new SqlCommand("_AddFarm", a.DBConfig);
                a.SQLCMD.CommandType = CommandType.StoredProcedure;
                a.SQLCMD.Parameters.Add("@DivisionID", SqlDbType.TinyInt).Value = DivisionID;
                a.SQLCMD.Parameters.Add("@FarmName", SqlDbType.VarChar).Value = Farm.Text;
                a.SQLCMD.ExecuteNonQuery();
                ///

                a.DBConfig.Close();
                MessageBox.Show("Successfully added new farm!\nDivision: " + Division.Text + "\nFarm: " + Farm.Text, "Success");
            }
        }
    }
}
