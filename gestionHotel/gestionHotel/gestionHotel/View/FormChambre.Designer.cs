﻿namespace gestionHotel.View
{
    partial class FormChambre
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
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button_valider = new System.Windows.Forms.Button();
            this.button_sp = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxnumero = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button_voir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textboxNom = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // comboBox
            // 
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Items.AddRange(new object[] {
            "vip",
            "non vip"});
            this.comboBox.Location = new System.Drawing.Point(173, 207);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(353, 21);
            this.comboBox.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(79, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "NUMERO";
            // 
            // button_valider
            // 
            this.button_valider.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_valider.Location = new System.Drawing.Point(424, 289);
            this.button_valider.Name = "button_valider";
            this.button_valider.Size = new System.Drawing.Size(117, 23);
            this.button_valider.TabIndex = 23;
            this.button_valider.Text = "ENREGISTRER";
            this.button_valider.UseVisualStyleBackColor = false;
            this.button_valider.Click += new System.EventHandler(this.button_valider_Click);
            // 
            // button_sp
            // 
            this.button_sp.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_sp.Location = new System.Drawing.Point(227, 289);
            this.button_sp.Name = "button_sp";
            this.button_sp.Size = new System.Drawing.Size(161, 23);
            this.button_sp.TabIndex = 22;
            this.button_sp.Text = "SUPPRIMER  ";
            this.button_sp.UseVisualStyleBackColor = false;
            this.button_sp.Click += new System.EventHandler(this.button_sp_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(79, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "TYPE";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(79, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "NOM";
            // 
            // textBoxnumero
            // 
            this.textBoxnumero.Location = new System.Drawing.Point(173, 136);
            this.textBoxnumero.Name = "textBoxnumero";
            this.textBoxnumero.Size = new System.Drawing.Size(353, 20);
            this.textBoxnumero.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(118, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(408, 25);
            this.label3.TabIndex = 19;
            this.label3.Text = "ENREGISTREMENT DES CHAMBRES";
            // 
            // button_voir
            // 
            this.button_voir.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_voir.Location = new System.Drawing.Point(60, 289);
            this.button_voir.Name = "button_voir";
            this.button_voir.Size = new System.Drawing.Size(127, 23);
            this.button_voir.TabIndex = 18;
            this.button_voir.Text = "VOIR";
            this.button_voir.UseVisualStyleBackColor = false;
            this.button_voir.Click += new System.EventHandler(this.button_voir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(239, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 17;
            // 
            // textboxNom
            // 
            this.textboxNom.Location = new System.Drawing.Point(173, 83);
            this.textboxNom.Name = "textboxNom";
            this.textboxNom.Size = new System.Drawing.Size(353, 20);
            this.textboxNom.TabIndex = 16;
            // 
            // FormChambre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 361);
            this.Controls.Add(this.comboBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button_valider);
            this.Controls.Add(this.button_sp);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxnumero);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button_voir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textboxNom);
            this.Name = "FormChambre";
            this.Text = "FormChambre";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button_valider;
        private System.Windows.Forms.Button button_sp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxnumero;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_voir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textboxNom;
    }
}