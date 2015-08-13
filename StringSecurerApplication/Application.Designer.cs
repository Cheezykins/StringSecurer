namespace StringSecurerApplication
{
    partial class Application
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.unsafetext = new System.Windows.Forms.TextBox();
            this.safetext = new System.Windows.Forms.TextBox();
            this.decrypt = new System.Windows.Forms.Button();
            this.encrypt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(12, 12);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.unsafetext);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.safetext);
            this.splitContainer1.Size = new System.Drawing.Size(260, 208);
            this.splitContainer1.SplitterDistance = 111;
            this.splitContainer1.TabIndex = 4;
            // 
            // unsafetext
            // 
            this.unsafetext.Dock = System.Windows.Forms.DockStyle.Fill;
            this.unsafetext.Location = new System.Drawing.Point(0, 0);
            this.unsafetext.Multiline = true;
            this.unsafetext.Name = "unsafetext";
            this.unsafetext.Size = new System.Drawing.Size(260, 111);
            this.unsafetext.TabIndex = 0;
            this.unsafetext.Enter += new System.EventHandler(this.unsafetext_Enter);
            this.unsafetext.Leave += new System.EventHandler(this.unsafetext_Leave);
            // 
            // safetext
            // 
            this.safetext.Dock = System.Windows.Forms.DockStyle.Fill;
            this.safetext.Location = new System.Drawing.Point(0, 0);
            this.safetext.Multiline = true;
            this.safetext.Name = "safetext";
            this.safetext.Size = new System.Drawing.Size(260, 93);
            this.safetext.TabIndex = 0;
            this.safetext.Enter += new System.EventHandler(this.safetext_Enter);
            this.safetext.Leave += new System.EventHandler(this.safetext_Leave);
            // 
            // decrypt
            // 
            this.decrypt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.decrypt.Location = new System.Drawing.Point(196, 226);
            this.decrypt.Name = "decrypt";
            this.decrypt.Size = new System.Drawing.Size(75, 23);
            this.decrypt.TabIndex = 5;
            this.decrypt.Text = "Decrypt";
            this.decrypt.UseVisualStyleBackColor = true;
            this.decrypt.Click += new System.EventHandler(this.decrypt_Click);
            // 
            // encrypt
            // 
            this.encrypt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.encrypt.Location = new System.Drawing.Point(115, 226);
            this.encrypt.Name = "encrypt";
            this.encrypt.Size = new System.Drawing.Size(75, 23);
            this.encrypt.TabIndex = 6;
            this.encrypt.Text = "Encrypt";
            this.encrypt.UseVisualStyleBackColor = true;
            this.encrypt.Click += new System.EventHandler(this.encrypt_Click);
            // 
            // Application
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.encrypt);
            this.Controls.Add(this.decrypt);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Application";
            this.Text = "String Securer";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox unsafetext;
        private System.Windows.Forms.Button decrypt;
        private System.Windows.Forms.Button encrypt;
        private System.Windows.Forms.TextBox safetext;
    }
}

