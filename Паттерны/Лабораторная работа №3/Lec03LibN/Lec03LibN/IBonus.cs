using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lec03LibN
{
    public interface IBonus                                                                                                                //Вознаграждение
    {
        float cost1hour { get; set; }
        float calc(                                                                                                             //вычисление вознагрождения
                   float number_hours                                                                                           //кол-во отработанных часов
                  );
    }
}
