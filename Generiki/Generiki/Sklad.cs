using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generiki
{
    class Sklad
    {
        int m_size;
        object[] m_Items;
        int m_StackPointer = 0;

        public Sklad(int v) {
            m_size = v;
            m_Items = new object[v];
        }

        public Sklad() : this(100) { }

        public void Push(object item) {
            if (m_StackPointer >= m_size) { throw new Exception("Sklad je poln"); }
            m_Items[m_StackPointer] = item;
            m_StackPointer++;
        }

        public object Pop() {
            m_StackPointer--;
            if (m_StackPointer >= 0) { return m_Items[m_StackPointer]; }
            throw new Exception("Sklad je prazen");
        }
    }
}
