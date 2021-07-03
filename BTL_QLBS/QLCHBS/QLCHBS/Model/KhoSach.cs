using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCHBS.Model
{
    class KhoSach
    {
        public KhoSach(string tenSach, int soLuongNhap)
        {
            this.tenSach = tenSach;
            this.soLuongNhap = soLuongNhap;
            this.soLuongBan = 0;
            this.tonKho = soLuongNhap - soLuongBan;
        }
        public KhoSach(string tenSach, int soLuongNhap, int soLuongBan)
        {
            this.tenSach = tenSach;
            this.soLuongNhap = soLuongNhap;
            this.soLuongBan = soLuongBan;
            this.tonKho = soLuongNhap - soLuongBan;
        }



        public string tenSach { get; set; }
        public int soLuongNhap { get; set; }
        public int soLuongBan { get; set; }
        public int tonKho { get; set; }
    }
}
