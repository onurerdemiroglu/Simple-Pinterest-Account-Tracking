using Newtonsoft.Json; 
using System; 
using System.Data;
using System.Data.SqlClient; 
using System.IO;
using System.Linq;
using System.Net; 
using System.Text;
using System.Threading; 
using System.Windows.Forms; 

namespace PinterestToken
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
        }
        string pinsayisi, takipcisayisi, shadowdurum, boardsayisi, goruntulenme,domaindurum;

        private void Hesap_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            hesabagit();
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //try
            //{
            //    th1.Abort(); 
            //}
            //catch (Exception)
            //{ 
            //}
            ////browserkapat(); 
        }
        void hesabagit()
        {
            try
            {
                string target = "https://pinterest.com/" + Hesap.CurrentRow.Cells[1].Value.ToString();
                System.Diagnostics.Process.Start(target);
            }
            catch
            {
            }
        } 
        void gridgetir()
        {
            try
            {
                con = new SqlConnection(@"server=Onurerdemiroglu; Initial Catalog=YAZILIM;Integrated Security=SSPI");
                da = new SqlDataAdapter("SELECT ID,KullaniciAdi,Domain,Goruntulenme,PinSayisi,TakipciSayisi,BoardSayisi,DomainDurum,ShadowDurum,Guncelleme FROM Takip ORDER BY ID, KullaniciAdi, Domain, Goruntulenme, PinSayisi, TakipciSayisi, BoardSayisi, DomainDurum, ShadowDurum, Guncelleme ", con);
                ds = new DataSet();
                con.Open();
                da.Fill(ds, "Takip");
                Hesap.DataSource = ds.Tables["Takip"];
                con.Close();

                Hesap.Columns[0].Width = 50;
                Hesap.Columns[1].Width = 120;
                Hesap.Columns[2].Width = 120;
                Hesap.Columns[3].Width = 120;
                Hesap.Columns[4].Width = 120;
                Hesap.Columns[5].Width = 120;
                Hesap.Columns[6].Width = 120;
                Hesap.Columns[7].Width = 120;
                Hesap.Columns[8].Width = 120;
                Hesap.Columns[9].Width = 180;
            }
            catch (Exception)
            {
            }
        }
        void gridgetir2()
        {
            try
            {
                con = new SqlConnection(@"server=Onurerdemiroglu; Initial Catalog=YAZILIM;Integrated Security=SSPI");
                da = new SqlDataAdapter("SELECT name FROM sys.tables ORDER BY name ", con);
                ds = new DataSet();
                con.Open();
                da.Fill(ds, "Takip");
                Hesap.DataSource = ds.Tables["Takip"];
                con.Close();
                 
            }
            catch (Exception)
            {
            }
        }

        Thread th1;
        int domainbansayi, hesapbansayi, shadowbansayi;
        private void button3_Click(object sender, EventArgs e)
        {
            th1 = new Thread(new ThreadStart(takip));
            th1.Start();
        } 
        string mevcutgoruntulenme, mevcutpinsayisi, mevcuttakipcisayisi, mevcutboardsayisi, mevcutdomaindurum, mevcutshadowdurum;


        void takip()
        { 
            domainbansayi = 0;
            hesapbansayi = 0;
            shadowbansayi=0;
            for (int i = 0; i < Hesap.RowCount-1; i++)
            {
                try
                {


                    mevcutgoruntulenme = Hesap.Rows[i].Cells[3].Value.ToString().Split('(').First();
                    mevcutpinsayisi = Hesap.Rows[i].Cells[4].Value.ToString().Split('(').First();
                    mevcuttakipcisayisi = Hesap.Rows[i].Cells[5].Value.ToString().Split('(').First();
                    mevcutboardsayisi = Hesap.Rows[i].Cells[6].Value.ToString().Split('(').First();
                    mevcutdomaindurum = Hesap.Rows[i].Cells[7].Value.ToString().Split('(').First();
                    mevcutshadowdurum = Hesap.Rows[i].Cells[8].Value.ToString().Split('(').First();

                    DataGridViewRow limit2 = Hesap.Rows[i];
                    limit2.Cells[3].Value = "······";
                    limit2.Cells[4].Value = "······";
                    limit2.Cells[5].Value = "······";
                    limit2.Cells[6].Value = "······";
                    limit2.Cells[7].Value = "······";
                    limit2.Cells[8].Value = "······";
                    limit2.Cells[9].Value = "······";

                    string kullaniciadi = Hesap.Rows[i].Cells[1].Value.ToString().Replace(Environment.NewLine, "");
                    string domain = Hesap.Rows[i].Cells[2].Value.ToString().Replace(Environment.NewLine, "").Replace("https://","");

                    string hesapgetir = "https://tr.pinterest.com/resource/UserResource/get/?source_url=%2F" + kullaniciadi + "%2F&data=%7B%22options%22%3A%7B%22isPrefetch%22%3Afalse%2C%22username%22%3A%22" + kullaniciadi + "%22%2C%22field_set_key%22%3A%22profile%22%7D%2C%22context%22%3A%7B%7D%7D&_=";
                    string domaingetir = "https://tr.pinterest.com/resource/DomainFeedResource/get/?source_url=%2Fsource%2F" + domain + "&data=%7B%22options%22%3A%7B%22isPrefetch%22%3Afalse%2C%22domain%22%3A%22" + domain + "%22%7D%2C%22context%22%3A%7B%7D%7D&_=";
                    domaingetir = domaingetir.Replace(Environment.NewLine, "").Replace(" ", "");

                    try
                    {
                        WebClient wc = new WebClient();
                        Stream oku = wc.OpenRead(hesapgetir);
                        StreamReader sr = new StreamReader(oku, Encoding.GetEncoding("windows-1254"));
                        string gelen = sr.ReadToEnd();
                        string HtmlKodum = gelen;
                        dynamic array = JsonConvert.DeserializeObject(HtmlKodum);

                        foreach (var item in array)
                        {
                            try
                            {
                                for (int b = 0; b < 100; b++)
                                {
                                    pinsayisi = array["resource_response"]["data"]["pin_count"].ToString();

                                    //if (mevcutpinsayisi!="")
                                    //{
                                    //    if (Convert.ToInt32(pinsayisi) > Convert.ToInt32(mevcutpinsayisi))
                                    //    {
                                    //        pinsayisi = pinsayisi + "(+" + (Convert.ToInt32(pinsayisi)-Convert.ToInt32(mevcutpinsayisi)).ToString() + ")";
                                    //    }
                                    //    if (Convert.ToInt32(pinsayisi) < Convert.ToInt32(mevcutpinsayisi))
                                    //    {
                                    //        pinsayisi = pinsayisi + "(-" + (Convert.ToInt32(mevcutpinsayisi) - Convert.ToInt32(pinsayisi)).ToString() + ")";
                                    //    }
                                    //}


                                    takipcisayisi = array["resource_response"]["data"]["follower_count"].ToString();

                                    //if (mevcuttakipcisayisi != "")
                                    //{
                                    //    if (Convert.ToInt32(takipcisayisi) > Convert.ToInt32(mevcuttakipcisayisi))
                                    //    {
                                    //        takipcisayisi = takipcisayisi + "(+" + (Convert.ToInt32(takipcisayisi) - Convert.ToInt32(mevcuttakipcisayisi)).ToString() + ")";
                                    //    }
                                    //    if (Convert.ToInt32(takipcisayisi) < Convert.ToInt32(mevcuttakipcisayisi))
                                    //    {
                                    //        takipcisayisi = takipcisayisi + "(-" + (Convert.ToInt32(mevcuttakipcisayisi) - Convert.ToInt32(takipcisayisi)).ToString() + ")";
                                    //    }
                                    //}
                                    boardsayisi = array["resource_response"]["data"]["board_count"].ToString();

                                    //if (mevcutboardsayisi != "")
                                    //{
                                    //    if (Convert.ToInt32(boardsayisi) > Convert.ToInt32(mevcutboardsayisi))
                                    //    {
                                    //        boardsayisi = boardsayisi + "(+" + (Convert.ToInt32(boardsayisi) - Convert.ToInt32(mevcutboardsayisi)).ToString() + ")";
                                    //    }
                                    //    if (Convert.ToInt32(boardsayisi) < Convert.ToInt32(mevcutboardsayisi))
                                    //    {
                                    //        boardsayisi = boardsayisi + "(-" + (Convert.ToInt32(mevcutboardsayisi) - Convert.ToInt32(boardsayisi)).ToString() + ")";
                                    //    }
                                    //}

                                    goruntulenme = array["resource_response"]["data"]["profile_reach"].ToString();

                                    //if (mevcutgoruntulenme != "")
                                    //{
                                    //    if (Convert.ToInt32(goruntulenme) > Convert.ToInt32(mevcutgoruntulenme))
                                    //    {
                                    //        goruntulenme = goruntulenme + "(+" + (Convert.ToInt32(goruntulenme) - Convert.ToInt32(mevcutgoruntulenme)).ToString() + ")";
                                    //    }
                                    //    if (Convert.ToInt32(takipcisayisi) < Convert.ToInt32(mevcutgoruntulenme))
                                    //    {
                                    //        goruntulenme = goruntulenme + "(-" + (Convert.ToInt32(mevcutgoruntulenme) - Convert.ToInt32(goruntulenme)).ToString() + ")";
                                    //    }
                                    //} 

                                    shadowdurum = array["resource_response"]["data"]["indexed"].ToString();

                                    if (shadowdurum == "True")
                                    {
                                        shadowdurum = "Temiz";
                                    }
                                    if (shadowdurum == "False")
                                    {
                                        shadowdurum = "Shadowlu";
                                        shadowbansayi += 1;
                                    }

                                    //if (mevcutshadowdurum != "")
                                    //{
                                    //    if (mevcutshadowdurum == "Temiz")
                                    //    {
                                    //        if (shadowdurum == "False")
                                    //        {
                                    //            shadowdurum = "Shadowlandı";
                                    //        }
                                    //    }
                                    //}


                                    if (goruntulenme == "-1")
                                    {
                                        goruntulenme = "0";
                                    }
                                }
                            }
                            catch (Exception e)
                            {
                                MessageBox.Show(e.ToString());
                            }
                        }
                    }
                    catch (Exception)
                    {
                        pinsayisi = "xxxxxxxxxxxx";
                        goruntulenme = "xxxxxxxxxxxx";
                        boardsayisi = "xxxxxxxxxxxx";
                        takipcisayisi = "xxxxxxxxxxxx";
                        shadowdurum = "xxxxxxxxxxxx";
                        hesapbansayi += 1;
                    }
                   

                    try
                    {
                        WebClient wc2 = new WebClient();
                        Stream oku2 = wc2.OpenRead(domaingetir);
                        StreamReader sr2 = new StreamReader(oku2, Encoding.GetEncoding("windows-1254"));
                        string gelen2 = sr2.ReadToEnd();
                        string HtmlKodum2 = gelen2;
                        dynamic array2 = JsonConvert.DeserializeObject(HtmlKodum2);

                        foreach (var item in array2)
                        {
                            try
                            {
                                domaindurum = array2["resource_response"]["data"][1]["board"]["image_thumbnail_url"].ToString();
                                domaindurum = "Temiz";
                            }
                            catch (Exception)
                            {
                                domaindurum = "Banlı";
                            }
                        }
                    }
                    catch (Exception)
                    {
                        if (takipcisayisi== "xxxxxxxxxxxx")
                        {
                            domaindurum = "xxxxxxxxxxxx"; 
                        }
                        else
                        {
                            domaindurum = "Belirsiz"; 
                        }
                    }

                    if (domaindurum=="Banlı")
                    {
                        domainbansayi += 1; 
                    }

                    DataGridViewRow limit = Hesap.Rows[i];
                    limit.Cells[3].Value = goruntulenme;
                    limit.Cells[4].Value = pinsayisi;
                    limit.Cells[5].Value = takipcisayisi;
                    limit.Cells[6].Value = boardsayisi;
                    limit.Cells[7].Value = domaindurum;
                    limit.Cells[8].Value = shadowdurum;
                    limit.Cells[9].Value = DateTime.Now.ToString();
                }
                catch (Exception)
                { 
                }
                string ID = Hesap.Rows[i].Cells[0].Value.ToString();
                string KullaniciAdi = Hesap.Rows[i].Cells[1].Value.ToString();
                string Domain = Hesap.Rows[i].Cells[2].Value.ToString();
                string Görüntülenme = Hesap.Rows[i].Cells[3].Value.ToString();
                string PinSayısı = Hesap.Rows[i].Cells[4].Value.ToString();
                string TakipçiSayısı = Hesap.Rows[i].Cells[5].Value.ToString();
                string BoardSayısı = Hesap.Rows[i].Cells[6].Value.ToString();
                string DomainnDurum = Hesap.Rows[i].Cells[7].Value.ToString();
                string ShadowDurum = Hesap.Rows[i].Cells[8].Value.ToString();
                string Güncelleme = Hesap.Rows[i].Cells[9].Value.ToString();

                cmd = new SqlCommand();
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "update Takip set KullaniciAdi='" + KullaniciAdi + "' " + ",Domain='" + Domain + "',Goruntulenme='" + Görüntülenme + "' ,PinSayisi='" + PinSayısı + "',TakipciSayisi='" + TakipçiSayısı + "',DomainDurum='" + DomainnDurum + "',BoardSayisi='" + BoardSayısı + "',ShadowDurum='" + ShadowDurum + "',Guncelleme='" + Güncelleme + "' where ID=" + ID + "";
                cmd.ExecuteNonQuery();
                con.Close();
                label4.Text = "İşlem: " + (i+1).ToString();
                ToplamHesapBan.Text = hesapbansayi.ToString();
                toplamshadow.Text = shadowbansayi.ToString();
                ToplamDomain.Text = domainbansayi.ToString();
            }
            
        } 
   
         
        private void Form1_Load_1(object sender, EventArgs e)
        { 
            gridgetir();   
        }  
        SqlConnection con;
        SqlDataAdapter da;
        SqlCommand cmd;
        DataSet ds;
       

       

    }
}
