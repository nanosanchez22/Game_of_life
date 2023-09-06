using System;
using System.Text;
using System.Threading;

namespace PII_Game_Of_Life
{
    public class ImprimirTablero
    {

        public static void Imprimir(bool[,] b){

            int width = b.GetLength(0); //variabe que representa el ancho del tablero
            int height = b.GetLength(1); //variabe que representa altura del tablero

            LogicaDeJuego logicaDeJuego= new LogicaDeJuego();

            while (true)
            {
                Console.Clear();
                StringBuilder s = new StringBuilder();
                for (int y = 0; y<height;y++)
                {
                    for (int x = 0; x<width; x++)
                    {
                        if(b [x,y])
                        {
                            s.Append("|X|");
                        }
                        else
                        {
                            s.Append("___");
                        }
                    }
                    s.Append("\n");
                }
                
                Console.WriteLine(s.ToString());
                //=================================================
                //Invocar método para calcular siguiente generación
                //=================================================
                b = logicaDeJuego.NewBoard(b);
                Thread.Sleep(300);
            }
        }
            
    }
}