using BackTrackInterfacesLibrary;

namespace BackTrackClassLibrary
{
    public class CheckLocation : ICheckLocation
    {
        int[] line = new int[9];
        private readonly IValueRepeat _valueRepeat;

        public CheckLocation(IValueRepeat valueRepeat)
        {
            _valueRepeat = valueRepeat;
        }

        public virtual bool Check(int[,] sudoku, int num, int[] coords)
        {
            for (int i = 0; i < 9; i++)
                line[i] = sudoku[coords[0], i];
            if (_valueRepeat.IsRepeating(line, num)) //row checking
                return false;

            for (int i = 0; i < 9; i++)
                line[i] = sudoku[i, coords[1]];
            if (_valueRepeat.IsRepeating(line, num)) //column checking
                return false;

            for (int i = 0, n = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    line[n++] = sudoku[coords[0] - (coords[0] % 3) + i, coords[1] - (coords[1] % 3) + j];
            if (_valueRepeat.IsRepeating(line, num)) //square 3x3 checking
                return false;
            return true;
        }
    }
}
