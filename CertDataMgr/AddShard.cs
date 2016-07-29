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
    public partial class AddShard : Form
    {
        public AddShard()
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

            a.SQLCMD = new SqlCommand("DECLARE @ModuleID TINYINT; SELECT @ModuleID = nID FROM _Module WHERE szModuleName = 'SR_ShardManager'; SELECT nID FROM _ServerBody WHERE nModuleID = @ModuleID", a.DBConfig);

            a.SQLReader = a.SQLCMD.ExecuteReader();
            while (a.SQLReader.Read())
            {
                //StartupShardMgr.Items.Add("[" + SQLReader.GetInt16(0) + "]" + " - SR_ShardManager");
                StartupShardMgr.Items.Add(a.SQLReader.GetInt16(0));
            }
            a.SQLReader.Close();

            a.DBConfig.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Shard.Text == "" || Farm.Text == "" || Content.Text == "" || MaxUser.Text == "" || ShardDBConfig.Text == "" || ShardDBLogConfig.Text == "" || StartupShardMgr.Text == "")
            {
                MessageBox.Show("Please fill shard data!!!", "WARNING!!!");
            }
            else
            {
                CertSQL.SQLCon a = new SQLCon();
                a.DBConfig.Open();

                a.SQLCMD = new SqlCommand("SELECT nID FROM _Farm WHERE szName = '" + Farm.Text + "'", a.DBConfig);
                a.SQLReader = a.SQLCMD.ExecuteReader();
                a.SQLReader.Read();
                var FarmID = a.SQLReader.GetSqlByte(0);
                a.SQLReader.Close();

                a.SQLCMD = new SqlCommand("SELECT nID FROM _Content WHERE szName = '" + Content.Text + "'", a.DBConfig);
                a.SQLReader = a.SQLCMD.ExecuteReader();
                a.SQLReader.Read();
                var ContentID = a.SQLReader.GetSqlByte(0);
                a.SQLReader.Close();

                // EXEC _AddShard @FarmID, @ContentID, @ShardName, @ShardDB, @LogDB, @MaxUser, @StartupShardMgr
                a.SQLCMD = new SqlCommand("_AddShard", a.DBConfig);
                a.SQLCMD.CommandType = CommandType.StoredProcedure;
                a.SQLCMD.Parameters.Add("@FarmID", SqlDbType.TinyInt).Value = FarmID;
                a.SQLCMD.Parameters.Add("@ContentID", SqlDbType.TinyInt).Value = ContentID;
                a.SQLCMD.Parameters.Add("@ShardName", SqlDbType.VarChar).Value = Shard.Text;
                a.SQLCMD.Parameters.Add("@ShardDB", SqlDbType.VarChar).Value = ShardDBConfig.Text;
                a.SQLCMD.Parameters.Add("@LogDB", SqlDbType.VarChar).Value = ShardDBLogConfig.Text;
                a.SQLCMD.Parameters.Add("@MaxUser", SqlDbType.SmallInt).Value = MaxUser.Text;
                a.SQLCMD.Parameters.Add("@StartupShardMgr", SqlDbType.SmallInt).Value = StartupShardMgr.Text;
                a.SQLCMD.ExecuteNonQuery();
                ///

                // Update AgentServer, SR_ShardManager, SR_GameServer with the new ShardID
                a.SQLCMD = new SqlCommand("DECLARE @ShardID TINYINT; SELECT @ShardID = nID FROM _Shard WHERE szName = '" + Shard.Text + "'; UPDATE _ServerBody SET nShardID = @ShardID WHERE nModuleID = 6 OR nModuleID = 7 OR nModuleID = 8", a.DBConfig);
                a.SQLCMD.ExecuteNonQuery();
                ///

                a.DBConfig.Close();
                MessageBox.Show("Successfully added shard!", "Success");
            }
        }
    }
}
