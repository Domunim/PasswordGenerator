namespace PasswordGeneratorUI
{
    partial class PasswordManagerMainScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PasswordManagerMainScreen));
            this.YourPasswordsHeader = new System.Windows.Forms.Label();
            this.GenerateButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.PasswordListBox = new System.Windows.Forms.ListBox();
            this.DeletePasswordButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // YourPasswordsHeader
            // 
            this.YourPasswordsHeader.AutoSize = true;
            this.YourPasswordsHeader.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.YourPasswordsHeader.Location = new System.Drawing.Point(309, 36);
            this.YourPasswordsHeader.Name = "YourPasswordsHeader";
            this.YourPasswordsHeader.Size = new System.Drawing.Size(231, 40);
            this.YourPasswordsHeader.TabIndex = 34;
            this.YourPasswordsHeader.Text = "Your Passwords";
            // 
            // GenerateButton
            // 
            this.GenerateButton.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.GenerateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GenerateButton.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GenerateButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.GenerateButton.Location = new System.Drawing.Point(155, 477);
            this.GenerateButton.Name = "GenerateButton";
            this.GenerateButton.Size = new System.Drawing.Size(300, 44);
            this.GenerateButton.TabIndex = 33;
            this.GenerateButton.Text = "Generate new password";
            this.GenerateButton.UseVisualStyleBackColor = false;
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ExitButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ExitButton.Location = new System.Drawing.Point(688, 561);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(190, 44);
            this.ExitButton.TabIndex = 31;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = false;
            // 
            // PasswordListBox
            // 
            this.PasswordListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.PasswordListBox.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.PasswordListBox.FormattingEnabled = true;
            this.PasswordListBox.ItemHeight = 30;
            this.PasswordListBox.Location = new System.Drawing.Point(144, 100);
            this.PasswordListBox.Name = "PasswordListBox";
            this.PasswordListBox.Size = new System.Drawing.Size(649, 334);
            this.PasswordListBox.TabIndex = 35;
            // 
            // DeletePasswordButton
            // 
            this.DeletePasswordButton.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.DeletePasswordButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeletePasswordButton.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DeletePasswordButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.DeletePasswordButton.Location = new System.Drawing.Point(471, 477);
            this.DeletePasswordButton.Name = "DeletePasswordButton";
            this.DeletePasswordButton.Size = new System.Drawing.Size(300, 44);
            this.DeletePasswordButton.TabIndex = 36;
            this.DeletePasswordButton.Text = "Delete password";
            this.DeletePasswordButton.UseVisualStyleBackColor = false;
            // 
            // PasswordManagerMainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(902, 640);
            this.Controls.Add(this.DeletePasswordButton);
            this.Controls.Add(this.PasswordListBox);
            this.Controls.Add(this.YourPasswordsHeader);
            this.Controls.Add(this.GenerateButton);
            this.Controls.Add(this.ExitButton);
            this.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "PasswordManagerMainScreen";
            this.Text = "Password Manager - Your Passwords";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label YourPasswordsHeader;
        private Button GenerateButton;
        private Button ExitButton;
        private ListBox PasswordListBox;
        private Button DeletePasswordButton;
    }
}