namespace Music2
{
    partial class Article18
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
            this.lblSource = new System.Windows.Forms.Label();
            this.lblDest = new System.Windows.Forms.Label();
            this.lstSource = new System.Windows.Forms.ListBox();
            this.lstDest = new System.Windows.Forms.ListBox();
            this.btnMoveRight = new System.Windows.Forms.Button();
            this.btnMoveLeft = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSource
            // 
            this.lblSource.AutoSize = true;
            this.lblSource.Location = new System.Drawing.Point(25, 20);
            this.lblSource.Name = "lblSource";
            this.lblSource.Size = new System.Drawing.Size(92, 13);
            this.lblSource.TabIndex = 0;
            this.lblSource.Text = "Danh sách bài hát";
            // 
            // lblDest
            // 
            this.lblDest.AutoSize = true;
            this.lblDest.Location = new System.Drawing.Point(345, 20);
            this.lblDest.Name = "lblDest";
            this.lblDest.Size = new System.Drawing.Size(129, 13);
            this.lblDest.TabIndex = 1;
            this.lblDest.Text = "Danh sách bài hát ưa thích";
            // 
            // lstSource
            // 
            this.lstSource.FormattingEnabled = true;
            this.lstSource.Location = new System.Drawing.Point(28, 45);
            this.lstSource.Name = "lstSource";
            this.lstSource.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstSource.Size = new System.Drawing.Size(200, 290);
            this.lstSource.TabIndex = 2;
            // 
            // lstDest
            // 
            this.lstDest.FormattingEnabled = true;
            this.lstDest.Location = new System.Drawing.Point(348, 45);
            this.lstDest.Name = "lstDest";
            this.lstDest.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstDest.Size = new System.Drawing.Size(200, 290);
            this.lstDest.TabIndex = 3;
            // 
            // btnMoveRight
            // 
            this.btnMoveRight.Location = new System.Drawing.Point(260, 130);
            this.btnMoveRight.Name = "btnMoveRight";
            this.btnMoveRight.Size = new System.Drawing.Size(55, 40);
            this.btnMoveRight.TabIndex = 4;
            this.btnMoveRight.Text = ">";
            this.btnMoveRight.UseVisualStyleBackColor = true;
            this.btnMoveRight.Click += new System.EventHandler(this.btnMoveRight_Click);
            // 
            // btnMoveLeft
            // 
            this.btnMoveLeft.Location = new System.Drawing.Point(260, 190);
            this.btnMoveLeft.Name = "btnMoveLeft";
            this.btnMoveLeft.Size = new System.Drawing.Size(55, 40);
            this.btnMoveLeft.TabIndex = 5;
            this.btnMoveLeft.Text = "<";
            this.btnMoveLeft.UseVisualStyleBackColor = true;
            this.btnMoveLeft.Click += new System.EventHandler(this.btnMoveLeft_Click);
            // 
            // Article18
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.btnMoveLeft);
            this.Controls.Add(this.btnMoveRight);
            this.Controls.Add(this.lstDest);
            this.Controls.Add(this.lstSource);
            this.Controls.Add(this.lblDest);
            this.Controls.Add(this.lblSource);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Article18";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Music";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSource;
        private System.Windows.Forms.Label lblDest;
        private System.Windows.Forms.ListBox lstSource;
        private System.Windows.Forms.ListBox lstDest;
        private System.Windows.Forms.Button btnMoveRight;
        private System.Windows.Forms.Button btnMoveLeft;
    }
}