
namespace Zahlensysteme_GUI
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.comBoxUrsprung = new System.Windows.Forms.ComboBox();
            this.comBoxZiel = new System.Windows.Forms.ComboBox();
            this.txtAusgangszahl = new System.Windows.Forms.TextBox();
            this.btnBerechnen = new System.Windows.Forms.Button();
            this.txtResultat = new System.Windows.Forms.TextBox();
            this.lblUrsprung = new System.Windows.Forms.Label();
            this.lblAusgang = new System.Windows.Forms.Label();
            this.lblZiel = new System.Windows.Forms.Label();
            this.lboxError = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // comBoxUrsprung
            // 
            this.comBoxUrsprung.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBoxUrsprung.FormattingEnabled = true;
            this.comBoxUrsprung.Location = new System.Drawing.Point(41, 105);
            this.comBoxUrsprung.Name = "comBoxUrsprung";
            this.comBoxUrsprung.Size = new System.Drawing.Size(121, 21);
            this.comBoxUrsprung.TabIndex = 0;
            this.comBoxUrsprung.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comBoxZiel
            // 
            this.comBoxZiel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBoxZiel.FormattingEnabled = true;
            this.comBoxZiel.Location = new System.Drawing.Point(41, 254);
            this.comBoxZiel.Name = "comBoxZiel";
            this.comBoxZiel.Size = new System.Drawing.Size(121, 21);
            this.comBoxZiel.TabIndex = 1;
            // 
            // txtAusgangszahl
            // 
            this.txtAusgangszahl.Location = new System.Drawing.Point(352, 106);
            this.txtAusgangszahl.Name = "txtAusgangszahl";
            this.txtAusgangszahl.Size = new System.Drawing.Size(275, 20);
            this.txtAusgangszahl.TabIndex = 2;
            // 
            // btnBerechnen
            // 
            this.btnBerechnen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBerechnen.Location = new System.Drawing.Point(397, 231);
            this.btnBerechnen.Name = "btnBerechnen";
            this.btnBerechnen.Size = new System.Drawing.Size(75, 23);
            this.btnBerechnen.TabIndex = 3;
            this.btnBerechnen.Text = "Berechnen !";
            this.btnBerechnen.UseVisualStyleBackColor = true;
            this.btnBerechnen.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtResultat
            // 
            this.txtResultat.Location = new System.Drawing.Point(352, 260);
            this.txtResultat.Name = "txtResultat";
            this.txtResultat.Size = new System.Drawing.Size(171, 20);
            this.txtResultat.TabIndex = 4;
            this.txtResultat.Text = "Hier wird das Resultat ausgegeben.";
            this.txtResultat.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // lblUrsprung
            // 
            this.lblUrsprung.AutoSize = true;
            this.lblUrsprung.Location = new System.Drawing.Point(41, 68);
            this.lblUrsprung.Name = "lblUrsprung";
            this.lblUrsprung.Size = new System.Drawing.Size(184, 13);
            this.lblUrsprung.TabIndex = 5;
            this.lblUrsprung.Text = "Bitte Ursprungs-Zahlensystem wählen";
            // 
            // lblAusgang
            // 
            this.lblAusgang.AutoSize = true;
            this.lblAusgang.Location = new System.Drawing.Point(349, 68);
            this.lblAusgang.Name = "lblAusgang";
            this.lblAusgang.Size = new System.Drawing.Size(278, 13);
            this.lblAusgang.TabIndex = 6;
            this.lblAusgang.Text = "Bitte geben Sie die Zahl ein die umberechnet werden soll.";
            // 
            // lblZiel
            // 
            this.lblZiel.AutoSize = true;
            this.lblZiel.Location = new System.Drawing.Point(38, 217);
            this.lblZiel.Name = "lblZiel";
            this.lblZiel.Size = new System.Drawing.Size(153, 13);
            this.lblZiel.TabIndex = 7;
            this.lblZiel.Text = "Bitte Ziel-Zahlensystem wählen";
            // 
            // lboxError
            // 
            this.lboxError.FormattingEnabled = true;
            this.lboxError.Location = new System.Drawing.Point(41, 343);
            this.lboxError.Name = "lboxError";
            this.lboxError.Size = new System.Drawing.Size(747, 95);
            this.lboxError.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lboxError);
            this.Controls.Add(this.lblZiel);
            this.Controls.Add(this.lblAusgang);
            this.Controls.Add(this.lblUrsprung);
            this.Controls.Add(this.txtResultat);
            this.Controls.Add(this.btnBerechnen);
            this.Controls.Add(this.txtAusgangszahl);
            this.Controls.Add(this.comBoxZiel);
            this.Controls.Add(this.comBoxUrsprung);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comBoxUrsprung;
        private System.Windows.Forms.ComboBox comBoxZiel;
        private System.Windows.Forms.TextBox txtAusgangszahl;
        private System.Windows.Forms.Button btnBerechnen;
        private System.Windows.Forms.TextBox txtResultat;
        private System.Windows.Forms.Label lblUrsprung;
        private System.Windows.Forms.Label lblAusgang;
        private System.Windows.Forms.Label lblZiel;
        private System.Windows.Forms.ListBox lboxError;
    }
}

