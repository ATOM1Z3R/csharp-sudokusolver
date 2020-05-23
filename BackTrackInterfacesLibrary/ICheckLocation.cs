using System;
using System.Collections.Generic;
using System.Text;

namespace BackTrackInterfacesLibrary
{
    public interface ICheckLocation
    {
        bool Check(int[,] sudoku, int num, int[] coords);
    }
}
