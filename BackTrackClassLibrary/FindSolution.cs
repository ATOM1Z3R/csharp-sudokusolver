using BackTrackInterfacesLibrary;

namespace BackTrackClassLibrary
{
    public class FindSolution : CheckLocation, IFindSpace //Main class for algorithm
    {
        public virtual bool Find(int[,] sudoku)
        {
            int [] coords = FindSpace(sudoku);
            if (coords[0] == -1) return true;

            for (int i = 1; i < 10; i++)
            {
                if (Check(sudoku, i, coords))
                {
                    sudoku[coords[0], coords[1]] = i;
                    if (Find(sudoku))
                    {
                        return true;
                    }

                }
            }
            sudoku[coords[0], coords[1]] = 0;
            return false;
        }
        public virtual int[] FindSpace(int[,] sudoku)
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

