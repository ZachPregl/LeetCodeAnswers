public class Solution
{
    public bool IsPalindrome(int x)
    {
        int legnthOf = x.ToString().Length;

        int[] array = new int[legnthOf];
        for (int i = 0; i < legnthOf; i++)
        {
            array[i] = x % 10;
            x /= 10;
        }
        int[] backwardsArray = new int[legnthOf];
        int counter = 0;
        for (int i = legnthOf - 1; i > -1; i--)
        {

            backwardsArray[counter] = array[i];
            counter++;
        }

        if (array.SequenceEqual(backwardsArray))
        {
            return true;
        }
        else
        {
            return false;

        }
    }
}
