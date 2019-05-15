using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Tests
{
    delegate void EinfacherDelegate();
    delegate void DelegateMitParameter(string name);
    delegate long CalcDelegate(int a, int b);

    public class HalloDelegate
    {

        public HalloDelegate()
        {
            EinfacherDelegate meinDele = EinfacheMethode;
            Action meinDeleAlsAction = EinfacheMethode;
            Action meinDeleAlsAction2 = delegate () { Console.WriteLine("Hallo"); };
            Action meinDeleAlsAction3 = () => { Console.WriteLine("Hallo"); };
            Action meinDeleAlsAction4 = () => Console.WriteLine("Hallo");

            DelegateMitParameter deleMitPara = MethodeMitPara;
            Action<string> actionMitString = MethodeMitPara;
            DelegateMitParameter deleMitPara2 = delegate (string bla) { Console.WriteLine("Hallo" + bla); };
            DelegateMitParameter deleMitPara3 = (string bla) => { Console.WriteLine("Hallo" + bla); };
            DelegateMitParameter deleMitPara4 = (bla) => Console.WriteLine("Hallo" + bla);
            DelegateMitParameter deleMitPara5 = x => Console.WriteLine("Hallo" + x);

            CalcDelegate calcDele = Sum;
            Func<int, int, long> calcFunc = Sum;
            Func<int, int, long> calcFunc2 = delegate (int a, int b) { return a + b; };
            Func<int, int, long> calcFunc3 = (int a, int b) => { return a + b; };
            Func<int, int, long> calcFunc4 = (a, b) => { return a + b; };
            Func<int, int, long> calcFunc5 = (a, b) => a + b;

            List<string> liste = new List<string>();
            liste.Where(Filter);
            liste.Where(x => x.StartsWith("B"));


        }

        public void MachDinge(object obj)
        {
            #region .NET 1.1 casting
            if (obj is DateTime) //typ prüfung 
            {
                DateTime objAsDate = (DateTime)obj; //casting
            }
            #endregion

            #region .NET 2.0 boxing
            DateTime? objAsDateTime = obj as DateTime?;
            if (objAsDateTime != null)
            {

            }
            #endregion

            #region (C# 6) pattern matching
            if (obj is DateTime objAsDateTime2)
            {

            }
            #endregion


        }


        private bool Filter(string arg)
        {
            if (arg.StartsWith("B"))
                return true;
            else
                return false;
        }

        private long Sum(int a, int b)
        {
            return a + b;
        }

        private void MethodeMitPara(string txt)
        {
            //Console.WriteLine(string.Format("Hallo {0}", txt));
            Console.WriteLine($"Hallo {txt} {0.67:000.00}");
        }

        public void EinfacheMethode()
        {
            Console.WriteLine("Hallo");
        }


        public void HalloLinq()
        {


            List<String> liste = new List<string>();

            var query = from i in liste
                        where i == "Fred"
                        orderby i.Length, i.Length ascending
                        select i;
            query.ToList();

            var ll = liste.Where(i => i == "Fred")
                          .OrderBy(i => i.Length)
                          .ThenByDescending(i => i.Length);
        }
    }
}
