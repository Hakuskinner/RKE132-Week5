﻿int math, biology, chemistry;
Console.WriteLine("Enter your math results");
math = Int32.Parse(Console.ReadLine());

Console.WriteLine("Enter your biology results");
biology = Int32.Parse(Console.ReadLine());

Console.WriteLine("Enter your chemistry results");
chemistry = Int32.Parse(Console.ReadLine());

if(math >= 90 && biology >= 90 && chemistry >= 90)
{
    Console.WriteLine("Congratulation! You got accepted.");
}
else
    {
    Console.WriteLine("Your application is not approved.");
}