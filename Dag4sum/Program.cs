using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dag4sum
{
    class Program
    {
        static void Main(string[] args)
        {


            //Singleton s = Singleton.HentSingleton();

            //OblBeregning.Beregning1();


            //Person p = new Person();
            


        }
    }

    public static class OblBeregning
    {

        public static bool Beregning1()
        {
            return false;
        }

        public static int Beregning2(int a)
        {
            return 0;
        }

    }

    public class Singleton
    {
        // Man må ikke skabe en instans - kun HentSingleton er mulig
        private Singleton() { }

        // instans data (bør ikke være offentligt felt)
        public int Id;
        // mv...

        private static Singleton o = null;

        public static Singleton HentSingleton()
        {
            if (o == null)
                o = new Singleton();
            return o;
        }

    }
}
