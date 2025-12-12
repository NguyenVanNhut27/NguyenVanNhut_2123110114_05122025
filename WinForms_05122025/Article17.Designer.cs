namespace Music
{
    partial class Article17
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
            this.btnMoveAllRight = new System.Windows.Forms.Button();
            this.btnMoveAllLeft = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSource
            // 
            this.lblSource.AutoSize = true;
            this.lblSource.Location = new System.Drawing.Point(12, 15);
            this.lblSource.Name = "lblSource";
            this.lblSource.Size = new System.Drawing.Size(92, 13);
            this.lblSource.TabIndex = 0;
            this.lblSource.Text = "Danh sách bài hát";
            // 
            // lblDest
            // 
            this.lblDest.AutoSize = true;
            this.lblDest.Location = new System.Drawing.Point(330, 15);
            this.lblDest.Name = "lblDest";
            this.lblDest.Size = new System.Drawing.Size(129, 13);
            this.lblDest.TabIndex = 1;
            this.lblDest.Text = "Danh sách bài hát ưa thích";
            // 
            // lstSource
            // 
            this.lstSource.FormattingEnabled = true;
            this.lstSource.Location = new System.Drawing.Point(15, 35);
            this.lstSource.Name = "lstSource";
            this.lstSource.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstSource.Size = new System.Drawing.Size(220, 316);
            this.lstSource.TabIndex = 2;
            // 
            // lstDest
            // 
            this.lstDest.FormattingEnabled = true;
            this.lstDest.Location = new System.Drawing.Point(333, 35);
            this.lstDest.Name = "lstDest";
            this.lstDest.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstDest.Size = new System.Drawing.Size(220, 316);
            this.lstDest.TabIndex = 3;
            // 
            // btnMoveRight
            // 
            this.btnMoveRight.Location = new System.Drawing.Point(260, 100);
            this.btnMoveRight.Name = "btnMoveRight";
            this.btnMoveRight.Size = new System.Drawing.Size(50, 40);
            this.btnMoveRight.TabIndex = 4;
            this.btnMoveRight.Text = ">";
            this.btnMoveRight.UseVisualStyleBackColor = true;
            this.btnMoveRight.Click += new System.EventHandler(this.btnMoveRight_Click);
            // 
            // btnMoveLeft
            // 
            this.btnMoveLeft.Location = new System.Drawing.Point(260, 155);
            this.btnMoveLeft.Name = "btnMoveLeft";
            this.btnMoveLeft.Size = new System.Drawing.Size(50, 40);
            this.btnMoveLeft.TabIndex = 5;
            this.btnMoveLeft.Text = "<";
            this.btnMoveLeft.UseVisualStyleBackColor = true;
            this.btnMoveLeft.Click += new System.EventHandler(this.btnMoveLeft_Click);
            // 
            // btnMoveAllRight
            // 
            this.btnMoveAllRight.Location = new System.Drawing.Point(260, 210);
            this.btnMoveAllRight.Name = "btnMoveAllRight";
            this.btnMoveAllRight.Size = new System.Drawing.Size(50, 40);
            this.btnMoveAllRight.TabIndex = 6;
            this.btnMoveAllRight.Text = ">>";
            this.btnMoveAllRight.UseVisualStyleBackColor = true;
            this.btnMoveAllRight.Click += new System.EventHandler(this.btnMoveAllRight_Click);
            // 
            // btnMoveAllLeft
            // 
            this.btnMoveAllLeft.Location = new System.Drawing.Point(260, 265);
            this.btnMoveAllLeft.Name = "btnMoveAllLeft";
            this.btnMoveAllLeft.Size = new System.Drawing.Size(50, 40);
            this.btnMoveAllLeft.TabIndex = 7;
            this.btnMoveAllLeft.Text = "<<";
            this.btnMoveAllLeft.UseVisualStyleBackColor = true;
            this.btnMoveAllLeft.Click += new System.EventHandler(this.btnMoveAllLeft_Click);
            // 
            // Article17
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 371);
            this.Controls.Add(this.btnMoveAllLeft);
            this.Controls.Add(this.btnMoveAllRight);
            this.Controls.Add(this.btnMoveLeft);
            this.Controls.Add(this.btnMoveRight);
            this.Controls.Add(this.lstDest);
            this.Controls.Add(this.lstSource);
            this.Controls.Add(this.lblDest);
            this.Controls.Add(this.lblSource);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Article17";
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
        private System.Windows.Forms.Button btnMoveAllRight;
        private System.Windows.Forms.Button btnMoveAllLeft;
    }
}