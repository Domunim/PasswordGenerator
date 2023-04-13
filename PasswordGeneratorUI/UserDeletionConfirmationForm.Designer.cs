namespace PasswordGeneratorUI
{
    partial class UserDeletionConfirmationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserDeletionConfirmationForm));
            this.UserDeletionConfirmationButton = new System.Windows.Forms.Button();
            this.UserDeletionRejectionButton = new System.Windows.Forms.Button();
            this.UserDeleteHeader = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UserDeletionConfirmationButton
            // 
            this.UserDeletionConfirmationButton.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.UserDeletionConfirmationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UserDeletionConfirmationButton.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UserDeletionConfirmationButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.UserDeletionConfirmationButton.Location = new System.Drawing.Point(118, 130);
            this.UserDeletionConfirmationButton.Name = "UserDeletionConfirmationButton";
            this.UserDeletionConfirmationButton.Size = new System.Drawing.Size(210, 44);
            this.UserDeletionConfirmationButton.TabIndex = 11;
            this.UserDeletionConfirmationButton.Text = "Yes";
            this.UserDeletionConfirmationButton.UseVisualStyleBackColor = false;
            this.UserDeletionConfirmationButton.Click += new System.EventHandler(this.UserDeletionConfirmationButton_Click);
            // 
            // UserDeletionRejectionButton
            // 
            this.UserDeletionRejectionButton.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.UserDeletionRejectionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UserDeletionRejectionButton.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UserDeletionRejectionButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.UserDeletionRejectionButton.Location = new System.Drawing.Point(118, 180);
            this.UserDeletionRejectionButton.Name = "UserDeletionRejectionButton";
            this.UserDeletionRejectionButton.Size = new System.Drawing.Size(210, 44);
            this.UserDeletionRejectionButton.TabIndex = 10;
            this.UserDeletionRejectionButton.Text = "No";
            this.UserDeletionRejectionButton.UseVisualStyleBackColor = false;
            this.UserDeletionRejectionButton.Click += new System.EventHandler(this.UserDeletionRejectionButton_Click);
            // 
            // UserDeleteHeader
            // 
            this.UserDeleteHeader.AutoSize = true;
            this.UserDeleteHeader.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UserDeleteHeader.Location = new System.Drawing.Point(75, 58);
            this.UserDeleteHeader.Name = "UserDeleteHeader";
            this.UserDeleteHeader.Size = new System.Drawing.Size(297, 30);
            this.UserDeleteHeader.TabIndex = 12;
            this.UserDeleteHeader.Text = "Are you sure to delete the user?";
            // 
            // UserDeletionConfirmationForm
            // 
            this.AcceptButton = this.UserDeletionConfirmationButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.CancelButton = this.UserDeletionRejectionButton;
            this.ClientSize = new System.Drawing.Size(459, 300);
            this.Controls.Add(this.UserDeleteHeader);
            this.Controls.Add(this.UserDeletionConfirmationButton);
            this.Controls.Add(this.UserDeletionRejectionButton);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "UserDeletionConfirmationForm";
            this.Text = "Password Manager - Confirm user\'s deletion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button UserDeletionConfirmationButton;
        private Button UserDeletionRejectionButton;
        private Label UserDeleteHeader;
    }
}