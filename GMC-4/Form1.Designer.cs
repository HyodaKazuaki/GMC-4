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
            this.components = new System.ComponentModel.Container();
            this.buttonINCR = new System.Windows.Forms.Button();
            this.SegmentLED0 = new System.Windows.Forms.PictureBox();
            this.SegmentLED1 = new System.Windows.Forms.PictureBox();
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
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.memoryText = new System.Windows.Forms.TextBox();
            this.assembleButton = new System.Windows.Forms.Button();
            this.runButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.resetButton = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.buttonA = new System.Windows.Forms.Button();
            this.buttonB = new System.Windows.Forms.Button();
            this.buttonC = new System.Windows.Forms.Button();
            this.buttonD = new System.Windows.Forms.Button();
            this.buttonE = new System.Windows.Forms.Button();
            this.buttonF = new System.Windows.Forms.Button();
            this.addressSetButton = new System.Windows.Forms.Button();
            this.memoryResetButton = new System.Windows.Forms.Button();
            this.clockSpeed = new System.Windows.Forms.NumericUpDown();
            this.clockSpeedSetButton = new System.Windows.Forms.Button();
            this.stepRunButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SegmentLED0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SegmentLED1)).BeginInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.clockSpeed)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonINCR
            // 
            this.buttonINCR.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonINCR.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonINCR.Location = new System.Drawing.Point(860, 189);
            this.buttonINCR.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.buttonINCR.Name = "buttonINCR";
            this.buttonINCR.Size = new System.Drawing.Size(118, 52);
            this.buttonINCR.TabIndex = 0;
            this.buttonINCR.Text = "INCR";
            this.buttonINCR.UseVisualStyleBackColor = true;
            this.buttonINCR.Click += new System.EventHandler(this.buttonINCR_Click);
            // 
            // SegmentLED0
            // 
            this.SegmentLED0.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.SegmentLED0.BackColor = System.Drawing.Color.Black;
            this.SegmentLED0.Location = new System.Drawing.Point(352, 134);
            this.SegmentLED0.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.SegmentLED0.Name = "SegmentLED0";
            this.SegmentLED0.Size = new System.Drawing.Size(96, 28);
            this.SegmentLED0.TabIndex = 1;
            this.SegmentLED0.TabStop = false;
            // 
            // SegmentLED1
            // 
            this.SegmentLED1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.SegmentLED1.BackColor = System.Drawing.Color.Black;
            this.SegmentLED1.Location = new System.Drawing.Point(454, 162);
            this.SegmentLED1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.SegmentLED1.Name = "SegmentLED1";
            this.SegmentLED1.Size = new System.Drawing.Size(22, 123);
            this.SegmentLED1.TabIndex = 2;
            this.SegmentLED1.TabStop = false;
            // 
            // SegmentLED2
            // 
            this.SegmentLED2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.SegmentLED2.BackColor = System.Drawing.Color.Black;
            this.SegmentLED2.Location = new System.Drawing.Point(454, 308);
            this.SegmentLED2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.SegmentLED2.Name = "SegmentLED2";
            this.SegmentLED2.Size = new System.Drawing.Size(22, 123);
            this.SegmentLED2.TabIndex = 3;
            this.SegmentLED2.TabStop = false;
            // 
            // SegmentLED3
            // 
            this.SegmentLED3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.SegmentLED3.BackColor = System.Drawing.Color.Black;
            this.SegmentLED3.Location = new System.Drawing.Point(352, 432);
            this.SegmentLED3.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.SegmentLED3.Name = "SegmentLED3";
            this.SegmentLED3.Size = new System.Drawing.Size(96, 28);
            this.SegmentLED3.TabIndex = 4;
            this.SegmentLED3.TabStop = false;
            // 
            // SegmentLED4
            // 
            this.SegmentLED4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.SegmentLED4.BackColor = System.Drawing.Color.Black;
            this.SegmentLED4.Location = new System.Drawing.Point(322, 308);
            this.SegmentLED4.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.SegmentLED4.Name = "SegmentLED4";
            this.SegmentLED4.Size = new System.Drawing.Size(22, 123);
            this.SegmentLED4.TabIndex = 5;
            this.SegmentLED4.TabStop = false;
            // 
            // SegmentLED5
            // 
            this.SegmentLED5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.SegmentLED5.BackColor = System.Drawing.Color.Black;
            this.SegmentLED5.Location = new System.Drawing.Point(322, 162);
            this.SegmentLED5.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.SegmentLED5.Name = "SegmentLED5";
            this.SegmentLED5.Size = new System.Drawing.Size(22, 123);
            this.SegmentLED5.TabIndex = 6;
            this.SegmentLED5.TabStop = false;
            // 
            // SegmentLED6
            // 
            this.SegmentLED6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.SegmentLED6.BackColor = System.Drawing.Color.Black;
            this.SegmentLED6.Location = new System.Drawing.Point(352, 280);
            this.SegmentLED6.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.SegmentLED6.Name = "SegmentLED6";
            this.SegmentLED6.Size = new System.Drawing.Size(96, 28);
            this.SegmentLED6.TabIndex = 7;
            this.SegmentLED6.TabStop = false;
            // 
            // binaryLED0
            // 
            this.binaryLED0.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.binaryLED0.BackColor = System.Drawing.Color.Black;
            this.binaryLED0.Location = new System.Drawing.Point(768, 45);
            this.binaryLED0.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.binaryLED0.Name = "binaryLED0";
            this.binaryLED0.Size = new System.Drawing.Size(22, 28);
            this.binaryLED0.TabIndex = 8;
            this.binaryLED0.TabStop = false;
            // 
            // binaryLED1
            // 
            this.binaryLED1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.binaryLED1.BackColor = System.Drawing.Color.Black;
            this.binaryLED1.Location = new System.Drawing.Point(684, 45);
            this.binaryLED1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.binaryLED1.Name = "binaryLED1";
            this.binaryLED1.Size = new System.Drawing.Size(22, 28);
            this.binaryLED1.TabIndex = 9;
            this.binaryLED1.TabStop = false;
            // 
            // binaryLED2
            // 
            this.binaryLED2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.binaryLED2.BackColor = System.Drawing.Color.Black;
            this.binaryLED2.Location = new System.Drawing.Point(600, 45);
            this.binaryLED2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.binaryLED2.Name = "binaryLED2";
            this.binaryLED2.Size = new System.Drawing.Size(22, 28);
            this.binaryLED2.TabIndex = 10;
            this.binaryLED2.TabStop = false;
            // 
            // binaryLED3
            // 
            this.binaryLED3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.binaryLED3.BackColor = System.Drawing.Color.Black;
            this.binaryLED3.Location = new System.Drawing.Point(498, 45);
            this.binaryLED3.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.binaryLED3.Name = "binaryLED3";
            this.binaryLED3.Size = new System.Drawing.Size(22, 28);
            this.binaryLED3.TabIndex = 11;
            this.binaryLED3.TabStop = false;
            // 
            // binaryLED4
            // 
            this.binaryLED4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.binaryLED4.BackColor = System.Drawing.Color.Black;
            this.binaryLED4.Location = new System.Drawing.Point(400, 45);
            this.binaryLED4.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.binaryLED4.Name = "binaryLED4";
            this.binaryLED4.Size = new System.Drawing.Size(22, 28);
            this.binaryLED4.TabIndex = 12;
            this.binaryLED4.TabStop = false;
            // 
            // binaryLED5
            // 
            this.binaryLED5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.binaryLED5.BackColor = System.Drawing.Color.Black;
            this.binaryLED5.Location = new System.Drawing.Point(292, 45);
            this.binaryLED5.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.binaryLED5.Name = "binaryLED5";
            this.binaryLED5.Size = new System.Drawing.Size(22, 28);
            this.binaryLED5.TabIndex = 13;
            this.binaryLED5.TabStop = false;
            // 
            // binaryLED6
            // 
            this.binaryLED6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.binaryLED6.BackColor = System.Drawing.Color.Black;
            this.binaryLED6.Location = new System.Drawing.Point(170, 45);
            this.binaryLED6.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.binaryLED6.Name = "binaryLED6";
            this.binaryLED6.Size = new System.Drawing.Size(22, 28);
            this.binaryLED6.TabIndex = 14;
            this.binaryLED6.TabStop = false;
            // 
            // sourceCodeBox
            // 
            this.sourceCodeBox.AcceptsReturn = true;
            this.sourceCodeBox.AcceptsTab = true;
            this.sourceCodeBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sourceCodeBox.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.sourceCodeBox.Location = new System.Drawing.Point(14, 82);
            this.sourceCodeBox.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.sourceCodeBox.Multiline = true;
            this.sourceCodeBox.Name = "sourceCodeBox";
            this.sourceCodeBox.Size = new System.Drawing.Size(245, 464);
            this.sourceCodeBox.TabIndex = 15;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileFToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1008, 25);
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
            this.openFileOToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.openFileOToolStripMenuItem.Text = "開く (&O)";
            this.openFileOToolStripMenuItem.Click += new System.EventHandler(this.openFileOToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.saveToolStripMenuItem.Text = "上書き保存 (&S)";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // memoryText
            // 
            this.memoryText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.memoryText.Location = new System.Drawing.Point(14, 639);
            this.memoryText.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.memoryText.Name = "memoryText";
            this.memoryText.Size = new System.Drawing.Size(986, 21);
            this.memoryText.TabIndex = 17;
            // 
            // assembleButton
            // 
            this.assembleButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.assembleButton.Font = new System.Drawing.Font("Gill Sans MT", 12F);
            this.assembleButton.Location = new System.Drawing.Point(51, 558);
            this.assembleButton.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.assembleButton.Name = "assembleButton";
            this.assembleButton.Size = new System.Drawing.Size(179, 52);
            this.assembleButton.TabIndex = 18;
            this.assembleButton.Text = "Assemble";
            this.assembleButton.UseVisualStyleBackColor = true;
            this.assembleButton.Click += new System.EventHandler(this.assembleButton_Click);
            // 
            // runButton
            // 
            this.runButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.runButton.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.runButton.Location = new System.Drawing.Point(860, 280);
            this.runButton.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.runButton.Name = "runButton";
            this.runButton.Size = new System.Drawing.Size(118, 52);
            this.runButton.TabIndex = 19;
            this.runButton.Text = "RUN";
            this.runButton.UseVisualStyleBackColor = true;
            this.runButton.Click += new System.EventHandler(this.runButton_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // resetButton
            // 
            this.resetButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.resetButton.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetButton.Location = new System.Drawing.Point(860, 545);
            this.resetButton.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(118, 52);
            this.resetButton.TabIndex = 20;
            this.resetButton.Text = "RESET";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // button0
            // 
            this.button0.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button0.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button0.Location = new System.Drawing.Point(557, 393);
            this.button0.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(45, 52);
            this.button0.TabIndex = 21;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = true;
            this.button0.Click += new System.EventHandler(this.buttonNumber_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button1.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(609, 393);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(45, 52);
            this.button1.TabIndex = 22;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonNumber_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button2.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(661, 393);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(45, 52);
            this.button2.TabIndex = 23;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.buttonNumber_Click);
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button3.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(717, 393);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(45, 52);
            this.button3.TabIndex = 24;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.buttonNumber_Click);
            // 
            // button4
            // 
            this.button4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button4.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(557, 332);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(45, 52);
            this.button4.TabIndex = 25;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.buttonNumber_Click);
            // 
            // button5
            // 
            this.button5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button5.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(609, 332);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(45, 52);
            this.button5.TabIndex = 26;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.buttonNumber_Click);
            // 
            // button6
            // 
            this.button6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button6.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(661, 332);
            this.button6.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(45, 52);
            this.button6.TabIndex = 27;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.buttonNumber_Click);
            // 
            // button7
            // 
            this.button7.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button7.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(717, 332);
            this.button7.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(45, 52);
            this.button7.TabIndex = 28;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.buttonNumber_Click);
            // 
            // button8
            // 
            this.button8.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button8.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(557, 270);
            this.button8.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(45, 52);
            this.button8.TabIndex = 29;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.buttonNumber_Click);
            // 
            // button9
            // 
            this.button9.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button9.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(609, 270);
            this.button9.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(45, 52);
            this.button9.TabIndex = 30;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.buttonNumber_Click);
            // 
            // buttonA
            // 
            this.buttonA.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonA.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonA.Location = new System.Drawing.Point(661, 270);
            this.buttonA.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.buttonA.Name = "buttonA";
            this.buttonA.Size = new System.Drawing.Size(45, 52);
            this.buttonA.TabIndex = 31;
            this.buttonA.Text = "A";
            this.buttonA.UseVisualStyleBackColor = true;
            this.buttonA.Click += new System.EventHandler(this.buttonNumber_Click);
            // 
            // buttonB
            // 
            this.buttonB.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonB.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonB.Location = new System.Drawing.Point(717, 270);
            this.buttonB.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.buttonB.Name = "buttonB";
            this.buttonB.Size = new System.Drawing.Size(45, 52);
            this.buttonB.TabIndex = 32;
            this.buttonB.Text = "B";
            this.buttonB.UseVisualStyleBackColor = true;
            this.buttonB.Click += new System.EventHandler(this.buttonNumber_Click);
            // 
            // buttonC
            // 
            this.buttonC.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonC.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonC.Location = new System.Drawing.Point(557, 208);
            this.buttonC.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.buttonC.Name = "buttonC";
            this.buttonC.Size = new System.Drawing.Size(45, 52);
            this.buttonC.TabIndex = 33;
            this.buttonC.Text = "C";
            this.buttonC.UseVisualStyleBackColor = true;
            this.buttonC.Click += new System.EventHandler(this.buttonNumber_Click);
            // 
            // buttonD
            // 
            this.buttonD.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonD.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonD.Location = new System.Drawing.Point(609, 208);
            this.buttonD.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.buttonD.Name = "buttonD";
            this.buttonD.Size = new System.Drawing.Size(45, 52);
            this.buttonD.TabIndex = 34;
            this.buttonD.Text = "D";
            this.buttonD.UseVisualStyleBackColor = true;
            this.buttonD.Click += new System.EventHandler(this.buttonNumber_Click);
            // 
            // buttonE
            // 
            this.buttonE.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonE.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonE.Location = new System.Drawing.Point(661, 208);
            this.buttonE.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.buttonE.Name = "buttonE";
            this.buttonE.Size = new System.Drawing.Size(45, 52);
            this.buttonE.TabIndex = 35;
            this.buttonE.Text = "E";
            this.buttonE.UseVisualStyleBackColor = true;
            this.buttonE.Click += new System.EventHandler(this.buttonNumber_Click);
            // 
            // buttonF
            // 
            this.buttonF.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonF.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonF.Location = new System.Drawing.Point(717, 208);
            this.buttonF.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.buttonF.Name = "buttonF";
            this.buttonF.Size = new System.Drawing.Size(45, 52);
            this.buttonF.TabIndex = 36;
            this.buttonF.Text = "F";
            this.buttonF.UseVisualStyleBackColor = true;
            this.buttonF.Click += new System.EventHandler(this.buttonNumber_Click);
            // 
            // addressSetButton
            // 
            this.addressSetButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.addressSetButton.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressSetButton.Location = new System.Drawing.Point(860, 110);
            this.addressSetButton.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.addressSetButton.Name = "addressSetButton";
            this.addressSetButton.Size = new System.Drawing.Size(118, 52);
            this.addressSetButton.TabIndex = 37;
            this.addressSetButton.Text = "A SET";
            this.addressSetButton.UseVisualStyleBackColor = true;
            this.addressSetButton.Click += new System.EventHandler(this.addressSetButton_Click);
            // 
            // memoryResetButton
            // 
            this.memoryResetButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.memoryResetButton.Font = new System.Drawing.Font("Gill Sans MT", 12F);
            this.memoryResetButton.Location = new System.Drawing.Point(378, 542);
            this.memoryResetButton.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.memoryResetButton.Name = "memoryResetButton";
            this.memoryResetButton.Size = new System.Drawing.Size(58, 56);
            this.memoryResetButton.TabIndex = 38;
            this.memoryResetButton.Text = "CLR";
            this.memoryResetButton.UseVisualStyleBackColor = true;
            this.memoryResetButton.Click += new System.EventHandler(this.memoryResetButton_Click);
            // 
            // clockSpeed
            // 
            this.clockSpeed.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.clockSpeed.Font = new System.Drawing.Font("Gill Sans MT", 12F);
            this.clockSpeed.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.clockSpeed.Location = new System.Drawing.Point(848, 376);
            this.clockSpeed.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.clockSpeed.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.clockSpeed.Name = "clockSpeed";
            this.clockSpeed.Size = new System.Drawing.Size(68, 26);
            this.clockSpeed.TabIndex = 39;
            this.clockSpeed.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // clockSpeedSetButton
            // 
            this.clockSpeedSetButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.clockSpeedSetButton.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clockSpeedSetButton.Location = new System.Drawing.Point(922, 370);
            this.clockSpeedSetButton.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.clockSpeedSetButton.Name = "clockSpeedSetButton";
            this.clockSpeedSetButton.Size = new System.Drawing.Size(77, 52);
            this.clockSpeedSetButton.TabIndex = 40;
            this.clockSpeedSetButton.Text = "Hz SET";
            this.clockSpeedSetButton.UseVisualStyleBackColor = true;
            this.clockSpeedSetButton.Click += new System.EventHandler(this.clockSpeedSetButton_Click);
            // 
            // stepRunButton
            // 
            this.stepRunButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.stepRunButton.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stepRunButton.Location = new System.Drawing.Point(860, 460);
            this.stepRunButton.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.stepRunButton.Name = "stepRunButton";
            this.stepRunButton.Size = new System.Drawing.Size(118, 52);
            this.stepRunButton.TabIndex = 41;
            this.stepRunButton.Text = "STP RUN";
            this.stepRunButton.UseVisualStyleBackColor = true;
            this.stepRunButton.Click += new System.EventHandler(this.stepRunButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 689);
            this.Controls.Add(this.stepRunButton);
            this.Controls.Add(this.clockSpeedSetButton);
            this.Controls.Add(this.clockSpeed);
            this.Controls.Add(this.memoryResetButton);
            this.Controls.Add(this.addressSetButton);
            this.Controls.Add(this.buttonF);
            this.Controls.Add(this.buttonE);
            this.Controls.Add(this.buttonD);
            this.Controls.Add(this.buttonC);
            this.Controls.Add(this.buttonB);
            this.Controls.Add(this.buttonA);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.runButton);
            this.Controls.Add(this.assembleButton);
            this.Controls.Add(this.memoryText);
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
            this.Controls.Add(this.SegmentLED1);
            this.Controls.Add(this.SegmentLED0);
            this.Controls.Add(this.buttonINCR);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Gill Sans MT", 9F);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MinimumSize = new System.Drawing.Size(1024, 728);
            this.Name = "Form1";
            this.Text = "GMC-4";
            ((System.ComponentModel.ISupportInitialize)(this.SegmentLED0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SegmentLED1)).EndInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.clockSpeed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonINCR;
        private System.Windows.Forms.PictureBox SegmentLED0;
        private System.Windows.Forms.PictureBox SegmentLED1;
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
        private System.Windows.Forms.TextBox memoryText;
        private System.Windows.Forms.Button assembleButton;
        private System.Windows.Forms.Button runButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button buttonA;
        private System.Windows.Forms.Button buttonB;
        private System.Windows.Forms.Button buttonC;
        private System.Windows.Forms.Button buttonD;
        private System.Windows.Forms.Button buttonE;
        private System.Windows.Forms.Button buttonF;
        private System.Windows.Forms.Button addressSetButton;
        private System.Windows.Forms.Button memoryResetButton;
        public System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.NumericUpDown clockSpeed;
        private System.Windows.Forms.Button clockSpeedSetButton;
        private System.Windows.Forms.Button stepRunButton;
    }
}

