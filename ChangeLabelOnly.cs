using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using UmengChannel.src;

namespace UmengChannel
{
    public partial class ChangeLabelOnly : Form
    {
        BackgroundWorker bw = new BackgroundWorker();

        public ChangeLabelOnly()
        {
            InitializeComponent();
            initBackgroundWorker();

            loadConfig();
        }

        private void loadConfig()
        {
            ChangeLabelOnlyConfig c = ChangeLabelOnlyConfig.getInstance();
            if (c != null)
            {
                this.tb_alias.Text = c.alias;
                this.tb_android_sdk_path.Text = c.android_home;
                this.tb_java_path.Text = c.java_home;
                this.tb_key_pw.Text = c.key_pw;
                this.tb_keystore.Text = c.keystore_file_path;
                this.tb_keystore_pw.Text = c.keystore_pw;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (checkLabelInfo() || checkKeyStore() || checkJavaAndroidPath())
            {
                MessageBox.Show("信息填写不完整");
                return;
            }

            ChangeLabelOnlyConfig.getInstance().writeSettintToFile();

            ChangeLabelOnlyConfig.getInstance().labelName = this.textBox2.Text.Trim();

            //package
            ChangeLabelOnlyConfig.getInstance().key_pw = tb_key_pw.Text.Trim();
            ChangeLabelOnlyConfig.getInstance().keystore_pw = tb_keystore_pw.Text.Trim();
            ChangeLabelOnlyConfig.getInstance().alias = tb_alias.Text.Trim();
            ChangeLabelOnlyConfig.getInstance().setEnvironment();
            progressBar1.Visible = true;
            bw.RunWorkerAsync();

        }

        //set backgroundworker for background task!
        private void initBackgroundWorker()
        {
            bw.WorkerReportsProgress = true;
            bw.WorkerSupportsCancellation = true;
            bw.DoWork += new DoWorkEventHandler(doWork);
            bw.ProgressChanged += new ProgressChangedEventHandler(bw_ProgressChanged);
            bw.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bw_RunWorkerCompleted);
        }

        private void bw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.progressBar1.Visible = false;

            if ((e.Cancelled == true))
            {
                MessageBox.Show("任务已经取消");
            }
            
            else if (!(e.Error == null))
            {   
                System.Text.StringBuilder sb = new System.Text.StringBuilder();
                sb.Append(e.Error.Message);
                sb.Append("\n\n");
                sb.Append("查看 /log/i.txt 详细错误信息");
                MessageBox.Show(sb.ToString());

                //agent.OnEvent("build", "fail");
            }
            else
            {
               // ChangeLabelOnlyConfig.getInstance().writeSettintToFile();
                MessageBox.Show("渠道打包完成");
            }
        }

        private void bw_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            this.progressBar1.Value = e.ProgressPercentage;
            Log.i("progress:" + e.ProgressPercentage);
        }


        private void doWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                BackgroundWorker worker = sender as BackgroundWorker;
                ChangeLabelOnlyWorker.setBackgroundWorker(worker);
                ChangeLabelOnlyWorker.start();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private bool checkKeyStore()
        {
            return (this.tb_alias.Text.Trim().Equals("") || this.tb_keystore.Text.Trim().Equals("") || this.tb_keystore_pw.Text.Trim().Equals("")
                || this.tb_key_pw.Text.Trim().Equals(""));
        }

        private bool checkJavaAndroidPath()
        {
            return (this.tb_java_path.Text.Trim().Equals("") || this.tb_android_sdk_path.Text.Trim().Equals(""));
        }

        private bool checkLabelInfo()
        {
            return (this.textBox1.Text.Trim().Equals("") || this.textBox2.Text.Trim().Equals(""));
        }

        private void bt_keystore_path_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.DefaultExt = "keystore";
            openFileDialog1.Filter = "keystore files (*.*)|*.*";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                this.tb_keystore.Text = openFileDialog1.FileName;
                ChangeLabelOnlyConfig.getInstance().keystore_file_path = this.tb_keystore.Text.Trim();
            }
        }

        private void bt_java_path_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();

            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                string path = null;
                if (Utils.isValidJavaSDKPath(path = folderBrowserDialog1.SelectedPath))
                {
                    this.tb_java_path.Text = path;
                    ChangeLabelOnlyConfig.getInstance().java_home = path;
                }
                else
                {
                    MessageBox.Show("请选择 JDK 工程根目录( 包涵 lin ,bin 等子目录)");
                }
            }
        }

        private void bt_android_sdk_path_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();

            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                string path = null;
                if (Utils.isValidAndroidSDKPath(path = folderBrowserDialog1.SelectedPath))
                {
                    this.tb_android_sdk_path.Text = path;
                    ChangeLabelOnlyConfig.getInstance().android_home = path;
                }
                else
                {
                    MessageBox.Show("请选择 Android SDK 目录( 包涵 platform , tools 等子目录)");
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.DefaultExt = "apk";
            openFileDialog1.Filter = "所有文件 (*.apk)|*.APK";
            openFileDialog1.Multiselect = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                String[] apks = openFileDialog1.FileNames;
                bool isAllApks = true;
                foreach (String apk in apks)
                {
                    if (!apk.ToLower().EndsWith(".apk"))
                    {
                        isAllApks = false;
                        break;
                    }

                }

                if (isAllApks)
                {
                    ChangeLabelOnlyConfig.getInstance().apks = apks;
                    this.textBox1.Text = openFileDialog1.FileNames[0].Substring(0, openFileDialog1.FileNames[0].LastIndexOf("\\"));
                    
                }
                else
                {
                    MessageBox.Show("你的选择中有非APK文件，请重新选择");
                    return;
                }

            }
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", ChangeLabelOnlyConfig.getInstance().outputFolder);
        }

    }
}
