using BackTrackInterfacesLibrary;

namespace BackTrackClassLibrary
{
    public class FindSolution : IFindSolution//Main class for algorithm
    {
        private readonly ICheckLocation _checkLocation;
        private readonly IFindSpace _findSpace;

        public FindSolution(ICheckLocation checkLocation, IFindSpace findSpace)
        {
            _checkLocation = checkLocation;
            _findSpace = findSpace;
        }
        public virtual bool FindSol(int[,] sudoku)
        {
            int [] coords = _findSpace.Find(sudoku);
            if (coords[0] == -1) return true;

            for (int i = 1; i < 10; i++)
            {
                if (_checkLocation.Check(sudoku, i, coords))
                {
                    sudoku[coords[0], coords[1]] = i;
                    if (FindSol(sudoku))
                    {
                        return true;
                    }

                }
            }
            sudoku[coords[0], coords[1]] = 0;
            return false;
        }
        
    }
}

