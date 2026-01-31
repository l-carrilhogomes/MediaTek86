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
            username_label = new Label();
            username_textbox = new TextBox();
            password_label = new Label();
            password_textbox = new MaskedTextBox();
            connect_button = new Button();
            SuspendLayout();
            // 
            // username_label
            // 
            username_label.AutoSize = true;
            username_label.Location = new Point(12, 27);
            username_label.Name = "username_label";
            username_label.Size = new Size(123, 20);
            username_label.TabIndex = 0;
            username_label.Text = "Nom d'utilisateur";
            // 
            // username_textbox
            // 
            username_textbox.Location = new Point(12, 50);
            username_textbox.Name = "username_textbox";
            username_textbox.Size = new Size(235, 27);
            username_textbox.TabIndex = 1;
            // 
            // password_label
            // 
            password_label.AutoSize = true;
            password_label.Location = new Point(12, 105);
            password_label.Name = "password_label";
            password_label.Size = new Size(98, 20);
            password_label.TabIndex = 3;
            password_label.Text = "Mot de passe";
            // 
            // password_textbox
            // 
            password_textbox.Location = new Point(12, 128);
            password_textbox.Name = "password_textbox";
            password_textbox.PasswordChar = '*';
            password_textbox.Size = new Size(235, 27);
            password_textbox.TabIndex = 4;
            // 
            // connect_button
            // 
            connect_button.Location = new Point(12, 183);
            connect_button.Name = "connect_button";
            connect_button.Size = new Size(235, 29);
            connect_button.TabIndex = 5;
            connect_button.Text = "Se connecter";
            connect_button.UseVisualStyleBackColor = true;
            // 
            // Auth
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(connect_button);
            Controls.Add(password_textbox);
            Controls.Add(password_label);
            Controls.Add(username_textbox);
            Controls.Add(username_label);
            Name = "Auth";
            Text = "Auth";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label username_label;
        private TextBox username_textbox;
        private Label password_label;
        private MaskedTextBox password_textbox;
        private Button connect_button;
    }
}