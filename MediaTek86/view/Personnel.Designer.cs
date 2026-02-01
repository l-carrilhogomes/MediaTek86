namespace MediaTek86.view
{
    partial class Personnel
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
            personnel_grid = new DataGridView();
            addpersonnel_button = new Button();
            deletepersonnel_button = new Button();
            modifypersonnel_button = new Button();
            gestionabsences_button = new Button();
            disconnect_button = new Button();
            ((System.ComponentModel.ISupportInitialize)personnel_grid).BeginInit();
            SuspendLayout();
            // 
            // personnel_grid
            // 
            personnel_grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            personnel_grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            personnel_grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            personnel_grid.MultiSelect = false;
            personnel_grid.Location = new Point(12, 12);
            personnel_grid.Name = "personnel_grid";
            personnel_grid.RowHeadersWidth = 51;
            personnel_grid.Size = new Size(951, 824);
            personnel_grid.TabIndex = 0;
            // 
            // addpersonnel_button
            // 
            addpersonnel_button.Location = new Point(969, 12);
            addpersonnel_button.Name = "addpersonnel_button";
            addpersonnel_button.Size = new Size(203, 29);
            addpersonnel_button.TabIndex = 1;
            addpersonnel_button.Text = "Ajouter un personnel";
            addpersonnel_button.UseVisualStyleBackColor = true;
            addpersonnel_button.Click += new System.EventHandler(this.addpersonnel_button_Click);
            // 
            // deletepersonnel_button
            // 
            deletepersonnel_button.Location = new Point(969, 47);
            deletepersonnel_button.Name = "deletepersonnel_button";
            deletepersonnel_button.Size = new Size(203, 29);
            deletepersonnel_button.TabIndex = 2;
            deletepersonnel_button.Text = "Supprimer un personnel";
            deletepersonnel_button.UseVisualStyleBackColor = true;
            deletepersonnel_button.Click += new System.EventHandler(this.deletepersonnel_button_Click);
            // 
            // modifypersonnel_button
            // 
            modifypersonnel_button.Location = new Point(969, 82);
            modifypersonnel_button.Name = "modifypersonnel_button";
            modifypersonnel_button.Size = new Size(203, 29);
            modifypersonnel_button.TabIndex = 3;
            modifypersonnel_button.Text = "Modifier un personnel";
            modifypersonnel_button.UseVisualStyleBackColor = true;
            modifypersonnel_button.Click += new System.EventHandler(this.modifypersonnel_button_Click);
            // 
            // gestionabsences_button
            // 
            gestionabsences_button.Location = new Point(969, 117);
            gestionabsences_button.Name = "gestionabsences_button";
            gestionabsences_button.Size = new Size(203, 29);
            gestionabsences_button.TabIndex = 4;
            gestionabsences_button.Text = "Gestion des absences";
            gestionabsences_button.UseVisualStyleBackColor = true;
            gestionabsences_button.Click += new System.EventHandler(this.gestionabsences_button_Click);
            // 
            // disconnect_button
            // 
            disconnect_button.Location = new Point(969, 152);
            disconnect_button.Name = "disconnect_button";
            disconnect_button.Size = new Size(203, 29);
            disconnect_button.TabIndex = 5;
            disconnect_button.Text = "Déconnexion";
            disconnect_button.UseVisualStyleBackColor = true;
            disconnect_button.Click += new System.EventHandler(this.disconnect_button_Click);
            // 
            // Personnel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1389, 848);
            Controls.Add(disconnect_button);
            Controls.Add(gestionabsences_button);
            Controls.Add(modifypersonnel_button);
            Controls.Add(deletepersonnel_button);
            Controls.Add(addpersonnel_button);
            Controls.Add(personnel_grid);
            Name = "Personnel";
            Text = "Personnel";
            ((System.ComponentModel.ISupportInitialize)personnel_grid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView personnel_grid;
        private Button addpersonnel_button;
        private Button deletepersonnel_button;
        private Button modifypersonnel_button;
        private Button gestionabsences_button;
        private Button disconnect_button;
    }
}