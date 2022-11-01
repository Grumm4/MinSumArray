int[] nums = new int[] { 438, 879, 328, 463, 852, 725, 389, 368, 318, 762, 814, 109, 98, 971, 564, 444, 324, 256, 784, 230, 569, 
    822, 741, 865, 260, 49, 83, 896, 197, 219, 968, 836, 916, 877, 646, 488, 907, 50, 869, 796, 795, 784, 930, 912, 243, 652, 
    251, 738, 988, 427, 185, 596, 990, 920, 76, 446, 527, 393, 441, 952, 304, 403, 748, 383, 433, 869, 160, 29, 515, 766, 505, 
    481, 259, 990, 223, 744, 463, 573, 36, 265, 197, 153, 420, 948, 170, 416, 756, 777, 456, 876, 242, 747, 813, 680, 961, 12, 481, 
    610, 572, 200 };

int min = 10000;
int a = 0;
int b = 0;

void Min (ref int minimum, ref int a_p, ref int b_p)
{
    try
    {
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i+1; j < nums.Length-1; j++)
            {
                if ((nums[i] + nums[j+1]) < min)
                {
                    a = nums[i];
                    b = nums[j + 1];
                    min = a + b;
                }
                else continue;
            }
            Console.WriteLine($"Выполнено {i}%");
            Thread.Sleep(100);
            Console.Clear();
        }
    }
    catch (IndexOutOfRangeException)
    {
        Console.WriteLine("...");
    }
    finally
    {
        Console.WriteLine($"Минимальная сумма чисел найдена: \n{a} + {b} = {min}");
    }
}


Min(ref min, ref a, ref b);

