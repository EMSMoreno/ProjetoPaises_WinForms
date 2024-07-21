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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            lblFuncionalities = new Label();
            lblCountriesList = new Label();
            pictureBox1 = new PictureBox();
            btnCleanCountry = new Button();
            btnSearchCountry = new Button();
            txtSearchCountry = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFlag).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblFlag
            // 
            lblFlag.AutoSize = true;
            lblFlag.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblFlag.Location = new Point(12, 178);
            lblFlag.Name = "lblFlag";
            lblFlag.Size = new Size(75, 15);
            lblFlag.TabIndex = 0;
            lblFlag.Text = "Country Flag";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblName.Location = new Point(12, 265);
            lblName.Name = "lblName";
            lblName.Size = new Size(84, 15);
            lblName.TabIndex = 1;
            lblName.Text = "Country Name";
            // 
            // lblOfficialName
            // 
            lblOfficialName.AutoSize = true;
            lblOfficialName.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblOfficialName.Location = new Point(12, 313);
            lblOfficialName.Name = "lblOfficialName";
            lblOfficialName.Size = new Size(125, 15);
            lblOfficialName.TabIndex = 2;
            lblOfficialName.Text = "Country Official Name";
            // 
            // lblCurrency
            // 
            lblCurrency.AutoSize = true;
            lblCurrency.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblCurrency.Location = new Point(12, 360);
            lblCurrency.Name = "lblCurrency";
            lblCurrency.Size = new Size(99, 15);
            lblCurrency.TabIndex = 3;
            lblCurrency.Text = "Country Currency";
            // 
            // lblCapital
            // 
            lblCapital.AutoSize = true;
            lblCapital.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblCapital.Location = new Point(12, 403);
            lblCapital.Name = "lblCapital";
            lblCapital.Size = new Size(91, 15);
            lblCapital.TabIndex = 4;
            lblCapital.Text = "Country Capital";
            // 
            // panel
            // 
            panel.BackColor = Color.Gray;
            panel.Location = new Point(1047, 432);
            panel.Name = "panel";
            panel.Size = new Size(179, 172);
            panel.TabIndex = 5;
            // 
            // txtCurrency
            // 
            txtCurrency.Enabled = false;
            txtCurrency.Location = new Point(144, 357);
            txtCurrency.Name = "txtCurrency";
            txtCurrency.Size = new Size(142, 23);
            txtCurrency.TabIndex = 7;
            txtCurrency.TextAlign = HorizontalAlignment.Center;
            // 
            // txtCapital
            // 
            txtCapital.Enabled = false;
            txtCapital.Location = new Point(144, 400);
            txtCapital.Name = "txtCapital";
            txtCapital.Size = new Size(142, 23);
            txtCapital.TabIndex = 8;
            txtCapital.TextAlign = HorizontalAlignment.Center;
            // 
            // txtRegion
            // 
            txtRegion.Enabled = false;
            txtRegion.Location = new Point(144, 445);
            txtRegion.Name = "txtRegion";
            txtRegion.Size = new Size(142, 23);
            txtRegion.TabIndex = 9;
            txtRegion.TextAlign = HorizontalAlignment.Center;
            // 
            // txtSubregion
            // 
            txtSubregion.Enabled = false;
            txtSubregion.Location = new Point(144, 487);
            txtSubregion.Name = "txtSubregion";
            txtSubregion.Size = new Size(142, 23);
            txtSubregion.TabIndex = 10;
            txtSubregion.TextAlign = HorizontalAlignment.Center;
            // 
            // lblRegion
            // 
            lblRegion.AutoSize = true;
            lblRegion.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblRegion.Location = new Point(12, 445);
            lblRegion.Name = "lblRegion";
            lblRegion.Size = new Size(88, 15);
            lblRegion.TabIndex = 12;
            lblRegion.Text = "Country Region";
            // 
            // progressBar
            // 
            progressBar.ForeColor = Color.Black;
            progressBar.Location = new Point(336, 196);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(407, 27);
            progressBar.TabIndex = 13;
            // 
            // pictureBoxFlag
            // 
            pictureBoxFlag.Location = new Point(144, 150);
            pictureBoxFlag.Name = "pictureBoxFlag";
            pictureBoxFlag.Size = new Size(142, 80);
            pictureBoxFlag.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxFlag.TabIndex = 14;
            pictureBoxFlag.TabStop = false;
            // 
            // lblSubregion
            // 
            lblSubregion.AutoSize = true;
            lblSubregion.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblSubregion.Location = new Point(12, 490);
            lblSubregion.Name = "lblSubregion";
            lblSubregion.Size = new Size(108, 15);
            lblSubregion.TabIndex = 15;
            lblSubregion.Text = "Country SubRegion";
            // 
            // lblLoading
            // 
            lblLoading.AutoSize = true;
            lblLoading.Location = new Point(336, 178);
            lblLoading.Name = "lblLoading";
            lblLoading.Size = new Size(59, 15);
            lblLoading.TabIndex = 17;
            lblLoading.Text = "Loading...";
            // 
            // lblPopulation
            // 
            lblPopulation.AutoSize = true;
            lblPopulation.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblPopulation.Location = new Point(12, 535);
            lblPopulation.Name = "lblPopulation";
            lblPopulation.Size = new Size(109, 15);
            lblPopulation.TabIndex = 19;
            lblPopulation.Text = "Country Population";
            // 
            // txtPopulation
            // 
            txtPopulation.Enabled = false;
            txtPopulation.Location = new Point(144, 532);
            txtPopulation.Name = "txtPopulation";
            txtPopulation.Size = new Size(142, 23);
            txtPopulation.TabIndex = 18;
            txtPopulation.TextAlign = HorizontalAlignment.Center;
            // 
            // lblGiniIndex
            // 
            lblGiniIndex.AutoSize = true;
            lblGiniIndex.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblGiniIndex.Location = new Point(12, 574);
            lblGiniIndex.Name = "lblGiniIndex";
            lblGiniIndex.Size = new Size(104, 15);
            lblGiniIndex.TabIndex = 21;
            lblGiniIndex.Text = "Country Gini Index";
            // 
            // txtGiniIndex
            // 
            txtGiniIndex.Enabled = false;
            txtGiniIndex.Location = new Point(144, 571);
            txtGiniIndex.Name = "txtGiniIndex";
            txtGiniIndex.Size = new Size(65, 23);
            txtGiniIndex.TabIndex = 20;
            txtGiniIndex.TextAlign = HorizontalAlignment.Center;
            // 
            // btnLoadCountries
            // 
            btnLoadCountries.FlatAppearance.BorderColor = Color.Orange;
            btnLoadCountries.FlatStyle = FlatStyle.Flat;
            btnLoadCountries.Location = new Point(1065, 117);
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
            btnJapanese.Location = new Point(1065, 216);
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
            btnOrderAZ.Location = new Point(1065, 150);
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
            btnOrderZA.Location = new Point(1065, 183);
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
            lblCountryContinent.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblCountryContinent.Location = new Point(450, 464);
            lblCountryContinent.Name = "lblCountryContinent";
            lblCountryContinent.Size = new Size(104, 15);
            lblCountryContinent.TabIndex = 31;
            lblCountryContinent.Text = "Country Continent";
            // 
            // txtCountryContinent
            // 
            txtCountryContinent.Enabled = false;
            txtCountryContinent.Location = new Point(565, 461);
            txtCountryContinent.Name = "txtCountryContinent";
            txtCountryContinent.Size = new Size(86, 23);
            txtCountryContinent.TabIndex = 30;
            txtCountryContinent.TextAlign = HorizontalAlignment.Center;
            // 
            // lblCountryTimezones
            // 
            lblCountryTimezones.AutoSize = true;
            lblCountryTimezones.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblCountryTimezones.Location = new Point(450, 508);
            lblCountryTimezones.Name = "lblCountryTimezones";
            lblCountryTimezones.Size = new Size(106, 15);
            lblCountryTimezones.TabIndex = 29;
            lblCountryTimezones.Text = "Country Timezones";
            // 
            // txtTimezones
            // 
            txtTimezones.Enabled = false;
            txtTimezones.Location = new Point(565, 505);
            txtTimezones.Multiline = true;
            txtTimezones.Name = "txtTimezones";
            txtTimezones.Size = new Size(178, 99);
            txtTimezones.TabIndex = 27;
            txtTimezones.TextAlign = HorizontalAlignment.Center;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblDescription.Location = new Point(450, 261);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(145, 15);
            lblDescription.TabIndex = 34;
            lblDescription.Text = "Country Flag - Description";
            // 
            // txtFlagDescription
            // 
            txtFlagDescription.Enabled = false;
            txtFlagDescription.Location = new Point(450, 279);
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
            lblTitle.Location = new Point(118, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(402, 32);
            lblTitle.TabIndex = 38;
            lblTitle.Text = "Welcome to Countries API Project";
            // 
            // lblCreator
            // 
            lblCreator.AutoSize = true;
            lblCreator.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCreator.Location = new Point(1065, 346);
            lblCreator.Name = "lblCreator";
            lblCreator.Size = new Size(147, 15);
            lblCreator.TabIndex = 39;
            lblCreator.Text = "@EduardoM - ServerSide";
            // 
            // btnGithub
            // 
            btnGithub.FlatAppearance.BorderColor = SystemColors.MenuHighlight;
            btnGithub.FlatStyle = FlatStyle.Flat;
            btnGithub.Location = new Point(1065, 364);
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
            txtSymbol.Location = new Point(364, 357);
            txtSymbol.Name = "txtSymbol";
            txtSymbol.Size = new Size(42, 23);
            txtSymbol.TabIndex = 41;
            txtSymbol.TextAlign = HorizontalAlignment.Center;
            // 
            // CountrySymbol
            // 
            CountrySymbol.AutoSize = true;
            CountrySymbol.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            CountrySymbol.Location = new Point(311, 360);
            CountrySymbol.Name = "CountrySymbol";
            CountrySymbol.Size = new Size(45, 15);
            CountrySymbol.TabIndex = 42;
            CountrySymbol.Text = "Symbol";
            // 
            // listBoxCountries
            // 
            listBoxCountries.FormattingEnabled = true;
            listBoxCountries.ItemHeight = 15;
            listBoxCountries.Location = new Point(760, 196);
            listBoxCountries.Name = "listBoxCountries";
            listBoxCountries.Size = new Size(281, 409);
            listBoxCountries.TabIndex = 48;
            listBoxCountries.SelectedIndexChanged += listBoxCountries_SelectedIndexChanged;
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblSubtitle.ForeColor = Color.Black;
            lblSubtitle.Location = new Point(240, 41);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(155, 21);
            lblSubtitle.TabIndex = 49;
            lblSubtitle.Text = "A Country Database";
            // 
            // txtOfficialName
            // 
            txtOfficialName.Enabled = false;
            txtOfficialName.Location = new Point(144, 310);
            txtOfficialName.Name = "txtOfficialName";
            txtOfficialName.Size = new Size(214, 23);
            txtOfficialName.TabIndex = 50;
            txtOfficialName.TextAlign = HorizontalAlignment.Center;
            // 
            // txtName
            // 
            txtName.Enabled = false;
            txtName.Location = new Point(144, 262);
            txtName.Name = "txtName";
            txtName.Size = new Size(262, 23);
            txtName.TabIndex = 51;
            txtName.TextAlign = HorizontalAlignment.Center;
            // 
            // btnCleanForm
            // 
            btnCleanForm.FlatAppearance.BorderColor = Color.Red;
            btnCleanForm.FlatStyle = FlatStyle.Flat;
            btnCleanForm.Location = new Point(1065, 84);
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
            btnDarkMode.Location = new Point(1065, 249);
            btnDarkMode.Name = "btnDarkMode";
            btnDarkMode.Size = new Size(147, 27);
            btnDarkMode.TabIndex = 53;
            btnDarkMode.Text = "Enable Dark Mode";
            btnDarkMode.UseVisualStyleBackColor = true;
            btnDarkMode.Click += btnDarkMode_Click;
            // 
            // lblFuncionalities
            // 
            lblFuncionalities.AutoSize = true;
            lblFuncionalities.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFuncionalities.Location = new Point(1065, 66);
            lblFuncionalities.Name = "lblFuncionalities";
            lblFuncionalities.Size = new Size(82, 15);
            lblFuncionalities.TabIndex = 54;
            lblFuncionalities.Text = "Funcionalities";
            // 
            // lblCountriesList
            // 
            lblCountriesList.AutoSize = true;
            lblCountriesList.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblCountriesList.Location = new Point(760, 178);
            lblCountriesList.Name = "lblCountriesList";
            lblCountriesList.Size = new Size(78, 15);
            lblCountriesList.TabIndex = 55;
            lblCountriesList.Text = "Countries List";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(2, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(111, 53);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 56;
            pictureBox1.TabStop = false;
            // 
            // btnCleanCountry
            // 
            btnCleanCountry.FlatAppearance.BorderColor = Color.Red;
            btnCleanCountry.FlatStyle = FlatStyle.Flat;
            btnCleanCountry.Location = new Point(759, 117);
            btnCleanCountry.Name = "btnCleanCountry";
            btnCleanCountry.Size = new Size(147, 27);
            btnCleanCountry.TabIndex = 57;
            btnCleanCountry.Text = "Clean Search";
            btnCleanCountry.UseVisualStyleBackColor = true;
            btnCleanCountry.Click += btnCleanCountry_Click;
            // 
            // btnSearchCountry
            // 
            btnSearchCountry.FlatAppearance.BorderColor = Color.DodgerBlue;
            btnSearchCountry.FlatStyle = FlatStyle.Flat;
            btnSearchCountry.Location = new Point(912, 117);
            btnSearchCountry.Name = "btnSearchCountry";
            btnSearchCountry.Size = new Size(147, 27);
            btnSearchCountry.TabIndex = 58;
            btnSearchCountry.Text = "Search Country";
            btnSearchCountry.UseVisualStyleBackColor = true;
            // 
            // txtSearchCountry
            // 
            txtSearchCountry.Location = new Point(856, 87);
            txtSearchCountry.Name = "txtSearchCountry";
            txtSearchCountry.Size = new Size(202, 23);
            txtSearchCountry.TabIndex = 59;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(759, 90);
            label1.Name = "label1";
            label1.Size = new Size(90, 15);
            label1.TabIndex = 60;
            label1.Text = "Country Search:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1224, 607);
            Controls.Add(label1);
            Controls.Add(txtSearchCountry);
            Controls.Add(btnSearchCountry);
            Controls.Add(btnCleanCountry);
            Controls.Add(pictureBox1);
            Controls.Add(lblCountriesList);
            Controls.Add(lblFuncionalities);
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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private Label lblFuncionalities;
        private Label lblCountriesList;
        private PictureBox pictureBox1;
        private Button btnCleanCountry;
        private Button btnSearchCountry;
        private TextBox txtSearchCountry;
        private Label label1;
    }
}
