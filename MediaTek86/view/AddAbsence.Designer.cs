namespace MediaTek86.view
{
    partial class AddAbsence
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
            startingdate_label = new Label();
            startingdate_datepicker = new DateTimePicker();
            endingdate_datepicker = new DateTimePicker();
            endingdate_label = new Label();
            motif_dropdown = new ComboBox();
            motif_label = new Label();
            addAbsence_button = new Button();
            SuspendLayout();
            // 
            // startingdate_label
            // 
            startingdate_label.AutoSize = true;
            startingdate_label.Location = new Point(12, 9);
            startingdate_label.Name = "startingdate_label";
            startingdate_label.Size = new Size(105, 20);
            startingdate_label.TabIndex = 0;
            startingdate_label.Text = "Date de début";
            // 
            // startingdate_datepicker
            // 
            startingdate_datepicker.Location = new Point(12, 32);
            startingdate_datepicker.Name = "startingdate_datepicker";
            startingdate_datepicker.Size = new Size(250, 27);
            startingdate_datepicker.TabIndex = 1;
            // 
            // endingdate_datepicker
            // 
            endingdate_datepicker.Location = new Point(12, 96);
            endingdate_datepicker.Name = "endingdate_datepicker";
            endingdate_datepicker.Size = new Size(250, 27);
            endingdate_datepicker.TabIndex = 3;
            // 
            // endingdate_label
            // 
            endingdate_label.AutoSize = true;
            endingdate_label.Location = new Point(12, 73);
            endingdate_label.Name = "endingdate_label";
            endingdate_label.Size = new Size(83, 20);
            endingdate_label.TabIndex = 2;
            endingdate_label.Text = "Date de fin";
            // 
            // motif_dropdown
            // 
            motif_dropdown.DropDownStyle = ComboBoxStyle.DropDownList;
            motif_dropdown.FormattingEnabled = true;
            motif_dropdown.Location = new Point(12, 160);
            motif_dropdown.Name = "motif_dropdown";
            motif_dropdown.Size = new Size(250, 28);
            motif_dropdown.TabIndex = 10;
            // 
            // motif_label
            // 
            motif_label.AutoSize = true;
            motif_label.Location = new Point(12, 137);
            motif_label.Name = "motif_label";
            motif_label.Size = new Size(45, 20);
            motif_label.TabIndex = 11;
            motif_label.Text = "Motif";
            // 
            // addAbsence_button
            // 
            addAbsence_button.Location = new Point(12, 215);
            addAbsence_button.Name = "addAbsence_button";
            addAbsence_button.Size = new Size(250, 29);
            addAbsence_button.TabIndex = 12;
            addAbsence_button.Text = "Ajouter une absence";
            addAbsence_button.UseVisualStyleBackColor = true;
            addAbsence_button.Click += new System.EventHandler(this.addAbsence_button_Click);
            // 
            // AddAbsence
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(974, 585);
            Controls.Add(addAbsence_button);
            Controls.Add(motif_label);
            Controls.Add(motif_dropdown);
            Controls.Add(endingdate_datepicker);
            Controls.Add(endingdate_label);
            Controls.Add(startingdate_datepicker);
            Controls.Add(startingdate_label);
            Name = "AddAbsence";
            Text = "AddAbsence";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label startingdate_label;
        private DateTimePicker startingdate_datepicker;
        private DateTimePicker endingdate_datepicker;
        private Label endingdate_label;
        private ComboBox motif_dropdown;
        private Label motif_label;
        private Button addAbsence_button;
    }
}