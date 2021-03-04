using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinkedList_Reto;

namespace LinkedList_Reto
{
    class Program
    {
        static void Main(string[] args)
        { 
            LinkedList lista1 = new LinkedList();

            lista1.add(1);
            lista1.add(4);
            lista1.add(3);
            lista1.add(7);

            Iterator it = lista1.getIterator();
            
            while(it.hasNext())
            {
                Iterator backupIt = new Iterator(it);
                int element = it.next();

                if(element==3)
                {
                    lista1.insert(10, LinkedList.BEFORE, backupIt);
                }

                if (element == 7)
                {
                    lista1.insert(15, LinkedList.AFTER, backupIt);
                }

            }

            lista1.delete(3);

            Console.WriteLine("----------------");
            Console.WriteLine("El tamaño es:" + lista1.getSize());
            Console.WriteLine("----------------");
            //Console.ReadKey();

            it = lista1.getIterator();

            while (it.hasNext())
            {
                int element = it.next();

                Console.WriteLine("Dato: " + element);
            }

            Console.WriteLine("---------------------");

            ReverseIterator reverseIterator = lista1.getReverseIterator();


            while (reverseIterator.hasNext())
            {
                int element = reverseIterator.next();

                Console.WriteLine("Dato: " + element);
            }
            Console.ReadKey();
        }

    }
}
