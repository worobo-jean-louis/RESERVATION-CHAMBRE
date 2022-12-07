namespace gestionHotel.View
{
    partial class FormService
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
            this.button1 = new System.Windows.Forms.Button();
            this.btn_valider = new System.Windows.Forms.Button();
            this.btn_effacer = new System.Windows.Forms.Button();
            this.textBox_prix = new System.Windows.Forms.TextBox();
            this.textBox_qte = new System.Windows.Forms.TextBox();
            this.textBox_chambre = new System.Windows.Forms.TextBox();
            this.textBox_nom = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_total = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(45, 280);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 32);
            this.button1.TabIndex = 32;
            this.button1.Text = "voir";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_valider
            // 
            this.btn_valider.BackColor = System.Drawing.Color.Transparent;
            this.btn_valider.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_valider.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_valider.Location = new System.Drawing.Point(174, 280);
            this.btn_valider.Name = "btn_valider";
            this.btn_valider.Size = new System.Drawing.Size(84, 32);
            this.btn_valider.TabIndex = 31;
            this.btn_valider.Text = "Valider";
            this.btn_valider.UseVisualStyleBackColor = false;
            this.btn_valider.Click += new System.EventHandler(this.btn_valider_Click);
            // 
            // btn_effacer
            // 
            this.btn_effacer.BackColor = System.Drawing.Color.Transparent;
            this.btn_effacer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_effacer.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_effacer.Location = new System.Drawing.Point(299, 280);
            this.btn_effacer.Name = "btn_effacer";
            this.btn_effacer.Size = new System.Drawing.Size(90, 32);
            this.btn_effacer.TabIndex = 30;
            this.btn_effacer.Text = "Effacer";
            this.btn_effacer.UseVisualStyleBackColor = false;
            this.btn_effacer.Click += new System.EventHandler(this.btn_effacer_Click);
            // 
            // textBox_prix
            // 
            this.textBox_prix.Location = new System.Drawing.Point(487, 162);
            this.textBox_prix.Name = "textBox_prix";
            this.textBox_prix.Size = new System.Drawing.Size(161, 20);
            this.textBox_prix.TabIndex = 27;
            // 
            // textBox_qte
            // 
            this.textBox_qte.Location = new System.Drawing.Point(487, 103);
            this.textBox_qte.Name = "textBox_qte";
            this.textBox_qte.Size = new System.Drawing.Size(161, 20);
            this.textBox_qte.TabIndex = 26;
            // 
            // textBox_chambre
            // 
            this.textBox_chambre.Location = new System.Drawing.Point(169, 166);
            this.textBox_chambre.Name = "textBox_chambre";
            this.textBox_chambre.Size = new System.Drawing.Size(161, 20);
            this.textBox_chambre.TabIndex = 25;
            // 
            // textBox_nom
            // 
            this.textBox_nom.Location = new System.Drawing.Point(169, 107);
            this.textBox_nom.Name = "textBox_nom";
            this.textBox_nom.Size = new System.Drawing.Size(161, 20);
            this.textBox_nom.TabIndex = 24;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 107);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 16);
            this.label8.TabIndex = 23;
            this.label8.Text = "Nom";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(380, 166);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 16);
            this.label7.TabIndex = 22;
            this.label7.Text = "Prix Unitaire";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(380, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 16);
            this.label6.TabIndex = 21;
            this.label6.Text = "Quantite";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(401, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 16);
            this.label5.TabIndex = 20;
            this.label5.Text = "Total";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 16);
            this.label4.TabIndex = 19;
            this.label4.Text = "Numero Chambre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(157, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(393, 31);
            this.label1.TabIndex = 17;
            this.label1.Text = "Enregistrement Des Services\r\n";
            // 
            // textBox_total
            // 
            this.textBox_total.Location = new System.Drawing.Point(487, 227);
            this.textBox_total.Name = "textBox_total";
            this.textBox_total.Size = new System.Drawing.Size(161, 20);
            this.textBox_total.TabIndex = 33;
            // 
            // FormService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 326);
            this.Controls.Add(this.textBox_total);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_valider);
            this.Controls.Add(this.btn_effacer);
            this.Controls.Add(this.textBox_prix);
            this.Controls.Add(this.textBox_qte);
            this.Controls.Add(this.textBox_chambre);
            this.Controls.Add(this.textBox_nom);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "FormService";
            this.Text = "FormService";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_valider;
        private System.Windows.Forms.Button btn_effacer;
        private System.Windows.Forms.TextBox textBox_prix;
        private System.Windows.Forms.TextBox textBox_qte;
        private System.Windows.Forms.TextBox textBox_chambre;
        private System.Windows.Forms.TextBox textBox_nom;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_total;
    }
}