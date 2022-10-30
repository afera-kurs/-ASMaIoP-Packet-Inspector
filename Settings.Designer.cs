namespace LowLevelClientPacket
{
    partial class Settings
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
            this.Address_TextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Connect_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Address_TextBox
            // 
            this.Address_TextBox.Location = new System.Drawing.Point(58, 12);
            this.Address_TextBox.Name = "Address_TextBox";
            this.Address_TextBox.Size = new System.Drawing.Size(189, 23);
            this.Address_TextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Адрес";
            // 
            // Connect_Button
            // 
            this.Connect_Button.Location = new System.Drawing.Point(12, 41);
            this.Connect_Button.Name = "Connect_Button";
            this.Connect_Button.Size = new System.Drawing.Size(235, 23);
            this.Connect_Button.TabIndex = 4;
            this.Connect_Button.Text = "Применить";
            this.Connect_Button.UseVisualStyleBackColor = true;
            this.Connect_Button.Click += new System.EventHandler(this.Connect_Button_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 72);
            this.Controls.Add(this.Connect_Button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Address_TextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Settings";
            this.Text = "Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox Address_TextBox;
        private Label label1;
        private Button Connect_Button;
    }
}