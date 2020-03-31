namespace GitHub_Test
{
    partial class Form1
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
            this.btnHelloDeb = new System.Windows.Forms.Button();
            this.lblOut = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnHelloDeb
            // 
            this.btnHelloDeb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnHelloDeb.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelloDeb.ForeColor = System.Drawing.Color.White;
            this.btnHelloDeb.Location = new System.Drawing.Point(301, 149);
            this.btnHelloDeb.Name = "btnHelloDeb";
            this.btnHelloDeb.Size = new System.Drawing.Size(125, 70);
            this.btnHelloDeb.TabIndex = 0;
            this.btnHelloDeb.Text = "Push";
            this.btnHelloDeb.UseVisualStyleBackColor = false;
            this.btnHelloDeb.Click += new System.EventHandler(this.btnHelloDeb_Click);
            // 
            // lblOut
            // 
            this.lblOut.AutoSize = true;
            this.lblOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOut.Location = new System.Drawing.Point(315, 292);
            this.lblOut.Name = "lblOut";
            this.lblOut.Size = new System.Drawing.Size(100, 25);
            this.lblOut.TabIndex = 1;
            this.lblOut.Text = "Message";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblOut);
            this.Controls.Add(this.btnHelloDeb);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHelloDeb;
        private System.Windows.Forms.Label lblOut;
    }
}

