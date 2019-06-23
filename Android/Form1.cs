using Ionic.Zip;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

//Hi 这个项目会持续更新，如果各位有更好的建议或觉得哪儿有问题可以在Github上直接修改或指出。
//该版本比较拙劣，代码也没有梳理清晰。
//致敬

namespace Android
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            req.Text = "当前版本:Android-packinfo-1\r\n原理就是检测包内的so和dex里的类名来判断加固的厂商\r\n软件源码：github搜索Android-packinfo 第一次写C#，轻喷\r\n推荐脱壳工具：\r\nFrida-android-unpack：https://bbs.pediy.com/thread-251707.htm \r\nFDEX2:https://bbs.pediy.com/thread-224105.htm \r\n如发现识别不了的加固方式请将样本或so及类名提交到帖子下方或在源码更改，我会及时更新";
        }

        private void Form1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.All;
            }else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void Form1_DragDrop(object sender, DragEventArgs e)
        {
            string path = ((System.Array)e.Data.GetData(DataFormats.FileDrop)).GetValue(0).ToString();
            apkpath.Text = path;
            DoApkinfo();
        }

        //处理APK、
        private void DoApkinfo()
        {
            if(!apkpath.Text.Contains(".apk") || !File.Exists(apkpath.Text))
            {
                req.Text = "\r\n \r\nApk解析错误 路径："+apkpath.Text+"\r\n1：文件可能不存在\r\n2：只接受后缀为APK的文件";
                return;
            }
            req.Text = "";
            req.Text = "\r\n当前处理Apk路径:" + apkpath.Text +"\r\n";
            apkinfo(apkpath.Text);
            Thread t1 = new Thread(new ParameterizedThreadStart(this.howso));
            t1.Start(apkpath.Text);
        }

        //获取APK的一些信息--下个版本加强，目前jar环境处理中。
        private void apkinfo(string filePath)
        {
            FileInfo f = new FileInfo(filePath);
            req.Text += "Apk大小："+f.Length+"\r\n编译Time:"+ f.CreationTime.ToShortDateString()+"\r\n";
        }

        private void howso(object filepath)
        {
            req.Text += "\r\n开始分析So文件特征";
            //定义加固so特征 -- 虽然我不知道为什么这么写，但是我感觉我的大脑限制了我。 fuck code
            string[,] soke = new string[22,6]; //定义加固特征数组
            string Fstring = ""; //定义临时APK文件信息
            string sojiagurequest = ""; //定义结果
            bool jiagutype = false;
            
            //360
            soke[0, 0] = "360加固";
            soke[0, 1] = "assets/libjiagu_x86.so";
            soke[0, 2] = "assets/.appkey";
            //爱加密
            soke[1, 0] = "爱加密";
            soke[1, 1] = "lib/armeabi/libexecmain.so";
            soke[1, 2] = "assets/ijiami.ajm";
            soke[1, 3] = "assets/ijm_lib/x86/libexec.so";
            //几维安全
            soke[2, 0] = "几维安全";
            soke[2, 1] = "lib/armeabi/kdpdata.so";
            soke[2, 2] = "lib/armeabi/libkwscmm.so";
            //娜迦
            soke[3, 0] = "娜迦";
            soke[3, 1] = "libchaosvmp.so";
            soke[3, 2] = "libddog.so";
            //梆梆企业版
            soke[4, 0] = "梆梆企业版";
            soke[4, 1] = "assets/meta-data/manifest.mf";
            soke[4, 2] = "assets/meta-data/rsa.pub";
            //邦邦-免费版
            soke[5, 0] = "邦邦-免费版";
            soke[5, 1] = "secData0.jar";
            soke[5, 2] = "libSecShell.so";
            soke[5, 3] = "libsecmain.so";
            //通付盾
            soke[6, 0] = "通付盾";
            soke[6, 1] = "libegis.so";
            soke[6, 2] = "libNSaferOnly.so";
            //网秦
            soke[7, 0] = "网秦";
            soke[7, 1] = "libnqshield.so";
            //百度应用加固
            soke[8, 0] = "百度应用加固";
            soke[8, 1] = "lib/armeabi/libbaiduprotect.so";
            soke[8, 2] = "assets/libbaiduprotect_x86";
            soke[8, 3] = "assets/baiduprotect1.jar";
            //腾讯御安全
            soke[9, 0] = "腾讯御安全";
            soke[9, 1] = "libtosprotection.x86.so";
            soke[9, 2] = "libtosprotection.armeabi-v7a.so";
            soke[9, 3] = "tosversion";
            //APKProtect
            soke[10, 0] = "APKProtect";
            soke[10, 1] = "libAPKProtect.so";
            //顶象科技
            soke[11, 0] = "顶象科技";
            soke[11, 1] = "libmisc-ld.so";
            soke[11, 2] = "assets/libcsn_x86.so";
            //阿里加固
            soke[12, 0] = "阿里加固";
            soke[12, 1] = "libsgsecuritybody.so";
            soke[12, 2] = "libpreverify1.so";
            //海云安加固
            soke[13, 0] = "海云安加固";
            soke[13, 1] = "libitsec.so";
            soke[13, 2] = "lib/armeabi/libapktoolplus_jiagu.so";
            //UU安全
            soke[14, 0] = "UU安全";
            soke[14, 1] = "libuusafe.jar.so";
            soke[14, 2] = "libuusafe.so";
            //DexProtect加固
            soke[15, 0] = "DexProtect加固";
            soke[15, 1] = "dp.arm-v7.so.dat";
            soke[15, 2] = "dp.arm.so.dat";
            //中国移动加固
            soke[16, 0] = "中国移动加固";
            soke[16, 1] = "libmogosec_sodecrypt.so";
            soke[16, 2] = "libcmvmp.so";
            //珊瑚灵御
            soke[17, 0] = "珊瑚灵御";
            soke[17, 1] = "libreincp.so";
            //乐固
            soke[18, 0] = "乐固";
            soke[18, 1] = "lib/armeabi/libBugly.so";
            soke[18, 2] = "lib/armeabi/libshellx-3.0.0.0.so";
            //apktoolplus
            soke[19, 0] = "apktoolplus";
            soke[19, 1] = "libapktoolplus_jiagu.so";
            //瑞星加固
            soke[20, 0] = "瑞星加固";
            soke[20, 1] = "librsprotect.so";
            //盛大加固
            soke[21, 0] = "盛大加固";
            soke[21, 1] = "libapssec.so";

            //循环取APk内的全部文件信息，然后放入变量中


            using (ZipFile zip = ZipFile.Read(filepath.ToString()))
            {
                foreach (ZipEntry e in zip)
                {
                    Fstring += " "+e.FileName;
                }
            }


            for (int i = 0; i < soke.GetLength(0); i++)
            {

                for (int j = 0; j < soke.GetLength(1); j++)

                {
                    if(soke[i, j] != null)
                    {
                        if (Fstring.Contains(soke[i, j]))
                        {
                            req.Text += "\r\n报告，So探测发现疑似加固，疑似加固类型："+soke[i, 0] +"-----time:"+ DateTime.Now.ToString()+"\r\n若So不精准请参考下方的dex入口探测";
                            jiagutype = true;
                        }
                    }
                }
            }
            if(jiagutype == false)
            {
                req.Text += "\r\n当前APKso处理没有发现加固或加固是未知的。";
            }
        }

        //该内容下个版本添加
        private void howdex(object filepath)
        {
            return;
        }

        private void skinButton1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Multiselect = false;//该值确定是否可以选择多个文件
            dialog.Title = "请选择Apk";
            dialog.Filter = "安卓Apk(*.Apk)|*.apk";
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string file = dialog.FileName;
                apkpath.Text = file;
                DoApkinfo();
            }
        }
    }
}
