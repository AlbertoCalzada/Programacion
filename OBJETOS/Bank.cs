using System;

namespace Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount B1 = new BankAccount("Jorge");
            BankAccount B2 = new BankAccount("Fran", 150000);

            B1.ToDeposit(-1);
            Console.WriteLine(B1.Write());
            B1.ToWithDraw(40);
            Console.WriteLine(B1.Write());
            Console.WriteLine();
            
            B2.ToDeposit(50000);
            Console.WriteLine(B2.Write());

           
        }
    }


    class BankAccount
    {

        string accountholder;
        float amount;


        public BankAccount(string accountholder)
        {
            this.accountholder = accountholder;
            amount = 0;

        }
        public BankAccount(string accountholder, float amount)
        {
            this.accountholder = accountholder;
            this.amount = amount;

        }

        public string GetAccountHolder()
        {

            return accountholder;
        }
        public float GetAmount()
        {

            return amount;
        }

        public void SetAccountHolder(string accountholder)
        {
            this.accountholder = accountholder;

        }

        public void SetAmount(float amount)
        {
            this.amount = amount;

        }

        public string Write()
        {

            if (amount > 0)
            {
                return accountholder + " ahora tienes " + amount + " euros en la cuenta";
            }
            else
            {
                return accountholder + " has realizado una transacción erronea, intentalo de nuevo";
            }
            
        }

        public bool ToDeposit(float requiredamount)
        {
            
            if (requiredamount <= 0)
            {
                Console.WriteLine("No has depositado una cantidad correcta " +accountholder);
                return false;
            }
            else
            {
                Console.WriteLine("El dinero ha sido sumado a tu cuenta con éxito " + accountholder);
                amount = amount + requiredamount;
                return true;
            }
            
        }

        public bool ToWithDraw(float requiredamount)
        {
            amount = amount - requiredamount;
            if (requiredamount <= 0 || requiredamount > amount)
            {
                Console.WriteLine("El dinero NO ha sido retirado de tu cuenta con éxito " + accountholder);
                return false;
            }
            else
            {
                Console.WriteLine("El dinero ha sido retirado de tu cuenta con éxito " + accountholder);
                return true;
            }

            
        }
    }
}

