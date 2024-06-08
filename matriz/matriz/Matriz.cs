using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matriz
{
    class Matriz
    {
        const int MAXF = 100;
        const int MAXC = 100;
        private int[,] x;
        private int f, c;


        public Matriz()
        {
            x = new int[MAXF, MAXC];
            f = 0; c = 0;
        }

        public void cargar(int nf, int nc, int a, int b)
        {
            f = nf; c = nc;
            int f1, c1;
            Random r = new Random();
            for (f1 = 1; f1 <= f; f1++)
            {
                for (c1 = 1; c1 <= c; c1++)
                {
                    x[f1, c1] = r.Next(a, b);
                }
            }
        }
        public string descargar()
        {
            string s = "";
            int f1, c1;
            for (f1 = 1; f1 <= f; f1++)
            {
                for (c1 = 1; c1 <= c; c1++)
                {
                    s = s + x[f1, c1] + "\x09";
                }
                s = s + "\x0d" + "\x0a";
            }
            return s;
        }
      
       
         public void pregunta1()
         {
             int may = 0;
             int elemay=0;
             for (int c1 = 1; c1 <= c; c1++)
             {
                 may = 0;
                for (int f1 = 1; f1 <= f; f1++)
                 {
                    int ele = x[f1, c1];
                    int fr=frecuenciaCol(c1,ele);
                    if (fr > may)
                    {
                        may = fr;
                        elemay = ele;
                    }
                 }
                x[f + 1, c1] = elemay;
               // x[f + 2, c1] = may;
             }
             f = f + 1;
            Ord_las_col_x_el_nro_de_eles_difsme();
         }

        int frecuenciaCol(int c1, int ele)
        {
            int fr = 0;
            for (int f1 = 1; f1 <= f; f1++)
            {
                if (x[f1, c1] == ele)
                {
                    fr++;
                }
            }
            return fr;
        }

        public void Ord_las_col_x_el_nro_de_eles_difsme()
        {
            for (var p = 1; p <= c - 1; p++)
            {
                for (var d = p + 1; d <= c; d++)
                {
                    if (x[f, p] > x[f, d])
                        Intercambiar_col(d, p);
                }
            }
        }



        public void Intercambiar_col(int c1, int c2)
        {
            for (var f1 = 1; f1 <= f; f1++)
                Intercambiar(f1, c1, f1, c2);
        }
        public void Intercambiar(int f1, int c1, int f2, int c2)
        {
            int aux = x[f1, c1];
            x[f1, c1] = x[f2, c2];
            x[f2, c2] = aux;
        }






    }
}
