void Towers(string from = "1", string on = "3", string some = "2", int count = 3)
{
    if (count > 1) Towers(from, some, on, count - 1);
    Console.WriteLine($"{from} >> {on}");
    if (count > 1) Towers(some, on, from, count - 1);
}


Towers();