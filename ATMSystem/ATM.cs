using ATMSystem.ATMStates;

namespace ATMSystem
{
    public class ATM
    {
        static ATM atmObject = new ATM();
        ATMState currentATMState;

        int atmBalance;
        int noOfTwoThousandNotes;
        int noOfFiveHundredNotes;
        int noOfHundredNotes;

        public void setCurrentATMState(ATMState currentATMState)
        {
            this.currentATMState = currentATMState;
        }

        public ATMState getCurrentATMState()
        {
            return currentATMState;
        }

        public static ATM getATMObject() {
            atmObject.setCurrentATMState(new IdleState());
            return atmObject;
        }

        public int getATMBalance()
        {
            return atmBalance;
        }

        public void setAtmBalance(int atmBalance, int noOfTwoThousandNotes, int noOfFiveHundredNotes, int noOfOneHundredNotes)
        {
            this.atmBalance = atmBalance;
            this.noOfTwoThousandNotes = noOfTwoThousandNotes;
            this.noOfFiveHundredNotes = noOfFiveHundredNotes;
            this.noOfHundredNotes = noOfOneHundredNotes;
        }

        public int getNoOfTwoThousandNotes()
        {
            return noOfTwoThousandNotes;
        }

        public int getNoOfFiveHundredNotes()
        {
            return noOfFiveHundredNotes;
        }

        public int getNoOfOneHundredNotes()
        {
            return noOfHundredNotes;
        }

        public void deductATMBalance(int amount)
        {
            atmBalance = atmBalance - amount;
        }

        public void deductTwoThousandNotes(int number)
        {
            noOfTwoThousandNotes = noOfTwoThousandNotes - number;
        }

        public void deductFiveHundredNotes(int number)
        {
            noOfFiveHundredNotes = noOfFiveHundredNotes - number;
        }

        public void deductOneHundredNotes(int number)
        {
            noOfHundredNotes = noOfHundredNotes - number;
        }

        public void printCurrentATMStatus()
        {
            Console.WriteLine("Balance: " + atmBalance);
            Console.WriteLine("2kNotes: " + noOfTwoThousandNotes);
            Console.WriteLine("500Notes: " + noOfFiveHundredNotes);
            Console.WriteLine("100Notes: " + noOfHundredNotes);

        }

    }
}
