using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;                                     // 파일 IO
using System.Security.Cryptography;                  // SHA1
using System.Collections;                            // 해시 테이블
using System.Net;                                    // WebClient

namespace WindowsFormsApp2
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }


    private void button1_Click(object sender, EventArgs e)
    {
      Hello hello = new Hello();
      hello.DirectoryCall(textBox1.Text, textBox3.Text);                                      // 비교 대상 디렉토리
      hello.TextboxText1(textBox4);
      string fileh = string.Join(", ", hello.hashlist);                                       // 문자열 합치기
      fileh = fileh.Replace(",", Environment.NewLine);                                        // , 문자열일때 줄바꿈

      textBox6.Text = fileh;                                                                  // 비교대상 해시값
    }

    private void button2_Click_1(object sender, EventArgs e)
    {
      Hello hello = new Hello();
      hello.DirectoryCall1(textBox2.Text, textBox3.Text);                                     // 원본 디렉토리
      hello.TextboxText1(textBox5);
      string fileh = string.Join(", ", hello.hashlist1);                                      // 문자열 합치기
      fileh = fileh.Replace(",", Environment.NewLine);
      textBox7.Text = fileh;                                                                  // 원본해시값
    }

    public void button3_Click(object sender, EventArgs e)   // 원본해시값
    {
      Hello hello = new Hello();
      List<string> result1 = new List<string>();
      List<string> result2 = new List<string>();

      hello.DirectoryCall(textBox1.Text, textBox3.Text);
      hello.DirectoryCall1(textBox2.Text, textBox3.Text);


      // 원본 파일과 원본해시 딕셔너리에 추가
      int index = 0;
      foreach (string path1 in hello.pathlist1)                                               // 원본파일
      {
        string path11 = Path.GetFileName(path1);
        for (int i = 0; i < hello.hashlist1.Count; i++)                                       // 원본해시
        {
          if (!hello.hashDic1.ContainsKey(path11))
          {
            hello.hashDic1.Add(path11, hello.hashlist1[i + index]);                           // hashDic1 : 원본 파일 , 원본 해시 딕셔너리
            index++;
          }
        }
      }

      // 원본 파일과 원본 경로 딕셔너리에 추가
      index = 0;
      foreach (string path1 in hello.pathlist1)                         // 원본파일
      {
        string path11 = Path.GetFileName(path1);    
        for (int i = 0; i < hello.pathlist1.Count; i++)                 // 원본경로
        {
          if (!hello.hashDic3.ContainsKey(path11))
          {
            hello.hashDic3.Add(path11, hello.pathlist1[i + index]);      // hashDic3 : 원본 파일 , 원본 경로 딕셔너리
            index++;
          }
        }
      }


      // 대상 파일과 대상해시 딕셔너리에 추가
      index = 0;
      foreach (string path1 in hello.pathlist)                          // 대상파일
      {
        string path11 = Path.GetFileName(path1);

        for (int i = 0; i < hello.hashlist.Count; i++)                  // 대상해시
        {
          if (!hello.hashDic2.ContainsKey(path11))
          {
            hello.hashDic2.Add(path11, hello.hashlist[i + index]);      // hashDic2 : 대상 파일 , 대상 해시 딕셔너리
            index++;
          }
        }
      }

      // 대상 파일과 대상경로 딕셔너리에 추가
      index = 0;
      foreach (string path1 in hello.pathlist)                          // 대상파일
      {
        string path11 = Path.GetFileName(path1);

        for (int i = 0; i < hello.pathlist.Count; i++)                  // 대상경로
        {
          if (!hello.hashDic4.ContainsKey(path11))
          {
            hello.hashDic4.Add(path11, hello.pathlist[i + index]);      // hashDic4: 대상 파일 , 대상 경로 딕셔너리
            index++;
          }
        }
      }


      // 파일명이 일치하는지 아닌지 확인       // pathlist4에 있는 파일 : 생성 , pathlist5 : 덮어쓰기 

      foreach (string path1 in hello.pathlist1)                         // 원본파일
      {
        string path11 = Path.GetFileName(path1);

        foreach (string path2 in hello.pathlist)                        // 대상파일
        {
          string path22 = Path.GetFileName(path2);
          if (hello.pathlist3.Contains(path11)) { continue; }
          if (path11 == path22)                                         // 있는 파일일 경우 pathlist4에 추가
          {
            hello.pathlist3.Add(path11);
          }
        }
      }
      foreach (string path1 in hello.pathlist1)                         // 없는 파일일 경우 pathlist4에 추가
      {
        string path11 = Path.GetFileName(path1);
        if (!hello.pathlist3.Contains(path11))
        {
          hello.pathlist4.Add(path11);
          textBox9.Text += "배포가 필요한 파일명 : " + path11 + "   //   " + "원본 HASH 값 : " + hello.hashDic1.FirstOrDefault(x => x.Key == path11).Value + Environment.NewLine + "   //   " + "원본 경로 : " + path1 + Environment.NewLine + Environment.NewLine;
        }
      }


      // 있는 대상 파일의 해시가 원본 파일의 해시와 일치하는가

      foreach (string path in hello.pathlist3)
      {
        // 대상 파일 반복해서 가져오기

        string path_hash = hello.hashDic2.FirstOrDefault(x => x.Key == path).Value;   // 있는 파일 중 파일명에 맞는 대상 해시를 딕셔너리에서 가져옴
        string path_hash1 = hello.hashDic1.FirstOrDefault(x => x.Key == path).Value;  // 딕셔너리에서 원본 해시 가져옴
        string path_path = hello.hashDic3.FirstOrDefault(x => x.Key == path).Value;   // 딕셔너리에서 원본 경로 가져옴

        if (path_hash == path_hash1)                                            // 해시가 일치하는 파일일 경우 무시 (유지할 파일)
        {
          textBox8.Text += "유지할 파일명 : " + path + "   //   " + "원본 HASH 값 : " + path_hash1 + Environment.NewLine + "   //   " + "원본 경로 : " + path_path + Environment.NewLine + Environment.NewLine;
          continue;
        }
        else                                                                    // 해시가 일치하지 않는 파일은 pathlist5에 추가 (갱신할 파일)
        {
          hello.pathlist5.Add(path);
          textBox9.Text += "갱신할 파일명 : " + path + "   //   " + "원본 HASH 값 : " + path_hash1 + Environment.NewLine + "   //   " + "원본 경로 : " + path_path + Environment.NewLine + Environment.NewLine;
        }
      }
    }


    private void button4_Click(object sender, EventArgs e)
    {
      textBox4.Text = textBox5.Text = textBox6.Text = textBox7.Text = textBox8.Text = textBox9.Text = textBox10.Text = null;
    }

    private void button5_Click(object sender, EventArgs e)
    {
      Hello hello = new Hello();
      List<string> result1 = new List<string>();
      List<string> result2 = new List<string>();

      hello.DirectoryCall(textBox1.Text, textBox3.Text);
      hello.DirectoryCall1(textBox2.Text, textBox3.Text);

      int index = 0;
      foreach (string path1 in hello.pathlist1)                         // 원본파일
      {
        string path11 = Path.GetFileName(path1);
        for (int i = 0; i < hello.pathlist1.Count; i++)                 // 원본경로
        {
          if (!hello.hashDic3.ContainsKey(path11))
          {
            hello.hashDic3.Add(path11, hello.pathlist1[i + index]);      // hashDic3 : 원본 파일 , 원본 경로 딕셔너리 추가
            index++;
          }
        }
      }
      index = 0;
      foreach (string path1 in hello.pathlist)                          // 대상파일
      {
        string path11 = Path.GetFileName(path1);

        for (int i = 0; i < hello.pathlist.Count; i++)                  // 대상경로
        {
          if (!hello.hashDic4.ContainsKey(path11))
          {
            hello.hashDic4.Add(path11, hello.pathlist[i + index]);      // hashDic4: 대상 파일 , 대상 경로 딕셔너리 추가
            index++;
          }
        }
      }
      foreach (string path1 in hello.pathlist1)                         // 원본파일
      {
        string path11 = Path.GetFileName(path1);
        foreach (string path2 in hello.pathlist)                        // 대상파일
        {
          string path22 = Path.GetFileName(path2);
          if (hello.pathlist3.Contains(path11)) { continue; }           // 있는 파일일 경우 pathlist3에 추가
          if (path11 == path22){hello.pathlist3.Add(path11);}
        }
      }
      foreach (string path1 in hello.pathlist1)                         // 없는 파일일 경우 pathlist4에 추가
      {
        string path11 = Path.GetFileName(path1);
        if (!hello.pathlist3.Contains(path11))
        {hello.pathlist4.Add(path11);}
      }

      // 파일 생성하기

      if(hello.pathlist4.Count == 0)
      {
        textBox10.Text = "배포할 파일이 없습니다.";
      }

      foreach (string path in hello.pathlist4)     // 원본에 일치하는 대상 파일이 없는 경우 /  없는 원본 파일을 하나 가져온다
      {
        string path_1 = hello.hashDic3.FirstOrDefault(x => x.Key == path).Value;     // 없는 파일의 원본 파일 경로 가져오기


        Directory.CreateDirectory(@textBox1.Text);
        // File.Create(path_2);

        // FileInfo file1 = new FileInfo(path_1);
        // file1.CopyTo(@path_2, true);
        string path_2 = textBox1.Text + @"\" + path;

        File.Copy(@path_1, @path_2);
        textBox10.Text += textBox1.Text + "  경로에  " + path + "  파일이 추가되었습니다." + Environment.NewLine + Environment.NewLine;
      }
    }
  }

  class Hello
  {
    
    public string FilePrint = "";
    public string FileHash = "";
    public string FileHash3 = "";
    public int i = 0;

    public List<string> hashlist = new List<string>();
    public List<string> hashlist1 = new List<string>();
    public List<string> pathlist = new List<string>();      // 대상 패스
    public List<string> pathlist1 = new List<string>();     // 원본 패스
    public List<string> pathlist2 = new List<string>();     // 결과 패스
    public List<string> pathlist3 = new List<string>();
    public List<string> pathlist4 = new List<string>();
    public List<string> pathlist5 = new List<string>();

    public Dictionary<string, string> hashDic1 = new Dictionary<string, string>();   // 원본 파일과 원본 해시가 포함된 딕셔너리
    public Dictionary<string, string> hashDic2 = new Dictionary<string, string>();   // 대상 파일과 대상 해시가 포함된 딕셔너리
    public Dictionary<string, string> hashDic3 = new Dictionary<string, string>();   // 원본 파일과 원본 경로가 포함된 딕셔너리
    public Dictionary<string, string> hashDic4 = new Dictionary<string, string>();   // 대상 파일과 대상 경로가 포함된 딕셔너리

    public void DirectoryCall(string path, string file)
    {
      if (Directory.Exists(path))
      {
        string[] dirs = Directory.GetDirectories(path, $"*", SearchOption.AllDirectories);
        string[] files = Directory.GetFiles(path, $"*.{file}", SearchOption.AllDirectories);
        
        if(files != null)
        {
          foreach (string f in files)
          {
            FileInfo leftFileInfo = new System.IO.FileInfo(f);
            string file10 = Path.GetFileName(f);
            string file11 = Path.GetDirectoryName(f);
            FilePrint += "대상 파일명 : " + file10 + "   //   " + "파일 경로 : " + file11 + Environment.NewLine + Environment.NewLine;
            FileHash = leftFileInfo.ToString();
          }

          foreach (string f in files)                                                 // 파일 해시값
          {
            FileInfo leftFileInfo = new System.IO.FileInfo(f);
            FileHash3 = leftFileInfo.ToString();
            pathlist.Add(FileHash3);

            FileHash3 = GetChecksum(FileHash3);
            hashlist.Add(FileHash3);
            i++;
          }
        }
        
      }
    }

    public void DirectoryCall1(string path, string file)
    {
      if (Directory.Exists(path))
      {
        string[] dirs = Directory.GetDirectories(path, $"*",SearchOption.AllDirectories);
        string[] files = Directory.GetFiles(path, $"*.{file}", SearchOption.AllDirectories);

        if(files != null)
        {
          foreach (string f in files)
          {
            FileInfo leftFileInfo = new System.IO.FileInfo(f);
            string file12 = Path.GetFileName(f);
            string file13 = Path.GetDirectoryName(f);
            FilePrint += "원본 파일명: " + file12 + "   //   " + "파일 경로 : " + file13 + Environment.NewLine + Environment.NewLine;
            FileHash = leftFileInfo.ToString();
          }

          foreach (string f in files)                                                 // 파일 해시값
          {
            FileInfo leftFileInfo = new System.IO.FileInfo(f);
            FileHash3 = leftFileInfo.ToString();
            pathlist1.Add(FileHash3);
            FileHash3 = GetChecksum(FileHash3);
            hashlist1.Add(FileHash3);
            i++;
          }
        }
        
      }
    }

    public static string GetChecksum(string path)
    {
      if (!File.Exists(path))
        return null;

      using (FileStream stream = File.OpenRead(path))
      {
        SHA1 sha1 = new SHA1CryptoServiceProvider();     // MD5 sha1 = new MD5CryptoServiceProvider();
        byte[] byteChecksum = sha1.ComputeHash(stream);
        return BitConverter.ToString(byteChecksum).Replace("-", String.Empty);
      }
    }

    public void TextboxText1(object textbox)
    {
      TextBox textbox1 = textbox as TextBox;
      textbox1.Text = FilePrint;
    }
  }
}
