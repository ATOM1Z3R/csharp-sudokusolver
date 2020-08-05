using System;
using System.Collections.Generic;
using System.Text;

namespace BackTrackInterfacesLibrary
{
    public interface IFindSolution
    {
        bool FindSol(int[,] sudoku);
    }
}
