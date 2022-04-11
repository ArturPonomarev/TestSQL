
namespace TestSQL.Forms
{
    partial class OrdersChangeForm
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
            this.ChangeButton = new System.Windows.Forms.Button();
            this.StateBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.StateLast = new System.Windows.Forms.Label();
            this.DateStartLabel = new System.Windows.Forms.Label();
            this.DateFinishBox = new System.Windows.Forms.DateTimePicker();
            this.TimeFinishBox = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // ChangeButton
            // 
            this.ChangeButton.Font = new System.Drawing.Font("Malgun Gothic", 24F, System.Drawing.FontStyle.Bold);
            this.ChangeButton.Location = new System.Drawing.Point(12, 269);
            this.ChangeButton.Name = "ChangeButton";
            this.ChangeButton.Size = new System.Drawing.Size(348, 64);
            this.ChangeButton.TabIndex = 23;
            this.ChangeButton.Text = "Изменить запись";
            this.ChangeButton.UseVisualStyleBackColor = true;
            this.ChangeButton.Click += new System.EventHandler(this.ChangeButton_Click);
            this.ChangeButton.MouseEnter += new System.EventHandler(this.ChangeButton_MouseEnter);
            this.ChangeButton.MouseLeave += new System.EventHandler(this.ChangeButton_MouseLeave);
            // 
            // StateBox
            // 
            this.StateBox.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.StateBox.FormattingEnabled = true;
            this.StateBox.Location = new System.Drawing.Point(105, 64);
            this.StateBox.Name = "StateBox";
            this.StateBox.Size = new System.Drawing.Size(164, 29);
            this.StateBox.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Malgun Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(79, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(218, 63);
            this.label4.TabIndex = 19;
            this.label4.Text = "ДатаВремя окончания";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Malgun Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(105, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 32);
            this.label2.TabIndex = 17;
            this.label2.Text = "Состояние";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StateLast
            // 
            this.StateLast.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StateLast.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.StateLast.Location = new System.Drawing.Point(106, 41);
            this.StateLast.Name = "StateLast";
            this.StateLast.Size = new System.Drawing.Size(164, 20);
            this.StateLast.TabIndex = 39;
            this.StateLast.Text = "п. состояние";
            this.StateLast.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DateStartLabel
            // 
            this.DateStartLabel.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateStartLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.DateStartLabel.Location = new System.Drawing.Point(80, 165);
            this.DateStartLabel.Name = "DateStartLabel";
            this.DateStartLabel.Size = new System.Drawing.Size(217, 20);
            this.DateStartLabel.TabIndex = 42;
            this.DateStartLabel.Text = "п. датавремяконца";
            this.DateStartLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DateFinishBox
            // 
            this.DateFinishBox.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.DateFinishBox.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateFinishBox.Location = new System.Drawing.Point(47, 188);
            this.DateFinishBox.Name = "DateFinishBox";
            this.DateFinishBox.Size = new System.Drawing.Size(278, 29);
            this.DateFinishBox.TabIndex = 43;
            // 
            // TimeFinishBox
            // 
            this.TimeFinishBox.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.TimeFinishBox.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.TimeFinishBox.Location = new System.Drawing.Point(47, 223);
            this.TimeFinishBox.Name = "TimeFinishBox";
            this.TimeFinishBox.Size = new System.Drawing.Size(278, 29);
            this.TimeFinishBox.TabIndex = 44;
            // 
            // OrdersChangeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 340);
            this.Controls.Add(this.TimeFinishBox);
            this.Controls.Add(this.DateFinishBox);
            this.Controls.Add(this.DateStartLabel);
            this.Controls.Add(this.StateLast);
            this.Controls.Add(this.ChangeButton);
            this.Controls.Add(this.StateBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Name = "OrdersChangeForm";
            this.Text = "Изменение данных: Заказ";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OrdersChangeForm_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button ChangeButton;
        private System.Windows.Forms.ComboBox StateBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label StateLast;
        private System.Windows.Forms.Label DateStartLabel;
        private System.Windows.Forms.DateTimePicker DateFinishBox;
        private System.Windows.Forms.DateTimePicker TimeFinishBox;
    }
}