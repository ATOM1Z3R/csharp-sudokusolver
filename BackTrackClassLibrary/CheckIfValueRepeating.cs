using BackTrackInterfacesLibrary;

namespace BackTrackClassLibrary
{
    public class CheckIfValueRepeating : IValueRepeat
    {
        public virtual bool IsRepeating(int[] tab, int num) //checking numbers if not repeating in row or column
        {
            for (int i = 0; i < tab.Length; i++)
                if (tab[i] == num)
                    return true;
            return false;
        }
    }
}
