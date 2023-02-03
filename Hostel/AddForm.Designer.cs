namespace Hostel
{
    partial class AddForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ClientSurName = new System.Windows.Forms.TextBox();
            this.ClientName = new System.Windows.Forms.TextBox();
            this.ClientLastName = new System.Windows.Forms.TextBox();
            this.ClientBDay = new System.Windows.Forms.DateTimePicker();
            this.GetFloor = new System.Windows.Forms.ComboBox();
            this.GetSizeOfRoom = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Фамилия";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(427, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Этаж";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Дата рождения";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Отчество";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Имя";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(427, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Размер номера";
            // 
            // ClientSurName
            // 
            this.ClientSurName.Location = new System.Drawing.Point(25, 47);
            this.ClientSurName.Name = "ClientSurName";
            this.ClientSurName.Size = new System.Drawing.Size(154, 22);
            this.ClientSurName.TabIndex = 6;
            this.ClientSurName.TextChanged += new System.EventHandler(this.ClientSurName_TextChanged);
            // 
            // ClientName
            // 
            this.ClientName.Location = new System.Drawing.Point(25, 112);
            this.ClientName.Name = "ClientName";
            this.ClientName.Size = new System.Drawing.Size(154, 22);
            this.ClientName.TabIndex = 7;
            // 
            // ClientLastName
            // 
            this.ClientLastName.Location = new System.Drawing.Point(25, 181);
            this.ClientLastName.Name = "ClientLastName";
            this.ClientLastName.Size = new System.Drawing.Size(154, 22);
            this.ClientLastName.TabIndex = 8;
            // 
            // ClientBDay
            // 
            this.ClientBDay.CustomFormat = "dd-MM-yyyy HH:mm";
            this.ClientBDay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ClientBDay.Location = new System.Drawing.Point(25, 264);
            this.ClientBDay.Name = "ClientBDay";
            this.ClientBDay.Size = new System.Drawing.Size(200, 22);
            this.ClientBDay.TabIndex = 9;
            // 
            // GetFloor
            // 
            this.GetFloor.FormattingEnabled = true;
            this.GetFloor.Location = new System.Drawing.Point(430, 45);
            this.GetFloor.Name = "GetFloor";
            this.GetFloor.Size = new System.Drawing.Size(121, 24);
            this.GetFloor.TabIndex = 10;
            this.GetFloor.SelectedIndexChanged += new System.EventHandler(this.GetFloor_SelectedIndexChanged);
            // 
            // GetSizeOfRoom
            // 
            this.GetSizeOfRoom.FormattingEnabled = true;
            this.GetSizeOfRoom.Location = new System.Drawing.Point(430, 112);
            this.GetSizeOfRoom.Name = "GetSizeOfRoom";
            this.GetSizeOfRoom.Size = new System.Drawing.Size(121, 24);
            this.GetSizeOfRoom.TabIndex = 11;
            this.GetSizeOfRoom.SelectedIndexChanged += new System.EventHandler(this.GetSizeOfRoom_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(430, 199);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(720, 293);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(83, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "Выход";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1166, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.GetSizeOfRoom);
            this.Controls.Add(this.GetFloor);
            this.Controls.Add(this.ClientBDay);
            this.Controls.Add(this.ClientLastName);
            this.Controls.Add(this.ClientName);
            this.Controls.Add(this.ClientSurName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddForm";
            this.Text = "AddForm";
            this.Load += new System.EventHandler(this.AddForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ClientSurName;
        private System.Windows.Forms.TextBox ClientName;
        private System.Windows.Forms.TextBox ClientLastName;
        private System.Windows.Forms.DateTimePicker ClientBDay;
        private System.Windows.Forms.ComboBox GetFloor;
        private System.Windows.Forms.ComboBox GetSizeOfRoom;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}