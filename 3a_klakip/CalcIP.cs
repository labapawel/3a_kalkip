using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3a_klakip
{
    internal class CalcIP
    {
        public Dictionary<int, uint> maski = new Dictionary<int, uint>();
        private int _selectMask = 24;
        public int SelectMask { set { _selectMask = value; } get { return _selectMask; } }
        public CalcIP()
        {
            this.maski.Clear();
            this.genMask();

        }
        public string ipToDec(uint addr)
        {
            uint addtmp = addr;
            string ip = "";
            for(int i = 4; i > 0; i--)
            {
                byte tmp = (byte)(addtmp & 0xff);
                if (i < 4) ip = ip + ".";
                ip = ip + tmp.ToString();
                addtmp >>= 8;
            }
            return ip;
        }
        private void genMask()
        {
            uint maska = 0xffffffff;
            for(int i=32;i>=0; i--)
            {
                uint maskatmp = maska & 0xffffffff;
                this.maski.Add(i, maskatmp);
                maskatmp = (0xffffffff & (maskatmp << 1) );
            }
        } 
    }
}
