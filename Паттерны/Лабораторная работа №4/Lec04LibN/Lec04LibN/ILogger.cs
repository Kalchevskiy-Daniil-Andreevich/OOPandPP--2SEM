using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lec04LibN
{
    public interface ILogger
    {
        void start(string title);                                                                                                                //Старт простр имен
        void log(string message);                                                                                                         //вывод сообщ в тек простр
        void stop();                                                                                                                                 //заверш простр
    }
}