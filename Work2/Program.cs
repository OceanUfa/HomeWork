Console.Clear();
int Prompt(string message)
{
  Console.Write(message);
  int result = Convert.ToInt32(Console.ReadLine());
  return result;
}

int SumOfElements(int m, int n)
{
  if (m == n) return n;
  else return SumOfElements(m + 1, n) + m;
}

int m = Prompt("Input M: ");
int n = Prompt("Input N: ");

Console.WriteLine(SumOfElements(m, n));