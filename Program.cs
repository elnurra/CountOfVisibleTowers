
internal class Program
{
    private static void Main(string[] args)
    {
        List<int> towers = new List<int>();

        towers.Add(3);
        towers.Add(2);
        towers.Add(3);
        towers.Add(3);
 


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


        List<int> array = new List<int>();
        int countOfVisivibleRightTowers = 0;
        int countOfVisivibleLeftTowers = 0;
        for (int i = 0; i < towers.Count; i++)
        {
            for (int j = i  + 1  ; j < towers.Count; j++)
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
            array.Add(countOfVisivibleRightTowers);
            countOfVisivibleRightTowers = 0;

        }
        towers.Reverse();
        List<int> array2 = new List<int>();
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
            array2.Add(countOfVisivibleLeftTowers);
            countOfVisivibleLeftTowers = 0;

        }
        List<int> finalArray = new List<int>();
        for (int i = 0; i < array.Count; i++)
        {
            int finalCount = array[i] + array2[array2.Count-i-1];
            finalArray.Add(finalCount);

        }
        
        return finalArray;
    }

}

#region MyRegion
//towers.Reverse();
//List<int> array2 = new List<int>();
//for (int i = 0; i < towers.Count; i++)
//{
//    for (int j = i + 1; j < towers.Count; j++)
//    {
//        if (towers[i] >= towers[j])
//        {
//            countOfVisivibleLeftTowers++;
//        }
//        else
//        {
//            countOfVisivibleLeftTowers++;
//            break;
//        }

//    }
//    array2.Add(countOfVisivibleLeftTowers);
//    countOfVisivibleRightTowers = 0;

//}
//int finalCount;
//List<int> finalArray = new List<int>();
//for (int i = 0; i < array.Count; i++)
//{
//    finalCount = array[i] + array2[i];
//    finalArray.Add(finalCount);
//}
#endregion


