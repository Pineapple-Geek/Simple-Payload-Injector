namespace Simple_Payload_Injector
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.IPLabel = new System.Windows.Forms.Label();
            this.IPText = new System.Windows.Forms.TextBox();
            this.PortText = new System.Windows.Forms.TextBox();
            this.PortLabel = new System.Windows.Forms.Label();
            this.PayloadLabel = new System.Windows.Forms.Label();
            this.PathText = new System.Windows.Forms.TextBox();
            this.BrowseBT = new System.Windows.Forms.Button();
            this.PayloadBT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Simple Payload Injector";
            // 
            // IPLabel
            // 
            this.IPLabel.AutoSize = true;
            this.IPLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IPLabel.Location = new System.Drawing.Point(15, 62);
            this.IPLabel.Name = "IPLabel";
            this.IPLabel.Size = new System.Drawing.Size(57, 16);
            this.IPLabel.TabIndex = 1;
            this.IPLabel.Text = "IP PS4 : ";
            // 
            // IPText
            // 
            this.IPText.Location = new System.Drawing.Point(78, 61);
            this.IPText.Name = "IPText";
            this.IPText.Size = new System.Drawing.Size(100, 20);
            this.IPText.TabIndex = 2;
            // 
            // PortText
            // 
            this.PortText.Location = new System.Drawing.Point(244, 61);
            this.PortText.Name = "PortText";
            this.PortText.Size = new System.Drawing.Size(49, 20);
            this.PortText.TabIndex = 4;
            // 
            // PortLabel
            // 
            this.PortLabel.AutoSize = true;
            this.PortLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PortLabel.Location = new System.Drawing.Point(183, 62);
            this.PortLabel.Name = "PortLabel";
            this.PortLabel.Size = new System.Drawing.Size(55, 16);
            this.PortLabel.TabIndex = 3;
            this.PortLabel.Text = "PORT : ";
            // 
            // PayloadLabel
            // 
            this.PayloadLabel.AutoSize = true;
            this.PayloadLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.PayloadLabel.Location = new System.Drawing.Point(15, 106);
            this.PayloadLabel.Name = "PayloadLabel";
            this.PayloadLabel.Size = new System.Drawing.Size(67, 17);
            this.PayloadLabel.TabIndex = 5;
            this.PayloadLabel.Text = "Payload :";
            // 
            // PathText
            // 
            this.PathText.Location = new System.Drawing.Point(88, 105);
            this.PathText.Name = "PathText";
            this.PathText.Size = new System.Drawing.Size(141, 20);
            this.PathText.TabIndex = 6;
            // 
            // BrowseBT
            // 
            this.BrowseBT.Location = new System.Drawing.Point(235, 103);
            this.BrowseBT.Name = "BrowseBT";
            this.BrowseBT.Size = new System.Drawing.Size(75, 23);
            this.BrowseBT.TabIndex = 7;
            this.BrowseBT.Text = "Browse";
            this.BrowseBT.UseVisualStyleBackColor = true;
            this.BrowseBT.Click += new System.EventHandler(this.BrowseBT_Click);
            // 
            // PayloadBT
            // 
            this.PayloadBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PayloadBT.Location = new System.Drawing.Point(69, 148);
            this.PayloadBT.Name = "PayloadBT";
            this.PayloadBT.Size = new System.Drawing.Size(189, 45);
            this.PayloadBT.TabIndex = 8;
            this.PayloadBT.Text = "Send Payload";
            this.PayloadBT.UseVisualStyleBackColor = true;
            this.PayloadBT.Click += new System.EventHandler(this.PayloadBT_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 205);
            this.Controls.Add(this.PayloadBT);
            this.Controls.Add(this.BrowseBT);
            this.Controls.Add(this.PathText);
            this.Controls.Add(this.PayloadLabel);
            this.Controls.Add(this.PortText);
            this.Controls.Add(this.PortLabel);
            this.Controls.Add(this.IPText);
            this.Controls.Add(this.IPLabel);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Simple Payload Injector";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label IPLabel;
        private System.Windows.Forms.TextBox IPText;
        private System.Windows.Forms.TextBox PortText;
        private System.Windows.Forms.Label PortLabel;
        private System.Windows.Forms.Label PayloadLabel;
        private System.Windows.Forms.TextBox PathText;
        private System.Windows.Forms.Button BrowseBT;
        private System.Windows.Forms.Button PayloadBT;
    }
}

