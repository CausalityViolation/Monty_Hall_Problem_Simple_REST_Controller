namespace MontyHallRESTController
{

    public class MontyHallProblem
    {
        public int RunGame(int numberOfSimulations, int switchDoor)
        {
            int WinsWhenSwitchingFromTheFirstDoor;
            int WinsWhenKeepingTheOriginalDoor;
            WinsWhenKeepingTheOriginalDoor = 0;
            WinsWhenSwitchingFromTheFirstDoor = 0;
            int shownDoor;
            Random random = new();

            for (int i = 0; i < numberOfSimulations; i++)
            {
                int winningDoor = random.Next(3);
                int chosenDoor = random.Next(3);

                //1 = win, 0 = lose
                int[] doors = { 0, 0, 0 };
                doors[winningDoor] = 1;


                do
                {
                    shownDoor = random.Next(3);
                }
                while (doors[shownDoor] == 1 || shownDoor == chosenDoor);


                WinsWhenKeepingTheOriginalDoor += doors[chosenDoor];


                //only remaining door
                WinsWhenSwitchingFromTheFirstDoor += doors[3 - chosenDoor - shownDoor];

            }

            if (switchDoor == 1)
            {

                return WinsWhenSwitchingFromTheFirstDoor;
            }

            else
            {

                return WinsWhenKeepingTheOriginalDoor;
            }
        }
    }
}
