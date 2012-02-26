namespace OpdrachtDierenasiel1
{
    /// <summary>
    /// Formulier om dierenasiel te kunnen testen
    /// </summary>
    partial class FormDierenasiel
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
            this.rdBtnHond = new System.Windows.Forms.RadioButton();
            this.rdBtnKat = new System.Windows.Forms.RadioButton();
            this.btnMaakDier = new System.Windows.Forms.Button();
            this.btnGeefInfo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rdBtnHond
            // 
            this.rdBtnHond.AutoSize = true;
            this.rdBtnHond.Checked = true;
            this.rdBtnHond.Location = new System.Drawing.Point(195, 38);
            this.rdBtnHond.Name = "rdBtnHond";
            this.rdBtnHond.Size = new System.Drawing.Size(57, 17);
            this.rdBtnHond.TabIndex = 0;
            this.rdBtnHond.TabStop = true;
            this.rdBtnHond.Text = "HOND";
            this.rdBtnHond.UseVisualStyleBackColor = true;
            // 
            // rdBtnKat
            // 
            this.rdBtnKat.AutoSize = true;
            this.rdBtnKat.Location = new System.Drawing.Point(195, 73);
            this.rdBtnKat.Name = "rdBtnKat";
            this.rdBtnKat.Size = new System.Drawing.Size(46, 17);
            this.rdBtnKat.TabIndex = 1;
            this.rdBtnKat.Text = "KAT";
            this.rdBtnKat.UseVisualStyleBackColor = true;
            // 
            // btnMaakDier
            // 
            this.btnMaakDier.Location = new System.Drawing.Point(194, 132);
            this.btnMaakDier.Name = "btnMaakDier";
            this.btnMaakDier.Size = new System.Drawing.Size(76, 22);
            this.btnMaakDier.TabIndex = 2;
            this.btnMaakDier.Text = "Maak dier";
            this.btnMaakDier.UseVisualStyleBackColor = true;
            this.btnMaakDier.Click += new System.EventHandler(this.btnMaakDier_Click);
            // 
            // btnGeefInfo
            // 
            this.btnGeefInfo.Location = new System.Drawing.Point(195, 171);
            this.btnGeefInfo.Name = "btnGeefInfo";
            this.btnGeefInfo.Size = new System.Drawing.Size(75, 23);
            this.btnGeefInfo.TabIndex = 3;
            this.btnGeefInfo.Text = "Geef info";
            this.btnGeefInfo.UseVisualStyleBackColor = true;
            this.btnGeefInfo.Click += new System.EventHandler(this.btnGeefInfo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 266);
            this.Controls.Add(this.btnGeefInfo);
            this.Controls.Add(this.btnMaakDier);
            this.Controls.Add(this.rdBtnKat);
            this.Controls.Add(this.rdBtnHond);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdBtnHond;
        private System.Windows.Forms.RadioButton rdBtnKat;
        private System.Windows.Forms.Button btnMaakDier;
        private System.Windows.Forms.Button btnGeefInfo;
    }
}

