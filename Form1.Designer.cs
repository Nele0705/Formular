
namespace Formular2
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtVorname = new System.Windows.Forms.TextBox();
            this.txtNachname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButtonMännlich = new System.Windows.Forms.RadioButton();
            this.radioButtonWeiblich = new System.Windows.Forms.RadioButton();
            this.txtBeruf = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonSpeichernSenden = new System.Windows.Forms.Button();
            this.buttonSchließen = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vorname:";
            // 
            // txtVorname
            // 
            this.txtVorname.Location = new System.Drawing.Point(174, 94);
            this.txtVorname.Name = "txtVorname";
            this.txtVorname.Size = new System.Drawing.Size(176, 20);
            this.txtVorname.TabIndex = 1;
            // 
            // txtNachname
            // 
            this.txtNachname.Location = new System.Drawing.Point(174, 120);
            this.txtNachname.Name = "txtNachname";
            this.txtNachname.Size = new System.Drawing.Size(176, 20);
            this.txtNachname.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(96, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nachname:";
            // 
            // radioButtonMännlich
            // 
            this.radioButtonMännlich.AutoSize = true;
            this.radioButtonMännlich.Location = new System.Drawing.Point(183, 146);
            this.radioButtonMännlich.Name = "radioButtonMännlich";
            this.radioButtonMännlich.Size = new System.Drawing.Size(67, 17);
            this.radioButtonMännlich.TabIndex = 2;
            this.radioButtonMännlich.TabStop = true;
            this.radioButtonMännlich.Text = "männlich";
            this.radioButtonMännlich.UseVisualStyleBackColor = true;
            // 
            // radioButtonWeiblich
            // 
            this.radioButtonWeiblich.AutoSize = true;
            this.radioButtonWeiblich.Location = new System.Drawing.Point(275, 146);
            this.radioButtonWeiblich.Name = "radioButtonWeiblich";
            this.radioButtonWeiblich.Size = new System.Drawing.Size(63, 17);
            this.radioButtonWeiblich.TabIndex = 2;
            this.radioButtonWeiblich.TabStop = true;
            this.radioButtonWeiblich.Text = "weiblich";
            this.radioButtonWeiblich.UseVisualStyleBackColor = true;
            // 
            // txtBeruf
            // 
            this.txtBeruf.Location = new System.Drawing.Point(174, 169);
            this.txtBeruf.Name = "txtBeruf";
            this.txtBeruf.Size = new System.Drawing.Size(176, 20);
            this.txtBeruf.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(96, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Beruf:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 45.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label4.Location = new System.Drawing.Point(88, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(273, 63);
            this.label4.TabIndex = 0;
            this.label4.Text = "Formular";
            // 
            // buttonSpeichernSenden
            // 
            this.buttonSpeichernSenden.Location = new System.Drawing.Point(275, 195);
            this.buttonSpeichernSenden.Name = "buttonSpeichernSenden";
            this.buttonSpeichernSenden.Size = new System.Drawing.Size(75, 23);
            this.buttonSpeichernSenden.TabIndex = 3;
            this.buttonSpeichernSenden.Text = "Senden";
            this.buttonSpeichernSenden.UseVisualStyleBackColor = true;
            this.buttonSpeichernSenden.Click += new System.EventHandler(this.buttonSpeichernSenden_Click);
            // 
            // buttonSchließen
            // 
            this.buttonSchließen.Location = new System.Drawing.Point(99, 195);
            this.buttonSchließen.Name = "buttonSchließen";
            this.buttonSchließen.Size = new System.Drawing.Size(75, 23);
            this.buttonSchließen.TabIndex = 3;
            this.buttonSchließen.Text = "Schließen";
            this.buttonSchließen.UseVisualStyleBackColor = true;
            this.buttonSchließen.Click += new System.EventHandler(this.buttonSchließen_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(96, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Geschlecht:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(469, 328);
            this.Controls.Add(this.buttonSchließen);
            this.Controls.Add(this.buttonSpeichernSenden);
            this.Controls.Add(this.radioButtonWeiblich);
            this.Controls.Add(this.radioButtonMännlich);
            this.Controls.Add(this.txtBeruf);
            this.Controls.Add(this.txtNachname);
            this.Controls.Add(this.txtVorname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtVorname;
        private System.Windows.Forms.TextBox txtNachname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioButtonMännlich;
        private System.Windows.Forms.RadioButton radioButtonWeiblich;
        private System.Windows.Forms.TextBox txtBeruf;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonSpeichernSenden;
        private System.Windows.Forms.Button buttonSchließen;
        private System.Windows.Forms.Label label5;
    }
}

