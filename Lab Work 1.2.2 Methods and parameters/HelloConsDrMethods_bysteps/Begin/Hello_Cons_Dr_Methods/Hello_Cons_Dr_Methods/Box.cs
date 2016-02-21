using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_Cons_Dr_Methods
{
    class Box
    {
        public uint X { get; set; }
        public uint Y { get; set; }
        public uint Width { get; set; }
        public uint Height { get; set; }
        public string Message { get; set; }
        public char Symbol { get; set; }

        public void Draw()
        {
            if (Width > 0 && Height > 0)
            {
                if (Symbol == '*' || Symbol == '+' || Symbol == '$' || Symbol == '#' || Symbol == '@')
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;

                    if (Message == null)
                    {
                        Message = "";
                    }

                    string mes;

                    if (Width >= 3 && Height >= 3)
                    {
                        mes = Message.Substring(0, Math.Min((int)Width - 2, Message.Length));
                    }
                    else
                    {
                        mes = "";
                    }

                    draw((int)X, (int)Y, (int)Width, (int)Height, ref mes, Symbol);
                    Message = mes;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(@"""{0}"" - invalid symbol.", Symbol);
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("invalid Width or Height.");
            }

            Console.ResetColor();
        }

        private void draw(int X, int Y, int Width, int Height, ref string mes, char Symb)
        {
            // painting message...

            if (Width >= 3 && Height >= 3)
            {
                Console.SetCursorPosition(X + (Width - mes.Length) / 2, Y + Height / 2);
                Console.Write(mes);
            }

            // painting rectangle...

            for (int i = 0; i < Width ; i++)
            {
                Console.SetCursorPosition(X + i, Y);
                Console.Write(Symb);
                Console.SetCursorPosition(X + i, Y + Height-1);
                Console.Write(Symb);
            }

            for (int j = 1; j < Height-1 ; j++)
            {
                Console.SetCursorPosition(X, Y + j);
                Console.Write(Symb);
                Console.SetCursorPosition(X + Width-1, Y + j);
                Console.Write(Symb);
            }

            Console.SetCursorPosition(0 , Y + Height+1);
            mes = "Square = " + Width * Height;
        }
    }
}
