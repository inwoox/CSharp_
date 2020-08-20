namespace WindowsFormsApp2
{
  partial class Form1
  {
    /// <summary>
    /// 필수 디자이너 변수입니다.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// 사용 중인 모든 리소스를 정리합니다.
    /// </summary>
    /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form 디자이너에서 생성한 코드

    /// <summary>
    /// 디자이너 지원에 필요한 메서드입니다. 
    /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
    /// </summary>
    private void InitializeComponent()
    {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
      this.button1 = new System.Windows.Forms.Button();
      this.button2 = new System.Windows.Forms.Button();
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.textBox2 = new System.Windows.Forms.TextBox();
      this.button3 = new System.Windows.Forms.Button();
      this.button4 = new System.Windows.Forms.Button();
      this.textBox3 = new System.Windows.Forms.TextBox();
      this.textBox4 = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.label8 = new System.Windows.Forms.Label();
      this.textBox5 = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.textBox6 = new System.Windows.Forms.TextBox();
      this.textBox7 = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.textBox8 = new System.Windows.Forms.TextBox();
      this.label5 = new System.Windows.Forms.Label();
      this.textBox9 = new System.Windows.Forms.TextBox();
      this.label6 = new System.Windows.Forms.Label();
      this.textBox10 = new System.Windows.Forms.TextBox();
      this.button5 = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(35, 805);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(154, 39);
      this.button1.TabIndex = 0;
      this.button1.Text = "대상 디렉토리 정보";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // button2
      // 
      this.button2.Location = new System.Drawing.Point(293, 805);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(164, 39);
      this.button2.TabIndex = 1;
      this.button2.Text = "원본 디렉토리 정보";
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Click += new System.EventHandler(this.button2_Click_1);
      // 
      // textBox1
      // 
      this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.textBox1.Location = new System.Drawing.Point(35, 24);
      this.textBox1.Multiline = true;
      this.textBox1.Name = "textBox1";
      this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.textBox1.Size = new System.Drawing.Size(349, 19);
      this.textBox1.TabIndex = 3;
      this.textBox1.Text = "파일 배포 대상 디렉토리";
      this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      // 
      // textBox2
      // 
      this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.textBox2.Location = new System.Drawing.Point(416, 24);
      this.textBox2.Multiline = true;
      this.textBox2.Name = "textBox2";
      this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.textBox2.Size = new System.Drawing.Size(354, 19);
      this.textBox2.TabIndex = 6;
      this.textBox2.Text = "배포 원본 디렉토리";
      this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      // 
      // button3
      // 
      this.button3.Location = new System.Drawing.Point(545, 805);
      this.button3.Name = "button3";
      this.button3.Size = new System.Drawing.Size(129, 39);
      this.button3.TabIndex = 9;
      this.button3.Text = "HASH 비교 결과";
      this.button3.UseVisualStyleBackColor = true;
      this.button3.Click += new System.EventHandler(this.button3_Click);
      // 
      // button4
      // 
      this.button4.Location = new System.Drawing.Point(963, 805);
      this.button4.Name = "button4";
      this.button4.Size = new System.Drawing.Size(129, 39);
      this.button4.TabIndex = 11;
      this.button4.Text = "결과 삭제";
      this.button4.UseVisualStyleBackColor = true;
      this.button4.Click += new System.EventHandler(this.button4_Click);
      // 
      // textBox3
      // 
      this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.textBox3.Location = new System.Drawing.Point(808, 24);
      this.textBox3.Multiline = true;
      this.textBox3.Name = "textBox3";
      this.textBox3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.textBox3.Size = new System.Drawing.Size(173, 19);
      this.textBox3.TabIndex = 15;
      this.textBox3.Text = "검색 / 변경 파일 타입";
      this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      // 
      // textBox4
      // 
      this.textBox4.BackColor = System.Drawing.SystemColors.ControlLight;
      this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.textBox4.Location = new System.Drawing.Point(167, 71);
      this.textBox4.Multiline = true;
      this.textBox4.Name = "textBox4";
      this.textBox4.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.textBox4.Size = new System.Drawing.Size(946, 92);
      this.textBox4.TabIndex = 16;
      this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      // 
      // label1
      // 
      this.label1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
      this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
      this.label1.Location = new System.Drawing.Point(35, 71);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(117, 92);
      this.label1.TabIndex = 17;
      this.label1.Text = "대상파일 LIST";
      this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // label8
      // 
      this.label8.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
      this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
      this.label8.Location = new System.Drawing.Point(35, 279);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(117, 94);
      this.label8.TabIndex = 18;
      this.label8.Text = "원본파일 LIST";
      this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // textBox5
      // 
      this.textBox5.BackColor = System.Drawing.SystemColors.ControlLight;
      this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.textBox5.Location = new System.Drawing.Point(167, 281);
      this.textBox5.Multiline = true;
      this.textBox5.Name = "textBox5";
      this.textBox5.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.textBox5.Size = new System.Drawing.Size(946, 92);
      this.textBox5.TabIndex = 19;
      this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      // 
      // label2
      // 
      this.label2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
      this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
      this.label2.Location = new System.Drawing.Point(35, 176);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(117, 94);
      this.label2.TabIndex = 20;
      this.label2.Text = "대상파일 HASH";
      this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // textBox6
      // 
      this.textBox6.BackColor = System.Drawing.SystemColors.ControlLight;
      this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.textBox6.Location = new System.Drawing.Point(167, 176);
      this.textBox6.Multiline = true;
      this.textBox6.Name = "textBox6";
      this.textBox6.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.textBox6.Size = new System.Drawing.Size(946, 92);
      this.textBox6.TabIndex = 21;
      this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      // 
      // textBox7
      // 
      this.textBox7.BackColor = System.Drawing.SystemColors.ControlLight;
      this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.textBox7.Location = new System.Drawing.Point(167, 383);
      this.textBox7.Multiline = true;
      this.textBox7.Name = "textBox7";
      this.textBox7.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.textBox7.Size = new System.Drawing.Size(946, 92);
      this.textBox7.TabIndex = 22;
      this.textBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      // 
      // label3
      // 
      this.label3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
      this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
      this.label3.Location = new System.Drawing.Point(35, 383);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(117, 94);
      this.label3.TabIndex = 23;
      this.label3.Text = "원본파일 HASH";
      this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // label4
      // 
      this.label4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
      this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
      this.label4.Location = new System.Drawing.Point(35, 489);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(117, 94);
      this.label4.TabIndex = 24;
      this.label4.Text = "유지 LIST";
      this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // textBox8
      // 
      this.textBox8.BackColor = System.Drawing.SystemColors.ControlLight;
      this.textBox8.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.textBox8.Location = new System.Drawing.Point(165, 489);
      this.textBox8.Multiline = true;
      this.textBox8.Name = "textBox8";
      this.textBox8.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.textBox8.Size = new System.Drawing.Size(946, 92);
      this.textBox8.TabIndex = 25;
      this.textBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      // 
      // label5
      // 
      this.label5.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
      this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
      this.label5.Location = new System.Drawing.Point(35, 594);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(117, 94);
      this.label5.TabIndex = 26;
      this.label5.Text = "갱신 / 배포 LIST";
      this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // textBox9
      // 
      this.textBox9.BackColor = System.Drawing.SystemColors.ControlLight;
      this.textBox9.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.textBox9.Location = new System.Drawing.Point(158, 594);
      this.textBox9.Multiline = true;
      this.textBox9.Name = "textBox9";
      this.textBox9.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.textBox9.Size = new System.Drawing.Size(946, 94);
      this.textBox9.TabIndex = 27;
      this.textBox9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      // 
      // label6
      // 
      this.label6.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
      this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
      this.label6.Location = new System.Drawing.Point(35, 701);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(117, 94);
      this.label6.TabIndex = 28;
      this.label6.Text = "실행 결과";
      this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // textBox10
      // 
      this.textBox10.BackColor = System.Drawing.SystemColors.ControlLight;
      this.textBox10.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.textBox10.Location = new System.Drawing.Point(165, 701);
      this.textBox10.Multiline = true;
      this.textBox10.Name = "textBox10";
      this.textBox10.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.textBox10.Size = new System.Drawing.Size(946, 94);
      this.textBox10.TabIndex = 29;
      this.textBox10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      // 
      // button5
      // 
      this.button5.Location = new System.Drawing.Point(762, 805);
      this.button5.Name = "button5";
      this.button5.Size = new System.Drawing.Size(129, 39);
      this.button5.TabIndex = 30;
      this.button5.Text = "파일 배포";
      this.button5.UseVisualStyleBackColor = true;
      this.button5.Click += new System.EventHandler(this.button5_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1125, 856);
      this.Controls.Add(this.button5);
      this.Controls.Add(this.textBox10);
      this.Controls.Add(this.label6);
      this.Controls.Add(this.textBox9);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.textBox8);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.textBox7);
      this.Controls.Add(this.textBox6);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.textBox5);
      this.Controls.Add(this.label8);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.textBox4);
      this.Controls.Add(this.textBox3);
      this.Controls.Add(this.button4);
      this.Controls.Add(this.button3);
      this.Controls.Add(this.textBox2);
      this.Controls.Add(this.textBox1);
      this.Controls.Add(this.button2);
      this.Controls.Add(this.button1);
      this.Cursor = System.Windows.Forms.Cursors.Hand;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "Form1";
      this.Text = "파일 검색 / 파일 복사 / HASH 비교 프로그램 (만든이: 황인우)";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.TextBox textBox2;
    private System.Windows.Forms.Button button3;
    private System.Windows.Forms.Button button4;
    private System.Windows.Forms.TextBox textBox3;
    private System.Windows.Forms.TextBox textBox4;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.TextBox textBox5;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox textBox6;
    private System.Windows.Forms.TextBox textBox7;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.TextBox textBox8;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.TextBox textBox9;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.TextBox textBox10;
    private System.Windows.Forms.Button button5;
  }
}

