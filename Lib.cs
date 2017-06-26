using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerialportCheck
{
    class Lib
    {
        public string cmd(string text, int selected_index)
        {
            string EOS = "";
            switch (selected_index)
            {
                case 1:
                    EOS = "\r";
                    break;
                case 2:
                    EOS = "\n";
                    break;
                case 3:
                    EOS = "\r\n";
                    break;
            }
            return text + EOS;
        }
    }
}