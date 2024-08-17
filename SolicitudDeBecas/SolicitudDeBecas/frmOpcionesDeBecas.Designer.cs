namespace SolicitudDeBecas
{
    partial class frmOpcionesDeBecas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOpcionesDeBecas));
            this.btnBecaExcelencia = new System.Windows.Forms.Button();
            this.gbBecas = new System.Windows.Forms.GroupBox();
            this.btnBecaDeportiva = new System.Windows.Forms.Button();
            this.btnBecaAcademica = new System.Windows.Forms.Button();
            this.stRegresar = new System.Windows.Forms.StatusStrip();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.tsRegresar = new System.Windows.Forms.ToolStripMenuItem();
            this.gbBecas.SuspendLayout();
            this.stRegresar.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBecaExcelencia
            // 
            this.btnBecaExcelencia.BackColor = System.Drawing.Color.AliceBlue;
            this.btnBecaExcelencia.FlatAppearance.BorderColor = System.Drawing.Color.LightBlue;
            this.btnBecaExcelencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBecaExcelencia.Font = new System.Drawing.Font("Eras Medium ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBecaExcelencia.Image = ((System.Drawing.Image)(resources.GetObject("btnBecaExcelencia.Image")));
            this.btnBecaExcelencia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBecaExcelencia.Location = new System.Drawing.Point(6, 45);
            this.btnBecaExcelencia.Name = "btnBecaExcelencia";
            this.btnBecaExcelencia.Size = new System.Drawing.Size(170, 33);
            this.btnBecaExcelencia.TabIndex = 0;
            this.btnBecaExcelencia.Text = "     Beca de Excelencia";
            this.btnBecaExcelencia.UseVisualStyleBackColor = false;
            this.btnBecaExcelencia.MouseLeave += new System.EventHandler(this.btnBecaExcelencia_MouseLeave);
            this.btnBecaExcelencia.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnBecaExcelencia_MouseMove);
            // 
            // gbBecas
            // 
            this.gbBecas.Controls.Add(this.btnBecaDeportiva);
            this.gbBecas.Controls.Add(this.btnBecaAcademica);
            this.gbBecas.Controls.Add(this.btnBecaExcelencia);
            this.gbBecas.Location = new System.Drawing.Point(13, 13);
            this.gbBecas.Name = "gbBecas";
            this.gbBecas.Size = new System.Drawing.Size(390, 135);
            this.gbBecas.TabIndex = 1;
            this.gbBecas.TabStop = false;
            this.gbBecas.Text = "Becas Disponibles";
            // 
            // btnBecaDeportiva
            // 
            this.btnBecaDeportiva.BackColor = System.Drawing.Color.AliceBlue;
            this.btnBecaDeportiva.FlatAppearance.BorderColor = System.Drawing.Color.LightBlue;
            this.btnBecaDeportiva.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBecaDeportiva.Font = new System.Drawing.Font("Eras Medium ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBecaDeportiva.Image = ((System.Drawing.Image)(resources.GetObject("btnBecaDeportiva.Image")));
            this.btnBecaDeportiva.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBecaDeportiva.Location = new System.Drawing.Point(114, 84);
            this.btnBecaDeportiva.Name = "btnBecaDeportiva";
            this.btnBecaDeportiva.Size = new System.Drawing.Size(170, 33);
            this.btnBecaDeportiva.TabIndex = 2;
            this.btnBecaDeportiva.Text = "Beca Deportiva";
            this.btnBecaDeportiva.UseVisualStyleBackColor = false;
            this.btnBecaDeportiva.MouseLeave += new System.EventHandler(this.btnBecaDeportiva_MouseLeave);
            this.btnBecaDeportiva.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnBecaDeportiva_MouseMove);
            // 
            // btnBecaAcademica
            // 
            this.btnBecaAcademica.BackColor = System.Drawing.Color.AliceBlue;
            this.btnBecaAcademica.FlatAppearance.BorderColor = System.Drawing.Color.LightBlue;
            this.btnBecaAcademica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBecaAcademica.Font = new System.Drawing.Font("Eras Medium ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBecaAcademica.Image = ((System.Drawing.Image)(resources.GetObject("btnBecaAcademica.Image")));
            this.btnBecaAcademica.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBecaAcademica.Location = new System.Drawing.Point(206, 45);
            this.btnBecaAcademica.Name = "btnBecaAcademica";
            this.btnBecaAcademica.Size = new System.Drawing.Size(170, 33);
            this.btnBecaAcademica.TabIndex = 1;
            this.btnBecaAcademica.Text = "Beca Academica";
            this.btnBecaAcademica.UseVisualStyleBackColor = false;
            this.btnBecaAcademica.MouseLeave += new System.EventHandler(this.btnBecaAcademica_MouseLeave);
            this.btnBecaAcademica.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnBecaAcademica_MouseMove);
            // 
            // stRegresar
            // 
            this.stRegresar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSplitButton1});
            this.stRegresar.Location = new System.Drawing.Point(0, 187);
            this.stRegresar.Name = "stRegresar";
            this.stRegresar.Size = new System.Drawing.Size(415, 22);
            this.stRegresar.TabIndex = 5;
            this.stRegresar.Text = "statusStrip1";
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsRegresar});
            this.toolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton1.Image")));
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(32, 20);
            this.toolStripSplitButton1.Text = "toolStripSplitButton1";
            // 
            // tsRegresar
            // 
            this.tsRegresar.Name = "tsRegresar";
            this.tsRegresar.Size = new System.Drawing.Size(180, 22);
            this.tsRegresar.Text = "Regresar";
            this.tsRegresar.Click += new System.EventHandler(this.tsRegresar_Click);
            // 
            // frmOpcionesDeBecas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(415, 209);
            this.ControlBox = false;
            this.Controls.Add(this.stRegresar);
            this.Controls.Add(this.gbBecas);
            this.Font = new System.Drawing.Font("Eras Medium ITC", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmOpcionesDeBecas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Becas Disponibles";
            this.TopMost = true;
            this.gbBecas.ResumeLayout(false);
            this.stRegresar.ResumeLayout(false);
            this.stRegresar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBecaExcelencia;
        private System.Windows.Forms.GroupBox gbBecas;
        private System.Windows.Forms.Button btnBecaDeportiva;
        private System.Windows.Forms.Button btnBecaAcademica;
        private System.Windows.Forms.StatusStrip stRegresar;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripMenuItem tsRegresar;
    }
}