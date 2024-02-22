namespace PayRollTuto1
{
    partial class Bonus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bonus));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.BNameTb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BAmountTb = new System.Windows.Forms.TextBox();
            this.DeleteBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.EditBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.SaveBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BonusDGV = new Guna.UI2.WinForms.Guna2DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BonusDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(486, 53);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 27);
            this.label2.TabIndex = 5;
            this.label2.Text = "Bonus";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel4.Location = new System.Drawing.Point(491, 84);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(70, 4);
            this.panel4.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(199, 114);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 19);
            this.label7.TabIndex = 9;
            this.label7.Text = "Name";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // BNameTb
            // 
            this.BNameTb.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BNameTb.Location = new System.Drawing.Point(203, 137);
            this.BNameTb.Margin = new System.Windows.Forms.Padding(4);
            this.BNameTb.Name = "BNameTb";
            this.BNameTb.Size = new System.Drawing.Size(176, 26);
            this.BNameTb.TabIndex = 8;
            this.BNameTb.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(642, 114);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 19);
            this.label1.TabIndex = 11;
            this.label1.Text = "Amount";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // BAmountTb
            // 
            this.BAmountTb.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BAmountTb.Location = new System.Drawing.Point(646, 137);
            this.BAmountTb.Margin = new System.Windows.Forms.Padding(4);
            this.BAmountTb.Name = "BAmountTb";
            this.BAmountTb.Size = new System.Drawing.Size(176, 26);
            this.BAmountTb.TabIndex = 10;
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.ActiveBorderThickness = 1;
            this.DeleteBtn.ActiveCornerRadius = 20;
            this.DeleteBtn.ActiveFillColor = System.Drawing.Color.DeepPink;
            this.DeleteBtn.ActiveForecolor = System.Drawing.Color.White;
            this.DeleteBtn.ActiveLineColor = System.Drawing.Color.DeepPink;
            this.DeleteBtn.BackColor = System.Drawing.Color.White;
            this.DeleteBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DeleteBtn.BackgroundImage")));
            this.DeleteBtn.ButtonText = "Delete";
            this.DeleteBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteBtn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteBtn.ForeColor = System.Drawing.Color.SeaGreen;
            this.DeleteBtn.IdleBorderThickness = 1;
            this.DeleteBtn.IdleCornerRadius = 20;
            this.DeleteBtn.IdleFillColor = System.Drawing.Color.Orange;
            this.DeleteBtn.IdleForecolor = System.Drawing.Color.Honeydew;
            this.DeleteBtn.IdleLineColor = System.Drawing.Color.Orange;
            this.DeleteBtn.Location = new System.Drawing.Point(673, 209);
            this.DeleteBtn.Margin = new System.Windows.Forms.Padding(6);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(149, 50);
            this.DeleteBtn.TabIndex = 29;
            this.DeleteBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // EditBtn
            // 
            this.EditBtn.ActiveBorderThickness = 1;
            this.EditBtn.ActiveCornerRadius = 20;
            this.EditBtn.ActiveFillColor = System.Drawing.Color.DeepPink;
            this.EditBtn.ActiveForecolor = System.Drawing.Color.White;
            this.EditBtn.ActiveLineColor = System.Drawing.Color.DeepPink;
            this.EditBtn.BackColor = System.Drawing.Color.White;
            this.EditBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("EditBtn.BackgroundImage")));
            this.EditBtn.ButtonText = "Edit";
            this.EditBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EditBtn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditBtn.ForeColor = System.Drawing.Color.SeaGreen;
            this.EditBtn.IdleBorderThickness = 1;
            this.EditBtn.IdleCornerRadius = 20;
            this.EditBtn.IdleFillColor = System.Drawing.Color.Orange;
            this.EditBtn.IdleForecolor = System.Drawing.Color.Honeydew;
            this.EditBtn.IdleLineColor = System.Drawing.Color.Orange;
            this.EditBtn.Location = new System.Drawing.Point(418, 209);
            this.EditBtn.Margin = new System.Windows.Forms.Padding(6);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(149, 50);
            this.EditBtn.TabIndex = 28;
            this.EditBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.ActiveBorderThickness = 1;
            this.SaveBtn.ActiveCornerRadius = 20;
            this.SaveBtn.ActiveFillColor = System.Drawing.Color.DeepPink;
            this.SaveBtn.ActiveForecolor = System.Drawing.Color.White;
            this.SaveBtn.ActiveLineColor = System.Drawing.Color.DeepPink;
            this.SaveBtn.BackColor = System.Drawing.Color.White;
            this.SaveBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SaveBtn.BackgroundImage")));
            this.SaveBtn.ButtonText = "Save";
            this.SaveBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SaveBtn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveBtn.ForeColor = System.Drawing.Color.SeaGreen;
            this.SaveBtn.IdleBorderThickness = 1;
            this.SaveBtn.IdleCornerRadius = 20;
            this.SaveBtn.IdleFillColor = System.Drawing.Color.Orange;
            this.SaveBtn.IdleForecolor = System.Drawing.Color.Honeydew;
            this.SaveBtn.IdleLineColor = System.Drawing.Color.Orange;
            this.SaveBtn.Location = new System.Drawing.Point(181, 209);
            this.SaveBtn.Margin = new System.Windows.Forms.Padding(6);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(149, 50);
            this.SaveBtn.TabIndex = 27;
            this.SaveBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(901, 27);
            this.pictureBox7.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(51, 53);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 31;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Click += new System.EventHandler(this.pictureBox7_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(34, 27);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(59, 53);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // BonusDGV
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.BonusDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.BonusDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.BonusDGV.ColumnHeadersHeight = 4;
            this.BonusDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.BonusDGV.DefaultCellStyle = dataGridViewCellStyle6;
            this.BonusDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.BonusDGV.Location = new System.Drawing.Point(61, 280);
            this.BonusDGV.Name = "BonusDGV";
            this.BonusDGV.RowHeadersVisible = false;
            this.BonusDGV.RowHeadersWidth = 51;
            this.BonusDGV.RowTemplate.Height = 24;
            this.BonusDGV.Size = new System.Drawing.Size(877, 250);
            this.BonusDGV.TabIndex = 33;
            this.BonusDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.BonusDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.BonusDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.BonusDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.BonusDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.BonusDGV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.BonusDGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.BonusDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.BonusDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.BonusDGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BonusDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.BonusDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.BonusDGV.ThemeStyle.HeaderStyle.Height = 4;
            this.BonusDGV.ThemeStyle.ReadOnly = false;
            this.BonusDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.BonusDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.BonusDGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BonusDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.BonusDGV.ThemeStyle.RowsStyle.Height = 24;
            this.BonusDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.BonusDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.BonusDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.BonusDGV_CellContentClick);
            // 
            // Bonus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1001, 565);
            this.Controls.Add(this.BonusDGV);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.EditBtn);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BAmountTb);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.BNameTb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel4);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Bonus";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bonus";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BonusDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox BNameTb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox BAmountTb;
        private Bunifu.Framework.UI.BunifuThinButton2 DeleteBtn;
        private Bunifu.Framework.UI.BunifuThinButton2 EditBtn;
        private Bunifu.Framework.UI.BunifuThinButton2 SaveBtn;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2DataGridView BonusDGV;
    }
}