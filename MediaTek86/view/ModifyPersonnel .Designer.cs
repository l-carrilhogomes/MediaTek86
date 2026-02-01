namespace MediaTek86.view
{
    partial class ModifyPersonnel
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
            lastname_label = new Label();
            lastname_textbox = new TextBox();
            firstname_textbox = new TextBox();
            firstname_label = new Label();
            tel_textbox = new TextBox();
            tel_label = new Label();
            mail_textbox = new TextBox();
            mail_label = new Label();
            service_dropdown = new ComboBox();
            service_label = new Label();
            modifyPersonnel_button = new Button();
            SuspendLayout();
            // 
            // lastname_label
            // 
            lastname_label.AutoSize = true;
            lastname_label.Location = new Point(12, 9);
            lastname_label.Name = "lastname_label";
            lastname_label.Size = new Size(42, 20);
            lastname_label.TabIndex = 0;
            lastname_label.Text = "Nom";
            // 
            // lastname_textbox
            // 
            lastname_textbox.Location = new Point(12, 32);
            lastname_textbox.Name = "lastname_textbox";
            lastname_textbox.Size = new Size(235, 27);
            lastname_textbox.TabIndex = 2;
            // 
            // firstname_textbox
            // 
            firstname_textbox.Location = new Point(12, 95);
            firstname_textbox.Name = "firstname_textbox";
            firstname_textbox.Size = new Size(235, 27);
            firstname_textbox.TabIndex = 4;
            // 
            // firstname_label
            // 
            firstname_label.AutoSize = true;
            firstname_label.Location = new Point(12, 72);
            firstname_label.Name = "firstname_label";
            firstname_label.Size = new Size(60, 20);
            firstname_label.TabIndex = 3;
            firstname_label.Text = "Prénom";
            // 
            // tel_textbox
            // 
            tel_textbox.Location = new Point(12, 159);
            tel_textbox.Name = "tel_textbox";
            tel_textbox.Size = new Size(235, 27);
            tel_textbox.TabIndex = 6;
            // 
            // tel_label
            // 
            tel_label.AutoSize = true;
            tel_label.Location = new Point(12, 136);
            tel_label.Name = "tel_label";
            tel_label.Size = new Size(78, 20);
            tel_label.TabIndex = 5;
            tel_label.Text = "Téléphone";
            // 
            // mail_textbox
            // 
            mail_textbox.Location = new Point(12, 223);
            mail_textbox.Name = "mail_textbox";
            mail_textbox.Size = new Size(235, 27);
            mail_textbox.TabIndex = 8;
            // 
            // mail_label
            // 
            mail_label.AutoSize = true;
            mail_label.Location = new Point(12, 200);
            mail_label.Name = "mail_label";
            mail_label.Size = new Size(38, 20);
            mail_label.TabIndex = 7;
            mail_label.Text = "Mail";
            // 
            // service_dropdown
            // 
            service_dropdown.DropDownStyle = ComboBoxStyle.DropDownList;
            service_dropdown.FormattingEnabled = true;
            service_dropdown.Location = new Point(12, 287);
            service_dropdown.Name = "service_dropdown";
            service_dropdown.Size = new Size(235, 28);
            service_dropdown.TabIndex = 9;
            // 
            // service_label
            // 
            service_label.AutoSize = true;
            service_label.Location = new Point(12, 264);
            service_label.Name = "service_label";
            service_label.Size = new Size(56, 20);
            service_label.TabIndex = 10;
            service_label.Text = "Service";
            // 
            // modifyPersonnel_button
            // 
            modifyPersonnel_button.Location = new Point(12, 334);
            modifyPersonnel_button.Name = "modifyPersonnel_button";
            modifyPersonnel_button.Size = new Size(235, 29);
            modifyPersonnel_button.TabIndex = 11;
            modifyPersonnel_button.Text = "Modifier un personnel";
            modifyPersonnel_button.UseVisualStyleBackColor = true;
            modifyPersonnel_button.Click += new System.EventHandler(this.modifyPersonnel_button_Click);
            // 
            // ModifyPersonnel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(modifyPersonnel_button);
            Controls.Add(service_label);
            Controls.Add(service_dropdown);
            Controls.Add(mail_textbox);
            Controls.Add(mail_label);
            Controls.Add(tel_textbox);
            Controls.Add(tel_label);
            Controls.Add(firstname_textbox);
            Controls.Add(firstname_label);
            Controls.Add(lastname_textbox);
            Controls.Add(lastname_label);
            Name = "ModifyPersonnel";
            Text = "ModifyPersonnel";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lastname_label;
        private TextBox lastname_textbox;
        private TextBox firstname_textbox;
        private Label firstname_label;
        private TextBox tel_textbox;
        private Label tel_label;
        private TextBox mail_textbox;
        private Label mail_label;
        private ComboBox service_dropdown;
        private Label service_label;
        private Button modifyPersonnel_button;
    }
}