using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midassigment
{ 
   
    
        class Bank
        {
            private string bankName;
            private Account[] myBank;

            public Bank(string bankName, int size)
            {
                this.bankName = bankName;
                this.myBank = new Account[size];
            }

            public string BankName
            {
                set { this.bankName = value; }
                get { return this.bankName; }
            }

            public Account[] MyBank
            {
                get { return this.myBank; }
            }
        public void AddAccount()
        {

        }
        public void DeleteAccount()
        {

        }
        public void Transaction()
        {

        }
        public int SearchAccount()
        {

        }



}
