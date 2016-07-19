using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Net;
using System.Linq;

namespace kgs_bots {
    public partial class Form1 : Form
    {
        Process P;
        string sBat, sExe, sIni;
        internal delegate void UpdateRTB(Color SelectionColor, string Text);

        DropShadow ds = new DropShadow();
        ToolTip t = new ToolTip();        

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        string sNickname, sPassword, sEngine, sGamesDB, sThreads, 
            sMaxTreeSize, sRules, sBoardSize, sMainTime, sBuyomyTime, sPeriods;

        bool isChecked = false;

        public Form1()
        {           
            // Если в настройках есть язык, устанавливаем его для текущего потока, в котором выполняется приложение.
            if (!String.IsNullOrEmpty(Properties.Settings.Default.Language))
            {
                // ВАЖНО: Устанавливать язык нужно до создания элементов формы!
                // Это можно сделать глобально, в рамках приложения в классе Program (см. файл Program.cs).
                System.Threading.Thread.CurrentThread.CurrentUICulture = System.Globalization.CultureInfo.GetCultureInfo(Properties.Settings.Default.Language);
                System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.GetCultureInfo(Properties.Settings.Default.Language);
            }

            InitializeComponent();

            this.Shown += new EventHandler(Form1_Shown);
            this.Resize += new EventHandler(Form1_Resize);
            this.LocationChanged += new EventHandler(Form1_Resize);
        }

        void Form1_Shown(object sender, EventArgs e)
        {
            Rectangle rc = this.Bounds;
            rc.Inflate(7, 7);
            ds.Bounds = rc;
            ds.Show();
            this.BringToFront();
        }

        void Form1_Resize(object sender, EventArgs e)
        {
            ds.Visible = (this.WindowState == FormWindowState.Normal);
            if (ds.Visible)
            {
                Rectangle rc = this.Bounds;
                rc.Inflate(7, 7);
                ds.Bounds = rc;
            }
            this.BringToFront();
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
                return;
            }

            base.OnMouseMove(e);
        }

        private void MinimizedApp(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        
        private void Settings(object sender, EventArgs e)
        {
            Image Set = Properties.Resources.set;
            Image Set_chek = Properties.Resources.set_chek;
            SettingsBtn.BackgroundImage = Set_chek;

            Opacity = 0.8;

            Settings f4 = new Settings();
            if (f4.ShowDialog(this) == DialogResult.OK) Application.Restart();
            else
            {
                Opacity = 1.0;
                SettingsBtn.BackgroundImage = Set;
            }
            f4.Dispose();
        }

        private void Info(object sender, EventArgs e)
        {
            Image Info = Properties.Resources.info;
            Image Info_chek = Properties.Resources.info_chek;
            checkBox2.BackgroundImage = Info_chek;
            Opacity = 0.8;

            Info f5 = new Info();
            if (f5.ShowDialog(this) == DialogResult.OK)
            {
                Opacity = 1.0;
                checkBox2.BackgroundImage = Info;
            }
            f5.Dispose();
        }

        private void Console(object sender, EventArgs e)
        {
            isChecked = !isChecked;
            int a = 820;
            int b = 410;
            this.Width = isChecked ? a : b;

            Image Console = Properties.Resources.console;
            Image Console_chek = Properties.Resources.console_chek;
            checkBox1.BackgroundImage = isChecked ? Console_chek : Console;
        }

        private void CloseApp(object sender, EventArgs e)
        {
            Opacity = 0.8;

            Exit f3 = new Exit();
            if (f3.ShowDialog(this) == DialogResult.OK)
            {
                if (startBTN.Enabled == false)
                {
                    if (sEngine == "pachi") sExe = "pachi";
                    if (sEngine == "gnugo") sExe = "gnugo";
                    if (sEngine == "fuego") sExe = "fuego";

                    Process[] ps1 = Process.GetProcessesByName(sExe);
                    foreach (Process p1 in ps1)
                    {
                        p1.Kill();
                    }
                }
                Close();
            }
            else Opacity = 1.0;

            f3.Dispose();
        }

        private void EngineSelectedIndexChanged(object sender, EventArgs e)
        {
            if (engine.Text == "gnugo") {
                checkDB.Visible = false;
                label13.Visible = false;
                threads.Visible = false;
                label14.Visible = false;
                maxtreesize.Visible = false;
                label15.Visible = false;
            };
            if (engine.Text == "pachi")
            {
                checkDB.Visible = true;
                label13.Visible = true;
                threads.Visible = true;
                label14.Visible = true;
                maxtreesize.Visible = true;
                label15.Visible = true;
            };
            if (engine.Text == "fuego")
            {
                checkDB.Visible = false;
                label13.Visible = false;
                threads.Visible = false;
                label14.Visible = false;
                maxtreesize.Visible = false;
                label15.Visible = false;
            };
        }

        public void StartClick(object sender, EventArgs e)
        {
            richTBConsole.Clear();
            textOut.Clear();

            sNickname = nickname.Text;
            sPassword = psw.Text;

            var sRoom = room.Text;
            var sRoomC = "\\u" + string.Join("\\u", sRoom.Select(c => ((int)c).ToString("x4")));

            sEngine = engine.Text;

            if (checkDB.Text == "off") { sGamesDB = ""; }
            else if (checkDB.Text == "on") { sGamesDB = "-f book.dat "; }

            sThreads = threads.Text;
            sMaxTreeSize = maxtreesize.Text;

            if (rules.Text == "Chinese") sRules = "chinese";
            if (rules.Text == "Japanese") sRules = "japanese";
            if (boardsize.Text == "7 x 7") sBoardSize = "7";
            if (boardsize.Text == "9 x 9") sBoardSize = "9";
            if (boardsize.Text == "11 x 11") sBoardSize = "11";
            if (boardsize.Text == "13 x 13") sBoardSize = "13";
            if (boardsize.Text == "15 x 15") sBoardSize = "15";
            if (boardsize.Text == "17 x 17") sBoardSize = "17";
            if (boardsize.Text == "19 x 19") sBoardSize = "19";

            sMainTime = maintime.Text;
            sBuyomyTime = byuomytime.Text;
            sPeriods = periods.Text;

            string setNOE = "name = " + sNickname + "\r\n" +
                            "password=" + sPassword + "\r\n" +
                            "room=" + sRoomC + "\r\n" +
                            "mode=custom" + "\r\n" +
                            "reconnect=true" + "\r\n" +
                            "rules=" + sRules + "\r\n" +
                            "rules.boardSize=" + sBoardSize + "\r\n" +
                            "rules.time=" + sMainTime + ":00+" + sPeriods + "x0:" + sBuyomyTime + "\r\n" +
                            "talk=I'm a computer." + "\r\n" +
                            "gameNotes=bot :: " + sEngine;

            if (textOut.Text == "")
            {
                if (nickname.Text == "") { nickname.Focus(); t.Show(MyStrings.EnterNickname, nickname, 1500); }
                else if (psw.Text == "") { psw.Focus(); t.Show(MyStrings.EnterPassword, psw, 1500); }
                else if (room.Text == "") { room.Focus(); t.Show(MyStrings.EnterRoom, room, 1500); }
                else if (rules.Text == "") { rules.Focus(); t.Show(MyStrings.Rules, rules, 1500); }
                else if (boardsize.Text == "") { boardsize.Focus(); t.Show(MyStrings.BoardSize, boardsize, 1500); }
                else if (engine.Text == "") { engine.Focus(); t.Show(MyStrings.Engine, engine, 1500); }

                else if (engine.Text == "pachi")
                {
                    if (threads.Text == "") { threads.Focus(); t.Show(MyStrings.Threads, threads, 1500); }
                    else if (maxtreesize.Text == "") { maxtreesize.Focus(); t.Show(MyStrings.Memory, maxtreesize, 1500); }
                    else if ((threads.Text != "") && (maxtreesize.Text != ""))
                    {
                        textOut.Text += "engine=" + sEngine + ".exe " + sGamesDB + "threads=" + sThreads + ", max_tree_size=" + sMaxTreeSize + "\r\n" + setNOE;
                        SaveEngine(textOut.Text);
                    }
                }
                else if (engine.Text == "gnugo")
                {
                    textOut.Text += "engine=" + sEngine + ".exe" + " --mode gtp --quiet --cache-size 32" + "\r\n" + setNOE;
                    SaveEngine(textOut.Text);
                }
                else if (engine.Text == "fuego")
                {
                    textOut.Text += "engine=" + sEngine + ".exe" + "\r\n" + setNOE;
                    SaveEngine(textOut.Text);
                }
            }

        }
     
        private void DisabledField()
        {
            startBTN.Enabled = false;
            button2.Enabled = true;
            startBTN.Visible = false;
            button2.Visible = true;

            greenPic.Visible = true;
            redPic.Visible = true;
            label5.Visible = false;
            SettingsBtn.Enabled = false;

            for (int i = 0; i < 3; i++)
            {
                TextBox[] txtBox = new TextBox[]
                {
                    nickname, psw, room
                };
                txtBox[i].Enabled = false;
            }

            for (int x = 0; x < 3; x++)
            {
                NumericUpDown[] nudBox = new NumericUpDown[]
                {
                    maintime, byuomytime, periods
                };
                nudBox[x].Enabled = false;
            }

            if (engine.Text == "pachi")
            {
                for (int j = 0; j < 5; j++)
                {
                    ComboBox[] cmbBox = new ComboBox[]
                    {
                    rules, boardsize, engine, threads, maxtreesize
                    };
                    cmbBox[j].Enabled = false;
                }
                checkDB.Enabled = false;
            }

            if (engine.Text == "gnugo")
            {
                for (int j = 0; j < 3; j++)
                {
                    ComboBox[] cmbBox = new ComboBox[]
                    {
                    rules, boardsize, engine
                    };
                    cmbBox[j].Enabled = false;
                }
            }

            if (engine.Text == "fuego")
            {
                for (int j = 0; j < 3; j++)
                {
                    ComboBox[] cmbBox = new ComboBox[]
                    {
                    rules, boardsize, engine
                    };
                    cmbBox[j].Enabled = false;
                }
            }
        }

        private void SaveEngine(string data)
        {
            if (sEngine == "pachi") sIni = @"pachi.ini";
            if (sEngine == "gnugo") sIni = @"gnugo.ini";
            if (sEngine == "fuego") sIni = @"fuego.ini";

            StreamWriter writer = new StreamWriter(sIni, false);
            writer.Write(data);
            writer.Close();

            string Out = POST();

            if (Out.Contains("You are currently logged in as"))
            {
                //запускаем батник и перехватываем консоль в textbox    
                if (sEngine == "pachi") sBat = @"startpachi.bat";
                if (sEngine == "gnugo") sBat = @"startgnugo.bat";
                if (sEngine == "fuego") sBat = @"startfuego.bat";

                P = new Process();
                P.StartInfo.FileName = sBat;
                P.StartInfo.Arguments = "/k";
                P.StartInfo.RedirectStandardError = true;
                P.StartInfo.RedirectStandardInput = true;
                P.StartInfo.RedirectStandardOutput = true;
                P.StartInfo.CreateNoWindow = true;
                P.StartInfo.UseShellExecute = false;
                P.ErrorDataReceived += P_ErrorDataReceived;
                P.OutputDataReceived += P_OutputDataReceived;
                P.Start();
                P.BeginErrorReadLine();
                P.BeginOutputReadLine();

                DisabledField();
            }
            else
            {
                groupBox1.Focus();
                t.Show(MyStrings.Error, groupBox1, 1500);
            }
        }

        private void P_ErrorDataReceived(object sender, DataReceivedEventArgs e)
        {
            this.Invoke(new UpdateRTB(UpdateRTBMethod), new object[] { Color.Lime, e.Data });
        }

        private void P_OutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            this.Invoke(new UpdateRTB(UpdateRTBMethod), new object[] { Color.Lime, e.Data });
        }

        public void UpdateRTBMethod(Color SelectionColor, string Text)
        {
            richTBConsole.SelectionColor = SelectionColor;
            richTBConsole.SelectedText = Text + Environment.NewLine;
            richTBConsole.ScrollToCaret();
        }

        private void StopClick(object sender, EventArgs e)
        {
            Opacity = 0.8;        

            // создаем форму
            StopBot f2 = new StopBot();

            // Show testDialog as a modal dialog and determine if DialogResult = OK.
            if (f2.ShowDialog(this) == DialogResult.OK)
            {
                if (startBTN.Enabled == false)
                {
                    richTBConsole.Clear();

                    if (sEngine == "pachi") sExe = "pachi";
                    if (sEngine == "gnugo") sExe = "gnugo";
                    if (sEngine == "fuego") sExe = "fuego";

                    Process[] ps1 = Process.GetProcessesByName(sExe);
                    foreach (Process p1 in ps1)
                    {
                        p1.Kill();
                    }
                }

                startBTN.Enabled = true;
                button2.Enabled = false;
                startBTN.Visible = true;
                button2.Visible = false;

                greenPic.Visible = false;
                redPic.Visible = true;
                SettingsBtn.Enabled = true;
                label5.Visible = true;

                for (int i = 0; i < 3; i++)
                {
                    TextBox[] txtBox = new TextBox[] {
                    nickname, psw, room
                };
                    txtBox[i].Enabled = true;
                }

                for (int x = 0; x < 3; x++)
                {
                    NumericUpDown[] nudBox = new NumericUpDown[] {
                    maintime, byuomytime, periods
                };
                    nudBox[x].Enabled = true;
                }

                if (engine.Text == "pachi")
                {
                    for (int j = 0; j < 5; j++)
                    {
                        ComboBox[] cmbBox = new ComboBox[]
                        {
                    rules, boardsize, engine, threads, maxtreesize
                        };
                        cmbBox[j].Enabled = true;
                    }
                    checkDB.Enabled = true;
                }

                if (engine.Text == "gnugo")
                {
                    for (int j = 0; j < 3; j++)
                    {
                        ComboBox[] cmbBox = new ComboBox[]
                        {
                    rules, boardsize, engine
                        };
                        cmbBox[j].Enabled = true;
                    }
                }

                if (engine.Text == "fuego")
                {
                    for (int j = 0; j < 3; j++)
                    {
                        ComboBox[] cmbBox = new ComboBox[]
                        {
                    rules, boardsize, engine
                        };
                        cmbBox[j].Enabled = true;
                    }
                }

                Opacity = 1.0;
            }
            else Opacity = 1.0;
            f2.Dispose();
        }

        public string POST() // POST запрос на сайт кгс для проверки аккаунта
        {
            string user = nickname.Text;
            string password = psw.Text;

            HttpWebRequest req = (HttpWebRequest)WebRequest.Create("https://www.gokgs.com/advertisers/index.jsp");
            req.Method = "POST";
            req.ContentType = "application/x-www-form-urlencoded";
            string d = "user=" + user + "&password=" + password + "&type=submit";
            byte[] sentData = Encoding.UTF8.GetBytes(d);
            req.ContentLength = sentData.Length;
            Stream sendStream = req.GetRequestStream();
            sendStream.Write(sentData, 0, sentData.Length);
            sendStream.Close();

            HttpWebResponse res = (HttpWebResponse)req.GetResponse();// Получаем ответ
            Stream ReceiveStream = res.GetResponseStream();
            StreamReader sr = new StreamReader(ReceiveStream, Encoding.UTF8);
            string result = sr.ReadToEnd();
            sr.Close();

            return result;
        }
    }
}
