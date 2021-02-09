namespace Radio_music_count
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnStart = new System.Windows.Forms.Button();
            this.lbStatus = new System.Windows.Forms.Label();
            this.btnSelect = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnExclude = new System.Windows.Forms.Button();
            this.btnRusMusic = new System.Windows.Forms.Button();
            this.btnKazMusic = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnStart
            // 
            this.btnStart.Enabled = false;
            this.btnStart.Location = new System.Drawing.Point(484, 159);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(152, 47);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Посчитать";
            this.btnStart.UseVisualStyleBackColor = true;
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbStatus.Location = new System.Drawing.Point(480, 12);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(155, 24);
            this.lbStatus.TabIndex = 1;
            this.lbStatus.Text = "Выберите папку";
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(482, 80);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(152, 45);
            this.btnSelect.TabIndex = 2;
            this.btnSelect.Text = "Выбрать";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(439, 424);
            this.listBox1.TabIndex = 3;
            // 
            // btnExclude
            // 
            this.btnExclude.Location = new System.Drawing.Point(1133, 12);
            this.btnExclude.Name = "btnExclude";
            this.btnExclude.Size = new System.Drawing.Size(152, 45);
            this.btnExclude.TabIndex = 4;
            this.btnExclude.Text = "Исключить";
            this.btnExclude.UseVisualStyleBackColor = true;
            this.btnExclude.Click += new System.EventHandler(this.btnExclude_Click);
            // 
            // btnRusMusic
            // 
            this.btnRusMusic.Location = new System.Drawing.Point(714, 12);
            this.btnRusMusic.Name = "btnRusMusic";
            this.btnRusMusic.Size = new System.Drawing.Size(152, 45);
            this.btnRusMusic.TabIndex = 5;
            this.btnRusMusic.Text = "Рус Муз";
            this.btnRusMusic.UseVisualStyleBackColor = true;
            this.btnRusMusic.Click += new System.EventHandler(this.btnRusMusic_Click);
            // 
            // btnKazMusic
            // 
            this.btnKazMusic.Location = new System.Drawing.Point(922, 12);
            this.btnKazMusic.Name = "btnKazMusic";
            this.btnKazMusic.Size = new System.Drawing.Size(152, 45);
            this.btnKazMusic.TabIndex = 6;
            this.btnKazMusic.Text = "Каз Муз";
            this.btnKazMusic.UseVisualStyleBackColor = true;
            this.btnKazMusic.Click += new System.EventHandler(this.btnKazMusic_Click);
            // 
            // listBox2
            // 
            this.listBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 20;
            this.listBox2.Location = new System.Drawing.Point(714, 80);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(571, 344);
            this.listBox2.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1315, 450);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.btnKazMusic);
            this.Controls.Add(this.btnRusMusic);
            this.Controls.Add(this.btnExclude);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.lbStatus);
            this.Controls.Add(this.btnStart);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnExclude;
        private System.Windows.Forms.Button btnRusMusic;
        private System.Windows.Forms.Button btnKazMusic;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}

