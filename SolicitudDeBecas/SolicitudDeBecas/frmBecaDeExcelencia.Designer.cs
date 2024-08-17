namespace SolicitudDeBecas
{
    partial class frmBecaDeExcelencia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBecaDeExcelencia));
            this.rctbConvocatoria3 = new System.Windows.Forms.RichTextBox();
            this.pbLogoTec = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoTec)).BeginInit();
            this.SuspendLayout();
            // 
            // rctbConvocatoria3
            // 
            this.rctbConvocatoria3.BackColor = System.Drawing.SystemColors.Control;
            this.rctbConvocatoria3.Enabled = false;
            this.rctbConvocatoria3.Font = new System.Drawing.Font("Eras Medium ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rctbConvocatoria3.Location = new System.Drawing.Point(12, 12);
            this.rctbConvocatoria3.Name = "rctbConvocatoria3";
            this.rctbConvocatoria3.Size = new System.Drawing.Size(405, 314);
            this.rctbConvocatoria3.TabIndex = 1;
            this.rctbConvocatoria3.Text = resources.GetString("rctbConvocatoria3.Text");
            // 
            // pbLogoTec
            // 
            this.pbLogoTec.Image = ((System.Drawing.Image)(resources.GetObject("pbLogoTec.Image")));
            this.pbLogoTec.Location = new System.Drawing.Point(274, 359);
            this.pbLogoTec.Name = "pbLogoTec";
            this.pbLogoTec.Size = new System.Drawing.Size(143, 53);
            this.pbLogoTec.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogoTec.TabIndex = 2;
            this.pbLogoTec.TabStop = false;
            // 
            // frmBecaDeExcelencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 436);
            this.Controls.Add(this.pbLogoTec);
            this.Controls.Add(this.rctbConvocatoria3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(400, 0);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBecaDeExcelencia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Convocatoria Beca de Excelencia";
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoTec)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rctbConvocatoria3;
        private System.Windows.Forms.PictureBox pbLogoTec;
    }
}