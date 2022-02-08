namespace CompresorAC
{
    partial class Compresor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Compresor));
            this.btnCarpetas = new System.Windows.Forms.Button();
            this.txtFolder = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtZips = new System.Windows.Forms.DomainUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.btnZip = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.lbltotalarchivos = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCarpetas
            // 
            this.btnCarpetas.Location = new System.Drawing.Point(368, 34);
            this.btnCarpetas.Name = "btnCarpetas";
            this.btnCarpetas.Size = new System.Drawing.Size(22, 20);
            this.btnCarpetas.TabIndex = 11;
            this.btnCarpetas.Text = "+";
            this.btnCarpetas.UseVisualStyleBackColor = true;
            this.btnCarpetas.Click += new System.EventHandler(this.btnCarpetas_Click);
            // 
            // txtFolder
            // 
            this.txtFolder.Enabled = false;
            this.txtFolder.Location = new System.Drawing.Point(12, 35);
            this.txtFolder.MaxLength = 50;
            this.txtFolder.Name = "txtFolder";
            this.txtFolder.Size = new System.Drawing.Size(356, 20);
            this.txtFolder.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Carpeta de trabajo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Nuevo Zip cada:";
            // 
            // txtZips
            // 
            this.txtZips.Location = new System.Drawing.Point(100, 70);
            this.txtZips.Name = "txtZips";
            this.txtZips.Size = new System.Drawing.Size(85, 20);
            this.txtZips.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(189, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "archivos.";
            // 
            // btnZip
            // 
            this.btnZip.Image = ((System.Drawing.Image)(resources.GetObject("btnZip.Image")));
            this.btnZip.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnZip.Location = new System.Drawing.Point(293, 149);
            this.btnZip.Name = "btnZip";
            this.btnZip.Size = new System.Drawing.Size(97, 23);
            this.btnZip.TabIndex = 15;
            this.btnZip.Text = "&Comprimir";
            this.btnZip.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnZip.UseVisualStyleBackColor = true;
            this.btnZip.Click += new System.EventHandler(this.btnZip_Click);
            // 
            // progressBar
            // 
            this.progressBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBar.Location = new System.Drawing.Point(0, 178);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(402, 21);
            this.progressBar.TabIndex = 16;
            // 
            // lbltotalarchivos
            // 
            this.lbltotalarchivos.AutoSize = true;
            this.lbltotalarchivos.Location = new System.Drawing.Point(12, 114);
            this.lbltotalarchivos.Name = "lbltotalarchivos";
            this.lbltotalarchivos.Size = new System.Drawing.Size(0, 13);
            this.lbltotalarchivos.TabIndex = 17;
            // 
            // Compresor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(402, 199);
            this.Controls.Add(this.lbltotalarchivos);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.btnZip);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtZips);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCarpetas);
            this.Controls.Add(this.txtFolder);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Compresor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Compresor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCarpetas;
        private System.Windows.Forms.TextBox txtFolder;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DomainUpDown txtZips;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnZip;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label lbltotalarchivos;
    }
}