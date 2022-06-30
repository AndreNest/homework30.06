void fifthnuber(int x)
{
    //int numb = Convert.ToInt32(Console.ReadLine());
    int numb = x;
    int numb1 = numb / 10000;
    int numb2 = numb % 10000 / 1000;
    int numb4 = numb % 10000 % 100 /10;
    int numb5 = numb % 10;
    if(numb1 == numb5 && numb2 == numb4)
    {
        Console.Write(numb +" - this numbers is a polydrome");
    }
    else
    {
        Console.Write(numb +" - this numbers is not a polydrome");
    }

}

fifthnuber(12321);