namespace TicTacToeGame
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
      this.btn1 = new System.Windows.Forms.Button();
      this.btn4 = new System.Windows.Forms.Button();
      this.btn5 = new System.Windows.Forms.Button();
      this.btn6 = new System.Windows.Forms.Button();
      this.btn7 = new System.Windows.Forms.Button();
      this.btn8 = new System.Windows.Forms.Button();
      this.btn9 = new System.Windows.Forms.Button();
      this.btn3 = new System.Windows.Forms.Button();
      this.btn2 = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // btn1
      // 
      this.btn1.Font = new System.Drawing.Font("굴림", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.btn1.Location = new System.Drawing.Point(26, 24);
      this.btn1.Name = "btn1";
      this.btn1.Size = new System.Drawing.Size(190, 156);
      this.btn1.TabIndex = 0;
      this.btn1.UseVisualStyleBackColor = true;
      this.btn1.Click += new System.EventHandler(this.button_Click);
      // 
      // btn4
      // 
      this.btn4.Font = new System.Drawing.Font("굴림", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.btn4.Location = new System.Drawing.Point(26, 199);
      this.btn4.Name = "btn4";
      this.btn4.Size = new System.Drawing.Size(190, 156);
      this.btn4.TabIndex = 3;
      this.btn4.UseVisualStyleBackColor = true;
      this.btn4.Click += new System.EventHandler(this.button_Click);
      // 
      // btn5
      // 
      this.btn5.Font = new System.Drawing.Font("굴림", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.btn5.Location = new System.Drawing.Point(288, 199);
      this.btn5.Name = "btn5";
      this.btn5.Size = new System.Drawing.Size(190, 156);
      this.btn5.TabIndex = 4;
      this.btn5.UseVisualStyleBackColor = true;
      this.btn5.Click += new System.EventHandler(this.button_Click);
      // 
      // btn6
      // 
      this.btn6.Font = new System.Drawing.Font("굴림", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.btn6.Location = new System.Drawing.Point(549, 199);
      this.btn6.Name = "btn6";
      this.btn6.Size = new System.Drawing.Size(190, 156);
      this.btn6.TabIndex = 5;
      this.btn6.UseVisualStyleBackColor = true;
      this.btn6.Click += new System.EventHandler(this.button_Click);
      // 
      // btn7
      // 
      this.btn7.Font = new System.Drawing.Font("굴림", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.btn7.Location = new System.Drawing.Point(26, 373);
      this.btn7.Name = "btn7";
      this.btn7.Size = new System.Drawing.Size(190, 156);
      this.btn7.TabIndex = 6;
      this.btn7.UseVisualStyleBackColor = true;
      this.btn7.Click += new System.EventHandler(this.button_Click);
      // 
      // btn8
      // 
      this.btn8.Font = new System.Drawing.Font("굴림", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.btn8.Location = new System.Drawing.Point(288, 373);
      this.btn8.Name = "btn8";
      this.btn8.Size = new System.Drawing.Size(190, 156);
      this.btn8.TabIndex = 7;
      this.btn8.UseVisualStyleBackColor = true;
      this.btn8.Click += new System.EventHandler(this.button_Click);
      // 
      // btn9
      // 
      this.btn9.Font = new System.Drawing.Font("굴림", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.btn9.Location = new System.Drawing.Point(549, 373);
      this.btn9.Name = "btn9";
      this.btn9.Size = new System.Drawing.Size(190, 156);
      this.btn9.TabIndex = 8;
      this.btn9.UseVisualStyleBackColor = true;
      this.btn9.Click += new System.EventHandler(this.button_Click);
      // 
      // btn3
      // 
      this.btn3.Font = new System.Drawing.Font("굴림", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.btn3.Location = new System.Drawing.Point(549, 24);
      this.btn3.Name = "btn3";
      this.btn3.Size = new System.Drawing.Size(190, 156);
      this.btn3.TabIndex = 2;
      this.btn3.UseVisualStyleBackColor = true;
      this.btn3.Click += new System.EventHandler(this.button_Click);
      // 
      // btn2
      // 
      this.btn2.Font = new System.Drawing.Font("굴림", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.btn2.Location = new System.Drawing.Point(288, 24);
      this.btn2.Name = "btn2";
      this.btn2.Size = new System.Drawing.Size(190, 156);
      this.btn2.TabIndex = 1;
      this.btn2.UseVisualStyleBackColor = true;
      this.btn2.Click += new System.EventHandler(this.button_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(763, 555);
      this.Controls.Add(this.btn9);
      this.Controls.Add(this.btn8);
      this.Controls.Add(this.btn7);
      this.Controls.Add(this.btn6);
      this.Controls.Add(this.btn5);
      this.Controls.Add(this.btn4);
      this.Controls.Add(this.btn3);
      this.Controls.Add(this.btn2);
      this.Controls.Add(this.btn1);
      this.Name = "Form1";
      this.Text = "Form1";
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button btn1;
    private System.Windows.Forms.Button btn4;
    private System.Windows.Forms.Button btn5;
    private System.Windows.Forms.Button btn6;
    private System.Windows.Forms.Button btn7;
    private System.Windows.Forms.Button btn8;
    private System.Windows.Forms.Button btn9;
    private System.Windows.Forms.Button btn3;
    private System.Windows.Forms.Button btn2;
  }
}

