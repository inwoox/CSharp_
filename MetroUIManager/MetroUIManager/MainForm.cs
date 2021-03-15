using MetroFramework;
using MetroFramework.Controls;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace MetroUIManager
{
  public partial class MainForm : MetroForm
  {
    int count = 0;
    int timerFlag = 0;
    int newsFlag = 0;
    string arg = "";
    string filename = "";
    Timer timer = new Timer();

    public MainForm()
    {
      InitializeComponent();
      this.StyleManager = metroStyleManager1;
    }

    private void MainForm_Load(object sender, EventArgs e)
    {
      /*_instance = this;*/
      metroPanel1.Hide();

      mcbTheme.SelectedIndex = 0;
      mcbColor.SelectedIndex = 7;
      mcbFont.SelectedIndex = 0;

      // 이 옵션들이 없으면 컬러를 변경할 수 없다.
      mtTimer.UseCustomForeColor = true;
      mtTaskMgr.UseCustomForeColor = true;
      mtNews.UseCustomForeColor = true;
      mtNetPath1.UseCustomForeColor = true;
      mtNetPath2.UseCustomForeColor = true;
      mtPath1.UseCustomForeColor = true;
      mtPath2.UseCustomForeColor = true;
      mtPath3.UseCustomForeColor = true;
      mtPath4.UseCustomForeColor = true;
    }

    // 뉴스 타일 클릭 
    private void mtNews_Click(object sender, EventArgs e)
    {
      if (newsFlag == 0)
      {
        ucBoard board = new ucBoard();
        board.Dock = DockStyle.Fill;
        metroPanel1.Show();
        metroPanel1.Controls.Add(board);
        newsFlag = 1;
      }
      else
      {
        metroPanel1.Hide();
        newsFlag = 0;
      }
    }

    // 타이머 타일 클릭
    private void mtTimer_Click(object sender, EventArgs e)
    {
      if (timerFlag == 0)  // 시작 
      {
        mtTimer.UseTileImage = false;   
        timerFlag = 1;
        timer.Interval = 1000; 
        timer.Tick += new EventHandler(timer_Tick);
        timer.Start();
      }
      else
      {
        mtTimer.UseTileImage = true;    
        timerFlag = 0;
        count = 0;
        timer.Tick -= timer_Tick;
        timer.Stop();
        mtTimer.TextAlign = ContentAlignment.BottomLeft;
        mtTimer.TileTextFontSize = MetroFramework.MetroTileTextSize.Medium;
        mtTimer.Text = "Rest Timer";
        mtTimer.UseCustomBackColor = false;
      }
    }

    void timer_Tick(object sender, EventArgs e)
    {
      count++;
      if (count == 1)
      {
        mtTimer.UseCustomBackColor = true;  // 이 설정이 없으면, 커스텀으로 컬러를 변경할 수 없다.
        mtTimer.BackColor = Color.Pink;
        mtTimer.TextAlign = ContentAlignment.MiddleCenter;
        mtTimer.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
      }
      if (count > 59)
      {
        int minute = count / 60;
        int second = count - (minute * 60);
        mtTimer.Text = DateTime.Now.ToLongTimeString() + "\r\n" + $"{minute}분 {second}초 경과";
      }
      else
      {
        mtTimer.Text = DateTime.Now.ToLongTimeString() + "\r\n" + count + "초 경과";
      }

      if (count > 20)   // 타일 색 깜빡임
      {
        if (count % 2 == 0)
        {
          mtTimer.BackColor = Color.DeepPink;
        }
        else
        {
          mtTimer.BackColor = Color.Pink;
        }
      }
      if (count > 30)
      {
        Console.Beep();

        mtTimer.UseTileImage = true;    // 타일 이미지 보이기 
        timerFlag = 0;
        count = 0;
        timer.Tick -= timer_Tick;
        timer.Stop();
        mtTimer.TextAlign = ContentAlignment.BottomLeft;
        mtTimer.TileTextFontSize = MetroFramework.MetroTileTextSize.Medium;
        mtTimer.Text = "Rest Timer";
        mtTimer.UseCustomBackColor = false;
      }
    }

    // 기타 기능 타일 클릭
    private void mtNetPath_Click(object sender, EventArgs e)
    {
      if (((MetroTile)sender).Name == "mtNetPath1")
      {
        arg = "http://www.google.co.kr";
      }
      else
      {
        arg = "http://www.naver.com";
      }

      using (Process myProcess = new Process())
      {
        myProcess.StartInfo.UseShellExecute = false;
        myProcess.StartInfo.FileName = @"C:\Program Files\Google\Chrome\Application\chrome.exe";
        myProcess.StartInfo.Arguments = arg;
        myProcess.Start();
      }
    }

    private void mtExe_Click(object sender, EventArgs e)
    {
      if (((MetroTile)sender).Name == "mtPath1")
      {
        filename = "notepad.exe";
      }
      else if (((MetroTile)sender).Name == "mtPath2")
      {
        filename = "calc.exe";
      }

      using (Process myProcess = new Process())
      {
        myProcess.StartInfo.UseShellExecute = false;
        myProcess.StartInfo.FileName = filename;
        myProcess.Start();
      }
    }

    private void mtPath_Click(object sender, EventArgs e)
    {
      if (((MetroTile)sender).Name == "mtPath3")
      {
        filename = @"\\Mac\Home\Downloads";
      }
      else
      {
        filename = @"\\Mac\Home\Desktop";
      }

      using (Process myProcess = new Process())
      {
        myProcess.StartInfo.FileName = filename;
        myProcess.Start();
      }
    }

    private void mtTaskMgr_Click(object sender, EventArgs e)
    {
      SendKeys.Send("^+{ESC}");
    }

    // metrostylemanager 컨트롤을 폼에 추가하고, 이 컨트롤의 Owner를 MainForm으로 설정 후, 콤보 박스에 선택할 항목들 추가, 아래와 같이 작성
    private void mcbTheme_SelectedIndexChanged(object sender, EventArgs e)
    {
      switch (mcbTheme.SelectedIndex)
      {
        case 0:
          StyleManager.Theme = MetroThemeStyle.Dark;
          break;
        case 1:
          StyleManager.Theme = MetroThemeStyle.Light;
          break;
      }
    }

    private void mcbColor_SelectedIndexChanged(object sender, EventArgs e)
    {
      metroStyleManager1.Style = (MetroFramework.MetroColorStyle)Convert.ToInt32(mcbColor.SelectedIndex);
    }

    private void mcbFont_SelectedIndexChanged(object sender, EventArgs e)
    {
      ArrayList tiles = new ArrayList();
      tiles.Add(mtNetPath1);
      tiles.Add(mtNetPath2);
      tiles.Add(mtPath1);
      tiles.Add(mtPath2);
      tiles.Add(mtPath3);
      tiles.Add(mtPath4);
      tiles.Add(mtNews);
      tiles.Add(mtTimer);
      tiles.Add(mtTaskMgr);

      switch (mcbFont.SelectedIndex)
      {
        case 0:
          foreach(MetroTile tile in tiles)
          {
            tile.ForeColor = Color.Black;
          }
          break;
        case 1:
          foreach (MetroTile tile in tiles)
          {
            tile.ForeColor = Color.White;
          }
          break;
        case 2:
          foreach (MetroTile tile in tiles)
          {
            tile.ForeColor = Color.Blue;
          }
          break;
        case 3:
          foreach (MetroTile tile in tiles)
          {
            tile.ForeColor = Color.Purple;
          }
          break;
        case 4:
          foreach (MetroTile tile in tiles)
          {
            tile.ForeColor = Color.Red;
          }
          break;
      }
    }

    // 폼을 닫을 때 할 행위
    private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
    {
      Process[] procs = Process.GetProcessesByName("chromedriver");
      foreach(Process proc in procs)
      {
        proc.Kill();
      }
    }
  }
}
