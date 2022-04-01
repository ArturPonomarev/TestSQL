
namespace TestSQL.Forms
{
    partial class OrdersAddForm
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
            this.PriceBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DataStartBox = new System.Windows.Forms.TextBox();
            this.DataFinishBox = new System.Windows.Forms.TextBox();
            this.StateBox = new System.Windows.Forms.ComboBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Malgun Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(25, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Стоимость";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PriceBox
            // 
            this.PriceBox.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.PriceBox.Location = new System.Drawing.Point(12, 78);
            this.PriceBox.Name = "PriceBox";
            this.PriceBox.Size = new System.Drawing.Size(164, 29);
            this.PriceBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Malgun Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(264, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "Состояние";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Malgun Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(109, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(218, 32);
            this.label3.TabIndex = 5;
            this.label3.Text = "ДатаВремя начала";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Malgun Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(84, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(272, 38);
            this.label4.TabIndex = 6;
            this.label4.Text = "ДатаВремя окончания";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DataStartBox
            // 
            this.DataStartBox.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.DataStartBox.Location = new System.Drawing.Point(109, 174);
            this.DataStartBox.Name = "DataStartBox";
            this.DataStartBox.Size = new System.Drawing.Size(218, 29);
            this.DataStartBox.TabIndex = 7;
            // 
            // DataFinishBox
            // 
            this.DataFinishBox.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.DataFinishBox.Location = new System.Drawing.Point(109, 262);
            this.DataFinishBox.Name = "DataFinishBox";
            this.DataFinishBox.Size = new System.Drawing.Size(218, 29);
            this.DataFinishBox.TabIndex = 8;
            // 
            // StateBox
            // 
            this.StateBox.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.StateBox.FormattingEnabled = true;
            this.StateBox.Items.AddRange(new object[] {
            "Выполнен",
            "Выполняется",
            "Не выполнен",
            "Отменен"});
            this.StateBox.Location = new System.Drawing.Point(264, 78);
            this.StateBox.Name = "StateBox";
            this.StateBox.Size = new System.Drawing.Size(164, 29);
            this.StateBox.TabIndex = 9;
            // 
            // AddButton
            // 
            this.AddButton.Font = new System.Drawing.Font("Malgun Gothic", 24F, System.Drawing.FontStyle.Bold);
            this.AddButton.Location = new System.Drawing.Point(47, 346);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(348, 64);
            this.AddButton.TabIndex = 10;
            this.AddButton.Text = "Добавить запись";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            this.AddButton.MouseEnter += new System.EventHandler(this.AddButton_MouseEnter);
            this.AddButton.MouseLeave += new System.EventHandler(this.AddButton_MouseLeave);
            // 
            // OrdersAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 450);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.StateBox);
            this.Controls.Add(this.DataFinishBox);
            this.Controls.Add(this.DataStartBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PriceBox);
            this.Controls.Add(this.label1);
            this.Name = "OrdersAddForm";
            this.Text = "Добавить запись";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OrdersAddForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox DataStartBox;
        private System.Windows.Forms.TextBox DataFinishBox;
        private System.Windows.Forms.ComboBox StateBox;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.TextBox PriceBox;
    }
}