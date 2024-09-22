using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation.Extra;

/*
 * Tuliskan spesifikasi soal Anda disini. 
 * Kelas yang dibuat, atribut apa saja yang dibutuhkan, metode apa saja yang dibutuhkan, validasi atau aturan apa yang harus dilakukan.
 */


/*
 * Buatlah Abstract Parent bernama Vehicle yang memiliki atribut brand (string), type (string), engine (string), speed (integer), 
 * price (double), monthProduction (int), dayProduction(int), dan yearProduction(int)
 * 
 * Pastikan setiap atribut merupakan atribut private dan memiliki public property 
 * 
 * pada abstract class juga pastikan terdapat beberapa metode:
 * 1. SpeedPerPrice, adalah metode untuk menunjukkan efisiensi biaya terhadap kecepatan tertinggi dari suatu kendaraan. Format yang ditampilkan yaitu "Efisiensi biaya dari kendaraan terhadap kecepatan yaitu: {value}"
 * 2. DisplayDateProduction, metode untuk menunjukan tanggal produksi terakhir suatu kendaraan dengan format DD/MM/YYYY. Tampilkan value yaitu "Tanggal produksi terakhir kendaraan yaitu : {value}"
 * 3. CheckProduction, metode untuk menunjukkan apakah kendaraan tersebut masih diproduksi atau tidak. Keluarkan dengan format "Kendaraan ini masih diproduksi" atau " Kendaraan ini sudah tidak diproduksi lagi". Lakukan metode ini dengan membandingkan
 * tanggal produksi dengan tanggal 22 September 2024.
 * 4. DisplayInfo, metode untuk menunjukkan semua atribut pada suatu class dengan format string "Kendaraan dengan class {class}, bermerk {brand}, type {type}, memiliki mesin {engine}, yang dapat menghasilkan {speed} km/H. Kendaraan ini diproduksi dengan harga ${price} sampai tanggal {dayProduction}/{monthProduction}/{yearProduction}". Metode ini berupa metode abstract.
 * 5. DisplaySpeed, metode untuk menunjukkan kecepatan kendaraan dengan format "Kecepatan kendaraan: {speed} km/H"
 * 6. Karena harga suatu barang dapat mengalami kenaikan atau penurunan, maka disediakanlah metode untuk mengganti harga dari suatu kendaraan yang disebut dengan "EditPrice". Pengubahan harga dilakukan dengan 
 * memasukkan value int yang dapat negatif ataupun positif yang kemudian ditambahkan ke harga sebelumnya. Jika harga sebelumnya mencapai 0 setelah pengubahan, maka batalkan metode dan keluarkan "Pengubahan harga tidak berhasil karena harga tidak boleh 0, harga sekarang tetap {Price}". Jika berhasil maka keluarkan
 * "Pengubahan harga berhasil, harga sekarang adalah {price}".
 * 
 * 
 * Buatlah 4 Child Class dibawah abstract Vehicle, yakni Plane, Car, Ships, dan Tank. Setiap Classnya harus mengubah kata {class} pada DisplayInfo dengan nama classnya dalam bahasa Indonesia (harus di override).
 * Contoh, "Kendaraan dengan class Pesawat, bermerk {brand}, type {type}, memiliki mesin {engine}, yang dapat menghasilkan {speed} km/H. Kendaraan ini diproduksi dengan harga ${price} sampai tanggal {dayProduction}/{monthProduction}/{yearProduction}". Selain itu setiap 
 * Child Class harus memiliki constructor.
 * 
 * Pastikan semua atribut saat instansiasi ataupun pengubahan atribut tidak bernilai null (untuk string) dan tidak bernilai negatif (untuk numeric)
 * Apabila tidak memenuhi syarat, maka isi dengan "Unknown" untuk string, dan defaultkan ke 1 atau 1.0 untuk numeric
 * 
 * Untuk atribut tanggal, pastikan harus memenuhi syarat. Hari harus sesuai jumlahnya antara 1 sampai 31 berdasarkan bulannya. Bulan harus bernilai antara 1 sampai 12. Tahun harus dicek jika kabisat, maka Februari bisa sampai tanggal 29, jika tidak maka sampai 28 dan harus diatas 1000.
 * Jika terdapat satu value yang tidak valid, maka tanggal diubah menjadi 1/1/1970. Tanggal akhir produksi juga tidak boleh melompati tanggal 22 September 2024.
 * 
 * 
 *

 * 
 */

/*
 * Implementasikan solusi kelas dari soal Anda disini dan eksekusi implementasinya di Program.cs
 */

// Tulis disini

public abstract class Vehicle
{
    private string brand;
    private string type;
    private string engine;
    private int speed;
    private double price;
    private int monthProduction;
    private int dayProduction;
    private int yearProduction;


    public string Brand
    {
        get { return brand; }
        set
        {

            if (string.IsNullOrEmpty(value))
            {
                brand = "Unknown";
            }
            else
            {
                brand = value;
            }

        }
    }

    public string Type
    {
        get { return type; }
        set
        {

            if (string.IsNullOrEmpty(value))
            {
                type = "Unknown";
            }
            else
            {
                type = value;
            }

        }
    }

    public string Engine
    {
        get { return engine; }
        set
        {

            if (string.IsNullOrEmpty(value))
            {
                engine = "Unknown";
            }
            else
            {
                engine = value;
            }

        }
    }


    public int Speed
    {
        get { return speed; }
        set
        {

            if (value < 0)

            {
                speed = 1;
            }
            else
            {
                speed = value;
            }

        }
    }


    public double Price
    {
        get { return price; }
        set
        {

            if (value < 0)
            {
                price = 1.0;
            }
            else
            {
                price = value;
            }

        }
    }
    public int Year
    {
        get
        {
            return yearProduction;
        }

        set
        { 
            if(value < 1000 || value > 2024)
            {
                dayProduction = 1;
                monthProduction = 1;
                yearProduction = 1970;
            }
            else
            {
                yearProduction = value;
            }
            
        }
    }

    public int Month
    {
        get
        {
            return monthProduction;
        }
        set
        {
            if (value < 0 || value > 12)
            {
                dayProduction = 1;
                monthProduction = 1;
                yearProduction = 1970;
            }
            else if(Year == 2024 && value > 9)
            {
                dayProduction = 1;
                monthProduction = 1;
                yearProduction = 1970;
            }
            else
            {
                monthProduction = value;
            }
            
        }
    }

    public int Day
    {
        get { return dayProduction; }
        set {

            if (Year == 2024 && Month == 9 && value > 22)
            {
                dayProduction = 1;
                monthProduction = 1;
                yearProduction = 1970;
            }

            if (value < 0 || value > 31)
            {
                dayProduction = 1;
                monthProduction = 1;
                yearProduction = 1970;
            }
            else
            {
                if (Month != null)
                {
                    if(Month == 2)
                    {
                        if(Year != null)
                        {
                            if (Year % 4 == 0)
                                {
                                if (Year % 100 == 0)
                                {
                                    if(Year % 400 == 0) {
                                        if (value <= 29)
                                        {
                                            dayProduction = value;
                                        }
                                        else
                                        {
                                            dayProduction = 1;
                                            monthProduction = 1;
                                            yearProduction = 1970;
                                        }
                                    }
                                    else
                                    {
                                        dayProduction = 1;
                                        monthProduction = 1;
                                        yearProduction = 1970;
                                    }
                                   
                                }
                                else
                                {
                                    if (value <= 29)
                                    {
                                        dayProduction = value;
                                    }
                                }
                              
                            }
                            else
                            {
                                if (value <= 28)
                                {
                                    dayProduction = value;
                                }
                                else
                                {
                                    dayProduction = 1;
                                    monthProduction = 1;
                                    yearProduction = 1970;
                                }
                            }

                        }
                        else
                        {
                            dayProduction = value;
                        }
                    }else if( Month == 1 || Month == 3 || Month == 5 || Month == 7 || Month == 8 || Month == 10 || Month == 12)
                    {
                        dayProduction = value;
                    }
                    else
                    {
                        if(value > 30)
                        {
                            dayProduction = 1;
                            monthProduction = 1;
                            yearProduction = 1970;
                        }
                        else
                        {
                            dayProduction = value;
                        }
                    }

                }
            }
            

        }
    }

    public void SpeedPerPrice()
    {
        Console.WriteLine($"Efisiensi biaya dari kendaraan terhadap kecepatan yaitu: {speed / price}");
    }
    public void DisplayDateProduction()
    {
        Console.WriteLine($"Tanggal produksi terakhir kendaraan yaitu : {dayProduction}/{monthProduction}/{yearProduction}");
    }
    public void CheckProduction()
    {
        if(Day == 22 && Month == 9 && Year == 2024)
        {
            Console.WriteLine($"Kendaraan ini masih diproduksi");
        }
        else
        {
            Console.WriteLine($"Kendaraan ini sudah tidak diproduksi lagi");
        }
        
    }
    public abstract void DisplayInfo();
    public void DisplaySpeed()
    {
        Console.WriteLine($"Kecepatan kendaraan: {speed} km/H");
    }
    public void EditPrice(double val)
    {
        if(val + Price <= 0)
        {
            Console.WriteLine($"Pengubahan harga tidak berhasil karena harga tidak boleh 0, harga sekarang tetap {Price}");
        }
        else 
        {
            Price += val;
            Console.WriteLine($"Pengubahan harga berhasil, harga sekarang adalah {Price}");

        }
        
    }

}

public class Plane : Vehicle
{
    public Plane(string a, string b, string c,  int h, double d, int e, int f, int g)
    {
        Brand = a;
        Type = b;
        Engine = c;
        Speed = h;
        Price = d;
        Day = e;
        Month = f;
        Year = g;
    }
    public override void DisplayInfo()
    {
        Console.WriteLine($"Kendaraan dengan class Pesawat, bermerk {Brand}, type {Type}, memiliki mesin {Engine}, yang dapat menghasilkan {Speed} km/H. Kendaraan ini diproduksi dengan harga ${Price} sampai tanggal {Day}/{Month}/{Year}");
    }

}

public class Car : Vehicle
{
    public Car(string a, string b, string c, int h, double d, int e, int f, int g)
    {
        Brand = a;
        Type = b;
        Engine = c;
        Speed = h;
        Price = d;
        Day = e;
        Month = f;
        Year = g;
    }
    public override void DisplayInfo()
    {
        Console.WriteLine($"Kendaraan dengan class Mobil, bermerk {Brand}, type {Type}, memiliki mesin {Engine}, yang dapat menghasilkan {Speed} km/H. Kendaraan ini diproduksi dengan harga ${Price} sampai tanggal {Day}/{Month}/{Year}");
    }

}

public class Ships : Vehicle
{
    public Ships(string a, string b, string c, int h, double d, int e, int f, int g)
    {
        Brand = a;
        Type = b;
        Engine = c;
        Speed = h;
        Price = d;
        Day = e;
        Month = f;
        Year = g;
    }
    public override void DisplayInfo()
    {
        Console.WriteLine($"Kendaraan dengan class Kapal, bermerk {Brand}, type {Type}, memiliki mesin {Engine}, yang dapat menghasilkan {Speed} km / H. Kendaraan ini diproduksi dengan harga ${Price} sampai tanggal {Day}/{Month}/{Year}");
    }

}

public class Tank : Vehicle
{
    public Tank(string a, string b, string c, int h, double d, int e, int f, int g)
    {
        Brand = a;
        Type = b;
        Engine = c;
        Speed = h;
        Price = d;
        Day = e;
        Month = f;
        Year = g;
    }
    public override void DisplayInfo()
    {
        Console.WriteLine($"Kendaraan dengan class Tank, bermerk {Brand}, type {Type}, memiliki mesin {Engine}, yang dapat menghasilkan {Speed} km / H. Kendaraan ini diproduksi dengan harga ${Price} sampai tanggal {Day}/{Month}/{Year}");
    }

}


