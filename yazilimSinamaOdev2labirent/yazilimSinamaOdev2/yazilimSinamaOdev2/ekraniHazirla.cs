using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yazilimSinamaOdev2
{
    public class ekraniHazirla
    {
        private int[,] durum;
        public int duvarSay = 0, fareSay = 0, peynirSay = 0;

        public ekraniHazirla()
        {
            //bu sınıf doluluk durumunu tutacak, böylece fare
            //duvar olan tarafa hareket etmeyecek
            // boş:0    duvar:1     fare:2    peynir:3   sabitDuvar:4
            durum = new int[17,12];
            for(int i = 0; i < 12; i++)
            {
                durum[0, i] = 4;//sabit çerçevenin sol duvarı
                durum[16, i] = 4;//sabit çerçevenin sağ duvarı
            }
            for (int i = 0; i < 17; i++)
            {
                durum[i, 0] = 4;//sabit çerçevenin üst duvarı
                durum[i, 11] = 4;//sabit çerçevenin alt duvarı
            }
            for (int i = 1; i <= 15; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    durum[i, j] = 0;//başlangıçta gezinme alanı boş
                }
            }
        }
        public int durumNe(int x,int y)
        {
                return durum[x,y];   
        }
        public void durumArttir(int x,int y,string drm)
        {
            if (drm == "duvar")
            {
                this.durum[x, y] = 1;
                duvarSay++;
            }
            else if (drm == "fare")
            {
                this.durum[x, y] = 2;
                fareSay++;
            }
            else if (drm == "peynir")
            {
                this.durum[x, y] = 3;
                peynirSay++;
            }
        }
        public void durumAzalt(int x,int y)
        {
            if (this.durum[x, y] == 1)
            {
                this.durum[x, y] = 0;
                duvarSay--;
            }
            else if (this.durum[x, y] == 2)
            {
                this.durum[x, y] = 0;
                fareSay--;
            }
            else if (this.durum[x, y] == 3)
            {
                this.durum[x, y] = 0;
                peynirSay--;
            }
        }

    }
}
