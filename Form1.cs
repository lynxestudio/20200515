using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Samples.ApplyF
{
    public partial class Applyf : Form
    {
        delegate double DelegateToApply(double[] d);
        static double GetOperation(double[] data, DelegateToApply del)
        {
            return del(data);
        }

        public Applyf()
        {
            InitializeComponent();
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            outputLabel.Text = string.Empty;
            if(string.IsNullOrEmpty(DataArray.Text))
                MessageBox.Show("Data cannot be empty","Apply functions",MessageBoxButtons.OK,MessageBoxIcon.Error);
            else
            {
            string[] input = DataArray.Text.Trim().Split(',');
            double[] data = new double[input.Length];
            for (int i = 0; i < input.Length;i++)
            {
                try
                {
                    data[i] = Convert.ToDouble(input[i]);
                }
                catch (FormatException)
                {
                    MessageBox.Show(input[i] + " is not a number", "Apply functions", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (rbAvg.Checked)
                outputLabel.Text = "Result: " + GetOperation(data, Operations.Avg).ToString("F");
            if (rbMax.Checked)
                outputLabel.Text = "Result: " + GetOperation(data, Operations.Max).ToString();
            if (rbMin.Checked)
                outputLabel.Text = "Result: " + GetOperation(data, Operations.Min).ToString();
            if (rbSum.Checked)
                outputLabel.Text = "Result: " + GetOperation(data, Operations.Sum).ToString();
            }
        }

        private void DataArray_TextChanged(object sender, EventArgs e)
        {
            lbTotal.Text = string.Empty;
            string[] input = DataArray.Text.Trim().Split(',');
            lbTotal.Text = "Total of array elements: " + input.Length.ToString();
        }
    }
}
