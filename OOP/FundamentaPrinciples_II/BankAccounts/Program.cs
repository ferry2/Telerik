using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts
{
    class Program
    {
        static void Main(string[] args)
        {
            Company comp = new Company("Balkancar Rekord JSC");
            Individual ind = new Individual("Vladislav Naydenov");

            Deposit dep1 = new Deposit(comp, 450000, 0.14m);
            Deposit dep2 = new Deposit(ind, 850, 0.05m);

            Loan loan1 = new Loan(comp, 450000, 0.14m);
            Loan loan2 = new Loan(ind, 850, 0.06m);

            Mortgage mort1 = new Mortgage(comp, 450000, 0.14m);
            Mortgage mort2 = new Mortgage(ind, 850, 0.04m);

            Console.WriteLine(dep1.CalculateInterest(6));
            Console.WriteLine(dep2.CalculateInterest(2.5m));

            Console.WriteLine(mort1.CalculateInterest(6));
            Console.WriteLine(mort2.CalculateInterest(2.5m));

            Console.WriteLine(loan1.CalculateInterest(6));
            Console.WriteLine(loan2.CalculateInterest(2.5m));

            dep1.Deposite(450);
            dep2.WithDraw(100);

            Console.WriteLine("The customer is of type \"{0}\", with name: {1}. \nAccount is of type \"{2}\" \nBalance: {3} \nInterest rate: {4:p}",
                comp.GetType().Name, comp.Name, dep1.GetType().Name, dep1.Balance, dep1.InterestRate);
            Console.WriteLine("The customer is of type \"{0}\", with name: {1}. \nAccount is of type \"{2}\" \nBalance: {3} \nInterest rate: {4:p}",
                ind.GetType().Name, ind.Name, dep2.GetType().Name, dep2.Balance, dep2.InterestRate);

            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("The customer is of type \"{0}\", with name: {1}. \nAccount is of type \"{2}\" \nBalance: {3} \nInterest rate: {4:p}",
                comp.GetType().Name, comp.Name, loan1.GetType().Name, loan1.Balance, loan1.InterestRate);
            Console.WriteLine("The customer is of type \"{0}\", with name: {1}. \nAccount is of type \"{2}\" \nBalance: {3} \nInterest rate: {4:p}",
                ind.GetType().Name, ind.Name, loan2.GetType().Name, loan2.Balance, loan2.InterestRate);

            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("The customer is of type \"{0}\", with name: {1}. \nAccount is of type \"{2}\" \nBalance: {3} \nInterest rate: {4:p}",
                comp.GetType().Name, comp.Name, mort1.GetType().Name, mort1.Balance, mort1.InterestRate);
            Console.WriteLine("The customer is of type \"{0}\", with name: {1}. \nAccount is of type \"{2}\" \nBalance: {3} \nInterest rate: {4:p}",
                ind.GetType().Name, ind.Name, mort2.GetType().Name, mort2.Balance, mort2.InterestRate);
        }
    }
}
