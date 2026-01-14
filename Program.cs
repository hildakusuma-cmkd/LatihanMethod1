static void tambah (int a, int b)
{
    int c = 0; 

    c = a + b;
    Console.WriteLine($"{a} + {b} = {c}"); 
}

static void kurang (int a, int b)
{
    int c = 0; 

    c = a - b;
    Console.WriteLine($"{a} - {b} = {c}"); 
}

static void kali (int a, int b)
{ 
    int c = 0;

    c = a * b;
    Console.WriteLine($"{a} * {b} = {c}"); 
}

static void bagi (int a, int b)
{ 
    int c = 0;

    c = a / b;
    Console.WriteLine($"{a} / {b} = {c}"); 
}

tambah(10, 2);
kurang(8, 3); 
kali(9, 4);
bagi(12, 1);