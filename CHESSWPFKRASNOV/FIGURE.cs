using System;
using System.Collections.Generic;
using System.Text;

namespace CHESSWPFKRASNOV
{
    class Figure
    {
        public int X;
        public int Y;

        public Figure(int newX, int newY)
        {
            X = newX;
            Y = newY;
            Console.WriteLine("Figure Constructor");
        }

        public virtual bool Move(int newX, int newY)
        {
            return false;
        }
    }

    class King : Figure
    {
        public King(int X, int Y) : base(X, Y)
        {
            Console.WriteLine("King Constructor");
        }

        public override bool Move(int newX, int newY)
        {
            if (Math.Abs(X - newX) <= 1 && Math.Abs(Y - newY) <= 1)
            {
                X = newX;
                Y = newY;
                return true;
            }
            else
            {
                return false;
            }
        }
    }


    class Queen : Figure
    {
        public Queen(int X, int Y) : base(X, Y)
        {
            Console.WriteLine("Queen Constructor");
        }
        public override bool Move(int newX, int newY)
        {
            if ((X == newX || Y == newY ||
            Math.Abs(X - newX) == Math.Abs(Y - newY)))
            {
                X = newX;
                Y = newY;
                return true;
            }
            else
            {
                return false;
            }
        }
    }


    class Rook : Figure
    {
        public Rook(int X, int Y) : base(X, Y)
        {
            Console.WriteLine("Rook Constructor");
        }
        public override bool Move(int newX, int newY)
        {
            if (X == newX || Y == newY)
            {
                X = newX;
                Y = newY;
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    class Bishop : Figure
    {
        public Bishop(int X, int Y) : base(X, Y)
        {
            Console.WriteLine("Bishop Constructor");
        }
        public override bool Move(int newX, int newY)
        {
            if (Math.Abs(X - newX) == Math.Abs(Y - newY))
            {
                X = newX;
                Y = newY;
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    class Knight : Figure
    {
        public Knight(int X, int Y) : base(X, Y)
        {
            Console.WriteLine("Knight Constructor");
        }
        public override bool Move(int newX, int newY)
        {
            if ((Math.Abs(X - newX) == 2 && Math.Abs(Y - newY) == 1) ||
            (Math.Abs(X - newX) == 1 && Math.Abs(Y - newY) == 2))
            {
                X = newX;
                Y = newY;
                return true;
            }
            else
            {
                return false;
            }
        }
    }

}
