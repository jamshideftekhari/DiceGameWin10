using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceWin10.Model
{
    public class Groups
    {
        private Random r;
        private string _groupName;
        private string _groupSign;
        private string[] _members;

        enum GroupNames{Alpha, Omega, Epsilon, Gamma, Zeta, Theta, Lambda, Delta}
        public Groups(Random r)
        {
            this.r = r;
        }

        public void RandomGroup()
        {
            _members = new string[5];
            int ranNr = r.Next(0, 6);
            switch (ranNr)
            {
                case (int)GroupNames.Alpha:
                    _groupName = "Alpha";
                    _groupSign = char.ConvertFromUtf32(0x3B1);
                    break;
                case (int)GroupNames.Delta:
                    _groupName = "Delta";
                    _groupSign = char.ConvertFromUtf32(0x3B4);
                    break;
                case (int)GroupNames.Epsilon:
                    _groupName = "Epsilon";
                    _groupSign = char.ConvertFromUtf32(0x3B5);
                    break;
                case (int)GroupNames.Gamma:
                    _groupName = "Gamma";
                    _groupSign = char.ConvertFromUtf32(0x3B3);
                    break;
                case (int)GroupNames.Lambda:
                    _groupName = "Lambda";
                    _groupSign = char.ConvertFromUtf32(0x3BB);
                    break;
                case (int)GroupNames.Omega:
                    _groupName = "Omega";
                    _groupSign = char.ConvertFromUtf32(0x3c9);
                    break;
                case (int)GroupNames.Theta:
                    _groupName = "Theta";
                    _groupSign = char.ConvertFromUtf32(0x3B8);
                    break;
                case (int)GroupNames.Zeta:
                    _groupName = "Zeta";
                    _groupSign = char.ConvertFromUtf32(0x3B6);
                    break;
                default:
                    break;

             }
            {
                
            }
        }

        public string GetFaceValue()
        {
            return _groupName;
        }
        public string GetSignValue()
        {
            return _groupSign;
        }
    }
}
