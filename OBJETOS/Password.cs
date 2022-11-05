 class Password
    {

        int length;
        string password;

        public Password()
        {
           length = 8;
           

        }

        public Password(int length)
        {
            this.length = length;   

        }

        public int GetLength()
        {

            return length;

        }

        public string GetPassword()
        {

            return password;
        }

        public void SetLength(int length)
        {

            this.length = length;
        }
        
        public void GeneratePassword(string password) //esto no va a funcionar
        {
            this.password = password;


        }

        public bool Strong()
        {


        }
    }
