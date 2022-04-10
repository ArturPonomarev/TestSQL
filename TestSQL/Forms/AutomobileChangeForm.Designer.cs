
namespace TestSQL.Forms
{
    partial class AutomobileChangeForm
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
            this.StateBox = new System.Windows.Forms.ComboBox();
            this.KyzovBox = new System.Windows.Forms.ComboBox();
            this.ModelBox = new System.Windows.Forms.ComboBox();
            this.MarkaBox = new System.Windows.Forms.ComboBox();
            this.ChangeButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CapacityBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ColorBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.NumberBox = new System.Windows.Forms.TextBox();
            this.Number = new System.Windows.Forms.Label();
            this.MarkaLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // StateBox
            // 
            this.StateBox.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.StateBox.FormattingEnabled = true;
            this.StateBox.Location = new System.Drawing.Point(203, 208);
            this.StateBox.Name = "StateBox";
            this.StateBox.Size = new System.Drawing.Size(139, 29);
            this.StateBox.TabIndex = 36;
            // 
            // KyzovBox
            // 
            this.KyzovBox.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.KyzovBox.FormattingEnabled = true;
            this.KyzovBox.Items.AddRange(new object[] {
            "СЕДАН",
            "УНИВЕРСАЛ",
            "ХЭТЧБЕК"});
            this.KyzovBox.Location = new System.Drawing.Point(29, 208);
            this.KyzovBox.Name = "KyzovBox";
            this.KyzovBox.Size = new System.Drawing.Size(139, 29);
            this.KyzovBox.TabIndex = 35;
            // 
            // ModelBox
            // 
            this.ModelBox.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.ModelBox.FormattingEnabled = true;
            this.ModelBox.Location = new System.Drawing.Point(203, 54);
            this.ModelBox.Name = "ModelBox";
            this.ModelBox.Size = new System.Drawing.Size(139, 29);
            this.ModelBox.TabIndex = 34;
            // 
            // MarkaBox
            // 
            this.MarkaBox.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.MarkaBox.FormattingEnabled = true;
            this.MarkaBox.Items.AddRange(new object[] {
            "SUBARU",
            "FORD",
            "AUDI",
            "LADA",
            "BMW"});
            this.MarkaBox.Location = new System.Drawing.Point(29, 54);
            this.MarkaBox.Name = "MarkaBox";
            this.MarkaBox.Size = new System.Drawing.Size(139, 29);
            this.MarkaBox.TabIndex = 33;
            this.MarkaBox.SelectionChangeCommitted += new System.EventHandler(this.MarkaBox_SelectionChangeCommitted);
            // 
            // ChangeButton
            // 
            this.ChangeButton.Font = new System.Drawing.Font("Malgun Gothic", 24F, System.Drawing.FontStyle.Bold);
            this.ChangeButton.Location = new System.Drawing.Point(37, 333);
            this.ChangeButton.Name = "ChangeButton";
            this.ChangeButton.Size = new System.Drawing.Size(301, 100);
            this.ChangeButton.TabIndex = 32;
            this.ChangeButton.Text = "Изменить запись\r\n";
            this.ChangeButton.UseVisualStyleBackColor = true;
            this.ChangeButton.Click += new System.EventHandler(this.ChangeButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Malgun Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(224, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 30);
            this.label5.TabIndex = 31;
            this.label5.Text = "Модель";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Malgun Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(241, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 30);
            this.label4.TabIndex = 30;
            this.label4.Text = "Цвет";
            // 
            // CapacityBox
            // 
            this.CapacityBox.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.CapacityBox.Location = new System.Drawing.Point(29, 286);
            this.CapacityBox.Name = "CapacityBox";
            this.CapacityBox.Size = new System.Drawing.Size(139, 29);
            this.CapacityBox.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Malgun Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(24, 253);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 30);
            this.label3.TabIndex = 28;
            this.label3.Text = "Вместимость";
            // 
            // ColorBox
            // 
            this.ColorBox.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.ColorBox.Location = new System.Drawing.Point(203, 286);
            this.ColorBox.Name = "ColorBox";
            this.ColorBox.Size = new System.Drawing.Size(139, 29);
            this.ColorBox.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Malgun Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(212, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 30);
            this.label2.TabIndex = 26;
            this.label2.Text = "Состояние";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Malgun Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(32, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 30);
            this.label1.TabIndex = 25;
            this.label1.Text = "Тип кузова";
            // 
            // NumberBox
            // 
            this.NumberBox.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.NumberBox.Location = new System.Drawing.Point(29, 119);
            this.NumberBox.Name = "NumberBox";
            this.NumberBox.Size = new System.Drawing.Size(313, 29);
            this.NumberBox.TabIndex = 24;
            // 
            // Number
            // 
            this.Number.AutoSize = true;
            this.Number.Font = new System.Drawing.Font("Malgun Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.Number.Location = new System.Drawing.Point(113, 86);
            this.Number.Name = "Number";
            this.Number.Size = new System.Drawing.Size(134, 30);
            this.Number.TabIndex = 23;
            this.Number.Text = "Гос. номер\r\n";
            // 
            // MarkaLabel
            // 
            this.MarkaLabel.AutoSize = true;
            this.MarkaLabel.Font = new System.Drawing.Font("Malgun Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.MarkaLabel.Location = new System.Drawing.Point(59, 20);
            this.MarkaLabel.Name = "MarkaLabel";
            this.MarkaLabel.Size = new System.Drawing.Size(84, 30);
            this.MarkaLabel.TabIndex = 22;
            this.MarkaLabel.Text = "Марка";
            // 
            // AutomobileChangeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 445);
            this.Controls.Add(this.StateBox);
            this.Controls.Add(this.KyzovBox);
            this.Controls.Add(this.ModelBox);
            this.Controls.Add(this.MarkaBox);
            this.Controls.Add(this.ChangeButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CapacityBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ColorBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NumberBox);
            this.Controls.Add(this.Number);
            this.Controls.Add(this.MarkaLabel);
            this.Name = "AutomobileChangeForm";
            this.Text = "Изменение данных: Автомобиль";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AutomobileChangeForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox StateBox;
        private System.Windows.Forms.ComboBox KyzovBox;
        private System.Windows.Forms.ComboBox ModelBox;
        private System.Windows.Forms.ComboBox MarkaBox;
        private System.Windows.Forms.Button ChangeButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox CapacityBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ColorBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NumberBox;
        private System.Windows.Forms.Label Number;
        private System.Windows.Forms.Label MarkaLabel;
    }
}