
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
            this.ChangeButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.ColorBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.NumberBox = new System.Windows.Forms.TextBox();
            this.Number = new System.Windows.Forms.Label();
            this.NumberLast = new System.Windows.Forms.Label();
            this.StateLast = new System.Windows.Forms.Label();
            this.ColorLast = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // StateBox
            // 
            this.StateBox.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.StateBox.FormattingEnabled = true;
            this.StateBox.Location = new System.Drawing.Point(26, 162);
            this.StateBox.Name = "StateBox";
            this.StateBox.Size = new System.Drawing.Size(139, 29);
            this.StateBox.TabIndex = 36;
            // 
            // ChangeButton
            // 
            this.ChangeButton.Font = new System.Drawing.Font("Malgun Gothic", 24F, System.Drawing.FontStyle.Bold);
            this.ChangeButton.Location = new System.Drawing.Point(26, 215);
            this.ChangeButton.Name = "ChangeButton";
            this.ChangeButton.Size = new System.Drawing.Size(313, 65);
            this.ChangeButton.TabIndex = 32;
            this.ChangeButton.Text = "Изменить запись\r\n";
            this.ChangeButton.UseVisualStyleBackColor = true;
            this.ChangeButton.Click += new System.EventHandler(this.ChangeButton_Click);
            this.ChangeButton.MouseEnter += new System.EventHandler(this.ChangeButton_MouseEnter);
            this.ChangeButton.MouseLeave += new System.EventHandler(this.ChangeButton_MouseLeave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Malgun Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(233, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 30);
            this.label4.TabIndex = 30;
            this.label4.Text = "Цвет";
            // 
            // ColorBox
            // 
            this.ColorBox.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.ColorBox.Location = new System.Drawing.Point(200, 162);
            this.ColorBox.Name = "ColorBox";
            this.ColorBox.Size = new System.Drawing.Size(139, 29);
            this.ColorBox.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Malgun Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(26, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 30);
            this.label2.TabIndex = 26;
            this.label2.Text = "Состояние";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NumberBox
            // 
            this.NumberBox.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.NumberBox.Location = new System.Drawing.Point(27, 63);
            this.NumberBox.Name = "NumberBox";
            this.NumberBox.Size = new System.Drawing.Size(313, 29);
            this.NumberBox.TabIndex = 24;
            // 
            // Number
            // 
            this.Number.AutoSize = true;
            this.Number.Font = new System.Drawing.Font("Malgun Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.Number.Location = new System.Drawing.Point(115, 9);
            this.Number.Name = "Number";
            this.Number.Size = new System.Drawing.Size(134, 30);
            this.Number.TabIndex = 23;
            this.Number.Text = "Гос. номер\r\n";
            // 
            // NumberLast
            // 
            this.NumberLast.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumberLast.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.NumberLast.Location = new System.Drawing.Point(27, 39);
            this.NumberLast.Name = "NumberLast";
            this.NumberLast.Size = new System.Drawing.Size(313, 20);
            this.NumberLast.TabIndex = 39;
            this.NumberLast.Text = "п. номер";
            this.NumberLast.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StateLast
            // 
            this.StateLast.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StateLast.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.StateLast.Location = new System.Drawing.Point(26, 139);
            this.StateLast.Name = "StateLast";
            this.StateLast.Size = new System.Drawing.Size(139, 20);
            this.StateLast.TabIndex = 41;
            this.StateLast.Text = "п. состояние";
            this.StateLast.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ColorLast
            // 
            this.ColorLast.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ColorLast.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ColorLast.Location = new System.Drawing.Point(199, 139);
            this.ColorLast.Name = "ColorLast";
            this.ColorLast.Size = new System.Drawing.Size(140, 20);
            this.ColorLast.TabIndex = 43;
            this.ColorLast.Text = "п. цвет";
            this.ColorLast.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AutomobileChangeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 289);
            this.Controls.Add(this.ColorLast);
            this.Controls.Add(this.StateLast);
            this.Controls.Add(this.NumberLast);
            this.Controls.Add(this.StateBox);
            this.Controls.Add(this.ChangeButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ColorBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NumberBox);
            this.Controls.Add(this.Number);
            this.Name = "AutomobileChangeForm";
            this.Text = "Изменение данных: Автомобиль";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AutomobileChangeForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox StateBox;
        private System.Windows.Forms.Button ChangeButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ColorBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NumberBox;
        private System.Windows.Forms.Label Number;
        private System.Windows.Forms.Label NumberLast;
        private System.Windows.Forms.Label StateLast;
        private System.Windows.Forms.Label ColorLast;
    }
}