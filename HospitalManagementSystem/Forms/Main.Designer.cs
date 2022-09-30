using System.Windows.Forms;

namespace HospitalManagementSystem.Windows
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.delPtnBtn = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.addDocBtn = new System.Windows.Forms.Button();
            this.usrBtn = new System.Windows.Forms.Button();
            this.updPtnBtn = new System.Windows.Forms.Button();
            this.addPtnBtn = new System.Windows.Forms.Button();
            this.docBtn = new System.Windows.Forms.Button();
            this.ptnBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnDischarge = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.tblLbl = new System.Windows.Forms.Label();
            this.dataGridViewMain = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMain)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.delPtnBtn);
            this.panel1.Controls.Add(this.btnLogOut);
            this.panel1.Controls.Add(this.addDocBtn);
            this.panel1.Controls.Add(this.usrBtn);
            this.panel1.Controls.Add(this.updPtnBtn);
            this.panel1.Controls.Add(this.addPtnBtn);
            this.panel1.Controls.Add(this.docBtn);
            this.panel1.Controls.Add(this.ptnBtn);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1028, 77);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // delPtnBtn
            // 
            this.delPtnBtn.BackColor = System.Drawing.Color.DodgerBlue;
            this.delPtnBtn.Font = new System.Drawing.Font("Poetsen One", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delPtnBtn.ForeColor = System.Drawing.Color.White;
            this.delPtnBtn.Location = new System.Drawing.Point(413, 10);
            this.delPtnBtn.Margin = new System.Windows.Forms.Padding(4);
            this.delPtnBtn.Name = "delPtnBtn";
            this.delPtnBtn.Size = new System.Drawing.Size(121, 43);
            this.delPtnBtn.TabIndex = 4;
            this.delPtnBtn.Text = "Delete";
            this.delPtnBtn.UseVisualStyleBackColor = false;
            this.delPtnBtn.Click += new System.EventHandler(this.delPtnBtn_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnLogOut.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnLogOut.Font = new System.Drawing.Font("Poetsen One", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLogOut.Location = new System.Drawing.Point(893, 11);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(124, 44);
            this.btnLogOut.TabIndex = 8;
            this.btnLogOut.Text = "Logout";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // addDocBtn
            // 
            this.addDocBtn.BackColor = System.Drawing.Color.DodgerBlue;
            this.addDocBtn.Font = new System.Drawing.Font("Poetsen One", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addDocBtn.ForeColor = System.Drawing.Color.White;
            this.addDocBtn.Location = new System.Drawing.Point(683, 11);
            this.addDocBtn.Margin = new System.Windows.Forms.Padding(4);
            this.addDocBtn.Name = "addDocBtn";
            this.addDocBtn.Size = new System.Drawing.Size(98, 43);
            this.addDocBtn.TabIndex = 5;
            this.addDocBtn.Text = "Add";
            this.addDocBtn.UseVisualStyleBackColor = false;
            this.addDocBtn.Click += new System.EventHandler(this.addDocBtn_Click);
            // 
            // usrBtn
            // 
            this.usrBtn.BackColor = System.Drawing.Color.DodgerBlue;
            this.usrBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.usrBtn.Font = new System.Drawing.Font("Poetsen One", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usrBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.usrBtn.Location = new System.Drawing.Point(789, 11);
            this.usrBtn.Margin = new System.Windows.Forms.Padding(4);
            this.usrBtn.Name = "usrBtn";
            this.usrBtn.Size = new System.Drawing.Size(96, 44);
            this.usrBtn.TabIndex = 4;
            this.usrBtn.Text = "User";
            this.usrBtn.UseVisualStyleBackColor = false;
            this.usrBtn.Visible = false;
            this.usrBtn.Click += new System.EventHandler(this.usrBtn_Click);
            // 
            // updPtnBtn
            // 
            this.updPtnBtn.BackColor = System.Drawing.Color.DodgerBlue;
            this.updPtnBtn.Font = new System.Drawing.Font("Poetsen One", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updPtnBtn.ForeColor = System.Drawing.Color.White;
            this.updPtnBtn.Location = new System.Drawing.Point(274, 8);
            this.updPtnBtn.Margin = new System.Windows.Forms.Padding(4);
            this.updPtnBtn.Name = "updPtnBtn";
            this.updPtnBtn.Size = new System.Drawing.Size(129, 44);
            this.updPtnBtn.TabIndex = 3;
            this.updPtnBtn.Text = "Update";
            this.updPtnBtn.UseVisualStyleBackColor = false;
            this.updPtnBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // addPtnBtn
            // 
            this.addPtnBtn.BackColor = System.Drawing.Color.DodgerBlue;
            this.addPtnBtn.Font = new System.Drawing.Font("Poetsen One", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPtnBtn.ForeColor = System.Drawing.Color.White;
            this.addPtnBtn.Location = new System.Drawing.Point(167, 8);
            this.addPtnBtn.Margin = new System.Windows.Forms.Padding(4);
            this.addPtnBtn.Name = "addPtnBtn";
            this.addPtnBtn.Size = new System.Drawing.Size(99, 44);
            this.addPtnBtn.TabIndex = 2;
            this.addPtnBtn.Text = "Add";
            this.addPtnBtn.UseVisualStyleBackColor = false;
            this.addPtnBtn.Click += new System.EventHandler(this.addPtnBtn_Click);
            // 
            // docBtn
            // 
            this.docBtn.BackColor = System.Drawing.Color.DodgerBlue;
            this.docBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.docBtn.Font = new System.Drawing.Font("Poetsen One", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.docBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.docBtn.Location = new System.Drawing.Point(545, 10);
            this.docBtn.Margin = new System.Windows.Forms.Padding(4);
            this.docBtn.Name = "docBtn";
            this.docBtn.Size = new System.Drawing.Size(127, 44);
            this.docBtn.TabIndex = 1;
            this.docBtn.Text = "Doctor";
            this.docBtn.UseVisualStyleBackColor = false;
            this.docBtn.Click += new System.EventHandler(this.docBtn_Click);
            // 
            // ptnBtn
            // 
            this.ptnBtn.BackColor = System.Drawing.Color.DodgerBlue;
            this.ptnBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptnBtn.Font = new System.Drawing.Font("Poetsen One", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ptnBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ptnBtn.Location = new System.Drawing.Point(14, 6);
            this.ptnBtn.Margin = new System.Windows.Forms.Padding(4);
            this.ptnBtn.Name = "ptnBtn";
            this.ptnBtn.Size = new System.Drawing.Size(135, 46);
            this.ptnBtn.TabIndex = 0;
            this.ptnBtn.Text = "Patient";
            this.ptnBtn.UseVisualStyleBackColor = false;
            this.ptnBtn.Click += new System.EventHandler(this.ptnBtn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.btnDischarge);
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.searchBox);
            this.panel2.Controls.Add(this.tblLbl);
            this.panel2.Controls.Add(this.dataGridViewMain);
            this.panel2.Location = new System.Drawing.Point(13, 114);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1028, 612);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(25, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(167, 139);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // btnDischarge
            // 
            this.btnDischarge.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnDischarge.Enabled = false;
            this.btnDischarge.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnDischarge.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDischarge.Font = new System.Drawing.Font("Sitka Small", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDischarge.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDischarge.Location = new System.Drawing.Point(811, 94);
            this.btnDischarge.Margin = new System.Windows.Forms.Padding(4);
            this.btnDischarge.Name = "btnDischarge";
            this.btnDischarge.Size = new System.Drawing.Size(117, 37);
            this.btnDischarge.TabIndex = 7;
            this.btnDischarge.Text = "Discharge";
            this.btnDischarge.UseVisualStyleBackColor = false;
            this.btnDischarge.Click += new System.EventHandler(this.btnDischarge_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.comboBox1.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "ID",
            "Name"});
            this.comboBox1.Location = new System.Drawing.Point(202, 94);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(125, 29);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // searchBox
            // 
            this.searchBox.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.searchBox.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBox.Location = new System.Drawing.Point(336, 94);
            this.searchBox.Margin = new System.Windows.Forms.Padding(4);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(455, 31);
            this.searchBox.TabIndex = 2;
            this.searchBox.TextChanged += new System.EventHandler(this.searchBox_TextChanged);
            // 
            // tblLbl
            // 
            this.tblLbl.AutoSize = true;
            this.tblLbl.Font = new System.Drawing.Font("Poetsen One", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tblLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tblLbl.Location = new System.Drawing.Point(199, 26);
            this.tblLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tblLbl.Name = "tblLbl";
            this.tblLbl.Size = new System.Drawing.Size(597, 40);
            this.tblLbl.TabIndex = 1;
            this.tblLbl.Text = "ABC Hospital and Diagnostic Center";
            this.tblLbl.Visible = false;
            // 
            // dataGridViewMain
            // 
            this.dataGridViewMain.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridViewMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.MediumAquamarine;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewMain.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewMain.Location = new System.Drawing.Point(25, 151);
            this.dataGridViewMain.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewMain.Name = "dataGridViewMain";
            this.dataGridViewMain.ReadOnly = true;
            this.dataGridViewMain.RowHeadersWidth = 51;
            this.dataGridViewMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewMain.Size = new System.Drawing.Size(963, 440);
            this.dataGridViewMain.TabIndex = 0;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1085, 753);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Main";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CCH Ltd.";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMain)).EndInit();
            this.ResumeLayout(false);

        }

        public void AdminAccess()
        {
            this.usrBtn.Visible = true;
            this.lblAdministrator.Visible = true;
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ptnBtn;
        private System.Windows.Forms.Button docBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridViewMain;
        private System.Windows.Forms.Label tblLbl;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Button usrBtn;
        private System.Windows.Forms.Button addPtnBtn;
        private System.Windows.Forms.Button btnDischarge;
        private System.Windows.Forms.Button updPtnBtn;
        private System.Windows.Forms.Button delPtnBtn;
        private System.Windows.Forms.Button addDocBtn;
        private Button btnLogOut;
        private PictureBox pictureBox1;
    }
}