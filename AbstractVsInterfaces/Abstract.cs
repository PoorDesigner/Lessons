using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractVsInterfaces
{
    class Abstract
    {
        static void Main(string[] args)
        {
            // Session vs Cookie ?
            // Tupes of Authentication in ASP ?
            // How Garbage collector works in .net
            // Why no return type for constructor ?

            // Why MVC ?
            // What is the adavantage of using ASP.NET routing?
            // Action filters in MVC ?
            // How do you change the variable value while debugging
            // Put vs Post
            // $.ajax({
            //    type: 'PUT',
            //url: '/products/123',
            //data: { name: 'new product name' }
            //    });
            //    }


            //// SQL

            // Differnce between union and union all which is better in terms of performance ?
            // select case when null is null then 'Yup' else 'Nope' end as Result;
            // Rank vs Dense_rank For example, consider the set {25, 25, 50, 75, 75, 100}. For such a set, RANK() will return {1, 1, 3, 4, 4, 6} (note that the values 2 and 5 are skipped), whereas DENSE_RANK() will return {1,1,2,3,3,4}.
            // How to delte a duplicates rows which have no primary key
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
        class Fresher : Interview
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
