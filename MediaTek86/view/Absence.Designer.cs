namespace MediaTek86.view
{
    partial class Absence
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
            absence_grid = new DataGridView();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            addabsence_button = new Button();
            deleteabsence_button = new Button();
            modifyabsence_button = new Button();
            ((System.ComponentModel.ISupportInitialize)absence_grid).BeginInit();
            SuspendLayout();
            // 
            // absence_grid
            // 
            absence_grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            absence_grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            absence_grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            absence_grid.MultiSelect = false;
            absence_grid.Location = new Point(12, 12);
            absence_grid.Name = "absence_grid";
            absence_grid.RowHeadersWidth = 51;
            absence_grid.Size = new Size(747, 641);
            absence_grid.TabIndex = 0;
            // 
            // addabsence_button
            // 
            addabsence_button.Location = new Point(781, 12);
            addabsence_button.Name = "addabsence_button";
            addabsence_button.Size = new Size(243, 29);
            addabsence_button.TabIndex = 1;
            addabsence_button.Text = "Ajouter une absence";
            addabsence_button.UseVisualStyleBackColor = true;
            addabsence_button.Click += new System.EventHandler(this.addabsence_button_Click);
            // 
            // deleteabsence_button
            // 
            deleteabsence_button.Location = new Point(781, 47);
            deleteabsence_button.Name = "deleteabsence_button";
            deleteabsence_button.Size = new Size(243, 29);
            deleteabsence_button.TabIndex = 2;
            deleteabsence_button.Text = "Supprimer une absence";
            deleteabsence_button.UseVisualStyleBackColor = true;
            deleteabsence_button.Click += new System.EventHandler(this.deleteabsence_button_Click);
            // 
            // modifyabsence_button
            // 
            modifyabsence_button.Location = new Point(781, 82);
            modifyabsence_button.Name = "modifyabsence_button";
            modifyabsence_button.Size = new Size(243, 29);
            modifyabsence_button.TabIndex = 3;
            modifyabsence_button.Text = "Modifier une absence";
            modifyabsence_button.UseVisualStyleBackColor = true;
            modifyabsence_button.Click += new System.EventHandler(this.modifyabsence_button_Click);
            // 
            // Absence
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1036, 665);
            Controls.Add(modifyabsence_button);
            Controls.Add(deleteabsence_button);
            Controls.Add(addabsence_button);
            Controls.Add(absence_grid);
            Name = "Absence";
            Text = "Absence";
            ((System.ComponentModel.ISupportInitialize)absence_grid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView absence_grid;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button addabsence_button;
        private Button deleteabsence_button;
        private Button modifyabsence_button;
    }
}