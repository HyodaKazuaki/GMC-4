namespace GMC_4
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonINCR = new System.Windows.Forms.Button();
            this.SegmentLED0 = new System.Windows.Forms.PictureBox();
            this.SegmentLED01 = new System.Windows.Forms.PictureBox();
            this.SegmentLED2 = new System.Windows.Forms.PictureBox();
            this.SegmentLED3 = new System.Windows.Forms.PictureBox();
            this.SegmentLED4 = new System.Windows.Forms.PictureBox();
            this.SegmentLED5 = new System.Windows.Forms.PictureBox();
            this.SegmentLED6 = new System.Windows.Forms.PictureBox();
            this.binaryLED0 = new System.Windows.Forms.PictureBox();
            this.binaryLED1 = new System.Windows.Forms.PictureBox();
            this.binaryLED2 = new System.Windows.Forms.PictureBox();
            this.binaryLED3 = new System.Windows.Forms.PictureBox();
            this.binaryLED4 = new System.Windows.Forms.PictureBox();
            this.binaryLED5 = new System.Windows.Forms.PictureBox();
            this.binaryLED6 = new System.Windows.Forms.PictureBox();
            this.sourceCodeBox = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.SegmentLED0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SegmentLED01)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SegmentLED2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SegmentLED3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SegmentLED4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SegmentLED5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SegmentLED6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.binaryLED0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.binaryLED1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.binaryLED2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.binaryLED3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.binaryLED4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.binaryLED5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.binaryLED6)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonINCR
            // 
            this.buttonINCR.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonINCR.Location = new System.Drawing.Point(675, 67);
            this.buttonINCR.Name = "buttonINCR";
            this.buttonINCR.Size = new System.Drawing.Size(101, 35);
            this.buttonINCR.TabIndex = 0;
            this.buttonINCR.Text = "INCR";
            this.buttonINCR.UseVisualStyleBackColor = true;
            this.buttonINCR.Click += new System.EventHandler(this.buttonINCR_Click);
            // 
            // SegmentLED0
            // 
            this.SegmentLED0.BackColor = System.Drawing.Color.Black;
            this.SegmentLED0.Location = new System.Drawing.Point(241, 81);
            this.SegmentLED0.Name = "SegmentLED0";
            this.SegmentLED0.Size = new System.Drawing.Size(82, 19);
            this.SegmentLED0.TabIndex = 1;
            this.SegmentLED0.TabStop = false;
            // 
            // SegmentLED01
            // 
            this.SegmentLED01.BackColor = System.Drawing.Color.Black;
            this.SegmentLED01.Location = new System.Drawing.Point(329, 100);
            this.SegmentLED01.Name = "SegmentLED01";
            this.SegmentLED01.Size = new System.Drawing.Size(19, 82);
            this.SegmentLED01.TabIndex = 2;
            this.SegmentLED01.TabStop = false;
            // 
            // SegmentLED2
            // 
            this.SegmentLED2.BackColor = System.Drawing.Color.Black;
            this.SegmentLED2.Location = new System.Drawing.Point(329, 197);
            this.SegmentLED2.Name = "SegmentLED2";
            this.SegmentLED2.Size = new System.Drawing.Size(19, 82);
            this.SegmentLED2.TabIndex = 3;
            this.SegmentLED2.TabStop = false;
            // 
            // SegmentLED3
            // 
            this.SegmentLED3.BackColor = System.Drawing.Color.Black;
            this.SegmentLED3.Location = new System.Drawing.Point(241, 280);
            this.SegmentLED3.Name = "SegmentLED3";
            this.SegmentLED3.Size = new System.Drawing.Size(82, 19);
            this.SegmentLED3.TabIndex = 4;
            this.SegmentLED3.TabStop = false;
            // 
            // SegmentLED4
            // 
            this.SegmentLED4.BackColor = System.Drawing.Color.Black;
            this.SegmentLED4.Location = new System.Drawing.Point(216, 197);
            this.SegmentLED4.Name = "SegmentLED4";
            this.SegmentLED4.Size = new System.Drawing.Size(19, 82);
            this.SegmentLED4.TabIndex = 5;
            this.SegmentLED4.TabStop = false;
            // 
            // SegmentLED5
            // 
            this.SegmentLED5.BackColor = System.Drawing.Color.Black;
            this.SegmentLED5.Location = new System.Drawing.Point(216, 100);
            this.SegmentLED5.Name = "SegmentLED5";
            this.SegmentLED5.Size = new System.Drawing.Size(19, 82);
            this.SegmentLED5.TabIndex = 6;
            this.SegmentLED5.TabStop = false;
            // 
            // SegmentLED6
            // 
            this.SegmentLED6.BackColor = System.Drawing.Color.Black;
            this.SegmentLED6.Location = new System.Drawing.Point(241, 179);
            this.SegmentLED6.Name = "SegmentLED6";
            this.SegmentLED6.Size = new System.Drawing.Size(82, 19);
            this.SegmentLED6.TabIndex = 7;
            this.SegmentLED6.TabStop = false;
            // 
            // binaryLED0
            // 
            this.binaryLED0.BackColor = System.Drawing.Color.Black;
            this.binaryLED0.Location = new System.Drawing.Point(658, 30);
            this.binaryLED0.Name = "binaryLED0";
            this.binaryLED0.Size = new System.Drawing.Size(19, 19);
            this.binaryLED0.TabIndex = 8;
            this.binaryLED0.TabStop = false;
            // 
            // binaryLED1
            // 
            this.binaryLED1.BackColor = System.Drawing.Color.Black;
            this.binaryLED1.Location = new System.Drawing.Point(587, 30);
            this.binaryLED1.Name = "binaryLED1";
            this.binaryLED1.Size = new System.Drawing.Size(19, 19);
            this.binaryLED1.TabIndex = 9;
            this.binaryLED1.TabStop = false;
            // 
            // binaryLED2
            // 
            this.binaryLED2.BackColor = System.Drawing.Color.Black;
            this.binaryLED2.Location = new System.Drawing.Point(514, 30);
            this.binaryLED2.Name = "binaryLED2";
            this.binaryLED2.Size = new System.Drawing.Size(19, 19);
            this.binaryLED2.TabIndex = 10;
            this.binaryLED2.TabStop = false;
            // 
            // binaryLED3
            // 
            this.binaryLED3.BackColor = System.Drawing.Color.Black;
            this.binaryLED3.Location = new System.Drawing.Point(427, 30);
            this.binaryLED3.Name = "binaryLED3";
            this.binaryLED3.Size = new System.Drawing.Size(19, 19);
            this.binaryLED3.TabIndex = 11;
            this.binaryLED3.TabStop = false;
            // 
            // binaryLED4
            // 
            this.binaryLED4.BackColor = System.Drawing.Color.Black;
            this.binaryLED4.Location = new System.Drawing.Point(343, 30);
            this.binaryLED4.Name = "binaryLED4";
            this.binaryLED4.Size = new System.Drawing.Size(19, 19);
            this.binaryLED4.TabIndex = 12;
            this.binaryLED4.TabStop = false;
            // 
            // binaryLED5
            // 
            this.binaryLED5.BackColor = System.Drawing.Color.Black;
            this.binaryLED5.Location = new System.Drawing.Point(250, 30);
            this.binaryLED5.Name = "binaryLED5";
            this.binaryLED5.Size = new System.Drawing.Size(19, 19);
            this.binaryLED5.TabIndex = 13;
            this.binaryLED5.TabStop = false;
            // 
            // binaryLED6
            // 
            this.binaryLED6.BackColor = System.Drawing.Color.Black;
            this.binaryLED6.Location = new System.Drawing.Point(146, 30);
            this.binaryLED6.Name = "binaryLED6";
            this.binaryLED6.Size = new System.Drawing.Size(19, 19);
            this.binaryLED6.TabIndex = 14;
            this.binaryLED6.TabStop = false;
            // 
            // sourceCodeBox
            // 
            this.sourceCodeBox.AcceptsReturn = true;
            this.sourceCodeBox.AcceptsTab = true;
            this.sourceCodeBox.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.sourceCodeBox.Location = new System.Drawing.Point(12, 55);
            this.sourceCodeBox.Multiline = true;
            this.sourceCodeBox.Name = "sourceCodeBox";
            this.sourceCodeBox.Size = new System.Drawing.Size(153, 383);
            this.sourceCodeBox.TabIndex = 15;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileFToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileFToolStripMenuItem
            // 
            this.fileFToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFileOToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.fileFToolStripMenuItem.Name = "fileFToolStripMenuItem";
            this.fileFToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.fileFToolStripMenuItem.Text = "ファイル (&F)";
            // 
            // openFileOToolStripMenuItem
            // 
            this.openFileOToolStripMenuItem.Name = "openFileOToolStripMenuItem";
            this.openFileOToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openFileOToolStripMenuItem.Text = "開く (&O)";
            this.openFileOToolStripMenuItem.Click += new System.EventHandler(this.openFileOToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem.Text = "上書き保存 (&S)";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sourceCodeBox);
            this.Controls.Add(this.binaryLED6);
            this.Controls.Add(this.binaryLED5);
            this.Controls.Add(this.binaryLED4);
            this.Controls.Add(this.binaryLED3);
            this.Controls.Add(this.binaryLED2);
            this.Controls.Add(this.binaryLED1);
            this.Controls.Add(this.binaryLED0);
            this.Controls.Add(this.SegmentLED6);
            this.Controls.Add(this.SegmentLED5);
            this.Controls.Add(this.SegmentLED4);
            this.Controls.Add(this.SegmentLED3);
            this.Controls.Add(this.SegmentLED2);
            this.Controls.Add(this.SegmentLED01);
            this.Controls.Add(this.SegmentLED0);
            this.Controls.Add(this.buttonINCR);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.SegmentLED0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SegmentLED01)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SegmentLED2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SegmentLED3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SegmentLED4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SegmentLED5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SegmentLED6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.binaryLED0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.binaryLED1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.binaryLED2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.binaryLED3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.binaryLED4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.binaryLED5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.binaryLED6)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonINCR;
        private System.Windows.Forms.PictureBox SegmentLED0;
        private System.Windows.Forms.PictureBox SegmentLED01;
        private System.Windows.Forms.PictureBox SegmentLED2;
        private System.Windows.Forms.PictureBox SegmentLED3;
        private System.Windows.Forms.PictureBox SegmentLED4;
        private System.Windows.Forms.PictureBox SegmentLED5;
        private System.Windows.Forms.PictureBox SegmentLED6;
        private System.Windows.Forms.PictureBox binaryLED0;
        private System.Windows.Forms.PictureBox binaryLED1;
        private System.Windows.Forms.PictureBox binaryLED2;
        private System.Windows.Forms.PictureBox binaryLED3;
        private System.Windows.Forms.PictureBox binaryLED4;
        private System.Windows.Forms.PictureBox binaryLED5;
        private System.Windows.Forms.PictureBox binaryLED6;
        private System.Windows.Forms.TextBox sourceCodeBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFileOToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
    }
}

