using System.Text;

internal class Program
{
    static void NhapVaInChuoi()
    {
        Console.Write("Nhap chuoi: ");

        string s = Console.ReadLine()!;

        Console.WriteLine($"Chuoi vua nhap la: {s}");
    }

    static int ChieuDaiChuoi(string s)
    {
        int length = 0;

        foreach (char c in s)
        {
            length++;
        }
        return length;
    }

    static void TachKTDB(string s)
    {
        foreach (char c in s)
        {
            Console.Write(c + " ");
        }
    }

    static void InDaoNguoc(string s)
    {
        for (int i = s.Length - 1; i >= 0; i--)
        {
            Console.Write(s[i] + " ");
        }
    }

    static int DemSoTu(string s)
    {
        if (string.IsNullOrEmpty(s))
        {
            return 0;
        }
        int dem = 0;

        bool isWord = false;

        foreach (char c in s)
        {
            if (char.IsWhiteSpace(c)) 
            {
                isWord = false;

            } else if (!isWord)
            {
                dem++;
                isWord = true;
            }
        }
        return dem;
    }

    static bool SoSanhHaiChuoi(string a, string b)
    {
        int lenA = a.Length;

        int lenB = b.Length;

        if (lenA != lenB) return false;

        for (int i = 0; i < a.Length; i++)
        {
            if (a[i] != b[i])
            {
                return false;
            }
        }
        return true;
    }

    static void DemChu_So_KTDB(string s)
    {
        int ChuCai = 0, So = 0, KTDB = 0;

        foreach (char c in s)
        {
            if (char.IsDigit(c))
            {
                So++;
            } else if (char.IsLetter(c))
            {
                ChuCai++;

            } else
            {
                KTDB++;
            }
        }
        Console.WriteLine($"So luong chu cai: {ChuCai}");

        Console.WriteLine($"So luong chu so: {So}");

        Console.WriteLine($"So luong ki tu dac biet: {KTDB}");
    }

    static void DemNguyenAm_PhuAm(string s)
    {
        s.ToLower();

        int DemNguyenAm = 0, DemPhuAm = 0;

        string NguyenAm = "aoeui";

        foreach (char c in s)
        {
            if (char.IsLetter(c))
            {
                if (NguyenAm.Contains(c))
                {
                    DemNguyenAm++;
                } else
                {
                    DemPhuAm++;
                }
            }
        }
        Console.WriteLine($"So luong nguyen am: {DemNguyenAm}");

        Console.WriteLine($"So luong phu am: {DemPhuAm}");
    }

    static bool KiemTraChuoiCon(string s, string s1)
    {
        return s.Contains(s1);
    }

    static int TimViTriChuoiCon(string s, string s1)
    {
        return s.IndexOf(s1);
    }
    static void KiemTraKiTu(char c)
    {
        if (char.IsLetter(c))
        {
            if (char.IsUpper(c))
            {
                Console.WriteLine($"'{c}' là chữ IN HOA.");
            } else
            {
                Console.WriteLine($"'{c}' là chữ in thường.");
            }
        } else
        {
            Console.WriteLine($"'{c}' KHÔNG phải chữ cái.");
        }
    }

    static int TimSoLanXuatHienChuoiCon(string s, string s1)
    {
        if (string.IsNullOrEmpty(s1)) return 0;

        int dem = 0, vitri = 0;

        while ((vitri = s.IndexOf(s1, vitri)) != -1)
        {
            dem++;

            vitri += s1.Length;
        }
        return dem;
    }

    static string ChenChuoiCon(string s, string s1, string s2)
    {
        int pos = s.IndexOf(s1);

        if (pos != -1)
        {
            return s.Insert(pos, s2);
        }
        return s;
    }
    private static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.UTF8;

        Console.Write("Nhap chuoi: ");

        string s = Console.ReadLine()!;

        Console.WriteLine($"Chieu dai: {ChieuDaiChuoi(s)}");

        Console.Write("Tach ki tu rieng biet: ");

        TachKTDB(s);

        Console.WriteLine();

        Console.Write("In dao nguoc: ");

        InDaoNguoc(s);

        Console.WriteLine();

        Console.WriteLine($"Tong so tu trong chuoi: {DemSoTu(s)}");

        Console.Write("Nhap chuoi thu nhat (de so sanh): ");

        string a = Console.ReadLine()!;

        Console.Write("Nhap chuoi thu hai (de so sanh): ");

        string b = Console.ReadLine()!;

        if (SoSanhHaiChuoi(a, b))
        {
            Console.WriteLine($"Chuoi '{a}' = Chuoi '{b}'");
        }
        else
        {
            Console.WriteLine($"Chuoi '{a}' khac Chuoi '{b}'");
        }

        DemChu_So_KTDB(s);

        DemNguyenAm_PhuAm(s);

        Console.Write("Nhap chuoi con muon kiem tra (s1): ");

        string s1 = Console.ReadLine()!;

        if (KiemTraChuoiCon(s, s1))
        {
            Console.WriteLine($"'{s1}' la con cua '{s}'");

            Console.WriteLine($"Vi tri xuat hien dau tien cua chuoi con '{s1}': {TimViTriChuoiCon(s, s1)}");

            Console.WriteLine($"So lan xuat hien cua '{s1}' trong chuoi goc: {TimSoLanXuatHienChuoiCon(s, s1)}");

            Console.Write($"Nhap chuoi muon chen vao truoc '{s1}' (s2): ");

            string s2 = Console.ReadLine()!;

            Console.WriteLine($"Chuoi sau khi chen: {ChenChuoiCon(s, s1, s2)}");
        }
        else
        {
            Console.WriteLine($"'{s1}' khong la con cua '{s}'");
        }

        Console.Write("Nhap ki tu can kiem tra in Hoa/Thuong: ");

        char c = char.Parse(Console.ReadLine()!);

        KiemTraKiTu(c);

        Console.WriteLine();
    }
}