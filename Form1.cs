using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        List<String> liste = new List<string>();

        String gelen_yol = "";
        public string[] gelen = new string[50];

        public Form1()
        {
            InitializeComponent();
        }
        public void Secim()
        {
            liste.Clear();
            listView.Items.Clear();
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                txtPath.Text = fbd.SelectedPath;
                gelen_yol = fbd.SelectedPath;
                foreach (string item in Directory.GetFiles(fbd.SelectedPath))
                {
                    ımageList.Images.Add(System.Drawing.Icon.ExtractAssociatedIcon(item));
                    FileInfo fi = new FileInfo(item);
                    liste.Add(fi.FullName);
                    listView.Items.Add(fi.Name, ımageList.Images.Count - 1);
                }
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            Secim();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void newFile_Click(object sender, EventArgs e)
        {
            try
            {
                string kubilay_bozak = gelen_yol + @"\Logs";
                System.Diagnostics.Process.Start(kubilay_bozak);
            }

            catch
            {
                MessageBox.Show(gelen_yol + " Adı altında bir log dosyası bulunamadı. Lütfen doğru" +
                    "Dosya yolunu seçtiğinizden emin olun ! ");
            }

        }

        private void ChangeCell_Click(object sender, EventArgs e)
        {
            string[] files = Directory.GetFiles(gelen_yol);
            for (int i = 0; i < files.Length; i++)
            {
                Directory.CreateDirectory(files[i]);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        List<String> alt_klasör = new List<string>();
        private void L800_Click(object sender, EventArgs e)
        {
            int count = 0;
            Elements.Items.Clear();
            String asd = gelen_yol;
            string[] dsfss = Directory.GetDirectories(asd);

            if (Directory.Exists(gelen_yol + @"\Logs"))
            {
                Directory.Delete(gelen_yol + @"\Logs", true); //EĞER DAHA ÖNCE LOG DOSYASI VAR İSE SONU SİLİYORUZ. 
            }


            String asd3 = gelen_yol + "/" + "logs";
            Directory.CreateDirectory(asd3);                   //Kendimiz bos bir Log dosyası oluşturuyoruz .
            foreach (string i in dsfss)
            {
                Elements.Items.Add(i);
                count++;
                FileInfo info3 = new FileInfo(i);
                String cell1_yeni1 = gelen_yol + "\\" + "hhhh1";  //S1 olarak ayarlanan bir dosyanın adı önce hhh1 olarak ayarlanacak.
                String cell2_yeni2 = gelen_yol + "\\" + "hhhh2";  //s2 olarak ayarlanan bir dosyanın adı sonra hh2 olarak ayarlanacak.
                String cell3_yeni3 = gelen_yol + "\\" + "hhhh3";  //s3 olarak ayarlanan bir dosyanın adı önce hh3 olarak ayarlanacak.
                if (info3.Name.IndexOf("1") != -1)                //Dosyanın adında 1 geçiyor ise.
                {

                    String cell1_gelen = gelen_yol + "\\" + info3.Name; //Bu dosyanın konumu.
                    String cell1_yeni = gelen_yol + "\\" + "s1";        //Dosyanın adının s1 olması için gereken kod.

                    Directory.Move(cell1_gelen, cell1_yeni1);      //gelen dosya x olsun biz bunu önce hhhh1 yapıyoruz.
                    Directory.Move(cell1_yeni1, cell1_yeni);       //daha sonra hhh1 olan dosyanın adını s1 olarak ayarlıyoruz.



                    foreach (string str4 in Directory.GetFiles(cell1_yeni))
                    {
                        Elements.Items.Add(str4);               //Dosyanın işleme alındığını ekranda gösteriyor.
                        FileInfo info4 = new FileInfo(str4);    //

                        if (info4.Name.IndexOf("ping") != -1)
                        {
                            String ping_gelen = gelen_yol + "\\" + "s1" + "\\" + info4.Name;
                            String ping_yeni = gelen_yol + @"\Logs" + "\\" + "st1_ping_800.trp";
                            File.Copy(ping_gelen, ping_yeni);   //s1 adı altında olan ping içeren dosyayı yeniden adlandırmak için.


                        }
                        else if (info4.Name.IndexOf("dl") != -1 || info4.Name.IndexOf("DL") != -1 || info4.Name.IndexOf("Dl") != -1 || info4.Name.IndexOf("dL") != -1)
                        {
                            String dl_gelen = gelen_yol + "\\" + "s1" + "\\" + info4.Name;
                            String dl_yeni = gelen_yol + @"\Logs" + "\\" + "st1_dl_800.trp";
                            File.Copy(dl_gelen, dl_yeni);  ////s1 adı altında olan dl içeren dosyayı yeniden adlandırmak için.

                        }
                        else if (info4.Name.IndexOf("ul") != -1 || info4.Name.IndexOf("UL") != -1 || info4.Name.IndexOf("Ul") != -1 || info4.Name.IndexOf("uL") != -1)
                        {

                            String ul_gelen = gelen_yol + "\\" + "s1" + "\\" + info4.Name;
                            String ul_yeni = gelen_yol + @"\Logs" + "\\" + "st1_ul_800.trp";
                            File.Copy(ul_gelen, ul_yeni);  //s1 adı altında olan UL içeren dosyayı yeniden adlandırmak için.

                        }
                        else if (((info4.Name.IndexOf("CSFB") != -1) || (info4.Name.IndexOf("4G4G") != -1)))
                        {
                            String CSFB_gelen = gelen_yol + "\\" + "s1" + "\\" + info4.Name;
                            String CSFB_yeni = gelen_yol + @"\Logs" + "\\" + "st1_vc_800.trp";
                            File.Copy(CSFB_gelen, CSFB_yeni);   //s1 adı altında olan CSFB içeren dosyayı yeniden adlandırmak için.

                        }

                        else if (((info4.Name.IndexOf("Volte") != -1) || (info4.Name.IndexOf("volte") != -1)) || (info4.Name.IndexOf("VOLTE") != -1) || (info4.Name.IndexOf("volte") != -1))
                        {
                            String Volte_gelen = gelen_yol + "\\" + "s1" + "\\" + info4.Name;
                            String Volte_yeni = gelen_yol + @"\Logs" + "\\" + "st1_volte.trp";
                            File.Copy(Volte_gelen, Volte_yeni);    //s1 adı altında olan CSFB içeren dosyayı yeniden adlandırmak için

                        }


                    }
                }
                else if (info3.Name.IndexOf("2") != -1)
                {

                    String cell2_gelen = gelen_yol + "\\" + info3.Name;
                    String cell2_yeni = gelen_yol + "\\" + "s2";


                    Directory.Move(cell2_gelen, cell2_yeni2);
                    Directory.Move(cell2_yeni2, cell2_yeni);


                    foreach (string str4 in Directory.GetFiles(cell2_yeni))
                    {
                        Elements.Items.Add(str4);
                        FileInfo info4 = new FileInfo(str4);

                        if (info4.Name.IndexOf("ping") != -1)
                        {
                            String ping_gelen = gelen_yol + "\\" + "s2" + "\\" + info4.Name;
                            String ping_yeni = gelen_yol + @"\Logs" + "\\" + "st2_ping_800.trp";
                            File.Copy(ping_gelen, ping_yeni);
                        }
                        else if (info4.Name.IndexOf("dl") != -1 || info4.Name.IndexOf("DL") != -1 || info4.Name.IndexOf("Dl") != -1 || info4.Name.IndexOf("dL") != -1)
                        {
                            String dl_gelen = gelen_yol + "\\" + "s2" + "\\" + info4.Name;
                            String dl_yeni = gelen_yol + @"\Logs" + "\\" + "st2_dl_800.trp";
                            File.Copy(dl_gelen, dl_yeni);
                        }

                        else if (info4.Name.IndexOf("ul") != -1 || info4.Name.IndexOf("UL") != -1 || info4.Name.IndexOf("Ul") != -1 || info4.Name.IndexOf("uL") != -1)
                        {
                            String ul_gelen = gelen_yol + "\\" + "s2" + "\\" + info4.Name;
                            String ul_yeni = gelen_yol + @"\Logs" + "\\" + "st2_ul_800.trp";
                            File.Copy(ul_gelen, ul_yeni);
                        }

                        else if (((info4.Name.IndexOf("CSFB") != -1) || (info4.Name.IndexOf("4G4G") != -1)))
                        {
                            String CSFB_gelen = gelen_yol + "\\" + "s2" + "\\" + info4.Name;
                            String CSFB_yeni = gelen_yol + @"\Logs" + "\\" + "st2_vc_800.trp";
                            File.Copy(CSFB_gelen, CSFB_yeni);
                        }

                        else if (((info4.Name.IndexOf("Volte") != -1) || (info4.Name.IndexOf("volte") != -1)) || (info4.Name.IndexOf("VOLTE") != -1))
                        {
                            String Volte_gelen = gelen_yol + "\\" + "s2" + "\\" + info4.Name;
                            String Volte_yeni = gelen_yol + @"\Logs" + "\\" + "st2_volte.trp";
                            File.Copy(Volte_gelen, Volte_yeni);
                        }


                    }





                }
                else if (info3.Name.IndexOf("3") != -1)
                {

                    String cell3_gelen = gelen_yol + "\\" + info3.Name;
                    String cell3_yeni = gelen_yol + "\\" + "s3";
                    Directory.Move(cell3_gelen, cell3_yeni3);
                    Directory.Move(cell3_yeni3, cell3_yeni);


                    foreach (string str4 in Directory.GetFiles(cell3_yeni))
                    {
                        Elements.Items.Add(str4);
                        FileInfo info4 = new FileInfo(str4);

                        if (info4.Name.IndexOf("ping") != -1)
                        {
                            String ping_gelen = gelen_yol + "\\" + "s3" + "\\" + info4.Name;
                            String ping_yeni = gelen_yol + @"\Logs" + "\\" + "st3_ping_800.trp";
                            File.Copy(ping_gelen, ping_yeni);
                        }
                        else if (info4.Name.IndexOf("dl") != -1 || info4.Name.IndexOf("DL") != -1 || info4.Name.IndexOf("Dl") != -1 || info4.Name.IndexOf("dL") != -1)
                        {
                            String dl_gelen = gelen_yol + "\\" + "s3" + "\\" + info4.Name;
                            String dl_yeni = gelen_yol + @"\Logs" + "\\" + "st3_dl_800.trp";
                            File.Copy(dl_gelen, dl_yeni);
                        }

                        else if (info4.Name.IndexOf("ul") != -1 || info4.Name.IndexOf("UL") != -1 || info4.Name.IndexOf("Ul") != -1 || info4.Name.IndexOf("uL") != -1)
                        {
                            String ul_gelen = gelen_yol + "\\" + "s3" + "\\" + info4.Name;
                            String ul_yeni = gelen_yol + @"\Logs" + "\\" + "st3_ul_800.trp";
                            File.Copy(ul_gelen, ul_yeni);
                        }

                        else if (((info4.Name.IndexOf("CSFB") != -1) || (info4.Name.IndexOf("4G4G") != -1)))
                        {
                            String CSFB_gelen = gelen_yol + "\\" + "s3" + "\\" + info4.Name;
                            String CSFB_yeni = gelen_yol + @"\Logs" + "\\" + "st3_vc_800.trp";
                            File.Copy(CSFB_gelen, CSFB_yeni);
                        }

                        else if (((info4.Name.IndexOf("Volte") != -1) || (info4.Name.IndexOf("volte") != -1)) || (info4.Name.IndexOf("VOLTE") != -1))
                        {
                            String Volte_gelen = gelen_yol + "\\" + "s3" + "\\" + info4.Name;
                            String Volte_yeni = gelen_yol + @"\Logs" + "\\" + "st3_volte.trp";
                            File.Copy(Volte_gelen, Volte_yeni);
                        }


                    }
                }
                else { MessageBox.Show(" Dosya isimlerini Kontrol edin ! ve doğru dosya uzantısını Kullandığınızdan emin olun ! "); }
            }




            try
            {
                if (Directory.Exists(gelen_yol + @"\Mobility"))   //Seçilen yolda var ise.
                {
                    int counter2 = 1;
                    string gelen_mob = gelen_yol + @"\Mobility";
                    string gidecek_mob = gelen_yol + @"\Logs";
                    string[] dosya_var = Directory.GetFiles(gelen_mob);
                    foreach (string i in dosya_var)
                    {
                        String a = i.ToUpper();
                        if (a.IndexOf(".JPG") != -1 || a.IndexOf(".png") != -1 || a.IndexOf(".JPEG") != -1 || a.IndexOf(".PNG") != -1)
                        {
                            continue;
                        }
                        else
                        {
                            if (counter2 == 1)
                            {
                                String mob_change_name = gelen_yol + @"\Logs" + "\\" + "mobility_800.trp";
                                File.Copy(i, mob_change_name);
                                counter2++;
                                Elements.Items.Add(i);
                            }
                            else
                            {
                                String mob_change_name = gelen_yol + @"\Logs" + "\\" + "mobility_800_" + counter2 + ".trp";
                                File.Copy(i, mob_change_name);
                                counter2++;
                                Elements.Items.Add(i);
                            }
                        }

                    }
                }

                else //Dosya olarark ayarlanmamış dağınık bırakılmış ise 
                {    

                    string[] dosya_var = Directory.GetFiles(gelen_yol);
                    int counter2 = 1;
                    foreach (string i in dosya_var)
                    {
                        if (counter2 == 1)
                        {
                            String mob_change_name = gelen_yol + @"\Logs" + "\\" + "mobility_800.trp";
                            File.Copy(i, mob_change_name);
                            counter2++;
                            Elements.Items.Add(i);
                        }
                        else
                        {
                            String mob_change_name = gelen_yol + @"\Logs" + "\\" + "mobility_800_" + counter2 + ".trp";
                            File.Copy(i, mob_change_name);
                            counter2++;
                            Elements.Items.Add(i);
                        }
                    }
                }

               
            }

            catch  {  MessageBox.Show("Mobility dosyalarında hata olabilir kontrol edin. !! "); }


        }
    


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e) { }

        private void L1800Name_Click(object sender, EventArgs e)
        {
            
                int counter = 0;
                Elements.Items.Clear();
                String gelen_dosya_yolu = gelen_yol;
                string[] sahip = Directory.GetDirectories(gelen_dosya_yolu);

                if (Directory.Exists(gelen_yol + @"\Logs"))
                {
                    Directory.Delete(gelen_yol + @"\Logs", true); //EĞER DAHA ÖNCE LOG DOSYASI VAR İSE SONU SİLİYORUZ. 
                }


                String gelen_dosya_yolu3 = gelen_yol + "/" + "logs";
                Directory.CreateDirectory(gelen_dosya_yolu3);                   //Kendimiz bos bir Log dosyası oluşturuyoruz .
                foreach (string j in sahip)
                {
                    Elements.Items.Add(j);
                    counter++;
                    FileInfo info3 = new FileInfo(j);
                    String cell1_yeni1 = gelen_yol + "\\" + "hhhh1";  //S1 olarak ayarlanan bir dosyanın adı önce hhh1 olarak ayarlanacak.
                    String cell2_yeni2 = gelen_yol + "\\" + "hhhh2";  //s2 olarak ayarlanan bir dosyanın adı sonra hh2 olarak ayarlanacak.
                    String cell3_yeni3 = gelen_yol + "\\" + "hhhh3";  //s3 olarak ayarlanan bir dosyanın adı önce hh3 olarak ayarlanacak.
                   
                    if (info3.Name.IndexOf("1") != -1)                //Dosyanın adında 1 geçiyor ise.
                    {

                        String cell1_gelen = gelen_yol + "\\" + info3.Name; //Bu dosyanın konumu.
                        String cell1_yeni = gelen_yol + "\\" + "s1";        //Dosyanın adının s1 olması için gereken kod.

                        Directory.Move(cell1_gelen, cell1_yeni1);      //gelen dosya x olsun biz bunu önce hhhh1 yapıyoruz.
                        Directory.Move(cell1_yeni1, cell1_yeni);       //daha sonra hhh1 olan dosyanın adını s1 olarak ayarlıyoruz.



                        foreach (string str4 in Directory.GetFiles(cell1_yeni))
                        {
                            Elements.Items.Add(str4);               //Dosyanın işleme alındığını ekranda gösteriyor.
                            FileInfo info4 = new FileInfo(str4);    //

                            if (info4.Name.IndexOf("ping") != -1)
                            {
                                String ping_gelen = gelen_yol + "\\" + "s1" + "\\" + info4.Name;
                                String ping_yeni = gelen_yol + @"\Logs" + "\\" + "st1_ping_1800.trp";
                                File.Copy(ping_gelen, ping_yeni);   //s1 adı altında olan ping içeren dosyayı yeniden adlandırmak için.


                            }
                            else if (info4.Name.IndexOf("dl") != -1 || info4.Name.IndexOf("DL") != -1 || info4.Name.IndexOf("Dl") != -1 || info4.Name.IndexOf("dL") != -1)
                            {
                                String dl_gelen = gelen_yol + "\\" + "s1" + "\\" + info4.Name;
                                String dl_yeni = gelen_yol + @"\Logs" + "\\" + "st1_dl_1800.trp";
                                File.Copy(dl_gelen, dl_yeni);  ////s1 adı altında olan dl içeren dosyayı yeniden adlandırmak için.

                            }
                            else if (info4.Name.IndexOf("ul") != -1 || info4.Name.IndexOf("UL") != -1 || info4.Name.IndexOf("Ul") != -1 || info4.Name.IndexOf("uL") != -1)
                            {

                                String ul_gelen = gelen_yol + "\\" + "s1" + "\\" + info4.Name;
                                String ul_yeni = gelen_yol + @"\Logs" + "\\" + "st1_ul_1800.trp";
                                File.Copy(ul_gelen, ul_yeni);  //s1 adı altında olan UL içeren dosyayı yeniden adlandırmak için.

                            }
                        else if (((info4.Name.IndexOf("CSFB") != -1) || (info4.Name.IndexOf("4G4G") != -1)))
                        {
                                String CSFB_gelen = gelen_yol + "\\" + "s1" + "\\" + info4.Name;
                                String CSFB_yeni = gelen_yol + @"\Logs" + "\\" + "st1_vc_1800.trp";
                                File.Copy(CSFB_gelen, CSFB_yeni);   //s1 adı altında olan CSFB içeren dosyayı yeniden adlandırmak için.

                            }

                            else if (((info4.Name.IndexOf("Volte") != -1) || (info4.Name.IndexOf("volte") != -1)) || (info4.Name.IndexOf("VOLTE") != -1))
                            {
                                String Volte_gelen = gelen_yol + "\\" + "s1" + "\\" + info4.Name;
                                String Volte_yeni = gelen_yol + @"\Logs" + "\\" + "st1_volte.trp";
                                File.Copy(Volte_gelen, Volte_yeni);    //s1 adı altında olan CSFB içeren dosyayı yeniden adlandırmak için

                            }


                        }
                    }
                    else if (info3.Name.IndexOf("2") != -1)
                    {

                        String cell2_gelen = gelen_yol + "\\" + info3.Name;
                        String cell2_yeni = gelen_yol + "\\" + "s2";


                        Directory.Move(cell2_gelen, cell2_yeni2);
                        Directory.Move(cell2_yeni2, cell2_yeni);


                        foreach (string str4 in Directory.GetFiles(cell2_yeni))
                        {
                            Elements.Items.Add(str4);
                            FileInfo info4 = new FileInfo(str4);

                            if (info4.Name.IndexOf("ping") != -1)
                            {
                                String ping_gelen = gelen_yol + "\\" + "s2" + "\\" + info4.Name;
                                String ping_yeni = gelen_yol + @"\Logs" + "\\" + "st2_ping_1800.trp";
                                File.Copy(ping_gelen, ping_yeni);
                            }
                            else if (info4.Name.IndexOf("dl") != -1 || info4.Name.IndexOf("DL") != -1 || info4.Name.IndexOf("Dl") != -1 || info4.Name.IndexOf("dL") != -1)
                            {
                                String dl_gelen = gelen_yol + "\\" + "s2" + "\\" + info4.Name;
                                String dl_yeni = gelen_yol + @"\Logs" + "\\" + "st2_dl_1800.trp";
                                File.Copy(dl_gelen, dl_yeni);
                            }

                            else if (info4.Name.IndexOf("ul") != -1 || info4.Name.IndexOf("UL") != -1 || info4.Name.IndexOf("Ul") != -1 || info4.Name.IndexOf("uL") != -1)
                            {
                                String ul_gelen = gelen_yol + "\\" + "s2" + "\\" + info4.Name;
                                String ul_yeni = gelen_yol + @"\Logs" + "\\" + "st2_ul_1800.trp";
                                File.Copy(ul_gelen, ul_yeni);
                            }

                        else if (((info4.Name.IndexOf("CSFB") != -1) || (info4.Name.IndexOf("4G4G") != -1)))
                        {
                                String CSFB_gelen = gelen_yol + "\\" + "s2" + "\\" + info4.Name;
                                String CSFB_yeni = gelen_yol + @"\Logs" + "\\" + "st2_vc_1800.trp";
                                File.Copy(CSFB_gelen, CSFB_yeni);
                            }

                            else if (((info4.Name.IndexOf("Volte") != -1) || (info4.Name.IndexOf("volte") != -1)) || (info4.Name.IndexOf("VOLTE") != -1))
                            {
                                String Volte_gelen = gelen_yol + "\\" + "s2" + "\\" + info4.Name;
                                String Volte_yeni = gelen_yol + @"\Logs" + "\\" + "st2_volte.trp";
                                File.Copy(Volte_gelen, Volte_yeni);
                            }


                        }





                    }
                    else if (info3.Name.IndexOf("3") != -1)
                    {

                        String cell3_gelen = gelen_yol + "\\" + info3.Name;
                        String cell3_yeni = gelen_yol + "\\" + "s3";
                        Directory.Move(cell3_gelen, cell3_yeni3);
                        Directory.Move(cell3_yeni3, cell3_yeni);


                        foreach (string str4 in Directory.GetFiles(cell3_yeni))
                        {
                            Elements.Items.Add(str4);
                            FileInfo info4 = new FileInfo(str4);

                            if (info4.Name.IndexOf("ping") != -1)
                            {
                                String ping_gelen = gelen_yol + "\\" + "s3" + "\\" + info4.Name;
                                String ping_yeni = gelen_yol + @"\Logs" + "\\" + "st3_ping_1800.trp";
                                File.Copy(ping_gelen, ping_yeni);
                            }
                            else if (info4.Name.IndexOf("dl") != -1 || info4.Name.IndexOf("DL") != -1 || info4.Name.IndexOf("Dl") != -1 || info4.Name.IndexOf("dL") != -1)
                            {
                                String dl_gelen = gelen_yol + "\\" + "s3" + "\\" + info4.Name;
                                String dl_yeni = gelen_yol + @"\Logs" + "\\" + "st3_dl_1800.trp";
                                File.Copy(dl_gelen, dl_yeni);
                            }

                            else if (info4.Name.IndexOf("ul") != -1 || info4.Name.IndexOf("UL") != -1 || info4.Name.IndexOf("Ul") != -1 || info4.Name.IndexOf("uL") != -1)
                            {
                                String ul_gelen = gelen_yol + "\\" + "s3" + "\\" + info4.Name;
                                String ul_yeni = gelen_yol + @"\Logs" + "\\" + "st3_ul_1800.trp";
                                File.Copy(ul_gelen, ul_yeni);
                            }

                            else if (((info4.Name.IndexOf("CSFB") != -1)  || (info4.Name.IndexOf("4G4G") != -1) ))
                            {
                                String CSFB_gelen = gelen_yol + "\\" + "s3" + "\\" + info4.Name;
                                String CSFB_yeni = gelen_yol + @"\Logs" + "\\" + "st3_vc_1800.trp";
                                File.Copy(CSFB_gelen, CSFB_yeni);
                            }

                            else if (((info4.Name.IndexOf("Volte") != -1) || (info4.Name.IndexOf("volte") != -1)) || (info4.Name.IndexOf("VOLTE") != -1))
                            {
                                String Volte_gelen = gelen_yol + "\\" + "s3" + "\\" + info4.Name;
                                String Volte_yeni = gelen_yol + @"\Logs" + "\\" + "st3_volte.trp";
                                File.Copy(Volte_gelen, Volte_yeni);
                            }


                        }
                    }
                    else { MessageBox.Show("Düzenlemeler yapıldı veya düzenlenecek içerik bulunamadı ! Lütfen dosyayı kontrol edin."); }

                
            }

            try
            {
                if (Directory.Exists(gelen_yol + @"\Mobility"))   //Seçilen yolda var ise.
                {
                    int counter2 = 1;
                    string gelen_mob = gelen_yol + @"\Mobility";
                    string gidecek_mob = gelen_yol + @"\Logs";
                    string[] dosya_var = Directory.GetFiles(gelen_mob);
                    foreach (string i in dosya_var)
                    {
                        if (counter2 == 1)
                        {
                            String mob_change_name = gelen_yol + @"\Logs" + "\\" + "mobility_800.trp";
                            File.Copy(i, mob_change_name);
                            counter2++;
                            Elements.Items.Add(i);
                        }
                        else
                        {
                            String mob_change_name = gelen_yol + @"\Logs" + "\\" + "mobility_800_" + counter2 + ".trp";
                            File.Copy(i, mob_change_name);
                            counter2++;
                            Elements.Items.Add(i);
                        }
                    }
                }

                else //Dosya olarark ayarlanmamış dağınık bırakılmış ise 
                {

                    string[] dosya_var = Directory.GetFiles(gelen_yol);
                    int counter2 = 1;
                    foreach (string i in dosya_var)
                    {
                        String a = i.ToUpper();
                        if (a.IndexOf(".JPG") != -1 || a.IndexOf(".png") != -1 || a.IndexOf(".JPEG") != -1 || a.IndexOf(".PNG") != -1)
                        {
                            continue;
                        }
                        else
                        {
                            if (counter2 == 1)
                            {
                                String mob_change_name = gelen_yol + @"\Logs" + "\\" + "mobility_800.trp";
                                File.Copy(i, mob_change_name);
                                counter2++;
                                Elements.Items.Add(i);
                            }
                            else
                            {
                                String mob_change_name = gelen_yol + @"\Logs" + "\\" + "mobility_800_" + counter2 + ".trp";
                                File.Copy(i, mob_change_name);
                                counter2++;
                                Elements.Items.Add(i);
                            }
                        }

                    }
                }


            }

            catch { MessageBox.Show("Mobility dosyaları malesef bulunamadı."); }
            
        }
        



        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Elements.Items.Clear();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }


        private void label2_Click(object sender, EventArgs e)
        {

        }


        private void backScript_Click(object sender, EventArgs e)
        {
            work_rename(gelen_yol);
        }
        public string dosyayolu = "";
        public void work_rename(string dosyayolu)
        {
           this.dosyayolu = gelen_yol;
            try
            {
                if (Directory.Exists(this.dosyayolu + @"\Logs"))
                {
                    Directory.Delete(this.dosyayolu + @"\Logs", true);
                }
                Directory.CreateDirectory(this.dosyayolu + @"\Logs");
                string[] files = Directory.GetFiles(this.dosyayolu);
                int num = 1;
                string[] directories = Directory.GetDirectories(this.dosyayolu);
                int index = 0;
                while (true)
                {
                    if (index >= directories.Length)
                    {
                        string[] strArray5 = Directory.GetDirectories(this.dosyayolu);
                        int num4 = 0;
                        while (true)
                        {
                            if (num4 >= strArray5.Length)
                            {
                                int num2 = 1;
                                string[] strArray8 = files;
                                int num6 = 0;
                                while (true)
                                {
                                    if (num6 >= strArray8.Length)
                                    {
                                        num2 = 1;
                                        break;
                                    }
                                    string fileName = strArray8[num6];
                                    FileInfo info4 = new FileInfo(fileName);
                                    if (info4.Name.IndexOf("mobility") != -1)
                                    {
                                        if (num2 == 1)
                                        {
                                            File.Copy(this.dosyayolu + @"\" + info4.Name, this.dosyayolu + @"\Logs\mobility_800.trp");
                                        }
                                        else
                                        {
                                            object[] objArray1 = new object[] { this.dosyayolu, @"\Logs\mobility_800_", num2, ".trp" };
                                            File.Copy(this.dosyayolu + @"\" + info4.Name, string.Concat(objArray1));
                                        }
                                        num2++;
                                    }
                                    num6++;
                                }
                                break;
                            }
                            string str2 = strArray5[num4];
                            DirectoryInfo info2 = new DirectoryInfo(str2);
                            string fullName = info2.FullName;
                            if (info2.Name != "Logs")
                            {
                                foreach (string str4 in Directory.GetFiles(fullName))
                                {
                                    FileInfo info3 = new FileInfo(str4);
                                    if (info3.Name.IndexOf("ping") != -1)
                                    {
                                        File.Copy(fullName + @"\" + info3.Name, this.dosyayolu + @"\Logs\st" + info2.Name + "_ping_attach_800.trp");
                                    }
                                    else if (info3.Name.IndexOf("dl") != -1)
                                    {
                                        File.Copy(fullName + @"\" + info3.Name, this.dosyayolu + @"\Logs\st" + info2.Name + "_dl_800.trp");
                                    }
                                    else if (info3.Name.IndexOf("ul") != -1)
                                    {
                                        File.Copy(fullName + @"\" + info3.Name, this.dosyayolu + @"\Logs\st" + info2.Name + "_ul_800.trp");
                                    }
                                    else if (((info3.Name.IndexOf("CSFB") != -1) || (info3.Name.IndexOf("vc") != -1)) || (info3.Name.IndexOf("4G3G") != -1))
                                    {
                                        File.Copy(fullName + @"\" + info3.Name, this.dosyayolu + @"\Logs\st" + info2.Name + "_vc_4G4G_800.trp");
                                    }
                                }
                            }
                            num4++;
                        }
                        break;
                    }
                    string path = directories[index];
                    DirectoryInfo info = new DirectoryInfo(path);
                    if (info.Name != "Logs")
                    {
                        if ((this.dosyayolu + @"\" + info.Name) != (this.dosyayolu + @"\" + num))
                        {
                            Directory.Move(this.dosyayolu + @"\" + info.Name, this.dosyayolu + @"\" + num);
                        }
                        num++;
                    }
                    index++;
                }
            }
            catch (Exception)
            {
                MessageBox.Show(" HATA VERDİ :)");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int ana_dosya_counter = 0;
            int alt_dosya_counter = 0;
            string gelen_u2100 = gelen_yol;
            int elm = 0;
            string[] child_files = Directory.GetDirectories(gelen_u2100);
            
            if (Directory.Exists(gelen_yol + @"\Logs"))
            {
                Directory.Delete(gelen_yol + @"\Logs", true); //EĞER DAHA ÖNCE LOG DOSYASI VAR İSE SONU SİLİYORUZ. 
            }
            String asd3 = gelen_yol + "/" + "logs";
            Directory.CreateDirectory(asd3);                 //Log dosyasını yeniden oluşturuyoruz.
           
           
            foreach(string child_files_u2100 in child_files) // Burada U2100 dosyalarının isimlendirmelerini yapıyoruz.
            {
                    FileInfo ana_file = new FileInfo(child_files_u2100);  //Elemanların hepsini file info altına alıyoruz. Bu şekilde dosyaları kontrol edebileceğiz.
                        //İsmi DC olan klasör için ayrı işlem gerekiyor bundan dolayı bunu  farklı bir block içinde kullanıyoruz.
                    if(ana_file.Name.IndexOf("DC") != -1  || ana_file.Name.IndexOf("Dc") != -1 || ana_file.Name.IndexOf("dc") != -1 || ana_file.Name.IndexOf("dC") != -1)
                {                                                              
                    Elements.Items.Add("Ana Dosyamız:");
                    Elements.Items.Add(child_files_u2100);      //Ana dosyalarımızın hepsini Ekrana yazdırıyoruz.
                    foreach (string first_file in Directory.GetDirectories(child_files_u2100))
                    {
                        alt_dosya_counter++;
                        Elements.Items.Add("Alt dosyalarımız.");
                        Elements.Items.Add(first_file);     //Alt dosyalarımızı ekrana yazdırıyoruz.
                       // MessageBox.Show("Alt dosyamız" + Convert.ToString(alt_dosya_counter));
                        FileInfo dosya_içi = new FileInfo(first_file);
                        String cell1_yeni1 = child_files_u2100 + "\\" + "hhhh1";  //S1 olarak ayarlanan bir dosyanın adı önce hhh1 olarak ayarlanacak.
                        String cell2_yeni2 = child_files_u2100 + "\\" + "hhhh2";  //s2 olarak ayarlanan bir dosyanın adı sonra hh2 olarak ayarlanacak.
                        String cell3_yeni3 = child_files_u2100 + "\\" + "hhhh3";  //s3 olarak ayarlanan bir dosyanın adı önce hh3 olarak ayarlanacak.
                        String cell4_yeni4 = child_files_u2100 + "\\" + "hhhh4";  //s2 olarak ayarlanan bir dosyanın adı sonra hh2 olarak ayarlanacak.
                        String cell5_yeni5 = child_files_u2100 + "\\" + "hhhh5";  //s3 olarak ayarlanan bir dosyanın adı önce hh3 olarak ayarlanacak.

                        if (alt_dosya_counter > 2)
                        {
                            alt_dosya_counter = 1;
                        }

                        if (dosya_içi.Name.IndexOf("1") != -1)                //Dosyanın adında 1 geçiyor ise.
                        {

                            String cell1_gelen = child_files_u2100 + "\\" + dosya_içi.Name; //Bu dosyanın konumu.
                            String cell1_yeni = child_files_u2100 + "\\" + "s1";        //Dosyanın adının s1 olması için gereken kod.
                            Directory.Move(cell1_gelen, cell1_yeni1);      //gelen dosya x olsun biz bunu önce hhhh1 yapıyoruz.
                            Directory.Move(cell1_yeni1, cell1_yeni);

                            foreach (string str4 in Directory.GetFiles(cell1_yeni))
                            {
                                Elements.Items.Add(str4);               //Dosyanın işleme alındığını ekranda gösteriyor.
                                FileInfo info4 = new FileInfo(str4);

                                if (info4.Name.IndexOf("dl") != -1 || info4.Name.IndexOf("DL") != -1 || info4.Name.IndexOf("Dl") != -1 || info4.Name.IndexOf("dL") != -1)
                                {
                                    String dl_gelen = first_file + "\\" + info4.Name;
                                    String dl_yeni = gelen_yol + @"\Logs" + "\\" + "st" + alt_dosya_counter + "_dual" + "_dl.trp";
                                    File.Copy(dl_gelen, dl_yeni);
                                }
                                else if (info4.Name.IndexOf("ul") != -1 || info4.Name.IndexOf("UL") != -1 || info4.Name.IndexOf("Ul") != -1 || info4.Name.IndexOf("uL") != -1)
                                {
                                    String Ul_gelen = first_file + "\\" + info4.Name;
                                    String Ul_yeni = gelen_yol + @"\Logs" + "\\" + "st" + alt_dosya_counter + "_dual" + "_ul.trp";
                                    File.Copy(Ul_gelen, Ul_yeni);

                                }
                                else if (info4.Name.IndexOf("voice") != -1 || info4.Name.IndexOf("Voice") != -1 || info4.Name.IndexOf("Voice_3G") != -1 || info4.Name.IndexOf("VOICE") != -1)
                                {

                                    String voice_gelen = first_file + "\\" + info4.Name;
                                    String voice_yeni = gelen_yol + @"\Logs" + "\\" + "st" + alt_dosya_counter + "_dual" + "_voice.trp";
                                    File.Copy(voice_gelen, voice_yeni);

                                }
                            }







                        }
                        else if (dosya_içi.Name.IndexOf("2") != -1)                //Dosyanın adında 1 geçiyor ise.
                        {

                            String cell2_gelen = child_files_u2100 + "\\" + dosya_içi.Name; //Bu dosyanın konumu.
                            String cell2_yeni = child_files_u2100 + "\\" + "s2";        //Dosyanın adının s1 olması için gereken kod.
                            Directory.Move(cell2_gelen, cell2_yeni2);      //gelen dosya x olsun biz bunu önce hhhh1 yapıyoruz.
                            Directory.Move(cell2_yeni2, cell2_yeni);

                            foreach (string str4 in Directory.GetFiles(cell2_yeni))
                            {
                                Elements.Items.Add(str4);               //Dosyanın işleme alındığını ekranda gösteriyor.
                                FileInfo info4 = new FileInfo(str4);
                                if (info4.Name.IndexOf("dl") != -1 || info4.Name.IndexOf("DL") != -1 || info4.Name.IndexOf("Dl") != -1 || info4.Name.IndexOf("dL") != -1)
                                {
                                    String dl_gelen = first_file + "\\" + info4.Name;
                                    String dl_yeni = gelen_yol + @"\Logs" + "\\" +"st" + alt_dosya_counter + "_dual" + "_dl.trp";
                                    File.Copy(dl_gelen, dl_yeni);
                                }
                                else if (info4.Name.IndexOf("ul") != -1 || info4.Name.IndexOf("UL") != -1 || info4.Name.IndexOf("Ul") != -1 || info4.Name.IndexOf("uL") != -1)
                                {
                                    String Ul_gelen = first_file + "\\" + info4.Name;
                                    String Ul_yeni = gelen_yol + @"\Logs" + "\\" + "st" + alt_dosya_counter + "_dual" + "_ul.trp";
                                    File.Copy(Ul_gelen, Ul_yeni);

                                }
                                else if (info4.Name.IndexOf("voice") != -1 || info4.Name.IndexOf("Voice") != -1 || info4.Name.IndexOf("Voice_3G") != -1 || info4.Name.IndexOf("VOICE") != -1)
                                {

                                    String voice_gelen = first_file + "\\" + info4.Name;
                                    String voice_yeni = gelen_yol + @"\Logs" + "\\" + "st" + alt_dosya_counter + "_dual" + "_voice.trp";
                                    File.Copy(voice_gelen, voice_yeni);

                                }
                            }







                        }
                        else if (dosya_içi.Name.IndexOf("3") != -1)                //Dosyanın adında 1 geçiyor ise.
                        {

                            String cell3_gelen = child_files_u2100 + "\\" + dosya_içi.Name; //Bu dosyanın konumu.
                            String cell3_yeni = child_files_u2100 + "\\" + "s3";        //Dosyanın adının s1 olması için gereken kod.
                            Directory.Move(cell3_gelen, cell3_yeni3);      //gelen dosya x olsun biz bunu önce hhhh1 yapıyoruz.
                            Directory.Move(cell3_yeni3, cell3_yeni);

                            foreach (string str4 in Directory.GetFiles(cell3_yeni))
                            {
                                Elements.Items.Add(str4);               //Dosyanın işleme alındığını ekranda gösteriyor.
                                FileInfo info4 = new FileInfo(str4);
                                if (info4.Name.IndexOf("dl") != -1 || info4.Name.IndexOf("DL") != -1 || info4.Name.IndexOf("Dl") != -1 || info4.Name.IndexOf("dL") != -1)
                                {
                                    String dl_gelen = first_file + "\\" + info4.Name;
                                    String dl_yeni = gelen_yol + @"\Logs" + "\\" + "st" + alt_dosya_counter + "_dual" + "_dl.trp";
                                    File.Copy(dl_gelen, dl_yeni);
                                }
                                else if (info4.Name.IndexOf("ul") != -1 || info4.Name.IndexOf("UL") != -1 || info4.Name.IndexOf("Ul") != -1 || info4.Name.IndexOf("uL") != -1)
                                {
                                    String Ul_gelen = first_file + "\\" + info4.Name;
                                    String Ul_yeni = gelen_yol + @"\Logs" + "\\" + "st" + alt_dosya_counter + "_dual" + "_ul.trp";
                                    File.Copy(Ul_gelen, Ul_yeni);

                                }
                                else if (info4.Name.IndexOf("voice") != -1 || info4.Name.IndexOf("Voice") != -1 || info4.Name.IndexOf("Voice_3G") != -1 || info4.Name.IndexOf("VOICE") != -1)
                                {

                                    String voice_gelen = first_file + "\\" + info4.Name;
                                    String voice_yeni = gelen_yol + @"\Logs" + "\\" + "st" + alt_dosya_counter + "_dual" + "_voice.trp";
                                    File.Copy(voice_gelen, voice_yeni);

                                }
                            }







                        }
                        else if (dosya_içi.Name.IndexOf("4") != -1)                //Dosyanın adında 1 geçiyor ise.
                        {

                            String cell4_gelen = child_files_u2100 + "\\" + dosya_içi.Name; //Bu dosyanın konumu.
                            String cell4_yeni = child_files_u2100 + "\\" + "s4";        //Dosyanın adının s1 olması için gereken kod.
                            Directory.Move(cell4_gelen, cell4_yeni4);      //gelen dosya x olsun biz bunu önce hhhh1 yapıyoruz.
                            Directory.Move(cell4_yeni4, cell4_yeni);

                            foreach (string str4 in Directory.GetFiles(cell4_yeni))
                            {
                                Elements.Items.Add(str4);               //Dosyanın işleme alındığını ekranda gösteriyor.
                                FileInfo info4 = new FileInfo(str4);
                                if (info4.Name.IndexOf("dl") != -1 || info4.Name.IndexOf("DL") != -1 || info4.Name.IndexOf("Dl") != -1 || info4.Name.IndexOf("dL") != -1)
                                {
                                    String dl_gelen = first_file + "\\" + info4.Name;
                                    String dl_yeni = gelen_yol + @"\Logs" + "\\" + "st" + alt_dosya_counter + "_dual" + "_dl.trp";
                                    File.Copy(dl_gelen, dl_yeni);
                                }
                                else if (info4.Name.IndexOf("ul") != -1 || info4.Name.IndexOf("UL") != -1 || info4.Name.IndexOf("Ul") != -1 || info4.Name.IndexOf("uL") != -1)
                                {
                                    String Ul_gelen = first_file + "\\" + info4.Name;
                                    String Ul_yeni = gelen_yol + @"\Logs" + "\\" + "st" + alt_dosya_counter + "_dual" + "_ul.trp";
                                    File.Copy(Ul_gelen, Ul_yeni);

                                }
                                else if (info4.Name.IndexOf("voice") != -1 || info4.Name.IndexOf("Voice") != -1 || info4.Name.IndexOf("Voice_3G") != -1 || info4.Name.IndexOf("VOICE") != -1)
                                {

                                    String voice_gelen = first_file + "\\" + info4.Name;
                                    String voice_yeni = gelen_yol + @"\Logs" + "\\" +"st" + alt_dosya_counter + "_dual" + "_voice.trp";
                                    File.Copy(voice_gelen, voice_yeni);

                                }
                            }



                        }
                        else if (dosya_içi.Name.IndexOf("5") != -1)                //Dosyanın adında 1 geçiyor ise.
                        {

                            String cell5_gelen = child_files_u2100 + "\\" + dosya_içi.Name; //Bu dosyanın konumu.
                            String cell5_yeni = child_files_u2100 + "\\" + "s5";        //Dosyanın adının s1 olması için gereken kod.
                            Directory.Move(cell5_gelen, cell5_yeni5);      //gelen dosya x olsun biz bunu önce hhhh1 yapıyoruz.
                            Directory.Move(cell5_yeni5, cell5_yeni);

                            foreach (string str4 in Directory.GetFiles(cell5_yeni))
                            {
                                Elements.Items.Add(str4);               //Dosyanın işleme alındığını ekranda gösteriyor.
                                FileInfo info4 = new FileInfo(str4);
                                if (info4.Name.IndexOf("dl") != -1 || info4.Name.IndexOf("DL") != -1 || info4.Name.IndexOf("Dl") != -1 || info4.Name.IndexOf("dL") != -1)
                                {
                                    String dl_gelen = first_file + "\\" + info4.Name;
                                    String dl_yeni = gelen_yol + @"\Logs" + "\\" + "st" + alt_dosya_counter + "_dual" + "_dl.trp";
                                    File.Copy(dl_gelen, dl_yeni);
                                }
                                else if (info4.Name.IndexOf("ul") != -1 || info4.Name.IndexOf("UL") != -1 || info4.Name.IndexOf("Ul") != -1 || info4.Name.IndexOf("uL") != -1)
                                {
                                    String Ul_gelen = first_file + "\\" + info4.Name;
                                    String Ul_yeni = gelen_yol + @"\Logs" + "\\" + "st" + alt_dosya_counter + "_dual" + "_ul.trp";
                                    File.Copy(Ul_gelen, Ul_yeni);

                                }
                                else if (info4.Name.IndexOf("voice") != -1 || info4.Name.IndexOf("Voice") != -1 || info4.Name.IndexOf("Voice_3G") != -1 || info4.Name.IndexOf("VOICE") != -1)
                                {

                                    String voice_gelen = first_file + "\\" + info4.Name;
                                    String voice_yeni = gelen_yol + @"\Logs" + "\\" + "st" + alt_dosya_counter + "_dual" + "_voice.trp";
                                    File.Copy(voice_gelen, voice_yeni);

                                }
                            }







                        }
                        else
                        {
                            MessageBox.Show("Dosyalar EKSİK !! ");
                        }
                    }
                }    
                    else
                {
                    Elements.Items.Add("Ana Dosyamız:");
                    Elements.Items.Add(child_files_u2100);
                    ana_dosya_counter++;
                    //MessageBox.Show(Convert.ToString(ana_dosya_counter));
                    foreach (string first_file in Directory.GetDirectories(child_files_u2100))
                    {
                        alt_dosya_counter++;
                        Elements.Items.Add("Alt dosyalarımız.");
                        Elements.Items.Add(first_file);
                        //MessageBox.Show("Alt dosyamız"+Convert.ToString(alt_dosya_counter));
                        FileInfo dosya_içi = new FileInfo(first_file);
                        String cell1_yeni1 = child_files_u2100 + "\\" + "hhhh1";  //S1 olarak ayarlanan bir dosyanın adı önce hhh1 olarak ayarlanacak.
                        String cell2_yeni2 = child_files_u2100 + "\\" + "hhhh2";  //s2 olarak ayarlanan bir dosyanın adı sonra hh2 olarak ayarlanacak.
                        String cell3_yeni3 = child_files_u2100 + "\\" + "hhhh3";  //s3 olarak ayarlanan bir dosyanın adı önce hh3 olarak ayarlanacak.
                        String cell4_yeni4 = child_files_u2100 + "\\" + "hhhh4";  //s2 olarak ayarlanan bir dosyanın adı sonra hh2 olarak ayarlanacak.
                        String cell5_yeni5 = child_files_u2100 + "\\" + "hhhh5";  //s3 olarak ayarlanan bir dosyanın adı önce hh3 olarak ayarlanacak.

                        if (alt_dosya_counter > 2)
                        {
                            alt_dosya_counter = 1;
                        }

                        if (dosya_içi.Name.IndexOf("1") != -1)                //Dosyanın adında 1 geçiyor ise.
                        {

                            String cell1_gelen = child_files_u2100 + "\\" + dosya_içi.Name; //Bu dosyanın konumu.
                            String cell1_yeni = child_files_u2100 + "\\" + "s1";        //Dosyanın adının s1 olması için gereken kod.
                            Directory.Move(cell1_gelen, cell1_yeni1);      //gelen dosya x olsun biz bunu önce hhhh1 yapıyoruz.
                            Directory.Move(cell1_yeni1, cell1_yeni);

                            foreach (string str4 in Directory.GetFiles(cell1_yeni))
                            {
                                Elements.Items.Add(str4);               //Dosyanın işleme alındığını ekranda gösteriyor.
                                FileInfo info4 = new FileInfo(str4);

                                if (info4.Name.IndexOf("dl") != -1 || info4.Name.IndexOf("DL") != -1 || info4.Name.IndexOf("Dl") != -1 || info4.Name.IndexOf("dL") != -1)
                                {
                                    String dl_gelen = first_file + "\\" + info4.Name;
                                    String dl_yeni = gelen_yol + @"\Logs" + "\\" + "st" + alt_dosya_counter + "_f" + ana_dosya_counter + "_dl.trp";
                                    File.Copy(dl_gelen, dl_yeni);
                                }
                                else if (info4.Name.IndexOf("ul") != -1 || info4.Name.IndexOf("UL") != -1 || info4.Name.IndexOf("Ul") != -1 || info4.Name.IndexOf("uL") != -1)
                                {
                                    String Ul_gelen = first_file + "\\" + info4.Name;
                                    String Ul_yeni = gelen_yol + @"\Logs" + "\\" + "st" + alt_dosya_counter + "_f" + ana_dosya_counter + "_ul.trp";
                                    File.Copy(Ul_gelen, Ul_yeni);

                                }
                                else if (info4.Name.IndexOf("voice") != -1 || info4.Name.IndexOf("Voice") != -1 || info4.Name.IndexOf("Voice_3G") != -1 || info4.Name.IndexOf("VOICE") != -1)
                                {

                                    String voice_gelen = first_file + "\\" + info4.Name;
                                    String voice_yeni = gelen_yol + @"\Logs" + "\\" + "st" + alt_dosya_counter + "_f" + ana_dosya_counter + "_voice.trp";
                                    File.Copy(voice_gelen, voice_yeni);

                                }
                            }







                        }
                        else if (dosya_içi.Name.IndexOf("2") != -1)                //Dosyanın adında 1 geçiyor ise.
                        {

                            String cell2_gelen = child_files_u2100 + "\\" + dosya_içi.Name; //Bu dosyanın konumu.
                            String cell2_yeni = child_files_u2100 + "\\" + "s2";        //Dosyanın adının s1 olması için gereken kod.
                            Directory.Move(cell2_gelen, cell2_yeni2);      //gelen dosya x olsun biz bunu önce hhhh1 yapıyoruz.
                            Directory.Move(cell2_yeni2, cell2_yeni);

                            foreach (string str4 in Directory.GetFiles(cell2_yeni))
                            {
                                Elements.Items.Add(str4);               //Dosyanın işleme alındığını ekranda gösteriyor.
                                FileInfo info4 = new FileInfo(str4);
                                if (info4.Name.IndexOf("dl") != -1 || info4.Name.IndexOf("DL") != -1 || info4.Name.IndexOf("Dl") != -1 || info4.Name.IndexOf("dL") != -1)
                                {
                                    String dl_gelen = first_file + "\\" + info4.Name;
                                    String dl_yeni = gelen_yol + @"\Logs" + "\\" + "st" + alt_dosya_counter + "_f" + ana_dosya_counter + "_dl.trp";
                                    File.Copy(dl_gelen, dl_yeni);
                                }
                                else if (info4.Name.IndexOf("ul") != -1 || info4.Name.IndexOf("UL") != -1 || info4.Name.IndexOf("Ul") != -1 || info4.Name.IndexOf("uL") != -1)
                                {
                                    String Ul_gelen = first_file + "\\" + info4.Name;
                                    String Ul_yeni = gelen_yol + @"\Logs" + "\\" + "st" + alt_dosya_counter + "_f" + ana_dosya_counter + "_ul.trp";
                                    File.Copy(Ul_gelen, Ul_yeni);

                                }
                                else if (info4.Name.IndexOf("voice") != -1 || info4.Name.IndexOf("Voice") != -1 || info4.Name.IndexOf("Voice_3G") != -1 || info4.Name.IndexOf("VOICE") != -1)
                                {

                                    String voice_gelen = first_file + "\\" + info4.Name;
                                    String voice_yeni = gelen_yol + @"\Logs" + "\\" + "st" + alt_dosya_counter + "_f" + ana_dosya_counter + "_voice.trp";
                                    File.Copy(voice_gelen, voice_yeni);

                                }
                            }







                        }
                        else if (dosya_içi.Name.IndexOf("3") != -1)                //Dosyanın adında 1 geçiyor ise.
                        {

                            String cell3_gelen = child_files_u2100 + "\\" + dosya_içi.Name; //Bu dosyanın konumu.
                            String cell3_yeni = child_files_u2100 + "\\" + "s3";        //Dosyanın adının s1 olması için gereken kod.
                            Directory.Move(cell3_gelen, cell3_yeni3);      //gelen dosya x olsun biz bunu önce hhhh1 yapıyoruz.
                            Directory.Move(cell3_yeni3, cell3_yeni);

                            foreach (string str4 in Directory.GetFiles(cell3_yeni))
                            {
                                Elements.Items.Add(str4);               //Dosyanın işleme alındığını ekranda gösteriyor.
                                FileInfo info4 = new FileInfo(str4);
                                if (info4.Name.IndexOf("dl") != -1 || info4.Name.IndexOf("DL") != -1 || info4.Name.IndexOf("Dl") != -1 || info4.Name.IndexOf("dL") != -1)
                                {
                                    String dl_gelen = first_file + "\\" + info4.Name;
                                    String dl_yeni = gelen_yol + @"\Logs" + "\\" + "st" + alt_dosya_counter + "_f" + ana_dosya_counter + "_dl.trp";
                                    File.Copy(dl_gelen, dl_yeni);
                                }
                                else if (info4.Name.IndexOf("ul") != -1 || info4.Name.IndexOf("UL") != -1 || info4.Name.IndexOf("Ul") != -1 || info4.Name.IndexOf("uL") != -1)
                                {
                                    String Ul_gelen = first_file + "\\" + info4.Name;
                                    String Ul_yeni = gelen_yol + @"\Logs" + "\\" + "st" + alt_dosya_counter + "_f" + ana_dosya_counter + "_ul.trp";
                                    File.Copy(Ul_gelen, Ul_yeni);

                                }
                                else if (info4.Name.IndexOf("voice") != -1 || info4.Name.IndexOf("Voice") != -1 || info4.Name.IndexOf("Voice_3G") != -1 || info4.Name.IndexOf("VOICE") != -1)
                                {

                                    String voice_gelen = first_file + "\\" + info4.Name;
                                    String voice_yeni = gelen_yol + @"\Logs" + "\\" + "st" + alt_dosya_counter + "_f" + ana_dosya_counter + "_voice.trp";
                                    File.Copy(voice_gelen, voice_yeni);

                                }
                            }







                        }
                        else if (dosya_içi.Name.IndexOf("4") != -1)                //Dosyanın adında 1 geçiyor ise.
                        {

                            String cell4_gelen = child_files_u2100 + "\\" + dosya_içi.Name; //Bu dosyanın konumu.
                            String cell4_yeni = child_files_u2100 + "\\" + "s4";        //Dosyanın adının s1 olması için gereken kod.
                            Directory.Move(cell4_gelen, cell4_yeni4);      //gelen dosya x olsun biz bunu önce hhhh1 yapıyoruz.
                            Directory.Move(cell4_yeni4, cell4_yeni);

                            foreach (string str4 in Directory.GetFiles(cell4_yeni))
                            {
                                Elements.Items.Add(str4);               //Dosyanın işleme alındığını ekranda gösteriyor.
                                FileInfo info4 = new FileInfo(str4);
                                if (info4.Name.IndexOf("dl") != -1 || info4.Name.IndexOf("DL") != -1 || info4.Name.IndexOf("Dl") != -1 || info4.Name.IndexOf("dL") != -1)
                                {
                                    String dl_gelen = first_file + "\\" + info4.Name;
                                    String dl_yeni = gelen_yol + @"\Logs" + "\\" + "st" + alt_dosya_counter + "_f" + ana_dosya_counter + "_dl.trp";
                                    File.Copy(dl_gelen, dl_yeni);
                                }
                                else if (info4.Name.IndexOf("ul") != -1 || info4.Name.IndexOf("UL") != -1 || info4.Name.IndexOf("Ul") != -1 || info4.Name.IndexOf("uL") != -1)
                                {
                                    String Ul_gelen = first_file + "\\" + info4.Name;
                                    String Ul_yeni = gelen_yol + @"\Logs" + "\\" + "st" + alt_dosya_counter + "_f" + ana_dosya_counter + "_ul.trp";
                                    File.Copy(Ul_gelen, Ul_yeni);

                                }
                                else if (info4.Name.IndexOf("voice") != -1 || info4.Name.IndexOf("Voice") != -1 || info4.Name.IndexOf("Voice_3G") != -1 || info4.Name.IndexOf("VOICE") != -1)
                                {

                                    String voice_gelen = first_file + "\\" + info4.Name;
                                    String voice_yeni = gelen_yol + @"\Logs" + "\\" + "st" + alt_dosya_counter + "_f" + ana_dosya_counter + "_voice.trp";
                                    File.Copy(voice_gelen, voice_yeni);

                                }
                            }







                        }
                        else if (dosya_içi.Name.IndexOf("5") != -1)                //Dosyanın adında 1 geçiyor ise.
                        {

                            String cell5_gelen = child_files_u2100 + "\\" + dosya_içi.Name; //Bu dosyanın konumu.
                            String cell5_yeni = child_files_u2100 + "\\" + "s5";        //Dosyanın adının s1 olması için gereken kod.
                            Directory.Move(cell5_gelen, cell5_yeni5);      //gelen dosya x olsun biz bunu önce hhhh1 yapıyoruz.
                            Directory.Move(cell5_yeni5, cell5_yeni);

                            foreach (string str4 in Directory.GetFiles(cell5_yeni))
                            {
                                Elements.Items.Add(str4);               //Dosyanın işleme alındığını ekranda gösteriyor.
                                FileInfo info4 = new FileInfo(str4);
                                if (info4.Name.IndexOf("dl") != -1 || info4.Name.IndexOf("DL") != -1 || info4.Name.IndexOf("Dl") != -1 || info4.Name.IndexOf("dL") != -1)
                                {
                                    String dl_gelen = first_file + "\\" + info4.Name;
                                    String dl_yeni = gelen_yol + @"\Logs" + "\\" + "st" + alt_dosya_counter + "_f" + ana_dosya_counter + "_dl.trp";
                                    File.Copy(dl_gelen, dl_yeni);
                                }
                                else if (info4.Name.IndexOf("ul") != -1 || info4.Name.IndexOf("UL") != -1 || info4.Name.IndexOf("Ul") != -1 || info4.Name.IndexOf("uL") != -1)
                                {
                                    String Ul_gelen = first_file + "\\" + info4.Name;
                                    String Ul_yeni = gelen_yol + @"\Logs" + "\\" + "st" + alt_dosya_counter + "_f" + ana_dosya_counter + "_ul.trp";
                                    File.Copy(Ul_gelen, Ul_yeni);

                                }
                                else if (info4.Name.IndexOf("voice") != -1 || info4.Name.IndexOf("Voice") != -1 || info4.Name.IndexOf("Voice_3G") != -1 || info4.Name.IndexOf("VOICE") != -1)
                                {

                                    String voice_gelen = first_file + "\\" + info4.Name;
                                    String voice_yeni = gelen_yol + @"\Logs" + "\\" + "st" + alt_dosya_counter + "_f" + ana_dosya_counter + "_voice.trp";
                                    File.Copy(voice_gelen, voice_yeni);

                                }
                            }







                        }
                        else
                        {
                            MessageBox.Show("Dosyalar EKSİK !! ");
                            alt_dosya_counter = 0;
                        }
                    }
                    }
                    try
                {
                    if (Directory.Exists(gelen_yol + @"\Mobility"))   //Seçilen yolda var ise.
                    {
                        int counter2 = 1;
                        string gelen_mob = gelen_yol + @"\Mobility";
                        string gidecek_mob = gelen_yol + @"\Logs";
                        string[] dosya_var = Directory.GetFiles(gelen_mob);
                        foreach (string i in dosya_var)
                        {
                            String a = i.ToUpper();
                            if (a.IndexOf(".JPG") != -1 || a.IndexOf(".png") != -1 || a.IndexOf(".JPEG") != -1 || a.IndexOf(".PNG") != -1 )
                            {
                                continue;
                            }
                            else
                            {
                                if (counter2 == 1)
                                {
                                    String mob_change_name = gelen_yol + @"\Logs" + "\\" + "MOB.trp";
                                    File.Copy(i, mob_change_name);
                                    counter2++;
                                    Elements.Items.Add(i);
                                }
                                else
                                {
                                    String mob_change_name = gelen_yol + @"\Logs" + "\\" + "MOB" + counter2 + ".trp";
                                    File.Copy(i, mob_change_name);
                                    counter2++;
                                    Elements.Items.Add(i);
                                }
                            }

                        }
                    }

                    else //Dosya olarark ayarlanmamış dağınık bırakılmış ise 
                    {

                        string[] dosya_var = Directory.GetFiles(gelen_yol);
                        int counter2 = 1;
                        foreach (string i in dosya_var)
                        {
                            if (i.IndexOf(".jpg") != -1 || i.IndexOf(".png") != -1 || i.IndexOf(".jpeg") != -1 || i.IndexOf(".PNG") != -1)
                            {
                                continue;
                            }
                            else
                            {
                                if (counter2 == 1)
                                {
                                    String mob_change_name = gelen_yol + @"\Logs" + "\\" + "MOB.trp";
                                    File.Copy(i, mob_change_name);
                                    counter2++;
                                    Elements.Items.Add(i);
                                }
                                else
                                {
                                    String mob_change_name = gelen_yol + @"\Logs" + "\\" + "MOB" + counter2 + ".trp";
                                    File.Copy(i, mob_change_name);
                                    counter2++;
                                    Elements.Items.Add(i);
                                }
                            }

                        }
                    }


                }

                catch
                {
                    
                }



            }

            }

        private void button4_Click(object sender, EventArgs e)
        {
            int ana_dosya_counter = 0;
            int alt_dosya_counter = 0;
            string gelen_u2100_eksik = gelen_yol;
            string[] child_files = Directory.GetDirectories(gelen_u2100_eksik);

            if (Directory.Exists(gelen_yol + @"\Logs"))
            {
                Directory.Delete(gelen_yol + @"\Logs", true); //EĞER DAHA ÖNCE LOG DOSYASI VAR İSE SONU SİLİYORUZ. 
            }
            String asd3 = gelen_yol + "/" + "logs";
            Directory.CreateDirectory(asd3);

            foreach(string iç_dosyalar in child_files)
            {
                FileInfo ana_file = new FileInfo(iç_dosyalar);
                String cell1_yeni1 = gelen_u2100_eksik + "\\" + "hhhh1";  //S1 olarak ayarlanan bir dosyanın adı önce hhh1 olarak ayarlanacak.
                String cell2_yeni2 = gelen_u2100_eksik + "\\" + "hhhh2";  //s2 olarak ayarlanan bir dosyanın adı sonra hh2 olarak ayarlanacak.
                String cell3_yeni3 = gelen_u2100_eksik + "\\" + "hhhh3";  //s3 olarak ayarlanan bir dosyanın adı önce hh3 olarak ayarlanacak.
                String cell4_yeni4 = gelen_u2100_eksik + "\\" + "hhhh4";  //s4 olarak ayarlanan bir dosyanın adı sonra hh2 olarak ayarlanacak.
                String cell5_yeni5 = gelen_u2100_eksik + "\\" + "hhhh5";  //s5 olarak ayarlanan bir dosyanın adı önce hh3 olarak ayarlanacak.
                alt_dosya_counter++;
                if (ana_file.Name.IndexOf("1") != -1)
                {
                    
                    String cell1_gelen = gelen_u2100_eksik + "\\" + ana_file.Name; //Bu dosyanın konumu.
                    String cell1_yeni = gelen_u2100_eksik + "\\" + "s1";        //Dosyanın adının s1 olması için gereken kod.
                    Directory.Move(cell1_gelen, cell1_yeni1);      //gelen dosya x olsun biz bunu önce hhhh1 yapıyoruz.
                    Directory.Move(cell1_yeni1, cell1_yeni);
                    ana_dosya_counter++;

                    foreach (string str4 in Directory.GetFiles(cell1_yeni))
                    {
                        Elements.Items.Add(str4);               //Dosyanın işleme alındığını ekranda gösteriyor.
                        FileInfo info4 = new FileInfo(str4);

                        if (info4.Name.IndexOf("dl") != -1 || info4.Name.IndexOf("DL") != -1 || info4.Name.IndexOf("Dl") != -1 || info4.Name.IndexOf("dL") != -1)
                        {
                            String dl_gelen = ana_file + "\\" + info4.Name;
                            String dl_yeni = gelen_yol + @"\Logs" + "\\" + "st" + alt_dosya_counter + "_dual" + "_dl.trp";
                            File.Copy(dl_gelen, dl_yeni);
                        }
                        else if (info4.Name.IndexOf("ul") != -1 || info4.Name.IndexOf("UL") != -1 || info4.Name.IndexOf("Ul") != -1 || info4.Name.IndexOf("uL") != -1)
                        {
                            String Ul_gelen = ana_file + "\\" + info4.Name;
                            String Ul_yeni = gelen_yol + @"\Logs" + "\\" + "st" + alt_dosya_counter + "_dual" + "_ul.trp";
                            File.Copy(Ul_gelen, Ul_yeni);

                        }
                        else if (info4.Name.IndexOf("voice") != -1 || info4.Name.IndexOf("Voice") != -1 || info4.Name.IndexOf("Voice_3G") != -1 || info4.Name.IndexOf("VOICE") != -1)
                        {

                            String voice_gelen = ana_file + "\\" + info4.Name;
                            String voice_yeni = gelen_yol + @"\Logs" + "\\" + "st" + alt_dosya_counter + "_f" + ana_dosya_counter + "_voice.trp";
                            File.Copy(voice_gelen, voice_yeni);

                        }
                    }


                }
                else if (ana_file.Name.IndexOf("2") != -1)
                {

                    String cell2_gelen = gelen_u2100_eksik + "\\" + ana_file.Name; //Bu dosyanın konumu.
                    String cell2_yeni = gelen_u2100_eksik + "\\" + "s2";        //Dosyanın adının s1 olması için gereken kod.
                    Directory.Move(cell2_gelen, cell2_yeni2);      //gelen dosya x olsun biz bunu önce hhhh1 yapıyoruz.
                    Directory.Move(cell2_yeni2, cell2_yeni);

                    foreach (string str4 in Directory.GetFiles(cell2_yeni))
                    {
                        Elements.Items.Add(str4);               //Dosyanın işleme alındığını ekranda gösteriyor.
                        FileInfo info4 = new FileInfo(str4);

                        if (info4.Name.IndexOf("dl") != -1 || info4.Name.IndexOf("DL") != -1 || info4.Name.IndexOf("Dl") != -1 || info4.Name.IndexOf("dL") != -1)
                        {
                            String dl_gelen = ana_file + "\\" + info4.Name;
                            String dl_yeni = gelen_yol + @"\Logs" + "\\" + "st" + alt_dosya_counter + "_dual" + "_dl.trp";
                            File.Copy(dl_gelen, dl_yeni);
                        }
                        else if (info4.Name.IndexOf("ul") != -1 || info4.Name.IndexOf("UL") != -1 || info4.Name.IndexOf("Ul") != -1 || info4.Name.IndexOf("uL") != -1)
                        {
                            String Ul_gelen = ana_file + "\\" + info4.Name;
                            String Ul_yeni = gelen_yol + @"\Logs" + "\\" + "st" + alt_dosya_counter + "_dual"  + "_ul.trp";
                            File.Copy(Ul_gelen, Ul_yeni);

                        }
                        else if (info4.Name.IndexOf("voice") != -1 || info4.Name.IndexOf("Voice") != -1 || info4.Name.IndexOf("Voice_3G") != -1 || info4.Name.IndexOf("VOICE") != -1)
                        {

                            String voice_gelen = ana_file + "\\" + info4.Name;
                            String voice_yeni = gelen_yol + @"\Logs" + "\\" + "st" + alt_dosya_counter + "_f" + ana_dosya_counter + "_voice.trp";
                            File.Copy(voice_gelen, voice_yeni);

                        }
                    }


                }
                else if (ana_file.Name.IndexOf("3") != -1)
                {

                    String cell3_gelen = gelen_u2100_eksik + "\\" + ana_file.Name; //Bu dosyanın konumu.
                    String cell3_yeni = gelen_u2100_eksik + "\\" + "s3";        //Dosyanın adının s1 olması için gereken kod.
                    Directory.Move(cell3_gelen, cell3_yeni3);      //gelen dosya x olsun biz bunu önce hhhh1 yapıyoruz.
                    Directory.Move(cell3_yeni3, cell3_yeni);

                    foreach (string str4 in Directory.GetFiles(cell3_yeni))
                    {
                        Elements.Items.Add(str4);               //Dosyanın işleme alındığını ekranda gösteriyor.
                        FileInfo info4 = new FileInfo(str4);

                        if (info4.Name.IndexOf("dl") != -1 || info4.Name.IndexOf("DL") != -1 || info4.Name.IndexOf("Dl") != -1 || info4.Name.IndexOf("dL") != -1)
                        {
                            String dl_gelen = ana_file + "\\" + info4.Name;
                            String dl_yeni = gelen_yol + @"\Logs" + "\\" + "st" + alt_dosya_counter + "_dual" + "_dl.trp";
                            File.Copy(dl_gelen, dl_yeni);
                        }
                        else if (info4.Name.IndexOf("ul") != -1 || info4.Name.IndexOf("UL") != -1 || info4.Name.IndexOf("Ul") != -1 || info4.Name.IndexOf("uL") != -1)
                        {
                            String Ul_gelen = ana_file + "\\" + info4.Name;
                            String Ul_yeni = gelen_yol + @"\Logs" + "\\" + "st" + alt_dosya_counter + "_dual" + "_ul.trp";
                            File.Copy(Ul_gelen, Ul_yeni);

                        }
                        else if (info4.Name.IndexOf("voice") != -1 || info4.Name.IndexOf("Voice") != -1 || info4.Name.IndexOf("Voice_3G") != -1 || info4.Name.IndexOf("VOICE") != -1)
                        {

                            String voice_gelen = ana_file + "\\" + info4.Name;
                            String voice_yeni = gelen_yol + @"\Logs" + "\\" + "st" + alt_dosya_counter + "_f" + ana_dosya_counter + "_voice.trp";
                            File.Copy(voice_gelen, voice_yeni);

                        }
                    }


                }
                else if (ana_file.Name.IndexOf("4") != -1)
                {

                    String cell4_gelen = gelen_u2100_eksik + "\\" + ana_file.Name; //Bu dosyanın konumu.
                    String cell4_yeni = gelen_u2100_eksik + "\\" + "s4";        //Dosyanın adının s1 olması için gereken kod.
                    Directory.Move(cell4_gelen, cell4_yeni4);      //gelen dosya x olsun biz bunu önce hhhh1 yapıyoruz.
                    Directory.Move(cell4_yeni4, cell4_yeni);

                    foreach (string str4 in Directory.GetFiles(cell4_yeni))
                    {
                        Elements.Items.Add(str4);               //Dosyanın işleme alındığını ekranda gösteriyor.
                        FileInfo info4 = new FileInfo(str4);

                        if (info4.Name.IndexOf("dl") != -1 || info4.Name.IndexOf("DL") != -1 || info4.Name.IndexOf("Dl") != -1 || info4.Name.IndexOf("dL") != -1)
                        {
                            String dl_gelen = ana_file + "\\" + info4.Name;
                            String dl_yeni = gelen_yol + @"\Logs" + "\\" +"st" + alt_dosya_counter + "_dual" + "_dl.trp";
                            File.Copy(dl_gelen, dl_yeni);
                        }
                        else if (info4.Name.IndexOf("ul") != -1 || info4.Name.IndexOf("UL") != -1 || info4.Name.IndexOf("Ul") != -1 || info4.Name.IndexOf("uL") != -1)
                        {
                            String Ul_gelen = ana_file + "\\" + info4.Name;
                            String Ul_yeni = gelen_yol + @"\Logs" + "\\" + "st" + alt_dosya_counter + "_dual" + "_ul.trp";
                            File.Copy(Ul_gelen, Ul_yeni);

                        }
                        else if (info4.Name.IndexOf("voice") != -1 || info4.Name.IndexOf("Voice") != -1 || info4.Name.IndexOf("Voice_3G") != -1 || info4.Name.IndexOf("VOICE") != -1)
                        {

                            String voice_gelen = ana_file + "\\" + info4.Name;
                            String voice_yeni = gelen_yol + @"\Logs" + "\\" + "st" + alt_dosya_counter + "_f" + ana_dosya_counter + "_voice.trp";
                            File.Copy(voice_gelen, voice_yeni);

                        }
                    }


                }
                else if (ana_file.Name.IndexOf("5") != -1)
                {

                    String cell5_gelen = gelen_u2100_eksik + "\\" + ana_file.Name; //Bu dosyanın konumu.
                    String cell5_yeni = gelen_u2100_eksik + "\\" + "s4";        //Dosyanın adının s1 olması için gereken kod.
                    Directory.Move(cell5_gelen, cell5_yeni5);      //gelen dosya x olsun biz bunu önce hhhh1 yapıyoruz.
                    Directory.Move(cell5_yeni5, cell5_yeni);

                    foreach (string str4 in Directory.GetFiles(cell5_yeni))
                    {
                        Elements.Items.Add(str4);               //Dosyanın işleme alındığını ekranda gösteriyor.
                        FileInfo info4 = new FileInfo(str4);

                        if (info4.Name.IndexOf("dl") != -1 || info4.Name.IndexOf("DL") != -1 || info4.Name.IndexOf("Dl") != -1 || info4.Name.IndexOf("dL") != -1)
                        {
                            String dl_gelen = ana_file + "\\" + info4.Name;
                            String dl_yeni = gelen_yol + @"\Logs" + "\\" + "st" + alt_dosya_counter + "_dual" + "_dl.trp";
                            File.Copy(dl_gelen, dl_yeni);
                        }
                        else if (info4.Name.IndexOf("ul") != -1 || info4.Name.IndexOf("UL") != -1 || info4.Name.IndexOf("Ul") != -1 || info4.Name.IndexOf("uL") != -1)
                        {
                            String Ul_gelen = ana_file + "\\" + info4.Name;
                            String Ul_yeni = gelen_yol + @"\Logs" + "\\" + "st" + alt_dosya_counter + "_dual" + "_ul.trp";
                            File.Copy(Ul_gelen, Ul_yeni);

                        }
                        else if (info4.Name.IndexOf("voice") != -1 || info4.Name.IndexOf("Voice") != -1 || info4.Name.IndexOf("Voice_3G") != -1 || info4.Name.IndexOf("VOICE") != -1)
                        {

                            String voice_gelen = ana_file + "\\" + info4.Name;
                            String voice_yeni = gelen_yol + @"\Logs" + "\\" + "st" + alt_dosya_counter + "_f" + ana_dosya_counter + "_voice.trp";
                            File.Copy(voice_gelen, voice_yeni);

                        }
                    }


                }
                else
                {
                    MessageBox.Show("Dosyalar EKSİK !! ");
                    alt_dosya_counter = 0;
                }

                try
                {
                    if (Directory.Exists(gelen_yol + @"\Mobility"))   //Seçilen yolda var ise.
                    {
                        int counter2 = 1;
                        string gelen_mob = gelen_yol + @"\Mobility";
                        string gidecek_mob = gelen_yol + @"\Logs";
                        string[] dosya_var = Directory.GetFiles(gelen_mob);
                        foreach (string i in dosya_var)
                        {
                            String a = i.ToUpper();
                            if (a.IndexOf(".JPG") != -1 || a.IndexOf(".png") != -1 || a.IndexOf(".JPEG") != -1 || a.IndexOf(".PNG") != -1)
                            {
                                continue;
                            }
                            else
                            {
                                if (counter2 == 1)
                                {
                                    String mob_change_name = gelen_yol + @"\Logs" + "\\" + "MOB.trp";
                                    File.Copy(i, mob_change_name);
                                    counter2++;
                                    Elements.Items.Add(i);
                                }
                                else
                                {
                                    String mob_change_name = gelen_yol + @"\Logs" + "\\" + "MOB" + counter2 + ".trp";
                                    File.Copy(i, mob_change_name);
                                    counter2++;
                                    Elements.Items.Add(i);
                                }
                            }

                        }
                    }

                    else //Dosya olarark ayarlanmamış dağınık bırakılmış ise 
                    {

                        string[] dosya_var = Directory.GetFiles(gelen_yol);
                        int counter2 = 1;
                        foreach (string i in dosya_var)
                        {
                            String a = i.ToUpper();
                            if (a.IndexOf(".JPG") != -1 || a.IndexOf(".png") != -1 || a.IndexOf(".JPEG") != -1 || a.IndexOf(".PNG") != -1)
                            {
                                continue;
                            }
                            else
                            {
                                if (counter2 == 1)
                                {
                                    String mob_change_name = gelen_yol + @"\Logs" + "\\" + "MOB.trp";
                                    File.Copy(i, mob_change_name);
                                    counter2++;
                                    Elements.Items.Add(i);
                                }
                                else
                                {
                                    String mob_change_name = gelen_yol + @"\Logs" + "\\" + "MOB" + counter2 + ".trp";
                                    File.Copy(i, mob_change_name);
                                    counter2++;
                                    Elements.Items.Add(i);
                                }
                            }

                        }
                    }


                }

                catch
                {

                }

            }



        }

        private void button3_Click_1(object sender, EventArgs e)
        {

            work_rename(gelen_yol);
        }

        private void button5_Click(object sender, EventArgs e) 
        {
            
                int ana_dosya_counter = 3;
                int alt_dosya_counter = 0;
                string gelen_u2100 = gelen_yol;
                int elm = 0;
                string[] child_files = Directory.GetDirectories(gelen_u2100);

                if (Directory.Exists(gelen_yol + @"\Logs"))
                {
                    Directory.Delete(gelen_yol + @"\Logs", true); //EĞER DAHA ÖNCE LOG DOSYASI VAR İSE SONU SİLİYORUZ. 
                }
                String asd3 = gelen_yol + "/" + "Logs";
                Directory.CreateDirectory(asd3);                 //Log dosyasını yeniden oluşturuyoruz.


                foreach (string child_files_u2100 in child_files) // Burada U2100 dosyalarının isimlendirmelerini yapıyoruz.
                {
                    FileInfo ana_file = new FileInfo(child_files_u2100);  //Elemanların hepsini file info altına alıyoruz. Bu şekilde dosyaları kontrol edebileceğiz.
                                                                          //İsmi DC olan klasör için ayrı işlem gerekiyor bundan dolayı bunu  farklı bir block içinde kullanıyoruz.
                    if (ana_file.Name.IndexOf("DC") != -1 || ana_file.Name.IndexOf("Dc") != -1 || ana_file.Name.IndexOf("dc") != -1 || ana_file.Name.IndexOf("dC") != -1)
                    {
                        Elements.Items.Add("Ana Dosyamız:");
                        Elements.Items.Add(child_files_u2100);      //Ana dosyalarımızın hepsini Ekrana yazdırıyoruz.
                        foreach (string first_file in Directory.GetDirectories(child_files_u2100))
                        {
                            alt_dosya_counter++;
                            Elements.Items.Add("Alt dosyalarımız.");
                            Elements.Items.Add(first_file);     //Alt dosyalarımızı ekrana yazdırıyoruz.
                                                                // MessageBox.Show("Alt dosyamız" + Convert.ToString(alt_dosya_counter));
                            FileInfo dosya_içi = new FileInfo(first_file);
                            String cell1_yeni1 = child_files_u2100 + "\\" + "hhhh1";  //S1 olarak ayarlanan bir dosyanın adı önce hhh1 olarak ayarlanacak.
                            String cell2_yeni2 = child_files_u2100 + "\\" + "hhhh2";  //s2 olarak ayarlanan bir dosyanın adı sonra hh2 olarak ayarlanacak.
                            String cell3_yeni3 = child_files_u2100 + "\\" + "hhhh3";  //s3 olarak ayarlanan bir dosyanın adı önce hh3 olarak ayarlanacak.
                            String cell4_yeni4 = child_files_u2100 + "\\" + "hhhh4";  //s2 olarak ayarlanan bir dosyanın adı sonra hh2 olarak ayarlanacak.
                            String cell5_yeni5 = child_files_u2100 + "\\" + "hhhh5";  //s3 olarak ayarlanan bir dosyanın adı önce hh3 olarak ayarlanacak.

                            if (alt_dosya_counter > 5)
                            {
                                alt_dosya_counter = 4;
                            }

                            if (dosya_içi.Name.IndexOf("1") != -1)                //Dosyanın adında 1 geçiyor ise.
                            {

                                String cell1_gelen = child_files_u2100 + "\\" + dosya_içi.Name; //Bu dosyanın konumu.
                                String cell1_yeni = child_files_u2100 + "\\" + "s1";        //Dosyanın adının s1 olması için gereken kod.
                                Directory.Move(cell1_gelen, cell1_yeni1);      //gelen dosya x olsun biz bunu önce hhhh1 yapıyoruz.
                                Directory.Move(cell1_yeni1, cell1_yeni);

                                foreach (string str4 in Directory.GetFiles(cell1_yeni))
                                {
                                    Elements.Items.Add(str4);               //Dosyanın işleme alındığını ekranda gösteriyor.
                                    FileInfo info4 = new FileInfo(str4);

                                    if (info4.Name.IndexOf("dl") != -1 || info4.Name.IndexOf("DL") != -1 || info4.Name.IndexOf("Dl") != -1 || info4.Name.IndexOf("dL") != -1)
                                    {
                                        String dl_gelen = first_file + "\\" + info4.Name;
                                        String dl_yeni = gelen_yol + @"\Logs" + "\\" + "st" + alt_dosya_counter + "_dual" + "_dl.trp";
                                        File.Copy(dl_gelen, dl_yeni);
                                    }
                                    else if (info4.Name.IndexOf("ul") != -1 || info4.Name.IndexOf("UL") != -1 || info4.Name.IndexOf("Ul") != -1 || info4.Name.IndexOf("uL") != -1)
                                    {
                                        String Ul_gelen = first_file + "\\" + info4.Name;
                                        String Ul_yeni = gelen_yol + @"\Logs" + "\\" + "st" + alt_dosya_counter + "_dual" + "_ul.trp";
                                        File.Copy(Ul_gelen, Ul_yeni);

                                    }
                                    else if (info4.Name.IndexOf("voice") != -1 || info4.Name.IndexOf("Voice") != -1 || info4.Name.IndexOf("Voice_3G") != -1 || info4.Name.IndexOf("VOICE") != -1)
                                    {

                                        String voice_gelen = first_file + "\\" + info4.Name;
                                        String voice_yeni = gelen_yol + @"\Logs" + "\\" + "st" + alt_dosya_counter + "_dual" + "_voice.trp";
                                        File.Copy(voice_gelen, voice_yeni);

                                    }
                                }







                            }
                            else if (dosya_içi.Name.IndexOf("2") != -1)                //Dosyanın adında 1 geçiyor ise.
                            {

                                String cell2_gelen = child_files_u2100 + "\\" + dosya_içi.Name; //Bu dosyanın konumu.
                                String cell2_yeni = child_files_u2100 + "\\" + "s2";        //Dosyanın adının s1 olması için gereken kod.
                                Directory.Move(cell2_gelen, cell2_yeni2);      //gelen dosya x olsun biz bunu önce hhhh1 yapıyoruz.
                                Directory.Move(cell2_yeni2, cell2_yeni);

                                foreach (string str4 in Directory.GetFiles(cell2_yeni))
                                {
                                    Elements.Items.Add(str4);               //Dosyanın işleme alındığını ekranda gösteriyor.
                                    FileInfo info4 = new FileInfo(str4);
                                    if (info4.Name.IndexOf("dl") != -1 || info4.Name.IndexOf("DL") != -1 || info4.Name.IndexOf("Dl") != -1 || info4.Name.IndexOf("dL") != -1)
                                    {
                                        String dl_gelen = first_file + "\\" + info4.Name;
                                        String dl_yeni = gelen_yol + @"\Logs" + "\\" + "st" + alt_dosya_counter + "_dual" + "_dl.trp";
                                        File.Copy(dl_gelen, dl_yeni);
                                    }
                                    else if (info4.Name.IndexOf("ul") != -1 || info4.Name.IndexOf("UL") != -1 || info4.Name.IndexOf("Ul") != -1 || info4.Name.IndexOf("uL") != -1)
                                    {
                                        String Ul_gelen = first_file + "\\" + info4.Name;
                                        String Ul_yeni = gelen_yol + @"\Logs" + "\\" + "st" + alt_dosya_counter + "_dual" + "_ul.trp";
                                        File.Copy(Ul_gelen, Ul_yeni);

                                    }
                                    else if (info4.Name.IndexOf("voice") != -1 || info4.Name.IndexOf("Voice") != -1 || info4.Name.IndexOf("Voice_3G") != -1 || info4.Name.IndexOf("VOICE") != -1)
                                    {

                                        String voice_gelen = first_file + "\\" + info4.Name;
                                        String voice_yeni = gelen_yol + @"\Logs" + "\\" + "st" + alt_dosya_counter + "_dual" + "_voice.trp";
                                        File.Copy(voice_gelen, voice_yeni);

                                    }
                                }







                            }
                            else if (dosya_içi.Name.IndexOf("3") != -1)                //Dosyanın adında 1 geçiyor ise.
                            {

                                String cell3_gelen = child_files_u2100 + "\\" + dosya_içi.Name; //Bu dosyanın konumu.
                                String cell3_yeni = child_files_u2100 + "\\" + "s3";        //Dosyanın adının s1 olması için gereken kod.
                                Directory.Move(cell3_gelen, cell3_yeni3);      //gelen dosya x olsun biz bunu önce hhhh1 yapıyoruz.
                                Directory.Move(cell3_yeni3, cell3_yeni);

                                foreach (string str4 in Directory.GetFiles(cell3_yeni))
                                {
                                    Elements.Items.Add(str4);               //Dosyanın işleme alındığını ekranda gösteriyor.
                                    FileInfo info4 = new FileInfo(str4);
                                    if (info4.Name.IndexOf("dl") != -1 || info4.Name.IndexOf("DL") != -1 || info4.Name.IndexOf("Dl") != -1 || info4.Name.IndexOf("dL") != -1)
                                    {
                                        String dl_gelen = first_file + "\\" + info4.Name;
                                        String dl_yeni = gelen_yol + @"\Logs" + "\\" + "st" + alt_dosya_counter + "_dual" + "_dl.trp";
                                        File.Copy(dl_gelen, dl_yeni);
                                    }
                                    else if (info4.Name.IndexOf("ul") != -1 || info4.Name.IndexOf("UL") != -1 || info4.Name.IndexOf("Ul") != -1 || info4.Name.IndexOf("uL") != -1)
                                    {
                                        String Ul_gelen = first_file + "\\" + info4.Name;
                                        String Ul_yeni = gelen_yol + @"\Logs" + "\\" + "st" + alt_dosya_counter + "_dual" + "_ul.trp";
                                        File.Copy(Ul_gelen, Ul_yeni);

                                    }
                                    else if (info4.Name.IndexOf("voice") != -1 || info4.Name.IndexOf("Voice") != -1 || info4.Name.IndexOf("Voice_3G") != -1 || info4.Name.IndexOf("VOICE") != -1)
                                    {

                                        String voice_gelen = first_file + "\\" + info4.Name;
                                        String voice_yeni = gelen_yol + @"\Logs" + "\\" + "st" + alt_dosya_counter + "_dual" + "_voice.trp";
                                        File.Copy(voice_gelen, voice_yeni);

                                    }
                                }







                            }
                            else if (dosya_içi.Name.IndexOf("4") != -1)                //Dosyanın adında 1 geçiyor ise.
                            {

                                String cell4_gelen = child_files_u2100 + "\\" + dosya_içi.Name; //Bu dosyanın konumu.
                                String cell4_yeni = child_files_u2100 + "\\" + "s4";        //Dosyanın adının s1 olması için gereken kod.
                                Directory.Move(cell4_gelen, cell4_yeni4);      //gelen dosya x olsun biz bunu önce hhhh1 yapıyoruz.
                                Directory.Move(cell4_yeni4, cell4_yeni);

                                foreach (string str4 in Directory.GetFiles(cell4_yeni))
                                {
                                    Elements.Items.Add(str4);               //Dosyanın işleme alındığını ekranda gösteriyor.
                                    FileInfo info4 = new FileInfo(str4);
                                    if (info4.Name.IndexOf("dl") != -1 || info4.Name.IndexOf("DL") != -1 || info4.Name.IndexOf("Dl") != -1 || info4.Name.IndexOf("dL") != -1)
                                    {
                                        String dl_gelen = first_file + "\\" + info4.Name;
                                        String dl_yeni = gelen_yol + @"\Logs" + "\\" + "st" + alt_dosya_counter + "_dual" + "_dl.trp";
                                        File.Copy(dl_gelen, dl_yeni);
                                    }
                                    else if (info4.Name.IndexOf("ul") != -1 || info4.Name.IndexOf("UL") != -1 || info4.Name.IndexOf("Ul") != -1 || info4.Name.IndexOf("uL") != -1)
                                    {
                                        String Ul_gelen = first_file + "\\" + info4.Name;
                                        String Ul_yeni = gelen_yol + @"\Logs" + "\\" + "st" + alt_dosya_counter + "_dual" + "_ul.trp";
                                        File.Copy(Ul_gelen, Ul_yeni);

                                    }
                                    else if (info4.Name.IndexOf("voice") != -1 || info4.Name.IndexOf("Voice") != -1 || info4.Name.IndexOf("Voice_3G") != -1 || info4.Name.IndexOf("VOICE") != -1)
                                    {

                                        String voice_gelen = first_file + "\\" + info4.Name;
                                        String voice_yeni = gelen_yol + @"\Logs" + "\\" + "st" + alt_dosya_counter + "_dual" + "_voice.trp";
                                        File.Copy(voice_gelen, voice_yeni);

                                    }
                                }



                            }
                            else if (dosya_içi.Name.IndexOf("5") != -1)                //Dosyanın adında 1 geçiyor ise.
                            {

                                String cell5_gelen = child_files_u2100 + "\\" + dosya_içi.Name; //Bu dosyanın konumu.
                                String cell5_yeni = child_files_u2100 + "\\" + "s5";        //Dosyanın adının s1 olması için gereken kod.
                                Directory.Move(cell5_gelen, cell5_yeni5);      //gelen dosya x olsun biz bunu önce hhhh1 yapıyoruz.
                                Directory.Move(cell5_yeni5, cell5_yeni);

                                foreach (string str4 in Directory.GetFiles(cell5_yeni))
                                {
                                    Elements.Items.Add(str4);               //Dosyanın işleme alındığını ekranda gösteriyor.
                                    FileInfo info4 = new FileInfo(str4);
                                    if (info4.Name.IndexOf("dl") != -1 || info4.Name.IndexOf("DL") != -1 || info4.Name.IndexOf("Dl") != -1 || info4.Name.IndexOf("dL") != -1)
                                    {
                                        String dl_gelen = first_file + "\\" + info4.Name;
                                        String dl_yeni = gelen_yol + @"\Logs" + "\\" + "st" + alt_dosya_counter + "_dual" + "_dl.trp";
                                        File.Copy(dl_gelen, dl_yeni);
                                    }
                                    else if (info4.Name.IndexOf("ul") != -1 || info4.Name.IndexOf("UL") != -1 || info4.Name.IndexOf("Ul") != -1 || info4.Name.IndexOf("uL") != -1)
                                    {
                                        String Ul_gelen = first_file + "\\" + info4.Name;
                                        String Ul_yeni = gelen_yol + @"\Logs" + "\\" + "st" + alt_dosya_counter + "_dual" + "_ul.trp";
                                        File.Copy(Ul_gelen, Ul_yeni);

                                    }
                                    else if (info4.Name.IndexOf("voice") != -1 || info4.Name.IndexOf("Voice") != -1 || info4.Name.IndexOf("Voice_3G") != -1 || info4.Name.IndexOf("VOICE") != -1)
                                    {

                                        String voice_gelen = first_file + "\\" + info4.Name;
                                        String voice_yeni = gelen_yol + @"\Logs" + "\\" + "st" + alt_dosya_counter + "_dual" + "_voice.trp";
                                        File.Copy(voice_gelen, voice_yeni);

                                    }
                                }







                            }
                            else
                            {
                                MessageBox.Show("Dosyalar EKSİK !! ");
                            }
                        }
                    }
                    else
                    {
                        Elements.Items.Add("Ana Dosyamız:");
                        Elements.Items.Add(child_files_u2100);
                        ana_dosya_counter++;
                        //MessageBox.Show(Convert.ToString(ana_dosya_counter));
                        foreach (string first_file in Directory.GetDirectories(child_files_u2100))
                        {
                            alt_dosya_counter++;
                            Elements.Items.Add("Alt dosyalarımız.");
                            Elements.Items.Add(first_file);
                            //MessageBox.Show("Alt dosyamız"+Convert.ToString(alt_dosya_counter));
                            FileInfo dosya_içi = new FileInfo(first_file);
                            String cell1_yeni1 = child_files_u2100 + "\\" + "hhhh1";  //S1 olarak ayarlanan bir dosyanın adı önce hhh1 olarak ayarlanacak.
                            String cell2_yeni2 = child_files_u2100 + "\\" + "hhhh2";  //s2 olarak ayarlanan bir dosyanın adı sonra hh2 olarak ayarlanacak.
                            String cell3_yeni3 = child_files_u2100 + "\\" + "hhhh3";  //s3 olarak ayarlanan bir dosyanın adı önce hh3 olarak ayarlanacak.
                            String cell4_yeni4 = child_files_u2100 + "\\" + "hhhh4";  //s2 olarak ayarlanan bir dosyanın adı sonra hh2 olarak ayarlanacak.
                            String cell5_yeni5 = child_files_u2100 + "\\" + "hhhh5";  //s3 olarak ayarlanan bir dosyanın adı önce hh3 olarak ayarlanacak.

                            if (alt_dosya_counter > 5)
                            {
                                alt_dosya_counter = 4;
                            }

                            if (dosya_içi.Name.IndexOf("1") != -1)                //Dosyanın adında 1 geçiyor ise.
                            {

                                String cell1_gelen = child_files_u2100 + "\\" + dosya_içi.Name; //Bu dosyanın konumu.
                                String cell1_yeni = child_files_u2100 + "\\" + "s1";        //Dosyanın adının s1 olması için gereken kod.
                                Directory.Move(cell1_gelen, cell1_yeni1);      //gelen dosya x olsun biz bunu önce hhhh1 yapıyoruz.
                                Directory.Move(cell1_yeni1, cell1_yeni);

                                foreach (string str4 in Directory.GetFiles(cell1_yeni))
                                {
                                    Elements.Items.Add(str4);               //Dosyanın işleme alındığını ekranda gösteriyor.
                                    FileInfo info4 = new FileInfo(str4);

                                    if (info4.Name.IndexOf("dl") != -1 || info4.Name.IndexOf("DL") != -1 || info4.Name.IndexOf("Dl") != -1 || info4.Name.IndexOf("dL") != -1)
                                    {
                                        String dl_gelen = first_file + "\\" + info4.Name;
                                        String dl_yeni = gelen_yol + @"\Logs" + "\\" + "st" + alt_dosya_counter + "_f" + ana_dosya_counter + "_dl.trp";
                                        File.Copy(dl_gelen, dl_yeni);
                                    }
                                    else if (info4.Name.IndexOf("ul") != -1 || info4.Name.IndexOf("UL") != -1 || info4.Name.IndexOf("Ul") != -1 || info4.Name.IndexOf("uL") != -1)
                                    {
                                        String Ul_gelen = first_file + "\\" + info4.Name;
                                        String Ul_yeni = gelen_yol + @"\Logs" + "\\" + "st" + alt_dosya_counter + "_f" + ana_dosya_counter + "_ul.trp";
                                        File.Copy(Ul_gelen, Ul_yeni);

                                    }
                                    else if (info4.Name.IndexOf("voice") != -1 || info4.Name.IndexOf("Voice") != -1 || info4.Name.IndexOf("Voice_3G") != -1 || info4.Name.IndexOf("VOICE") != -1)
                                    {

                                        String voice_gelen = first_file + "\\" + info4.Name;
                                        String voice_yeni = gelen_yol + @"\Logs" + "\\" + "st" + alt_dosya_counter + "_f" + ana_dosya_counter + "_voice.trp";
                                        File.Copy(voice_gelen, voice_yeni);

                                    }
                                }







                            }
                            else if (dosya_içi.Name.IndexOf("2") != -1)                //Dosyanın adında 1 geçiyor ise.
                            {

                                String cell2_gelen = child_files_u2100 + "\\" + dosya_içi.Name; //Bu dosyanın konumu.
                                String cell2_yeni = child_files_u2100 + "\\" + "s2";        //Dosyanın adının s1 olması için gereken kod.
                                Directory.Move(cell2_gelen, cell2_yeni2);      //gelen dosya x olsun biz bunu önce hhhh1 yapıyoruz.
                                Directory.Move(cell2_yeni2, cell2_yeni);

                                foreach (string str4 in Directory.GetFiles(cell2_yeni))
                                {
                                    Elements.Items.Add(str4);               //Dosyanın işleme alındığını ekranda gösteriyor.
                                    FileInfo info4 = new FileInfo(str4);
                                    if (info4.Name.IndexOf("dl") != -1 || info4.Name.IndexOf("DL") != -1 || info4.Name.IndexOf("Dl") != -1 || info4.Name.IndexOf("dL") != -1)
                                    {
                                        String dl_gelen = first_file + "\\" + info4.Name;
                                        String dl_yeni = gelen_yol + @"\Logs" + "\\" + "st" + alt_dosya_counter + "_f" + ana_dosya_counter + "_dl.trp";
                                        File.Copy(dl_gelen, dl_yeni);
                                    }
                                    else if (info4.Name.IndexOf("ul") != -1 || info4.Name.IndexOf("UL") != -1 || info4.Name.IndexOf("Ul") != -1 || info4.Name.IndexOf("uL") != -1)
                                    {
                                        String Ul_gelen = first_file + "\\" + info4.Name;
                                        String Ul_yeni = gelen_yol + @"\Logs" + "\\" + "st" + alt_dosya_counter + "_f" + ana_dosya_counter + "_ul.trp";
                                        File.Copy(Ul_gelen, Ul_yeni);

                                    }
                                    else if (info4.Name.IndexOf("voice") != -1 || info4.Name.IndexOf("Voice") != -1 || info4.Name.IndexOf("Voice_3G") != -1 || info4.Name.IndexOf("VOICE") != -1)
                                    {

                                        String voice_gelen = first_file + "\\" + info4.Name;
                                        String voice_yeni = gelen_yol + @"\Logs" + "\\" + "st" + alt_dosya_counter + "_f" + ana_dosya_counter + "_voice.trp";
                                        File.Copy(voice_gelen, voice_yeni);

                                    }
                                }







                            }
                            else if (dosya_içi.Name.IndexOf("3") != -1)                //Dosyanın adında 1 geçiyor ise.
                            {

                                String cell3_gelen = child_files_u2100 + "\\" + dosya_içi.Name; //Bu dosyanın konumu.
                                String cell3_yeni = child_files_u2100 + "\\" + "s3";        //Dosyanın adının s1 olması için gereken kod.
                                Directory.Move(cell3_gelen, cell3_yeni3);      //gelen dosya x olsun biz bunu önce hhhh1 yapıyoruz.
                                Directory.Move(cell3_yeni3, cell3_yeni);

                                foreach (string str4 in Directory.GetFiles(cell3_yeni))
                                {
                                    Elements.Items.Add(str4);               //Dosyanın işleme alındığını ekranda gösteriyor.
                                    FileInfo info4 = new FileInfo(str4);
                                    if (info4.Name.IndexOf("dl") != -1 || info4.Name.IndexOf("DL") != -1 || info4.Name.IndexOf("Dl") != -1 || info4.Name.IndexOf("dL") != -1)
                                    {
                                        String dl_gelen = first_file + "\\" + info4.Name;
                                        String dl_yeni = gelen_yol + @"\Logs" + "\\" + "st" + alt_dosya_counter + "_f" + ana_dosya_counter + "_dl.trp";
                                        File.Copy(dl_gelen, dl_yeni);
                                    }
                                    else if (info4.Name.IndexOf("ul") != -1 || info4.Name.IndexOf("UL") != -1 || info4.Name.IndexOf("Ul") != -1 || info4.Name.IndexOf("uL") != -1)
                                    {
                                        String Ul_gelen = first_file + "\\" + info4.Name;
                                        String Ul_yeni = gelen_yol + @"\Logs" + "\\" + "st" + alt_dosya_counter + "_f" + ana_dosya_counter + "_ul.trp";
                                        File.Copy(Ul_gelen, Ul_yeni);

                                    }
                                    else if (info4.Name.IndexOf("voice") != -1 || info4.Name.IndexOf("Voice") != -1 || info4.Name.IndexOf("Voice_3G") != -1 || info4.Name.IndexOf("VOICE") != -1)
                                    {

                                        String voice_gelen = first_file + "\\" + info4.Name;
                                        String voice_yeni = gelen_yol + @"\Logs" + "\\" + "st" + alt_dosya_counter + "_f" + ana_dosya_counter + "_voice.trp";
                                        File.Copy(voice_gelen, voice_yeni);

                                    }
                                }







                            }
                            else if (dosya_içi.Name.IndexOf("4") != -1)                //Dosyanın adında 1 geçiyor ise.
                            {

                                String cell4_gelen = child_files_u2100 + "\\" + dosya_içi.Name; //Bu dosyanın konumu.
                                String cell4_yeni = child_files_u2100 + "\\" + "s4";        //Dosyanın adının s1 olması için gereken kod.
                                Directory.Move(cell4_gelen, cell4_yeni4);      //gelen dosya x olsun biz bunu önce hhhh1 yapıyoruz.
                                Directory.Move(cell4_yeni4, cell4_yeni);

                                foreach (string str4 in Directory.GetFiles(cell4_yeni))
                                {
                                    Elements.Items.Add(str4);               //Dosyanın işleme alındığını ekranda gösteriyor.
                                    FileInfo info4 = new FileInfo(str4);
                                    if (info4.Name.IndexOf("dl") != -1 || info4.Name.IndexOf("DL") != -1 || info4.Name.IndexOf("Dl") != -1 || info4.Name.IndexOf("dL") != -1)
                                    {
                                        String dl_gelen = first_file + "\\" + info4.Name;
                                        String dl_yeni = gelen_yol + @"\Logs" + "\\" + "st" + alt_dosya_counter + "_f" + ana_dosya_counter + "_dl.trp";
                                        File.Copy(dl_gelen, dl_yeni);
                                    }
                                    else if (info4.Name.IndexOf("ul") != -1 || info4.Name.IndexOf("UL") != -1 || info4.Name.IndexOf("Ul") != -1 || info4.Name.IndexOf("uL") != -1)
                                    {
                                        String Ul_gelen = first_file + "\\" + info4.Name;
                                        String Ul_yeni = gelen_yol + @"\Logs" + "\\" + "st" + alt_dosya_counter + "_f" + ana_dosya_counter + "_ul.trp";
                                        File.Copy(Ul_gelen, Ul_yeni);

                                    }
                                    else if (info4.Name.IndexOf("voice") != -1 || info4.Name.IndexOf("Voice") != -1 || info4.Name.IndexOf("Voice_3G") != -1 || info4.Name.IndexOf("VOICE") != -1)
                                    {

                                        String voice_gelen = first_file + "\\" + info4.Name;
                                        String voice_yeni = gelen_yol + @"\Logs" + "\\" + "st" + alt_dosya_counter + "_f" + ana_dosya_counter + "_voice.trp";
                                        File.Copy(voice_gelen, voice_yeni);

                                    }
                                }







                            }
                            else if (dosya_içi.Name.IndexOf("5") != -1)                //Dosyanın adında 1 geçiyor ise.
                            {

                                String cell5_gelen = child_files_u2100 + "\\" + dosya_içi.Name; //Bu dosyanın konumu.
                                String cell5_yeni = child_files_u2100 + "\\" + "s5";        //Dosyanın adının s1 olması için gereken kod.
                                Directory.Move(cell5_gelen, cell5_yeni5);      //gelen dosya x olsun biz bunu önce hhhh1 yapıyoruz.
                                Directory.Move(cell5_yeni5, cell5_yeni);

                                foreach (string str4 in Directory.GetFiles(cell5_yeni))
                                {
                                    Elements.Items.Add(str4);               //Dosyanın işleme alındığını ekranda gösteriyor.
                                    FileInfo info4 = new FileInfo(str4);
                                    if (info4.Name.IndexOf("dl") != -1 || info4.Name.IndexOf("DL") != -1 || info4.Name.IndexOf("Dl") != -1 || info4.Name.IndexOf("dL") != -1)
                                    {
                                        String dl_gelen = first_file + "\\" + info4.Name;
                                        String dl_yeni = gelen_yol + @"\Logs" + "\\" + "st" + alt_dosya_counter + "_f" + ana_dosya_counter + "_dl.trp";
                                        File.Copy(dl_gelen, dl_yeni);
                                    }
                                    else if (info4.Name.IndexOf("ul") != -1 || info4.Name.IndexOf("UL") != -1 || info4.Name.IndexOf("Ul") != -1 || info4.Name.IndexOf("uL") != -1)
                                    {
                                        String Ul_gelen = first_file + "\\" + info4.Name;
                                        String Ul_yeni = gelen_yol + @"\Logs" + "\\" + "st" + alt_dosya_counter + "_f" + ana_dosya_counter + "_ul.trp";
                                        File.Copy(Ul_gelen, Ul_yeni);

                                    }
                                    else if (info4.Name.IndexOf("voice") != -1 || info4.Name.IndexOf("Voice") != -1 || info4.Name.IndexOf("Voice_3G") != -1 || info4.Name.IndexOf("VOICE") != -1)
                                    {

                                        String voice_gelen = first_file + "\\" + info4.Name;
                                        String voice_yeni = gelen_yol + @"\Logs" + "\\" + "st" + alt_dosya_counter + "_f" + ana_dosya_counter + "_voice.trp";
                                        File.Copy(voice_gelen, voice_yeni);

                                    }
                                }







                            }
                            else
                            {
                                MessageBox.Show("Dosyalar EKSİK !! ");
                                alt_dosya_counter = 0;
                            }
                        }
                    }

              
                }

            try
            {
                if (Directory.Exists(gelen_yol + @"\Mobility"))   //Seçilen yolda var ise.
                {
                    
                    string gelen_mob = gelen_yol + @"\Mobility";
                    string gidecek_mob = gelen_yol + @"\Logs";
                    string[] dosya_var = Directory.GetFiles(gelen_mob);
                    foreach (string i in dosya_var)
                    {
                        FileInfo mobil1 = new FileInfo(i);
                        String mob_change_name = gelen_yol + @"\Logs"+ "\\"+mobil1.Name;
                        File.Copy(i, mob_change_name);
                        Elements.Items.Add(i);
                    }

                }
                else
                {
                    string[] dosya_var = Directory.GetFiles(gelen_yol);
                    foreach (string i in dosya_var)
                    {
                        FileInfo mobil1 = new FileInfo(i);
                        String mob_change_name = gelen_yol + @"\Logs" + "\\" + mobil1.Name;
                        File.Copy(i, mob_change_name);
                        Elements.Items.Add(i);
                    }
                }
            }
            catch
            {

            }
        }
         

        private void button6_Click(object sender, EventArgs e)
        {
                int ana_dosya_counter = 3;
                int alt_dosya_counter = 0;
                string gelen_u2100_eksik = gelen_yol;
                string[] child_files = Directory.GetDirectories(gelen_u2100_eksik);

                if (Directory.Exists(gelen_yol + @"\Logs"))
                {
                    Directory.Delete(gelen_yol + @"\Logs", true); //EĞER DAHA ÖNCE LOG DOSYASI VAR İSE SONU SİLİYORUZ. 
                }
                String asd3 = gelen_yol + "/" + "Logs";
                Directory.CreateDirectory(asd3);

                foreach (string iç_dosyalar in child_files)
                {
                    FileInfo ana_file = new FileInfo(iç_dosyalar);
                    String cell1_yeni1 = gelen_u2100_eksik + "\\" + "hhhh1";  //S1 olarak ayarlanan bir dosyanın adı önce hhh1 olarak ayarlanacak.
                    String cell2_yeni2 = gelen_u2100_eksik + "\\" + "hhhh2";  //s2 olarak ayarlanan bir dosyanın adı sonra hh2 olarak ayarlanacak.
                    String cell3_yeni3 = gelen_u2100_eksik + "\\" + "hhhh3";  //s3 olarak ayarlanan bir dosyanın adı önce hh3 olarak ayarlanacak.
                    String cell4_yeni4 = gelen_u2100_eksik + "\\" + "hhhh4";  //s4 olarak ayarlanan bir dosyanın adı sonra hh2 olarak ayarlanacak.
                    String cell5_yeni5 = gelen_u2100_eksik + "\\" + "hhhh5";  //s5 olarak ayarlanan bir dosyanın adı önce hh3 olarak ayarlanacak.
                    alt_dosya_counter++;
                    if (ana_file.Name.IndexOf("1") != -1)
                    {

                        String cell1_gelen = gelen_u2100_eksik + "\\" + ana_file.Name; //Bu dosyanın konumu.
                        String cell1_yeni = gelen_u2100_eksik + "\\" + "s1";        //Dosyanın adının s1 olması için gereken kod.
                        Directory.Move(cell1_gelen, cell1_yeni1);      //gelen dosya x olsun biz bunu önce hhhh1 yapıyoruz.
                        Directory.Move(cell1_yeni1, cell1_yeni);
                        ana_dosya_counter++;

                        foreach (string str4 in Directory.GetFiles(cell1_yeni))
                        {
                            Elements.Items.Add(str4);               //Dosyanın işleme alındığını ekranda gösteriyor.
                            FileInfo info4 = new FileInfo(str4);

                            if (info4.Name.IndexOf("dl") != -1 || info4.Name.IndexOf("DL") != -1 || info4.Name.IndexOf("Dl") != -1 || info4.Name.IndexOf("dL") != -1)
                            {
                                String dl_gelen = ana_file + "\\" + info4.Name;
                                String dl_yeni = gelen_yol + @"\Logs" + "\\" + "st" + alt_dosya_counter + "_dual" + "_dl.trp";
                                File.Copy(dl_gelen, dl_yeni);
                            }
                            else if (info4.Name.IndexOf("ul") != -1 || info4.Name.IndexOf("UL") != -1 || info4.Name.IndexOf("Ul") != -1 || info4.Name.IndexOf("uL") != -1)
                            {
                                String Ul_gelen = ana_file + "\\" + info4.Name;
                                String Ul_yeni = gelen_yol + @"\Logs" + "\\" + "st" + alt_dosya_counter + "_dual" + "_ul.trp";
                                File.Copy(Ul_gelen, Ul_yeni);

                            }
                            else if (info4.Name.IndexOf("voice") != -1 || info4.Name.IndexOf("Voice") != -1 || info4.Name.IndexOf("Voice_3G") != -1 || info4.Name.IndexOf("VOICE") != -1)
                            {

                                String voice_gelen = ana_file + "\\" + info4.Name;
                                String voice_yeni = gelen_yol + @"\Logs" + "\\" + "st" + alt_dosya_counter + "_f" + ana_dosya_counter + "_voice.trp";
                                File.Copy(voice_gelen, voice_yeni);

                            }
                        }


                    }
                    else if (ana_file.Name.IndexOf("2") != -1)
                    {

                        String cell2_gelen = gelen_u2100_eksik + "\\" + ana_file.Name; //Bu dosyanın konumu.
                        String cell2_yeni = gelen_u2100_eksik + "\\" + "s2";        //Dosyanın adının s1 olması için gereken kod.
                        Directory.Move(cell2_gelen, cell2_yeni2);      //gelen dosya x olsun biz bunu önce hhhh1 yapıyoruz.
                        Directory.Move(cell2_yeni2, cell2_yeni);

                        foreach (string str4 in Directory.GetFiles(cell2_yeni))
                        {
                            Elements.Items.Add(str4);               //Dosyanın işleme alındığını ekranda gösteriyor.
                            FileInfo info4 = new FileInfo(str4);

                            if (info4.Name.IndexOf("dl") != -1 || info4.Name.IndexOf("DL") != -1 || info4.Name.IndexOf("Dl") != -1 || info4.Name.IndexOf("dL") != -1)
                            {
                                String dl_gelen = ana_file + "\\" + info4.Name;
                                String dl_yeni = gelen_yol + @"\Logs" + "\\" + "st" + alt_dosya_counter + "_dual" + "_dl.trp";
                                File.Copy(dl_gelen, dl_yeni);
                            }
                            else if (info4.Name.IndexOf("ul") != -1 || info4.Name.IndexOf("UL") != -1 || info4.Name.IndexOf("Ul") != -1 || info4.Name.IndexOf("uL") != -1)
                            {
                                String Ul_gelen = ana_file + "\\" + info4.Name;
                                String Ul_yeni = gelen_yol + @"\Logs" + "\\" + "st" + alt_dosya_counter + "_dual" + "_ul.trp";
                                File.Copy(Ul_gelen, Ul_yeni);

                            }
                            else if (info4.Name.IndexOf("voice") != -1 || info4.Name.IndexOf("Voice") != -1 || info4.Name.IndexOf("Voice_3G") != -1 || info4.Name.IndexOf("VOICE") != -1)
                            {

                                String voice_gelen = ana_file + "\\" + info4.Name;
                                String voice_yeni = gelen_yol + @"\Logs" + "\\" + "st" + alt_dosya_counter + "_f" + ana_dosya_counter + "_voice.trp";
                                File.Copy(voice_gelen, voice_yeni);

                            }
                        }


                    }
                    else if (ana_file.Name.IndexOf("3") != -1)
                    {

                        String cell3_gelen = gelen_u2100_eksik + "\\" + ana_file.Name; //Bu dosyanın konumu.
                        String cell3_yeni = gelen_u2100_eksik + "\\" + "s3";        //Dosyanın adının s1 olması için gereken kod.
                        Directory.Move(cell3_gelen, cell3_yeni3);      //gelen dosya x olsun biz bunu önce hhhh1 yapıyoruz.
                        Directory.Move(cell3_yeni3, cell3_yeni);

                        foreach (string str4 in Directory.GetFiles(cell3_yeni))
                        {
                            Elements.Items.Add(str4);               //Dosyanın işleme alındığını ekranda gösteriyor.
                            FileInfo info4 = new FileInfo(str4);

                            if (info4.Name.IndexOf("dl") != -1 || info4.Name.IndexOf("DL") != -1 || info4.Name.IndexOf("Dl") != -1 || info4.Name.IndexOf("dL") != -1)
                            {
                                String dl_gelen = ana_file + "\\" + info4.Name;
                                String dl_yeni = gelen_yol + @"\Logs" + "\\" + "st" + alt_dosya_counter + "_dual" + "_dl.trp";
                                File.Copy(dl_gelen, dl_yeni);
                            }
                            else if (info4.Name.IndexOf("ul") != -1 || info4.Name.IndexOf("UL") != -1 || info4.Name.IndexOf("Ul") != -1 || info4.Name.IndexOf("uL") != -1)
                            {
                                String Ul_gelen = ana_file + "\\" + info4.Name;
                                String Ul_yeni = gelen_yol + @"\Logs" + "\\" + "st" + alt_dosya_counter + "_dual" + "_ul.trp";
                                File.Copy(Ul_gelen, Ul_yeni);

                            }
                            else if (info4.Name.IndexOf("voice") != -1 || info4.Name.IndexOf("Voice") != -1 || info4.Name.IndexOf("Voice_3G") != -1 || info4.Name.IndexOf("VOICE") != -1)
                            {

                                String voice_gelen = ana_file + "\\" + info4.Name;
                                String voice_yeni = gelen_yol + @"\Logs" + "\\" + "st" + alt_dosya_counter + "_f" + ana_dosya_counter + "_voice.trp";
                                File.Copy(voice_gelen, voice_yeni);

                            }
                        }


                    }
                    else if (ana_file.Name.IndexOf("4") != -1)
                    {

                        String cell4_gelen = gelen_u2100_eksik + "\\" + ana_file.Name; //Bu dosyanın konumu.
                        String cell4_yeni = gelen_u2100_eksik + "\\" + "s4";        //Dosyanın adının s1 olması için gereken kod.
                        Directory.Move(cell4_gelen, cell4_yeni4);      //gelen dosya x olsun biz bunu önce hhhh1 yapıyoruz.
                        Directory.Move(cell4_yeni4, cell4_yeni);

                        foreach (string str4 in Directory.GetFiles(cell4_yeni))
                        {
                            Elements.Items.Add(str4);               //Dosyanın işleme alındığını ekranda gösteriyor.
                            FileInfo info4 = new FileInfo(str4);

                            if (info4.Name.IndexOf("dl") != -1 || info4.Name.IndexOf("DL") != -1 || info4.Name.IndexOf("Dl") != -1 || info4.Name.IndexOf("dL") != -1)
                            {
                                String dl_gelen = ana_file + "\\" + info4.Name;
                                String dl_yeni = gelen_yol + @"\Logs" + "\\" + "st" + alt_dosya_counter + "_dual" + "_dl.trp";
                                File.Copy(dl_gelen, dl_yeni);
                            }
                            else if (info4.Name.IndexOf("ul") != -1 || info4.Name.IndexOf("UL") != -1 || info4.Name.IndexOf("Ul") != -1 || info4.Name.IndexOf("uL") != -1)
                            {
                                String Ul_gelen = ana_file + "\\" + info4.Name;
                                String Ul_yeni = gelen_yol + @"\Logs" + "\\" + "st" + alt_dosya_counter + "_dual" + "_ul.trp";
                                File.Copy(Ul_gelen, Ul_yeni);

                            }
                            else if (info4.Name.IndexOf("voice") != -1 || info4.Name.IndexOf("Voice") != -1 || info4.Name.IndexOf("Voice_3G") != -1 || info4.Name.IndexOf("VOICE") != -1)
                            {

                                String voice_gelen = ana_file + "\\" + info4.Name;
                                String voice_yeni = gelen_yol + @"\Logs" + "\\" + "st" + alt_dosya_counter + "_f" + ana_dosya_counter + "_voice.trp";
                                File.Copy(voice_gelen, voice_yeni);

                            }
                        }


                    }
                    else if (ana_file.Name.IndexOf("5") != -1)
                    {

                        String cell5_gelen = gelen_u2100_eksik + "\\" + ana_file.Name; //Bu dosyanın konumu.
                        String cell5_yeni = gelen_u2100_eksik + "\\" + "s4";        //Dosyanın adının s1 olması için gereken kod.
                        Directory.Move(cell5_gelen, cell5_yeni5);      //gelen dosya x olsun biz bunu önce hhhh1 yapıyoruz.
                        Directory.Move(cell5_yeni5, cell5_yeni);

                        foreach (string str4 in Directory.GetFiles(cell5_yeni))
                        {
                            Elements.Items.Add(str4);               //Dosyanın işleme alındığını ekranda gösteriyor.
                            FileInfo info4 = new FileInfo(str4);

                            if (info4.Name.IndexOf("dl") != -1 || info4.Name.IndexOf("DL") != -1 || info4.Name.IndexOf("Dl") != -1 || info4.Name.IndexOf("dL") != -1)
                            {
                                String dl_gelen = ana_file + "\\" + info4.Name;
                                String dl_yeni = gelen_yol + @"\Logs" + "\\" + "st" + alt_dosya_counter + "_dual" + "_dl.trp";
                                File.Copy(dl_gelen, dl_yeni);
                            }
                            else if (info4.Name.IndexOf("ul") != -1 || info4.Name.IndexOf("UL") != -1 || info4.Name.IndexOf("Ul") != -1 || info4.Name.IndexOf("uL") != -1)
                            {
                                String Ul_gelen = ana_file + "\\" + info4.Name;
                                String Ul_yeni = gelen_yol + @"\Logs" + "\\" + "st" + alt_dosya_counter + "_dual" + "_ul.trp";
                                File.Copy(Ul_gelen, Ul_yeni);

                            }
                            else if (info4.Name.IndexOf("voice") != -1 || info4.Name.IndexOf("Voice") != -1 || info4.Name.IndexOf("Voice_3G") != -1 || info4.Name.IndexOf("VOICE") != -1)
                            {

                                String voice_gelen = ana_file + "\\" + info4.Name;
                                String voice_yeni = gelen_yol + @"\Logs" + "\\" + "st" + alt_dosya_counter + "_f" + ana_dosya_counter + "_voice.trp";
                                File.Copy(voice_gelen, voice_yeni);

                            }
                        }


                    }
                    else
                    {
                        MessageBox.Show("Dosyalar EKSİK !! ");
                        alt_dosya_counter = 0;
                    }


                try
                {
                    if (Directory.Exists(gelen_yol + @"\Mobility"))   //Seçilen yolda var ise.
                    {

                        string gelen_mob = gelen_yol + @"\Mobility";
                        string gidecek_mob = gelen_yol + @"\Logs";
                        string[] dosya_var = Directory.GetFiles(gelen_mob);
                        foreach (string i in dosya_var)
                        {
                            FileInfo mobil1 = new FileInfo(i);
                            String mob_change_name = gelen_yol + @"\Logs" + "\\" + mobil1.Name;
                            File.Copy(i, mob_change_name);
                            Elements.Items.Add(i);
                        }

                    }
                    else
                    {
                        string[] dosya_var = Directory.GetFiles(gelen_yol);
                        foreach (string i in dosya_var)
                        {
                            FileInfo mobil1 = new FileInfo(i);
                            String mob_change_name = gelen_yol + @"\Logs" + "\\" + mobil1.Name;
                            File.Copy(i, mob_change_name);
                            Elements.Items.Add(i);
                        }
                    }
                }
                catch
                {

                }
            }

            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            
                int count = 0;
                Elements.Items.Clear();
                String asd = gelen_yol;
                string[] dsfss = Directory.GetDirectories(asd);

                if (Directory.Exists(gelen_yol + @"\Logs"))
                {
                    Directory.Delete(gelen_yol + @"\Logs", true); //EĞER DAHA ÖNCE LOG DOSYASI VAR İSE SONU SİLİYORUZ. 
                }


                String asd3 = gelen_yol + "/" + "logs";
                Directory.CreateDirectory(asd3);                   //Kendimiz bos bir Log dosyası oluşturuyoruz .
                foreach (string i in dsfss)
                {
                    Elements.Items.Add(i);
                    count++;
                    FileInfo info3 = new FileInfo(i);
                    String cell1_yeni1 = gelen_yol + "\\" + "hhhh1";  //S1 olarak ayarlanan bir dosyanın adı önce hhh1 olarak ayarlanacak.
                    String cell2_yeni2 = gelen_yol + "\\" + "hhhh2";  //s2 olarak ayarlanan bir dosyanın adı sonra hh2 olarak ayarlanacak.
                    String cell3_yeni3 = gelen_yol + "\\" + "hhhh3";  //s3 olarak ayarlanan bir dosyanın adı önce hh3 olarak ayarlanacak.
                    if (info3.Name.IndexOf("1") != -1)                //Dosyanın adında 1 geçiyor ise.
                    {

                        String cell1_gelen = gelen_yol + "\\" + info3.Name; //Bu dosyanın konumu.
                        String cell1_yeni = gelen_yol + "\\" + "s1";        //Dosyanın adının s1 olması için gereken kod.

                        Directory.Move(cell1_gelen, cell1_yeni1);      //gelen dosya x olsun biz bunu önce hhhh1 yapıyoruz.
                        Directory.Move(cell1_yeni1, cell1_yeni);       //daha sonra hhh1 olan dosyanın adını s1 olarak ayarlıyoruz.



                        foreach (string str4 in Directory.GetFiles(cell1_yeni))
                        {
                            Elements.Items.Add(str4);               //Dosyanın işleme alındığını ekranda gösteriyor.
                            FileInfo info4 = new FileInfo(str4);    //

                            if (info4.Name.IndexOf("ping") != -1)
                            {
                                String ping_gelen = gelen_yol + "\\" + "s1" + "\\" + info4.Name;
                                String ping_yeni = gelen_yol + @"\Logs" + "\\" + "st1_ping_2600.trp";
                                File.Copy(ping_gelen, ping_yeni);   //s1 adı altında olan ping içeren dosyayı yeniden adlandırmak için.


                            }
                            else if (info4.Name.IndexOf("dl") != -1 || info4.Name.IndexOf("DL") != -1 || info4.Name.IndexOf("Dl") != -1 || info4.Name.IndexOf("dL") != -1)
                            {
                                String dl_gelen = gelen_yol + "\\" + "s1" + "\\" + info4.Name;
                                String dl_yeni = gelen_yol + @"\Logs" + "\\" + "st1_dl_2600.trp";
                                File.Copy(dl_gelen, dl_yeni);  ////s1 adı altında olan dl içeren dosyayı yeniden adlandırmak için.

                            }
                            else if (info4.Name.IndexOf("ul") != -1 || info4.Name.IndexOf("UL") != -1 || info4.Name.IndexOf("Ul") != -1 || info4.Name.IndexOf("uL") != -1)
                            {

                                String ul_gelen = gelen_yol + "\\" + "s1" + "\\" + info4.Name;
                                String ul_yeni = gelen_yol + @"\Logs" + "\\" + "st1_ul_2600.trp";
                                File.Copy(ul_gelen, ul_yeni);  //s1 adı altında olan UL içeren dosyayı yeniden adlandırmak için.

                            }
                            else if (((info4.Name.IndexOf("CSFB") != -1) || (info4.Name.IndexOf("4G4G") != -1)))
                            {
                                String CSFB_gelen = gelen_yol + "\\" + "s1" + "\\" + info4.Name;
                                String CSFB_yeni = gelen_yol + @"\Logs" + "\\" + "st1_vc_2600.trp";
                                File.Copy(CSFB_gelen, CSFB_yeni);   //s1 adı altında olan CSFB içeren dosyayı yeniden adlandırmak için.

                            }

                            else if (((info4.Name.IndexOf("Volte") != -1) || (info4.Name.IndexOf("volte") != -1)) || (info4.Name.IndexOf("VOLTE") != -1) || (info4.Name.IndexOf("volte") != -1))
                            {
                                String Volte_gelen = gelen_yol + "\\" + "s1" + "\\" + info4.Name;
                                String Volte_yeni = gelen_yol + @"\Logs" + "\\" + "st1_volte.trp";
                                File.Copy(Volte_gelen, Volte_yeni);    //s1 adı altında olan CSFB içeren dosyayı yeniden adlandırmak için

                            }


                        }
                    }
                    else if (info3.Name.IndexOf("2") != -1)
                    {

                        String cell2_gelen = gelen_yol + "\\" + info3.Name;
                        String cell2_yeni = gelen_yol + "\\" + "s2";


                        Directory.Move(cell2_gelen, cell2_yeni2);
                        Directory.Move(cell2_yeni2, cell2_yeni);


                        foreach (string str4 in Directory.GetFiles(cell2_yeni))
                        {
                            Elements.Items.Add(str4);
                            FileInfo info4 = new FileInfo(str4);

                            if (info4.Name.IndexOf("ping") != -1)
                            {
                                String ping_gelen = gelen_yol + "\\" + "s2" + "\\" + info4.Name;
                                String ping_yeni = gelen_yol + @"\Logs" + "\\" + "st2_ping_2600.trp";
                                File.Copy(ping_gelen, ping_yeni);
                            }
                            else if (info4.Name.IndexOf("dl") != -1 || info4.Name.IndexOf("DL") != -1 || info4.Name.IndexOf("Dl") != -1 || info4.Name.IndexOf("dL") != -1)
                            {
                                String dl_gelen = gelen_yol + "\\" + "s2" + "\\" + info4.Name;
                                String dl_yeni = gelen_yol + @"\Logs" + "\\" + "st2_dl_2600.trp";
                                File.Copy(dl_gelen, dl_yeni);
                            }

                            else if (info4.Name.IndexOf("ul") != -1 || info4.Name.IndexOf("UL") != -1 || info4.Name.IndexOf("Ul") != -1 || info4.Name.IndexOf("uL") != -1)
                            {
                                String ul_gelen = gelen_yol + "\\" + "s2" + "\\" + info4.Name;
                                String ul_yeni = gelen_yol + @"\Logs" + "\\" + "st2_ul_2600.trp";
                                File.Copy(ul_gelen, ul_yeni);
                            }

                            else if (((info4.Name.IndexOf("CSFB") != -1) || (info4.Name.IndexOf("4G4G") != -1)))
                            {
                                String CSFB_gelen = gelen_yol + "\\" + "s2" + "\\" + info4.Name;
                                String CSFB_yeni = gelen_yol + @"\Logs" + "\\" + "st2_vc_2600.trp";
                                File.Copy(CSFB_gelen, CSFB_yeni);
                            }

                            else if (((info4.Name.IndexOf("Volte") != -1) || (info4.Name.IndexOf("volte") != -1)) || (info4.Name.IndexOf("VOLTE") != -1))
                            {
                                String Volte_gelen = gelen_yol + "\\" + "s2" + "\\" + info4.Name;
                                String Volte_yeni = gelen_yol + @"\Logs" + "\\" + "st2_volte.trp";
                                File.Copy(Volte_gelen, Volte_yeni);
                            }


                        }





                    }
                    else if (info3.Name.IndexOf("3") != -1)
                    {

                        String cell3_gelen = gelen_yol + "\\" + info3.Name;
                        String cell3_yeni = gelen_yol + "\\" + "s3";
                        Directory.Move(cell3_gelen, cell3_yeni3);
                        Directory.Move(cell3_yeni3, cell3_yeni);


                        foreach (string str4 in Directory.GetFiles(cell3_yeni))
                        {
                            Elements.Items.Add(str4);
                            FileInfo info4 = new FileInfo(str4);

                            if (info4.Name.IndexOf("ping") != -1)
                            {
                                String ping_gelen = gelen_yol + "\\" + "s3" + "\\" + info4.Name;
                                String ping_yeni = gelen_yol + @"\Logs" + "\\" + "st3_ping_2600.trp";
                                File.Copy(ping_gelen, ping_yeni);
                            }
                            else if (info4.Name.IndexOf("dl") != -1 || info4.Name.IndexOf("DL") != -1 || info4.Name.IndexOf("Dl") != -1 || info4.Name.IndexOf("dL") != -1)
                            {
                                String dl_gelen = gelen_yol + "\\" + "s3" + "\\" + info4.Name;
                                String dl_yeni = gelen_yol + @"\Logs" + "\\" + "st3_dl_2600.trp";
                                File.Copy(dl_gelen, dl_yeni);
                            }

                            else if (info4.Name.IndexOf("ul") != -1 || info4.Name.IndexOf("UL") != -1 || info4.Name.IndexOf("Ul") != -1 || info4.Name.IndexOf("uL") != -1)
                            {
                                String ul_gelen = gelen_yol + "\\" + "s3" + "\\" + info4.Name;
                                String ul_yeni = gelen_yol + @"\Logs" + "\\" + "st3_ul_2600.trp";
                                File.Copy(ul_gelen, ul_yeni);
                            }

                            else if (((info4.Name.IndexOf("CSFB") != -1) || (info4.Name.IndexOf("4G4G") != -1)))
                            {
                                String CSFB_gelen = gelen_yol + "\\" + "s3" + "\\" + info4.Name;
                                String CSFB_yeni = gelen_yol + @"\Logs" + "\\" + "st3_vc_2600.trp";
                                File.Copy(CSFB_gelen, CSFB_yeni);
                            }

                            else if (((info4.Name.IndexOf("Volte") != -1) || (info4.Name.IndexOf("volte") != -1)) || (info4.Name.IndexOf("VOLTE") != -1))
                            {
                                String Volte_gelen = gelen_yol + "\\" + "s3" + "\\" + info4.Name;
                                String Volte_yeni = gelen_yol + @"\Logs" + "\\" + "st3_volte.trp";
                                File.Copy(Volte_gelen, Volte_yeni);
                            }


                        }
                    }
                    else { MessageBox.Show(" Dosya isimlerini Kontrol edin ! ve doğru dosya uzantısını Kullandığınızdan emin olun ! "); }
                }




                try
                {
                    if (Directory.Exists(gelen_yol + @"\Mobility"))   //Seçilen yolda var ise.
                    {
                        int counter2 = 1;
                        string gelen_mob = gelen_yol + @"\Mobility";
                        string gidecek_mob = gelen_yol + @"\Logs";
                        string[] dosya_var = Directory.GetFiles(gelen_mob);
                        foreach (string i in dosya_var)
                        {
                            String a = i.ToUpper();
                            if (a.IndexOf(".JPG") != -1 || a.IndexOf(".png") != -1 || a.IndexOf(".JPEG") != -1 || a.IndexOf(".PNG") != -1)
                            {
                                continue;
                            }
                            else
                            {
                                if (counter2 == 1)
                                {
                                    String mob_change_name = gelen_yol + @"\Logs" + "\\" + "mobility_800.trp";
                                    File.Copy(i, mob_change_name);
                                    counter2++;
                                    Elements.Items.Add(i);
                                }
                                else
                                {
                                    String mob_change_name = gelen_yol + @"\Logs" + "\\" + "mobility_800_" + counter2 + ".trp";
                                    File.Copy(i, mob_change_name);
                                    counter2++;
                                    Elements.Items.Add(i);
                                }
                            }

                        }
                    }

                    else //Dosya olarark ayarlanmamış dağınık bırakılmış ise 
                    {

                        string[] dosya_var = Directory.GetFiles(gelen_yol);
                        int counter2 = 1;
                        foreach (string i in dosya_var)
                        {
                            if (counter2 == 1)
                            {
                                String mob_change_name = gelen_yol + @"\Logs" + "\\" + "mobility_800.trp";
                                File.Copy(i, mob_change_name);
                                counter2++;
                                Elements.Items.Add(i);
                            }
                            else
                            {
                                String mob_change_name = gelen_yol + @"\Logs" + "\\" + "mobility_800_" + counter2 + ".trp";
                                File.Copy(i, mob_change_name);
                                counter2++;
                                Elements.Items.Add(i);
                            }
                        }
                    }


                }

                catch { MessageBox.Show("Mobility dosyalarında hata olabilir kontrol edin. !! "); }


            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }

    }
