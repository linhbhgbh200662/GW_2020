using System;
using System.Collections.Generic;

namespace BaiTapQLSV
{
    class SinhVien
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Dateofbirth { get; set; }
        public string Class { get; set; }
        public double DiemToan { get; set; }
        public double DiemLy { get; set; }
        public double DiemHoa { get; set; }
        public double DiemTB { get; set; }
        public string HocLuc { get; set; }
    }
    class QuanLySinhVien
    {
        List<SinhVien> ListSinhVien = new List<SinhVien>();
        
        //private List<SinhVien> ListSinhVien = null;
        //public QuanLySinhVien()
        //{
        //    ListSinhVien = new List<SinhVien>();
        //}

        public void NhapSinhVien()
        {
            SinhVien sv = new SinhVien();
            Console.Write("ID: ");
            sv.ID = Convert.ToInt32(Console.ReadLine());

            Console.Write("Name: ");
            sv.Name = Convert.ToString(Console.ReadLine());

            Console.Write("Gender: ");
            sv.Gender = Convert.ToString(Console.ReadLine());

            Console.Write("Date of birth: ");
            sv.Dateofbirth = Convert.ToString(Console.ReadLine());

            Console.Write("Class: ");
            sv.Class = Convert.ToString(Console.ReadLine());

            Console.Write("Diem toan: ");
            sv.DiemToan = Convert.ToDouble(Console.ReadLine());

            Console.Write("Diem ly: ");
            sv.DiemLy = Convert.ToDouble(Console.ReadLine());

            Console.Write("Diem hoa: ");
            sv.DiemHoa = Convert.ToDouble(Console.ReadLine());

            TinhDTB(sv);
            XepLoaiHocLuc(sv);

            ListSinhVien.Add(sv);
        }
        //ham sap xep sinh vien theo DTB tang dan
        public void SortByDiemTB()
        {
            ListSinhVien.Sort((x,y) => y.DiemTB.CompareTo(x.DiemTB));
            ListSinhVien.Sort((x, y) => x.DiemTB.CompareTo(y.DiemTB));
        }
        // ham tính DTB cho SV
        private void TinhDTB(SinhVien sv)
        {
            double DiemTB = (sv.DiemToan + sv.DiemLy + sv.DiemHoa) / 3;
            sv.DiemTB = Math.Round(DiemTB, 2, MidpointRounding.AwayFromZero);
        }
        //ham xep loai hoc luc cho SV
        private void XepLoaiHocLuc(SinhVien sv)
        {
            if (sv.DiemTB >= 8)
            {
                sv.HocLuc = "Gioi";
            }
            else if (sv.DiemTB >= 6.5)
            {
                sv.HocLuc = "Kha";
            }
            else if (sv.DiemTB >= 5)
            {
                sv.HocLuc = "Trung Binh";
            }
            else
            {
                sv.HocLuc = "Yeu";
            }
        }

        public SinhVien FindByID(int ID)
        {
            SinhVien searchResult = null;
            if (ListSinhVien != null && ListSinhVien.Count > 0)
            {
                foreach (SinhVien sv in ListSinhVien)
                {
                    if (sv.ID == ID)
                    {
                        searchResult = sv;
                    }
                }
            }
            return searchResult;
        }
        //ham xoa sinh vien theo ID
        public bool DeleteById(int ID)
        {
            bool IsDeleted = false;
            // tìm kiếm sinh viên theo ID
            SinhVien sv = FindByID(ID);
            if (sv != null)
            {
                IsDeleted = ListSinhVien.Remove(sv);
            }
            return IsDeleted;
        }
        //sap xep 
        public void SortByName()
        {
            ListSinhVien.Sort(delegate (SinhVien sv1, SinhVien sv2)
            {
                return sv1.Name.CompareTo(sv2.Name);
            });
        }


        /**
         * Hàm hiển thị danh sách sinh viên ra màn hình console
         */
        public void ShowSinhVien(List<SinhVien> listSV)
        {
            // hien thi tieu de cot
            Console.WriteLine("{0, -5} {1, -10} {2, 5} {3, 10} {4, 10} {5, 5} {6, 5} {7, 5} {8, 10} {9, 10}",
                  "ID", "Name", "Gender", "Dateofbirth", "Class", "Toan", "Ly", "Hoa", "Diem TB", "Hoc Luc");
            // hien thi danh sach sinh vien
            if (listSV != null && listSV.Count > 0)
            {
                foreach (SinhVien sv in listSV)
                {
                    Console.WriteLine("{0, -5} {1, -10} {2, 5} {3, 10} {4, 10} {5, 5} {6, 5} {7, 5} {8, 10} {9, 10}",
                                      sv.ID, sv.Name, sv.Gender, sv.Dateofbirth,sv.Class, sv.DiemToan, sv.DiemLy, sv.DiemHoa,
                                      sv.DiemTB, sv.HocLuc);
                }
            }
            Console.WriteLine();
        }
        //ham tra ve danh sach SV hien tai
        public List<SinhVien> getListSinhVien()
        {
            return ListSinhVien;
        }

        public int SoLuongSinhVien()
        {
            int Count = 0;
            if (ListSinhVien != null)
            {
                Count = ListSinhVien.Count;
            }
            return Count;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            QuanLySinhVien quanLySinhVien = new QuanLySinhVien();

            while (true)
            { 
                Console.WriteLine("\n         CHUONG TRINH QUAN LY SINH VIEN            \n");
                Console.WriteLine("*************************MENU**************************");
                Console.WriteLine("**  1. Them sinh vien.                               **");
                Console.WriteLine("**  2. Xoa sinh vien theo ID.                        **");
                Console.WriteLine("**  3. Sap xep sinh vien theo ten.                   **");
                Console.WriteLine("**  4. Sap xep sinh vien theo diem trung binh.       **");
                Console.WriteLine("**  5. Hien thi danh sach sinh vien                  **");
                Console.WriteLine("**  0. Thoat                                         **");
                Console.WriteLine("*******************************************************");
                Console.Write("\n Nhap tuy chon: ");
                int key = Convert.ToInt32(Console.ReadLine());
                switch (key)
                {
                    case 1:
                        Console.WriteLine("\n1. Them sinh vien.");
                        quanLySinhVien.NhapSinhVien();
                        Console.WriteLine("\nThem sinh vien thanh cong!");
                        break;

                    case 2:
                        if (quanLySinhVien.SoLuongSinhVien() > 0)
                        {
                            int id;
                            Console.WriteLine("\n2. Xoa sinh vien.");
                            Console.Write("\nID: ");
                            id = Convert.ToInt32(Console.ReadLine());
                            if (quanLySinhVien.DeleteById(id))
                            {
                                Console.WriteLine("\nSinh vien co id = {0} da bi xoa.", id);
                            }
                        }
                        else
                        {
                            Console.WriteLine("\nDanh sach sinh vien trong!");
                        }
                        break;

                    case 3:
                        if (quanLySinhVien.SoLuongSinhVien() > 0)
                        {
                            Console.WriteLine("\n3. Sap xep sinh vien theo ten.");
                            quanLySinhVien.SortByName();
                            quanLySinhVien.ShowSinhVien(quanLySinhVien.getListSinhVien());
                        }
                        else
                        {
                            Console.WriteLine("\nDanh sach sinh vien trong!");
                        }
                        break;

                    case 4:
                        if (quanLySinhVien.SoLuongSinhVien() > 0)
                        {
                            Console.WriteLine("\n4. Sap xep sinh vien theo diem trung binh.");
                            quanLySinhVien.SortByDiemTB();
                            quanLySinhVien.ShowSinhVien(quanLySinhVien.getListSinhVien());
                        }
                        else
                        {
                            Console.WriteLine("\nDanh sach sinh vien trong!");
                        }
                        break;

                    case 5:
                        if (quanLySinhVien.SoLuongSinhVien() > 0)
                        {
                            Console.WriteLine("\n5. Hien thi danh sach sinh vien.");
                            quanLySinhVien.ShowSinhVien(quanLySinhVien.getListSinhVien());
                        }
                        else
                        {
                            Console.WriteLine("\nDanh sach sinh vien trong!");
                        }
                        break;

                    case 0:
                        Console.WriteLine("\nBan da chon thoat chuong trinh!");
                        return;
                    default:
                        Console.WriteLine("\nKhong co chuc nang nay!");
                        Console.WriteLine("\nHay chon chuc nang trong menu.");
                        break;
                }
            }
        }
    }
}