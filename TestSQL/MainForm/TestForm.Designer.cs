
namespace TestSQL
{
    partial class MainForm
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
            this.MainDataGrid = new System.Windows.Forms.DataGridView();
            this.AutomobileMainButton = new System.Windows.Forms.Button();
            this.OrderMainButton = new System.Windows.Forms.Button();
            this.ClientMainButton = new System.Windows.Forms.Button();
            this.MainLabel = new System.Windows.Forms.Label();
            this.AddDataButton = new System.Windows.Forms.Button();
            this.DeleteDataButton = new System.Windows.Forms.Button();
            this.SortLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SortButton1 = new System.Windows.Forms.RadioButton();
            this.SortButton2 = new System.Windows.Forms.RadioButton();
            this.SortButton3 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.MainDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // MainDataGrid
            // 
            this.MainDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.MainDataGrid.BackgroundColor = System.Drawing.Color.White;
            this.MainDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MainDataGrid.Location = new System.Drawing.Point(12, 269);
            this.MainDataGrid.Name = "MainDataGrid";
            this.MainDataGrid.Size = new System.Drawing.Size(777, 640);
            this.MainDataGrid.TabIndex = 1;
            // 
            // AutomobileMainButton
            // 
            this.AutomobileMainButton.BackColor = System.Drawing.Color.SkyBlue;
            this.AutomobileMainButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AutomobileMainButton.Font = new System.Drawing.Font("Malgun Gothic", 27F, System.Drawing.FontStyle.Bold);
            this.AutomobileMainButton.ForeColor = System.Drawing.Color.Black;
            this.AutomobileMainButton.Location = new System.Drawing.Point(15, 39);
            this.AutomobileMainButton.Name = "AutomobileMainButton";
            this.AutomobileMainButton.Size = new System.Drawing.Size(300, 100);
            this.AutomobileMainButton.TabIndex = 2;
            this.AutomobileMainButton.Text = "Автомобили";
            this.AutomobileMainButton.UseVisualStyleBackColor = false;
            this.AutomobileMainButton.Click += new System.EventHandler(this.AutomobileMainButton_Click);
            this.AutomobileMainButton.MouseEnter += new System.EventHandler(this.AutomobileMainButton_MouseEnter);
            this.AutomobileMainButton.MouseLeave += new System.EventHandler(this.AutomobileMainButton_MouseLeave);
            // 
            // OrderMainButton
            // 
            this.OrderMainButton.BackColor = System.Drawing.Color.SkyBlue;
            this.OrderMainButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OrderMainButton.Font = new System.Drawing.Font("Malgun Gothic", 27F, System.Drawing.FontStyle.Bold);
            this.OrderMainButton.ForeColor = System.Drawing.Color.Black;
            this.OrderMainButton.Location = new System.Drawing.Point(489, 39);
            this.OrderMainButton.Name = "OrderMainButton";
            this.OrderMainButton.Size = new System.Drawing.Size(300, 100);
            this.OrderMainButton.TabIndex = 3;
            this.OrderMainButton.Text = "Заказы";
            this.OrderMainButton.UseVisualStyleBackColor = false;
            this.OrderMainButton.Click += new System.EventHandler(this.OrderMainButton_Click);
            this.OrderMainButton.MouseEnter += new System.EventHandler(this.OrderMainButton_MouseEnter);
            this.OrderMainButton.MouseLeave += new System.EventHandler(this.OrderMainButton_MouseLeave);
            // 
            // ClientMainButton
            // 
            this.ClientMainButton.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientMainButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClientMainButton.Font = new System.Drawing.Font("Malgun Gothic", 27F, System.Drawing.FontStyle.Bold);
            this.ClientMainButton.ForeColor = System.Drawing.Color.Black;
            this.ClientMainButton.Location = new System.Drawing.Point(952, 39);
            this.ClientMainButton.Name = "ClientMainButton";
            this.ClientMainButton.Size = new System.Drawing.Size(300, 100);
            this.ClientMainButton.TabIndex = 4;
            this.ClientMainButton.Text = "Клиенты";
            this.ClientMainButton.UseVisualStyleBackColor = false;
            this.ClientMainButton.Click += new System.EventHandler(this.ClientMainButton_Click);
            this.ClientMainButton.MouseEnter += new System.EventHandler(this.ClientMainButton_MouseEnter);
            this.ClientMainButton.MouseLeave += new System.EventHandler(this.ClientMainButton_MouseLeave);
            // 
            // MainLabel
            // 
            this.MainLabel.BackColor = System.Drawing.Color.Teal;
            this.MainLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MainLabel.Font = new System.Drawing.Font("Malgun Gothic", 24F, System.Drawing.FontStyle.Bold);
            this.MainLabel.ForeColor = System.Drawing.Color.White;
            this.MainLabel.Location = new System.Drawing.Point(12, 216);
            this.MainLabel.Name = "MainLabel";
            this.MainLabel.Size = new System.Drawing.Size(1240, 50);
            this.MainLabel.TabIndex = 5;
            this.MainLabel.Text = "Автомобили\r\n";
            this.MainLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AddDataButton
            // 
            this.AddDataButton.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.AddDataButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddDataButton.Font = new System.Drawing.Font("Malgun Gothic", 24F, System.Drawing.FontStyle.Bold);
            this.AddDataButton.ForeColor = System.Drawing.Color.Black;
            this.AddDataButton.Location = new System.Drawing.Point(827, 755);
            this.AddDataButton.Name = "AddDataButton";
            this.AddDataButton.Size = new System.Drawing.Size(400, 60);
            this.AddDataButton.TabIndex = 6;
            this.AddDataButton.Text = "Добавить запись";
            this.AddDataButton.UseVisualStyleBackColor = false;
            this.AddDataButton.Click += new System.EventHandler(this.AddDataButton_Click);
            this.AddDataButton.MouseEnter += new System.EventHandler(this.AddDataButton_MouseEnter);
            this.AddDataButton.MouseLeave += new System.EventHandler(this.AddDataButton_MouseLeave);
            // 
            // DeleteDataButton
            // 
            this.DeleteDataButton.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.DeleteDataButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteDataButton.Font = new System.Drawing.Font("Malgun Gothic", 24F, System.Drawing.FontStyle.Bold);
            this.DeleteDataButton.ForeColor = System.Drawing.Color.Black;
            this.DeleteDataButton.Location = new System.Drawing.Point(827, 836);
            this.DeleteDataButton.Name = "DeleteDataButton";
            this.DeleteDataButton.Size = new System.Drawing.Size(400, 60);
            this.DeleteDataButton.TabIndex = 7;
            this.DeleteDataButton.Text = "Удалить запись";
            this.DeleteDataButton.UseVisualStyleBackColor = false;
            this.DeleteDataButton.Click += new System.EventHandler(this.DeleteDataButton_Click);
            this.DeleteDataButton.MouseEnter += new System.EventHandler(this.DeleteDataButton_MouseEnter);
            this.DeleteDataButton.MouseLeave += new System.EventHandler(this.DeleteDataButton_MouseLeave);
            // 
            // SortLabel
            // 
            this.SortLabel.BackColor = System.Drawing.Color.Teal;
            this.SortLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SortLabel.Font = new System.Drawing.Font("Malgun Gothic", 24F, System.Drawing.FontStyle.Bold);
            this.SortLabel.ForeColor = System.Drawing.Color.White;
            this.SortLabel.Location = new System.Drawing.Point(827, 311);
            this.SortLabel.Name = "SortLabel";
            this.SortLabel.Size = new System.Drawing.Size(400, 53);
            this.SortLabel.TabIndex = 11;
            this.SortLabel.Text = "Сортировать";
            this.SortLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(827, 358);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(400, 317);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // SortButton1
            // 
            this.SortButton1.AutoSize = true;
            this.SortButton1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.SortButton1.Font = new System.Drawing.Font("Malgun Gothic", 24F, System.Drawing.FontStyle.Bold);
            this.SortButton1.Location = new System.Drawing.Point(846, 389);
            this.SortButton1.Name = "SortButton1";
            this.SortButton1.Size = new System.Drawing.Size(72, 49);
            this.SortButton1.TabIndex = 13;
            this.SortButton1.TabStop = true;
            this.SortButton1.Text = "ID";
            this.SortButton1.UseVisualStyleBackColor = false;
            this.SortButton1.CheckedChanged += new System.EventHandler(this.SortButton1_CheckedChanged);
            // 
            // SortButton2
            // 
            this.SortButton2.AutoSize = true;
            this.SortButton2.BackColor = System.Drawing.Color.PaleTurquoise;
            this.SortButton2.Font = new System.Drawing.Font("Malgun Gothic", 24F, System.Drawing.FontStyle.Bold);
            this.SortButton2.Location = new System.Drawing.Point(846, 492);
            this.SortButton2.Name = "SortButton2";
            this.SortButton2.Size = new System.Drawing.Size(267, 49);
            this.SortButton2.TabIndex = 14;
            this.SortButton2.TabStop = true;
            this.SortButton2.Text = "МаркаМодель";
            this.SortButton2.UseVisualStyleBackColor = false;
            this.SortButton2.CheckedChanged += new System.EventHandler(this.SortButton2_CheckedChanged);
            // 
            // SortButton3
            // 
            this.SortButton3.AutoSize = true;
            this.SortButton3.BackColor = System.Drawing.Color.PaleTurquoise;
            this.SortButton3.Font = new System.Drawing.Font("Malgun Gothic", 24F, System.Drawing.FontStyle.Bold);
            this.SortButton3.Location = new System.Drawing.Point(846, 605);
            this.SortButton3.Name = "SortButton3";
            this.SortButton3.Size = new System.Drawing.Size(205, 49);
            this.SortButton3.TabIndex = 15;
            this.SortButton3.TabStop = true;
            this.SortButton3.Text = "Состояние\r\n";
            this.SortButton3.UseVisualStyleBackColor = false;
            this.SortButton3.CheckedChanged += new System.EventHandler(this.SortButton3_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1264, 921);
            this.Controls.Add(this.SortButton3);
            this.Controls.Add(this.SortButton2);
            this.Controls.Add(this.SortButton1);
            this.Controls.Add(this.SortLabel);
            this.Controls.Add(this.DeleteDataButton);
            this.Controls.Add(this.AddDataButton);
            this.Controls.Add(this.MainLabel);
            this.Controls.Add(this.ClientMainButton);
            this.Controls.Add(this.OrderMainButton);
            this.Controls.Add(this.AutomobileMainButton);
            this.Controls.Add(this.MainDataGrid);
            this.Controls.Add(this.pictureBox1);
            this.Name = "MainForm";
            this.Text = "NoManTax";
            this.EnabledChanged += new System.EventHandler(this.MainForm_EnabledChanged);
            ((System.ComponentModel.ISupportInitialize)(this.MainDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView MainDataGrid;
        private System.Windows.Forms.Button AutomobileMainButton;
        private System.Windows.Forms.Button OrderMainButton;
        private System.Windows.Forms.Button ClientMainButton;
        private System.Windows.Forms.Label MainLabel;
        private System.Windows.Forms.Button AddDataButton;
        private System.Windows.Forms.Button DeleteDataButton;
        private System.Windows.Forms.Label SortLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton SortButton1;
        private System.Windows.Forms.RadioButton SortButton2;
        private System.Windows.Forms.RadioButton SortButton3;
    }
}