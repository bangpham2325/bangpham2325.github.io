using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace brCSDL
{
    class CCBBItem
    {
        private int _Value;
        private string text;

        public int Value { get => _Value; set => _Value = value; }
        public string Text { get => text; set => text = value; }
        public override string ToString()
        {
            return Text;
        }
    }
}
