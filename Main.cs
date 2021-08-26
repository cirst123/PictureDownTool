using Aspose.Cells;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Threading;
using System.Timers;
using System.Windows.Forms;

namespace PictureDownTool
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();

            comboBox1.SelectedIndex = 1;
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        private static System.Timers.Timer aTimer;

        List<string> listImg = new List<string>();
        static string dirPath = "";
        static string filePath = "";
        static int num = 1;
        private void btnDwon_Click(object sender, EventArgs e)
        {
            try
            {
                aTimer = new System.Timers.Timer(10000);
                progressBar1.Value = 0;
                txtMsg.Text = "";

                if (string.IsNullOrEmpty(txtTxtPath.Text))
                {
                    txtMsg.Text = "请选择数据文件";
                    return;
                }
                if (string.IsNullOrEmpty(txtDirPath.Text))
                {
                    txtMsg.Text = "请选择生成图片文件夹";
                    return;
                }
                if (txtTxtPath.Text.ToLower().EndsWith(".xls") || txtTxtPath.Text.ToLower().EndsWith(".xlsx"))
                {
                    int sheetIndex = 0, colName = -1, colAddr, rowStart;
                    if (string.IsNullOrWhiteSpace(txtSheet.Text.Trim()) || string.IsNullOrWhiteSpace(txtColAddr.Text.Trim()) || string.IsNullOrWhiteSpace(txtRowStart.Text.Trim()))
                    {
                        txtMsg.Text = "Excel参数未设置";
                        return;
                    }
                    if (!int.TryParse(txtSheet.Text.Trim(), out sheetIndex) || !int.TryParse(txtColAddr.Text.Trim(), out colAddr) || !int.TryParse(txtRowStart.Text.Trim(), out rowStart))
                    {
                        txtMsg.Text = "Excel参数非法";
                        return;
                    }
                    if (!string.IsNullOrEmpty(txtColName.Name.Trim()))
                    {
                        if (!int.TryParse(txtColName.Text.Trim(), out colName))
                        {
                            colName = -1;
                        }
                    }
                    listImg = mExcelToDS(txtTxtPath.Text, sheetIndex, colName, colAddr, rowStart);
                }
                else
                {
                    string split = txtSplit.Text.Trim();
                    listImg = System.IO.File.ReadAllLines(filePath).ToList();
                    for (int i = 0; i < listImg.Count; i++)
                    {
                        if (string.IsNullOrWhiteSpace(split))
                            listImg[i] = (i + 1) + "," + listImg[i];
                        else
                            listImg[i] = listImg[i].Substring(listImg[i].LastIndexOf(split.Trim()) + split.Trim().Length) + "," + listImg[i]; ;
                    }
                }
                if (listImg.Count == 0)
                {
                    txtMsg.Text = "文件中未找到有效的数据";
                    return;
                }
                bool isExistNoType = false;
                List<string> list = Directory.GetFiles(txtDirPath.Text).ToList();

                txtMsg.Text += "生成图片文件夹存在不相关文件，请先清空文件\r\n\r\n";
                foreach (var f in list)
                {
                    if (listImg.Count(li => f.EndsWith(li.Substring(0, li.IndexOf(",")) + (this.ckbPNGOrJPG.Checked ? ".jpg" : ".png"))) <= 0)
                    {
                        isExistNoType = true;
                        txtMsg.Text += "**" + f + "\r\n\r\n";
                    }
                };
                if (isExistNoType)
                    return;

                foreach (Control c in this.Controls)
                {
                    if (c.GetType().Equals(typeof(Button)) || c.GetType().Equals(typeof(ComboBox)) || c.GetType().Equals(typeof(GroupBox)) || c.GetType().Equals(typeof(CheckBox)))
                        c.Enabled = false;
                }

                TheardStart();
                txtMsg.Text = "开始下载\r\n\r\n";
                num = int.Parse(comboBox1.Text); threading = 0; successNum = 0;
                num = listImg.Count < num ? listImg.Count : num;
                Thread[] tasks = new Thread[num];
                List<string>[] listArraImg = new List<string>[num];
                for (int i = 0; i < listImg.Count; i++)
                {
                    if (listArraImg[i % num] == null) listArraImg[i % num] = new List<string>();
                    listArraImg[i % num].Add(listImg[i]);
                }
                for (int i = 0; i < num; i++)
                {
                    tasks[i] = new Thread(new ParameterizedThreadStart(doWork));
                    tasks[i].IsBackground = true;
                    tasks[i].Start(new { type = 0, list = listArraImg[i] });
                }
                //for (int i = 0; i < num; i++)
                //{
                //    tasks[i].Join();
                //}
                // t.Status = AtStatus.End; 
            }
            catch (Exception ex)
            {
                txtMsg.Text = "发生错误：" + ex.ToString();
            }
            finally
            {
            }
        }

        //线程任务
        void doWork(object obj)
        {
            List<string> list = (List<string>)obj.GetType().GetProperty("list").GetValue(obj, null);                                //图片路径集合
            // string split = obj.GetType().GetProperty("split").GetValue(obj, null).ToString();                                       //线程
            try
            {
                string imgname = "", imgaddr = "";
                int succNum = 0;
                for (int i = 0; i < list.Count; i++)
                {
                    imgname = list[i].Split(",".ToCharArray())[0].Substring(list[i].Split(",".ToCharArray())[0].LastIndexOf("/") + 1) + (ckbPNGOrJPG.Checked ? ".jpg" : ".png");
                    imgaddr = list[i].Split(",".ToCharArray())[1];
                    try
                    {
                        if (!File.Exists(dirPath + "/" + imgname))
                            HttpDownloadFile(imgaddr, dirPath + "/" + imgname);
                        succNum += 1;
                    }
                    catch (Exception ex)
                    {
                        collectList(imgaddr, dirPath + "/" + imgname);
                        TheardEnd(0, string.Format("链接：{0}  第{3}行，\r\n下载地址：{1}，\r\n异常：{2}\r\n\r\n\r\n", list[i], dirPath + "/" + imgname, ex.ToString(), (listImg.IndexOf(list[i]) + 1)));
                        //Application.Exit();
                    }
                    // System.Threading.Thread.Sleep(10000); 
                }
                TheardEnd(succNum);
            }
            catch (Exception ex)
            {
                TheardEnd(0, string.Format("***线程异常：{0}", ex.ToString()));
            }
        }

        static int threading = 0;
        static int successNum = 0;
        void TheardEnd(int succNum, string errMsg = "")
        {
            if (string.IsNullOrWhiteSpace(errMsg))
            {
                threading++;
                successNum += succNum;
                txtMsg.Text += string.Format("线程“{0}”下载完成\r\n\r\n", threading);
                if (threading == num)
                {
                    foreach (Control c in this.Controls)
                    {
                        if (c.GetType().Equals(typeof(Button)) || c.GetType().Equals(typeof(ComboBox)) || c.GetType().Equals(typeof(GroupBox)) || c.GetType().Equals(typeof(CheckBox)) || c.GetType().Equals(typeof(RadioButton)))
                            c.Enabled = true;
                    }
                    txtMsg.Text += string.Format("下载完成，共“{0}”条有效数据，成功下载“{1}”个文件\r\n", listImg.Count, successNum);

                    progressBar1.Value = listImg.Count;
                    aTimer.Stop();
                    Beep(800, 600);
                }
            }
            else
            {
                txtMsg.Text += errMsg;
            }
        }

        void TheardStart()
        {
            for (int i = listImg.Count - 1; i >= 0; i--)
            {
                if (!listImg[i].Contains("http"))
                    listImg.RemoveAt(i);
            }

            progressBar1.Maximum = listImg.Count;
            progressBar1.Step = 1;

            aTimer = new System.Timers.Timer(10000);
            aTimer.Elapsed += new ElapsedEventHandler(ProgressIng);
            aTimer.Interval = 1000;
            aTimer.AutoReset = true;
            aTimer.Start();

        }
        private void ProgressIng(object source, ElapsedEventArgs e)
        {
            progressBar1.Value = System.IO.Directory.GetFiles(filePath, (ckbPNGOrJPG.Checked ? "*.jpg" : "*.png")).Count();
        }

        public static void HttpDownloadFile(string url, string path)
        {
            try
            {
                // 设置参数
                HttpWebRequest request = WebRequest.Create(url) as HttpWebRequest;

                //发送请求并获取相应回应数据
                HttpWebResponse response = request.GetResponse() as HttpWebResponse;
                //直到request.GetResponse()程序才开始向目标网页发送Post请求
                Stream responseStream = response.GetResponseStream();

                //创建本地文件写入流
                Stream stream = new FileStream(path, FileMode.Create);

                byte[] bArr = new byte[256];//1024
                int size = responseStream.Read(bArr, 0, (int)bArr.Length);
                while (size > 0)
                {
                    stream.Write(bArr, 0, size);
                    size = responseStream.Read(bArr, 0, (int)bArr.Length);
                }
                stream.Close();
                responseStream.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("下载文件报错：" + ex.ToString());
            }
        }

        private void btnSelFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Multiselect = true;//该值确定是否可以选择多个文件
            dialog.Title = "请选择文件(excel|txt)";
            dialog.Filter = "文本文件|*.*|Excle|*.xlsx|Excel|*.xls";
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (!dialog.FileName.ToLower().EndsWith(".txt") && !dialog.FileName.ToLower().EndsWith(".xlsx") && !dialog.FileName.ToLower().EndsWith(".xls"))
                {
                    txtMsg.Text = "请选择文本文件或Excel文件（*.txt|*.xlsx|*.xls）";
                    return;
                }
                txtTxtPath.Text = dialog.FileName;
                filePath = dialog.FileName;
            }
        }

        private void btnSelDir_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog path = new FolderBrowserDialog();
            path.ShowDialog();
            txtDirPath.Text = path.SelectedPath;
            dirPath = path.SelectedPath;
        }

        ////声音函数  Beep(800,300);
        [DllImport("kernel32.dll")]
        public static extern bool Beep(int freq, int duration);
        private List<string> mExcelToDS(string Path, int sheet, int colName, int colAddr, int rowStart)
        {
            List<string> list = new List<string>();
            Workbook workbook = new Workbook();
            workbook.Open(Path);
            Cells cells = workbook.Worksheets[sheet].Cells;
            if (colAddr > cells.MaxDataColumn || colName > cells.MaxDataColumn)
                return list;
            for (int i = 0; i < cells.MaxDataRow + 1; i++)
            {
                if (i >= rowStart)
                {
                    if (colName != -1)
                        list.Add(cells[i, colName].StringValue.Trim() + "," + cells[i, colAddr].StringValue.Trim());
                    else
                        list.Add((i + 1) + "," + cells[i, colAddr].StringValue.Trim());

                    //for (int j = 0; j < cells.MaxDataColumn + 1; j++)
                    //{
                    //    string s = cells[i, j].StringValue.Trim();
                    //    list.Add(s);
                    //}
                }
            }
            return list;
        }

        Dictionary<string, string> dicError = new Dictionary<string, string>();
        object o = new object();
        /// <summary>
        /// 收集错误信息
        /// </summary>
        private void collectList(string url, string path)
        {
            lock (o)
            {
                dicError.Add(url, path);
            }
        }
    }
}
