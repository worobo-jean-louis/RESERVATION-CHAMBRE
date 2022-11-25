namespace gestionHotel.View
{
    partial class FormListClient
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
            this.label1 = new System.Windows.Forms.Label();
            this.PrintBuilding_btn = new System.Windows.Forms.Button();
            this.DeleteBuilding_btn = new System.Windows.Forms.Button();
            this.UpdateBuilding_btn = new System.Windows.Forms.Button();
            this.RefreshBuildingList_btn = new System.Windows.Forms.Button();
            this.BuildingFilterInput = new System.Windows.Forms.TextBox();
            this.listClients = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adresse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Genre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telephone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.listClients)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(250, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Liste Des Clients";
            // 
            // PrintBuilding_btn
            // 
            this.PrintBuilding_btn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PrintBuilding_btn.Location = new System.Drawing.Point(537, 151);
            this.PrintBuilding_btn.Margin = new System.Windows.Forms.Padding(2);
            this.PrintBuilding_btn.Name = "PrintBuilding_btn";
            this.PrintBuilding_btn.Size = new System.Drawing.Size(145, 24);
            this.PrintBuilding_btn.TabIndex = 12;
            this.PrintBuilding_btn.Text = "Print";
            this.PrintBuilding_btn.UseVisualStyleBackColor = true;
            // 
            // DeleteBuilding_btn
            // 
            this.DeleteBuilding_btn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DeleteBuilding_btn.Location = new System.Drawing.Point(365, 151);
            this.DeleteBuilding_btn.Margin = new System.Windows.Forms.Padding(2);
            this.DeleteBuilding_btn.Name = "DeleteBuilding_btn";
            this.DeleteBuilding_btn.Size = new System.Drawing.Size(143, 24);
            this.DeleteBuilding_btn.TabIndex = 11;
            this.DeleteBuilding_btn.Text = "Delete";
            this.DeleteBuilding_btn.UseVisualStyleBackColor = true;
            // 
            // UpdateBuilding_btn
            // 
            this.UpdateBuilding_btn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.UpdateBuilding_btn.Location = new System.Drawing.Point(189, 151);
            this.UpdateBuilding_btn.Margin = new System.Windows.Forms.Padding(2);
            this.UpdateBuilding_btn.Name = "UpdateBuilding_btn";
            this.UpdateBuilding_btn.Size = new System.Drawing.Size(142, 24);
            this.UpdateBuilding_btn.TabIndex = 10;
            this.UpdateBuilding_btn.Text = "Update";
            this.UpdateBuilding_btn.UseVisualStyleBackColor = true;
            // 
            // RefreshBuildingList_btn
            // 
            this.RefreshBuildingList_btn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.RefreshBuildingList_btn.Location = new System.Drawing.Point(40, 151);
            this.RefreshBuildingList_btn.Margin = new System.Windows.Forms.Padding(2);
            this.RefreshBuildingList_btn.Name = "RefreshBuildingList_btn";
            this.RefreshBuildingList_btn.Size = new System.Drawing.Size(123, 24);
            this.RefreshBuildingList_btn.TabIndex = 9;
            this.RefreshBuildingList_btn.Text = "Refresh";
            this.RefreshBuildingList_btn.UseVisualStyleBackColor = true;
            // 
            // BuildingFilterInput
            // 
            this.BuildingFilterInput.Location = new System.Drawing.Point(40, 100);
            this.BuildingFilterInput.Margin = new System.Windows.Forms.Padding(2);
            this.BuildingFilterInput.Name = "BuildingFilterInput";
            this.BuildingFilterInput.Size = new System.Drawing.Size(642, 20);
            this.BuildingFilterInput.TabIndex = 8;
            // 
            // listClients
            // 
            this.listClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listClients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Nom,
            this.Prenom,
            this.Adresse,
            this.Genre,
            this.Status,
            this.Telephone});
            this.listClients.Location = new System.Drawing.Point(40, 200);
            this.listClients.Name = "listClients";
            this.listClients.Size = new System.Drawing.Size(642, 219);
            this.listClients.TabIndex = 13;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.Visible = false;
            // 
            // Nom
            // 
            this.Nom.HeaderText = "Nom";
            this.Nom.Name = "Nom";
            // 
            // Prenom
            // 
            this.Prenom.HeaderText = "Prenom";
            this.Prenom.Name = "Prenom";
            // 
            // Adresse
            // 
            this.Adresse.HeaderText = "Adresse";
            this.Adresse.Name = "Adresse";
            // 
            // Genre
            // 
            this.Genre.HeaderText = "Genre";
            this.Genre.Name = "Genre";
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            // 
            // Telephone
            // 
            this.Telephone.HeaderText = "Telephone";
            this.Telephone.Name = "Telephone";
            // 
            // FormListClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 438);
            this.Controls.Add(this.listClients);
            this.Controls.Add(this.PrintBuilding_btn);
            this.Controls.Add(this.DeleteBuilding_btn);
            this.Controls.Add(this.UpdateBuilding_btn);
            this.Controls.Add(this.RefreshBuildingList_btn);
            this.Controls.Add(this.BuildingFilterInput);
            this.Controls.Add(this.label1);
            this.Name = "FormListClient";
            this.Text = "FormListClient";
            this.Load += new System.EventHandler(this.FormListClient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listClients)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button PrintBuilding_btn;
        private System.Windows.Forms.Button DeleteBuilding_btn;
        private System.Windows.Forms.Button UpdateBuilding_btn;
        private System.Windows.Forms.Button RefreshBuildingList_btn;
        private System.Windows.Forms.TextBox BuildingFilterInput;
        private System.Windows.Forms.DataGridView listClients;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prenom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adresse;
        private System.Windows.Forms.DataGridViewTextBoxColumn Genre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telephone;
    }
}