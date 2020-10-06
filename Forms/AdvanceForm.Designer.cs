namespace OutlookControll
{
    partial class AdvanceForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdvanceForm));
            this.Btn_cancel = new System.Windows.Forms.Button();
            this.Btn_encryption2 = new System.Windows.Forms.Button();
            this.Btn_standard = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ExpirationDateGroup = new System.Windows.Forms.GroupBox();
            this.RB1 = new System.Windows.Forms.RadioButton();
            this.RB3 = new System.Windows.Forms.RadioButton();
            this.RB2 = new System.Windows.Forms.RadioButton();
            this.txt_phone = new System.Windows.Forms.TextBox();
            this.lbl_expiration = new System.Windows.Forms.Label();
            this.lbl_phone = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.ExpirationDateGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // Btn_cancel
            // 
            this.Btn_cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Btn_cancel.FlatAppearance.BorderSize = 0;
            this.Btn_cancel.Image = global::OutlookControll.Properties.Resources.btn_cancel;
            this.Btn_cancel.Location = new System.Drawing.Point(-1, 138);
            this.Btn_cancel.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_cancel.Name = "Btn_cancel";
            this.Btn_cancel.Size = new System.Drawing.Size(296, 69);
            this.Btn_cancel.TabIndex = 5;
            this.Btn_cancel.UseVisualStyleBackColor = true;
            // 
            // Btn_encryption2
            // 
            this.Btn_encryption2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Btn_encryption2.FlatAppearance.BorderSize = 0;
            this.Btn_encryption2.Image = global::OutlookControll.Properties.Resources.btn_encrypt;
            this.Btn_encryption2.Location = new System.Drawing.Point(-1, 69);
            this.Btn_encryption2.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_encryption2.Name = "Btn_encryption2";
            this.Btn_encryption2.Size = new System.Drawing.Size(296, 69);
            this.Btn_encryption2.TabIndex = 4;
            this.Btn_encryption2.UseVisualStyleBackColor = true;
            this.Btn_encryption2.Click += new System.EventHandler(this.Btn_encryption2_Click);
            // 
            // Btn_standard
            // 
            this.Btn_standard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Btn_standard.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Btn_standard.FlatAppearance.BorderSize = 0;
            this.Btn_standard.ForeColor = System.Drawing.Color.Transparent;
            this.Btn_standard.Image = global::OutlookControll.Properties.Resources.btn_standard;
            this.Btn_standard.Location = new System.Drawing.Point(-1, 0);
            this.Btn_standard.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_standard.Name = "Btn_standard";
            this.Btn_standard.Size = new System.Drawing.Size(296, 69);
            this.Btn_standard.TabIndex = 3;
            this.Btn_standard.UseVisualStyleBackColor = true;
            this.Btn_standard.Click += new System.EventHandler(this.Btn_standard_Click);
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Location = new System.Drawing.Point(0, 72);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(0, 0);
            this.panel1.TabIndex = 6;
            this.panel1.Visible = false;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // ExpirationDateGroup
            // 
            this.ExpirationDateGroup.BackColor = System.Drawing.Color.Transparent;
            this.ExpirationDateGroup.Controls.Add(this.RB1);
            this.ExpirationDateGroup.Controls.Add(this.RB3);
            this.ExpirationDateGroup.Controls.Add(this.RB2);
            this.ExpirationDateGroup.Location = new System.Drawing.Point(3, 3);
            this.ExpirationDateGroup.Name = "ExpirationDateGroup";
            this.ExpirationDateGroup.Size = new System.Drawing.Size(208, 56);
            this.ExpirationDateGroup.TabIndex = 12;
            this.ExpirationDateGroup.TabStop = false;
            // 
            // RB1
            // 
            this.RB1.AutoSize = true;
            this.RB1.BackColor = System.Drawing.Color.Transparent;
            this.RB1.Checked = true;
            this.RB1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.RB1.Location = new System.Drawing.Point(6, 20);
            this.RB1.Name = "RB1";
            this.RB1.Size = new System.Drawing.Size(63, 20);
            this.RB1.TabIndex = 5;
            this.RB1.TabStop = true;
            this.RB1.Text = "1 den";
            this.RB1.UseVisualStyleBackColor = false;
            // 
            // RB3
            // 
            this.RB3.AutoSize = true;
            this.RB3.BackColor = System.Drawing.Color.Transparent;
            this.RB3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.RB3.Location = new System.Drawing.Point(139, 19);
            this.RB3.Name = "RB3";
            this.RB3.Size = new System.Drawing.Size(66, 20);
            this.RB3.TabIndex = 7;
            this.RB3.TabStop = true;
            this.RB3.Text = "30 dní";
            this.RB3.UseVisualStyleBackColor = false;
            // 
            // RB2
            // 
            this.RB2.AutoSize = true;
            this.RB2.BackColor = System.Drawing.Color.Transparent;
            this.RB2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.RB2.Location = new System.Drawing.Point(75, 20);
            this.RB2.Name = "RB2";
            this.RB2.Size = new System.Drawing.Size(58, 20);
            this.RB2.TabIndex = 6;
            this.RB2.TabStop = true;
            this.RB2.Text = "7 dní";
            this.RB2.UseVisualStyleBackColor = false;
            // 
            // txt_phone
            // 
            this.txt_phone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_phone.Location = new System.Drawing.Point(0, 62);
            this.txt_phone.Margin = new System.Windows.Forms.Padding(0);
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.Size = new System.Drawing.Size(273, 20);
            this.txt_phone.TabIndex = 11;
            // 
            // lbl_expiration
            // 
            this.lbl_expiration.AutoSize = true;
            this.lbl_expiration.BackColor = System.Drawing.Color.Transparent;
            this.lbl_expiration.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_expiration.Location = new System.Drawing.Point(3, 82);
            this.lbl_expiration.Name = "lbl_expiration";
            this.lbl_expiration.Size = new System.Drawing.Size(151, 16);
            this.lbl_expiration.TabIndex = 10;
            this.lbl_expiration.Text = "Doba platnosti přílohy";
            // 
            // lbl_phone
            // 
            this.lbl_phone.BackColor = System.Drawing.Color.Transparent;
            this.lbl_phone.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_phone.Location = new System.Drawing.Point(3, 98);
            this.lbl_phone.Name = "lbl_phone";
            this.lbl_phone.Size = new System.Drawing.Size(233, 32);
            this.lbl_phone.TabIndex = 9;
            this.lbl_phone.Text = "Zadejte mobilní číslo příjemce pro \r\nzaslání přístupového kódu";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(-1, 212);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(293, 165);
            this.flowLayoutPanel1.TabIndex = 7;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // AdvanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::OutlookControll.Properties.Resources.strom1;
            this.ClientSize = new System.Drawing.Size(295, 378);
            this.Controls.Add(this.Btn_cancel);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Btn_encryption2);
            this.Controls.Add(this.Btn_standard);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdvanceForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdvanceForm";
            this.ExpirationDateGroup.ResumeLayout(false);
            this.ExpirationDateGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_cancel;
        private System.Windows.Forms.Button Btn_encryption2;
        private System.Windows.Forms.Button Btn_standard;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox ExpirationDateGroup;
        private System.Windows.Forms.RadioButton RB1;
        private System.Windows.Forms.RadioButton RB3;
        private System.Windows.Forms.RadioButton RB2;
        private System.Windows.Forms.TextBox txt_phone;
        private System.Windows.Forms.Label lbl_expiration;
        private System.Windows.Forms.Label lbl_phone;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}