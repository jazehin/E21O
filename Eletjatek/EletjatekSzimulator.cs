using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eletjatek
{
    internal class EletjatekSzimulator
    {
        private int[,] Matrix { get; set; }
        private int OszlopokSzama { get; init; }
        private int SorokSzama { get; init; }

        public EletjatekSzimulator(int oszlopokSzama, int sorokSzama)
        {
            OszlopokSzama = oszlopokSzama;
            SorokSzama = sorokSzama;
            Matrix = new int[SorokSzama + 2, OszlopokSzama + 2];

            // alapvetően 0-val vannak eltöltve a helyek, nem szükséges a szélek helyeire 0-kat írni
            Random rnd = new();
            for (int i = 1; i < Matrix.GetLength(0) - 1; i++)
            {
                for (int j = 1; j < Matrix.GetLength(1) - 1; j++)
                {
                    Matrix[i, j] = rnd.Next(0, 2);
                }
            }
        }

        private void Megjelenit()
        {
            for (int i = 0; i < Matrix.GetLength(0); i++)
            {
                for (int j = 0; j < Matrix.GetLength(1); j++)
                {
                    char ki = ' ';
                    if (i == 0 || j == 0 || i == Matrix.GetLength(0) - 1 || j == Matrix.GetLength(1) - 1)
                    {
                        ki = 'X';
                    }
                    else
                    {
                        switch (Matrix[i, j])
                        {
                            case 0:
                                ki = ' ';
                                break;
                            case 1:
                                ki = 'S';
                                break;
                        }
                    }
                    Console.Write(ki);
                }
                Console.WriteLine();
            }
        }

        private int GetSejtszomszedokSzama(int x, int y)
        {
            int szamlalo = 0;

            for (int i = x - 1; i <= x + 1; i++)
            {
                for (int j = y - 1; j <= y + 1; j++)
                {
                    if (i != x || j != y)
                    {
                        if (Matrix[i, j] == 1) szamlalo++;
                    }
                }
            }

            return szamlalo;
        }

        private void KovetkezoAllapot()
        {
            int[,] ideiglenesMatrix = new int[SorokSzama + 2, OszlopokSzama + 2];

            for (int i = 1; i < Matrix.GetLength(0) - 1; i++)
            {
                for (int j = 1; j < Matrix.GetLength(1) - 1; j++)
                {
                    int sejtszomszedokSzama = GetSejtszomszedokSzama(i, j);

                    //0-kat nem állítok, mert felesleges
                    if (Matrix[i, j] == 1)
                    {
                        if (sejtszomszedokSzama == 2|| sejtszomszedokSzama == 3)
                        {
                            ideiglenesMatrix[i, j] = 1;
                        }
                    }
                    else {
                        if (sejtszomszedokSzama == 3)
                        {
                            ideiglenesMatrix[i, j] = 1;
                        }
                    }
                }
            }

            Matrix = ideiglenesMatrix;
        }

        public void Run()
        {
            Console.Clear();
            Megjelenit();
            KovetkezoAllapot();
            Thread.Sleep(500);
        }
    }
}
