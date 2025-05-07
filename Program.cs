int[] flowerbed = {1, 0, 0, 0, 1};
Console.WriteLine(CanPlantInFlowerbed(flowerbed, 1));
int[] flowerbed2 = { 1, 0, 0, 0, 1 };
Console.WriteLine(CanPlantInFlowerbed(flowerbed2, 2));


bool CanPlantInFlowerbed(int[] flowerbed, int n)
{
    int planted = 0;
    for (int i = 0; i < flowerbed.Length - 1; i++)
    {
        if (flowerbed[i] == 0)
        {
            bool leftSpotIsClear = (i == 0 || flowerbed[i - 1] == 0);
            bool rightSpotIsClear = (i == flowerbed.Length - 1 || flowerbed[i + 1] == 0);

            if (leftSpotIsClear && rightSpotIsClear)
            {
                flowerbed[i] = 1;
                planted++;
            }
        }

    }
    return planted == n;
}