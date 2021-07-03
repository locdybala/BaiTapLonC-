using QLCHBS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCHBS.Controller
{
    class managerKhoSach
    {
        public managerKhoSach()
        {
            listKho = new List<KhoSach>();
        }

        public int timkiem(string tensach)
        {
            int tk = 0;
            for (int i = 0; i < listKho.Count; i++)
            {
                if (listKho[i].tenSach == tensach)
                {
                    tk = listKho[i].tonKho;
                }
            }
            return tk;
        }
        public void addKho(KhoSach khoSach)
        {
            listKho.Add(khoSach);
        }
        //hay nó ko gọi đc đến csdl đang ko cập nhập ý


        public void editKho(KhoSach ks)
        {
            for (int i = 0; i < listKho.Count; i++)
            {
                if (listKho[i].tenSach.Equals(ks.tenSach))
                {

                    listKho[i].soLuongBan = ks.soLuongBan;
                    listKho[i].tonKho = listKho[i].soLuongNhap - ks.soLuongBan;

                }
            }
        }
        public List<KhoSach> listKho { get; set; }
    }
}
