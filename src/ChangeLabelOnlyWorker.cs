using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;

namespace UmengChannel.src
{
    public class ChangeLabelOnlyWorker
    {
        static System.ComponentModel.BackgroundWorker workReporter;
		//public StoredList
        private static ChangeLabelOnlyWorker worker;
        static ChangeLabelOnlyWorker()
        {
            worker = new ChangeLabelOnlyWorker();
		}


        public static void setBackgroundWorker(System.ComponentModel.BackgroundWorker bw)
        {
            workReporter = bw;
        }

        public static void start()
        {
            worker.run();
        }

        private void run()
        {   
            int progress = 0;
            int total = ChangeLabelOnlyConfig.getInstance().apks.Length*3  + 1;
            String name = "";
            for (int i = 0; i < ChangeLabelOnlyConfig.getInstance().apks.Length; i++)
            {
                String apk = ChangeLabelOnlyConfig.getInstance().apks[i];

                if (Directory.Exists(ChangeLabelOnlyConfig.getInstance().ApkDecodeFolder))
                {
                    Directory.Delete(ChangeLabelOnlyConfig.getInstance().ApkDecodeFolder, true);
                }
                
                decodeApk(apk);
                publishProgress(progress++, total);
                clean();
                replaceLableName();

                publishProgress(progress++, total);
                rebuildApk();

                publishProgress(progress++, total);
                signAPK();
                zipAlign();
                name = apk.Substring(apk.LastIndexOf("\\")+1);
                name = name.Substring(0,name.LastIndexOf(".")-1);
                copyToWorkspace(name);
                publishProgress(progress++, total);
            }
        }

        private void copyToWorkspace(string name)
        {

            string apk_file = ChangeLabelOnlyConfig.getInstance().finalApkFile;

            if (apk_file == null || !File.Exists(apk_file))
            {
                throw new XException("Fail to generate .apk for " + name);
            }

            string dst_file = generateDstFile(name);
            if (File.Exists(dst_file)) File.Delete(dst_file);

            File.Copy(apk_file, dst_file);
        }

        private string generateDstFile(string name)
        {

            string project_name = name;
            string file_name = string.Format("{0}_{1}.apk", project_name, ChangeLabelOnlyConfig.getInstance().labelName);
            
            string dst_path = Path.Combine(System.Environment.CurrentDirectory,
                Path.Combine("output", project_name));

            if (!Directory.Exists(dst_path))
            {
                Directory.CreateDirectory(dst_path);
            }

            return Path.Combine(dst_path, file_name);
        }

        private void zipAlign()
        {

            if (!File.Exists(ChangeLabelOnlyConfig.getInstance().UnzipalignApkFile))
            {
                throw new Exception(string.Format("signer apk error .. can't find {0} file for zip align", ChangeLabelOnlyConfig.getInstance().UnzipalignApkFile));
            }

            List<String> cmd = new List<string>();

            cmd.Add("zipalign");
            cmd.Add("-v");
            cmd.Add("4");
            cmd.Add(string.Format("\"{0}\"", ChangeLabelOnlyConfig.getInstance().UnzipalignApkFile));
            cmd.Add(string.Format("\"{0}\"", ChangeLabelOnlyConfig.getInstance().finalApkFile));

            Sys.Run(ToCommand(cmd));
        }

        private void signAPK()
        {

            List<String> cmd = new List<string>();

            cmd.Add("jarsigner");
            cmd.Add("-keystore");
            cmd.Add(string.Format("\"{0}\"", ChangeLabelOnlyConfig.getInstance().keystore_file_path));
            cmd.Add("-storepass");
            cmd.Add(ChangeLabelOnlyConfig.getInstance().keystore_pw);
            cmd.Add("-keypass");
            cmd.Add(ChangeLabelOnlyConfig.getInstance().key_pw);
            cmd.Add("-signedjar");
            cmd.Add(string.Format("\"{0}\"", ChangeLabelOnlyConfig.getInstance().UnzipalignApkFile));
            cmd.Add(string.Format("\"{0}\"", ChangeLabelOnlyConfig.getInstance().UnsignedApkFile));
            cmd.Add(ChangeLabelOnlyConfig.getInstance().alias);
            cmd.Add("-digestalg");
            cmd.Add("SHA1");
            cmd.Add("-sigalg");
            cmd.Add("MD5withRSA");

            Sys.Run(ToCommand(cmd));
        }

        private void rebuildApk()
        {

            if (!Directory.Exists(ChangeLabelOnlyConfig.getInstance().ApkTempFolder))
            {
                Directory.CreateDirectory(ChangeLabelOnlyConfig.getInstance().ApkTempFolder);
            }

            List<String> cmd = new List<string>();
            cmd.Add("apktool");
            cmd.Add("b");
            cmd.Add(string.Format("\"{0}\"", ChangeLabelOnlyConfig.getInstance().ApkDecodeFolder));
            cmd.Add(string.Format("\"{0}\"", ChangeLabelOnlyConfig.getInstance().UnsignedApkFile));

            Sys.Run(ToCommand(cmd));
        }


        private void replaceLableName()
        {
            Log.i("Add or replcae replaceLabelOnly");

            string androidmanifest_file = ChangeLabelOnlyConfig.getInstance().AndroidManifestFile;

            if (!File.Exists(androidmanifest_file))
            {
                throw new Exception(string.Format("Can't find AndroidManifest.xml file in the {0}", androidmanifest_file));
            }

            XmlDocument doc = new XmlDocument();
            doc.Load(androidmanifest_file);

            //update 
            XmlNodeList mata_datas = doc.GetElementsByTagName("meta-data");
            bool hasSet = false;
            foreach (XmlElement mata_data in mata_datas)
            {
                String meta_name = mata_data.GetAttribute("android:name");
                if (meta_name.Equals("TD_CHANNEL_ID") || meta_name.EndsWith("UMENG_CHANNEL") || meta_name.EndsWith("com.wiyun.sdk.channel"))
                {
                    mata_data.SetAttribute("android:value", ChangeLabelOnlyConfig.getInstance().labelName);
                    hasSet = true;
                }
            }

            // if no set ,add it
            if (!hasSet)
            {
                XmlElement application = doc.GetElementsByTagName("application")[0] as XmlElement;

                XmlElement channel_mata = doc.CreateElement("meta-data");
                channel_mata.SetAttribute("android:name", "UMENG_CHANNEL");
                channel_mata.SetAttribute("android:value", ChangeLabelOnlyConfig.getInstance().labelName);

                application.AppendChild(channel_mata);

                XmlElement td_channel__mata = doc.CreateElement("meta-data");
                td_channel__mata.SetAttribute("android:name", "TD_CHANNEL_ID");
                td_channel__mata.SetAttribute("android:value", ChangeLabelOnlyConfig.getInstance().labelName);

                application.AppendChild(td_channel__mata);

                XmlElement weiyun_mata = doc.CreateElement("meta-data");
                weiyun_mata.SetAttribute("android:name", "com.wiyun.sdk.channel");
                weiyun_mata.SetAttribute("android:value", ChangeLabelOnlyConfig.getInstance().labelName);

                application.AppendChild(weiyun_mata);
            }

            doc.Save(androidmanifest_file);

        }

        private void clean()
        {
            if (Directory.Exists(ChangeLabelOnlyConfig.getInstance().ApkTempFolder))
            {
                Directory.Delete(ChangeLabelOnlyConfig.getInstance().ApkTempFolder, true);
            }
            

            //if (Directory.Exists(ChangeLabelOnlyConfig.getInstance().ApkDecodeFolder))
            //{
            //    Directory.Delete(ChangeLabelOnlyConfig.getInstance().ApkDecodeFolder, true);
            //}
        }

        private void publishProgress(int progress, int total)
        {
            workReporter.ReportProgress(progress * 100 / total);
        }

        private void decodeApk(String apkPath)
        {
            if (!File.Exists(apkPath))
            {
                throw new XException("Target apk is missing..");
            }

            List<String> cmd = new List<string>();
            cmd.Add("apktool");
            cmd.Add("d");
            cmd.Add("--no-src");
            cmd.Add("-f");
            cmd.Add(string.Format("\"{0}\"", apkPath));
            cmd.Add(string.Format("\"{0}\"", ChangeLabelOnlyConfig.getInstance().ApkDecodeFolder));

            Sys.Run(ToCommand(cmd));
        }


        private string ToCommand(List<string> cmd)
        {

            StringBuilder msb = new StringBuilder();

            foreach (string p in cmd)
            {
                msb.Append(p);
                msb.Append(" ");
            }

            return msb.ToString();
        }

    }
}
