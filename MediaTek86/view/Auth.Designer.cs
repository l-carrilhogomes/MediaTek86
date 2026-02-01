namespace MediaTek86.view
{
    partial class Auth
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
            usernameLabel = new Label();
            usernameTextbox = new TextBox();
            passwordLabel = new Label();
            passwordTextbox = new MaskedTextBox();
            connectButton = new Button();
            SuspendLayout();
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Location = new Point(12, 27);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(123, 20);
            usernameLabel.TabIndex = 0;
            usernameLabel.Text = "Nom d'utilisateur";
            // 
            // usernameTextbox
            // 
            usernameTextbox.Location = new Point(12, 50);
            usernameTextbox.Name = "usernameTextbox";
            usernameTextbox.Size = new Size(235, 27);
            usernameTextbox.TabIndex = 1;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new Point(12, 105);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(98, 20);
            passwordLabel.TabIndex = 3;
            passwordLabel.Text = "Mot de passe";
            // 
            // passwordTextbox
            // 
            passwordTextbox.Location = new Point(12, 128);
            passwordTextbox.Name = "passwordTextbox";
            passwordTextbox.PasswordChar = '*';
            passwordTextbox.Size = new Size(235, 27);
            passwordTextbox.TabIndex = 4;
            // 
            // connectButton
            // 
            connectButton.Location = new Point(12, 183);
            connectButton.Name = "connectButton";
            connectButton.Size = new Size(235, 29);
            connectButton.TabIndex = 5;
            connectButton.Text = "Se connecter";
            connectButton.UseVisualStyleBackColor = true;
            connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // Auth
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(connectButton);
            Controls.Add(passwordTextbox);
            Controls.Add(passwordLabel);
            Controls.Add(usernameTextbox);
            Controls.Add(usernameLabel);
            Name = "Auth";
            Text = "Auth";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label usernameLabel;
        private TextBox usernameTextbox;
        private Label passwordLabel;
        private MaskedTextBox passwordTextbox;
        private Button connectButton;
    }
}