namespace ASCOM.LocalServer
{
    partial class frmDriver
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
            this.shutterControlGrpBx = new System.Windows.Forms.GroupBox();
            this.btnClosed = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.roofStatusGrpBx = new System.Windows.Forms.GroupBox();
            this.shutterStatusLbl = new System.Windows.Forms.Label();
            this.safetyStatusGrpBx = new System.Windows.Forms.GroupBox();
            this.safetyLbl = new System.Windows.Forms.Label();
            this.arduinoStatusGrpBx = new System.Windows.Forms.GroupBox();
            this.statusLbl = new System.Windows.Forms.Label();
            this.shutterControlGrpBx.SuspendLayout();
            this.roofStatusGrpBx.SuspendLayout();
            this.safetyStatusGrpBx.SuspendLayout();
            this.arduinoStatusGrpBx.SuspendLayout();
            this.SuspendLayout();
            // 
            // shutterControlGrpBx
            // 
            this.shutterControlGrpBx.Controls.Add(this.btnClosed);
            this.shutterControlGrpBx.Controls.Add(this.btnOpen);
            this.shutterControlGrpBx.Location = new System.Drawing.Point(13, 13);
            this.shutterControlGrpBx.Name = "shutterControlGrpBx";
            this.shutterControlGrpBx.Size = new System.Drawing.Size(229, 104);
            this.shutterControlGrpBx.TabIndex = 0;
            this.shutterControlGrpBx.TabStop = false;
            this.shutterControlGrpBx.Text = "Shutter Control";
            // 
            // btnClosed
            // 
            this.btnClosed.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnClosed.Location = new System.Drawing.Point(6, 58);
            this.btnClosed.Name = "btnClosed";
            this.btnClosed.Size = new System.Drawing.Size(217, 33);
            this.btnClosed.TabIndex = 2;
            this.btnClosed.Text = "Close";
            this.btnClosed.UseVisualStyleBackColor = true;
            this.btnClosed.Click += new System.EventHandler(this.btnClosed_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnOpen.Location = new System.Drawing.Point(6, 19);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(217, 33);
            this.btnOpen.TabIndex = 1;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // roofStatusGrpBx
            // 
            this.roofStatusGrpBx.Controls.Add(this.shutterStatusLbl);
            this.roofStatusGrpBx.Location = new System.Drawing.Point(13, 123);
            this.roofStatusGrpBx.Name = "roofStatusGrpBx";
            this.roofStatusGrpBx.Size = new System.Drawing.Size(229, 82);
            this.roofStatusGrpBx.TabIndex = 7;
            this.roofStatusGrpBx.TabStop = false;
            this.roofStatusGrpBx.Text = "Roof Status";
            // 
            // shutterStatusLbl
            // 
            this.shutterStatusLbl.AutoSize = true;
            this.shutterStatusLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.shutterStatusLbl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.shutterStatusLbl.Location = new System.Drawing.Point(6, 26);
            this.shutterStatusLbl.Name = "shutterStatusLbl";
            this.shutterStatusLbl.Size = new System.Drawing.Size(100, 39);
            this.shutterStatusLbl.TabIndex = 4;
            this.shutterStatusLbl.Text = "Open";
            this.shutterStatusLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // safetyStatusGrpBx
            // 
            this.safetyStatusGrpBx.Controls.Add(this.safetyLbl);
            this.safetyStatusGrpBx.Location = new System.Drawing.Point(12, 211);
            this.safetyStatusGrpBx.Name = "safetyStatusGrpBx";
            this.safetyStatusGrpBx.Size = new System.Drawing.Size(230, 82);
            this.safetyStatusGrpBx.TabIndex = 8;
            this.safetyStatusGrpBx.TabStop = false;
            this.safetyStatusGrpBx.Text = "Safety Status";
            // 
            // safetyLbl
            // 
            this.safetyLbl.AutoSize = true;
            this.safetyLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.safetyLbl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.safetyLbl.Location = new System.Drawing.Point(6, 26);
            this.safetyLbl.Name = "safetyLbl";
            this.safetyLbl.Size = new System.Drawing.Size(87, 39);
            this.safetyLbl.TabIndex = 4;
            this.safetyLbl.Text = "Safe";
            this.safetyLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // arduinoStatusGrpBx
            // 
            this.arduinoStatusGrpBx.Controls.Add(this.statusLbl);
            this.arduinoStatusGrpBx.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.arduinoStatusGrpBx.Location = new System.Drawing.Point(13, 299);
            this.arduinoStatusGrpBx.Name = "arduinoStatusGrpBx";
            this.arduinoStatusGrpBx.Size = new System.Drawing.Size(229, 53);
            this.arduinoStatusGrpBx.TabIndex = 9;
            this.arduinoStatusGrpBx.TabStop = false;
            this.arduinoStatusGrpBx.Text = "Arduino Status";
            // 
            // statusLbl
            // 
            this.statusLbl.AutoSize = true;
            this.statusLbl.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.statusLbl.Location = new System.Drawing.Point(8, 26);
            this.statusLbl.Name = "statusLbl";
            this.statusLbl.Size = new System.Drawing.Size(35, 13);
            this.statusLbl.TabIndex = 2;
            this.statusLbl.Text = "label1";
            // 
            // frmDriver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 366);
            this.Controls.Add(this.arduinoStatusGrpBx);
            this.Controls.Add(this.safetyStatusGrpBx);
            this.Controls.Add(this.roofStatusGrpBx);
            this.Controls.Add(this.shutterControlGrpBx);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmDriver";
            this.Text = "ArduinoUno Dome";
            this.Load += new System.EventHandler(this.frmDriver_Load);
            this.shutterControlGrpBx.ResumeLayout(false);
            this.roofStatusGrpBx.ResumeLayout(false);
            this.roofStatusGrpBx.PerformLayout();
            this.safetyStatusGrpBx.ResumeLayout(false);
            this.safetyStatusGrpBx.PerformLayout();
            this.arduinoStatusGrpBx.ResumeLayout(false);
            this.arduinoStatusGrpBx.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox shutterControlGrpBx;
        private System.Windows.Forms.GroupBox roofStatusGrpBx;
        private System.Windows.Forms.Label shutterStatusLbl;
        private System.Windows.Forms.GroupBox safetyStatusGrpBx;
        private System.Windows.Forms.Label safetyLbl;
        private System.Windows.Forms.Button btnClosed;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.GroupBox arduinoStatusGrpBx;
        private System.Windows.Forms.Label statusLbl;
    }
}