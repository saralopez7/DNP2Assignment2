using System.Linq;
using System.Text;

namespace Assignment2
{
    public static class Extentions
    {
        public static string ToString<T>(this IntList list)
        {
            var sb = new StringBuilder("[");
            list.ForEach(item =>
            {
                if (item.Equals(list.Last()))
                {
                    sb.Append(item + "]");
                }
                else
                {
                    sb.Append(item + ", ");
                }

            });

            return sb.ToString();
        }
    }
}
