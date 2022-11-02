namespace Banco
{
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

            return accountholder + "tienes " + amount + "dinero en la cuenta";
        }

        public bool ToDeposit(float requiredamount)
        {
            if (requiredamount <= 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool ToWithDraw(float requiredamount)
        {
            if (requiredamount <= 0)
            {
                return false;
            }
            else
            {
                return true;
            }

            if (requiredamount > amount)
            {
                return false;
            }
        }
    }
}

