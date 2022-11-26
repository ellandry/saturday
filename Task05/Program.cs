int[] nums = new int[6];
for (int i = 0; i < nums.Length; i++)
{
    Console.WriteLine($"Введите {1+i} число: ");
    nums[i] = Convert.ToInt32(Console.ReadLine());
}
for (int i = 0; i < nums.Length; i++)
{
for (int j=0; j < nums.Length; j++)
{
 if(nums[i]==nums[j]*nums[j]) Console.WriteLine($"{i+1} число {nums[i]} является квадратом {j+1} числа {nums[j]}");
;
}
}
