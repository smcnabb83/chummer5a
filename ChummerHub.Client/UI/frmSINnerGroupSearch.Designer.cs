namespace ChummerHub.Client.UI
{
    partial class frmSINnerGroupSearch
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
            if(disposing && (components != null))
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
            this.siNnerGroupSearch1 = new ChummerHub.Client.UI.ucSINnerGroupSearch();
            this.SuspendLayout();
            // 
            // siNnerGroupSearch1
            // 
            this.siNnerGroupSearch1.AutoScroll = true;
            this.siNnerGroupSearch1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.siNnerGroupSearch1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.siNnerGroupSearch1.Location = new System.Drawing.Point(0, 0);
            this.siNnerGroupSearch1.MyCE = null;
            this.siNnerGroupSearch1.MySINSearchGroupResult = null;
            this.siNnerGroupSearch1.Name = "siNnerGroupSearch1";
            this.siNnerGroupSearch1.Size = new System.Drawing.Size(400, 450);
            this.siNnerGroupSearch1.TabIndex = 0;
            // 
            // frmSINnerGroupSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 450);
            this.Controls.Add(this.siNnerGroupSearch1);
            this.Name = "frmSINnerGroupSearch";
            this.Text = "frmSINnerGroupSearch";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmSINnerGroupSearch_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private ucSINnerGroupSearch siNnerGroupSearch1;
    }
}
