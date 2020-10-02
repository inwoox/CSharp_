using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToeGame
{
  public partial class Form1 : Form
  {
    Button[] btns;
    TicTacToe manager = new TicTacToe();

    public Form1()
    {
      InitializeComponent();
      btns = new Button[9] { btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8, btn9 };
      for (int i = 0; i < 9; i++)
      {
        btns[i].Tag = i;
      }
    }

    private void button_Click(object sender, EventArgs e)
    {
      GameRule(sender);
    }

    public void GameRule(object sender)
    {
      Button btn = sender as Button;
      if (btn.Text == "O" || btn.Text == "X")
      {
        Console.Beep(500, 200);
        return;
      }

      manager.Mark((int)btn.Tag);

      if (manager.Seq % 2 == 1)
      {
        btn.Text = "O";
        if (manager.WinnerCheck())
        {
          MessageBox.Show("1번 유저가 승리하였습니다.");
          Reset();
        }
      }
      else
      {
        btn.Text = "X";
        if (manager.WinnerCheck())
        {
          MessageBox.Show("2번 유저가 승리하였습니다.");
          Reset();
        }
      }

      if (manager.Seq == 9)
      {
        MessageBox.Show("무승부입니다.");
        Reset();
      }
    }

    void Reset()
    {
      manager = new TicTacToe();
      for (int i = 0; i < 9; i++)
      {
        btns[i].Text = null;
      }
    }

  }
}
