namespace SolicitudDeBecas
{
    partial class frmBecaDeportiva
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBecaDeportiva));
            this.rctbConvocatiora2 = new System.Windows.Forms.RichTextBox();
            this.pbLogoTec = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoTec)).BeginInit();
            this.SuspendLayout();
            // 
            // rctbConvocatiora2
            // 
            this.rctbConvocatiora2.BackColor = System.Drawing.SystemColors.Control;
            this.rctbConvocatiora2.Enabled = false;
            this.rctbConvocatiora2.Font = new System.Drawing.Font("Eras Medium ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rctbConvocatiora2.Location = new System.Drawing.Point(12, 12);
            this.rctbConvocatiora2.Name = "rctbConvocatiora2";
            this.rctbConvocatiora2.Size = new System.Drawing.Size(405, 329);
            this.rctbConvocatiora2.TabIndex = 0;
            this.rctbConvocatiora2.Text = resources.GetString("rctbConvocatiora2.Text");
            // 
            // pbLogoTec
            // 
            this.pbLogoTec.Image = ((System.Drawing.Image)(resources.GetObject("pbLogoTec.Image")));
            this.pbLogoTec.Location = new System.Drawing.Point(274, 363);
            this.pbLogoTec.Name = "pbLogoTec";
            this.pbLogoTec.Size = new System.Drawing.Size(143, 53);
            this.pbLogoTec.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogoTec.TabIndex = 3;
            this.pbLogoTec.TabStop = false;
            // 
            // frmBecaDeportiva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 436);
            this.Controls.Add(this.pbLogoTec);
            this.Controls.Add(this.rctbConvocatiora2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(400, 0);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBecaDeportiva";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Convocatoria Beca Deportiva";
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoTec)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rctbConvocatiora2;
        private System.Windows.Forms.PictureBox pbLogoTec;
    }
}