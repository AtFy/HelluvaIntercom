using System;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;
using System.Media;

using CefSharp;
using CefSharp.Core;
using CefSharp.BrowserSubprocess;
using CefSharp.DevTools;
using CefSharp.Event;
using CefSharp.Web;
using CefSharp.DevTools.IO;
using CefSharp.WinForms;

using HelluvaIntercom.Extensions;

namespace HelluvaIntercom
{
    public partial class MainFrameForm : Form
    {
        public MainFrameForm()
        {
            InitializeComponent();

        }
        ChromiumWebBrowser browser = new ChromiumWebBrowser("https://app.intercom.com/a/apps/gcyyqzq9/inbox/inbox/5437244"); // грузим браузер
        private void Form1_Load(object sender, EventArgs e)
        {
            toolStripContainer1.ContentPanel.Controls.Add(browser); //обязательно грузим его в какое-тот окно, иначе всё ломается
        }

        private void toolStripContainer1_ContentPanel_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string test = "";
            var t = browser.GetSourceAsync(); //здесь таск на получение html кода
            test = t.Result;

            string[] usu = { "submenu__sections__section__items__item__count" };
            string[] awa = test.Split(usu, StringSplitOptions.RemoveEmptyEntries);
            textBox1.Text = awa[1]; //получаем результат выполнения таска в строку. В данном случае - в текстбокс.


            //скрипт разворачивания see more
            var script = @"document.getElementsByClassName('btn__tertiary__deemphasized pl-2')[0].click();";
            browser.ExecuteScriptAsync(script);


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void toolStripContainer1_TopToolStripPanel_Click(object sender, EventArgs e)
        {

        }

        public void popUpThread(Form j)
        {
            var sound = new SoundPlayer(Properties.Resources.NotificationSound1);
            sound.Play();

            var popUpForm = j;


            popUpForm.Show();
            popUpForm.TopLevel = true;
            popUpForm.ShowInTaskbar = false;

            var stopwatch = new Stopwatch();
            stopwatch.Sleep(2000);


            for (var i = 1.0; i >= 0; i -= 0.01)
            {
                popUpForm.Opacity = i;
                stopwatch.Sleep(10);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {


            //попап
            var t = new Thread(() => popUpThread(new PopupForm()));
            t.Start();




        }
    }
}
