using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lec03LibN
{
    public interface IFactory                                                                                                         //типы вознаграждения
    {
        IBonus getA(float cost1hour);
        IBonus getB(float cost1hour, float x);                                                                          //понижающий/повышающий коэффициент
        IBonus getC(float cost1hour, float x, float y);                                                                       //величина снижения/повышения
    }
}
