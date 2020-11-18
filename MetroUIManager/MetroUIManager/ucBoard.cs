using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;
using MetroFramework.Controls;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Collections;

namespace MetroUIManager
{
  public partial class ucBoard : MetroFramework.Controls.MetroUserControl
  {
    ChromeDriverService service;
    ChromeOptions options;
    IWebDriver driver;
    IWebDriver driver1;
    ArrayList links;
    ArrayList aticles;
    string categoryName;

    public ucBoard()
    {
      InitializeComponent();
      pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

      // chromedriver.exe, 실행파일 경로에 위치
      // 또는 CreateDefaultService(@"\\Mac\Home\Desktop") 처럼 별도 경로에 위치.
      service = ChromeDriverService.CreateDefaultService();
      options = new ChromeOptions();

      options.AddArguments("headless");
      service.HideCommandPromptWindow = true;
    }

    // 헤드라인 뉴스 카테고리 선택
    private void mtHead_Click(object sender, EventArgs e)
    {
      
      using (driver = new ChromeDriver(service, options))
      {
        links = new ArrayList();     // 카테고리 이동을 위해 링크와 뉴스 본문을 리셋. 
        aticles = new ArrayList();
        driver.Url = "https://news.naver.com/";

        // 헤드라인 사진 / 기사 이름
        mtNews1.Visible = true;
        pictureBox1.Visible = true;
        pictureBox1.ImageLocation = driver.FindElement(By.XPath("//*[@id=\"today_main_news\"]/div[2]/div/div[1]/a[1]/img")).GetAttribute("src");
        mtNews1.Text = driver.FindElement(By.XPath("//*[@id=\"today_main_news\"]/div[2]/div/div[1]/a[1]/img")).GetAttribute("alt").ToString();
        links.Add(driver.FindElement(By.XPath("//*[@id=\"today_main_news\"]/div[2]/div/div[1]/a[1]")).GetAttribute("href").ToString());

        // 그외 기사 이름 
        mtNews2.Visible = true;
        mtNews3.Visible = true;
        mtNews4.Visible = true;
        mtNews5.Visible = true;
        mtNews6.Visible = true;

        mtNews2.Text = driver.FindElement(By.XPath("//*[@id=\"today_main_news\"]/div[2]/ul/li[1]/div[1]/a")).Text;
        mtNews3.Text = driver.FindElement(By.XPath("//*[@id=\"today_main_news\"]/div[2]/ul/li[2]/div[1]/a")).Text;
        mtNews4.Text = driver.FindElement(By.XPath("//*[@id=\"today_main_news\"]/div[2]/ul/li[3]/div[1]/a")).Text;
        mtNews5.Text = driver.FindElement(By.XPath("//*[@id=\"today_main_news\"]/div[2]/ul/li[4]/div[1]/a")).Text;
        mtNews6.Text = driver.FindElement(By.XPath("//*[@id=\"today_main_news\"]/div[2]/ul/li[5]/div[1]/a")).Text;

        // 각 기사들 링크 저장
        links.Add(driver.FindElement(By.XPath("//*[@id=\"today_main_news\"]/div[2]/ul/li[1]/div[1]/a")).GetAttribute("href").ToString());
        links.Add(driver.FindElement(By.XPath("//*[@id=\"today_main_news\"]/div[2]/ul/li[2]/div[1]/a")).GetAttribute("href").ToString());
        links.Add(driver.FindElement(By.XPath("//*[@id=\"today_main_news\"]/div[2]/ul/li[3]/div[1]/a")).GetAttribute("href").ToString());
        links.Add(driver.FindElement(By.XPath("//*[@id=\"today_main_news\"]/div[2]/ul/li[4]/div[1]/a")).GetAttribute("href").ToString());
        links.Add(driver.FindElement(By.XPath("//*[@id=\"today_main_news\"]/div[2]/ul/li[5]/div[1]/a")).GetAttribute("href").ToString());


        // 기사 본문 미리 보기
        driver.Url = "https://news.naver.com/";
        driver.Url = driver.FindElement(By.XPath("//*[@id=\"today_main_news\"]/div[2]/div/div[1]/a[1]")).GetAttribute("href").ToString();
        aticles.Add(driver.FindElement(By.XPath("//*[@id=\"articleBodyContents\"]")).Text);
        driver.Url = "https://news.naver.com/";
        driver.Url = driver.FindElement(By.XPath("//*[@id=\"today_main_news\"]/div[2]/ul/li[1]/div[1]/a")).GetAttribute("href").ToString();
        aticles.Add(driver.FindElement(By.XPath("//*[@id=\"articleBodyContents\"]")).Text);
        driver.Url = "https://news.naver.com/";
        driver.Url = driver.FindElement(By.XPath("//*[@id=\"today_main_news\"]/div[2]/ul/li[2]/div[1]/a")).GetAttribute("href").ToString();
        aticles.Add(driver.FindElement(By.XPath("//*[@id=\"articleBodyContents\"]")).Text);
        driver.Url = "https://news.naver.com/";
        driver.Url = driver.FindElement(By.XPath("//*[@id=\"today_main_news\"]/div[2]/ul/li[3]/div[1]/a")).GetAttribute("href").ToString();
        aticles.Add(driver.FindElement(By.XPath("//*[@id=\"articleBodyContents\"]")).Text);
        driver.Url = "https://news.naver.com/";
        driver.Url = driver.FindElement(By.XPath("//*[@id=\"today_main_news\"]/div[2]/ul/li[4]/div[1]/a")).GetAttribute("href").ToString();
        aticles.Add(driver.FindElement(By.XPath("//*[@id=\"articleBodyContents\"]")).Text);
        driver.Url = "https://news.naver.com/";
        driver.Url = driver.FindElement(By.XPath("//*[@id=\"today_main_news\"]/div[2]/ul/li[5]/div[1]/a")).GetAttribute("href").ToString();
        aticles.Add(driver.FindElement(By.XPath("//*[@id=\"articleBodyContents\"]")).Text);

        for (int i = 0; i < 6; i++)
        {
          aticles[i] = aticles[i].ToString().Replace(".", "\r\n").Trim();
        }

        metroToolTip1.SetToolTip(mtNews1, aticles[0].ToString());
        metroToolTip1.SetToolTip(mtNews2, aticles[1].ToString());
        metroToolTip1.SetToolTip(mtNews3, aticles[2].ToString());
        metroToolTip1.SetToolTip(mtNews4, aticles[3].ToString());
        metroToolTip1.SetToolTip(mtNews5, aticles[4].ToString());
        metroToolTip1.SetToolTip(mtNews6, aticles[5].ToString());

      }
    }

    // 그외 뉴스 카테고리 선택
    private void mtAticle_Click(object sender, EventArgs e)
    {
      try
      {
        switch (((MetroTile)sender).Name)
        {
          case "mtPol":
            categoryName = "section_politics";
            break;
          case "mtEco":
            categoryName = "section_economy";
            break;
          case "mtSoc":
            categoryName = "section_society";
            break;
          case "mtLife":
            categoryName = "section_life";
            break;
          case "mtGlo":
            categoryName = "section_world";
            break;
          case "mtIt":
            categoryName = "section_it";
            break;
        }

        using (driver = new ChromeDriver(service, options))
        {
          links = new ArrayList();
          aticles = new ArrayList();
          driver.Url = "https://news.naver.com/";

          // 헤드라인 사진 / 기사 이름
          mtNews1.Visible = true;
          pictureBox1.Visible = true;
          pictureBox1.ImageLocation = driver.FindElement(By.XPath("//*[@id=\"" + categoryName + "\"]/div[2]/dl/dt/a/img")).GetAttribute("src");
          mtNews1.Text = driver.FindElement(By.XPath("//*[@id=\"" + categoryName + "\"]/div[2]/dl/dt/a/img")).GetAttribute("alt").ToString();
          links.Add(driver.FindElement(By.XPath("//*[@id=\"" + categoryName + "\"]/div[2]/dl/dt/a")).GetAttribute("href").ToString());

          // 그외 기사 이름 
          mtNews2.Visible = true;
          mtNews3.Visible = true;
          mtNews4.Visible = true;
          mtNews5.Visible = true;
          mtNews6.Visible = true;
          mtNews2.Text = driver.FindElement(By.XPath("//*[@id=\"" + categoryName + "\"]/div[2]/div/ul/li[1]/a")).Text;
          mtNews3.Text = driver.FindElement(By.XPath("//*[@id=\"" + categoryName + "\"]/div[2]/div/ul/li[2]/a")).Text;
          mtNews4.Text = driver.FindElement(By.XPath("//*[@id=\"" + categoryName + "\"]/div[2]/div/ul/li[3]/a")).Text;
          mtNews5.Text = driver.FindElement(By.XPath("//*[@id=\"" + categoryName + "\"]/div[2]/div/ul/li[4]/a")).Text;
          mtNews6.Text = driver.FindElement(By.XPath("//*[@id=\"" + categoryName + "\"]/div[2]/div/ul/li[5]/a")).Text;

          // 각 기사들 링크 저장
          links.Add(driver.FindElement(By.XPath("//*[@id=\"" + categoryName + "\"]/div[2]/div/ul/li[1]/a")).GetAttribute("href").ToString());
          links.Add(driver.FindElement(By.XPath("//*[@id=\"" + categoryName + "\"]/div[2]/div/ul/li[2]/a")).GetAttribute("href").ToString());
          links.Add(driver.FindElement(By.XPath("//*[@id=\"" + categoryName + "\"]/div[2]/div/ul/li[3]/a")).GetAttribute("href").ToString());
          links.Add(driver.FindElement(By.XPath("//*[@id=\"" + categoryName + "\"]/div[2]/div/ul/li[4]/a")).GetAttribute("href").ToString());
          links.Add(driver.FindElement(By.XPath("//*[@id=\"" + categoryName + "\"]/div[2]/div/ul/li[5]/a")).GetAttribute("href").ToString());

          // 기사 본문 미리 보기
          driver.Url = "https://news.naver.com/";
          driver.Url = driver.FindElement(By.XPath("//*[@id=\"" + categoryName + "\"]/div[2]/dl/dt/a")).GetAttribute("href").ToString();
          aticles.Add(driver.FindElement(By.XPath("//*[@id=\"articleBodyContents\"]")).Text);
          driver.Url = "https://news.naver.com/";
          driver.Url = driver.FindElement(By.XPath("//*[@id=\"" + categoryName + "\"]/div[2]/div/ul/li[1]/a")).GetAttribute("href").ToString();
          aticles.Add(driver.FindElement(By.XPath("//*[@id=\"articleBodyContents\"]")).Text);
          driver.Url = "https://news.naver.com/";
          driver.Url = driver.FindElement(By.XPath("//*[@id=\"" + categoryName + "\"]/div[2]/div/ul/li[2]/a")).GetAttribute("href").ToString();
          aticles.Add(driver.FindElement(By.XPath("//*[@id=\"articleBodyContents\"]")).Text);
          driver.Url = "https://news.naver.com/";
          driver.Url = driver.FindElement(By.XPath("//*[@id=\"" + categoryName + "\"]/div[2]/div/ul/li[3]/a")).GetAttribute("href").ToString();
          aticles.Add(driver.FindElement(By.XPath("//*[@id=\"articleBodyContents\"]")).Text);
          driver.Url = "https://news.naver.com/";
          driver.Url = driver.FindElement(By.XPath("//*[@id=\"" + categoryName + "\"]/div[2]/div/ul/li[4]/a")).GetAttribute("href").ToString();
          aticles.Add(driver.FindElement(By.XPath("//*[@id=\"articleBodyContents\"]")).Text);
          driver.Url = "https://news.naver.com/";
          driver.Url = driver.FindElement(By.XPath("//*[@id=\"" + categoryName + "\"]/div[2]/div/ul/li[5]/a")).GetAttribute("href").ToString();
          aticles.Add(driver.FindElement(By.XPath("//*[@id=\"articleBodyContents\"]")).Text);

          for (int i = 0; i < 6; i++)
          {
            aticles[i] = aticles[i].ToString().Replace(".", "\r\n").Trim();
          }

          metroToolTip1.SetToolTip(mtNews1, aticles[0].ToString());
          metroToolTip1.SetToolTip(mtNews2, aticles[1].ToString());
          metroToolTip1.SetToolTip(mtNews3, aticles[2].ToString());
          metroToolTip1.SetToolTip(mtNews4, aticles[3].ToString());
          metroToolTip1.SetToolTip(mtNews5, aticles[4].ToString());
          metroToolTip1.SetToolTip(mtNews6, aticles[5].ToString());
        }
      }
      catch { }
      
    }

    // 타일 누르면 해당 뉴스로 이동
    private void mtNews_Click(object sender, EventArgs e)
    {
      driver1 = new ChromeDriver(service);
      switch (((MetroTile)sender).Name)
      {
        case "mtNews1":
          driver1.Url = links[0].ToString();
          break;
        case "mtNews2":
          driver1.Url = links[1].ToString();
          break;
        case "mtNews3":
          driver1.Url = links[2].ToString();
          break;
        case "mtNews4":
          driver1.Url = links[3].ToString();
          break;
        case "mtNews5":
          driver1.Url = links[4].ToString();
          break;
        case "mtNews6":
          driver1.Url = links[5].ToString();
          break;
      }
    }
  }
}
