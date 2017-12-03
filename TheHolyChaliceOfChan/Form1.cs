using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
            try
            {
                model.Analyze();
                bsMain.ResetBindings(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnOutput_Click(object sender, EventArgs e)
        {
            try
            {
                model.Output();
                MessageBox.Show("出力完了");
            }catch(Exception ex)
            {
                MessageBox.Show(this, ex.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPref_Click(object sender, EventArgs e)
        {
            fbd.SelectedPath = model.OutDirectory;
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                model.OutDirectory = fbd.SelectedPath;
                bsMain.ResetBindings(false);
            }
        }
    }
}
