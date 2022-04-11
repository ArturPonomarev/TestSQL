
namespace TestSQL.Forms
{
    partial class ClientsChangeForm
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
            this.PhoneBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.FIOBox = new System.Windows.Forms.TextBox();
            this.ChangeButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.FIOLast = new System.Windows.Forms.Label();
            this.PhoneLast = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PhoneBox
            // 
            this.PhoneBox.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.PhoneBox.Location = new System.Drawing.Point(41, 179);
            this.PhoneBox.Name = "PhoneBox";
            this.PhoneBox.Size = new System.Drawing.Size(244, 29);
            this.PhoneBox.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Malgun Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(41, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(244, 38);
            this.label2.TabIndex = 25;
            this.label2.Text = "Телефон";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FIOBox
            // 
            this.FIOBox.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.FIOBox.Location = new System.Drawing.Point(12, 74);
            this.FIOBox.Name = "FIOBox";
            this.FIOBox.Size = new System.Drawing.Size(302, 29);
            this.FIOBox.TabIndex = 24;
            // 
            // ChangeButton
            // 
            this.ChangeButton.Font = new System.Drawing.Font("Malgun Gothic", 24F, System.Drawing.FontStyle.Bold);
            this.ChangeButton.Location = new System.Drawing.Point(12, 214);
            this.ChangeButton.Name = "ChangeButton";
            this.ChangeButton.Size = new System.Drawing.Size(302, 82);
            this.ChangeButton.TabIndex = 23;
            this.ChangeButton.Text = "Изменить запись";
            this.ChangeButton.UseVisualStyleBackColor = true;
            this.ChangeButton.Click += new System.EventHandler(this.ChangeButton_Click);
            this.ChangeButton.MouseEnter += new System.EventHandler(this.AddButton_MouseEnter);
            this.ChangeButton.MouseLeave += new System.EventHandler(this.AddButton_MouseLeave);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Malgun Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(302, 38);
            this.label1.TabIndex = 22;
            this.label1.Text = "ФИО";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FIOLast
            // 
            this.FIOLast.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FIOLast.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.FIOLast.Location = new System.Drawing.Point(12, 51);
            this.FIOLast.Name = "FIOLast";
            this.FIOLast.Size = new System.Drawing.Size(302, 20);
            this.FIOLast.TabIndex = 40;
            this.FIOLast.Text = "п. фио";
            this.FIOLast.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PhoneLast
            // 
            this.PhoneLast.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneLast.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.PhoneLast.Location = new System.Drawing.Point(41, 156);
            this.PhoneLast.Name = "PhoneLast";
            this.PhoneLast.Size = new System.Drawing.Size(244, 20);
            this.PhoneLast.TabIndex = 41;
            this.PhoneLast.Text = "п. телефон";
            this.PhoneLast.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ClientsChangeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 301);
            this.Controls.Add(this.PhoneLast);
            this.Controls.Add(this.FIOLast);
            this.Controls.Add(this.PhoneBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FIOBox);
            this.Controls.Add(this.ChangeButton);
            this.Controls.Add(this.label1);
            this.Name = "ClientsChangeForm";
            this.Text = "ClientsChangeForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ClientsChangeForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PhoneBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox FIOBox;
        private System.Windows.Forms.Button ChangeButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label FIOLast;
        private System.Windows.Forms.Label PhoneLast;
    }
}