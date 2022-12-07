namespace gestionHotel.View
{
    partial class FormListChambre
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
            this.ListChambre = new System.Windows.Forms.DataGridView();
            this.button_mod = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_pri = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.REFRESH = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NUMERO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TYPE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ListChambre)).BeginInit();
            this.SuspendLayout();
            // 
            // ListChambre
            // 
            this.ListChambre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListChambre.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.NUMERO,
            this.TYPE,
            this.Column1});
            this.ListChambre.Location = new System.Drawing.Point(27, 194);
            this.ListChambre.Name = "ListChambre";
            this.ListChambre.Size = new System.Drawing.Size(581, 166);
            this.ListChambre.TabIndex = 14;
            // 
            // button_mod
            // 
            this.button_mod.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_mod.Location = new System.Drawing.Point(214, 136);
            this.button_mod.Name = "button_mod";
            this.button_mod.Size = new System.Drawing.Size(69, 23);
            this.button_mod.TabIndex = 13;
            this.button_mod.Text = "Update";
            this.button_mod.UseVisualStyleBackColor = false;
            // 
            // button_delete
            // 
            this.button_delete.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_delete.Location = new System.Drawing.Point(319, 136);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(74, 23);
            this.button_delete.TabIndex = 12;
            this.button_delete.Text = "delete";
            this.button_delete.UseVisualStyleBackColor = false;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // button_pri
            // 
            this.button_pri.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_pri.Location = new System.Drawing.Point(415, 136);
            this.button_pri.Name = "button_pri";
            this.button_pri.Size = new System.Drawing.Size(80, 23);
            this.button_pri.TabIndex = 11;
            this.button_pri.Text = "print";
            this.button_pri.UseVisualStyleBackColor = false;
            this.button_pri.Click += new System.EventHandler(this.button_pri_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(189, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "LISTE DES CHAMBRES";
            // 
            // REFRESH
            // 
            this.REFRESH.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.REFRESH.Location = new System.Drawing.Point(112, 136);
            this.REFRESH.Name = "REFRESH";
            this.REFRESH.Size = new System.Drawing.Size(67, 23);
            this.REFRESH.TabIndex = 9;
            this.REFRESH.Text = "Refresh";
            this.REFRESH.UseVisualStyleBackColor = false;
            this.REFRESH.Click += new System.EventHandler(this.REFRESH_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(27, 80);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(581, 20);
            this.textBox1.TabIndex = 8;
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.Visible = false;
            this.id.Width = 150;
            // 
            // NUMERO
            // 
            this.NUMERO.HeaderText = "NOM";
            this.NUMERO.Name = "NUMERO";
            this.NUMERO.Width = 180;
            // 
            // TYPE
            // 
            this.TYPE.FillWeight = 150F;
            this.TYPE.HeaderText = "NUMERO";
            this.TYPE.Name = "TYPE";
            this.TYPE.Width = 180;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "TYPE";
            this.Column1.Name = "Column1";
            this.Column1.Width = 180;
            // 
            // FormListChambre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 378);
            this.Controls.Add(this.ListChambre);
            this.Controls.Add(this.button_mod);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.button_pri);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.REFRESH);
            this.Controls.Add(this.textBox1);
            this.Name = "FormListChambre";
            this.Text = "FormListChambre";
            this.Load += new System.EventHandler(this.FormListChambre_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ListChambre)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ListChambre;
        private System.Windows.Forms.Button button_mod;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_pri;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button REFRESH;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn NUMERO;
        private System.Windows.Forms.DataGridViewTextBoxColumn TYPE;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}