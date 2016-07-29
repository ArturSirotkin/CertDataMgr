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
    public partial class AddDivision : Form
    {
        public AddDivision()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (DivisionName.Text == "" || DivisionDBConfig.Text == "")
                MessageBox.Show("Please fill in the division data!!!", "WARNING!!!");
            else
            {
                CertSQL.SQLCon a = new SQLCon();

                // EXEC _AddDivision @DivisionName, @DBConfig
                a.SQLCMD = new SqlCommand("_AddDivision", a.DBConfig);
                a.SQLCMD.CommandType = CommandType.StoredProcedure;
                a.SQLCMD.Parameters.Add("@DivisionName", SqlDbType.VarChar).Value = DivisionName.Text;
                a.SQLCMD.Parameters.Add("@DBConfig", SqlDbType.VarChar).Value = DivisionDBConfig.Text;
                a.SQLCMD.ExecuteNonQuery();

                a.DBConfig.Close();
                MessageBox.Show("Successfully added new Division!", "Success");
            }
        }
    }
}
