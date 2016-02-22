using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Net_module1_2_3_lab
{
    // 1) declare enumeration CurrencyTypes, values UAH, USD, EU
    enum CurrencyTypes { Undefined, UAH, USD, EU };

    class Money
    {
        // 2) declare 2 properties Amount, CurrencyType

        public double Amount {get; set;}
        public CurrencyTypes CurrencyType {get;}
        
        // 3) declare parameter constructor for properties initialization

        public Money(CurrencyTypes CurType, double sum = 0.0d)
        {
            CurrencyType = CurType;
            Amount = sum;
        }

        // 4) declare overloading of operator + to add 2 objects of Money

        public static Money operator +(Money money1, Money money2)
        {
            return new Money(money1.CurrencyType, money1.Amount + money2.Amount);
        }

        public static Money operator +(Money money1, double d)
        {
            return new Money(money1.CurrencyType, money1.Amount + d);
        }

        // 5) declare overloading of operator -- to decrease object of Money by 1

        public static Money operator --(Money money)
        {
            --money.Amount;
            return money;
        }

        // 6) declare overloading of operator * to increase object of Money 3 times

        public static Money operator *(Money money, int num)
        {
            money.Amount *= num;
            return money;
        }

        // 7) declare overloading of operator > and < to compare 2 objects of Money

        public static bool operator >(Money money1, Money money2)
        {
            return (money1.Amount > money2.Amount);
        }

        public static bool operator <(Money money1, Money money2)
        {
            return (money1.Amount < money2.Amount);
        }

        // 8) declare overloading of operator true and false to check CurrencyType of object

        public static bool operator true(Money money)
        {
            return (money.CurrencyType > 0);
        }

        public static bool operator false(Money money)
        {
            return (money.CurrencyType == 0);
        }

        // 9) declare overloading of implicit/ explicit conversion  to convert Money to double, string and vice versa

        public static implicit operator double(Money money)
        {
            return money.Amount;
        }

        public static implicit operator string(Money money)
        {
            return money.Amount.ToString();
        }

        public static explicit operator Money(double sum)
        { 
            return new Money(CurrencyTypes.Undefined, sum);
        }

        public static implicit operator Money(string str)
        {
            return new Money(CurrencyTypes.Undefined, double.Parse(str));
        }

        public static bool operator ==(Money money1, Money money2)
        {
            if (money1.CurrencyType == money2.CurrencyType)
            {
                return true;
            }
            else
            {
                Console.WriteLine("You can't work with different сurrency types" );
                return false;
            }
        }
        public static bool operator !=(Money money1, Money money2)
        {
            if (money1.CurrencyType != money2.CurrencyType)
            {
                Console.WriteLine("You can't work with different сurrency types");
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
