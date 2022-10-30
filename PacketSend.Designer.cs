namespace LowLevelClientPacket
{
    partial class PacketSend
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
            this.PacketType_TextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DataTypes_ComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Data_TextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SetupPacketType_button = new System.Windows.Forms.Button();
            this.AddData_button = new System.Windows.Forms.Button();
            this.Send_button = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.Key_TextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Encrypt_button = new System.Windows.Forms.Button();
            this.PacketShow_textBox = new System.Windows.Forms.TextBox();
            this.Clear_button = new System.Windows.Forms.Button();
            this.SavePacket = new System.Windows.Forms.Button();
            this.Load_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PacketType_TextBox
            // 
            this.PacketType_TextBox.Location = new System.Drawing.Point(84, 12);
            this.PacketType_TextBox.Name = "PacketType_TextBox";
            this.PacketType_TextBox.Size = new System.Drawing.Size(203, 23);
            this.PacketType_TextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Тип пакета";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Добавить данные";
            // 
            // DataTypes_ComboBox
            // 
            this.DataTypes_ComboBox.FormattingEnabled = true;
            this.DataTypes_ComboBox.Items.AddRange(new object[] {
            "string",
            "int",
            "byte"});
            this.DataTypes_ComboBox.Location = new System.Drawing.Point(89, 117);
            this.DataTypes_ComboBox.Name = "DataTypes_ComboBox";
            this.DataTypes_ComboBox.Size = new System.Drawing.Size(198, 23);
            this.DataTypes_ComboBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Тип данных";
            // 
            // Data_TextBox
            // 
            this.Data_TextBox.Location = new System.Drawing.Point(12, 168);
            this.Data_TextBox.Multiline = true;
            this.Data_TextBox.Name = "Data_TextBox";
            this.Data_TextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.Data_TextBox.Size = new System.Drawing.Size(275, 84);
            this.Data_TextBox.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Данные";
            // 
            // SetupPacketType_button
            // 
            this.SetupPacketType_button.Location = new System.Drawing.Point(12, 41);
            this.SetupPacketType_button.Name = "SetupPacketType_button";
            this.SetupPacketType_button.Size = new System.Drawing.Size(275, 23);
            this.SetupPacketType_button.TabIndex = 7;
            this.SetupPacketType_button.Text = "Установить";
            this.SetupPacketType_button.UseVisualStyleBackColor = true;
            this.SetupPacketType_button.Click += new System.EventHandler(this.SetupPacketType_button_Click);
            // 
            // AddData_button
            // 
            this.AddData_button.Location = new System.Drawing.Point(12, 258);
            this.AddData_button.Name = "AddData_button";
            this.AddData_button.Size = new System.Drawing.Size(275, 23);
            this.AddData_button.TabIndex = 8;
            this.AddData_button.Text = "Добавить";
            this.AddData_button.UseVisualStyleBackColor = true;
            this.AddData_button.Click += new System.EventHandler(this.AddData_button_Click);
            // 
            // Send_button
            // 
            this.Send_button.BackColor = System.Drawing.Color.Gray;
            this.Send_button.Location = new System.Drawing.Point(12, 421);
            this.Send_button.Name = "Send_button";
            this.Send_button.Size = new System.Drawing.Size(275, 58);
            this.Send_button.TabIndex = 9;
            this.Send_button.Text = "Отправить";
            this.Send_button.UseVisualStyleBackColor = false;
            this.Send_button.Click += new System.EventHandler(this.Send_button_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 316);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Ключ шифрования";
            // 
            // Key_TextBox
            // 
            this.Key_TextBox.Location = new System.Drawing.Point(12, 334);
            this.Key_TextBox.Name = "Key_TextBox";
            this.Key_TextBox.Size = new System.Drawing.Size(275, 23);
            this.Key_TextBox.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(12, 284);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(161, 32);
            this.label6.TabIndex = 12;
            this.label6.Text = "Шифрование";
            // 
            // Encrypt_button
            // 
            this.Encrypt_button.Location = new System.Drawing.Point(12, 363);
            this.Encrypt_button.Name = "Encrypt_button";
            this.Encrypt_button.Size = new System.Drawing.Size(275, 23);
            this.Encrypt_button.TabIndex = 13;
            this.Encrypt_button.Text = "Зашифровать";
            this.Encrypt_button.UseVisualStyleBackColor = true;
            this.Encrypt_button.Click += new System.EventHandler(this.Encrypt_button_Click);
            // 
            // PacketShow_textBox
            // 
            this.PacketShow_textBox.Location = new System.Drawing.Point(306, 8);
            this.PacketShow_textBox.Multiline = true;
            this.PacketShow_textBox.Name = "PacketShow_textBox";
            this.PacketShow_textBox.ReadOnly = true;
            this.PacketShow_textBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.PacketShow_textBox.Size = new System.Drawing.Size(167, 519);
            this.PacketShow_textBox.TabIndex = 14;
            // 
            // Clear_button
            // 
            this.Clear_button.Location = new System.Drawing.Point(12, 392);
            this.Clear_button.Name = "Clear_button";
            this.Clear_button.Size = new System.Drawing.Size(275, 23);
            this.Clear_button.TabIndex = 15;
            this.Clear_button.Text = "очистить все";
            this.Clear_button.UseVisualStyleBackColor = true;
            this.Clear_button.Click += new System.EventHandler(this.Clear_button_Click);
            // 
            // SavePacket
            // 
            this.SavePacket.Location = new System.Drawing.Point(12, 485);
            this.SavePacket.Name = "SavePacket";
            this.SavePacket.Size = new System.Drawing.Size(275, 23);
            this.SavePacket.TabIndex = 16;
            this.SavePacket.Text = "Сохранить текщший пакет";
            this.SavePacket.UseVisualStyleBackColor = true;
            this.SavePacket.Click += new System.EventHandler(this.SavePacket_Click);
            // 
            // Load_button
            // 
            this.Load_button.Location = new System.Drawing.Point(12, 514);
            this.Load_button.Name = "Load_button";
            this.Load_button.Size = new System.Drawing.Size(275, 23);
            this.Load_button.TabIndex = 17;
            this.Load_button.Text = "Загрузить";
            this.Load_button.UseVisualStyleBackColor = true;
            this.Load_button.Click += new System.EventHandler(this.Load_button_Click);
            // 
            // PacketSend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 539);
            this.Controls.Add(this.Load_button);
            this.Controls.Add(this.SavePacket);
            this.Controls.Add(this.Clear_button);
            this.Controls.Add(this.PacketShow_textBox);
            this.Controls.Add(this.Encrypt_button);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Key_TextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Send_button);
            this.Controls.Add(this.AddData_button);
            this.Controls.Add(this.SetupPacketType_button);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Data_TextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DataTypes_ComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PacketType_TextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "PacketSend";
            this.Text = "Отправить пакет";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox PacketType_TextBox;
        private Label label1;
        private Label label2;
        private ComboBox DataTypes_ComboBox;
        private Label label3;
        private TextBox Data_TextBox;
        private Label label4;
        private Button SetupPacketType_button;
        private Button AddData_button;
        private Button Send_button;
        private Label label5;
        private TextBox Key_TextBox;
        private Label label6;
        private Button Encrypt_button;
        private TextBox PacketShow_textBox;
        private Button Clear_button;
        private Button SavePacket;
        private Button Load_button;
    }
}