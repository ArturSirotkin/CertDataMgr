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
    public partial class AssignFarmContent : Form
    {
        public AssignFarmContent()
        {
            InitializeComponent();

            CertSQL.SQLCon a = new SQLCon();
            a.DBConfig.Open();

            a.SQLCMD = new SqlCommand("SELECT szName FROM _Farm", a.DBConfig);
            a.SQLReader = a.SQLCMD.ExecuteReader();
            while (a.SQLReader.Read())
            {
                Farm.Items.Add(a.SQLReader.GetString(0));
            }
            a.SQLReader.Close();

            a.SQLCMD = new SqlCommand("SELECT szName FROM _Content", a.DBConfig);
            a.SQLReader = a.SQLCMD.ExecuteReader();
            while (a.SQLReader.Read())
            {
                Content.Items.Add(a.SQLReader.GetString(0));
            }
            a.SQLReader.Close();

            a.DBConfig.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CertSQL.SQLCon a = new SQLCon();
            a.DBConfig.Open();

            object FarmID = null;
            object ContentID = null;

            if (Farm.Text == "")
            { MessageBox.Show("Farm is not selected!!!", "WARNING!!!"); }
            else
            {
                a.SQLCMD = new SqlCommand("SELECT nID FROM _Farm WHERE szName = '" + Farm.Text + "'", a.DBConfig);
                a.SQLReader = a.SQLCMD.ExecuteReader();
                a.SQLReader.Read();
                FarmID = a.SQLReader.GetSqlByte(0);
                a.SQLReader.Close();
            }

            if (Content.Text == "")
            { MessageBox.Show("Content is not selected!!!", "WARNING!!!"); }
            else
            {
                a.SQLCMD = new SqlCommand("SELECT nID FROM _Content WHERE szName = '" + Content.Text + "'", a.DBConfig);
                a.SQLReader = a.SQLCMD.ExecuteReader();
                a.SQLReader.Read();
                ContentID = a.SQLReader.GetSqlByte(0);
                a.SQLReader.Close();
            }

            // EXEC _AssignContentToFarm @DivisionName, @DBConfig
            a.SQLCMD = new SqlCommand("_AssignContentToFarm", a.DBConfig);
            a.SQLCMD.CommandType = CommandType.StoredProcedure;
            a.SQLCMD.Parameters.Add("@FarmID", SqlDbType.TinyInt).Value = FarmID;
            a.SQLCMD.Parameters.Add("@ContentID", SqlDbType.TinyInt).Value = ContentID;
            a.SQLCMD.ExecuteNonQuery();

            a.DBConfig.Close();
            MessageBox.Show("Successfully assigned Content: " + Content.Text + " to Farm: " + Farm.Text + "!", "Success");

        }
    }
}
