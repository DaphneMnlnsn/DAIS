﻿namespace DAIS
{
    partial class Appointment
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.deleteAppntmnt = new System.Windows.Forms.Button();
            this.editAppntmnt = new System.Windows.Forms.Button();
            this.stffLbl = new System.Windows.Forms.Label();
            this.timeLbl = new System.Windows.Forms.Label();
            this.srvcLbl = new System.Windows.Forms.Label();
            this.ptntLbl = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.stffLbl);
            this.panel1.Controls.Add(this.timeLbl);
            this.panel1.Controls.Add(this.srvcLbl);
            this.panel1.Controls.Add(this.ptntLbl);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1064, 237);
            this.panel1.TabIndex = 15;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.deleteAppntmnt);
            this.panel2.Controls.Add(this.editAppntmnt);
            this.panel2.Location = new System.Drawing.Point(703, 46);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(316, 155);
            this.panel2.TabIndex = 7;
            // 
            // deleteAppntmnt
            // 
            this.deleteAppntmnt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteAppntmnt.Location = new System.Drawing.Point(29, 81);
            this.deleteAppntmnt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.deleteAppntmnt.Name = "deleteAppntmnt";
            this.deleteAppntmnt.Size = new System.Drawing.Size(262, 49);
            this.deleteAppntmnt.TabIndex = 2;
            this.deleteAppntmnt.Text = "Delete";
            this.deleteAppntmnt.UseVisualStyleBackColor = true;
            // 
            // editAppntmnt
            // 
            this.editAppntmnt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editAppntmnt.Location = new System.Drawing.Point(29, 21);
            this.editAppntmnt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.editAppntmnt.Name = "editAppntmnt";
            this.editAppntmnt.Size = new System.Drawing.Size(262, 46);
            this.editAppntmnt.TabIndex = 1;
            this.editAppntmnt.Text = "Edit";
            this.editAppntmnt.UseVisualStyleBackColor = true;
            this.editAppntmnt.Click += new System.EventHandler(this.editAppntmnt_Click);
            // 
            // stffLbl
            // 
            this.stffLbl.AutoSize = true;
            this.stffLbl.Font = new System.Drawing.Font("Inter Medium", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stffLbl.Location = new System.Drawing.Point(45, 181);
            this.stffLbl.Name = "stffLbl";
            this.stffLbl.Size = new System.Drawing.Size(61, 21);
            this.stffLbl.TabIndex = 6;
            this.stffLbl.Text = "label5";
            // 
            // timeLbl
            // 
            this.timeLbl.AutoSize = true;
            this.timeLbl.Font = new System.Drawing.Font("Inter Medium", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLbl.Location = new System.Drawing.Point(45, 136);
            this.timeLbl.Name = "timeLbl";
            this.timeLbl.Size = new System.Drawing.Size(62, 21);
            this.timeLbl.TabIndex = 5;
            this.timeLbl.Text = "label4";
            // 
            // srvcLbl
            // 
            this.srvcLbl.AutoSize = true;
            this.srvcLbl.Font = new System.Drawing.Font("Inter Medium", 9F, System.Drawing.FontStyle.Bold);
            this.srvcLbl.Location = new System.Drawing.Point(45, 93);
            this.srvcLbl.Name = "srvcLbl";
            this.srvcLbl.Size = new System.Drawing.Size(62, 21);
            this.srvcLbl.TabIndex = 4;
            this.srvcLbl.Text = "label3";
            // 
            // ptntLbl
            // 
            this.ptntLbl.AutoSize = true;
            this.ptntLbl.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ptntLbl.Location = new System.Drawing.Point(44, 33);
            this.ptntLbl.Name = "ptntLbl";
            this.ptntLbl.Size = new System.Drawing.Size(85, 29);
            this.ptntLbl.TabIndex = 3;
            this.ptntLbl.Text = "label2";
            this.ptntLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Location = new System.Drawing.Point(3, 231);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1058, 100);
            this.panel3.TabIndex = 8;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Location = new System.Drawing.Point(3, -16);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1058, 22);
            this.panel4.TabIndex = 9;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Location = new System.Drawing.Point(1059, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(203, 231);
            this.panel5.TabIndex = 10;
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Location = new System.Drawing.Point(-12, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(16, 231);
            this.panel6.TabIndex = 11;
            // 
            // Appointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "Appointment";
            this.Size = new System.Drawing.Size(1064, 236);
            this.Load += new System.EventHandler(this.Appointment_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button deleteAppntmnt;
        private System.Windows.Forms.Button editAppntmnt;
        private System.Windows.Forms.Label stffLbl;
        private System.Windows.Forms.Label timeLbl;
        private System.Windows.Forms.Label srvcLbl;
        private System.Windows.Forms.Label ptntLbl;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel6;
    }
}
