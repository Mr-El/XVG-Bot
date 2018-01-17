namespace XVG_Bot
{
    partial class URLAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(URLAdd));
            this.txtURL = new System.Windows.Forms.TextBox();
            this.URLGo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtURL
            // 
            this.txtURL.Location = new System.Drawing.Point(16, 15);
            this.txtURL.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(343, 22);
            this.txtURL.TabIndex = 0;
            // 
            // URLGo
            // 
            this.URLGo.Location = new System.Drawing.Point(368, 12);
            this.URLGo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.URLGo.Name = "URLGo";
            this.URLGo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.URLGo.Size = new System.Drawing.Size(100, 28);
            this.URLGo.TabIndex = 1;
            this.URLGo.Text = "Go";
            this.URLGo.UseVisualStyleBackColor = true;
            this.URLGo.Click += new System.EventHandler(this.URLGo_Click);
            // 
            // URLAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 59);
            this.Controls.Add(this.URLGo);
            this.Controls.Add(this.txtURL);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "URLAdd";
            this.Text = "Add a URL";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.Button URLGo;
    }
}