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
            this.btnRusReklama = new System.Windows.Forms.Button();
            this.btnKazReklama = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbCountRusMusic = new System.Windows.Forms.Label();
            this.lbCountKazMusic = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnStart
            // 
            this.btnStart.Enabled = false;
            this.btnStart.Location = new System.Drawing.Point(637, 389);
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
            this.lbStatus.Location = new System.Drawing.Point(633, 72);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(155, 24);
            this.lbStatus.TabIndex = 1;
            this.lbStatus.Text = "Выберите папку";
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(636, 140);
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
            this.listBox1.Location = new System.Drawing.Point(12, 72);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(615, 364);
            this.listBox1.TabIndex = 3;
            // 
            // btnExclude
            // 
            this.btnExclude.Location = new System.Drawing.Point(633, 259);
            this.btnExclude.Name = "btnExclude";
            this.btnExclude.Size = new System.Drawing.Size(152, 45);
            this.btnExclude.TabIndex = 4;
            this.btnExclude.Text = "Исключить";
            this.btnExclude.UseVisualStyleBackColor = true;
            this.btnExclude.Click += new System.EventHandler(this.btnExclude_Click);
            // 
            // btnRusMusic
            // 
            this.btnRusMusic.Location = new System.Drawing.Point(886, 140);
            this.btnRusMusic.Name = "btnRusMusic";
            this.btnRusMusic.Size = new System.Drawing.Size(152, 45);
            this.btnRusMusic.TabIndex = 5;
            this.btnRusMusic.Text = "Рус Муз";
            this.btnRusMusic.UseVisualStyleBackColor = true;
            this.btnRusMusic.Click += new System.EventHandler(this.btnRusMusic_Click);
            // 
            // btnKazMusic
            // 
            this.btnKazMusic.Location = new System.Drawing.Point(886, 259);
            this.btnKazMusic.Name = "btnKazMusic";
            this.btnKazMusic.Size = new System.Drawing.Size(152, 45);
            this.btnKazMusic.TabIndex = 6;
            this.btnKazMusic.Text = "Каз Муз";
            this.btnKazMusic.UseVisualStyleBackColor = true;
            this.btnKazMusic.Click += new System.EventHandler(this.btnKazMusic_Click);
            // 
            // btnRusReklama
            // 
            this.btnRusReklama.Location = new System.Drawing.Point(1093, 140);
            this.btnRusReklama.Name = "btnRusReklama";
            this.btnRusReklama.Size = new System.Drawing.Size(152, 45);
            this.btnRusReklama.TabIndex = 7;
            this.btnRusReklama.Text = "Рус Реклама";
            this.btnRusReklama.UseVisualStyleBackColor = true;
            this.btnRusReklama.Click += new System.EventHandler(this.btnRusReklama_Click);
            // 
            // btnKazReklama
            // 
            this.btnKazReklama.Location = new System.Drawing.Point(1093, 259);
            this.btnKazReklama.Name = "btnKazReklama";
            this.btnKazReklama.Size = new System.Drawing.Size(152, 45);
            this.btnKazReklama.TabIndex = 8;
            this.btnKazReklama.Text = "Каз Реклама";
            this.btnKazReklama.UseVisualStyleBackColor = true;
            this.btnKazReklama.Click += new System.EventHandler(this.btnKazReklama_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(883, 361);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = "Кол рус муз";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(1090, 361);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 24);
            this.label2.TabIndex = 10;
            this.label2.Text = "Кол каз муз";
            // 
            // lbCountRusMusic
            // 
            this.lbCountRusMusic.AutoSize = true;
            this.lbCountRusMusic.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbCountRusMusic.Location = new System.Drawing.Point(932, 398);
            this.lbCountRusMusic.Name = "lbCountRusMusic";
            this.lbCountRusMusic.Size = new System.Drawing.Size(20, 24);
            this.lbCountRusMusic.TabIndex = 11;
            this.lbCountRusMusic.Text = "0";
            this.lbCountRusMusic.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbCountKazMusic
            // 
            this.lbCountKazMusic.AutoSize = true;
            this.lbCountKazMusic.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbCountKazMusic.Location = new System.Drawing.Point(1140, 398);
            this.lbCountKazMusic.Name = "lbCountKazMusic";
            this.lbCountKazMusic.Size = new System.Drawing.Size(20, 24);
            this.lbCountKazMusic.TabIndex = 12;
            this.lbCountKazMusic.Text = "0";
            this.lbCountKazMusic.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1315, 450);
            this.Controls.Add(this.lbCountKazMusic);
            this.Controls.Add(this.lbCountRusMusic);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnKazReklama);
            this.Controls.Add(this.btnRusReklama);
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
        private System.Windows.Forms.Button btnRusReklama;
        private System.Windows.Forms.Button btnKazReklama;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbCountRusMusic;
        private System.Windows.Forms.Label lbCountKazMusic;
    }
}

