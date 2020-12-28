using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture15.Task1
{
    class UniqueItem
    {
        private static int _counter = 0;

        public int Id { get; private set; }

        public UniqueItem()
        {
            Id = _counter;
            _counter++;
        }

        public UniqueItem(int id)
        {
            _counter = id;
            Id = _counter;
            _counter++;
        }
    }
}
