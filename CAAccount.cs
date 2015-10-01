using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;

namespace CrestAccountingSystem
{
    public class CAAccount
    {
        private static CTADataClassesDataContext dataContext;
        private const int ACCOUNT_NUMBER_MINIMUM = 1000000;
        private const int ACCOUNT_NUMBER_MAXIMUM = 9999999;
        public CAAccountContact ContactInformation { get; private set; }
        public int AccountNumber { get; private set; }

        public CAAccount(CAAccountContact contactInformation)
        {
            ContactInformation = contactInformation;
            AccountNumber = GenerateNewAccountNumber();
            AddAccountToDatabase();
        }

        private void AddAccountToDatabase()
        {
            var accountToInsert = new Account();
            accountToInsert.AccountContactName = ContactInformation.AccountContactName;
            accountToInsert.AccountName = ContactInformation.AccountName;
            accountToInsert.PhoneNumber = ContactInformation.PhoneNumber;
            accountToInsert.Email = ContactInformation.AccountEmail;
            accountToInsert.AccountNumber = AccountNumber;
            dataContext = new CTADataClassesDataContext();
            try
            {
                dataContext.Accounts.InsertOnSubmit(accountToInsert);
                dataContext.SubmitChanges();
            }
            catch (Exception exception)
            {
                Console.WriteLine("Error: {0}", exception.ToString());
            }
        }

        private int GenerateNewAccountNumber()
        {
            var random = new Random();
            return random.Next(ACCOUNT_NUMBER_MINIMUM, ACCOUNT_NUMBER_MAXIMUM);
        }
    }
}
