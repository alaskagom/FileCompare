namespace FileCompare
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblAppName = new Label();
            splitContainer1 = new SplitContainer();
            panel3 = new Panel();
            lvwLeftDir = new ListView();
            panel2 = new Panel();
            btnLeftDir = new Button();
            panel1 = new Panel();
            btnCopyFromLeft = new Button();
            txtLeftDir = new TextBox();
            panel6 = new Panel();
            lvwrightDir = new ListView();
            panel5 = new Panel();
            btnCopyFromRight = new Button();
            txtRightDir = new TextBox();
            panel4 = new Panel();
            btnRightDir = new Button();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // lblAppName
            // 
            lblAppName.AutoSize = true;
            lblAppName.Font = new Font("맑은 고딕", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 129);
            lblAppName.ForeColor = Color.Blue;
            lblAppName.Location = new Point(57, 65);
            lblAppName.Name = "lblAppName";
            lblAppName.Size = new Size(232, 46);
            lblAppName.TabIndex = 0;
            lblAppName.Text = "File Compare";
            // 
            // splitContainer1
            // 
            splitContainer1.Location = new Point(42, 51);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(panel3);
            splitContainer1.Panel1.Controls.Add(panel2);
            splitContainer1.Panel1.Controls.Add(panel1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(panel6);
            splitContainer1.Panel2.Controls.Add(panel5);
            splitContainer1.Panel2.Controls.Add(panel4);
            splitContainer1.Size = new Size(945, 475);
            splitContainer1.SplitterDistance = 472;
            splitContainer1.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel3.Controls.Add(lvwLeftDir);
            panel3.Location = new Point(0, 164);
            panel3.Name = "panel3";
            panel3.Size = new Size(472, 311);
            panel3.TabIndex = 1;
            panel3.Paint += panel3_Paint;
            // 
            // lvwLeftDir
            // 
            lvwLeftDir.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lvwLeftDir.Location = new Point(21, 20);
            lvwLeftDir.Name = "lvwLeftDir";
            lvwLeftDir.Size = new Size(432, 274);
            lvwLeftDir.TabIndex = 0;
            lvwLeftDir.UseCompatibleStateImageBehavior = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnLeftDir);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(472, 92);
            panel2.TabIndex = 0;
            // 
            // btnLeftDir
            // 
            btnLeftDir.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnLeftDir.Font = new Font("맑은 고딕", 12F, FontStyle.Regular, GraphicsUnit.Point, 129);
            btnLeftDir.Location = new Point(359, 31);
            btnLeftDir.Name = "btnLeftDir";
            btnLeftDir.Size = new Size(94, 41);
            btnLeftDir.TabIndex = 0;
            btnLeftDir.Text = ">>>";
            btnLeftDir.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnCopyFromLeft);
            panel1.Controls.Add(txtLeftDir);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(472, 475);
            panel1.TabIndex = 0;
            // 
            // btnCopyFromLeft
            // 
            btnCopyFromLeft.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnCopyFromLeft.Location = new Point(359, 115);
            btnCopyFromLeft.Name = "btnCopyFromLeft";
            btnCopyFromLeft.Size = new Size(94, 29);
            btnCopyFromLeft.TabIndex = 3;
            btnCopyFromLeft.Text = "폴더선택";
            btnCopyFromLeft.UseVisualStyleBackColor = true;
            btnCopyFromLeft.Click += btnCopyFromLeft_Click;
            // 
            // txtLeftDir
            // 
            txtLeftDir.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtLeftDir.Font = new Font("맑은 고딕", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 129);
            txtLeftDir.Location = new Point(21, 115);
            txtLeftDir.Name = "txtLeftDir";
            txtLeftDir.Size = new Size(319, 30);
            txtLeftDir.TabIndex = 3;
            // 
            // panel6
            // 
            panel6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel6.Controls.Add(lvwrightDir);
            panel6.Location = new Point(0, 164);
            panel6.Name = "panel6";
            panel6.Size = new Size(469, 311);
            panel6.TabIndex = 2;
            // 
            // lvwrightDir
            // 
            lvwrightDir.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lvwrightDir.Location = new Point(17, 20);
            lvwrightDir.Name = "lvwrightDir";
            lvwrightDir.Size = new Size(432, 274);
            lvwrightDir.TabIndex = 1;
            lvwrightDir.UseCompatibleStateImageBehavior = false;
            // 
            // panel5
            // 
            panel5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel5.Controls.Add(btnCopyFromRight);
            panel5.Controls.Add(txtRightDir);
            panel5.Location = new Point(0, 92);
            panel5.Name = "panel5";
            panel5.Size = new Size(469, 383);
            panel5.TabIndex = 1;
            // 
            // btnCopyFromRight
            // 
            btnCopyFromRight.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnCopyFromRight.Location = new Point(359, 23);
            btnCopyFromRight.Name = "btnCopyFromRight";
            btnCopyFromRight.Size = new Size(94, 29);
            btnCopyFromRight.TabIndex = 2;
            btnCopyFromRight.Text = "폴더선택";
            btnCopyFromRight.UseVisualStyleBackColor = true;
            btnCopyFromRight.Click += btnCopyFromRight_Click;
            // 
            // txtRightDir
            // 
            txtRightDir.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtRightDir.Font = new Font("맑은 고딕", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 129);
            txtRightDir.Location = new Point(13, 23);
            txtRightDir.Name = "txtRightDir";
            txtRightDir.Size = new Size(329, 30);
            txtRightDir.TabIndex = 1;
            txtRightDir.TextChanged += textBox2_TextChanged;
            // 
            // panel4
            // 
            panel4.Controls.Add(btnRightDir);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(469, 92);
            panel4.TabIndex = 0;
            // 
            // btnRightDir
            // 
            btnRightDir.Font = new Font("맑은 고딕", 12F, FontStyle.Regular, GraphicsUnit.Point, 129);
            btnRightDir.Location = new Point(13, 31);
            btnRightDir.Name = "btnRightDir";
            btnRightDir.Size = new Size(94, 41);
            btnRightDir.TabIndex = 1;
            btnRightDir.Text = "<<<";
            btnRightDir.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1025, 569);
            Controls.Add(lblAppName);
            Controls.Add(splitContainer1);
            Name = "Form1";
            Padding = new Padding(5);
            Text = "File Compare v1.0";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel6.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAppName;
        private SplitContainer splitContainer1;
        private Panel panel3;
        private Panel panel2;
        private Panel panel1;
        private Panel panel6;
        private Panel panel5;
        private Panel panel4;
        private ListView lvwLeftDir;
        private Button btnLeftDir;
        private ListView lvwrightDir;
        private Button btnCopyFromRight;
        private TextBox txtRightDir;
        private Button btnRightDir;
        private Button btnCopyFromLeft;
        private TextBox txtLeftDir;
    }
}
