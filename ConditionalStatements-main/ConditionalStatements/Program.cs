namespace ConditionalStatements
{

    class Program
    {
        // INTRODUCTION to Conditional Statements assignment
        // The goal/purpose of this assignment is to learn how to use basic conditional statements
        // The assignment should be able to be completed using if/else statements
        static void Main(string[] args)
        {
            // Current balance of user
            double balance = 1000;

            // If user has past loans, used for TODO 4
            bool hasPastDueLoans = false;

            // Initial credit score of user
            int creditScore = 700;

            // Ask the user for input
            Console.WriteLine("Welcome to Enhanced Banking System!");
            Console.WriteLine("1. Check Balance");
            Console.WriteLine("2. Deposit Money");
            Console.WriteLine("3. Withdraw Money");
            Console.WriteLine("4. Apply for Loan");
            Console.Write("Enter your choice using number: ");

            // Read user input and save it into choice variable
            int choice = Convert.ToInt32(Console.ReadLine());

            // TODO 1: Check if user selected "Check Balance" option
            // TODO 1.1: Display the current balance to the user.

            if (choice == 1)
            {
                Console.WriteLine("Your balance is: " + balance);
            }

            // TODO 2: Check if user selected "Deposit Money" option
            // TODO 2.1: Prompt the user to enter an amount to deposit.
            // TODO 2.2: Validate the deposit amount. If valid, add to the balance and provide feedback.
            //           If invalid, display an error message.

            else if (choice == 2)
            {
                Console.Write("Enter an amount to deposit: ");
                double depositAmount = Convert.ToDouble(Console.ReadLine());

                if (depositAmount > 0)
                {
                    balance += depositAmount;
                    Console.WriteLine("Deposit successful. Your balance is: " + balance);
                }
                else
                {
                    Console.WriteLine("Invalid amount. Please enter a valid number.");
                }
            }

            // TODO 3: Check if user selected "Withdraw Money" option
            // TODO 3.1: Prompt the user to enter an amount to withdraw.
            // TODO 3.2: Validate the withdrawal amount: 
            // - Check if the user has sufficient funds.
            // - Check if the withdrawal amount is positive.
            // - Deduct from balance and provide feedback or display an appropriate error message.

            else if (choice == 3)
            {
                Console.Write("Enter an amount to withdraw: ");
                double withdrawAmount = Convert.ToDouble(Console.ReadLine());

                if (withdrawAmount > 0 && withdrawAmount <= balance)
                {
                    balance -= withdrawAmount;
                    Console.WriteLine("Withdrawal successful. Your new balance is: " + balance);
                }
                else if (withdrawAmount <= 0)
                {
                    Console.WriteLine("Invalid withdrawal amount. Please enter a valid number.");
                }
                else
                {
                    Console.WriteLine("Insufficient funds. Your balance is: " + balance);
                }
            }

            // TODO 4: Check if user selected "Apply for Loan" option
            // TODO 4.1: Evaluate the loan application based on the following criteria:
            // - Credit Score: Should be above 650.
            // - Balance: Should be greater than 2000 for approval.
            // - Past Due Loans: Check if the user has any past due loans.
            // Based on the above criteria, display a message indicating if the loan was approved or denied,
            // and if denied, state the reason.

            else if (choice == 4)
            {
                if (creditScore > 650 && balance > 2000 && !hasPastDueLoans)
                {
                    Console.WriteLine("Your loan is approved.");
                }
                else
                {
                    Console.WriteLine("Loan denied.");

                    if (creditScore <= 650)
                    {
                        Console.WriteLine("Credit score is low.");
                    }
                    if (hasPastDueLoans)
                    {
                        Console.WriteLine("You have past due loans.");
                    }
                    if (balance <= 2000)
                    {
                        Console.WriteLine("Balance is less than 2000.");
                    }
                }
            }

            // TODO 5: Do following if no other choice was used
            // TODO 5.1: Display an error message indicating the user made an invalid choice.

            else
            {
                Console.WriteLine("Invalid choice.");
            }

        }
    }
}