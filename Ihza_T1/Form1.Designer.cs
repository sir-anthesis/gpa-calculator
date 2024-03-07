
namespace Ihza_T1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txmodule = new TextBox();
            nutest = new NumericUpDown();
            nuassign = new NumericUpDown();
            btsubmit = new Button();
            label5 = new Label();
            lbresult = new Label();
            label6 = new Label();
            lbgrade = new Label();
            nucredit = new NumericUpDown();
            label7 = new Label();
            btgpa = new Button();
            ((System.ComponentModel.ISupportInitialize)nutest).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nuassign).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nucredit).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(141, 32);
            label1.Name = "label1";
            label1.Size = new Size(218, 21);
            label1.TabIndex = 0;
            label1.Text = "MENGHITUNG NILAI AKHIR";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(64, 97);
            label2.Name = "label2";
            label2.Size = new Size(109, 21);
            label2.TabIndex = 1;
            label2.Text = "Module Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(64, 141);
            label3.Name = "label3";
            label3.Size = new Size(93, 21);
            label3.TabIndex = 2;
            label3.Text = "Module Test";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(64, 185);
            label4.Name = "label4";
            label4.Size = new Size(92, 21);
            label4.TabIndex = 3;
            label4.Text = "Assignment";
            // 
            // txmodule
            // 
            txmodule.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txmodule.Location = new Point(241, 89);
            txmodule.Name = "txmodule";
            txmodule.Size = new Size(214, 29);
            txmodule.TabIndex = 4;
            // 
            // nutest
            // 
            nutest.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nutest.Location = new Point(241, 133);
            nutest.Name = "nutest";
            nutest.Size = new Size(214, 29);
            nutest.TabIndex = 5;
            // 
            // nuassign
            // 
            nuassign.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nuassign.Location = new Point(241, 177);
            nuassign.Name = "nuassign";
            nuassign.Size = new Size(214, 29);
            nuassign.TabIndex = 6;
            // 
            // btsubmit
            // 
            btsubmit.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btsubmit.Location = new Point(64, 257);
            btsubmit.Name = "btsubmit";
            btsubmit.Size = new Size(391, 30);
            btsubmit.TabIndex = 7;
            btsubmit.Text = "SUBMIT";
            btsubmit.UseVisualStyleBackColor = true;
            btsubmit.Click += btsubmit_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(65, 306);
            label5.Name = "label5";
            label5.Size = new Size(53, 21);
            label5.TabIndex = 8;
            label5.Text = "Result";
            // 
            // lbresult
            // 
            lbresult.AutoSize = true;
            lbresult.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbresult.Location = new Point(158, 306);
            lbresult.Name = "lbresult";
            lbresult.Size = new Size(0, 21);
            lbresult.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(307, 306);
            label6.Name = "label6";
            label6.Size = new Size(52, 21);
            label6.TabIndex = 10;
            label6.Text = "Grade";
            // 
            // lbgrade
            // 
            lbgrade.AutoSize = true;
            lbgrade.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbgrade.Location = new Point(403, 306);
            lbgrade.Name = "lbgrade";
            lbgrade.Size = new Size(0, 21);
            lbgrade.TabIndex = 11;
            // 
            // nucredit
            // 
            nucredit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nucredit.Location = new Point(241, 222);
            nucredit.Name = "nucredit";
            nucredit.Size = new Size(214, 29);
            nucredit.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(64, 230);
            label7.Name = "label7";
            label7.Size = new Size(94, 21);
            label7.TabIndex = 12;
            label7.Text = "Credit Value";
            // 
            // btgpa
            // 
            btgpa.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btgpa.Location = new Point(65, 366);
            btgpa.Name = "btgpa";
            btgpa.Size = new Size(391, 30);
            btgpa.TabIndex = 14;
            btgpa.Text = "GPA";
            btgpa.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(518, 446);
            Controls.Add(btgpa);
            Controls.Add(nucredit);
            Controls.Add(label7);
            Controls.Add(lbgrade);
            Controls.Add(label6);
            Controls.Add(lbresult);
            Controls.Add(label5);
            Controls.Add(btsubmit);
            Controls.Add(nuassign);
            Controls.Add(nutest);
            Controls.Add(txmodule);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Menghitung Nilai Akhir - Ihza";
            ((System.ComponentModel.ISupportInitialize)nutest).EndInit();
            ((System.ComponentModel.ISupportInitialize)nuassign).EndInit();
            ((System.ComponentModel.ISupportInitialize)nucredit).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txmodule;
        private NumericUpDown nutest;
        private NumericUpDown nuassign;
        private Button btsubmit;
        private Label label5;
        private Label lbresult;
        private Label label6;
        private Label lbgrade;
        private NumericUpDown nucredit;
        private Label label7;
        private Button btgpa;
    }
}
