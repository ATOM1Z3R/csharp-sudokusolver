using BackTrackInterfacesLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace backtrack
{
    public class AppStart : IAppStart
    {
        private readonly IFindSolution _findSolution;
        public AppStart(IFindSolution findSolution)
        {
            _findSolution = findSolution;
        }

        public void Start(int[,] sudoku)
        {
            _findSolution.FindSol(sudoku);
        }
    }
}
