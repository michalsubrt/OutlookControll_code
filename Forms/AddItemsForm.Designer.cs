namespace OutlookControll
{
    partial class AddItemsForm
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
            this.btn_cancel_encrypt = new System.Windows.Forms.Button();
            this.btn_send_ecrypt = new System.Windows.Forms.Button();
            this.lbl_phone = new System.Windows.Forms.Label();
            this.lbl_expiration = new System.Windows.Forms.Label();
            this.txt_phone = new System.Windows.Forms.TextBox();
            this.RB1 = new System.Windows.Forms.RadioButton();
            this.RB2 = new System.Windows.Forms.RadioButton();
            this.RB3 = new System.Windows.Forms.RadioButton();
            this.ExpirationDateGroup = new System.Windows.Forms.GroupBox();
            this.ExpirationDateGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_cancel_encrypt
            // 
            this.btn_cancel_encrypt.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_cancel_encrypt.Image = global::OutlookControll.Properties.Resources.btn_cancel;
            this.btn_cancel_encrypt.Location = new System.Drawing.Point(0, 272);
            this.btn_cancel_encrypt.Margin = new System.Windows.Forms.Padding(0);
            this.btn_cancel_encrypt.Name = "btn_cancel_encrypt";
            this.btn_cancel_encrypt.Size = new System.Drawing.Size(296, 69);
            this.btn_cancel_encrypt.TabIndex = 1;
            this.btn_cancel_encrypt.UseVisualStyleBackColor = false;
            this.btn_cancel_encrypt.Click += new System.EventHandler(this.Btn_cancel_encrypt_Click);
            // 
            // btn_send_ecrypt
            // 
            this.btn_send_ecrypt.BackColor = System.Drawing.Color.Transparent;
            this.btn_send_ecrypt.BackgroundImage = global::OutlookControll.Properties.Resources.btn_encrypt;
            this.btn_send_ecrypt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_send_ecrypt.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_send_ecrypt.Location = new System.Drawing.Point(0, 203);
            this.btn_send_ecrypt.Margin = new System.Windows.Forms.Padding(0);
            this.btn_send_ecrypt.Name = "btn_send_ecrypt";
            this.btn_send_ecrypt.Size = new System.Drawing.Size(296, 69);
            this.btn_send_ecrypt.TabIndex = 0;
            this.btn_send_ecrypt.UseVisualStyleBackColor = false;
            this.btn_send_ecrypt.Click += new System.EventHandler(this.Btn_send_ecrypt_Click);
            // 
            // lbl_phone
            // 
            this.lbl_phone.AutoSize = true;
            this.lbl_phone.BackColor = System.Drawing.Color.Transparent;
            this.lbl_phone.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_phone.Location = new System.Drawing.Point(14, 9);
            this.lbl_phone.Name = "lbl_phone";
            this.lbl_phone.Size = new System.Drawing.Size(233, 32);
            this.lbl_phone.TabIndex = 2;
            this.lbl_phone.Text = "Zadejte mobilní číslo příjemce pro \r\nzaslání přístupového kódu";
            // 
            // lbl_expiration
            // 
            this.lbl_expiration.AutoSize = true;
            this.lbl_expiration.BackColor = System.Drawing.Color.Transparent;
            this.lbl_expiration.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_expiration.Location = new System.Drawing.Point(13, 92);
            this.lbl_expiration.Name = "lbl_expiration";
            this.lbl_expiration.Size = new System.Drawing.Size(151, 16);
            this.lbl_expiration.TabIndex = 3;
            this.lbl_expiration.Text = "Doba platnosti přílohy";
            // 
            // txt_phone
            // 
            this.txt_phone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_phone.Location = new System.Drawing.Point(13, 54);
            this.txt_phone.Margin = new System.Windows.Forms.Padding(0);
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.Size = new System.Drawing.Size(273, 20);
            this.txt_phone.TabIndex = 4;
            this.txt_phone.TextChanged += new System.EventHandler(this.Txt_phone_text);
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
            this.RB1.CheckedChanged += new System.EventHandler(this.RB1_CheckedChanged);
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
            this.RB2.CheckedChanged += new System.EventHandler(this.RB2_CheckedChanged);
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
            this.RB3.CheckedChanged += new System.EventHandler(this.RB3_CheckedChanged);
            // 
            // ExpirationDateGroup
            // 
            this.ExpirationDateGroup.BackColor = System.Drawing.Color.Transparent;
            this.ExpirationDateGroup.Controls.Add(this.RB1);
            this.ExpirationDateGroup.Controls.Add(this.RB3);
            this.ExpirationDateGroup.Controls.Add(this.RB2);
            this.ExpirationDateGroup.Location = new System.Drawing.Point(16, 111);
            this.ExpirationDateGroup.Name = "ExpirationDateGroup";
            this.ExpirationDateGroup.Size = new System.Drawing.Size(208, 56);
            this.ExpirationDateGroup.TabIndex = 8;
            this.ExpirationDateGroup.TabStop = false;
            this.ExpirationDateGroup.Enter += new System.EventHandler(this.ExpirationDateGroup_Enter);
            // 
            // AddItemsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::OutlookControll.Properties.Resources.strom1;
            this.ClientSize = new System.Drawing.Size(297, 341);
            this.Controls.Add(this.ExpirationDateGroup);
            this.Controls.Add(this.txt_phone);
            this.Controls.Add(this.lbl_expiration);
            this.Controls.Add(this.lbl_phone);
            this.Controls.Add(this.btn_cancel_encrypt);
            this.Controls.Add(this.btn_send_ecrypt);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddItemsForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodatečné informace k odeslaní";
            this.ExpirationDateGroup.ResumeLayout(false);
            this.ExpirationDateGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_send_ecrypt;
        private System.Windows.Forms.Button btn_cancel_encrypt;
        private System.Windows.Forms.Label lbl_phone;
        private System.Windows.Forms.Label lbl_expiration;
        private System.Windows.Forms.TextBox txt_phone;
        private System.Windows.Forms.RadioButton RB1;
        private System.Windows.Forms.RadioButton RB2;
        private System.Windows.Forms.RadioButton RB3;
        private System.Windows.Forms.GroupBox ExpirationDateGroup;
    }
}