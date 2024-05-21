namespace DoAnCDIO2_Genuine_Cosmetic.ViewModels
{
    public class HangHoaVM
    {
        public int  MaHh { get; set; }
        public string TenHh { get; set; }
        public string HangSx { get; set; }
        public double DonGia { get; set; }
        public string Hinh { get; set; }
        public string TenLoai { get; set; }

        public double GiamGia { get; set; }
        public double GiaSauGiam => DonGia * (1 - GiamGia / 100.0);
    }
    public class ChiTietHangHoaVM
    {
        public int MaHh { get; set; }
        public string TenHh { get; set; }
        public string HangSx { get; set; }
        public double DonGia { get; set; }
        public string Hinh { get; set; }
        public string TenLoai { get; set; }
        public string ChiTiet { get; set; }
        public int DiemDanhGia { get; set; }
        public int SoLuongTon { get; set; }
        public double GiamGia { get; set; }
        public double GiaSauGiam => DonGia * (1 - GiamGia / 100.0);

    }

    public class ConveyorVM
    {
        public int MaHh { get; set; }
        public string TenHh { get; set; }
        public string HangSx { get; set; }
        public double DonGia { get; set; }
        public string Hinh { get; set; }
        public string TenLoai { get; set; }
        public double GiamGia { get; set; }
    }

    public class ConveyorVM1
    {
        public int MaHh { get; set; }
        public string TenHh { get; set; }
        public string HangSx { get; set; }
        public double DonGia { get; set; }
        public string Hinh { get; set; }
        public string TenLoai { get; set; }
        public double GiamGia { get; set; }
    }

    public class SaleVM
    {
        public int MaHh { get; set; }
        public string TenHh { get; set; }
        public string HangSx { get; set; }
        public double DonGia { get; set; }
        public string Hinh { get; set; }
        public string TenLoai { get; set; }

        public double GiamGia { get; set; }
        public double GiaSauGiam => DonGia * (1 - GiamGia / 100.0);

    }


}
