namespace XVG_Bot
{
    partial class GiveElements
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
            this.addMiner = new System.Windows.Forms.Button();
            this.minerName1 = new System.Windows.Forms.TextBox();
            this.minerName2 = new System.Windows.Forms.TextBox();
            this.minerName3 = new System.Windows.Forms.TextBox();
            this.element1 = new System.Windows.Forms.TextBox();
            this.element2 = new System.Windows.Forms.TextBox();
            this.element3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // addMiner
            // 
            this.addMiner.Location = new System.Drawing.Point(254, 189);
            this.addMiner.Name = "addMiner";
            this.addMiner.Size = new System.Drawing.Size(94, 23);
            this.addMiner.TabIndex = 1;
            this.addMiner.Text = "Add Miner";
            this.addMiner.UseVisualStyleBackColor = true;
            this.addMiner.Click += new System.EventHandler(this.addMiner_Click);
            // 
            // minerName1
            // 
            this.minerName1.Location = new System.Drawing.Point(29, 31);
            this.minerName1.Name = "minerName1";
            this.minerName1.Size = new System.Drawing.Size(100, 22);
            this.minerName1.TabIndex = 2;
            // 
            // minerName2
            // 
            this.minerName2.Location = new System.Drawing.Point(29, 82);
            this.minerName2.Name = "minerName2";
            this.minerName2.Size = new System.Drawing.Size(100, 22);
            this.minerName2.TabIndex = 3;
            this.minerName2.Visible = false;
            // 
            // minerName3
            // 
            this.minerName3.Location = new System.Drawing.Point(29, 134);
            this.minerName3.Name = "minerName3";
            this.minerName3.Size = new System.Drawing.Size(100, 22);
            this.minerName3.TabIndex = 4;
            this.minerName3.Visible = false;
            // 
            // element1
            // 
            this.element1.Location = new System.Drawing.Point(232, 31);
            this.element1.Name = "element1";
            this.element1.Size = new System.Drawing.Size(100, 22);
            this.element1.TabIndex = 5;
            // 
            // element2
            // 
            this.element2.Location = new System.Drawing.Point(232, 82);
            this.element2.Name = "element2";
            this.element2.Size = new System.Drawing.Size(100, 22);
            this.element2.TabIndex = 6;
            this.element2.Visible = false;
            // 
            // element3
            // 
            this.element3.Location = new System.Drawing.Point(232, 134);
            this.element3.Name = "element3";
            this.element3.Size = new System.Drawing.Size(100, 22);
            this.element3.TabIndex = 7;
            this.element3.Visible = false;
            // 
            // GiveElements
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 321);
            this.Controls.Add(this.element3);
            this.Controls.Add(this.element2);
            this.Controls.Add(this.element1);
            this.Controls.Add(this.minerName3);
            this.Controls.Add(this.minerName2);
            this.Controls.Add(this.minerName1);
            this.Controls.Add(this.addMiner);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "GiveElements";
            this.Text = "GiveElements";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button addMiner;
        private System.Windows.Forms.TextBox minerName1;
        private System.Windows.Forms.TextBox minerName2;
        private System.Windows.Forms.TextBox minerName3;
        private System.Windows.Forms.TextBox element1;
        private System.Windows.Forms.TextBox element2;
        private System.Windows.Forms.TextBox element3;
    }
}