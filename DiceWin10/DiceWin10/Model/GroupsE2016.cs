using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DiceWin10.Model
{
    class GroupsE2016
    {
        private Random r;
        private string _groupName;
        private string _groupSign;
        private string[] _members;

        // enum GroupNamesE2016 { 3d, 711, aOS, Birat, Fit, Itnh, Unos, Warriors }
        //enum GroupNames { Alpha, Omega, Epsilon, Gamma, Zeta, Theta, Lambda, Delta }

        enum GroupNames { DDD, Seven, aOs, Birat, Fit, Itnh, Unos, Warriers}

        public GroupsE2016(Random r)
        {
            this.r = r;
        }

        private void InitGroupMembers()
        {

            
        }

        public void RandomGroup()
        {
            int ranNr = r.Next(0, 6);
            switch (ranNr)
            {
                case (int)GroupNames.DDD:
                    _groupName = "3D";
                    _groupSign = char.ConvertFromUtf32(0x3B1);
                    break;
                case (int)GroupNames.Seven:
                    _groupName = "7_11";
                    _groupSign = char.ConvertFromUtf32(0x3B4);
                    break;
                case (int)GroupNames.aOs:
                    _groupName = "aOS";
                    _groupSign = char.ConvertFromUtf32(0x3B5);
                    break;
                case (int)GroupNames.Birat:
                    _groupName = "Birat Pay";
                    _groupSign = char.ConvertFromUtf32(0x3B3);
                    break;
                case (int)GroupNames.Fit:
                    _groupName = "F.I.T.Y.M.I";
                    _groupSign = char.ConvertFromUtf32(0x3BB);
                    break;
                case (int)GroupNames.Itnh:
                    _groupName = "ITNH";
                    _groupSign = char.ConvertFromUtf32(0x3c9);
                    break;
                case (int)GroupNames.Unos:
                    _groupName = "Unos";
                    _groupSign = char.ConvertFromUtf32(0x3B8);
                    break;
                case (int)GroupNames.Warriers:
                    _groupName = "Warriors";
                    _groupSign = char.ConvertFromUtf32(0x3B6);
                    break;
                default:
                    break;

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
