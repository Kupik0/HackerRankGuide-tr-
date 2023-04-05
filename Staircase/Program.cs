int n = Int16.Parse( Console.ReadLine());


 static void staircase(int n)
{
    int bosluksayisi = n - 1; //boşluklarda dolu bir satır olmadığı için en üst satır n-1den başlıyor
    int karesayisi = 1;  //en üst satırda en az 1 tane kare var

    for(int i = 0; i < n; i++)
    {
        Console.WriteLine(new string (' ', bosluksayisi) + new string('#' , karesayisi)); //her satırı yazdırıyoruz
        bosluksayisi--; //bosluk sayısını azaltıyor merdiven efekti için
        karesayisi++; // kare sayısını arttırıyoruz merdiven efekti için

        
    }
}
staircase(n);