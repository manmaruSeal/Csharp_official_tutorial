namespace RentalVideo
{
    partial class RentalVideo
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
            this.DataTimepicker1 = new System.Windows.Forms.DateTimePicker();
            this.DataTimepicker2 = new System.Windows.Forms.DateTimePicker();
            this.moneyCal = new System.Windows.Forms.Button();
            this.newVideo = new System.Windows.Forms.RadioButton();
            this.oldVideo = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rental = new System.Windows.Forms.Label();
            this.plus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DataTimepicker1
            // 
            this.DataTimepicker1.CalendarMonthBackground = System.Drawing.SystemColors.HighlightText;
            this.DataTimepicker1.Font = new System.Drawing.Font("MS UI Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.DataTimepicker1.Location = new System.Drawing.Point(67, 184);
            this.DataTimepicker1.Name = "DataTimepicker1";
            this.DataTimepicker1.Size = new System.Drawing.Size(249, 34);
            this.DataTimepicker1.TabIndex = 0;
            // 
            // DataTimepicker2
            // 
            this.DataTimepicker2.CalendarMonthBackground = System.Drawing.SystemColors.HighlightText;
            this.DataTimepicker2.Font = new System.Drawing.Font("MS UI Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.DataTimepicker2.Location = new System.Drawing.Point(365, 184);
            this.DataTimepicker2.Name = "DataTimepicker2";
            this.DataTimepicker2.Size = new System.Drawing.Size(248, 34);
            this.DataTimepicker2.TabIndex = 1;
            // 
            // moneyCal
            // 
            this.moneyCal.BackColor = System.Drawing.Color.Gold;
            this.moneyCal.Font = new System.Drawing.Font("MS UI Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.moneyCal.Location = new System.Drawing.Point(237, 262);
            this.moneyCal.Name = "moneyCal";
            this.moneyCal.Size = new System.Drawing.Size(173, 47);
            this.moneyCal.TabIndex = 2;
            this.moneyCal.Text = "料金計算";
            this.moneyCal.UseVisualStyleBackColor = false;
            this.moneyCal.Click += new System.EventHandler(this.moneyCal_Click);
            // 
            // newVideo
            // 
            this.newVideo.AutoSize = true;
            this.newVideo.BackColor = System.Drawing.Color.PowderBlue;
            this.newVideo.Checked = true;
            this.newVideo.Font = new System.Drawing.Font("MS UI Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.newVideo.Location = new System.Drawing.Point(255, 62);
            this.newVideo.Name = "newVideo";
            this.newVideo.Size = new System.Drawing.Size(153, 32);
            this.newVideo.TabIndex = 5;
            this.newVideo.TabStop = true;
            this.newVideo.Text = "新規ビデオ";
            this.newVideo.UseVisualStyleBackColor = false;
            // 
            // oldVideo
            // 
            this.oldVideo.AutoSize = true;
            this.oldVideo.Font = new System.Drawing.Font("MS UI Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.oldVideo.Location = new System.Drawing.Point(255, 100);
            this.oldVideo.Name = "oldVideo";
            this.oldVideo.Size = new System.Drawing.Size(125, 32);
            this.oldVideo.TabIndex = 6;
            this.oldVideo.Text = "旧ビデオ";
            this.oldVideo.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Orange;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("MS UI Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox1.ForeColor = System.Drawing.Color.DarkRed;
            this.textBox1.Location = new System.Drawing.Point(67, 156);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(249, 27);
            this.textBox1.TabIndex = 7;
            this.textBox1.Text = "レンタル日時";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.DarkOrange;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("MS UI Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox2.ForeColor = System.Drawing.Color.DarkRed;
            this.textBox2.Location = new System.Drawing.Point(365, 156);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(248, 27);
            this.textBox2.TabIndex = 8;
            this.textBox2.Text = "返却日時";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(74, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 33);
            this.label1.TabIndex = 9;
            this.label1.Text = "借りるビデオ";
            // 
            // rental
            // 
            this.rental.AutoSize = true;
            this.rental.Font = new System.Drawing.Font("MS UI Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.rental.Location = new System.Drawing.Point(140, 359);
            this.rental.Name = "rental";
            this.rental.Size = new System.Drawing.Size(152, 28);
            this.rental.TabIndex = 10;
            this.rental.Text = "レンタル料金";
            // 
            // plus
            // 
            this.plus.AutoSize = true;
            this.plus.Font = new System.Drawing.Font("MS UI Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.plus.Location = new System.Drawing.Point(164, 403);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(124, 28);
            this.plus.TabIndex = 11;
            this.plus.Text = "延滞料金";
            // 
            // RentalVideo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(682, 453);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.rental);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.oldVideo);
            this.Controls.Add(this.newVideo);
            this.Controls.Add(this.moneyCal);
            this.Controls.Add(this.DataTimepicker2);
            this.Controls.Add(this.DataTimepicker1);
            this.ForeColor = System.Drawing.Color.SaddleBrown;
            this.Name = "RentalVideo";
            this.Text = "RentalVideo";
            this.TransparencyKey = System.Drawing.SystemColors.Control;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker DataTimepicker1;
        private System.Windows.Forms.DateTimePicker DataTimepicker2;
        private System.Windows.Forms.Button moneyCal;
        private System.Windows.Forms.RadioButton newVideo;
        private System.Windows.Forms.RadioButton oldVideo;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label rental;
        private System.Windows.Forms.Label plus;
    }
}

