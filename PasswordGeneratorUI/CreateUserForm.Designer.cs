namespace PasswordGeneratorUI
{
    partial class CreateUserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateUserForm));
            this.HeaderLabel = new System.Windows.Forms.Label();
            this.CreateUserButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.UserPasswordValue = new System.Windows.Forms.TextBox();
            this.UserPasswordLabel = new System.Windows.Forms.Label();
            this.UserNameLabel = new System.Windows.Forms.Label();
            this.UsernameValue = new System.Windows.Forms.TextBox();
            this.ShowPasswordCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // HeaderLabel
            // 
            this.HeaderLabel.AutoSize = true;
            this.HeaderLabel.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.HeaderLabel.Location = new System.Drawing.Point(37, 36);
            this.HeaderLabel.Name = "HeaderLabel";
            this.HeaderLabel.Size = new System.Drawing.Size(290, 30);
            this.HeaderLabel.TabIndex = 5;
            this.HeaderLabel.Text = "Enter login data for a new user:";
            // 
            // CreateUserButton
            // 
            this.CreateUserButton.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.CreateUserButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateUserButton.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CreateUserButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.CreateUserButton.Location = new System.Drawing.Point(191, 221);
            this.CreateUserButton.Name = "CreateUserButton";
            this.CreateUserButton.Size = new System.Drawing.Size(220, 44);
            this.CreateUserButton.TabIndex = 14;
            this.CreateUserButton.Text = "Create a new user";
            this.CreateUserButton.UseVisualStyleBackColor = false;
            CreateUserForm createUserForm = this;
            EventHandler eventHandler = new System.EventHandler(createUserForm.CreateUserButton_Click);
            this.CreateUserButton.Click += eventHandler;
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackButton.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BackButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.BackButton.Location = new System.Drawing.Point(525, 314);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(125, 44);
            this.BackButton.TabIndex = 13;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // UserPasswordValue
            // 
            this.UserPasswordValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.UserPasswordValue.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.UserPasswordValue.Location = new System.Drawing.Point(201, 149);
            this.UserPasswordValue.Name = "UserPasswordValue";
            this.UserPasswordValue.PasswordChar = '*';
            this.UserPasswordValue.Size = new System.Drawing.Size(301, 35);
            this.UserPasswordValue.TabIndex = 12;
            // 
            // UserPasswordLabel
            // 
            this.UserPasswordLabel.AutoSize = true;
            this.UserPasswordLabel.Location = new System.Drawing.Point(50, 154);
            this.UserPasswordLabel.Name = "UserPasswordLabel";
            this.UserPasswordLabel.Size = new System.Drawing.Size(99, 30);
            this.UserPasswordLabel.TabIndex = 11;
            this.UserPasswordLabel.Text = "Password:";
            // 
            // UserNameLabel
            // 
            this.UserNameLabel.AutoSize = true;
            this.UserNameLabel.Location = new System.Drawing.Point(50, 99);
            this.UserNameLabel.Name = "UserNameLabel";
            this.UserNameLabel.Size = new System.Drawing.Size(107, 30);
            this.UserNameLabel.TabIndex = 10;
            this.UserNameLabel.Text = "Username:";
            // 
            // UsernameValue
            // 
            this.UsernameValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.UsernameValue.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.UsernameValue.Location = new System.Drawing.Point(201, 96);
            this.UsernameValue.Name = "UsernameValue";
            this.UsernameValue.Size = new System.Drawing.Size(301, 35);
            this.UsernameValue.TabIndex = 15;
            // 
            // ShowPasswordCheckBox
            // 
            this.ShowPasswordCheckBox.AutoSize = true;
            this.ShowPasswordCheckBox.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ShowPasswordCheckBox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ShowPasswordCheckBox.Location = new System.Drawing.Point(517, 154);
            this.ShowPasswordCheckBox.Name = "ShowPasswordCheckBox";
            this.ShowPasswordCheckBox.Size = new System.Drawing.Size(133, 25);
            this.ShowPasswordCheckBox.TabIndex = 16;
            this.ShowPasswordCheckBox.Text = "Show password";
            this.ShowPasswordCheckBox.UseVisualStyleBackColor = true;
            this.ShowPasswordCheckBox.CheckedChanged += new System.EventHandler(this.ShowPasswordCheckBox_CheckedChanged);
            // 
            // CreateUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(662, 370);
            this.Controls.Add(this.ShowPasswordCheckBox);
            this.Controls.Add(this.UsernameValue);
            this.Controls.Add(this.CreateUserButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.UserPasswordValue);
            this.Controls.Add(this.UserPasswordLabel);
            this.Controls.Add(this.UserNameLabel);
            this.Controls.Add(this.HeaderLabel);
            this.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "CreateUserForm";
            this.Text = "Password Manager - Create a user";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label HeaderLabel;
        private Button CreateUserButton;
        private Button BackButton;
        private TextBox UserPasswordValue;
        private Label UserPasswordLabel;
        private Label UserNameLabel;
        private TextBox UsernameValue;
        private CheckBox ShowPasswordCheckBox;
    }
}