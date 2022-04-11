
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
            this.AddButton = new System.Windows.Forms.Button();
            this.ClientBox = new System.Windows.Forms.ComboBox();
            this.AutoBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Malgun Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(81, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Стоимость";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PriceBox
            // 
            this.PriceBox.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.PriceBox.Location = new System.Drawing.Point(106, 44);
            this.PriceBox.Name = "PriceBox";
            this.PriceBox.Size = new System.Drawing.Size(164, 29);
            this.PriceBox.TabIndex = 2;
            // 
            // AddButton
            // 
            this.AddButton.Font = new System.Drawing.Font("Malgun Gothic", 24F, System.Drawing.FontStyle.Bold);
            this.AddButton.Location = new System.Drawing.Point(13, 243);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(348, 64);
            this.AddButton.TabIndex = 10;
            this.AddButton.Text = "Добавить запись";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            this.AddButton.MouseEnter += new System.EventHandler(this.AddButton_MouseEnter);
            this.AddButton.MouseLeave += new System.EventHandler(this.AddButton_MouseLeave);
            // 
            // ClientBox
            // 
            this.ClientBox.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.ClientBox.FormattingEnabled = true;
            this.ClientBox.Items.AddRange(new object[] {
            "Выполнен",
            "Выполняется",
            "Не выполнен",
            "Отменен"});
            this.ClientBox.Location = new System.Drawing.Point(81, 117);
            this.ClientBox.Name = "ClientBox";
            this.ClientBox.Size = new System.Drawing.Size(214, 29);
            this.ClientBox.TabIndex = 11;
            // 
            // AutoBox
            // 
            this.AutoBox.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.AutoBox.FormattingEnabled = true;
            this.AutoBox.Items.AddRange(new object[] {
            "Выполнен",
            "Выполняется",
            "Не выполнен",
            "Отменен"});
            this.AutoBox.Location = new System.Drawing.Point(81, 194);
            this.AutoBox.Name = "AutoBox";
            this.AutoBox.Size = new System.Drawing.Size(214, 29);
            this.AutoBox.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Malgun Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(81, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(214, 32);
            this.label5.TabIndex = 13;
            this.label5.Text = "Клиент";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Malgun Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(82, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(213, 32);
            this.label6.TabIndex = 14;
            this.label6.Text = "Автомобиль";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OrdersAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 318);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.AutoBox);
            this.Controls.Add(this.ClientBox);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.PriceBox);
            this.Controls.Add(this.label1);
            this.Name = "OrdersAddForm";
            this.Text = "Добавить заказ";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OrdersAddForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.TextBox PriceBox;
        private System.Windows.Forms.ComboBox ClientBox;
        private System.Windows.Forms.ComboBox AutoBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}