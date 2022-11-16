using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pw6
{
    public  class Class1
    {
        public string option;
        public int dlina;
        public int dlina2;
        
        public static Class1 qwadrat = new Class1();
        public static Class1 pryamougolnik = new Class1();
        public static Class1 treugolnik = new Class1();
        public static void Init()
        {

            qwadrat.option = "квадрат";
            qwadrat.dlina = 10;
            qwadrat.dlina2 = 10;
            treugolnik.option = "тре угольная шахтра";
            treugolnik.dlina = 5;
            treugolnik.dlina2 = 5;
            pryamougolnik.option = "мой мозг";
            pryamougolnik.dlina = 6;
            pryamougolnik.dlina2 = 6;
            convert.class1s.Add(treugolnik);
            convert.class1s.Add(pryamougolnik);
            convert.class1s.Add(qwadrat);
        }
        public Class1()
        {
                
        }
        public Class1(string option, dynamic dlina, dynamic dlina2)
        {
            this.option = option;
            this.dlina = dlina;
            this.dlina2 = dlina2;
        }
    }
}
