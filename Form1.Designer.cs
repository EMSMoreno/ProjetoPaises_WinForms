namespace ProjetoPaises_WinForms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblFlag = new Label();
            lblName = new Label();
            lblOfficialName = new Label();
            lblCurrency = new Label();
            lblCapital = new Label();
            panel = new Panel();
            txtCurrency = new TextBox();
            txtCapital = new TextBox();
            txtRegion = new TextBox();
            txtSubregion = new TextBox();
            lblRegion = new Label();
            progressBar = new ProgressBar();
            pictureBoxFlag = new PictureBox();
            lblSubregion = new Label();
            lblLoading = new Label();
            lblPopulation = new Label();
            txtPopulation = new TextBox();
            lblGiniIndex = new Label();
            txtGiniIndex = new TextBox();
            btnLoadCountries = new Button();
            btnJapanese = new Button();
            btnOrderAZ = new Button();
            btnOrderZA = new Button();
            lblCountryContinent = new Label();
            txtCountryContinent = new TextBox();
            lblCountryTimezones = new Label();
            txtTimezones = new TextBox();
            lblDescription = new Label();
            txtFlagDescription = new TextBox();
            lblTitle = new Label();
            lblCreator = new Label();
            btnGithub = new Button();
            txtSymbol = new TextBox();
            CountrySymbol = new Label();
            listBoxCountries = new ListBox();
            lblSubtitle = new Label();
            txtOfficialName = new TextBox();
            txtName = new TextBox();
            btnCleanForm = new Button();
            btnDarkMode = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFlag).BeginInit();
            SuspendLayout();
            // 
            // lblFlag
            // 
            lblFlag.AutoSize = true;
            lblFlag.Location = new Point(15, 220);
            lblFlag.Name = "lblFlag";
            lblFlag.Size = new Size(75, 15);
            lblFlag.TabIndex = 0;
            lblFlag.Text = "Country Flag";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(15, 307);
            lblName.Name = "lblName";
            lblName.Size = new Size(85, 15);
            lblName.TabIndex = 1;
            lblName.Text = "Country Name";
            // 
            // lblOfficialName
            // 
            lblOfficialName.AutoSize = true;
            lblOfficialName.Location = new Point(15, 355);
            lblOfficialName.Name = "lblOfficialName";
            lblOfficialName.Size = new Size(126, 15);
            lblOfficialName.TabIndex = 2;
            lblOfficialName.Text = "Country Official Name";
            // 
            // lblCurrency
            // 
            lblCurrency.AutoSize = true;
            lblCurrency.Location = new Point(15, 402);
            lblCurrency.Name = "lblCurrency";
            lblCurrency.Size = new Size(101, 15);
            lblCurrency.TabIndex = 3;
            lblCurrency.Text = "Country Currency";
            // 
            // lblCapital
            // 
            lblCapital.AutoSize = true;
            lblCapital.Location = new Point(15, 445);
            lblCapital.Name = "lblCapital";
            lblCapital.Size = new Size(90, 15);
            lblCapital.TabIndex = 4;
            lblCapital.Text = "Country Capital";
            // 
            // panel
            // 
            panel.BackColor = Color.Gray;
            panel.Location = new Point(1047, 1);
            panel.Name = "panel";
            panel.Size = new Size(179, 664);
            panel.TabIndex = 5;
            // 
            // txtCurrency
            // 
            txtCurrency.Enabled = false;
            txtCurrency.Location = new Point(147, 399);
            txtCurrency.Name = "txtCurrency";
            txtCurrency.Size = new Size(142, 23);
            txtCurrency.TabIndex = 7;
            txtCurrency.TextAlign = HorizontalAlignment.Center;
            // 
            // txtCapital
            // 
            txtCapital.Enabled = false;
            txtCapital.Location = new Point(147, 442);
            txtCapital.Name = "txtCapital";
            txtCapital.Size = new Size(142, 23);
            txtCapital.TabIndex = 8;
            txtCapital.TextAlign = HorizontalAlignment.Center;
            // 
            // txtRegion
            // 
            txtRegion.Enabled = false;
            txtRegion.Location = new Point(147, 487);
            txtRegion.Name = "txtRegion";
            txtRegion.Size = new Size(142, 23);
            txtRegion.TabIndex = 9;
            txtRegion.TextAlign = HorizontalAlignment.Center;
            // 
            // txtSubregion
            // 
            txtSubregion.Enabled = false;
            txtSubregion.Location = new Point(147, 529);
            txtSubregion.Name = "txtSubregion";
            txtSubregion.Size = new Size(142, 23);
            txtSubregion.TabIndex = 10;
            txtSubregion.TextAlign = HorizontalAlignment.Center;
            // 
            // lblRegion
            // 
            lblRegion.AutoSize = true;
            lblRegion.Location = new Point(15, 487);
            lblRegion.Name = "lblRegion";
            lblRegion.Size = new Size(90, 15);
            lblRegion.TabIndex = 12;
            lblRegion.Text = "Country Region";
            // 
            // progressBar
            // 
            progressBar.ForeColor = Color.Black;
            progressBar.Location = new Point(15, 122);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(584, 27);
            progressBar.TabIndex = 13;
            // 
            // pictureBoxFlag
            // 
            pictureBoxFlag.Location = new Point(147, 192);
            pictureBoxFlag.Name = "pictureBoxFlag";
            pictureBoxFlag.Size = new Size(142, 80);
            pictureBoxFlag.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxFlag.TabIndex = 14;
            pictureBoxFlag.TabStop = false;
            // 
            // lblSubregion
            // 
            lblSubregion.AutoSize = true;
            lblSubregion.Location = new Point(15, 532);
            lblSubregion.Name = "lblSubregion";
            lblSubregion.Size = new Size(110, 15);
            lblSubregion.TabIndex = 15;
            lblSubregion.Text = "Country SubRegion";
            // 
            // lblLoading
            // 
            lblLoading.AutoSize = true;
            lblLoading.Location = new Point(15, 104);
            lblLoading.Name = "lblLoading";
            lblLoading.Size = new Size(59, 15);
            lblLoading.TabIndex = 17;
            lblLoading.Text = "Loading...";
            // 
            // lblPopulation
            // 
            lblPopulation.AutoSize = true;
            lblPopulation.Location = new Point(15, 577);
            lblPopulation.Name = "lblPopulation";
            lblPopulation.Size = new Size(111, 15);
            lblPopulation.TabIndex = 19;
            lblPopulation.Text = "Country Population";
            // 
            // txtPopulation
            // 
            txtPopulation.Enabled = false;
            txtPopulation.Location = new Point(147, 574);
            txtPopulation.Name = "txtPopulation";
            txtPopulation.Size = new Size(142, 23);
            txtPopulation.TabIndex = 18;
            txtPopulation.TextAlign = HorizontalAlignment.Center;
            // 
            // lblGiniIndex
            // 
            lblGiniIndex.AutoSize = true;
            lblGiniIndex.Location = new Point(15, 616);
            lblGiniIndex.Name = "lblGiniIndex";
            lblGiniIndex.Size = new Size(106, 15);
            lblGiniIndex.TabIndex = 21;
            lblGiniIndex.Text = "Country Gini Index";
            // 
            // txtGiniIndex
            // 
            txtGiniIndex.Enabled = false;
            txtGiniIndex.Location = new Point(147, 613);
            txtGiniIndex.Name = "txtGiniIndex";
            txtGiniIndex.Size = new Size(65, 23);
            txtGiniIndex.TabIndex = 20;
            txtGiniIndex.TextAlign = HorizontalAlignment.Center;
            // 
            // btnLoadCountries
            // 
            btnLoadCountries.FlatAppearance.BorderColor = Color.Orange;
            btnLoadCountries.FlatStyle = FlatStyle.Flat;
            btnLoadCountries.Location = new Point(607, 155);
            btnLoadCountries.Name = "btnLoadCountries";
            btnLoadCountries.Size = new Size(147, 27);
            btnLoadCountries.TabIndex = 22;
            btnLoadCountries.Text = "Reload Countries";
            btnLoadCountries.UseVisualStyleBackColor = true;
            btnLoadCountries.Click += btnLoadCountries_Click;
            // 
            // btnJapanese
            // 
            btnJapanese.FlatAppearance.BorderColor = Color.BlueViolet;
            btnJapanese.FlatStyle = FlatStyle.Flat;
            btnJapanese.Location = new Point(607, 254);
            btnJapanese.Name = "btnJapanese";
            btnJapanese.Size = new Size(147, 27);
            btnJapanese.TabIndex = 23;
            btnJapanese.Text = "Japanese / 日本語";
            btnJapanese.UseVisualStyleBackColor = true;
            // 
            // btnOrderAZ
            // 
            btnOrderAZ.FlatAppearance.BorderColor = Color.GreenYellow;
            btnOrderAZ.FlatStyle = FlatStyle.Flat;
            btnOrderAZ.Location = new Point(607, 188);
            btnOrderAZ.Name = "btnOrderAZ";
            btnOrderAZ.Size = new Size(147, 27);
            btnOrderAZ.TabIndex = 24;
            btnOrderAZ.Text = "Order A -> Z";
            btnOrderAZ.UseVisualStyleBackColor = true;
            btnOrderAZ.Click += btnSortAZ_Click;
            // 
            // btnOrderZA
            // 
            btnOrderZA.FlatAppearance.BorderColor = Color.GreenYellow;
            btnOrderZA.FlatStyle = FlatStyle.Flat;
            btnOrderZA.Location = new Point(607, 221);
            btnOrderZA.Name = "btnOrderZA";
            btnOrderZA.Size = new Size(147, 27);
            btnOrderZA.TabIndex = 25;
            btnOrderZA.Text = "Order Z -> A";
            btnOrderZA.UseVisualStyleBackColor = true;
            btnOrderZA.Click += btnSortZA_Click;
            // 
            // lblCountryContinent
            // 
            lblCountryContinent.AutoSize = true;
            lblCountryContinent.Location = new Point(444, 496);
            lblCountryContinent.Name = "lblCountryContinent";
            lblCountryContinent.Size = new Size(106, 15);
            lblCountryContinent.TabIndex = 31;
            lblCountryContinent.Text = "Country Continent";
            // 
            // txtCountryContinent
            // 
            txtCountryContinent.Enabled = false;
            txtCountryContinent.Location = new Point(559, 493);
            txtCountryContinent.Name = "txtCountryContinent";
            txtCountryContinent.Size = new Size(86, 23);
            txtCountryContinent.TabIndex = 30;
            txtCountryContinent.TextAlign = HorizontalAlignment.Center;
            // 
            // lblCountryTimezones
            // 
            lblCountryTimezones.AutoSize = true;
            lblCountryTimezones.Location = new Point(444, 540);
            lblCountryTimezones.Name = "lblCountryTimezones";
            lblCountryTimezones.Size = new Size(109, 15);
            lblCountryTimezones.TabIndex = 29;
            lblCountryTimezones.Text = "Country Timezones";
            // 
            // txtTimezones
            // 
            txtTimezones.Enabled = false;
            txtTimezones.Location = new Point(559, 537);
            txtTimezones.Multiline = true;
            txtTimezones.Name = "txtTimezones";
            txtTimezones.Size = new Size(178, 99);
            txtTimezones.TabIndex = 27;
            txtTimezones.TextAlign = HorizontalAlignment.Center;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(444, 293);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(146, 15);
            lblDescription.TabIndex = 34;
            lblDescription.Text = "Country Flag - Description";
            // 
            // txtFlagDescription
            // 
            txtFlagDescription.Enabled = false;
            txtFlagDescription.Location = new Point(444, 311);
            txtFlagDescription.Multiline = true;
            txtFlagDescription.Name = "txtFlagDescription";
            txtFlagDescription.Size = new Size(293, 154);
            txtFlagDescription.TabIndex = 32;
            txtFlagDescription.TextAlign = HorizontalAlignment.Center;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(12, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(402, 32);
            lblTitle.TabIndex = 38;
            lblTitle.Text = "Welcome to Countries API Project";
            // 
            // lblCreator
            // 
            lblCreator.AutoSize = true;
            lblCreator.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCreator.Location = new Point(607, 9);
            lblCreator.Name = "lblCreator";
            lblCreator.Size = new Size(147, 15);
            lblCreator.TabIndex = 39;
            lblCreator.Text = "@EduardoM - ServerSide";
            // 
            // btnGithub
            // 
            btnGithub.FlatAppearance.BorderColor = SystemColors.MenuHighlight;
            btnGithub.FlatStyle = FlatStyle.Flat;
            btnGithub.Location = new Point(607, 27);
            btnGithub.Name = "btnGithub";
            btnGithub.Size = new Size(147, 51);
            btnGithub.TabIndex = 40;
            btnGithub.Text = "GitHub Account\r\n(Opens in Browser)";
            btnGithub.UseVisualStyleBackColor = true;
            btnGithub.Click += btnGithub_Click;
            // 
            // txtSymbol
            // 
            txtSymbol.Enabled = false;
            txtSymbol.Location = new Point(367, 399);
            txtSymbol.Name = "txtSymbol";
            txtSymbol.Size = new Size(42, 23);
            txtSymbol.TabIndex = 41;
            txtSymbol.TextAlign = HorizontalAlignment.Center;
            // 
            // CountrySymbol
            // 
            CountrySymbol.AutoSize = true;
            CountrySymbol.Location = new Point(314, 402);
            CountrySymbol.Name = "CountrySymbol";
            CountrySymbol.Size = new Size(47, 15);
            CountrySymbol.TabIndex = 42;
            CountrySymbol.Text = "Symbol";
            // 
            // listBoxCountries
            // 
            listBoxCountries.FormattingEnabled = true;
            listBoxCountries.ItemHeight = 15;
            listBoxCountries.Location = new Point(760, 1);
            listBoxCountries.Name = "listBoxCountries";
            listBoxCountries.Size = new Size(281, 664);
            listBoxCountries.TabIndex = 48;
            listBoxCountries.SelectedIndexChanged += listBoxCountries_SelectedIndexChanged;
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblSubtitle.ForeColor = Color.Black;
            lblSubtitle.Location = new Point(67, 41);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(155, 21);
            lblSubtitle.TabIndex = 49;
            lblSubtitle.Text = "A Country Database";
            // 
            // txtOfficialName
            // 
            txtOfficialName.Enabled = false;
            txtOfficialName.Location = new Point(147, 352);
            txtOfficialName.Name = "txtOfficialName";
            txtOfficialName.Size = new Size(214, 23);
            txtOfficialName.TabIndex = 50;
            txtOfficialName.TextAlign = HorizontalAlignment.Center;
            // 
            // txtName
            // 
            txtName.Enabled = false;
            txtName.Location = new Point(147, 304);
            txtName.Name = "txtName";
            txtName.Size = new Size(262, 23);
            txtName.TabIndex = 51;
            txtName.TextAlign = HorizontalAlignment.Center;
            // 
            // btnCleanForm
            // 
            btnCleanForm.FlatAppearance.BorderColor = Color.Red;
            btnCleanForm.FlatStyle = FlatStyle.Flat;
            btnCleanForm.Location = new Point(607, 122);
            btnCleanForm.Name = "btnCleanForm";
            btnCleanForm.Size = new Size(147, 27);
            btnCleanForm.TabIndex = 52;
            btnCleanForm.Text = "Clean Form";
            btnCleanForm.UseVisualStyleBackColor = true;
            btnCleanForm.Click += btnCleanForm_Click;
            // 
            // btnDarkMode
            // 
            btnDarkMode.FlatAppearance.BorderColor = Color.Black;
            btnDarkMode.FlatStyle = FlatStyle.Flat;
            btnDarkMode.Location = new Point(454, 155);
            btnDarkMode.Name = "btnDarkMode";
            btnDarkMode.Size = new Size(147, 27);
            btnDarkMode.TabIndex = 53;
            btnDarkMode.Text = "Enable Dark Mode";
            btnDarkMode.UseVisualStyleBackColor = true;
            btnDarkMode.Click += btnDarkMode_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1224, 666);
            Controls.Add(btnDarkMode);
            Controls.Add(btnCleanForm);
            Controls.Add(txtName);
            Controls.Add(txtOfficialName);
            Controls.Add(lblSubtitle);
            Controls.Add(listBoxCountries);
            Controls.Add(btnGithub);
            Controls.Add(lblCreator);
            Controls.Add(CountrySymbol);
            Controls.Add(txtSymbol);
            Controls.Add(lblTitle);
            Controls.Add(lblDescription);
            Controls.Add(txtFlagDescription);
            Controls.Add(lblCountryContinent);
            Controls.Add(txtCountryContinent);
            Controls.Add(lblCountryTimezones);
            Controls.Add(txtTimezones);
            Controls.Add(btnOrderZA);
            Controls.Add(btnOrderAZ);
            Controls.Add(btnJapanese);
            Controls.Add(btnLoadCountries);
            Controls.Add(lblGiniIndex);
            Controls.Add(txtGiniIndex);
            Controls.Add(lblPopulation);
            Controls.Add(txtPopulation);
            Controls.Add(lblLoading);
            Controls.Add(lblSubregion);
            Controls.Add(pictureBoxFlag);
            Controls.Add(progressBar);
            Controls.Add(lblRegion);
            Controls.Add(txtSubregion);
            Controls.Add(txtRegion);
            Controls.Add(txtCapital);
            Controls.Add(txtCurrency);
            Controls.Add(panel);
            Controls.Add(lblCapital);
            Controls.Add(lblCurrency);
            Controls.Add(lblOfficialName);
            Controls.Add(lblName);
            Controls.Add(lblFlag);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Form1";
            Text = "CountriesProject";
            ((System.ComponentModel.ISupportInitialize)pictureBoxFlag).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFlag;
        private Label lblName;
        private Label lblOfficialName;
        private Label lblCurrency;
        private Label lblCapital;
        private Panel panel;
        private TextBox txtCurrency;
        private TextBox txtCapital;
        private TextBox txtRegion;
        private TextBox txtSubregion;
        private Label lblRegion;
        private ProgressBar progressBar;
        private PictureBox pictureBoxFlag;
        private Label lblSubregion;
        private Label lblLoading;
        private Label lblPopulation;
        private TextBox txtPopulation;
        private Label lblGiniIndex;
        private TextBox txtGiniIndex;
        private Button btnLoadCountries;
        private Button btnJapanese;
        private Button btnOrderAZ;
        private Button btnOrderZA;
        private Label lblCountryContinent;
        private TextBox txtCountryContinent;
        private Label lblCountryTimezones;
        private TextBox txtTimezones;
        private Label lblDescription;
        private TextBox txtFlagDescription;
        private Label lblTitle;
        private Label lblCreator;
        private Button btnGithub;
        private TextBox txtSymbol;
        private Label CountrySymbol;
        private ListBox listBoxCountries;
        private Label lblSubtitle;
        private TextBox txtOfficialName;
        private TextBox txtName;
        private Button btnCleanForm;
        private Button btnDarkMode;
    }
}
