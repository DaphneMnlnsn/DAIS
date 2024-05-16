namespace DAIS
{
    partial class Staff
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
            this.searchTxtBox = new System.Windows.Forms.TextBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.dshbrdLbl = new System.Windows.Forms.Label();
            this.doctorPic = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnnewappointment = new System.Windows.Forms.Button();
            this.patientBtn = new System.Windows.Forms.PictureBox();
            this.staffBtn = new System.Windows.Forms.PictureBox();
            this.servicesBtn = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorPic)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patientBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicesBtn)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // searchTxtBox
            // 
            this.searchTxtBox.BackColor = System.Drawing.Color.White;
            this.searchTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTxtBox.ForeColor = System.Drawing.Color.Silver;
            this.searchTxtBox.Location = new System.Drawing.Point(757, 95);
            this.searchTxtBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.searchTxtBox.Name = "searchTxtBox";
            this.searchTxtBox.Size = new System.Drawing.Size(209, 24);
            this.searchTxtBox.TabIndex = 7;
            this.searchTxtBox.Text = "Search";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBox5.Image = global::DAIS.Properties.Resources.search;
            this.pictureBox5.Location = new System.Drawing.Point(941, 95);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(23, 21);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 8;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox4.Image = global::DAIS.Properties.Resources.staffs;
            this.pictureBox4.Location = new System.Drawing.Point(-31, 4);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(56, 55);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 4;
            this.pictureBox4.TabStop = false;
            // 
            // dshbrdLbl
            // 
            this.dshbrdLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dshbrdLbl.AutoSize = true;
            this.dshbrdLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dshbrdLbl.Location = new System.Drawing.Point(129, 14);
            this.dshbrdLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dshbrdLbl.Name = "dshbrdLbl";
            this.dshbrdLbl.Size = new System.Drawing.Size(129, 29);
            this.dshbrdLbl.TabIndex = 5;
            this.dshbrdLbl.Text = "List of Staff";
            this.dshbrdLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // doctorPic
            // 
            this.doctorPic.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.doctorPic.Image = global::DAIS.Properties.Resources.profile_icon;
            this.doctorPic.Location = new System.Drawing.Point(901, 8);
            this.doctorPic.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.doctorPic.Name = "doctorPic";
            this.doctorPic.Size = new System.Drawing.Size(51, 45);
            this.doctorPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.doctorPic.TabIndex = 7;
            this.doctorPic.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.panel1.Controls.Add(this.btnnewappointment);
            this.panel1.Controls.Add(this.doctorPic);
            this.panel1.Controls.Add(this.dshbrdLbl);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(913, 63);
            this.panel1.TabIndex = 6;
            // 
            // btnnewappointment
            // 
            this.btnnewappointment.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnnewappointment.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnnewappointment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnnewappointment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnewappointment.ForeColor = System.Drawing.SystemColors.Control;
            this.btnnewappointment.Location = new System.Drawing.Point(757, 20);
            this.btnnewappointment.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnnewappointment.Name = "btnnewappointment";
            this.btnnewappointment.Size = new System.Drawing.Size(149, 31);
            this.btnnewappointment.TabIndex = 8;
            this.btnnewappointment.Text = "+ Add Staff";
            this.btnnewappointment.UseVisualStyleBackColor = false;
            // 
            // patientBtn
            // 
            this.patientBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.patientBtn.Image = global::DAIS.Properties.Resources.patients;
            this.patientBtn.Location = new System.Drawing.Point(32, 143);
            this.patientBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.patientBtn.Name = "patientBtn";
            this.patientBtn.Size = new System.Drawing.Size(44, 46);
            this.patientBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.patientBtn.TabIndex = 1;
            this.patientBtn.TabStop = false;
            // 
            // staffBtn
            // 
            this.staffBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.staffBtn.Image = global::DAIS.Properties.Resources.calendar;
            this.staffBtn.Location = new System.Drawing.Point(32, 48);
            this.staffBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.staffBtn.Name = "staffBtn";
            this.staffBtn.Size = new System.Drawing.Size(44, 40);
            this.staffBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.staffBtn.TabIndex = 0;
            this.staffBtn.TabStop = false;
            // 
            // servicesBtn
            // 
            this.servicesBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.servicesBtn.Image = global::DAIS.Properties.Resources.services;
            this.servicesBtn.Location = new System.Drawing.Point(32, 243);
            this.servicesBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.servicesBtn.Name = "servicesBtn";
            this.servicesBtn.Size = new System.Drawing.Size(44, 42);
            this.servicesBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.servicesBtn.TabIndex = 2;
            this.servicesBtn.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(245)))), ((int)(((byte)(238)))));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.servicesBtn, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.staffBtn, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.patientBtn, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 63);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 98F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 98F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 98F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 111F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(108, 424);
            this.tableLayoutPanel1.TabIndex = 71;
            // 
            // Staff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(913, 487);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.searchTxtBox);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximumSize = new System.Drawing.Size(1045, 648);
            this.Name = "Staff";
            this.Text = "Staff";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Staff_FormClosing);
            this.Load += new System.EventHandler(this.Staff_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorPic)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patientBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicesBtn)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox searchTxtBox;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label dshbrdLbl;
        private System.Windows.Forms.PictureBox doctorPic;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox patientBtn;
        private System.Windows.Forms.PictureBox staffBtn;
        private System.Windows.Forms.PictureBox servicesBtn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnnewappointment;
    }
}