
internal class Program
{
    private static void Main(string[] args)
    {
        List<int> towers = new List<int> { 5, 2, 10, 1 };

        foreach (var item in towers)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
        List<int> countOfvisibleTowers = countVisibleTowers(towers);
        foreach (var item in countOfvisibleTowers)
        {
            Console.Write(item + " ");
        }
    }

    public static List<int> countVisibleTowers(List<int> towers)
    {
        List<int> ListOfLeftTower = new List<int>();
        int countOfVisivibleRightTowers = 0;
        int countOfVisivibleLeftTowers = 0;
        for (int i = 0; i < towers.Count; i++)
        {
            for (int j = i + 1; j < towers.Count; j++)
            {
                if (towers[i] >= towers[j])
                {
                    countOfVisivibleRightTowers++;
                }
                else
                {
                    countOfVisivibleRightTowers++;
                    break;
                }
            }
            ListOfLeftTower.Add(countOfVisivibleRightTowers);
            countOfVisivibleRightTowers = 0;
        }
        towers.Reverse();
        List<int> ListOfRightTower = new List<int>();
        for (int i = 0; i < towers.Count; i++)
        {
            for (int j = i + 1; j < towers.Count; j++)
            {
                if (towers[i] >= towers[j])
                {
                    countOfVisivibleLeftTowers++;
                }
                else
                {
                    countOfVisivibleLeftTowers++;
                    break;
                }
            }
            ListOfRightTower.Add(countOfVisivibleLeftTowers);
            countOfVisivibleLeftTowers = 0;
        }
        List<int> ListOfVisibleTowers = new List<int>();
        for (int i = 0; i < towers.Count; i++)
        {
            int finalCount = ListOfLeftTower[i] + ListOfRightTower[ListOfRightTower.Count - i - 1];
            ListOfVisibleTowers.Add(finalCount);
        }
        return ListOfVisibleTowers;
    }
}
