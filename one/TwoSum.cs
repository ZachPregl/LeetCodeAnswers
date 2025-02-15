public class Solution {
    public int[] TwoSum(int[] nums, int target) {
    int[] answer;
    int currentOuterIndex = 0;
    int currentInnerIndex = 0;

    foreach (int currentOuter in nums)
    {
        currentInnerIndex = 0;
        foreach (int currentInner in nums)
        {
            if (currentOuter + currentInner == target && currentOuterIndex != currentInnerIndex)
            {
                answer = new int[] { currentOuterIndex, currentInnerIndex };
                return answer;
            }
            else
            {
                currentInnerIndex += 1;
            }
        }
        currentOuterIndex += 1;
    }
        throw new ArgumentException("No two sum solution");
    }  
}
