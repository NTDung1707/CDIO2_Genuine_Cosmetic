namespace DoAnCDIO2_Genuine_Cosmetic.ViewModels
{
    public class CartItem
    {
        public int MaHh { get; set; }
        public string TenHh { get; set; }
        public double DonGia { get; set; }
        public double GiamGia { get; set; }
        public string Hinh { get; set; }
        public int soluong { get; set; }

        public double GiaSauGiam => DonGia * (1 - GiamGia / 100.0);

        public double ThanhTien => soluong * GiaSauGiam ; 
    }
}
