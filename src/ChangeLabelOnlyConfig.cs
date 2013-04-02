using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Xml.Serialization;

namespace UmengChannel
{
   public  class ChangeLabelOnlyConfig
    {
        private static ChangeLabelOnlyConfig config;

        public String ant_home{get;set;}
        public String apktool_home { get; set; }
        public String java_home { get; set; }
        public String android_home { get; set; }
        public String [] apks  {get;set;}

        public string keystore_file_path { get; set; }
        public string keystore_pw { get; set; }
        public string key_pw { get; set; }
        public string alias { get; set; }

        public String labelName { get; set; }

        public String pro_path { get; set; }

        public ChangeLabelOnlyConfig() {

            ant_home = System.IO.Path.Combine(System.Environment.CurrentDirectory, Path.Combine("tools", "ant"));
            apktool_home = Path.Combine(System.Environment.CurrentDirectory, Path.Combine("tools", "apktool"));
            buildDirectory();
            if (!string.IsNullOrEmpty(java_home) && !string.IsNullOrEmpty(android_home))
            {
                setEnvironment();
            }
        }

        public static ChangeLabelOnlyConfig getInstance()
        {
            if (config == null)
            {
                ChangeLabelOnlyConfig c = readSettingFromFile();
                if (c == null)
                {
                    config = new ChangeLabelOnlyConfig();
                }
                else
                {
                    config = c;
                }
            }
            return config;
        }

        private void buildDirectory()
        {
            string pro_path = Path.Combine(System.Environment.CurrentDirectory, "projects");

            if (!Directory.Exists(pro_path))
            {
                Directory.CreateDirectory(pro_path);
            }
        }

        public string AndroidManifestFile
        {
            get
            {
                return Path.Combine( ApkDecodeFolder , "AndroidManifest.xml");
            }
        }

        public string outputFolder
        {
            get
            {
                return Path.Combine(System.Environment.CurrentDirectory, Path.Combine(System.Environment.CurrentDirectory,"output"));
            }
        }

        public string ApkDecodeFolder
        {
            get
            {
                return Path.Combine(System.Environment.CurrentDirectory, "temp");
            }
        }

        public string ApkTempFolder
        {
            get
            {
                return Path.Combine(System.Environment.CurrentDirectory, "bin");
            }
        }

        public string UnsignedApkFile
        {
            get
            {
                  return Path.Combine(ApkTempFolder, "unsigned.apk");
            }
        }


        public string UnzipalignApkFile
        {
            get
            {
                return Path.Combine(ApkTempFolder, "unzipalign.apk");  
            }
        }

        public string finalApkFile
        {
            get
            {
                return Path.Combine( ApkTempFolder  ,"release.apk");
            }
        }

        public   void writeSettintToFile()
        {
            string settingPath = System.IO.Path.Combine(System.Environment.CurrentDirectory, "settings.xml");// Utils.generateSettingFileName(projectName));

            if (File.Exists(settingPath)) File.Delete(settingPath);

            XmlSerializer xs = new XmlSerializer(typeof(ChangeLabelOnlyConfig));
            Stream stream = new FileStream(settingPath, FileMode.Create, FileAccess.Write, FileShare.Read);
            xs.Serialize(stream, this);
            stream.Close();

            //using (Stream file = File.Open(settingPath, FileMode.OpenOrCreate))
            //{
            //    System.Runtime.Serialization.IFormatter formatter = new BinaryFormatter();
            //    formatter.Serialize(file, this);

            //    Log.i("setting save succeed !!");
            //}
        }

        public static ChangeLabelOnlyConfig readSettingFromFile()
        {
            string settingPath = System.IO.Path.Combine(System.Environment.CurrentDirectory, "settings.xml");// Utils.generateSettingFileName(projectName));

            if (!File.Exists(settingPath))
            {
                return null;
            }
            ChangeLabelOnlyConfig c = null;
            try
            {
                XmlSerializer xs = new XmlSerializer(typeof(ChangeLabelOnlyConfig));
                Stream stream = new FileStream(settingPath, FileMode.Open, FileAccess.Read, FileShare.Read);
                ChangeLabelOnlyConfig p = xs.Deserialize(stream) as ChangeLabelOnlyConfig;
                stream.Close();
                //using (FileStream fs = new FileStream(settingPath, FileMode.Open))
                //{
                //    BinaryFormatter formatter = new BinaryFormatter();
                //    c = (ChangeLabelOnlyConfig)formatter.Deserialize(fs);
                      
                //}
            }
            catch (Exception e)
            {
                Log.e(e.Message);
            }
            return c;
        }
		

        public void setEnvironment()
        {
            Log.i("set environment");

            string pathOrg = System.Environment.GetEnvironmentVariable("PATH", EnvironmentVariableTarget.Process);

            System.Environment.SetEnvironmentVariable("JAVA_HOME", java_home);//, EnvironmentVariableTarget.User);
            System.Environment.SetEnvironmentVariable("ANT_HOME", ant_home);//, EnvironmentVariableTarget.User);


            List<String> path = new List<string>();

            path.Add(pathOrg);
            path.Add(Path.Combine("%JAVA_HOME%", "bin"));
            path.Add(Path.Combine("%JAVA_HOME%", "lib"));
            path.Add(Path.Combine("%ANT_HOME%", "bin"));
            path.Add("%JAVA_HOME%");
            path.Add("%ANT_HOME%");
            path.Add(Path.Combine(java_home, "bin"));
            path.Add(Path.Combine(ant_home, "bin"));
            path.Add(Path.Combine(android_home, "tools"));
            path.Add(apktool_home);

            System.Text.StringBuilder paths = new System.Text.StringBuilder();

            foreach (string p in path)
            {
                paths.Append(p);
                paths.Append(";");
            }
            System.Environment.SetEnvironmentVariable("PATH", paths.ToString());
        }
    }


}
