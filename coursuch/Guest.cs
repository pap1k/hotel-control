using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coursuch
{
    public class Guest
    {
        public string name, surname, patronymic;
        public int roomN;

        public Guest(string n, string s, string p, int num)
        {
            this.name = n;
            this.surname = s;
            this.patronymic = p;
            this.roomN = num;
        }

    }
}
