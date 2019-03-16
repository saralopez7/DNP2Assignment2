using System.Collections.Generic;

namespace Assignment2
{
    // Delegate types to describe predicates on ints and actions on ints.
    public delegate bool GenericPredicate<in T>(T x);
    public delegate void GenericAction<in T>(T x);

    // Generic lists with Act and Filter operations.
    public class MyList<T> : List<T>
    {
        public MyList(params T[] elements) : base(elements) { }

        public void Act(GenericAction<T> f)
        {
            foreach (var i in this)
            {
                f(i);
            }
        }

        public MyList<T> Filter(GenericPredicate<T> p)
        {
            var res = new MyList<T>();
            foreach (var i in this)
                if (p(i))
                    res.Add(i);
            return res;
        }
    }
}
