namespace CPM
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
            components = new System.ComponentModel.Container();
            VideoPB = new PictureBox();
            DrawPB = new PictureBox();
            OnOffBtn = new Button();
            framtick = new System.Windows.Forms.Timer(components);
            numR = new NumericUpDown();
            numG = new NumericUpDown();
            numB = new NumericUpDown();
            SetColor = new Button();
            Clear = new Button();
            Save = new Button();
            saveFileDialog1 = new SaveFileDialog();
            Open = new Button();
            openFileDialog1 = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)VideoPB).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DrawPB).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numR).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numG).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numB).BeginInit();
            SuspendLayout();
            // 
            // VideoPB
            // 
            VideoPB.BorderStyle = BorderStyle.FixedSingle;
            VideoPB.Location = new Point(12, 12);
            VideoPB.Name = "VideoPB";
            VideoPB.Size = new Size(640, 480);
            VideoPB.TabIndex = 0;
            VideoPB.TabStop = false;
            // 
            // DrawPB
            // 
            DrawPB.BackColor = SystemColors.Control;
            DrawPB.BorderStyle = BorderStyle.FixedSingle;
            DrawPB.Location = new Point(658, 12);
            DrawPB.Name = "DrawPB";
            DrawPB.Size = new Size(640, 480);
            DrawPB.TabIndex = 1;
            DrawPB.TabStop = false;
            // 
            // OnOffBtn
            // 
            OnOffBtn.Location = new Point(12, 503);
            OnOffBtn.Name = "OnOffBtn";
            OnOffBtn.Size = new Size(75, 23);
            OnOffBtn.TabIndex = 2;
            OnOffBtn.Text = "Start";
            OnOffBtn.UseVisualStyleBackColor = true;
            OnOffBtn.Click += OnOffBtn_Click;
            // 
            // framtick
            // 
            framtick.Interval = 34;
            framtick.Tick += framtick_Tick;
            // 
            // numR
            // 
            numR.Location = new Point(174, 503);
            numR.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            numR.Name = "numR";
            numR.Size = new Size(56, 23);
            numR.TabIndex = 3;
            // 
            // numG
            // 
            numG.Location = new Point(236, 503);
            numG.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            numG.Name = "numG";
            numG.Size = new Size(56, 23);
            numG.TabIndex = 4;
            // 
            // numB
            // 
            numB.Location = new Point(298, 503);
            numB.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            numB.Name = "numB";
            numB.Size = new Size(56, 23);
            numB.TabIndex = 5;
            // 
            // SetColor
            // 
            SetColor.Location = new Point(360, 503);
            SetColor.Name = "SetColor";
            SetColor.Size = new Size(75, 23);
            SetColor.TabIndex = 6;
            SetColor.Text = "Set color";
            SetColor.UseVisualStyleBackColor = true;
            SetColor.Click += SetColor_Click;
            // 
            // Clear
            // 
            Clear.Location = new Point(1219, 498);
            Clear.Name = "Clear";
            Clear.Size = new Size(75, 23);
            Clear.TabIndex = 7;
            Clear.Text = "Clear";
            Clear.UseVisualStyleBackColor = true;
            Clear.Click += Clear_Click;
            // 
            // Save
            // 
            Save.Location = new Point(1138, 498);
            Save.Name = "Save";
            Save.Size = new Size(75, 23);
            Save.TabIndex = 8;
            Save.Text = "Save";
            Save.UseVisualStyleBackColor = true;
            Save.Click += Save_Click;
            // 
            // Open
            // 
            Open.Location = new Point(93, 503);
            Open.Name = "Open";
            Open.Size = new Size(75, 23);
            Open.TabIndex = 9;
            Open.Text = "Open";
            Open.UseVisualStyleBackColor = true;
            Open.Click += Open_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1306, 538);
            Controls.Add(Open);
            Controls.Add(Save);
            Controls.Add(Clear);
            Controls.Add(SetColor);
            Controls.Add(numB);
            Controls.Add(numG);
            Controls.Add(numR);
            Controls.Add(OnOffBtn);
            Controls.Add(DrawPB);
            Controls.Add(VideoPB);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)VideoPB).EndInit();
            ((System.ComponentModel.ISupportInitialize)DrawPB).EndInit();
            ((System.ComponentModel.ISupportInitialize)numR).EndInit();
            ((System.ComponentModel.ISupportInitialize)numG).EndInit();
            ((System.ComponentModel.ISupportInitialize)numB).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox VideoPB;
        private PictureBox DrawPB;
        private Button OnOffBtn;
        private System.Windows.Forms.Timer framtick;
        private NumericUpDown numR;
        private NumericUpDown numG;
        private NumericUpDown numB;
        private Button SetColor;
        private Button Clear;
        private Button Save;
        private SaveFileDialog saveFileDialog1;
        private Button Open;
        private OpenFileDialog openFileDialog1;
    }
}
