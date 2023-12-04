int[] grades = new int[365];
List<string> dayofweeks = new List<string>(7);
dayofweeks.Add("poniedziałek");
dayofweeks.Add("wtorek");
dayofweeks.Add("sroda");
dayofweeks.Add("czwartek");
dayofweeks.Add("piatek");
dayofweeks.Add("sobota");
dayofweeks.Add("niedziela");


/*for (int i = 0; i < dayofweeks.Count; i=i+2)
{
    Console.WriteLine(dayofweeks[i]);
}*/
foreach (var day in dayofweeks)
{
    Console.WriteLine(day);
}
int number = 4594;
string numberAsString = number.ToString();
char[] letters = numberAsString.ToArray();
int[] c = new int[10];
for (int i = 0; i < c.Length; i++)
{
    c[i] = 0;
}
foreach (char letter in letters)
{
    if (letter == '0')
    { c[0]++; }
    else if (letter == '1')
    { c[1]++; }
    else if (letter == '2')
    { c[2]++; }
    else if (letter == '3')
    { c[3]++; }
    else if (letter == '4')
    { c[4]++; }
    else if (letter == '5')
    { c[5]++; }
    else if (letter == '6')
    { c[6]++; }
    else if (letter == '7')
    { c[7]++; }
    else if (letter == '8')
    { c[8]++; }
    else if (letter == '9')
    { c[9]++; }
}

/// for (int i = 0; i < c.length; i++)
/*List<int> list = new List<int>(10);
list.Add(c0);
list.Add(c1);
list.Add(c2);
list.Add(c3);
list.Add(c4);
list.Add(c5);
list.Add(c6);
list.Add(c7);
list.Add(c8);
list.Add(c9);
*/
for (int i = 0; i < c.Length; i++)
{
    Console.WriteLine("liczba " + i + "występuje" + c[i] + "razy");
}