namespace WindowsFormsApplication1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numericUpDownColumn = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownRow = new System.Windows.Forms.NumericUpDown();
            this.checkBoxRemote = new System.Windows.Forms.CheckBox();
            this.checkBoxHelp = new System.Windows.Forms.CheckBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownColumn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRow)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numericUpDownColumn);
            this.groupBox1.Controls.Add(this.numericUpDownRow);
            this.groupBox1.Controls.Add(this.checkBoxRemote);
            this.groupBox1.Controls.Add(this.checkBoxHelp);
            this.groupBox1.Controls.Add(this.btnStart);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(481, 52);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lựa chọn cấu hình";
            // 
            // numericUpDownColumn
            // 
            this.numericUpDownColumn.Location = new System.Drawing.Point(174, 22);
            this.numericUpDownColumn.Name = "numericUpDownColumn";
            this.numericUpDownColumn.Size = new System.Drawing.Size(42, 20);
            this.numericUpDownColumn.TabIndex = 3;
            // 
            // numericUpDownRow
            // 
            this.numericUpDownRow.Location = new System.Drawing.Point(70, 22);
            this.numericUpDownRow.Name = "numericUpDownRow";
            this.numericUpDownRow.Size = new System.Drawing.Size(42, 20);
            this.numericUpDownRow.TabIndex = 3;
            // 
            // checkBoxRemote
            // 
            this.checkBoxRemote.AutoSize = true;
            this.checkBoxRemote.Location = new System.Drawing.Point(412, 23);
            this.checkBoxRemote.Name = "checkBoxRemote";
            this.checkBoxRemote.Size = new System.Drawing.Size(63, 17);
            this.checkBoxRemote.TabIndex = 2;
            this.checkBoxRemote.Text = "Remote";
            this.checkBoxRemote.UseVisualStyleBackColor = true;
            // 
            // checkBoxHelp
            // 
            this.checkBoxHelp.AutoSize = true;
            this.checkBoxHelp.Location = new System.Drawing.Point(342, 23);
            this.checkBoxHelp.Name = "checkBoxHelp";
            this.checkBoxHelp.Size = new System.Drawing.Size(64, 17);
            this.checkBoxHelp.TabIndex = 2;
            this.checkBoxHelp.Text = "Giúp đỡ";
            this.checkBoxHelp.UseVisualStyleBackColor = true;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(233, 17);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(92, 27);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Bắt đầu";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnBatDau_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(127, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Số cột:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số dòng:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Location = new System.Drawing.Point(13, 71);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(480, 320);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Main";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(23, 26);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Padding = new System.Windows.Forms.Padding(30);
            this.pictureBox1.Size = new System.Drawing.Size(200, 149);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 401);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Ghép hình";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownColumn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRow)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown numericUpDownColumn;
        private System.Windows.Forms.NumericUpDown numericUpDownRow;
        private System.Windows.Forms.CheckBox checkBoxRemote;
        private System.Windows.Forms.CheckBox checkBoxHelp;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

