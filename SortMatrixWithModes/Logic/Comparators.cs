using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class ElementsSumIncreasing : IComparer
    {
        int IComparer.Compare(int[] a, int[] b)
        {
            if (a == null || b == null) throw new ArgumentException();
            return a.Sum().CompareTo(b.Sum());
        }
    }
    public class ElementsSumDecreasing : IComparer
    {
        int IComparer.Compare(int[] a, int[] b)
        {
            if (a == null || b == null) throw new ArgumentException();
            return b.Sum().CompareTo(a.Sum());
        }
    }
    public class ElementsMaxIncreasing : IComparer
    {
        int IComparer.Compare(int[] a, int[] b)
        {
            if (a == null || b == null) throw new ArgumentException();
            return a.Max().CompareTo(b.Max());
        }
    }
    public class ElementsMaxDecreasing : IComparer
    {
        int IComparer.Compare(int[] a, int[] b)
        {
            if (a == null || b == null) throw new ArgumentException();
            return b.Max().CompareTo(a.Max());
        }
    }
    public class ElementsMinIncreasing : IComparer
    {
        int IComparer.Compare(int[] a, int[] b)
        {
            if (a == null || b == null) throw new ArgumentException();
            return a.Min().CompareTo(b.Min());
        }
    }
    public class ElementsMinDecreasing : IComparer
    {
        int IComparer.Compare(int[] a, int[] b)
        {
            if (a == null || b == null) throw new ArgumentException();
            return b.Min().CompareTo(a.Min());
        }
    }
}
    