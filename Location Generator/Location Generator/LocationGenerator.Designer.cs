namespace Location_Generator
{
    partial class fmLocGen
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
            this.lblLocation = new System.Windows.Forms.Label();
            this.btnNextLoc = new System.Windows.Forms.Button();
            this.lblDescr = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Font = new System.Drawing.Font("Open Sans", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocation.Location = new System.Drawing.Point(127, 103);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(313, 30);
            this.lblLocation.TabIndex = 0;
            this.lblLocation.Text = "Where are you going to land?";
            this.lblLocation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnNextLoc
            // 
            this.btnNextLoc.AutoSize = true;
            this.btnNextLoc.Location = new System.Drawing.Point(201, 307);
            this.btnNextLoc.Name = "btnNextLoc";
            this.btnNextLoc.Size = new System.Drawing.Size(83, 23);
            this.btnNextLoc.TabIndex = 1;
            this.btnNextLoc.Text = "Next Location";
            this.btnNextLoc.UseVisualStyleBackColor = true;
            this.btnNextLoc.Click += new System.EventHandler(this.btnNextLoc_Click);
            // 
            // lblDescr
            // 
            this.lblDescr.AutoSize = true;
            this.lblDescr.Font = new System.Drawing.Font("Open Sans", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescr.Location = new System.Drawing.Point(127, 212);
            this.lblDescr.Name = "lblDescr";
            this.lblDescr.Size = new System.Drawing.Size(0, 30);
            this.lblDescr.TabIndex = 2;
            this.lblDescr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fmLocGen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.lblDescr);
            this.Controls.Add(this.btnNextLoc);
            this.Controls.Add(this.lblLocation);
            this.Name = "fmLocGen";
            this.Text = "Location Generator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.Button btnNextLoc;
        private System.Windows.Forms.Label lblDescr;
    }
}

