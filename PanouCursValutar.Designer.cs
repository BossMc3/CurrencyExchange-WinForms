namespace ProiectPaw_CasaDeSchimbValutar
{
    partial class PanouCursValutar
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.listaCursuri = new System.Windows.Forms.ListBox();
            this.btnActualizare = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "CURSURI VALUTARE ZILEI";
            // 
            // listaCursuri
            // 
            this.listaCursuri.FormattingEnabled = true;
            this.listaCursuri.Location = new System.Drawing.Point(34, 38);
            this.listaCursuri.Name = "listaCursuri";
            this.listaCursuri.Size = new System.Drawing.Size(120, 95);
            this.listaCursuri.TabIndex = 1;
            // 
            // btnActualizare
            // 
            this.btnActualizare.Location = new System.Drawing.Point(52, 139);
            this.btnActualizare.Name = "btnActualizare";
            this.btnActualizare.Size = new System.Drawing.Size(75, 23);
            this.btnActualizare.TabIndex = 2;
            this.btnActualizare.Text = "Actualizează Cursuri";
            this.btnActualizare.UseVisualStyleBackColor = true;
            this.btnActualizare.Click += new System.EventHandler(this.btnActualizare_Click);
            // 
            // PanouCursValutar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnActualizare);
            this.Controls.Add(this.listaCursuri);
            this.Controls.Add(this.label1);
            this.Name = "PanouCursValutar";
            this.Size = new System.Drawing.Size(612, 289);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listaCursuri;
        private System.Windows.Forms.Button btnActualizare;
    }
}
