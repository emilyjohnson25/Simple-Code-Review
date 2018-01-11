using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeReview
{
    /// <summary>
    /// The Salutation class Represents somthing that can say hello or goodbye.
    /// </summary>
    public class Salutation
    {
        #region Properties and feilds - What the Salutation Objects will "look like"
        //Feilds
        private string _Greeting;
        private string _Farewell;
        #endregion

        #region Constructor and Methods - How the Salutation will "behave"
        /// <summary>
        /// Instantiates a Salutation object with the appropriate message 
        /// </summary>
        /// <param name="greetingMessage">message to use when greeting</param>
        /// <param name="farewellMessage">message to use when saying goodbye</param>
        public Salutation(string greetingMessage, string farewellMessage)
        {
            _Greeting = greetingMessage;
            _Farewell = farewellMessage;
        }
        public string Greet()
        {

            return _Greeting;
        }
        public string SayFarewell()
        {
            return _Farewell;
        }
        #endregion
    }
}
