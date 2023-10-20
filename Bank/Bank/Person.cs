using System;
using System.Collections.Generic;
using System.Reflection.Metadata;

namespace Bank
{
    internal class Person
    {
        // det som vi gjorde har är att vi använda oss av egenskap bara där sätter vi ingen värde eller något 
        /// medan vi bara get och set de två varibalerna, inget mer eller mindre
        ///  lägg märke till att både varibalerna är stringer inget int. 
        /// </summary>
        string passWord;
        string userName;
        public string PassWord
        {
            get;
            set;
        }
        public string UserName
        {
            get;
            set;
        }

    }
}
