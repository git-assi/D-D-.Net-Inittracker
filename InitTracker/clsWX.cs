using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InitTrackerBase
{
    public class clsWX
    {
        Random m_rnd;
        int m_intSeiten;

        public clsWX(int intSeiten)
        {
            m_rnd = new Random(DateTime.Now.Second * DateTime.Now.Millisecond);
            m_intSeiten = intSeiten;
        }

        public int Wurf()
        {
            return (m_rnd.Next() % m_intSeiten) + 1;
        }
    }
}
