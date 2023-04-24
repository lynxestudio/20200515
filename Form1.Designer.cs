namespace Samples.ApplyF
{
    partial class Applyf
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.outputLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.pncontrols = new System.Windows.Forms.Panel();
            this.btnApply = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.mnmain = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbSum = new System.Windows.Forms.RadioButton();
            this.rbMin = new System.Windows.Forms.RadioButton();
            this.rbMax = new System.Windows.Forms.RadioButton();
            this.rbAvg = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbTotal = new System.Windows.Forms.Label();
            this.DataArray = new System.Windows.Forms.TextBox();
            this.statusStrip1.SuspendLayout();
            this.pncontrols.SuspendLayout();
            this.mnmain.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.outputLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 278);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(376, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // outputLabel
            // 
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(54, 17);
            this.outputLabel.Text = "Running";
            // 
            // pncontrols
            // 
            this.pncontrols.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pncontrols.Controls.Add(this.groupBox1);
            this.pncontrols.Controls.Add(this.btnApply);
            this.pncontrols.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pncontrols.Location = new System.Drawing.Point(0, 211);
            this.pncontrols.Name = "pncontrols";
            this.pncontrols.Size = new System.Drawing.Size(376, 67);
            this.pncontrols.TabIndex = 4;
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(288, 13);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(75, 30);
            this.btnApply.TabIndex = 4;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Enter data array (numbers separated by commas):";
            // 
            // mnmain
            // 
            this.mnmain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.mnmain.Location = new System.Drawing.Point(0, 0);
            this.mnmain.Name = "mnmain";
            this.mnmain.Size = new System.Drawing.Size(376, 24);
            this.mnmain.TabIndex = 7;
            this.mnmain.Text = "&File";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.quitToolStripMenuItem.Text = "&Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbSum);
            this.groupBox1.Controls.Add(this.rbMin);
            this.groupBox1.Controls.Add(this.rbMax);
            this.groupBox1.Controls.Add(this.rbAvg);
            this.groupBox1.Location = new System.Drawing.Point(4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(278, 58);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Functions";
            // 
            // rbSum
            // 
            this.rbSum.AutoSize = true;
            this.rbSum.Location = new System.Drawing.Point(136, 19);
            this.rbSum.Name = "rbSum";
            this.rbSum.Size = new System.Drawing.Size(53, 20);
            this.rbSum.TabIndex = 7;
            this.rbSum.TabStop = true;
            this.rbSum.Text = "Sum";
            this.rbSum.UseVisualStyleBackColor = true;
            // 
            // rbMin
            // 
            this.rbMin.AutoSize = true;
            this.rbMin.Location = new System.Drawing.Point(83, 19);
            this.rbMin.Name = "rbMin";
            this.rbMin.Size = new System.Drawing.Size(47, 20);
            this.rbMin.TabIndex = 6;
            this.rbMin.TabStop = true;
            this.rbMin.Text = "Min";
            this.rbMin.UseVisualStyleBackColor = true;
            // 
            // rbMax
            // 
            this.rbMax.AutoSize = true;
            this.rbMax.Location = new System.Drawing.Point(195, 19);
            this.rbMax.Name = "rbMax";
            this.rbMax.Size = new System.Drawing.Size(51, 20);
            this.rbMax.TabIndex = 5;
            this.rbMax.TabStop = true;
            this.rbMax.Text = "Max";
            this.rbMax.UseVisualStyleBackColor = true;
            // 
            // rbAvg
            // 
            this.rbAvg.AutoSize = true;
            this.rbAvg.Checked = true;
            this.rbAvg.Location = new System.Drawing.Point(5, 19);
            this.rbAvg.Name = "rbAvg";
            this.rbAvg.Size = new System.Drawing.Size(72, 20);
            this.rbAvg.TabIndex = 4;
            this.rbAvg.TabStop = true;
            this.rbAvg.Text = "Average";
            this.rbAvg.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.DataArray);
            this.panel1.Controls.Add(this.lbTotal);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(376, 157);
            this.panel1.TabIndex = 8;
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbTotal.Location = new System.Drawing.Point(0, 141);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(144, 16);
            this.lbTotal.TabIndex = 9;
            this.lbTotal.Text = "Total of array elements:";
            // 
            // DataArray
            // 
            this.DataArray.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataArray.Location = new System.Drawing.Point(0, 0);
            this.DataArray.Multiline = true;
            this.DataArray.Name = "DataArray";
            this.DataArray.Size = new System.Drawing.Size(376, 141);
            this.DataArray.TabIndex = 10;
            this.DataArray.TextChanged += new System.EventHandler(this.DataArray_TextChanged);
            // 
            // Applyf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 300);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pncontrols);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.mnmain);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.mnmain;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Applyf";
            this.Text = "Apply functions";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.pncontrols.ResumeLayout(false);
            this.mnmain.ResumeLayout(false);
            this.mnmain.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel outputLabel;
        private System.Windows.Forms.Panel pncontrols;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip mnmain;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbSum;
        private System.Windows.Forms.RadioButton rbMin;
        private System.Windows.Forms.RadioButton rbMax;
        private System.Windows.Forms.RadioButton rbAvg;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox DataArray;
        private System.Windows.Forms.Label lbTotal;
    }
}

