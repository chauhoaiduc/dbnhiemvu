using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NhiemVu.Models;
using NhiemVu.Helper;
using System.IO;

namespace NhiemVu.Controllers
{
    public class AccountController : Controller
    {
        public ActionResult NhiemVuMoi()
        {
            return View();
        }
        public ActionResult GetNhiemVuMoi(int? index, string search) {

            if (!index.HasValue)
            {
                index = 0;
            }
            if (search == null)
            {
                search = "";
            }
            var iMaNguoiDuocGiao = CurrentContext.GetUser().iMaThanhVienCode;
            using (var db = new dbnhiemvuEntities())
            {
                var list = db.NhiemVus.ToList();
                var result = (from b in list
                              join t in db.ThanhViens on b.iMaNguoiDuocGiaoCode equals t.iMaThanhVienCode
                              join tt in db.TrangThais on b.iMaTrangThaiCode equals tt.iMaTrangThaiCode
                              where b.vTenNhiemVu.Contains(search) && b.iMaNguoiDuocGiaoCode == iMaNguoiDuocGiao && b.iMaTrangThaiCode==1
                              select new GetBangNhiemVuViewModel
                              {
                                  iMaNhiemVuCode = b.iMaNhiemVuCode,
                                  dNgayBD = b.dNgayBD,
                                  dNgayKT = b.dNgayKT,
                                  iMaTrangThaiCode = b.iMaTrangThaiCode,
                                  vNguoiDuocGiao = t.vTenDangNhap,
                                  vTenNhiemVu = b.vTenNhiemVu,
                                  vTenTrangThai = tt.vTenTrangThai
                              }).ToList();
                var item = 4;
                result = result.OrderByDescending(m => m.dNgayLap).Skip(index.Value * item).Take(item).ToList();
                return Json(result);
            }
        }
        public ActionResult NhiemVuDaNhan()
        {
            return View();
        }
        public ActionResult GetNhiemVuDaNhan(int? index, string search)
        {

            if (!index.HasValue)
            {
                index = 0;
            }
            if (search == null)
            {
                search = "";
            }
            var iMaNguoiDuocGiao = CurrentContext.GetUser().iMaThanhVienCode;
            using (var db = new dbnhiemvuEntities())
            {
                var list = db.NhiemVus.ToList();
                var result = (from b in list
                              join t in db.ThanhViens on b.iMaNguoiDuocGiaoCode equals t.iMaThanhVienCode
                              join tt in db.TrangThais on b.iMaTrangThaiCode equals tt.iMaTrangThaiCode
                              where b.vTenNhiemVu.Contains(search) && b.iMaNguoiDuocGiaoCode == iMaNguoiDuocGiao && b.iMaTrangThaiCode == 2
                              select new GetBangNhiemVuViewModel
                              {
                                  iMaNhiemVuCode = b.iMaNhiemVuCode,
                                  dNgayBD = b.dNgayBD,
                                  dNgayKT = b.dNgayKT,
                                  iMaTrangThaiCode = b.iMaTrangThaiCode,
                                  vNguoiDuocGiao = t.vTenDangNhap,
                                  vTenNhiemVu = b.vTenNhiemVu,
                                  vTenTrangThai = tt.vTenTrangThai
                              }).ToList();
                var item = 4;
                result = result.OrderByDescending(m => m.dNgayLap).Skip(index.Value * item).Take(item).ToList();
                return Json(result);
            }
        }
        public ActionResult NhiemVuChoDuyet()
        {
            return View();
        }
        public ActionResult GetNhiemVuChoDuyet(int? index, string search)
        {

            if (!index.HasValue)
            {
                index = 0;
            }
            if (search == null)
            {
                search = "";
            }
            var iMaNguoiDuocGiao = CurrentContext.GetUser().iMaThanhVienCode;
            using (var db = new dbnhiemvuEntities())
            {
                var list = db.NhiemVus.ToList();
                var result = (from b in list
                              join t in db.ThanhViens on b.iMaNguoiDuocGiaoCode equals t.iMaThanhVienCode
                              join tt in db.TrangThais on b.iMaTrangThaiCode equals tt.iMaTrangThaiCode
                              where b.vTenNhiemVu.Contains(search) && b.iMaNguoiDuocGiaoCode == iMaNguoiDuocGiao && b.iMaTrangThaiCode == 3
                              select new GetBangNhiemVuViewModel
                              {
                                  iMaNhiemVuCode = b.iMaNhiemVuCode,
                                  dNgayBD = b.dNgayBD,
                                  dNgayKT = b.dNgayKT,
                                  iMaTrangThaiCode = b.iMaTrangThaiCode,
                                  vNguoiDuocGiao = t.vTenDangNhap,
                                  vTenNhiemVu = b.vTenNhiemVu,
                                  vTenTrangThai = tt.vTenTrangThai
                              }).ToList();
                var item = 4;
                result = result.OrderByDescending(m => m.dNgayLap).Skip(index.Value * item).Take(item).ToList();
                return Json(result);
            }
        }
        public ActionResult NhiemVuDangSuaLoi()
        {
            return View();
        }
        public ActionResult NhiemVuDangSuaLoi(int? index, string search)
        {

            if (!index.HasValue)
            {
                index = 0;
            }
            if (search == null)
            {
                search = "";
            }
            var iMaNguoiDuocGiao = CurrentContext.GetUser().iMaThanhVienCode;
            using (var db = new dbnhiemvuEntities())
            {
                var list = db.NhiemVus.ToList();
                var result = (from b in list
                              join t in db.ThanhViens on b.iMaNguoiDuocGiaoCode equals t.iMaThanhVienCode
                              join tt in db.TrangThais on b.iMaTrangThaiCode equals tt.iMaTrangThaiCode
                              where b.vTenNhiemVu.Contains(search) && b.iMaNguoiDuocGiaoCode == iMaNguoiDuocGiao && b.iMaTrangThaiCode == 5
                              select new GetBangNhiemVuViewModel
                              {
                                  iMaNhiemVuCode = b.iMaNhiemVuCode,
                                  dNgayBD = b.dNgayBD,
                                  dNgayKT = b.dNgayKT,
                                  iMaTrangThaiCode = b.iMaTrangThaiCode,
                                  vNguoiDuocGiao = t.vTenDangNhap,
                                  vTenNhiemVu = b.vTenNhiemVu,
                                  vTenTrangThai = tt.vTenTrangThai
                              }).ToList();
                var item = 4;
                result = result.OrderByDescending(m => m.dNgayLap).Skip(index.Value * item).Take(item).ToList();
                return Json(result);
            }
        }
        public ActionResult NhiemVuDaHoanThanh()
        {
            return View();
        }
        public ActionResult NhiemVuDaHoanThanh(int? index, string search)
        {

            if (!index.HasValue)
            {
                index = 0;
            }
            if (search == null)
            {
                search = "";
            }
            var iMaNguoiDuocGiao = CurrentContext.GetUser().iMaThanhVienCode;
            using (var db = new dbnhiemvuEntities())
            {
                var list = db.NhiemVus.ToList();
                var result = (from b in list
                              join t in db.ThanhViens on b.iMaNguoiDuocGiaoCode equals t.iMaThanhVienCode
                              join tt in db.TrangThais on b.iMaTrangThaiCode equals tt.iMaTrangThaiCode
                              where b.vTenNhiemVu.Contains(search) && b.iMaNguoiDuocGiaoCode == iMaNguoiDuocGiao && b.iMaTrangThaiCode == 4
                              select new GetBangNhiemVuViewModel
                              {
                                  iMaNhiemVuCode = b.iMaNhiemVuCode,
                                  dNgayBD = b.dNgayBD,
                                  dNgayKT = b.dNgayKT,
                                  iMaTrangThaiCode = b.iMaTrangThaiCode,
                                  vNguoiDuocGiao = t.vTenDangNhap,
                                  vTenNhiemVu = b.vTenNhiemVu,
                                  vTenTrangThai = tt.vTenTrangThai
                              }).ToList();
                var item = 4;
                result = result.OrderByDescending(m => m.dNgayLap).Skip(index.Value * item).Take(item).ToList();
                return Json(result);
            }
        }
        public bool UploadFileBaoCao(int iMaBaoCaoCode)
        {
            try
            {
                for (int i = 0; i < Request.Files.Count; i++)
                {
                    var file = Request.Files[i];
                    if (file != null && file.ContentLength > 0)
                    {
                        string[] extFile = new string[] { ".xls", ".xlsx", ".doc", ".docx", ".txt", ".zip", ".rar", ".sql", ".cs", ".js", ".css" };
                        using (var db = new dbnhiemvuEntities())
                        {
                            if (extFile.Contains(Path.GetExtension(file.FileName).ToLower()))
                            {
                                // tạo thư mục lưu file
                                var spDirPath = Server.MapPath("~/Content/FileReports");
                                var targetDirpath = Path.Combine(spDirPath, iMaBaoCaoCode.ToString());
                                Directory.CreateDirectory(targetDirpath);
                                // lấy tên file
                                var fileName = Path.GetFileName(file.FileName);
                                // tạo đường dẫn và lưu hình ảnh
                                var path = Path.Combine(Server.MapPath($"~/Content/FileReports/{iMaBaoCaoCode}/"), fileName);
                                file.SaveAs(path);
                                // lưu hình ảnh vào cơ sở dữ liệu
                                var taptin = new TapTinBaoCao();
                                taptin.vDuongDan = $"/Content/FileReports/{iMaBaoCaoCode}/{fileName}";
                                taptin.iMaBaoCaoCode = iMaBaoCaoCode;
                                taptin.vTenTapTinBaoCao = fileName;
                                taptin.iTrangThai = 1;
                                db.TapTinBaoCaos.Add(taptin);
                                db.SaveChanges();
                            }
                        }
                    }
                }
                return true;
            }
            catch { return false; }
        }
        public int BaoCaoNhiemVu(BaoCaoNhiemVuViewModel model)
        {
            try {
                using (var db = new dbnhiemvuEntities())
                {
                    var baocao = new BaoCao();
                    baocao.iMaNhiemVuCode = model.iMaNhiemVuCode;
                    baocao.vMoTa = model.vMoTa;
                    baocao.vDuongDanTapTin = model.vDuongDanTapTin;
                    db.BaoCaos.Add(baocao);
                    db.SaveChanges();
                    return baocao.iMaBaoCaoCode;
                }
            } catch {
                return 0;
            }
            
        }
        public bool ThayDoiTrangThai(int iMaNhiemVuCode,int? iMaTrangThaiCode)
        {
            try {
                using (var db = new dbnhiemvuEntities())
                {
                    var task = db.NhiemVus.Find(iMaNhiemVuCode);
                    if (task.iMaTrangThaiCode < 3)
                    {
                        task.iMaTrangThaiCode += 1;
                    }
                    else {
                        task.iMaTrangThaiCode = iMaTrangThaiCode;
                    }
                    db.SaveChanges();
                    return true;
                }
            } catch {
                return false;
            }
            
        }
        public ActionResult HinhNhiemVuPartial(int iMaNhiemVuCode)
        {
            using (var db = new dbnhiemvuEntities()) {
                var result = db.Hinhs.Where(m => m.iMaNhiemVuCode == iMaNhiemVuCode).ToList();
                return PartialView("HinhNhiemVuPartial", result);
                //return Json(result);
            }
                
        }
        public ActionResult GetTapTinNhiemVu(int iMaNhiemVuCode)
        {
            using (var db = new dbnhiemvuEntities())
            {
                var result = db.TapTins.Where(m => m.iMaNhiemVuCode == iMaNhiemVuCode).ToList();
                return Json(result);
            }

        }
        public ActionResult ChiTietNhiemVu(int? iMaNhiemVuCode)
        {
            if (!iMaNhiemVuCode.HasValue)
            {
                return RedirectToAction("Index", "Home");
            }
            using (var db = new dbnhiemvuEntities())
            {
                var result = (from t in db.NhiemVus
                              join s in db.ThanhViens on t.iMaNguoiDangCode equals s.iMaThanhVienCode
                              join r in db.ThanhViens on t.iMaNguoiDuocGiaoCode equals r.iMaThanhVienCode
                              join tt in db.TrangThais on t.iMaTrangThaiCode equals tt.iMaTrangThaiCode
                              where t.iMaNhiemVuCode == iMaNhiemVuCode
                              select new ChiTietNhiemVuViewModel
                              {
                                  iMaNhiemVuCode=t.iMaNhiemVuCode,
                                  iMaTrangThaiCode=t.iMaTrangThaiCode,
                                  dNgayBD=t.dNgayBD,
                                  dNgayKT=t.dNgayKT,
                                  dNgayLap=t.dNgayLap,
                                  vMoTa=t.vMoTa,
                                  vTenNguoiDang=s.vTenDangNhap,
                                  vTenNguoiDuocGiao=r.vTenDangNhap,
                                  vTenNhiemVu=t.vTenNhiemVu,
                                  vTenTrangThai=tt.vTenTrangThai
                              }).FirstOrDefault();
                return View(result);
            }


        }
        [HttpPost]
        public ActionResult GetBangNhiemVu(int? index,string search,int? iMaNguoiDuocGiaoCode,int? iMaTrangThaiCode)
        {
            if (!index.HasValue)
            {
                index = 0;
            }
            if (search == null)
            {
                search = "";
            }
            using (var db = new dbnhiemvuEntities())
            {
                var list = db.NhiemVus.ToList();
                if (iMaNguoiDuocGiaoCode.HasValue && iMaNguoiDuocGiaoCode!=0)
                {
                    list = list.Where(m => m.iMaNguoiDuocGiaoCode == iMaNguoiDuocGiaoCode).ToList();
                }
                if(iMaTrangThaiCode.HasValue && iMaTrangThaiCode != 0)
                {
                    list = list.Where(m => m.iMaTrangThaiCode == iMaTrangThaiCode).ToList();
                }
                var result = (from b in list
                              join t in db.ThanhViens on b.iMaNguoiDuocGiaoCode equals t.iMaThanhVienCode
                              join tt in db.TrangThais on b.iMaTrangThaiCode equals tt.iMaTrangThaiCode
                              where b.vTenNhiemVu.Contains(search)
                              select new GetBangNhiemVuViewModel
                              {
                                  iMaNhiemVuCode=b.iMaNhiemVuCode,
                                  dNgayBD = b.dNgayBD,
                                  dNgayKT = b.dNgayKT,
                                  iMaTrangThaiCode = b.iMaTrangThaiCode,
                                  vNguoiDuocGiao = t.vTenDangNhap,
                                  vTenNhiemVu = b.vTenNhiemVu,
                                  vTenTrangThai = tt.vTenTrangThai
                              }).ToList();
                var item = 4;
                result = result.OrderByDescending(m => m.dNgayLap).Skip(index.Value * item).Take(item).ToList();
                return Json(result);
            }
            
        }
        public bool UploadFile(int iMaNhiemVuCode)
        {
            try
            {
                for (int i = 0; i < Request.Files.Count; i++)
                {
                    var file = Request.Files[i];
                    if (file != null && file.ContentLength > 0)
                    {
                        string[] extHinh = new string[] { ".jpg", ".png" };
                        string[] extFile = new string[] { ".xls", ".xlsx", ".doc", ".docx", ".txt",".zip",".rar",".sql",".cs",".js",".css" };
                        using (var db = new dbnhiemvuEntities())
                        {
                            // kiểm tra định dạng file là .jpg hoặc .png
                            if (extHinh.Contains(Path.GetExtension(file.FileName).ToLower()))
                            {
                                // tạo thư mục lưu hình
                                string spDirPath = Server.MapPath("~/Content/Images");
                                string targetDirpath = Path.Combine(spDirPath, iMaNhiemVuCode.ToString());
                                Directory.CreateDirectory(targetDirpath);
                                // lấy tên file
                                var fileName = Path.GetFileName(file.FileName);
                                // tạo đường dẫn và lưu hình ảnh
                                var path = Path.Combine(Server.MapPath($"~/Content/Images/{iMaNhiemVuCode}/"), fileName);
                                file.SaveAs(path);
                                // lưu hình ảnh vào cơ sở dữ liệu
                                var image = new Hinh();
                                image.vDuongDan = $"/Content/Images/{iMaNhiemVuCode}/{fileName}";
                                image.iMaNhiemVuCode = iMaNhiemVuCode;
                                image.iTrangThai = 1;
                                db.Hinhs.Add(image);
                                db.SaveChanges();
                            }
                            else if (extFile.Contains(Path.GetExtension(file.FileName).ToLower()))
                            {
                                // tạo thư mục lưu file
                                var spDirPath = Server.MapPath("~/Content/Files");
                                var targetDirpath = Path.Combine(spDirPath, iMaNhiemVuCode.ToString());
                                Directory.CreateDirectory(targetDirpath);
                                // lấy tên file
                                var fileName = Path.GetFileName(file.FileName);
                                // tạo đường dẫn và lưu hình ảnh
                                var path = Path.Combine(Server.MapPath($"~/Content/Files/{iMaNhiemVuCode}/"), fileName);
                                file.SaveAs(path);
                                // lưu hình ảnh vào cơ sở dữ liệu
                                var taptin = new TapTin();
                                taptin.vDuongDan = $"/Content/Files/{iMaNhiemVuCode}/{fileName}";
                                taptin.iMaNhiemVuCode = iMaNhiemVuCode;
                                taptin.vTenTapTin = fileName;
                                taptin.iTrangThai = 1;
                                db.TapTins.Add(taptin);
                                db.SaveChanges();
                            }
                        }   
                    }
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
        [HttpPost]
        public int ThemNhiemVu(ThemNhiemVuMoel model) {
            var task = new Models.NhiemVu();
            task.dNgayLap = DateTime.Now;
            task.dNgayBD = model.dNgayBD;
            task.dNgayKT = model.dNgayKT;
            task.iMaNguoiDuocGiaoCode = model.iMaNguoiDuocGiaoCode;
            task.vTenNhiemVu = model.vTenNhiemVu;
            task.vMoTa = model.vMoTa;
            task.iMaNguoiDangCode = 1;
            task.iMaTrangThaiCode = 1;
            try {
                using (var db = new dbnhiemvuEntities())
                {
                    db.NhiemVus.Add(task);
                    db.SaveChanges();
                }
                return task.iMaNhiemVuCode;
            } catch {
                return 0;
            }
            
        }
        public ActionResult Login()
        {
            return View();
        }
        // GET: Account
        public ActionResult Index()
        {
            using (var db = new dbnhiemvuEntities())
            {
                ViewBag.ThanhVien = (from t in db.ThanhViens
                                     select new GetThanhVienViewModel
                                     {
                                         iMaThanhVienCode = t.iMaThanhVienCode,
                                         vTenDangNhap = t.vTenDangNhap
                                     }).ToList();
                ViewBag.TrangThai = db.TrangThais.ToList();
                return View();
            }
                
            
        }
        [HttpPost]
        public ActionResult Login(LoginViewModel model)
        {
            string encPWD = StringUtils.MD5(model.vMatKhau);

            using (var db = new dbnhiemvuEntities())
            {
                var user = db.ThanhViens.Where(m => m.vTenDangNhap == model.vTenDangNhap && m.vMatKhau == encPWD).FirstOrDefault();
                if (user != null)
                {
                    Session["isLogin"] = 1;
                    Session["user"] = user;

                    if (Request.Form.GetValues("bGhiNho") != null)
                    {
                        Response.Cookies["userID"].Value = user.iMaThanhVienCode.ToString();
                        Response.Cookies["userID"].Expires = DateTime.Now.AddDays(7);
                    }
                    return RedirectToAction("Index", "Account");
                    //return RedirectToAction("Index", "Home");
                }
                else
                {
                    ViewBag.Msg = "Tên đăng nhập hoặc tài khoản không đúng !";
                    return View();
                }
            }
        }
        [HttpPost]
        public bool Register(RegisterViewModel model)
        {
            try
            {
                string encPWD = StringUtils.MD5(model.vMatKhau);
                using (var db = new dbnhiemvuEntities())
                {
                    var user = new ThanhVien()
                    {
                        vTenDangNhap = model.vTenDangNhap,
                        vMatKhau = encPWD,
                        iTrangThai = 1
                    };

                    db.ThanhViens.Add(user);
                    db.SaveChanges();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
        [HttpPost]
        public ActionResult Logout()
        {
            CurrentContext.Destroy();
            return RedirectToAction("Index", "Home");
        }
    }
}