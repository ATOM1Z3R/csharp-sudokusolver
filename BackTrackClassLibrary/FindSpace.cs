using BackTrackInterfacesLibrary;
using System;
using System.Collections.Generic;
using System.Text;

namespace BackTrackClassLibrary
{
    class FindSpace : IFindSpace
    {
        int[] IFindSpace.Find(int[,] sudoku)
        {
            int[] coords = new int[2];
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                    if (sudoku[i, j] == 0)
                    {
                        coords[0] = i; //X
                        coords[1] = j; //Y
                        return coords;
                    }
            }
            coords[0] = -1;
            coords[1] = -1;//solving done
            return coords;
        }
    }
}
