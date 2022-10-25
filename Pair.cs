using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace PairOnHаnds
{
    internal class Pair
    {
        public int One { get; set; }
       public int Two { get; set; }



        /// <summary>
        /// 
        /// </summary>
        /// <param name="firstPair" name="secondPair"></param>
        /// <returns name="result"></returns>
        public Pair Multiplication(Pair firstPair, Pair secondPair, Pair result)
        {

            result.One = firstPair.One * secondPair.One;
            result.Two = firstPair.Two * secondPair.Two ;
            return result;
        }
        /// <summary>
        /// Умножает пары чисел
        /// </summary>
        /// <param name="firstPair"></param>
        /// <returns name="result"></returns>
        public Pair Multiplication(Pair firstpair,Pair result)
        {

            result.One = firstpair.One * 2;
            result.Two=firstpair.Two * 2;

            return result;
        }
        /// <summary>
        /// Конструктор
        /// </summary>
        public  Pair()
        {
            One = 0;
            Two = 0;
            
        }
    }
}
