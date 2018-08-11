using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yazilimSinamaOdev2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int fareX, fareY;
        Boolean duvar =false, fare = false, peynir = false, kaldir=false;
        ekraniHazirla oyunEkrani;
        PictureBox[] resim;
        PictureBox farem, peynirim;
        Random rnd;
        private void Form1_Load(object sender, EventArgs e)
        {
            //fare ve peynir olmadan başlamasın
            //onun için başla butonu görünmesin
            baslaBtn.Visible = false;
            rnd = new Random();//yön kararında random yardımcı
            //oyunun ileride geliştirilebilmesi için her
            //picturebox bir dizide tutuluyor
            resim = new PictureBox[151];
            oyunEkrani = new ekraniHazirla();
            //dinamik olarak sınırları belirleyen 
            //pictureboxlar oluşturuluyor 
            for(int i = 0; i < 17; i++)
            {
                PictureBox sabitDuvarUst = new PictureBox();
                sabitDuvarYap(sabitDuvarUst);
                sabitDuvarUst.Left = i * 40;
                sabitDuvarUst.Top = 0;

                PictureBox sabitDuvarAlt = new PictureBox();
                sabitDuvarYap(sabitDuvarAlt);
                sabitDuvarAlt.Left = i * 40;
                sabitDuvarUst.Top = 440;
            }
            for (int i = 1; i < 11; i++)
            {
                PictureBox sabitDuvarSol = new PictureBox();
                sabitDuvarYap(sabitDuvarSol);
                sabitDuvarSol.Left = 0;
                sabitDuvarSol.Top = i*40;

                PictureBox sabitDuvarSag = new PictureBox();
                sabitDuvarYap(sabitDuvarSag);
                sabitDuvarSag.Left = 640;
                sabitDuvarSag.Top = i * 40;
            }
        }
        //dinamik olarak picturebox'lara özellik veriliyor
        private void sabitDuvarYap(PictureBox p)
        {
            p.Height = 40;
            p.Width = 40;
            p.SizeMode = PictureBoxSizeMode.Zoom;
            this.Controls.Add(p);
            p.BringToFront();
            p.Image = Image.FromFile("duvar2.png");
        }
        //ekrana konulacak öğenin seçilme durumu belirleniyor
        private void hepsiFalse()
        {
            duvar = fare = peynir = kaldir = false;
        }
        private void farePct_Click(object sender, EventArgs e)
        {
            hepsiFalse();
            fare = true;
        }
        private void peynirPct_Click(object sender, EventArgs e)
        {
            hepsiFalse();
            peynir = true;
        }
        private void kaldirPct_Click(object sender, EventArgs e)
        {
            hepsiFalse();
            kaldir = true;
        }
        private void duvarPct_Click(object sender, EventArgs e)
        {
            hepsiFalse();
            duvar = true;
        }
        private void baslaBtn_Click(object sender, EventArgs e)
        {
            //oyun başlayınca oyuna ekleme çıkarma yapılamayacak
            hepsiFalse();
            baslaBtn.Visible = duvarPct.Visible = farePct.Visible = false;
            kaldirPct.Visible = peynirPct.Visible = false;
            timer.Enabled = true;
        }
        //hep aynı hareketleri tekrarlamaması için arada iyileştirme
        //hamleleri yapacak
        //en son ilerlediği yön, 'sonYon'de tutuluyor 
        int adim = 0,iyilestir=0;
        int sonYon = 4;
        int yon=0;
        private void yoneGit()
        {
            iyilestir++;
            iyilestir %= 4;
            if (iyilestir == 3)
            {
                //dört hamle aynı yönde olursa beşinciyi değiştirir
                yon++;
                yon %= 4;
            }
            int x = farem.Left / 40;
            int y = farem.Top / 40;
            if(sonYon!=yon)
            yon = rnd.Next(4);
            //sağda duvar yoksa ilerle
            if (oyunEkrani.durumNe(x + 1, y) == 0 && yon == 0)
            {
                sonYon = yon;
                oyunEkrani.durumArttir(x + 1, y, "fare");
                oyunEkrani.durumAzalt(x, y);
                farem.Left += 40;
            }
            //üstte duvar yoksa ilerle
            else if (oyunEkrani.durumNe(x, y - 1) == 0 && yon == 1)
            {
                sonYon = yon;
                oyunEkrani.durumArttir(x, y - 1, "fare");
                oyunEkrani.durumAzalt(x, y);
                farem.Top -= 40;
            }
            //solda duvar yoksa ilerle
            else if (oyunEkrani.durumNe(x - 1, y) == 0 && yon == 2)
            {
                sonYon = yon;
                oyunEkrani.durumArttir(x - 1, y, "fare");
                oyunEkrani.durumAzalt(x, y);
                farem.Left -= 40;
            }
            //aşağıda duvar yoksa ilerle
            else if (oyunEkrani.durumNe(x, y +1) == 0 && yon == 3)
            {
                sonYon = yon;
                oyunEkrani.durumArttir(x, y + 1, "fare");
                oyunEkrani.durumAzalt(x, y);
                farem.Top += 40;
            }
            //etrafında peynir var mı kontrol et
            else if(oyunEkrani.durumNe(x+1, y) == 3|| oyunEkrani.durumNe(x, y - 1) == 3||
                    oyunEkrani.durumNe(x-1, y) == 3|| oyunEkrani.durumNe(x, y + 1) == 3)
            {

               // farem.Left = peynirim.Left;
               // farem.Top = peynirim.Top;
                timer.Enabled = false;
                MessageBox.Show("peynir " + adim + " adımda bulundu");
                duvarPct.Visible = kaldirPct.Visible = baslaBtn.Visible= true;
                oyunEkrani.durumAzalt(farem.Left / 40, farem.Top / 40);
                farem.Left = fareX;
                farem.Top = fareY;
                oyunEkrani.durumArttir(fareX/40, fareY/40, "fare");
                oyunEkrani.peynirSay = 1;
                adim = 0;

            }
            else
            {
                //üst üste çok fazla aynı yöne gitmeye çalışırsa 
                //son gittiği yön bilgisini değiştir
                sonYon = 4;
                yoneGit();
            }
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            adim++;
            //fare peynirin koordinatlarını biliyorsa o koordinatlar
            //yönüne hamle sayısı artacak fakat sürekli o yönde 
            //hareket ederse iki duvar arasında kısır döngüye girebilir
            //onun için tik açıksa 3 hamlede bir peynire doğru yönelecek 
            if (bilsinChk.Checked)
                if (adim % 3 == 0)
                    zekiGit();
                else
                    yoneGit();
            //tik kapalıysa daha bilinçsiz ilerleyecek
            else
                yoneGit();
        }
        private void zekiGit()
        {
            //peynirin konumunu fareye veren tik açılmışsa 
            //fare peynirin hangi tarafında kaldığına bakarak
            //yön aramaya çalışacak 
            int x = farem.Left/40,y=farem.Top/40;
            if (peynirim.Left - farem.Left > 0 &&
                (oyunEkrani.durumNe(x+1,y)==0||oyunEkrani.durumNe(x+1,y)==3))
            {
                oyunEkrani.durumArttir(x + 1, y, "fare");
                oyunEkrani.durumAzalt(x, y);
                farem.Left += 40;
                sonYon = 0;
            }
            else if(peynirim.Top - farem.Top < 0 &&
                (oyunEkrani.durumNe(x , y-1) == 0 || oyunEkrani.durumNe(x , y-1) == 3))
            {
                oyunEkrani.durumArttir(x, y-1, "fare");
                oyunEkrani.durumAzalt(x, y);
                farem.Top -= 40;
                sonYon = 1;
            }
            else if (peynirim.Left - farem.Left < 0 &&
                (oyunEkrani.durumNe(x - 1, y) == 0 || oyunEkrani.durumNe(x - 1, y) == 3))
            {
                oyunEkrani.durumArttir(x - 1, y, "fare");
                oyunEkrani.durumAzalt(x, y);
                farem.Left -= 40;
                sonYon = 2;
            }
            else if (peynirim.Top - farem.Top > 0 &&
                (oyunEkrani.durumNe(x, y + 1) == 0 || oyunEkrani.durumNe(x , y+1) == 3))
            {
                oyunEkrani.durumArttir(x , y+1, "fare");
                oyunEkrani.durumAzalt(x, y);
                farem.Top += 40;
                sonYon = 3;
            }
            else
            {
                //peynirin olduğu tarafta duvar varsa 
                //tekrar sıradan ilerlemeye dön
                yoneGit();
            }
            if (farem.Left == peynirim.Left && farem.Top == peynirim.Top)
            {
                timer.Enabled = false;
                MessageBox.Show("peynir " + adim + " adımda bulundu");
                duvarPct.Visible = kaldirPct.Visible = baslaBtn.Visible = true;
                // oyunEkrani.durumAzalt(farem.Left / 40, farem.Top / 40);
                oyunEkrani.durumArttir(peynirim.Left/40, peynirim.Top/40, "peynir");
                oyunEkrani.fareSay = 0;
                farem.Left = fareX;
                farem.Top = fareY;
                oyunEkrani.durumArttir(fareX/40, fareY/40,"fare");
                oyunEkrani.peynirSay = 1;
                adim = 0;


            }
        }
        protected override void OnMouseClick(MouseEventArgs e)
        {
            base.OnMouseClick(e);
            //pictureBox'lar 40x40 pixel olarak ayarlandığı için
            //tıklamalarda konum 40ın katı olan koordinatlara
            //göre uyarlanır ve alanın dışına pictureBox
            //eklenmesi engellenir
            int gercekX = e.X - (e.X % 40);
            int gercekY = e.Y - (e.Y % 40);
            if(gercekX<640 && gercekY<440)
            resimEkle(gercekX, gercekY);
            if (farePct.Visible == false && peynirPct.Visible == false&&timer.Enabled==false)
                baslaBtn.Visible = true;
        }
        public void resimKaldir(object sender,EventArgs e)
        {
            if (kaldir == true)
            {
                //dinamik olarak seçilen pictureBox kaldır
                PictureBox p = (PictureBox)sender;
                int gercekKoorX = (p.Left - (p.Left % 40)) / 40;
                int gercekKoorY = (p.Top - (p.Top % 40)) / 40;
                oyunEkrani.durumAzalt(gercekKoorX, gercekKoorY);
                if (oyunEkrani.fareSay == 0)
                    farePct.Visible = true;
                if (oyunEkrani.peynirSay == 0)
                    peynirPct.Visible = true;
                this.Controls.Remove(p);
            }
            if (farePct.Visible ==true || peynirPct.Visible == true)
                baslaBtn.Visible = false;
        }
        private void resimEkle(int x,int y)
        { 
            int koorX = x / 40;
            int koorY = y / 40;
            int i = 15 * (koorY-1) + koorX; 
            if (duvar == true)
            {
                resim[i] = new PictureBox();
                resim[i].Height = 40;
                resim[i].Width = 40;
                resim[i].SizeMode = PictureBoxSizeMode.Zoom;
                this.Controls.Add(resim[i]);
                resim[i].BringToFront();
                resim[i].Click += new EventHandler(resimKaldir);
                resim[i].Left = x;
                resim[i].Top = y;
                resim[i].Image = Image.FromFile("duvar.png");
                oyunEkrani.durumArttir(koorX, koorY, "duvar");
            }
            else if (fare == true)
            {
                if (oyunEkrani.fareSay == 1)
                    farePct.Visible = false;
                else
                {
                    resim[i] = new PictureBox();
                    farem = resim[i];
                    resim[i].Height = 40;
                    resim[i].Width = 40;
                    resim[i].SizeMode = PictureBoxSizeMode.Zoom;
                    this.Controls.Add(resim[i]);
                    resim[i].BringToFront();
                    resim[i].Click += new EventHandler(resimKaldir);
                    fareX = x;
                    fareY = y;
                    resim[i].Left = x;
                    resim[i].Top = y;
                    resim[i].Image = Image.FromFile("fare.png");
                    oyunEkrani.durumArttir(koorX, koorY, "fare");
                    farePct.Visible = false;
                }
            }
            else if (peynir == true)
            {
                if (oyunEkrani.peynirSay == 1)
                    peynirPct.Visible = false;
                else
                {
                    resim[i] = new PictureBox();
                    peynirim = resim[i];
                    resim[i].Height = 40;
                    resim[i].Width = 40;
                    resim[i].SizeMode = PictureBoxSizeMode.Zoom;
                    this.Controls.Add(resim[i]);
                    resim[i].BringToFront();
                    resim[i].Click += new EventHandler(resimKaldir);
                    resim[i].Left = x;
                    resim[i].Top = y;
                    resim[i].Image = Image.FromFile("peynir.png");
                    oyunEkrani.durumArttir(koorX, koorY, "peynir");
                    peynirPct.Visible = false;
                }
            }
        }
    }
}
