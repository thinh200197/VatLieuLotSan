using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VatLieuLotSan.DataBase;

namespace VatLieuLotSan.Models
{
    public class NhanVienModel
    {
        DBVatLieuLotSanContext db = null;
        public NhanVienModel()
        {
            db = new DBVatLieuLotSanContext();
        }
        public List<NHANVIEN> getByID(string TenNV)
        { 
            return db.NHANVIENs.OrderByDescending(x=> x.MANV).ToList();
        }
        public string Insert(NHANVIEN entity)
        {
            db.NHANVIENs.Add(entity);
            db.SaveChanges();
            return entity.MANV;
        }
        public bool Update(NHANVIEN entity)
        {
            try
            {
                var user = db.NHANVIENs.Find(entity.MANV);
                user.GIOITINH = entity.GIOITINH;
                user.NGAYSINH = entity.NGAYSINH;
                user.CMND = entity.CMND;
                user.TENNV = entity.TENNV;
                user.SODIENTHOAI = entity.SODIENTHOAI;
                user.Email = entity.Email;
                user.DIACHI = entity.DIACHI;
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }
        public bool Delete(string MaNV)
        {
            try
            {
                var user = db.NHANVIENs.Find(MaNV);
                db.NHANVIENs.Remove(user);
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }

        }
        //public IEnumerable<NHANVIEN> ListAllPaging(int page, int pageSize)
        //{
        //    return db.NGUOIDUNGs.OrderByDescending(x => x.NGAYTAO).ToPagedList(page, pageSize);
        //}
    }
}