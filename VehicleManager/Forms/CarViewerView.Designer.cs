namespace WinFormsApp1
{
    partial class CarViewerView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CarViewerView));
            this.editButton = new System.Windows.Forms.Button();
            this.kmEndPerMonthValue = new System.Windows.Forms.TextBox();
            this.kmEndPerMonthLabel = new System.Windows.Forms.Label();
            this.kmStartPerMonthValue = new System.Windows.Forms.TextBox();
            this.kmStartPerMonthLabel = new System.Windows.Forms.Label();
            this.litersFuelBurnedPerMonthValue = new System.Windows.Forms.TextBox();
            this.litersFuelBurnedPerMonthLabel = new System.Windows.Forms.Label();
            this.vehicleCategoryValue = new System.Windows.Forms.TextBox();
            this.vehicleCategoryLabel = new System.Windows.Forms.Label();
            this.litersFuelChargedPerMonthValue = new System.Windows.Forms.TextBox();
            this.kmPerMonthValue = new System.Windows.Forms.TextBox();
            this.litersPer100kmValue = new System.Windows.Forms.TextBox();
            this.carNumberValue = new System.Windows.Forms.TextBox();
            this.litersFuelChargedPerMonthLabel = new System.Windows.Forms.Label();
            this.kmPerMonthLabel = new System.Windows.Forms.Label();
            this.litresPer100kmLabel = new System.Windows.Forms.Label();
            this.typeFuelLabel = new System.Windows.Forms.Label();
            this.carNumberLabel = new System.Windows.Forms.Label();
            this.headerLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dateLabel = new System.Windows.Forms.Label();
            this.dateValueD = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.fuelLeftLabel = new System.Windows.Forms.Label();
            this.fuelLeftValue = new System.Windows.Forms.TextBox();
            this.driverValue = new System.Windows.Forms.TextBox();
            this.driverLabel = new System.Windows.Forms.Label();
            this.companyValue = new System.Windows.Forms.TextBox();
            this.companyLabel = new System.Windows.Forms.Label();
            this.omwValue = new System.Windows.Forms.TextBox();
            this.omwLabel = new System.Windows.Forms.Label();
            this.lukoilValue = new System.Windows.Forms.TextBox();
            this.lukoilLabel = new System.Windows.Forms.Label();
            this.startingLitersFuelValue = new System.Windows.Forms.TextBox();
            this.startingLitersFuelLabel = new System.Windows.Forms.Label();
            this.typeFuelValue = new System.Windows.Forms.ComboBox();
            this.dateValueY = new System.Windows.Forms.Label();
            this.dateValueM = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // editButton
            // 
            this.editButton.BackColor = System.Drawing.Color.White;
            this.editButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.editButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.editButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editButton.Font = new System.Drawing.Font("Segoe UI Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.editButton.ForeColor = System.Drawing.Color.Black;
            this.editButton.Location = new System.Drawing.Point(800, 928);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(247, 52);
            this.editButton.TabIndex = 39;
            this.editButton.Text = "Редактирай";
            this.editButton.UseVisualStyleBackColor = false;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // kmEndPerMonthValue
            // 
            this.kmEndPerMonthValue.Location = new System.Drawing.Point(1350, 328);
            this.kmEndPerMonthValue.Name = "kmEndPerMonthValue";
            this.kmEndPerMonthValue.Size = new System.Drawing.Size(189, 35);
            this.kmEndPerMonthValue.TabIndex = 38;
            this.kmEndPerMonthValue.Text = "0";
            // 
            // kmEndPerMonthLabel
            // 
            this.kmEndPerMonthLabel.AutoSize = true;
            this.kmEndPerMonthLabel.Location = new System.Drawing.Point(1119, 332);
            this.kmEndPerMonthLabel.Name = "kmEndPerMonthLabel";
            this.kmEndPerMonthLabel.Size = new System.Drawing.Size(225, 26);
            this.kmEndPerMonthLabel.TabIndex = 37;
            this.kmEndPerMonthLabel.Text = "Край на месеца: (км)";
            // 
            // kmStartPerMonthValue
            // 
            this.kmStartPerMonthValue.Location = new System.Drawing.Point(924, 328);
            this.kmStartPerMonthValue.Name = "kmStartPerMonthValue";
            this.kmStartPerMonthValue.Size = new System.Drawing.Size(189, 35);
            this.kmStartPerMonthValue.TabIndex = 36;
            this.kmStartPerMonthValue.Text = "0";
            // 
            // kmStartPerMonthLabel
            // 
            this.kmStartPerMonthLabel.AutoSize = true;
            this.kmStartPerMonthLabel.Location = new System.Drawing.Point(669, 332);
            this.kmStartPerMonthLabel.Name = "kmStartPerMonthLabel";
            this.kmStartPerMonthLabel.Size = new System.Drawing.Size(249, 26);
            this.kmStartPerMonthLabel.TabIndex = 35;
            this.kmStartPerMonthLabel.Text = "Начало на месеца: (км)";
            // 
            // litersFuelBurnedPerMonthValue
            // 
            this.litersFuelBurnedPerMonthValue.Location = new System.Drawing.Point(425, 761);
            this.litersFuelBurnedPerMonthValue.Name = "litersFuelBurnedPerMonthValue";
            this.litersFuelBurnedPerMonthValue.Size = new System.Drawing.Size(189, 35);
            this.litersFuelBurnedPerMonthValue.TabIndex = 34;
            this.litersFuelBurnedPerMonthValue.Text = "0";
            // 
            // litersFuelBurnedPerMonthLabel
            // 
            this.litersFuelBurnedPerMonthLabel.AutoSize = true;
            this.litersFuelBurnedPerMonthLabel.Location = new System.Drawing.Point(28, 764);
            this.litersFuelBurnedPerMonthLabel.Name = "litersFuelBurnedPerMonthLabel";
            this.litersFuelBurnedPerMonthLabel.Size = new System.Drawing.Size(373, 26);
            this.litersFuelBurnedPerMonthLabel.TabIndex = 33;
            this.litersFuelBurnedPerMonthLabel.Text = "Изразходено гориво /л/ за месеца:";
            // 
            // vehicleCategoryValue
            // 
            this.vehicleCategoryValue.Location = new System.Drawing.Point(425, 844);
            this.vehicleCategoryValue.Name = "vehicleCategoryValue";
            this.vehicleCategoryValue.Size = new System.Drawing.Size(189, 35);
            this.vehicleCategoryValue.TabIndex = 32;
            // 
            // vehicleCategoryLabel
            // 
            this.vehicleCategoryLabel.AutoSize = true;
            this.vehicleCategoryLabel.Location = new System.Drawing.Point(28, 847);
            this.vehicleCategoryLabel.Name = "vehicleCategoryLabel";
            this.vehicleCategoryLabel.Size = new System.Drawing.Size(160, 26);
            this.vehicleCategoryLabel.TabIndex = 31;
            this.vehicleCategoryLabel.Text = "Модификация:";
            // 
            // litersFuelChargedPerMonthValue
            // 
            this.litersFuelChargedPerMonthValue.Location = new System.Drawing.Point(425, 671);
            this.litersFuelChargedPerMonthValue.Name = "litersFuelChargedPerMonthValue";
            this.litersFuelChargedPerMonthValue.Size = new System.Drawing.Size(189, 35);
            this.litersFuelChargedPerMonthValue.TabIndex = 30;
            this.litersFuelChargedPerMonthValue.Text = "0";
            // 
            // kmPerMonthValue
            // 
            this.kmPerMonthValue.Location = new System.Drawing.Point(425, 328);
            this.kmPerMonthValue.Name = "kmPerMonthValue";
            this.kmPerMonthValue.Size = new System.Drawing.Size(189, 35);
            this.kmPerMonthValue.TabIndex = 29;
            this.kmPerMonthValue.Text = "0";
            this.kmPerMonthValue.TextChanged += new System.EventHandler(this.kmPerMonthValue_TextChanged);
            // 
            // litersPer100kmValue
            // 
            this.litersPer100kmValue.AutoCompleteCustomSource.AddRange(new string[] {
            "Супер Дизел",
            "Бензин А95 Н",
            "АМХ 103км",
            "ЕСТО 100 ",
            "MM Diz",
            "MM 95",
            "MM100",
            "Газ Пропан-Бутан",
            "Супер Дизел"});
            this.litersPer100kmValue.Location = new System.Drawing.Point(425, 248);
            this.litersPer100kmValue.Name = "litersPer100kmValue";
            this.litersPer100kmValue.Size = new System.Drawing.Size(189, 35);
            this.litersPer100kmValue.TabIndex = 28;
            this.litersPer100kmValue.Text = "0";
            // 
            // carNumberValue
            // 
            this.carNumberValue.BackColor = System.Drawing.SystemColors.Window;
            this.carNumberValue.Location = new System.Drawing.Point(425, 86);
            this.carNumberValue.Name = "carNumberValue";
            this.carNumberValue.ReadOnly = true;
            this.carNumberValue.Size = new System.Drawing.Size(189, 35);
            this.carNumberValue.TabIndex = 26;
            this.carNumberValue.TextChanged += new System.EventHandler(this.carNumberValue_TextChanged);
            // 
            // litersFuelChargedPerMonthLabel
            // 
            this.litersFuelChargedPerMonthLabel.AutoSize = true;
            this.litersFuelChargedPerMonthLabel.Location = new System.Drawing.Point(28, 674);
            this.litersFuelChargedPerMonthLabel.Name = "litersFuelChargedPerMonthLabel";
            this.litersFuelChargedPerMonthLabel.Size = new System.Drawing.Size(359, 26);
            this.litersFuelChargedPerMonthLabel.TabIndex = 25;
            this.litersFuelChargedPerMonthLabel.Text = "Общо заредено гориво за месеца:";
            // 
            // kmPerMonthLabel
            // 
            this.kmPerMonthLabel.AutoSize = true;
            this.kmPerMonthLabel.Location = new System.Drawing.Point(28, 332);
            this.kmPerMonthLabel.Name = "kmPerMonthLabel";
            this.kmPerMonthLabel.Size = new System.Drawing.Size(253, 26);
            this.kmPerMonthLabel.TabIndex = 24;
            this.kmPerMonthLabel.Text = "Пробег /км/ за месеца:";
            // 
            // litresPer100kmLabel
            // 
            this.litresPer100kmLabel.AutoSize = true;
            this.litresPer100kmLabel.Location = new System.Drawing.Point(28, 251);
            this.litresPer100kmLabel.Name = "litresPer100kmLabel";
            this.litresPer100kmLabel.Size = new System.Drawing.Size(305, 26);
            this.litresPer100kmLabel.TabIndex = 23;
            this.litresPer100kmLabel.Text = "Разход гориво /л/ на 100км:";
            // 
            // typeFuelLabel
            // 
            this.typeFuelLabel.AutoSize = true;
            this.typeFuelLabel.Location = new System.Drawing.Point(28, 166);
            this.typeFuelLabel.Name = "typeFuelLabel";
            this.typeFuelLabel.Size = new System.Drawing.Size(146, 26);
            this.typeFuelLabel.TabIndex = 22;
            this.typeFuelLabel.Text = "Вид - Гориво:";
            // 
            // carNumberLabel
            // 
            this.carNumberLabel.AutoSize = true;
            this.carNumberLabel.Location = new System.Drawing.Point(28, 88);
            this.carNumberLabel.Name = "carNumberLabel";
            this.carNumberLabel.Size = new System.Drawing.Size(207, 26);
            this.carNumberLabel.TabIndex = 21;
            this.carNumberLabel.Text = "Регистрационен №:";
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("SF Movie Poster", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.headerLabel.ForeColor = System.Drawing.Color.Cyan;
            this.headerLabel.Location = new System.Drawing.Point(839, 9);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(169, 41);
            this.headerLabel.TabIndex = 40;
            this.headerLabel.Text = "View Form";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("18thCentury", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(1073, 380);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(271, 46);
            this.button1.TabIndex = 41;
            this.button1.Text = "Изчисли пробег за месеца";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("SF Movie Poster", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateLabel.ForeColor = System.Drawing.Color.Cyan;
            this.dateLabel.Location = new System.Drawing.Point(987, 94);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(246, 27);
            this.dateLabel.TabIndex = 42;
            this.dateLabel.Text = "Дата на създаване:  ";
            // 
            // dateValueD
            // 
            this.dateValueD.AutoSize = true;
            this.dateValueD.Font = new System.Drawing.Font("SF Movie Poster", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateValueD.ForeColor = System.Drawing.Color.Cyan;
            this.dateValueD.Location = new System.Drawing.Point(1227, 94);
            this.dateValueD.Name = "dateValueD";
            this.dateValueD.Size = new System.Drawing.Size(38, 27);
            this.dateValueD.TabIndex = 43;
            this.dateValueD.Text = "10.";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("18thCentury", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(634, 755);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(170, 49);
            this.button2.TabIndex = 44;
            this.button2.Text = "Изчисли гориво";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("18thCentury", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(1250, 755);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(176, 50);
            this.button3.TabIndex = 60;
            this.button3.Text = "Изчисли остатък";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // fuelLeftLabel
            // 
            this.fuelLeftLabel.AutoSize = true;
            this.fuelLeftLabel.Location = new System.Drawing.Point(839, 764);
            this.fuelLeftLabel.Name = "fuelLeftLabel";
            this.fuelLeftLabel.Size = new System.Drawing.Size(181, 26);
            this.fuelLeftLabel.TabIndex = 59;
            this.fuelLeftLabel.Text = "Остатък гориво: ";
            // 
            // fuelLeftValue
            // 
            this.fuelLeftValue.Location = new System.Drawing.Point(1026, 761);
            this.fuelLeftValue.Name = "fuelLeftValue";
            this.fuelLeftValue.Size = new System.Drawing.Size(189, 35);
            this.fuelLeftValue.TabIndex = 58;
            // 
            // driverValue
            // 
            this.driverValue.Location = new System.Drawing.Point(1350, 841);
            this.driverValue.Name = "driverValue";
            this.driverValue.Size = new System.Drawing.Size(189, 35);
            this.driverValue.TabIndex = 57;
            // 
            // driverLabel
            // 
            this.driverLabel.AutoSize = true;
            this.driverLabel.Location = new System.Drawing.Point(1250, 844);
            this.driverLabel.Name = "driverLabel";
            this.driverLabel.Size = new System.Drawing.Size(61, 26);
            this.driverLabel.TabIndex = 56;
            this.driverLabel.Text = "Име:";
            // 
            // companyValue
            // 
            this.companyValue.Location = new System.Drawing.Point(1026, 844);
            this.companyValue.Name = "companyValue";
            this.companyValue.Size = new System.Drawing.Size(189, 35);
            this.companyValue.TabIndex = 55;
            // 
            // companyLabel
            // 
            this.companyLabel.AutoSize = true;
            this.companyLabel.Location = new System.Drawing.Point(839, 847);
            this.companyLabel.Name = "companyLabel";
            this.companyLabel.Size = new System.Drawing.Size(80, 26);
            this.companyLabel.TabIndex = 54;
            this.companyLabel.Text = "Обект:";
            // 
            // omwValue
            // 
            this.omwValue.Location = new System.Drawing.Point(425, 501);
            this.omwValue.Name = "omwValue";
            this.omwValue.Size = new System.Drawing.Size(189, 35);
            this.omwValue.TabIndex = 66;
            this.omwValue.Text = "0";
            this.omwValue.TextChanged += new System.EventHandler(this.omwValue_TextChanged);
            // 
            // omwLabel
            // 
            this.omwLabel.AutoSize = true;
            this.omwLabel.Location = new System.Drawing.Point(28, 504);
            this.omwLabel.Name = "omwLabel";
            this.omwLabel.Size = new System.Drawing.Size(257, 26);
            this.omwLabel.TabIndex = 65;
            this.omwLabel.Text = "Заредено гориво (ОМВ):";
            // 
            // lukoilValue
            // 
            this.lukoilValue.Location = new System.Drawing.Point(425, 583);
            this.lukoilValue.Name = "lukoilValue";
            this.lukoilValue.Size = new System.Drawing.Size(189, 35);
            this.lukoilValue.TabIndex = 64;
            this.lukoilValue.Text = "0";
            this.lukoilValue.TextChanged += new System.EventHandler(this.lukoilValue_TextChanged);
            // 
            // lukoilLabel
            // 
            this.lukoilLabel.AutoSize = true;
            this.lukoilLabel.Location = new System.Drawing.Point(28, 586);
            this.lukoilLabel.Name = "lukoilLabel";
            this.lukoilLabel.Size = new System.Drawing.Size(292, 26);
            this.lukoilLabel.TabIndex = 63;
            this.lukoilLabel.Text = "Заредено гориво (Лук Ойл):";
            // 
            // startingLitersFuelValue
            // 
            this.startingLitersFuelValue.Location = new System.Drawing.Point(425, 416);
            this.startingLitersFuelValue.Name = "startingLitersFuelValue";
            this.startingLitersFuelValue.Size = new System.Drawing.Size(189, 35);
            this.startingLitersFuelValue.TabIndex = 62;
            this.startingLitersFuelValue.Text = "0";
            this.startingLitersFuelValue.TextChanged += new System.EventHandler(this.startingLitersFuelValue_TextChanged);
            // 
            // startingLitersFuelLabel
            // 
            this.startingLitersFuelLabel.AutoSize = true;
            this.startingLitersFuelLabel.Location = new System.Drawing.Point(28, 419);
            this.startingLitersFuelLabel.Name = "startingLitersFuelLabel";
            this.startingLitersFuelLabel.Size = new System.Drawing.Size(369, 26);
            this.startingLitersFuelLabel.TabIndex = 61;
            this.startingLitersFuelLabel.Text = "Нал. гориво в началото на месеца: ";
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
            this.typeFuelValue.Location = new System.Drawing.Point(425, 166);
            this.typeFuelValue.Name = "typeFuelValue";
            this.typeFuelValue.Size = new System.Drawing.Size(189, 34);
            this.typeFuelValue.TabIndex = 67;
            // 
            // dateValueY
            // 
            this.dateValueY.AutoSize = true;
            this.dateValueY.Font = new System.Drawing.Font("SF Movie Poster", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateValueY.ForeColor = System.Drawing.Color.Cyan;
            this.dateValueY.Location = new System.Drawing.Point(1291, 94);
            this.dateValueY.Name = "dateValueY";
            this.dateValueY.Size = new System.Drawing.Size(79, 27);
            this.dateValueY.TabIndex = 69;
            this.dateValueY.Text = "2022g.";
            // 
            // dateValueM
            // 
            this.dateValueM.AutoSize = true;
            this.dateValueM.Font = new System.Drawing.Font("SF Movie Poster", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateValueM.ForeColor = System.Drawing.Color.Cyan;
            this.dateValueM.Location = new System.Drawing.Point(1259, 94);
            this.dateValueM.Name = "dateValueM";
            this.dateValueM.Size = new System.Drawing.Size(38, 27);
            this.dateValueM.TabIndex = 70;
            this.dateValueM.Text = "10.";
            // 
            // CarViewerView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1753, 992);
            this.Controls.Add(this.dateValueM);
            this.Controls.Add(this.dateValueY);
            this.Controls.Add(this.typeFuelValue);
            this.Controls.Add(this.omwValue);
            this.Controls.Add(this.omwLabel);
            this.Controls.Add(this.lukoilValue);
            this.Controls.Add(this.lukoilLabel);
            this.Controls.Add(this.startingLitersFuelValue);
            this.Controls.Add(this.startingLitersFuelLabel);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.fuelLeftLabel);
            this.Controls.Add(this.fuelLeftValue);
            this.Controls.Add(this.driverValue);
            this.Controls.Add(this.driverLabel);
            this.Controls.Add(this.companyValue);
            this.Controls.Add(this.companyLabel);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dateValueD);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.headerLabel);
            this.Controls.Add(this.editButton);
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
            this.Font = new System.Drawing.Font("November", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.Aqua;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "CarViewerView";
            this.Text = "View Form";
            this.Load += new System.EventHandler(this.CarViewerView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button editButton;
        private TextBox kmEndPerMonthValue;
        private Label kmEndPerMonthLabel;
        private TextBox kmStartPerMonthValue;
        private Label kmStartPerMonthLabel;
        private TextBox litersFuelBurnedPerMonthValue;
        private Label litersFuelBurnedPerMonthLabel;
        private TextBox vehicleCategoryValue;
        private Label vehicleCategoryLabel;
        private TextBox litersFuelChargedPerMonthValue;
        private TextBox kmPerMonthValue;
        private TextBox litersPer100kmValue;
        private TextBox carNumberValue;
        private Label litersFuelChargedPerMonthLabel;
        private Label kmPerMonthLabel;
        private Label litresPer100kmLabel;
        private Label typeFuelLabel;
        private Label carNumberLabel;
        private Label headerLabel;
        private Button button1;
        private Label dateLabel;
        private Label dateValueD;
        private Button button2;
        private Button button3;
        private Label fuelLeftLabel;
        private TextBox fuelLeftValue;
        private TextBox driverValue;
        private Label driverLabel;
        private TextBox companyValue;
        private Label companyLabel;
        private TextBox omwValue;
        private Label omwLabel;
        private TextBox lukoilValue;
        private Label lukoilLabel;
        private TextBox startingLitersFuelValue;
        private Label startingLitersFuelLabel;
        private ComboBox typeFuelValue;
        private Label dateValueY;
        private Label dateValueM;
    }
}