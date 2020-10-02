using System.Windows.Forms;

namespace OutlookControll
{
    partial class Form1
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
            this.Btn_cancel = new System.Windows.Forms.Button();
            this.Btn_encryption = new System.Windows.Forms.Button();
            this.Btn_standard = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn_cancel
            // 
            this.Btn_cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Btn_cancel.FlatAppearance.BorderSize = 0;
            this.Btn_cancel.Image = global::OutlookControll.Properties.Resources.btn_cancel;
            this.Btn_cancel.Location = new System.Drawing.Point(0, 136);
            this.Btn_cancel.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_cancel.Name = "Btn_cancel";
            this.Btn_cancel.Size = new System.Drawing.Size(296, 69);
            this.Btn_cancel.TabIndex = 2;
            this.Btn_cancel.UseVisualStyleBackColor = true;
            this.Btn_cancel.Click += new System.EventHandler(this.Btn_cancel_Click);
            // 
            // Btn_encryption
            // 
            this.Btn_encryption.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Btn_encryption.FlatAppearance.BorderSize = 0;
            this.Btn_encryption.Image = global::OutlookControll.Properties.Resources.btn_encrypt;
            this.Btn_encryption.Location = new System.Drawing.Point(0, 68);
            this.Btn_encryption.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_encryption.Name = "Btn_encryption";
            this.Btn_encryption.Size = new System.Drawing.Size(296, 69);
            this.Btn_encryption.TabIndex = 1;
            this.Btn_encryption.UseVisualStyleBackColor = true;
            this.Btn_encryption.Click += new System.EventHandler(this.Btn_encryption_Click);
            // 
            // Btn_standard
            // 
            this.Btn_standard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Btn_standard.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Btn_standard.FlatAppearance.BorderSize = 0;
            this.Btn_standard.ForeColor = System.Drawing.Color.Transparent;
            this.Btn_standard.Image = global::OutlookControll.Properties.Resources.btn_standard;
            this.Btn_standard.Location = new System.Drawing.Point(0, 0);
            this.Btn_standard.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_standard.Name = "Btn_standard";
            this.Btn_standard.Size = new System.Drawing.Size(296, 69);
            this.Btn_standard.TabIndex = 0;
            this.Btn_standard.UseVisualStyleBackColor = true;
            this.Btn_standard.Click += new System.EventHandler(this.Btn_standard_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 204);
            this.Controls.Add(this.Btn_cancel);
            this.Controls.Add(this.Btn_encryption);
            this.Controls.Add(this.Btn_standard);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jak odeslat e-mail ?";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_standard;
        private System.Windows.Forms.Button Btn_encryption;
        private System.Windows.Forms.Button Btn_cancel;
    }

}

