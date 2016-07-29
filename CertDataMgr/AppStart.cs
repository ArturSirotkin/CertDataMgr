using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CertDataMgr
{
    public partial class AppStart : Form
    {
        public AppStart()
        {
            InitializeComponent();
        }

        private void addServerBodyBtn_Click(object sender, EventArgs e)
        {
            AddServerBody AddSB = new AddServerBody();
            AddSB.Show();
        }

        private void addServerMachineBtn_Click(object sender, EventArgs e)
        {
            AddServerMachine AddSM = new AddServerMachine();
            AddSM.Show();
        }

        private void addDivisionBtn_Click(object sender, EventArgs e)
        {
            AddDivision AddDIV = new AddDivision();
            AddDIV.Show();
        }

        private void addFarmBtn_Click(object sender, EventArgs e)
        {
            AddFarm AddFM = new AddFarm();
            AddFM.Show();
        }

        private void addShardBtn_Click(object sender, EventArgs e)
        {
            AddShard AddSD = new AddShard();
            AddSD.Show();
        }

        private void assignFarmContentBtn_Click(object sender, EventArgs e)
        {
            AssignFarmContent AssFC = new AssignFarmContent();
            AssFC.Show(); 
        }
    }
}
