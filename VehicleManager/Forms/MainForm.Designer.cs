namespace WinFormsApp1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.deleteButton = new System.Windows.Forms.Button();
            this.createTableButton = new System.Windows.Forms.Button();
            this.createTableLabel = new System.Windows.Forms.Label();
            this.yearIndexValue = new System.Windows.Forms.ComboBox();
            this.monthIndexValue = new System.Windows.Forms.ComboBox();
            this.monthIndexLabel = new System.Windows.Forms.Label();
            this.yearIndexLabel = new System.Windows.Forms.Label();
            this.openSelectedButton = new System.Windows.Forms.Button();
            this.vehicleListBox = new System.Windows.Forms.ListBox();
            this.carNumberSearchButton = new System.Windows.Forms.Button();
            this.createNewNumberButton = new System.Windows.Forms.Button();
            this.createNewNumberLabel = new System.Windows.Forms.Label();
            this.carNumberValue = new System.Windows.Forms.TextBox();
            this.carNumberLabel = new System.Windows.Forms.Label();
            this.headerLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.White;
            this.deleteButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.deleteButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.Font = new System.Drawing.Font("Segoe UI Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.deleteButton.ForeColor = System.Drawing.Color.Black;
            this.deleteButton.Location = new System.Drawing.Point(87, 457);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(135, 70);
            this.deleteButton.TabIndex = 36;
            this.deleteButton.Text = "Изтрий избраните";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // createTableButton
            // 
            this.createTableButton.BackColor = System.Drawing.Color.White;
            this.createTableButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.createTableButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.createTableButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createTableButton.Font = new System.Drawing.Font("Segoe UI Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.createTableButton.ForeColor = System.Drawing.Color.Black;
            this.createTableButton.Location = new System.Drawing.Point(895, 340);
            this.createTableButton.Name = "createTableButton";
            this.createTableButton.Size = new System.Drawing.Size(123, 37);
            this.createTableButton.TabIndex = 35;
            this.createTableButton.Text = "Създай";
            this.createTableButton.UseVisualStyleBackColor = false;
            this.createTableButton.Click += new System.EventHandler(this.createTableButton_Click);
            // 
            // createTableLabel
            // 
            this.createTableLabel.AutoSize = true;
            this.createTableLabel.Location = new System.Drawing.Point(675, 345);
            this.createTableLabel.Name = "createTableLabel";
            this.createTableLabel.Size = new System.Drawing.Size(181, 26);
            this.createTableLabel.TabIndex = 34;
            this.createTableLabel.Text = "Създай справка:";
            // 
            // yearIndexValue
            // 
            this.yearIndexValue.FormattingEnabled = true;
            this.yearIndexValue.Items.AddRange(new object[] {
            "-",
            "2022",
            "2023",
            "2024",
            "2025",
            "2026",
            "2027",
            "2028",
            "2029",
            "2030",
            "2031",
            "2032",
            "2033",
            "2034",
            "2035",
            "2036",
            "2037",
            "2038",
            "2039",
            "2040",
            "2041",
            "2042",
            "2043",
            "2044",
            "2045",
            "2046",
            "2047",
            "2048",
            "2049",
            "2050",
            "2051",
            "2052",
            "2053",
            "2054",
            "2055",
            "2056",
            "2057",
            "2058",
            "2059",
            "2060",
            "2061",
            "2062",
            "2063",
            "2064",
            "2065",
            "2066",
            "2067",
            "2068",
            "2069",
            "2070",
            "2071",
            "2072",
            "2073",
            "2074",
            "2075",
            "2076",
            "2077",
            "2078",
            "2079",
            "2080",
            "2081",
            "2082",
            "2083",
            "2084",
            "2085",
            "2086",
            "2087",
            "2088",
            "2089",
            "2090",
            "2091",
            "2092",
            "2093",
            "2094",
            "2095",
            "2096",
            "2097",
            "2098",
            "2099",
            "2100"});
            this.yearIndexValue.Location = new System.Drawing.Point(136, 138);
            this.yearIndexValue.Name = "yearIndexValue";
            this.yearIndexValue.Size = new System.Drawing.Size(72, 34);
            this.yearIndexValue.TabIndex = 33;
            this.yearIndexValue.Text = "-";
            // 
            // monthIndexValue
            // 
            this.monthIndexValue.FormattingEnabled = true;
            this.monthIndexValue.Items.AddRange(new object[] {
            "-",
            "Януари",
            "Февруари",
            "Март",
            "Април",
            "Май",
            "Юни",
            "Юли",
            "Август",
            "Септември",
            "Октомври",
            "Ноември",
            "Декември"});
            this.monthIndexValue.Location = new System.Drawing.Point(358, 136);
            this.monthIndexValue.Name = "monthIndexValue";
            this.monthIndexValue.Size = new System.Drawing.Size(72, 34);
            this.monthIndexValue.TabIndex = 32;
            this.monthIndexValue.Text = "-";
            // 
            // monthIndexLabel
            // 
            this.monthIndexLabel.AutoSize = true;
            this.monthIndexLabel.Location = new System.Drawing.Point(268, 139);
            this.monthIndexLabel.Name = "monthIndexLabel";
            this.monthIndexLabel.Size = new System.Drawing.Size(84, 26);
            this.monthIndexLabel.TabIndex = 31;
            this.monthIndexLabel.Text = "Месец:";
            // 
            // yearIndexLabel
            // 
            this.yearIndexLabel.AutoSize = true;
            this.yearIndexLabel.Location = new System.Drawing.Point(39, 139);
            this.yearIndexLabel.Name = "yearIndexLabel";
            this.yearIndexLabel.Size = new System.Drawing.Size(91, 26);
            this.yearIndexLabel.TabIndex = 30;
            this.yearIndexLabel.Text = "Година:";
            // 
            // openSelectedButton
            // 
            this.openSelectedButton.BackColor = System.Drawing.Color.White;
            this.openSelectedButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.openSelectedButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.openSelectedButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openSelectedButton.Font = new System.Drawing.Font("Segoe UI Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.openSelectedButton.ForeColor = System.Drawing.Color.Black;
            this.openSelectedButton.Location = new System.Drawing.Point(87, 250);
            this.openSelectedButton.Name = "openSelectedButton";
            this.openSelectedButton.Size = new System.Drawing.Size(135, 70);
            this.openSelectedButton.TabIndex = 29;
            this.openSelectedButton.Text = "Отвори избраните";
            this.openSelectedButton.UseVisualStyleBackColor = false;
            this.openSelectedButton.Click += new System.EventHandler(this.openSelectedButton_Click);
            // 
            // vehicleListBox
            // 
            this.vehicleListBox.FormattingEnabled = true;
            this.vehicleListBox.ItemHeight = 26;
            this.vehicleListBox.Location = new System.Drawing.Point(268, 189);
            this.vehicleListBox.Name = "vehicleListBox";
            this.vehicleListBox.Size = new System.Drawing.Size(282, 394);
            this.vehicleListBox.TabIndex = 28;
            // 
            // carNumberSearchButton
            // 
            this.carNumberSearchButton.BackColor = System.Drawing.Color.White;
            this.carNumberSearchButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.carNumberSearchButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.carNumberSearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.carNumberSearchButton.Font = new System.Drawing.Font("Segoe UI Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.carNumberSearchButton.ForeColor = System.Drawing.Color.Black;
            this.carNumberSearchButton.Location = new System.Drawing.Point(463, 133);
            this.carNumberSearchButton.Name = "carNumberSearchButton";
            this.carNumberSearchButton.Size = new System.Drawing.Size(87, 38);
            this.carNumberSearchButton.TabIndex = 27;
            this.carNumberSearchButton.Text = "Търси";
            this.carNumberSearchButton.UseVisualStyleBackColor = false;
            this.carNumberSearchButton.Click += new System.EventHandler(this.carNumberSearchButton_Click);
            // 
            // createNewNumberButton
            // 
            this.createNewNumberButton.BackColor = System.Drawing.Color.White;
            this.createNewNumberButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.createNewNumberButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.createNewNumberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createNewNumberButton.Font = new System.Drawing.Font("Segoe UI Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.createNewNumberButton.ForeColor = System.Drawing.Color.Black;
            this.createNewNumberButton.Location = new System.Drawing.Point(895, 184);
            this.createNewNumberButton.Name = "createNewNumberButton";
            this.createNewNumberButton.Size = new System.Drawing.Size(123, 37);
            this.createNewNumberButton.TabIndex = 26;
            this.createNewNumberButton.Text = "ДОБАВИ";
            this.createNewNumberButton.UseVisualStyleBackColor = false;
            this.createNewNumberButton.Click += new System.EventHandler(this.createNewNumberButton_Click);
            // 
            // createNewNumberLabel
            // 
            this.createNewNumberLabel.AutoSize = true;
            this.createNewNumberLabel.Location = new System.Drawing.Point(675, 189);
            this.createNewNumberLabel.Name = "createNewNumberLabel";
            this.createNewNumberLabel.Size = new System.Drawing.Size(204, 26);
            this.createNewNumberLabel.TabIndex = 25;
            this.createNewNumberLabel.Text = "Добави нов номер:";
            // 
            // carNumberValue
            // 
            this.carNumberValue.Location = new System.Drawing.Point(268, 83);
            this.carNumberValue.Name = "carNumberValue";
            this.carNumberValue.Size = new System.Drawing.Size(189, 35);
            this.carNumberValue.TabIndex = 24;
            // 
            // carNumberLabel
            // 
            this.carNumberLabel.AutoSize = true;
            this.carNumberLabel.Location = new System.Drawing.Point(39, 86);
            this.carNumberLabel.Name = "carNumberLabel";
            this.carNumberLabel.Size = new System.Drawing.Size(207, 26);
            this.carNumberLabel.TabIndex = 23;
            this.carNumberLabel.Text = "Регистрационен №:";
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("SF Movie Poster", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.headerLabel.ForeColor = System.Drawing.Color.Cyan;
            this.headerLabel.Location = new System.Drawing.Point(411, 9);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(264, 41);
            this.headerLabel.TabIndex = 22;
            this.headerLabel.Text = "VEHICLE MANAGER";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1054, 634);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.createTableButton);
            this.Controls.Add(this.createTableLabel);
            this.Controls.Add(this.yearIndexValue);
            this.Controls.Add(this.monthIndexValue);
            this.Controls.Add(this.monthIndexLabel);
            this.Controls.Add(this.yearIndexLabel);
            this.Controls.Add(this.openSelectedButton);
            this.Controls.Add(this.vehicleListBox);
            this.Controls.Add(this.carNumberSearchButton);
            this.Controls.Add(this.createNewNumberButton);
            this.Controls.Add(this.createNewNumberLabel);
            this.Controls.Add(this.carNumberValue);
            this.Controls.Add(this.carNumberLabel);
            this.Controls.Add(this.headerLabel);
            this.Font = new System.Drawing.Font("November", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.Aqua;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "MainForm";
            this.Text = "Vehicle Manager";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button deleteButton;
        private Button createTableButton;
        private Label createTableLabel;
        private ComboBox yearIndexValue;
        private ComboBox monthIndexValue;
        private Label monthIndexLabel;
        private Label yearIndexLabel;
        private Button openSelectedButton;
        private ListBox vehicleListBox;
        private Button carNumberSearchButton;
        private Button createNewNumberButton;
        private Label createNewNumberLabel;
        private TextBox carNumberValue;
        private Label carNumberLabel;
        private Label headerLabel;
    }
}