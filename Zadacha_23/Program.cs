Console.WriteLine("Введите число ");
int num = Convert.ToInt32(Console.ReadLine());
void Cube(int[] num)
{
  int count = 0;
  int length = num.Length;
  while (count <  length)
  {
    num[count] = Convert.ToInt32(Math.Pow(count, 3));
    count++;
  }
}

void PrintArray(int[] coll)
{
  int count = coll.Length;
  int index = 1;
  while(index < count)
  {
    Console.Write(coll[index]+ " ");
    index++;
  }
} 
int[] array = new int[num+1];
Cube(array);
PrintArray(array);