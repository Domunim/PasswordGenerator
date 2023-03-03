namespace PasswordGeneratorUI
{
    partial class GeneratePasswordForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GeneratePasswordForm));
            this.GeneratePasswordHeader = new System.Windows.Forms.Label();
            this.GeneratePasswordButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.NewPasswordLabel = new System.Windows.Forms.Label();
            this.SimpleRadioButton = new System.Windows.Forms.RadioButton();
            this.ComplexRadioButton = new System.Windows.Forms.RadioButton();
            this.KeywordTextbox = new System.Windows.Forms.TextBox();
            this.SimpleKeywordLabel = new System.Windows.Forms.Label();
            this.LenghtTrackBar = new System.Windows.Forms.TrackBar();
            this.LenghtLabel = new System.Windows.Forms.Label();
            this.CapitalLettersCheckBox = new System.Windows.Forms.CheckBox();
            this.NumbersCheckBox = new System.Windows.Forms.CheckBox();
            this.SpecialCharsCheckBox = new System.Windows.Forms.CheckBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.AddCharactersRadioButton = new System.Windows.Forms.RadioButton();
            this.ReplaceRadioButton = new System.Windows.Forms.RadioButton();
            this.GeneratedPasswordLabel = new System.Windows.Forms.Label();
            this.SimplePasswordGroupBox = new System.Windows.Forms.GroupBox();
            this.PasswordTypeGroupBox = new System.Windows.Forms.GroupBox();
            this.CharacterNumberLabel = new System.Windows.Forms.Label();
            this.CharactersLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.LenghtTrackBar)).BeginInit();
            this.SimplePasswordGroupBox.SuspendLayout();
            this.PasswordTypeGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // GeneratePasswordHeader
            // 
            this.GeneratePasswordHeader.AutoSize = true;
            this.GeneratePasswordHeader.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.GeneratePasswordHeader.Location = new System.Drawing.Point(413, 27);
            this.GeneratePasswordHeader.Name = "GeneratePasswordHeader";
            this.GeneratePasswordHeader.Size = new System.Drawing.Size(281, 40);
            this.GeneratePasswordHeader.TabIndex = 35;
            this.GeneratePasswordHeader.Text = "Generate Password";
            // 
            // GeneratePasswordButton
            // 
            this.GeneratePasswordButton.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.GeneratePasswordButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GeneratePasswordButton.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GeneratePasswordButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.GeneratePasswordButton.Location = new System.Drawing.Point(443, 665);
            this.GeneratePasswordButton.Name = "GeneratePasswordButton";
            this.GeneratePasswordButton.Size = new System.Drawing.Size(220, 44);
            this.GeneratePasswordButton.TabIndex = 39;
            this.GeneratePasswordButton.Text = "Generate";
            this.GeneratePasswordButton.UseVisualStyleBackColor = false;
            this.GeneratePasswordButton.Click += new System.EventHandler(this.GeneratePasswordButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackButton.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BackButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.BackButton.Location = new System.Drawing.Point(952, 897);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(125, 44);
            this.BackButton.TabIndex = 38;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // NewPasswordLabel
            // 
            this.NewPasswordLabel.AutoSize = true;
            this.NewPasswordLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NewPasswordLabel.Location = new System.Drawing.Point(303, 737);
            this.NewPasswordLabel.Name = "NewPasswordLabel";
            this.NewPasswordLabel.Size = new System.Drawing.Size(232, 65);
            this.NewPasswordLabel.TabIndex = 37;
            this.NewPasswordLabel.Text = "Password:";
            // 
            // SimpleRadioButton
            // 
            this.SimpleRadioButton.AutoSize = true;
            this.SimpleRadioButton.Location = new System.Drawing.Point(554, 34);
            this.SimpleRadioButton.Name = "SimpleRadioButton";
            this.SimpleRadioButton.Size = new System.Drawing.Size(176, 34);
            this.SimpleRadioButton.TabIndex = 41;
            this.SimpleRadioButton.Text = "Simple Password";
            this.SimpleRadioButton.UseVisualStyleBackColor = true;
            // 
            // ComplexRadioButton
            // 
            this.ComplexRadioButton.AutoSize = true;
            this.ComplexRadioButton.Checked = true;
            this.ComplexRadioButton.Location = new System.Drawing.Point(110, 34);
            this.ComplexRadioButton.Name = "ComplexRadioButton";
            this.ComplexRadioButton.Size = new System.Drawing.Size(196, 34);
            this.ComplexRadioButton.TabIndex = 42;
            this.ComplexRadioButton.TabStop = true;
            this.ComplexRadioButton.Text = "Complex Password";
            this.ComplexRadioButton.UseVisualStyleBackColor = true;
            // 
            // KeywordTextbox
            // 
            this.KeywordTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.KeywordTextbox.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.KeywordTextbox.Location = new System.Drawing.Point(232, 44);
            this.KeywordTextbox.Name = "KeywordTextbox";
            this.KeywordTextbox.Size = new System.Drawing.Size(390, 35);
            this.KeywordTextbox.TabIndex = 44;
            // 
            // SimpleKeywordLabel
            // 
            this.SimpleKeywordLabel.AutoSize = true;
            this.SimpleKeywordLabel.Location = new System.Drawing.Point(88, 44);
            this.SimpleKeywordLabel.Name = "SimpleKeywordLabel";
            this.SimpleKeywordLabel.Size = new System.Drawing.Size(138, 30);
            this.SimpleKeywordLabel.TabIndex = 43;
            this.SimpleKeywordLabel.Text = "Your keyword:";
            // 
            // LenghtTrackBar
            // 
            this.LenghtTrackBar.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.LenghtTrackBar.Location = new System.Drawing.Point(303, 585);
            this.LenghtTrackBar.Maximum = 20;
            this.LenghtTrackBar.Minimum = 6;
            this.LenghtTrackBar.Name = "LenghtTrackBar";
            this.LenghtTrackBar.Size = new System.Drawing.Size(511, 45);
            this.LenghtTrackBar.TabIndex = 45;
            this.LenghtTrackBar.Value = 6;
            // 
            // LenghtLabel
            // 
            this.LenghtLabel.AutoSize = true;
            this.LenghtLabel.Location = new System.Drawing.Point(389, 535);
            this.LenghtLabel.Name = "LenghtLabel";
            this.LenghtLabel.Size = new System.Drawing.Size(146, 30);
            this.LenghtLabel.TabIndex = 46;
            this.LenghtLabel.Text = "Choose lenght:";
            // 
            // CapitalLettersCheckBox
            // 
            this.CapitalLettersCheckBox.AutoSize = true;
            this.CapitalLettersCheckBox.Location = new System.Drawing.Point(314, 99);
            this.CapitalLettersCheckBox.Name = "CapitalLettersCheckBox";
            this.CapitalLettersCheckBox.Size = new System.Drawing.Size(150, 34);
            this.CapitalLettersCheckBox.TabIndex = 47;
            this.CapitalLettersCheckBox.Text = "Capital letters";
            this.CapitalLettersCheckBox.UseVisualStyleBackColor = true;
            // 
            // NumbersCheckBox
            // 
            this.NumbersCheckBox.AutoSize = true;
            this.NumbersCheckBox.Location = new System.Drawing.Point(314, 139);
            this.NumbersCheckBox.Name = "NumbersCheckBox";
            this.NumbersCheckBox.Size = new System.Drawing.Size(113, 34);
            this.NumbersCheckBox.TabIndex = 48;
            this.NumbersCheckBox.Text = "Numbers";
            this.NumbersCheckBox.UseVisualStyleBackColor = true;
            // 
            // SpecialCharsCheckBox
            // 
            this.SpecialCharsCheckBox.AutoSize = true;
            this.SpecialCharsCheckBox.Location = new System.Drawing.Point(470, 382);
            this.SpecialCharsCheckBox.Name = "SpecialCharsCheckBox";
            this.SpecialCharsCheckBox.Size = new System.Drawing.Size(186, 34);
            this.SpecialCharsCheckBox.TabIndex = 49;
            this.SpecialCharsCheckBox.Text = "Special characters";
            this.SpecialCharsCheckBox.UseVisualStyleBackColor = true;
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveButton.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SaveButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.SaveButton.Location = new System.Drawing.Point(443, 843);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(220, 44);
            this.SaveButton.TabIndex = 50;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // AddCharactersRadioButton
            // 
            this.AddCharactersRadioButton.AutoSize = true;
            this.AddCharactersRadioButton.Location = new System.Drawing.Point(477, 233);
            this.AddCharactersRadioButton.Name = "AddCharactersRadioButton";
            this.AddCharactersRadioButton.Size = new System.Drawing.Size(111, 34);
            this.AddCharactersRadioButton.TabIndex = 52;
            this.AddCharactersRadioButton.Text = "Add only";
            this.AddCharactersRadioButton.UseVisualStyleBackColor = true;
            // 
            // ReplaceRadioButton
            // 
            this.ReplaceRadioButton.AutoSize = true;
            this.ReplaceRadioButton.Checked = true;
            this.ReplaceRadioButton.Location = new System.Drawing.Point(199, 233);
            this.ReplaceRadioButton.Name = "ReplaceRadioButton";
            this.ReplaceRadioButton.Size = new System.Drawing.Size(194, 34);
            this.ReplaceRadioButton.TabIndex = 51;
            this.ReplaceRadioButton.TabStop = true;
            this.ReplaceRadioButton.Text = "Replace characters";
            this.ReplaceRadioButton.UseVisualStyleBackColor = true;
            // 
            // GeneratedPasswordLabel
            // 
            this.GeneratedPasswordLabel.AutoSize = true;
            this.GeneratedPasswordLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GeneratedPasswordLabel.Location = new System.Drawing.Point(570, 737);
            this.GeneratedPasswordLabel.Name = "GeneratedPasswordLabel";
            this.GeneratedPasswordLabel.Size = new System.Drawing.Size(145, 65);
            this.GeneratedPasswordLabel.TabIndex = 53;
            this.GeneratedPasswordLabel.Text = "label1";
            // 
            // SimplePasswordGroupBox
            // 
            this.SimplePasswordGroupBox.Controls.Add(this.AddCharactersRadioButton);
            this.SimplePasswordGroupBox.Controls.Add(this.ReplaceRadioButton);
            this.SimplePasswordGroupBox.Controls.Add(this.SimpleKeywordLabel);
            this.SimplePasswordGroupBox.Controls.Add(this.KeywordTextbox);
            this.SimplePasswordGroupBox.Controls.Add(this.CapitalLettersCheckBox);
            this.SimplePasswordGroupBox.Controls.Add(this.NumbersCheckBox);
            this.SimplePasswordGroupBox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SimplePasswordGroupBox.Location = new System.Drawing.Point(156, 203);
            this.SimplePasswordGroupBox.Name = "SimplePasswordGroupBox";
            this.SimplePasswordGroupBox.Size = new System.Drawing.Size(795, 288);
            this.SimplePasswordGroupBox.TabIndex = 54;
            this.SimplePasswordGroupBox.TabStop = false;
            this.SimplePasswordGroupBox.Text = "Simple Password";
            // 
            // PasswordTypeGroupBox
            // 
            this.PasswordTypeGroupBox.Controls.Add(this.ComplexRadioButton);
            this.PasswordTypeGroupBox.Controls.Add(this.SimpleRadioButton);
            this.PasswordTypeGroupBox.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.PasswordTypeGroupBox.Location = new System.Drawing.Point(156, 73);
            this.PasswordTypeGroupBox.Name = "PasswordTypeGroupBox";
            this.PasswordTypeGroupBox.Size = new System.Drawing.Size(795, 88);
            this.PasswordTypeGroupBox.TabIndex = 55;
            this.PasswordTypeGroupBox.TabStop = false;
            this.PasswordTypeGroupBox.Text = "Choose a type";
            // 
            // CharacterNumberLabel
            // 
            this.CharacterNumberLabel.AutoSize = true;
            this.CharacterNumberLabel.Location = new System.Drawing.Point(547, 535);
            this.CharacterNumberLabel.Name = "CharacterNumberLabel";
            this.CharacterNumberLabel.Size = new System.Drawing.Size(61, 30);
            this.CharacterNumberLabel.TabIndex = 56;
            this.CharacterNumberLabel.Text = "label1";
            // 
            // CharactersLabel
            // 
            this.CharactersLabel.AutoSize = true;
            this.CharactersLabel.Location = new System.Drawing.Point(619, 535);
            this.CharactersLabel.Name = "CharactersLabel";
            this.CharactersLabel.Size = new System.Drawing.Size(101, 30);
            this.CharactersLabel.TabIndex = 57;
            this.CharactersLabel.Text = "characters";
            // 
            // GeneratePasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(1120, 978);
            this.Controls.Add(this.CharactersLabel);
            this.Controls.Add(this.CharacterNumberLabel);
            this.Controls.Add(this.PasswordTypeGroupBox);
            this.Controls.Add(this.GeneratedPasswordLabel);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.SpecialCharsCheckBox);
            this.Controls.Add(this.LenghtLabel);
            this.Controls.Add(this.LenghtTrackBar);
            this.Controls.Add(this.GeneratePasswordButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.NewPasswordLabel);
            this.Controls.Add(this.GeneratePasswordHeader);
            this.Controls.Add(this.SimplePasswordGroupBox);
            this.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "GeneratePasswordForm";
            this.Text = "Password Manager - Generate Password";
            ((System.ComponentModel.ISupportInitialize)(this.LenghtTrackBar)).EndInit();
            this.SimplePasswordGroupBox.ResumeLayout(false);
            this.SimplePasswordGroupBox.PerformLayout();
            this.PasswordTypeGroupBox.ResumeLayout(false);
            this.PasswordTypeGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label GeneratePasswordHeader;
        private Button GeneratePasswordButton;
        private Button BackButton;
        private Label NewPasswordLabel;
        private RadioButton SimpleRadioButton;
        private RadioButton ComplexRadioButton;
        private TextBox KeywordTextbox;
        private Label SimpleKeywordLabel;
        private TrackBar LenghtTrackBar;
        private Label LenghtLabel;
        private CheckBox CapitalLettersCheckBox;
        private CheckBox NumbersCheckBox;
        private CheckBox SpecialCharsCheckBox;
        private Button SaveButton;
        private RadioButton AddCharactersRadioButton;
        private RadioButton ReplaceRadioButton;
        private Label GeneratedPasswordLabel;
        private GroupBox SimplePasswordGroupBox;
        private GroupBox PasswordTypeGroupBox;
        private Label CharacterNumberLabel;
        private Label CharactersLabel;
    }
}