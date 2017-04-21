using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractVsInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    abstract class Interview
    {
        void WrittenTest()
        {
            Console.Write("Written test");
        }

        void TellMeAboutYourself()
        {
            Console.Write("Ask to tell about himself");
        }

        /// <summary>
        /// Should be publis
        /// Should not have implementation details
        /// </summary>
        /// <returns></returns>
        public abstract bool TechnicalQuestions();

        public abstract bool Hr();

    }
    class Fresher: Interview
    {
        /// <summary>
        /// Should override the abstract methods of the Ingterview
        /// </summary>
        /// <returns></returns>
        public override bool TechnicalQuestions()
        {
            throw new NotImplementedException();    
        }

        public override bool Hr()
        {
            throw new NotImplementedException();
        }
    }
   
}
