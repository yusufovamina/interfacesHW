Array myArray = new Array(new int[]{ 11, 32, 23, 74, 5 });
#region task1
myArray.Show();
myArray.Show("It is myArray");
Console.WriteLine();
#endregion

#region task2
Console.WriteLine("Max: " + myArray.Max());
Console.WriteLine("Min: " + myArray.Min());
Console.WriteLine("Average: " + myArray.Avg());

int valueToSearch = 5;
if (myArray.Search(valueToSearch))
{
    Console.WriteLine($"{valueToSearch} is in array");
}
else
{
    Console.WriteLine($" {valueToSearch} is not in array");
}
#endregion
Console.WriteLine();
#region task3
Console.WriteLine("Ascending:");
myArray.SortAsc();
myArray.Show();

Console.WriteLine("Descending:");
myArray.SortDesc();
myArray.Show();

Console.WriteLine("Parameter:");
myArray.SortByParam(true);
myArray.Show();

#endregion