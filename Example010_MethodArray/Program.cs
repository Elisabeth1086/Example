int[] array = {11, 21, 35, 46, 85, 63, 77, 28, 45555};

int n=array.Length;
int find=77;

int index=0;

while(index<n)
{
    if(array[index]==find)
    {
        System.Console.WriteLine(index);
    }
    index++;
}