namespace WinFormsApp1
{
    partial class CarViewerCreate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CarViewerCreate));
            this.headerLabel = new System.Windows.Forms.Label();
            this.carNumberLabel = new System.Windows.Forms.Label();
            this.typeFuelLabel = new System.Windows.Forms.Label();
            this.litresPer100kmLabel = new System.Windows.Forms.Label();
            this.kmPerMonthLabel = new System.Windows.Forms.Label();
            this.litersFuelChargedPerMonthLabel = new System.Windows.Forms.Label();
            this.carNumberValue = new System.Windows.Forms.TextBox();
            this.kmPerMonthValue = new System.Windows.Forms.TextBox();
            this.litersPer100kmValue = new System.Windows.Forms.TextBox();
            this.litersFuelChargedPerMonthValue = new System.Windows.Forms.TextBox();
            this.vehicleCategoryValue = new System.Windows.Forms.TextBox();
            this.vehicleCategoryLabel = new System.Windows.Forms.Label();
            this.litersFuelBurnedPerMonthValue = new System.Windows.Forms.TextBox();
            this.litersFuelBurnedPerMonthLabel = new System.Windows.Forms.Label();
            this.kmStartPerMonthValue = new System.Windows.Forms.TextBox();
            this.kmStartPerMonthLabel = new System.Windows.Forms.Label();
            this.kmEndPerMonthValue = new System.Windows.Forms.TextBox();
            this.kmEndPerMonthLabel = new System.Windows.Forms.Label();
            this.createButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.companyLabel = new System.Windows.Forms.Label();
            this.companyValue = new System.Windows.Forms.TextBox();
            this.driverValue = new System.Windows.Forms.TextBox();
            this.fuelLeftValue = new System.Windows.Forms.TextBox();
            this.driverLabel = new System.Windows.Forms.Label();
            this.fuelLeftLabel = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.startingLitersFuelValue = new System.Windows.Forms.TextBox();
            this.startingLitersFuelLabel = new System.Windows.Forms.Label();
            this.lukoilValue = new System.Windows.Forms.TextBox();
            this.lukoilLabel = new System.Windows.Forms.Label();
            this.omwValue = new System.Windows.Forms.TextBox();
            this.omwLabel = new System.Windows.Forms.Label();
            this.typeFuelValue = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("SF Movie Poster", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.headerLabel.ForeColor = System.Drawing.Color.Cyan;
            this.headerLabel.Location = new System.Drawing.Point(763, 9);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(200, 41);
            this.headerLabel.TabIndex = 1;
            this.headerLabel.Text = "CREATE FORM";
            // 
            // carNumberLabel
            // 
            this.carNumberLabel.AutoSize = true;
            this.carNumberLabel.Location = new System.Drawing.Point(12, 89);
            this.carNumberLabel.Name = "carNumberLabel";
            this.carNumberLabel.Size = new System.Drawing.Size(207, 26);
            this.carNumberLabel.TabIndex = 2;
            this.carNumberLabel.Text = "Регистрационен №:";
            // 
            // typeFuelLabel
            // 
            this.typeFuelLabel.AutoSize = true;
            this.typeFuelLabel.Location = new System.Drawing.Point(12, 167);
            this.typeFuelLabel.Name = "typeFuelLabel";
            this.typeFuelLabel.Size = new System.Drawing.Size(146, 26);
            this.typeFuelLabel.TabIndex = 3;
            this.typeFuelLabel.Text = "Вид - Гориво:";
            // 
            // litresPer100kmLabel
            // 
            this.litresPer100kmLabel.AutoSize = true;
            this.litresPer100kmLabel.Location = new System.Drawing.Point(12, 251);
            this.litresPer100kmLabel.Name = "litresPer100kmLabel";
            this.litresPer100kmLabel.Size = new System.Drawing.Size(305, 26);
            this.litresPer100kmLabel.TabIndex = 4;
            this.litresPer100kmLabel.Text = "Разход гориво /л/ на 100км:";
            // 
            // kmPerMonthLabel
            // 
            this.kmPerMonthLabel.AutoSize = true;
            this.kmPerMonthLabel.Location = new System.Drawing.Point(12, 337);
            this.kmPerMonthLabel.Name = "kmPerMonthLabel";
            this.kmPerMonthLabel.Size = new System.Drawing.Size(253, 26);
            this.kmPerMonthLabel.TabIndex = 5;
            this.kmPerMonthLabel.Text = "Пробег /км/ за месеца:";
            // 
            // litersFuelChargedPerMonthLabel
            // 
            this.litersFuelChargedPerMonthLabel.AutoSize = true;
            this.litersFuelChargedPerMonthLabel.Location = new System.Drawing.Point(12, 674);
            this.litersFuelChargedPerMonthLabel.Name = "litersFuelChargedPerMonthLabel";
            this.litersFuelChargedPerMonthLabel.Size = new System.Drawing.Size(359, 26);
            this.litersFuelChargedPerMonthLabel.TabIndex = 6;
            this.litersFuelChargedPerMonthLabel.Text = "Общо заредено гориво за месеца:";
            // 
            // carNumberValue
            // 
            this.carNumberValue.Location = new System.Drawing.Point(409, 86);
            this.carNumberValue.Name = "carNumberValue";
            this.carNumberValue.Size = new System.Drawing.Size(189, 35);
            this.carNumberValue.TabIndex = 7;
            // 
            // kmPerMonthValue
            // 
            this.kmPerMonthValue.Location = new System.Drawing.Point(409, 334);
            this.kmPerMonthValue.Name = "kmPerMonthValue";
            this.kmPerMonthValue.Size = new System.Drawing.Size(189, 35);
            this.kmPerMonthValue.TabIndex = 10;
            this.kmPerMonthValue.Text = "0";
            this.kmPerMonthValue.TextChanged += new System.EventHandler(this.kmPerMonthValue_TextChanged);
            // 
            // litersPer100kmValue
            // 
            this.litersPer100kmValue.Location = new System.Drawing.Point(409, 248);
            this.litersPer100kmValue.Name = "litersPer100kmValue";
            this.litersPer100kmValue.Size = new System.Drawing.Size(189, 35);
            this.litersPer100kmValue.TabIndex = 9;
            this.litersPer100kmValue.Text = "0";
            this.litersPer100kmValue.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // litersFuelChargedPerMonthValue
            // 
            this.litersFuelChargedPerMonthValue.Location = new System.Drawing.Point(409, 671);
            this.litersFuelChargedPerMonthValue.Name = "litersFuelChargedPerMonthValue";
            this.litersFuelChargedPerMonthValue.Size = new System.Drawing.Size(189, 35);
            this.litersFuelChargedPerMonthValue.TabIndex = 11;
            this.litersFuelChargedPerMonthValue.Text = "0";
            // 
            // vehicleCategoryValue
            // 
            this.vehicleCategoryValue.Location = new System.Drawing.Point(409, 841);
            this.vehicleCategoryValue.Name = "vehicleCategoryValue";
            this.vehicleCategoryValue.Size = new System.Drawing.Size(189, 35);
            this.vehicleCategoryValue.TabIndex = 13;
            // 
            // vehicleCategoryLabel
            // 
            this.vehicleCategoryLabel.AutoSize = true;
            this.vehicleCategoryLabel.Location = new System.Drawing.Point(12, 844);
            this.vehicleCategoryLabel.Name = "vehicleCategoryLabel";
            this.vehicleCategoryLabel.Size = new System.Drawing.Size(160, 26);
            this.vehicleCategoryLabel.TabIndex = 12;
            this.vehicleCategoryLabel.Text = "Модификация:";
            // 
            // litersFuelBurnedPerMonthValue
            // 
            this.litersFuelBurnedPerMonthValue.Location = new System.Drawing.Point(409, 758);
            this.litersFuelBurnedPerMonthValue.Name = "litersFuelBurnedPerMonthValue";
            this.litersFuelBurnedPerMonthValue.Size = new System.Drawing.Size(189, 35);
            this.litersFuelBurnedPerMonthValue.TabIndex = 15;
            this.litersFuelBurnedPerMonthValue.Text = "0";
            // 
            // litersFuelBurnedPerMonthLabel
            // 
            this.litersFuelBurnedPerMonthLabel.AutoSize = true;
            this.litersFuelBurnedPerMonthLabel.Location = new System.Drawing.Point(12, 761);
            this.litersFuelBurnedPerMonthLabel.Name = "litersFuelBurnedPerMonthLabel";
            this.litersFuelBurnedPerMonthLabel.Size = new System.Drawing.Size(373, 26);
            this.litersFuelBurnedPerMonthLabel.TabIndex = 14;
            this.litersFuelBurnedPerMonthLabel.Text = "Изразходено гориво /л/ за месеца:";
            this.litersFuelBurnedPerMonthLabel.Click += new System.EventHandler(this.litersFuelBurnedPerMonthLabel_Click);
            // 
            // kmStartPerMonthValue
            // 
            this.kmStartPerMonthValue.Location = new System.Drawing.Point(911, 328);
            this.kmStartPerMonthValue.Name = "kmStartPerMonthValue";
            this.kmStartPerMonthValue.Size = new System.Drawing.Size(189, 35);
            this.kmStartPerMonthValue.TabIndex = 17;
            this.kmStartPerMonthValue.Text = "0";
            // 
            // kmStartPerMonthLabel
            // 
            this.kmStartPerMonthLabel.AutoSize = true;
            this.kmStartPerMonthLabel.Location = new System.Drawing.Point(656, 331);
            this.kmStartPerMonthLabel.Name = "kmStartPerMonthLabel";
            this.kmStartPerMonthLabel.Size = new System.Drawing.Size(249, 26);
            this.kmStartPerMonthLabel.TabIndex = 16;
            this.kmStartPerMonthLabel.Text = "Начало на месеца: (км)";
            this.kmStartPerMonthLabel.Click += new System.EventHandler(this.label7_Click);
            // 
            // kmEndPerMonthValue
            // 
            this.kmEndPerMonthValue.Location = new System.Drawing.Point(1337, 328);
            this.kmEndPerMonthValue.Name = "kmEndPerMonthValue";
            this.kmEndPerMonthValue.Size = new System.Drawing.Size(189, 35);
            this.kmEndPerMonthValue.TabIndex = 19;
            this.kmEndPerMonthValue.Text = "0";
            // 
            // kmEndPerMonthLabel
            // 
            this.kmEndPerMonthLabel.AutoSize = true;
            this.kmEndPerMonthLabel.Location = new System.Drawing.Point(1106, 331);
            this.kmEndPerMonthLabel.Name = "kmEndPerMonthLabel";
            this.kmEndPerMonthLabel.Size = new System.Drawing.Size(225, 26);
            this.kmEndPerMonthLabel.TabIndex = 18;
            this.kmEndPerMonthLabel.Text = "Край на месеца: (км)";
            // 
            // createButton
            // 
            this.createButton.BackColor = System.Drawing.Color.White;
            this.createButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.createButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.createButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createButton.Font = new System.Drawing.Font("Segoe UI Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.createButton.ForeColor = System.Drawing.Color.Black;
            this.createButton.Location = new System.Drawing.Point(740, 928);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(247, 52);
            this.createButton.TabIndex = 20;
            this.createButton.Text = "Създай";
            this.createButton.UseVisualStyleBackColor = false;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(1079, 386);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(271, 66);
            this.button1.TabIndex = 42;
            this.button1.Text = "Изчисли пробег за месеца";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("18thCentury", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(614, 752);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(170, 50);
            this.button2.TabIndex = 45;
            this.button2.Text = "Изчисли гориво";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // companyLabel
            // 
            this.companyLabel.AutoSize = true;
            this.companyLabel.Location = new System.Drawing.Point(826, 844);
            this.companyLabel.Name = "companyLabel";
            this.companyLabel.Size = new System.Drawing.Size(80, 26);
            this.companyLabel.TabIndex = 46;
            this.companyLabel.Text = "Обект:";
            // 
            // companyValue
            // 
            this.companyValue.Location = new System.Drawing.Point(1013, 841);
            this.companyValue.Name = "companyValue";
            this.companyValue.Size = new System.Drawing.Size(189, 35);
            this.companyValue.TabIndex = 47;
            // 
            // driverValue
            // 
            this.driverValue.Location = new System.Drawing.Point(1337, 838);
            this.driverValue.Name = "driverValue";
            this.driverValue.Size = new System.Drawing.Size(189, 35);
            this.driverValue.TabIndex = 49;
            // 
            // fuelLeftValue
            // 
            this.fuelLeftValue.Location = new System.Drawing.Point(1013, 758);
            this.fuelLeftValue.Name = "fuelLeftValue";
            this.fuelLeftValue.Size = new System.Drawing.Size(189, 35);
            this.fuelLeftValue.TabIndex = 51;
            // 
            // driverLabel
            // 
            this.driverLabel.AutoSize = true;
            this.driverLabel.Location = new System.Drawing.Point(1237, 841);
            this.driverLabel.Name = "driverLabel";
            this.driverLabel.Size = new System.Drawing.Size(61, 26);
            this.driverLabel.TabIndex = 48;
            this.driverLabel.Text = "Име:";
            // 
            // fuelLeftLabel
            // 
            this.fuelLeftLabel.AutoSize = true;
            this.fuelLeftLabel.Location = new System.Drawing.Point(826, 761);
            this.fuelLeftLabel.Name = "fuelLeftLabel";
            this.fuelLeftLabel.Size = new System.Drawing.Size(181, 26);
            this.fuelLeftLabel.TabIndex = 52;
            this.fuelLeftLabel.Text = "Остатък гориво: ";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("18thCentury", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(1237, 752);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(176, 50);
            this.button3.TabIndex = 53;
            this.button3.Text = "Изчисли остатък";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.button4.ForeColor = System.Drawing.Color.Black;
            this.button4.Location = new System.Drawing.Point(1127, 69);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(286, 68);
            this.button4.TabIndex = 54;
            this.button4.Text = "Провери данни на ППС за предишен месец";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // startingLitersFuelValue
            // 
            this.startingLitersFuelValue.Location = new System.Drawing.Point(409, 417);
            this.startingLitersFuelValue.Name = "startingLitersFuelValue";
            this.startingLitersFuelValue.Size = new System.Drawing.Size(189, 35);
            this.startingLitersFuelValue.TabIndex = 56;
            this.startingLitersFuelValue.Text = "0";
            this.startingLitersFuelValue.TextChanged += new System.EventHandler(this.startingLitersFuelValue_TextChanged);
            // 
            // startingLitersFuelLabel
            // 
            this.startingLitersFuelLabel.AutoSize = true;
            this.startingLitersFuelLabel.Location = new System.Drawing.Point(12, 420);
            this.startingLitersFuelLabel.Name = "startingLitersFuelLabel";
            this.startingLitersFuelLabel.Size = new System.Drawing.Size(369, 26);
            this.startingLitersFuelLabel.TabIndex = 55;
            this.startingLitersFuelLabel.Text = "Нал. гориво в началото на месеца: ";
            // 
            // lukoilValue
            // 
            this.lukoilValue.Location = new System.Drawing.Point(409, 584);
            this.lukoilValue.Name = "lukoilValue";
            this.lukoilValue.Size = new System.Drawing.Size(189, 35);
            this.lukoilValue.TabIndex = 58;
            this.lukoilValue.Text = "0";
            this.lukoilValue.TextChanged += new System.EventHandler(this.lukoilValue_TextChanged);
            // 
            // lukoilLabel
            // 
            this.lukoilLabel.AutoSize = true;
            this.lukoilLabel.Location = new System.Drawing.Point(12, 587);
            this.lukoilLabel.Name = "lukoilLabel";
            this.lukoilLabel.Size = new System.Drawing.Size(292, 26);
            this.lukoilLabel.TabIndex = 57;
            this.lukoilLabel.Text = "Заредено гориво (Лук Ойл):";
            // 
            // omwValue
            // 
            this.omwValue.Location = new System.Drawing.Point(409, 502);
            this.omwValue.Name = "omwValue";
            this.omwValue.Size = new System.Drawing.Size(189, 35);
            this.omwValue.TabIndex = 60;
            this.omwValue.Text = "0";
            this.omwValue.TextChanged += new System.EventHandler(this.omwValue_TextChanged);
            // 
            // omwLabel
            // 
            this.omwLabel.AutoSize = true;
            this.omwLabel.Location = new System.Drawing.Point(12, 505);
            this.omwLabel.Name = "omwLabel";
            this.omwLabel.Size = new System.Drawing.Size(257, 26);
            this.omwLabel.TabIndex = 59;
            this.omwLabel.Text = "Заредено гориво (ОМВ):";
            // 
            // typeFuelValue
            // 
            this.typeFuelValue.FormattingEnabled = true;
            this.typeFuelValue.Items.AddRange(new object[] {
            "Бензин А95 Н",
            "MMDizel",
            "ECTO Dizel",
            "ECTO100 ",
            "MM100 ",
            "Газ Пропан-Бутан",
            "Супер Дизел"});
            this.typeFuelValue.Location = new System.Drawing.Point(409, 167);
            this.typeFuelValue.Name = "typeFuelValue";
            this.typeFuelValue.Size = new System.Drawing.Size(189, 34);
            this.typeFuelValue.TabIndex = 68;
            // 
            // CarViewerCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1753, 992);
            this.Controls.Add(this.typeFuelValue);
            this.Controls.Add(this.omwValue);
            this.Controls.Add(this.omwLabel);
            this.Controls.Add(this.lukoilValue);
            this.Controls.Add(this.lukoilLabel);
            this.Controls.Add(this.startingLitersFuelValue);
            this.Controls.Add(this.startingLitersFuelLabel);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.fuelLeftLabel);
            this.Controls.Add(this.fuelLeftValue);
            this.Controls.Add(this.driverValue);
            this.Controls.Add(this.driverLabel);
            this.Controls.Add(this.companyValue);
            this.Controls.Add(this.companyLabel);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.kmEndPerMonthValue);
            this.Controls.Add(this.kmEndPerMonthLabel);
            this.Controls.Add(this.kmStartPerMonthValue);
            this.Controls.Add(this.kmStartPerMonthLabel);
            this.Controls.Add(this.litersFuelBurnedPerMonthValue);
            this.Controls.Add(this.litersFuelBurnedPerMonthLabel);
            this.Controls.Add(this.vehicleCategoryValue);
            this.Controls.Add(this.vehicleCategoryLabel);
            this.Controls.Add(this.litersFuelChargedPerMonthValue);
            this.Controls.Add(this.kmPerMonthValue);
            this.Controls.Add(this.litersPer100kmValue);
            this.Controls.Add(this.carNumberValue);
            this.Controls.Add(this.litersFuelChargedPerMonthLabel);
            this.Controls.Add(this.kmPerMonthLabel);
            this.Controls.Add(this.litresPer100kmLabel);
            this.Controls.Add(this.typeFuelLabel);
            this.Controls.Add(this.carNumberLabel);
            this.Controls.Add(this.headerLabel);
            this.Font = new System.Drawing.Font("November", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.Aqua;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "CarViewerCreate";
            this.Text = "Create Form";
            this.Load += new System.EventHandler(this.CarViewerCreate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label headerLabel;
        private Label carNumberLabel;
        private Label typeFuelLabel;
        private Label litresPer100kmLabel;
        private Label kmPerMonthLabel;
        private Label litersFuelChargedPerMonthLabel;
        private TextBox carNumberValue;
        private TextBox kmPerMonthValue;
        private TextBox litersPer100kmValue;
        private TextBox litersFuelChargedPerMonthValue;
        private TextBox vehicleCategoryValue;
        private Label vehicleCategoryLabel;
        private TextBox litersFuelBurnedPerMonthValue;
        private Label litersFuelBurnedPerMonthLabel;
        private TextBox kmStartPerMonthValue;
        private Label kmStartPerMonthLabel;
        private TextBox kmEndPerMonthValue;
        private Label kmEndPerMonthLabel;
        private Button createButton;
        private Button button1;
        private Button button2;
        private Label companyLabel;
        private TextBox companyValue;
        private TextBox driverValue;
        private TextBox fuelLeftValue;
        private Label driverLabel;
        private Label fuelLeftLabel;
        private Button button3;
        private Button button4;
        private TextBox startingLitersFuelValue;
        private Label startingLitersFuelLabel;
        private TextBox lukoilValue;
        private Label lukoilLabel;
        private TextBox omwValue;
        private Label omwLabel;
        private ComboBox typeFuelValue;
    }
}