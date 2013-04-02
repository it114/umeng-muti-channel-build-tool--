/*
 * Created by SharpDevelop.
 * User: Administrator
 * Date: 2012/7/17
 * Time: 13:42
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace UmengChannel
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.projects = new System.Windows.Forms.ListBox();
            this.tb_project = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.keystore_file_path = new System.Windows.Forms.Label();
            this.tb_alias = new System.Windows.Forms.TextBox();
            this.keystore_pw = new System.Windows.Forms.Label();
            this.tb_keystore = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_keystore_pw = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.channels = new System.Windows.Forms.ListBox();
            this.button3 = new System.Windows.Forms.Button();
            this.tb_input_channel_area = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label7 = new System.Windows.Forms.Label();
            this.key_pw = new System.Windows.Forms.Label();
            this.tb_key_pw = new System.Windows.Forms.TextBox();
            this.bt_open_project = new System.Windows.Forms.Button();
            this.bt_keystore_path = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.javahome = new System.Windows.Forms.Label();
            this.tb_java_path = new System.Windows.Forms.TextBox();
            this.bt_java_path = new System.Windows.Forms.Button();
            this.bt_delete_project = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_android_sdk_path = new System.Windows.Forms.TextBox();
            this.bt_android_sdk_path = new System.Windows.Forms.Button();
            this.label_hint = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabChangeLabelOnly = new System.Windows.Forms.TabPage();
            this.tbChangeLabelonlyValue = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tabChangeLabelXX = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabChangeLabelOnly.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // projects
            // 
            this.projects.FormattingEnabled = true;
            this.projects.Location = new System.Drawing.Point(1096, 49);
            this.projects.Name = "projects";
            this.projects.Size = new System.Drawing.Size(160, 420);
            this.projects.TabIndex = 0;
            this.projects.SelectedIndexChanged += new System.EventHandler(this.ProjectsSelectedIndexChanged);
            // 
            // tb_project
            // 
            this.tb_project.Location = new System.Drawing.Point(1076, 77);
            this.tb_project.Name = "tb_project";
            this.tb_project.ReadOnly = true;
            this.tb_project.Size = new System.Drawing.Size(210, 23);
            this.tb_project.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(1112, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "工程目录";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // keystore_file_path
            // 
            this.keystore_file_path.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.keystore_file_path.Location = new System.Drawing.Point(29, 18);
            this.keystore_file_path.Name = "keystore_file_path";
            this.keystore_file_path.Size = new System.Drawing.Size(86, 25);
            this.keystore_file_path.TabIndex = 3;
            this.keystore_file_path.Text = "alias";
            this.keystore_file_path.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tb_alias
            // 
            this.tb_alias.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_alias.Location = new System.Drawing.Point(118, 16);
            this.tb_alias.Name = "tb_alias";
            this.tb_alias.Size = new System.Drawing.Size(259, 23);
            this.tb_alias.TabIndex = 4;
            // 
            // keystore_pw
            // 
            this.keystore_pw.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.keystore_pw.Location = new System.Drawing.Point(29, 54);
            this.keystore_pw.Name = "keystore_pw";
            this.keystore_pw.Size = new System.Drawing.Size(85, 25);
            this.keystore_pw.TabIndex = 5;
            this.keystore_pw.Text = "keystore";
            this.keystore_pw.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tb_keystore
            // 
            this.tb_keystore.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_keystore.Location = new System.Drawing.Point(118, 52);
            this.tb_keystore.Name = "tb_keystore";
            this.tb_keystore.ReadOnly = true;
            this.tb_keystore.Size = new System.Drawing.Size(210, 23);
            this.tb_keystore.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(20, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "keystore_pw";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.label4.Click += new System.EventHandler(this.Label4Click);
            // 
            // tb_keystore_pw
            // 
            this.tb_keystore_pw.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_keystore_pw.Location = new System.Drawing.Point(118, 88);
            this.tb_keystore_pw.Name = "tb_keystore_pw";
            this.tb_keystore_pw.Size = new System.Drawing.Size(259, 23);
            this.tb_keystore_pw.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.ForeColor = System.Drawing.Color.DarkMagenta;
            this.label5.Location = new System.Drawing.Point(31, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 23);
            this.label5.TabIndex = 9;
            this.label5.Text = "选择APK:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(1096, 225);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 25);
            this.button1.TabIndex = 10;
            this.button1.Text = "删除渠道";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.Location = new System.Drawing.Point(835, 27);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 25);
            this.button2.TabIndex = 11;
            this.button2.Text = "查看生成的APK";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2Click);
            // 
            // channels
            // 
            this.channels.FormattingEnabled = true;
            this.channels.Location = new System.Drawing.Point(1051, 153);
            this.channels.Name = "channels";
            this.channels.Size = new System.Drawing.Size(214, 316);
            this.channels.TabIndex = 12;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button3.Location = new System.Drawing.Point(117, 130);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(133, 39);
            this.button3.TabIndex = 13;
            this.button3.Text = "开始打包";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3Click);
            // 
            // tb_input_channel_area
            // 
            this.tb_input_channel_area.Location = new System.Drawing.Point(1082, 236);
            this.tb_input_channel_area.Name = "tb_input_channel_area";
            this.tb_input_channel_area.Size = new System.Drawing.Size(196, 23);
            this.tb_input_channel_area.TabIndex = 14;
            this.tb_input_channel_area.TabStop = false;
            this.tb_input_channel_area.Enter += new System.EventHandler(this.Tb_input_channel_areaEnter);
            this.tb_input_channel_area.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBox5KeyDown);
            this.tb_input_channel_area.Leave += new System.EventHandler(this.Tb_input_channel_areaLeave);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(1150, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 18);
            this.label6.TabIndex = 15;
            this.label6.Text = "工程名称";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(147, 36);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(659, 11);
            this.progressBar1.TabIndex = 16;
            this.progressBar1.Visible = false;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(1112, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 21);
            this.label7.TabIndex = 17;
            this.label7.Text = "密钥配置";
            // 
            // key_pw
            // 
            this.key_pw.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.key_pw.Location = new System.Drawing.Point(33, 122);
            this.key_pw.Name = "key_pw";
            this.key_pw.Size = new System.Drawing.Size(82, 25);
            this.key_pw.TabIndex = 18;
            this.key_pw.Text = "key_pw";
            this.key_pw.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tb_key_pw
            // 
            this.tb_key_pw.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_key_pw.Location = new System.Drawing.Point(118, 122);
            this.tb_key_pw.Name = "tb_key_pw";
            this.tb_key_pw.Size = new System.Drawing.Size(259, 23);
            this.tb_key_pw.TabIndex = 19;
            // 
            // bt_open_project
            // 
            this.bt_open_project.Enabled = false;
            this.bt_open_project.Location = new System.Drawing.Point(1190, 7);
            this.bt_open_project.Name = "bt_open_project";
            this.bt_open_project.Size = new System.Drawing.Size(66, 25);
            this.bt_open_project.TabIndex = 20;
            this.bt_open_project.Text = "==>选";
            this.bt_open_project.UseVisualStyleBackColor = true;
            this.bt_open_project.Click += new System.EventHandler(this.Bt_open_projectClick);
            // 
            // bt_keystore_path
            // 
            this.bt_keystore_path.Location = new System.Drawing.Point(337, 50);
            this.bt_keystore_path.Name = "bt_keystore_path";
            this.bt_keystore_path.Size = new System.Drawing.Size(41, 25);
            this.bt_keystore_path.TabIndex = 21;
            this.bt_keystore_path.Text = "....";
            this.bt_keystore_path.UseVisualStyleBackColor = true;
            this.bt_keystore_path.Click += new System.EventHandler(this.Bt_keystore_pathClick);
            // 
            // checkBox1
            // 
            this.checkBox1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkBox1.Location = new System.Drawing.Point(307, 68);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(71, 26);
            this.checkBox1.TabIndex = 22;
            this.checkBox1.Text = "混淆";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(1136, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 19);
            this.label2.TabIndex = 23;
            this.label2.Text = "系统配置";
            // 
            // javahome
            // 
            this.javahome.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.javahome.Location = new System.Drawing.Point(71, 28);
            this.javahome.Name = "javahome";
            this.javahome.Size = new System.Drawing.Size(75, 18);
            this.javahome.TabIndex = 24;
            this.javahome.Text = "Java 路径";
            this.javahome.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tb_java_path
            // 
            this.tb_java_path.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_java_path.Location = new System.Drawing.Point(149, 24);
            this.tb_java_path.Name = "tb_java_path";
            this.tb_java_path.ReadOnly = true;
            this.tb_java_path.Size = new System.Drawing.Size(210, 23);
            this.tb_java_path.TabIndex = 25;
            // 
            // bt_java_path
            // 
            this.bt_java_path.Location = new System.Drawing.Point(368, 21);
            this.bt_java_path.Name = "bt_java_path";
            this.bt_java_path.Size = new System.Drawing.Size(41, 25);
            this.bt_java_path.TabIndex = 26;
            this.bt_java_path.Text = "...";
            this.bt_java_path.UseVisualStyleBackColor = true;
            this.bt_java_path.Click += new System.EventHandler(this.Bt_java_pathClick);
            // 
            // bt_delete_project
            // 
            this.bt_delete_project.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bt_delete_project.Location = new System.Drawing.Point(1096, 10);
            this.bt_delete_project.Name = "bt_delete_project";
            this.bt_delete_project.Size = new System.Drawing.Size(87, 27);
            this.bt_delete_project.TabIndex = 27;
            this.bt_delete_project.Text = "删除工程";
            this.bt_delete_project.UseVisualStyleBackColor = true;
            this.bt_delete_project.Click += new System.EventHandler(this.Bt_delete_projectClick);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(11, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 19);
            this.label3.TabIndex = 28;
            this.label3.Text = "Android SDK 路径";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tb_android_sdk_path
            // 
            this.tb_android_sdk_path.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_android_sdk_path.Location = new System.Drawing.Point(149, 54);
            this.tb_android_sdk_path.Name = "tb_android_sdk_path";
            this.tb_android_sdk_path.ReadOnly = true;
            this.tb_android_sdk_path.Size = new System.Drawing.Size(210, 23);
            this.tb_android_sdk_path.TabIndex = 29;
            // 
            // bt_android_sdk_path
            // 
            this.bt_android_sdk_path.Location = new System.Drawing.Point(368, 52);
            this.bt_android_sdk_path.Name = "bt_android_sdk_path";
            this.bt_android_sdk_path.Size = new System.Drawing.Size(41, 25);
            this.bt_android_sdk_path.TabIndex = 30;
            this.bt_android_sdk_path.Text = "...";
            this.bt_android_sdk_path.UseVisualStyleBackColor = true;
            this.bt_android_sdk_path.Click += new System.EventHandler(this.Bt_android_sdk_pathClick);
            // 
            // label_hint
            // 
            this.label_hint.BackColor = System.Drawing.Color.Bisque;
            this.label_hint.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_hint.Enabled = false;
            this.label_hint.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_hint.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label_hint.Location = new System.Drawing.Point(1082, 236);
            this.label_hint.Name = "label_hint";
            this.label_hint.Size = new System.Drawing.Size(193, 20);
            this.label_hint.TabIndex = 31;
            this.label_hint.Text = "输入渠道名称，然后回车";
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(1082, 215);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 16);
            this.label9.TabIndex = 32;
            this.label9.Text = "添加渠道";
            // 
            // button4
            // 
            this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.Location = new System.Drawing.Point(119, 58);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(38, 41);
            this.button4.TabIndex = 33;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tb_keystore_pw);
            this.groupBox1.Controls.Add(this.keystore_file_path);
            this.groupBox1.Controls.Add(this.tb_alias);
            this.groupBox1.Controls.Add(this.keystore_pw);
            this.groupBox1.Controls.Add(this.tb_keystore);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.key_pw);
            this.groupBox1.Controls.Add(this.tb_key_pw);
            this.groupBox1.Controls.Add(this.bt_keystore_path);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.groupBox1.Location = new System.Drawing.Point(50, 87);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(435, 164);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "签名配置";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bt_android_sdk_path);
            this.groupBox2.Controls.Add(this.javahome);
            this.groupBox2.Controls.Add(this.tb_java_path);
            this.groupBox2.Controls.Add(this.bt_java_path);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.tb_android_sdk_path);
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.groupBox2.Location = new System.Drawing.Point(50, 272);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(435, 112);
            this.groupBox2.TabIndex = 37;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "运行环境配置";
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("华文行楷", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label10.Location = new System.Drawing.Point(29, 33);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 23);
            this.label10.TabIndex = 39;
            this.label10.Text = "打包进度";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label13.Location = new System.Drawing.Point(234, 481);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(458, 13);
            this.label13.TabIndex = 41;
            this.label13.Text = "提示：打包之后，要反编译看对不对，并且要经过在友盟、talking data测试才可以发布";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabChangeLabelOnly);
            this.tabControl1.Controls.Add(this.tabChangeLabelXX);
            this.tabControl1.Location = new System.Drawing.Point(6, 21);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(434, 271);
            this.tabControl1.TabIndex = 39;
            // 
            // tabChangeLabelOnly
            // 
            this.tabChangeLabelOnly.Controls.Add(this.label11);
            this.tabChangeLabelOnly.Controls.Add(this.tbChangeLabelonlyValue);
            this.tabChangeLabelOnly.Controls.Add(this.label8);
            this.tabChangeLabelOnly.Controls.Add(this.button3);
            this.tabChangeLabelOnly.Controls.Add(this.label5);
            this.tabChangeLabelOnly.Controls.Add(this.button4);
            this.tabChangeLabelOnly.Controls.Add(this.checkBox1);
            this.tabChangeLabelOnly.Location = new System.Drawing.Point(4, 22);
            this.tabChangeLabelOnly.Name = "tabChangeLabelOnly";
            this.tabChangeLabelOnly.Padding = new System.Windows.Forms.Padding(3);
            this.tabChangeLabelOnly.Size = new System.Drawing.Size(426, 245);
            this.tabChangeLabelOnly.TabIndex = 1;
            this.tabChangeLabelOnly.Text = "只改变标签";
            this.tabChangeLabelOnly.UseVisualStyleBackColor = true;
            // 
            // tbChangeLabelonlyValue
            // 
            this.tbChangeLabelonlyValue.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbChangeLabelonlyValue.Location = new System.Drawing.Point(119, 26);
            this.tbChangeLabelonlyValue.Name = "tbChangeLabelonlyValue";
            this.tbChangeLabelonlyValue.Size = new System.Drawing.Size(259, 23);
            this.tbChangeLabelonlyValue.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(6, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 25);
            this.label8.TabIndex = 9;
            this.label8.Text = "标签名称：";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tabChangeLabelXX
            // 
            this.tabChangeLabelXX.Location = new System.Drawing.Point(4, 22);
            this.tabChangeLabelXX.Name = "tabChangeLabelXX";
            this.tabChangeLabelXX.Padding = new System.Windows.Forms.Padding(3);
            this.tabChangeLabelXX.Size = new System.Drawing.Size(426, 245);
            this.tabChangeLabelXX.TabIndex = 2;
            this.tabChangeLabelXX.Text = "改变xxx";
            this.tabChangeLabelXX.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tabControl1);
            this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.groupBox3.Location = new System.Drawing.Point(546, 87);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(446, 297);
            this.groupBox3.TabIndex = 38;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "业务配置";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(163, 73);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 13);
            this.label11.TabIndex = 34;
            this.label11.Text = "Tip:支持多选";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 516);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label_hint);
            this.Controls.Add(this.bt_delete_project);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bt_open_project);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tb_input_channel_area);
            this.Controls.Add(this.channels);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_project);
            this.Controls.Add(this.projects);
            this.Font = new System.Drawing.Font("华文楷体", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.Text = "Mes内部Android渠道打包工具";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabChangeLabelOnly.ResumeLayout(false);
            this.tabChangeLabelOnly.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}
        private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label_hint;
		private System.Windows.Forms.TextBox tb_android_sdk_path;
		private System.Windows.Forms.Button bt_android_sdk_path;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button bt_delete_project;
		private System.Windows.Forms.Button bt_java_path;
		private System.Windows.Forms.TextBox tb_java_path;
		private System.Windows.Forms.Label javahome;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.Button bt_keystore_path;
		private System.Windows.Forms.Button bt_open_project;
		private System.Windows.Forms.TextBox tb_key_pw;
		private System.Windows.Forms.Label key_pw;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.ProgressBar progressBar1;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox tb_input_channel_area;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.ListBox channels;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox tb_keystore_pw;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox tb_keystore;
		private System.Windows.Forms.Label keystore_pw;
		private System.Windows.Forms.TextBox tb_alias;
		private System.Windows.Forms.Label keystore_file_path;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox tb_project;
		private System.Windows.Forms.ListBox projects;
		
		void Label4Click(object sender, System.EventArgs e)
		{
			
		}

        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabChangeLabelOnly;
        private System.Windows.Forms.TextBox tbChangeLabelonlyValue;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TabPage tabChangeLabelXX;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label11;
	}
}
