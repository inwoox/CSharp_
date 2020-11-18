namespace MetroUIManager
{
  partial class MainForm
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
      this.components = new System.ComponentModel.Container();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
      this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
      this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
      this.mcbTheme = new MetroFramework.Controls.MetroComboBox();
      this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
      this.mcbColor = new MetroFramework.Controls.MetroComboBox();
      this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
      this.mtNews = new MetroFramework.Controls.MetroTile();
      this.mtTimer = new MetroFramework.Controls.MetroTile();
      this.mtPath4 = new MetroFramework.Controls.MetroTile();
      this.mtPath1 = new MetroFramework.Controls.MetroTile();
      this.mtNetPath2 = new MetroFramework.Controls.MetroTile();
      this.mtPath3 = new MetroFramework.Controls.MetroTile();
      this.mtPath2 = new MetroFramework.Controls.MetroTile();
      this.mtNetPath1 = new MetroFramework.Controls.MetroTile();
      this.mtTaskMgr = new MetroFramework.Controls.MetroTile();
      this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
      this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
      this.mcbFont = new MetroFramework.Controls.MetroComboBox();
      ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
      this.SuspendLayout();
      // 
      // metroLabel1
      // 
      this.metroLabel1.AutoSize = true;
      this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
      this.metroLabel1.Location = new System.Drawing.Point(557, 44);
      this.metroLabel1.Name = "metroLabel1";
      this.metroLabel1.Size = new System.Drawing.Size(80, 25);
      this.metroLabel1.TabIndex = 2;
      this.metroLabel1.Text = "THEME  :";
      // 
      // mcbTheme
      // 
      this.mcbTheme.FormattingEnabled = true;
      this.mcbTheme.ItemHeight = 23;
      this.mcbTheme.Items.AddRange(new object[] {
            "Dark",
            "Light"});
      this.mcbTheme.Location = new System.Drawing.Point(653, 44);
      this.mcbTheme.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.mcbTheme.Name = "mcbTheme";
      this.mcbTheme.Size = new System.Drawing.Size(121, 29);
      this.mcbTheme.TabIndex = 3;
      this.mcbTheme.UseSelectable = true;
      this.mcbTheme.SelectedIndexChanged += new System.EventHandler(this.mcbTheme_SelectedIndexChanged);
      // 
      // metroLabel2
      // 
      this.metroLabel2.AutoSize = true;
      this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
      this.metroLabel2.Location = new System.Drawing.Point(557, 82);
      this.metroLabel2.Name = "metroLabel2";
      this.metroLabel2.Size = new System.Drawing.Size(77, 25);
      this.metroLabel2.TabIndex = 4;
      this.metroLabel2.Text = "COLOR :";
      // 
      // mcbColor
      // 
      this.mcbColor.FormattingEnabled = true;
      this.mcbColor.ItemHeight = 23;
      this.mcbColor.Items.AddRange(new object[] {
            "Default",
            "Black",
            "White",
            "Silver",
            "Blue",
            "Green",
            "Lime",
            "Teal",
            "Orange",
            "Brown",
            "Pink",
            "Magenta",
            "Purple",
            "Red"});
      this.mcbColor.Location = new System.Drawing.Point(653, 82);
      this.mcbColor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.mcbColor.Name = "mcbColor";
      this.mcbColor.Size = new System.Drawing.Size(121, 29);
      this.mcbColor.TabIndex = 5;
      this.mcbColor.UseSelectable = true;
      this.mcbColor.SelectedIndexChanged += new System.EventHandler(this.mcbColor_SelectedIndexChanged);
      // 
      // metroStyleManager1
      // 
      this.metroStyleManager1.Owner = this;
      this.metroStyleManager1.Style = MetroFramework.MetroColorStyle.Teal;
      // 
      // mtNews
      // 
      this.mtNews.ActiveControl = null;
      this.mtNews.BackColor = System.Drawing.Color.DeepSkyBlue;
      this.mtNews.Location = new System.Drawing.Point(23, 364);
      this.mtNews.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.mtNews.Name = "mtNews";
      this.mtNews.Size = new System.Drawing.Size(174, 179);
      this.mtNews.TabIndex = 6;
      this.mtNews.Text = "News Crawler";
      this.mtNews.TileImage = ((System.Drawing.Image)(resources.GetObject("mtNews.TileImage")));
      this.mtNews.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
      this.mtNews.UseSelectable = true;
      this.mtNews.UseTileImage = true;
      this.mtNews.Click += new System.EventHandler(this.mtNews_Click);
      // 
      // mtTimer
      // 
      this.mtTimer.ActiveControl = null;
      this.mtTimer.BackColor = System.Drawing.Color.DeepSkyBlue;
      this.mtTimer.Location = new System.Drawing.Point(23, 155);
      this.mtTimer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.mtTimer.Name = "mtTimer";
      this.mtTimer.Size = new System.Drawing.Size(174, 179);
      this.mtTimer.TabIndex = 7;
      this.mtTimer.Text = "Rest Timer";
      this.mtTimer.TileImage = ((System.Drawing.Image)(resources.GetObject("mtTimer.TileImage")));
      this.mtTimer.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
      this.mtTimer.UseSelectable = true;
      this.mtTimer.UseTileImage = true;
      this.mtTimer.Click += new System.EventHandler(this.mtTimer_Click);
      // 
      // mtPath4
      // 
      this.mtPath4.ActiveControl = null;
      this.mtPath4.BackColor = System.Drawing.Color.DeepSkyBlue;
      this.mtPath4.Location = new System.Drawing.Point(276, 446);
      this.mtPath4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.mtPath4.Name = "mtPath4";
      this.mtPath4.Size = new System.Drawing.Size(106, 99);
      this.mtPath4.TabIndex = 8;
      this.mtPath4.Text = "Local";
      this.mtPath4.TileImage = ((System.Drawing.Image)(resources.GetObject("mtPath4.TileImage")));
      this.mtPath4.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
      this.mtPath4.UseSelectable = true;
      this.mtPath4.UseTileImage = true;
      this.mtPath4.Click += new System.EventHandler(this.mtPath_Click);
      // 
      // mtPath1
      // 
      this.mtPath1.ActiveControl = null;
      this.mtPath1.BackColor = System.Drawing.Color.DeepSkyBlue;
      this.mtPath1.Location = new System.Drawing.Point(530, 301);
      this.mtPath1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.mtPath1.Name = "mtPath1";
      this.mtPath1.Size = new System.Drawing.Size(107, 99);
      this.mtPath1.TabIndex = 9;
      this.mtPath1.Text = "NotePad";
      this.mtPath1.TileImage = ((System.Drawing.Image)(resources.GetObject("mtPath1.TileImage")));
      this.mtPath1.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
      this.mtPath1.UseSelectable = true;
      this.mtPath1.UseTileImage = true;
      this.mtPath1.Click += new System.EventHandler(this.mtExe_Click);
      // 
      // mtNetPath2
      // 
      this.mtNetPath2.ActiveControl = null;
      this.mtNetPath2.BackColor = System.Drawing.Color.DeepSkyBlue;
      this.mtNetPath2.Location = new System.Drawing.Point(661, 180);
      this.mtNetPath2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.mtNetPath2.Name = "mtNetPath2";
      this.mtNetPath2.Size = new System.Drawing.Size(106, 99);
      this.mtNetPath2.TabIndex = 10;
      this.mtNetPath2.Text = "Naver";
      this.mtNetPath2.TileImage = ((System.Drawing.Image)(resources.GetObject("mtNetPath2.TileImage")));
      this.mtNetPath2.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
      this.mtNetPath2.UseSelectable = true;
      this.mtNetPath2.UseTileImage = true;
      this.mtNetPath2.Click += new System.EventHandler(this.mtNetPath_Click);
      // 
      // mtPath3
      // 
      this.mtPath3.ActiveControl = null;
      this.mtPath3.BackColor = System.Drawing.Color.DeepSkyBlue;
      this.mtPath3.Location = new System.Drawing.Point(276, 339);
      this.mtPath3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.mtPath3.Name = "mtPath3";
      this.mtPath3.Size = new System.Drawing.Size(107, 99);
      this.mtPath3.TabIndex = 11;
      this.mtPath3.Text = "Download";
      this.mtPath3.TileImage = ((System.Drawing.Image)(resources.GetObject("mtPath3.TileImage")));
      this.mtPath3.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
      this.mtPath3.UseSelectable = true;
      this.mtPath3.UseTileImage = true;
      this.mtPath3.Click += new System.EventHandler(this.mtPath_Click);
      // 
      // mtPath2
      // 
      this.mtPath2.ActiveControl = null;
      this.mtPath2.BackColor = System.Drawing.Color.DeepSkyBlue;
      this.mtPath2.Location = new System.Drawing.Point(661, 301);
      this.mtPath2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.mtPath2.Name = "mtPath2";
      this.mtPath2.Size = new System.Drawing.Size(106, 99);
      this.mtPath2.TabIndex = 12;
      this.mtPath2.Text = "Calc";
      this.mtPath2.TileImage = ((System.Drawing.Image)(resources.GetObject("mtPath2.TileImage")));
      this.mtPath2.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
      this.mtPath2.UseSelectable = true;
      this.mtPath2.UseTileImage = true;
      this.mtPath2.Click += new System.EventHandler(this.mtExe_Click);
      // 
      // mtNetPath1
      // 
      this.mtNetPath1.ActiveControl = null;
      this.mtNetPath1.BackColor = System.Drawing.Color.DeepSkyBlue;
      this.mtNetPath1.Location = new System.Drawing.Point(530, 180);
      this.mtNetPath1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.mtNetPath1.Name = "mtNetPath1";
      this.mtNetPath1.Size = new System.Drawing.Size(107, 99);
      this.mtNetPath1.TabIndex = 13;
      this.mtNetPath1.Text = "Google";
      this.mtNetPath1.TileImage = ((System.Drawing.Image)(resources.GetObject("mtNetPath1.TileImage")));
      this.mtNetPath1.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
      this.mtNetPath1.UseSelectable = true;
      this.mtNetPath1.UseTileImage = true;
      this.mtNetPath1.Click += new System.EventHandler(this.mtNetPath_Click);
      // 
      // mtTaskMgr
      // 
      this.mtTaskMgr.ActiveControl = null;
      this.mtTaskMgr.BackColor = System.Drawing.Color.DeepSkyBlue;
      this.mtTaskMgr.Location = new System.Drawing.Point(388, 446);
      this.mtTaskMgr.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.mtTaskMgr.Name = "mtTaskMgr";
      this.mtTaskMgr.Size = new System.Drawing.Size(107, 99);
      this.mtTaskMgr.TabIndex = 11;
      this.mtTaskMgr.Text = "TaskManager";
      this.mtTaskMgr.TileImage = ((System.Drawing.Image)(resources.GetObject("mtTaskMgr.TileImage")));
      this.mtTaskMgr.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
      this.mtTaskMgr.UseSelectable = true;
      this.mtTaskMgr.UseTileImage = true;
      this.mtTaskMgr.Click += new System.EventHandler(this.mtTaskMgr_Click);
      // 
      // metroPanel1
      // 
      this.metroPanel1.BackColor = System.Drawing.Color.Black;
      this.metroPanel1.HorizontalScrollbarBarColor = true;
      this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
      this.metroPanel1.HorizontalScrollbarSize = 10;
      this.metroPanel1.Location = new System.Drawing.Point(223, 155);
      this.metroPanel1.Name = "metroPanel1";
      this.metroPanel1.Size = new System.Drawing.Size(580, 460);
      this.metroPanel1.TabIndex = 14;
      this.metroPanel1.TabStop = true;
      this.metroPanel1.VerticalScrollbarBarColor = true;
      this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
      this.metroPanel1.VerticalScrollbarSize = 10;
      // 
      // metroLabel3
      // 
      this.metroLabel3.AutoSize = true;
      this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
      this.metroLabel3.Location = new System.Drawing.Point(557, 119);
      this.metroLabel3.Name = "metroLabel3";
      this.metroLabel3.Size = new System.Drawing.Size(65, 25);
      this.metroLabel3.TabIndex = 15;
      this.metroLabel3.Text = "FONT :";
      // 
      // mcbFont
      // 
      this.mcbFont.FormattingEnabled = true;
      this.mcbFont.ItemHeight = 23;
      this.mcbFont.Items.AddRange(new object[] {
            "Black",
            "White",
            "Blue",
            "Purple",
            "Red"});
      this.mcbFont.Location = new System.Drawing.Point(653, 119);
      this.mcbFont.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.mcbFont.Name = "mcbFont";
      this.mcbFont.Size = new System.Drawing.Size(121, 29);
      this.mcbFont.TabIndex = 16;
      this.mcbFont.UseSelectable = true;
      this.mcbFont.SelectedIndexChanged += new System.EventHandler(this.mcbFont_SelectedIndexChanged);
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(826, 628);
      this.Controls.Add(this.mcbFont);
      this.Controls.Add(this.metroLabel3);
      this.Controls.Add(this.metroPanel1);
      this.Controls.Add(this.mtNews);
      this.Controls.Add(this.mtTimer);
      this.Controls.Add(this.mtPath4);
      this.Controls.Add(this.mtPath1);
      this.Controls.Add(this.mtNetPath2);
      this.Controls.Add(this.mtTaskMgr);
      this.Controls.Add(this.mtPath3);
      this.Controls.Add(this.mtPath2);
      this.Controls.Add(this.mtNetPath1);
      this.Controls.Add(this.mcbColor);
      this.Controls.Add(this.metroLabel2);
      this.Controls.Add(this.mcbTheme);
      this.Controls.Add(this.metroLabel1);
      this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.Name = "MainForm";
      this.Padding = new System.Windows.Forms.Padding(20, 75, 20, 25);
      this.Text = "TaskManagement";
      this.Theme = MetroFramework.MetroThemeStyle.Default;
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
      this.Load += new System.EventHandler(this.MainForm_Load);
      ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.ComponentModel.BackgroundWorker backgroundWorker1;
    private MetroFramework.Controls.MetroLabel metroLabel1;
    private MetroFramework.Controls.MetroComboBox mcbTheme;
    private MetroFramework.Controls.MetroLabel metroLabel2;
    private MetroFramework.Controls.MetroComboBox mcbColor;
    private MetroFramework.Components.MetroStyleManager metroStyleManager1;
    private MetroFramework.Controls.MetroTile mtNews;
    private MetroFramework.Controls.MetroTile mtTimer;
    private MetroFramework.Controls.MetroTile mtPath4;
    private MetroFramework.Controls.MetroTile mtPath1;
    private MetroFramework.Controls.MetroTile mtNetPath2;
    private MetroFramework.Controls.MetroTile mtPath3;
    private MetroFramework.Controls.MetroTile mtPath2;
    private MetroFramework.Controls.MetroTile mtNetPath1;
    private MetroFramework.Controls.MetroTile mtTaskMgr;
    private MetroFramework.Controls.MetroPanel metroPanel1;
    private MetroFramework.Controls.MetroComboBox mcbFont;
    private MetroFramework.Controls.MetroLabel metroLabel3;
  }
}

