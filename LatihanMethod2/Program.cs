int jumlahItem;

decimal hargaItem, diskon, totalBayar;

static decimal hitungDiskon(int jml_item)
{
    if (jml_item== 5) return 50000m;
    else if (jml_item == 10) return 75000m;
    else return 0;
}

static decimal hitungTotal(int jml_item, decimal hargaItem, decimal diskon)
{
    return jml_item * hargaItem + diskon;
}




Console.WriteLine("Massukan jumlah Item:");
jumlahItem = int.Parse(Console.ReadLine());

Console.WriteLine("Massukan harga per Item: Rp");
hargaItem = decimal.Parse(Console.ReadLine());

diskon = hitungDiskon(jumlahItem);

totalBayar = hitungTotal(jumlahItem, hargaItem, diskon);

Console.WriteLine($"Total yang harus dibayar adalah Rp{totalBayar}");