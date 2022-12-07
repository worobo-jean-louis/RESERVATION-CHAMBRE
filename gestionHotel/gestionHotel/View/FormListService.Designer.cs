namespace gestionHotel.View
{
    partial class FormListService
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
            this.PrintBuilding_btn = new System.Windows.Forms.Button();
            this.DeleteBuilding_btn = new System.Windows.Forms.Button();
            this.UpdateBuilding_btn = new System.Windows.Forms.Button();
            this.RefreshBuildingList_btn = new System.Windows.Forms.Button();
            this.BuildingFilterInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ListService = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prix = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_chambre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ListService)).BeginInit();
            this.SuspendLayout();
            // 
            // PrintBuilding_btn
            // 
            this.PrintBuilding_btn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PrintBuilding_btn.Location = new System.Drawing.Point(550, 119);
            this.PrintBuilding_btn.Margin = new System.Windows.Forms.Padding(2);
            this.PrintBuilding_btn.Name = "PrintBuilding_btn";
            this.PrintBuilding_btn.Size = new System.Drawing.Size(145, 24);
            this.PrintBuilding_btn.TabIndex = 19;
            this.PrintBuilding_btn.Text = "Print";
            this.PrintBuilding_btn.UseVisualStyleBackColor = true;
            // 
            // DeleteBuilding_btn
            // 
            this.DeleteBuilding_btn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DeleteBuilding_btn.Location = new System.Drawing.Point(378, 119);
            this.DeleteBuilding_btn.Margin = new System.Windows.Forms.Padding(2);
            this.DeleteBuilding_btn.Name = "DeleteBuilding_btn";
            this.DeleteBuilding_btn.Size = new System.Drawing.Size(143, 24);
            this.DeleteBuilding_btn.TabIndex = 18;
            this.DeleteBuilding_btn.Text = "Delete";
            this.DeleteBuilding_btn.UseVisualStyleBackColor = true;
            // 
            // UpdateBuilding_btn
            // 
            this.UpdateBuilding_btn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.UpdateBuilding_btn.Location = new System.Drawing.Point(202, 119);
            this.UpdateBuilding_btn.Margin = new System.Windows.Forms.Padding(2);
            this.UpdateBuilding_btn.Name = "UpdateBuilding_btn";
            this.UpdateBuilding_btn.Size = new System.Drawing.Size(142, 24);
            this.UpdateBuilding_btn.TabIndex = 17;
            this.UpdateBuilding_btn.Text = "Update";
            this.UpdateBuilding_btn.UseVisualStyleBackColor = true;
            // 
            // RefreshBuildingList_btn
            // 
            this.RefreshBuildingList_btn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.RefreshBuildingList_btn.Location = new System.Drawing.Point(53, 119);
            this.RefreshBuildingList_btn.Margin = new System.Windows.Forms.Padding(2);
            this.RefreshBuildingList_btn.Name = "RefreshBuildingList_btn";
            this.RefreshBuildingList_btn.Size = new System.Drawing.Size(123, 24);
            this.RefreshBuildingList_btn.TabIndex = 16;
            this.RefreshBuildingList_btn.Text = "Refresh";
            this.RefreshBuildingList_btn.UseVisualStyleBackColor = true;
            // 
            // BuildingFilterInput
            // 
            this.BuildingFilterInput.Location = new System.Drawing.Point(34, 68);
            this.BuildingFilterInput.Margin = new System.Windows.Forms.Padding(2);
            this.BuildingFilterInput.Name = "BuildingFilterInput";
            this.BuildingFilterInput.Size = new System.Drawing.Size(642, 20);
            this.BuildingFilterInput.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(243, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 31);
            this.label1.TabIndex = 14;
            this.label1.Text = "Liste Des Services";
            // 
            // ListService
            // 
            this.ListService.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListService.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nom,
            this.prix,
            this.Quantite,
            this.Total,
            this.Id_chambre});
            this.ListService.Location = new System.Drawing.Point(53, 200);
            this.ListService.Name = "ListService";
            this.ListService.Size = new System.Drawing.Size(543, 144);
            this.ListService.TabIndex = 20;
            // 
            // ID
            // 
            this.ID.HeaderText = "Id";
            this.ID.Name = "ID";
            this.ID.Visible = false;
            // 
            // Nom
            // 
            this.Nom.HeaderText = "Nom";
            this.Nom.Name = "Nom";
            // 
            // prix
            // 
            this.prix.HeaderText = "prix";
            this.prix.Name = "prix";
            // 
            // Quantite
            // 
            this.Quantite.HeaderText = "Quantite";
            this.Quantite.Name = "Quantite";
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            // 
            // Id_chambre
            // 
            this.Id_chambre.HeaderText = "Id_chambre";
            this.Id_chambre.Name = "Id_chambre";
            // 
            // FormListService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 399);
            this.Controls.Add(this.ListService);
            this.Controls.Add(this.PrintBuilding_btn);
            this.Controls.Add(this.DeleteBuilding_btn);
            this.Controls.Add(this.UpdateBuilding_btn);
            this.Controls.Add(this.RefreshBuildingList_btn);
            this.Controls.Add(this.BuildingFilterInput);
            this.Controls.Add(this.label1);
            this.Name = "FormListService";
            this.Text = "FormListService";
            this.Load += new System.EventHandler(this.FormListService_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ListService)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button PrintBuilding_btn;
        private System.Windows.Forms.Button DeleteBuilding_btn;
        private System.Windows.Forms.Button UpdateBuilding_btn;
        private System.Windows.Forms.Button RefreshBuildingList_btn;
        private System.Windows.Forms.TextBox BuildingFilterInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView ListService;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn prix;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantite;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_chambre;
    }
}