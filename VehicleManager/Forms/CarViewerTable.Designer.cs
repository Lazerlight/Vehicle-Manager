namespace WinFormsApp1
{
    partial class CarViewerTable
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CarViewerTable));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.createButton = new System.Windows.Forms.Button();
            this.printButton = new System.Windows.Forms.Button();
            this.yearIndexValue = new System.Windows.Forms.ComboBox();
            this.monthIndexValue = new System.Windows.Forms.ComboBox();
            this.monthIndexLabel = new System.Windows.Forms.Label();
            this.yearIndexLabel = new System.Windows.Forms.Label();
            this.carNumberValue = new System.Windows.Forms.TextBox();
            this.carNumberLabel = new System.Windows.Forms.Label();
            this.fuelIndexValue = new System.Windows.Forms.ComboBox();
            this.fuelIndexLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.dateValue = new System.Windows.Forms.Label();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printButtonExcel = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(154, 124);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(961, 429);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // createButton
            // 
            this.createButton.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.createButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.createButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.createButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.createButton.Location = new System.Drawing.Point(154, 568);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(166, 45);
            this.createButton.TabIndex = 1;
            this.createButton.Text = "Създай справка";
            this.createButton.UseVisualStyleBackColor = false;
            this.createButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // printButton
            // 
            this.printButton.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.printButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.printButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.printButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.printButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.printButton.Location = new System.Drawing.Point(949, 568);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(166, 45);
            this.printButton.TabIndex = 2;
            this.printButton.Text = "Принтирай";
            this.printButton.UseVisualStyleBackColor = false;
            this.printButton.Click += new System.EventHandler(this.printButton_Click);
            // 
            // yearIndexValue
            // 
            this.yearIndexValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
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
            this.yearIndexValue.Location = new System.Drawing.Point(640, 49);
            this.yearIndexValue.Name = "yearIndexValue";
            this.yearIndexValue.Size = new System.Drawing.Size(72, 29);
            this.yearIndexValue.TabIndex = 24;
            this.yearIndexValue.Text = "-";
            // 
            // monthIndexValue
            // 
            this.monthIndexValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
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
            this.monthIndexValue.Location = new System.Drawing.Point(822, 49);
            this.monthIndexValue.Name = "monthIndexValue";
            this.monthIndexValue.Size = new System.Drawing.Size(72, 29);
            this.monthIndexValue.TabIndex = 23;
            this.monthIndexValue.Text = "-";
            // 
            // monthIndexLabel
            // 
            this.monthIndexLabel.AutoSize = true;
            this.monthIndexLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.monthIndexLabel.Location = new System.Drawing.Point(732, 52);
            this.monthIndexLabel.Name = "monthIndexLabel";
            this.monthIndexLabel.Size = new System.Drawing.Size(60, 21);
            this.monthIndexLabel.TabIndex = 22;
            this.monthIndexLabel.Text = "Месец:";
            // 
            // yearIndexLabel
            // 
            this.yearIndexLabel.AutoSize = true;
            this.yearIndexLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.yearIndexLabel.Location = new System.Drawing.Point(543, 50);
            this.yearIndexLabel.Name = "yearIndexLabel";
            this.yearIndexLabel.Size = new System.Drawing.Size(65, 21);
            this.yearIndexLabel.TabIndex = 21;
            this.yearIndexLabel.Text = "Година:";
            // 
            // carNumberValue
            // 
            this.carNumberValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.carNumberValue.Location = new System.Drawing.Point(312, 47);
            this.carNumberValue.Name = "carNumberValue";
            this.carNumberValue.Size = new System.Drawing.Size(189, 29);
            this.carNumberValue.TabIndex = 20;
            this.carNumberValue.TextChanged += new System.EventHandler(this.carNumberValue_TextChanged);
            // 
            // carNumberLabel
            // 
            this.carNumberLabel.AutoSize = true;
            this.carNumberLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.carNumberLabel.Location = new System.Drawing.Point(154, 50);
            this.carNumberLabel.Name = "carNumberLabel";
            this.carNumberLabel.Size = new System.Drawing.Size(152, 21);
            this.carNumberLabel.TabIndex = 19;
            this.carNumberLabel.Text = "Регистрационен №:";
            // 
            // fuelIndexValue
            // 
            this.fuelIndexValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fuelIndexValue.FormattingEnabled = true;
            this.fuelIndexValue.Items.AddRange(new object[] {
            "-",
            "Бензин А95 Н",
            "MMDizel",
            "ECTO Dizel",
            "ECTO 100 ",
            "MM100 ",
            "Газ Пропан-Бутан",
            "Супер Дизел"});
            this.fuelIndexValue.Location = new System.Drawing.Point(1014, 49);
            this.fuelIndexValue.Name = "fuelIndexValue";
            this.fuelIndexValue.Size = new System.Drawing.Size(72, 29);
            this.fuelIndexValue.TabIndex = 26;
            this.fuelIndexValue.Text = "-";
            // 
            // fuelIndexLabel
            // 
            this.fuelIndexLabel.AutoSize = true;
            this.fuelIndexLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fuelIndexLabel.Location = new System.Drawing.Point(924, 52);
            this.fuelIndexLabel.Name = "fuelIndexLabel";
            this.fuelIndexLabel.Size = new System.Drawing.Size(65, 21);
            this.fuelIndexLabel.TabIndex = 25;
            this.fuelIndexLabel.Text = "Гориво:";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateLabel.Location = new System.Drawing.Point(12, 9);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(107, 21);
            this.dateLabel.TabIndex = 27;
            this.dateLabel.Text = "Днешна дата:";
            // 
            // dateValue
            // 
            this.dateValue.AutoSize = true;
            this.dateValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateValue.Location = new System.Drawing.Point(125, 9);
            this.dateValue.Name = "dateValue";
            this.dateValue.Size = new System.Drawing.Size(88, 21);
            this.dateValue.TabIndex = 28;
            this.dateValue.Text = "10.10.2022";
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printButtonExcel
            // 
            this.printButtonExcel.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.printButtonExcel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.printButtonExcel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.printButtonExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.printButtonExcel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.printButtonExcel.Location = new System.Drawing.Point(546, 568);
            this.printButtonExcel.Name = "printButtonExcel";
            this.printButtonExcel.Size = new System.Drawing.Size(166, 45);
            this.printButtonExcel.TabIndex = 29;
            this.printButtonExcel.Text = "Създай файл .csv";
            this.printButtonExcel.UseVisualStyleBackColor = false;
            this.printButtonExcel.Click += new System.EventHandler(this.printButtonExcel_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // CarViewerTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1249, 625);
            this.Controls.Add(this.printButtonExcel);
            this.Controls.Add(this.dateValue);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.fuelIndexValue);
            this.Controls.Add(this.fuelIndexLabel);
            this.Controls.Add(this.yearIndexValue);
            this.Controls.Add(this.monthIndexValue);
            this.Controls.Add(this.monthIndexLabel);
            this.Controls.Add(this.yearIndexLabel);
            this.Controls.Add(this.carNumberValue);
            this.Controls.Add(this.carNumberLabel);
            this.Controls.Add(this.printButton);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "CarViewerTable";
            this.Text = "CarViewerTable";
            this.Load += new System.EventHandler(this.CarViewerTable_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private Button createButton;
        private Button printButton;
        private ComboBox yearIndexValue;
        private ComboBox monthIndexValue;
        private Label monthIndexLabel;
        private Label yearIndexLabel;
        private TextBox carNumberValue;
        private Label carNumberLabel;
        private ComboBox fuelIndexValue;
        private Label fuelIndexLabel;
        private Label dateLabel;
        private Label dateValue;
        private PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private Button printButtonExcel;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}