using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheHolyChaliceOfChan
{
    public partial class Form1 : Form
    {
        private Model model = new Model();

        public Form1()
        {
            InitializeComponent();
            this.bsMain.DataSource = model;
        }

        private void btnAnalyze_Click(object sender, EventArgs e)
        {
            model.Analyze();
            bsMain.ResetBindings(false);
        }

        private void btnOutput_Click(object sender, EventArgs e)
        {
            model.Output();
        }
    }
}
