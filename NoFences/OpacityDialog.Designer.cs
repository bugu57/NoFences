namespace NoFences
{
    partial class OpacityDialog
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.trackBarOpacity = new System.Windows.Forms.TrackBar();
            this.lblOpacityValue = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarOpacity)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(363, 67);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(56, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnOk.Location = new System.Drawing.Point(301, 67);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(56, 23);
            this.btnOk.TabIndex = 4;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // trackBarOpacity
            // 
            this.trackBarOpacity.Location = new System.Drawing.Point(12, 3);
            this.trackBarOpacity.Maximum = 100;
            this.trackBarOpacity.Minimum = 1;
            this.trackBarOpacity.Name = "trackBarOpacity";
            this.trackBarOpacity.Size = new System.Drawing.Size(407, 45);
            this.trackBarOpacity.TabIndex = 6;
            this.trackBarOpacity.Value = 50;
            this.trackBarOpacity.ValueChanged += new System.EventHandler(this.trackBarOpacity_ValueChanged);
            // 
            // lblOpacityValue
            // 
            this.lblOpacityValue.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblOpacityValue.AutoSize = true;
            this.lblOpacityValue.Location = new System.Drawing.Point(207, 51);
            this.lblOpacityValue.Name = "lblOpacityValue";
            this.lblOpacityValue.Size = new System.Drawing.Size(19, 13);
            this.lblOpacityValue.TabIndex = 7;
            this.lblOpacityValue.Text = "50";
            // 
            // OpacityDialog
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(431, 102);
            this.Controls.Add(this.lblOpacityValue);
            this.Controls.Add(this.trackBarOpacity);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OpacityDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Change Opacity";
            ((System.ComponentModel.ISupportInitialize)(this.trackBarOpacity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.TrackBar trackBarOpacity;
        private System.Windows.Forms.Label lblOpacityValue;
    }
}
