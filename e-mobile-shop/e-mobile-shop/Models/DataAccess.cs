﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace e_mobile_shop.Models
{
    public class DataAccess
    {
       
        public static int soCtdh = 0;
        public static ClientDbContext context = new ClientDbContext();
        public static List<AspNetUsers> ViewSanPham()
        {
            return context.AspNetUsers.ToList();

        }
        public static List<LoaiSp> ReadLoaiSp()
        {
            List<LoaiSp> result = new List<LoaiSp>();


            foreach (var item in context.LoaiSp.ToList())
            {
                if (item.TenLoai != "Phụ Kiện")
                {
                    result.Add(item);
                }
            }
            return result;
        }
   

    


        public static List<SanPham> ReadSanPham(string loaiSp)  
        {
            return context.SanPham.Where(x => x.LoaiSp == loaiSp).ToList();

        }

        public static List<ThongSo> ReadThongSo(string loaiSp)
        {

            return context.ThongSo.Where(x => x.MaLoai == loaiSp).ToList();


        }
        public static List<ThongSoKiThuat> ReadThongSoKiThuat(string ma)
        {

            return context.ThongSoKiThuat.Where(x => x.MaSp == ma).ToList();


        }
        public static string GetTenTSKT(string masp, string mats)
        {
            ThongSoKiThuat temp = context.ThongSoKiThuat.Where(x => x.MaSp == masp && x.ThongSo == mats).FirstOrDefault();
            if (temp != null)
                return temp.GiaTri;
            else
                return "";
        }
        public static string GetLoaiSp(string loaiSP)
        {

            return context.LoaiSp.Find(loaiSP).TenLoai;
        }
        public static List<NhaSanXuat> GetNSX()
        {
            return context.NhaSanXuat.ToList();
        }
        public static SanPham GetSanPham(string Id)
        {
            return context.SanPham.Find(Id);
        }

        public static List<ThongSoKiThuat> GetThongSoKiThuat(string maSp)
        {
            return context.ThongSoKiThuat.Where(x => x.MaSp == maSp).ToList();
        }
        public static List<string> getGiaTriThongSoKiThuat(List<ThongSoKiThuat> lst)
        {
            List<string> result = new List<string>();
            foreach (var item in lst)
            {
                result.Add(item.GiaTri.ToLower());
            }
            return result;
        }
        public static AnhSanPham GetAnhSanPham(string maSp)
        {
            return context.AnhSanPham.Where(x => x.MaSp == maSp).SingleOrDefault();
        }

        public static DonHang GetDonHang(string maDh)
        {
            return context.DonHang.Find(maDh);
        }
        public static AspNetUsers GetUser(string userId)
        {
            return context.AspNetUsers.Find(userId);
        }

        public static IQueryable<SanPham> FilterLaptopByRam(IQueryable<SanPham> sanphams, string _ramString)
        {

            var _filter_ = new List<IQueryable<SanPham>>();

            foreach (var _ramValue in _ramString.Split('-'))
            {
                if (!String.IsNullOrEmpty(_ramValue))
                {
                    var _sanphams = from s in sanphams
                                    join t in context.ThongSoKiThuat
                                    on s.MaSp equals t.MaSp
                                    where t.GiaTri.ToLower().Contains(_ramValue.ToLower()) && t.ThongSo == "TS0048" && s.LoaiSp == "LSP0008"
                                    select s;
                    _filter_.Add(_sanphams);
                }
            }
            _filter_.ToList().ForEach(item => _filter_[0] = _filter_[0].Intersect(item));
            var result = sanphams.Intersect(_filter_[0]);
            return result;
        }

        public static IQueryable<SanPham> FilterLaptopByCpu(IQueryable<SanPham> sanphams, string _cpuString)
        {
            var _filter_ = new List<IQueryable<SanPham>>();

            foreach (var _cpuValue in _cpuString.Split('-'))
            {
                if (!String.IsNullOrEmpty(_cpuValue))
                {
                    var _sanphams = from s in sanphams
                                    join t in context.ThongSoKiThuat
                                    on s.MaSp equals t.MaSp
                                    where t.GiaTri.ToLower().Contains(_cpuValue.ToLower()) && t.ThongSo.Contains("TS0046") && s.LoaiSp.Contains("LSP0008")
                                    select s;
                    _filter_.Add(_sanphams);
                }
            }
            _filter_.ToList().ForEach(item => _filter_[0] = _filter_[0].Intersect(item));
            return sanphams.Intersect(_filter_[0]);
        }

        public static IQueryable<SanPham> FilterSanphamBySpecialFeature(IQueryable<SanPham> sanphams, string _featureString)
        {
            var _filter_ = new List<IQueryable<SanPham>>();

            foreach (var _featureValue in _featureString.Split('-'))
            {
                if (!String.IsNullOrEmpty(_featureValue))
                {
                    var _sanphams = from s in sanphams
                                    join t in context.ThongSoKiThuat
                                    on s.MaSp equals t.MaSp
                                    where t.GiaTri.ToLower().Contains(_featureValue.ToLower()) && s.LoaiSp.Contains("LSP0008")
                                    select s;
                    _filter_.Add(_sanphams);
                }
            }
            _filter_.ToList().ForEach(item => _filter_[0] = _filter_[0].Union(item));
            return sanphams.Intersect(_filter_[0]);
        }

        public static IQueryable<SanPham> FilterLaptopByRequire(IQueryable<SanPham> sanphams, string _requireString)
        {
            var _filter_ = new List<IQueryable<SanPham>>();

            foreach (var _requireValue in _requireString.Split('-'))
            {
                 if (!String.IsNullOrEmpty(_requireValue))
                    {
                        if (_requireValue == "type_1") //học tập
                        {
                            var s1 = FilterLaptopByRam(sanphams, "4GB");
                            var s2 = FilterLaptopByCpu(sanphams, "i3");

                            _filter_.Add(s1);
                            _filter_.Add(s2);
                        }
                        else if (_requireValue.Contains("type_2")) //đồ họa 
                        {
                            var s1 = from s in context.SanPham where s.TenSp.ToLower().Contains("macbook") select s;
                            var s2 = FilterLaptopByCpu(sanphams, "i5");
                            var s3 = FilterLaptopByRam(sanphams, "8gb");
                            _filter_.Add(s1);
                            _filter_.Add(s2);
                            _filter_.Add(s3);
                        }
                        else if (_requireValue == "type_3") //văn phòng 
                        {
                            var s1 = from s in context.SanPham where s.TenSp.ToLower().Contains("macbook") select s;
                            var s2 = FilterLaptopByCpu(sanphams, "i3");
                            var s3 = FilterLaptopByRam(sanphams, "4gb");
                            _filter_.Add(s1);
                            _filter_.Add(s2);
                            _filter_.Add(s3);
                        }
                    }

            }

            _filter_.ToList().ForEach(item => _filter_[0] = _filter_[0].Union(item));
            return sanphams.Intersect(_filter_[0]);

        }

        public static IQueryable<SanPham> FilterPhoneByOs(IQueryable<SanPham> sanphams, string _osString)
        {
            var _filter_ = new List<IQueryable<SanPham>>();

            foreach (var _osValue in _osString.Split('-'))
            {
                if (!String.IsNullOrEmpty(_osValue))
                {
                    var _sanphams = from s in sanphams
                                    join t in context.ThongSoKiThuat
                                    on s.MaSp equals t.MaSp
                                    where t.GiaTri.ToLower().Contains(_osValue.ToLower()) && t.ThongSo.Contains("TS0008") && s.LoaiSp.Contains("LSP0002")
                                    select s;
                    _filter_.Add(_sanphams);
                }
            }
            _filter_.ToList().ForEach(item => _filter_[0] = _filter_[0].Intersect(item));
            return sanphams.Intersect(_filter_[0]);
        }

        public static IQueryable<SanPham> FilterPhoneByBattery(IQueryable<SanPham> sanphams, string _batteryString)
        {
            var _filter_ = new List<IQueryable<SanPham>>();

            foreach (var _batteryValue in _batteryString.Split('-'))
            {
                if (!String.IsNullOrEmpty(_batteryValue))
                {
                    switch(_batteryValue)
                    {
                        case "small":
                            {
                                var a1 = from s in DataAccess.context.SanPham
                                         join t in DataAccess.context.ThongSoKiThuat
                                          on s.MaSp equals t.MaSp
                                         where (Convert.ToInt32(t.GiaTri.Substring(0, 4)) < 4000 && t.ThongSo.Contains("TS0018") &&s.LoaiSp.Contains("LSP0002"))
                                         select s;
                                _filter_.Add(a1);
                                break;
                            }
                        case "big":
                            {
                                var a1 = from s in DataAccess.context.SanPham
                                         join t in DataAccess.context.ThongSoKiThuat
                                          on s.MaSp equals t.MaSp
                                         where (4000 <= Convert.ToInt32(t.GiaTri.ToLower().Substring(0, 4)) &&
                                         Convert.ToInt32(t.GiaTri.ToLower().Substring(0, 4)) <= 5000 &&
                                         t.ThongSo.Contains("TS0018") && s.LoaiSp.Contains("LSP0002"))
                                         select s;
                                _filter_.Add(a1);
                                break;
                            }
                        case "super":
                            {
                                var a1 = from s in DataAccess.context.SanPham
                                         join t in DataAccess.context.ThongSoKiThuat
                                          on s.MaSp equals t.MaSp
                                         where (5000 < Convert.ToInt32(t.GiaTri.ToLower().Substring(0, 4)) &&
                                         t.ThongSo.Contains("TS0018") && s.LoaiSp.Contains("LSP0002"))
                                         select s;
                                _filter_.Add(a1);
                                break;
                            }
                    }
                   
                }
            }
            _filter_.ToList().ForEach(item => _filter_[0] = _filter_[0].Intersect(item));
            return sanphams.Intersect(_filter_[0]);
        }

        public static IQueryable<SanPham> FilterPhoneByScreenSize(IQueryable<SanPham> sanphams, string _screenString)
        {
            var _filter_ = new List<IQueryable<SanPham>>();

            foreach (var _screenValue in _screenString.Split('-'))
            {
                if (!String.IsNullOrEmpty(_screenValue))
                {
                    switch (_screenValue)
                    {
                        case "small":
                            {
                                var a1 = from s in DataAccess.context.SanPham
                                         join t in DataAccess.context.ThongSoKiThuat
                                          on s.MaSp equals t.MaSp
                                         where (Convert.ToInt32(t.GiaTri.Substring(0, 1)) < 6 && t.ThongSo.Contains("TS0002") && s.LoaiSp.Contains("LSP0002"))
                                         select s;
                                _filter_.Add(a1);
                                break;
                            }
                        case "medium":
                            {
                                var a1 = from s in DataAccess.context.SanPham
                                         join t in DataAccess.context.ThongSoKiThuat
                                          on s.MaSp equals t.MaSp
                                         where (6 <= Convert.ToInt32(t.GiaTri.ToLower().Substring(0, 1)) &&
                                         Convert.ToInt32(t.GiaTri.ToLower().Substring(0, 1)) < 8 &&
                                         t.ThongSo.Contains("TS0002") && s.LoaiSp.Contains("LSP0002"))
                                         select s;
                                _filter_.Add(a1);
                                break;
                            }
                        case "big":
                            {
                                var a1 = from s in DataAccess.context.SanPham
                                         join t in DataAccess.context.ThongSoKiThuat
                                          on s.MaSp equals t.MaSp
                                         where (8 <= Convert.ToInt32(t.GiaTri.ToLower().Substring(0, 1)) &&
                                         t.ThongSo.Contains("TS0002") && s.LoaiSp.Contains("LSP0002"))
                                         select s;
                                _filter_.Add(a1);
                                break;
                            }
                    }

                }
            }
            _filter_.ToList().ForEach(item => _filter_[0] = _filter_[0].Intersect(item));
            return sanphams.Intersect(_filter_[0]);
        }


        public static IQueryable<SanPham> FilterPhoneBySpecialFeature(IQueryable<SanPham> sanphams, string _featureString)
        {
            var _filter_ = new List<IQueryable<SanPham>>();

            foreach (var _featureValue in _featureString.Split('-'))
            {
                if (!String.IsNullOrEmpty(_featureValue))
                {
                    var _sanphams = from s in sanphams
                                    join t in context.ThongSoKiThuat
                                    on s.MaSp equals t.MaSp
                                    where t.GiaTri.ToLower().Contains(_featureValue.ToLower()) && s.LoaiSp.Contains("LSP0002")
                                    select s;
                    _filter_.Add(_sanphams);
                }
            }
            _filter_.ToList().ForEach(item => _filter_[0] = _filter_[0].Union(item));
            return sanphams.Intersect(_filter_[0]);
        }


        public static IQueryable<SanPham> FilterTabletByScreenSize(IQueryable<SanPham> sanphams, string _screenString)
        {
            var _filter_ = new List<IQueryable<SanPham>>();

            foreach (var _screenValue in _screenString.Split('-'))
            {
                if (!String.IsNullOrEmpty(_screenValue))
                {
                    var _sanphams = from s in sanphams
                                    join t in context.ThongSoKiThuat
                                    on s.MaSp equals t.MaSp
                                    where t.GiaTri.ToLower().Contains(_screenValue.ToLower()) && t.ThongSo == "TS0025" && s.LoaiSp == "LSP0007"
                                    select s;
                    _filter_.Add(_sanphams);
                }
            }
            _filter_.ToList().ForEach(item => _filter_[0] = _filter_[0].Intersect(item));
            var result = sanphams.Intersect(_filter_[0]);
            return result;
        }

        public static IQueryable<SanPham> FilterTabletByRam(IQueryable<SanPham> sanphams, string _ramString)
        {
            var _filter_ = new List<IQueryable<SanPham>>();

            foreach (var _ramValue in _ramString.Split('-'))
            {
                if (!String.IsNullOrEmpty(_ramValue))
                {
                    var _sanphams = from s in sanphams
                                    join t in context.ThongSoKiThuat
                                    on s.MaSp equals t.MaSp
                                    where t.GiaTri.ToLower().Contains(_ramValue.ToLower()) && t.ThongSo == "TS0034" && s.LoaiSp == "LSP0007"
                                    select s;
                    _filter_.Add(_sanphams);
                }
            }
            _filter_.ToList().ForEach(item => _filter_[0] = _filter_[0].Intersect(item));
            var result = sanphams.Intersect(_filter_[0]);
            return result;
        }

        public static IQueryable<SanPham> FilterTabletBySim(IQueryable<SanPham> sanphams, string _simString)
        {
            var _filter_ = new List<IQueryable<SanPham>>();

            foreach (var _simValue in _simString.Split('-'))
            {
                if (!String.IsNullOrEmpty(_simValue))
                {
                    var _sanphams = from s in sanphams
                                    join t in context.ThongSoKiThuat
                                    on s.MaSp equals t.MaSp
                                    where t.GiaTri.ToLower().Contains(_simValue.ToLower()) && t.ThongSo == "TS0037" && s.LoaiSp == "LSP0007"
                                    select s;
                    _filter_.Add(_sanphams);
                }
            }
            _filter_.ToList().ForEach(item => _filter_[0] = _filter_[0].Intersect(item));
            var result = sanphams.Intersect(_filter_[0]);
            return result;
        }

        public static IQueryable<SanPham> FilterSanPhamWithParam(IQueryable<SanPham> sanphams, string params_list, string loaiSp)
        {
            ////filter by cấu hình 
            if (!String.IsNullOrEmpty(params_list) && !String.IsNullOrEmpty(loaiSp))
            {
                sanphams = sanphams.Where(s => s.LoaiSp == loaiSp);

                //for Laptop 
                if (loaiSp == "LSP0008")
                {
                    foreach (var _param in params_list.Split('&'))
                    {
                        if (!String.IsNullOrEmpty(_param))
                        {
                            if (_param.Contains('f'))
                            {
                                string _tmp_param_1 = Regex.Replace(_param, "f", "");
                                if (!String.IsNullOrEmpty(_tmp_param_1))
                                {
                                    sanphams = DataAccess.FilterLaptopByRam(sanphams, _tmp_param_1);
                                }

                            }
                            else if (_param.Contains('j'))
                            {
                                string _tmp_param_1 = Regex.Replace(_param, "j", "");
                                if (!String.IsNullOrEmpty(_tmp_param_1))
                                {
                                    sanphams = DataAccess.FilterLaptopByCpu(sanphams, _tmp_param_1);
                                }
                            }
                            else if (_param.Contains('w'))
                            {
                                string _tmp_param_1 = Regex.Replace(_param, "w", "");
                                if (!String.IsNullOrEmpty(_tmp_param_1))
                                {
                                    sanphams = DataAccess.FilterLaptopByRequire(sanphams, _tmp_param_1);
                                }

                            }
                            else if (_param.Contains('z'))
                            {
                                string _tmp_param_1 = Regex.Replace(_param, "z", "");
                                if (!String.IsNullOrEmpty(_tmp_param_1))
                                {
                                    sanphams = DataAccess.FilterSanphamBySpecialFeature(sanphams, _tmp_param_1);
                                }
                            }
                        }
                    }
                }
                else if (loaiSp == "LSP0002")
                {
                    foreach (var _param in params_list.Split('&'))
                    {
                        if (!String.IsNullOrEmpty(_param))
                        {
                            if (_param.Contains('f'))
                            {
                                string _tmp_param_1 = Regex.Replace(_param, "f", "");
                                if (!String.IsNullOrEmpty(_tmp_param_1))
                                {
                                    sanphams = DataAccess.FilterPhoneByOs(sanphams, _tmp_param_1);
                                }

                            }
                            else if (_param.Contains('j'))
                            {
                                string _tmp_param_1 = Regex.Replace(_param, "j", "");
                                if (!String.IsNullOrEmpty(_tmp_param_1))
                                {
                                    sanphams = DataAccess.FilterPhoneByBattery(sanphams, _tmp_param_1);
                                }
                            }
                            else if (_param.Contains('w'))
                            {
                                string _tmp_param_1 = Regex.Replace(_param, "w", "");

                                if (!String.IsNullOrEmpty(_tmp_param_1))
                                {
                                    sanphams = DataAccess.FilterPhoneByScreenSize(sanphams, _tmp_param_1);
                                }

                            }
                            else if (_param.Contains('z'))
                            {
                                string _tmp_param_1 = Regex.Replace(_param, "z", "");
                                if (!String.IsNullOrEmpty(_tmp_param_1))
                                {
                                    sanphams = DataAccess.FilterPhoneBySpecialFeature(sanphams, _tmp_param_1);
                                }
                            }
                        }
                    }
                }
                else if (loaiSp == "LSP0007")
                {
                    foreach (var _param in params_list.Split('&'))
                    {
                        if (!String.IsNullOrEmpty(_param))
                        {
                            if (_param.Contains('f'))
                            {
                                string _tmp_param_1 = Regex.Replace(_param, "f", "");
                                if (!String.IsNullOrEmpty(_tmp_param_1))
                                {
                                    sanphams = DataAccess.FilterTabletByScreenSize(sanphams, _tmp_param_1);
                                }

                            }
                            else if (_param.Contains('j'))
                            {
                                string _tmp_param_1 = Regex.Replace(_param, "j", "");
                                if (!String.IsNullOrEmpty(_tmp_param_1))
                                {
                                    sanphams = DataAccess.FilterTabletByRam(sanphams, _tmp_param_1);
                                }
                            }
                            else if (_param.Contains('w'))
                            {
                                string _tmp_param_1 = Regex.Replace(_param, "w", "");

                                if (!String.IsNullOrEmpty(_tmp_param_1))
                                {
                                    sanphams = DataAccess.FilterTabletBySim(sanphams, _tmp_param_1);
                                }

                            }
                            else if (_param.Contains('z'))
                            {
                                string _tmp_param_1 = Regex.Replace(_param, "z", "");
                                if (!String.IsNullOrEmpty(_tmp_param_1))
                                {
                                    sanphams = DataAccess.FilterPhoneBySpecialFeature(sanphams, _tmp_param_1);
                                }
                            }
                        }
                    }
                }
                return sanphams;
            }
            else return sanphams;
        }

        public static bool ExistUser(string id)
        {
            var a = context.AspNetUsers.Find(id);
            if (a == null)
                return false;
            else return true;
        }
    }
}