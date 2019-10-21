using System;

namespace HelloApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account(4);
        }
    }
    class Account
    {
        public int Id { get; private set; } // номер счета
        public Account(int _id)
        {
            Id = _id;
        }
    }
}