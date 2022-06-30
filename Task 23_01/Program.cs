// задача №3
Console.WriteLine("Введите число N: ");
int numb = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("============================================");
Console.WriteLine("Все числа от 1 до "+ numb + ", возведенные в куб.");

int [] A = new int[numb];
int i = 1;
while(i <= numb)
{
     A[i-1] = i * i * i;
     Console.Write(A[i-1]+ " ");
     i++;
     
}

