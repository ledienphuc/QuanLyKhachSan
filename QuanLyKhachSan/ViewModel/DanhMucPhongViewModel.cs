using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using QuanLyKhachSan.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace QuanLyKhachSan.ViewModel
{
    class DanhMucPhongViewModel : ViewModelBase
    {
        public ObservableCollection<Phong> DanhMucPhong { get; set; }

        public DanhMucPhongViewModel()
        {
            DanhMucPhong = new ObservableCollection<Phong>
            {
                new Phong{Ten="Phong1", LoaiPhong="A", DonGia = 150000},
                new Phong{Ten="Phong2", LoaiPhong="B", DonGia = 170000},
                new Phong{Ten="Phong3", LoaiPhong="C", DonGia = 200000}
            };

            ThemPhongCommand = new RelayCommand(ThemPhong);
        }


        private void ThemPhong()
        {
            DanhMucPhong.Add(new Phong { Ten = "PhongX", LoaiPhong = "A", DonGia = 150000 });
        }
        public ICommand ThemPhongCommand { get; set; } 

    }
}
