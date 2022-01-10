using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using QLTV.DAO;
using QLTV.Entity;
using QLTV.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTV.GUI
{
    public partial class frmMuonSach : DevExpress.XtraEditors.XtraForm
    {
        private int viTriPM;
        private int viTriCTPM;

        bool option;

        public frmMuonSach()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            if (lkupMaTheDG.EditValue == null)
            {
                return;
            }
            string maTheDG = lkupMaTheDG.EditValue.ToString();
            TheDocGia the = Data.Instance.TheDocGia.Find(maTheDG);
            txtHoTenDG.Text = the.DocGia.Ho + " " + the.DocGia.Ten;
            txtMaDG.Text = the.MaDG;
            bdsPhieuMuon.DataSource = the.PhieuMuon.ToList();
            if (bdsPhieuMuon.Count > 0)
            {
                PhieuMuon phieu = bdsPhieuMuon.Current as PhieuMuon;
                bdsCTPM.DataSource = phieu.ChiTietPhieuMuon.ToList();
            }
            else
            {
                bdsCTPM.DataSource = null;
            }
            ChangeUpdateMode_PhieuMuon(false);
            ChangeUpdateMode_CTPM(false);
        }

        private void ChangeUpdateMode_PhieuMuon(bool isUpdating)
        {
            btnThemPM.Enabled = txtViTriHocPhi.Enabled = !isUpdating && (lkupMaTheDG.EditValue != null);
            btnTaiPM.Enabled = btnThoat.Enabled = !isUpdating;
            btnXoaPM.Enabled = btnSuaPM.Enabled = !isUpdating && (bdsPhieuMuon.Count > 0);
            btnGhiPM.Enabled = btnHuyPM.Enabled = isUpdating;
            gbHocPhi.Enabled = isUpdating;

            gbTheDocGia.Enabled = gcHocPhi.Enabled = nvgtCTPM.Enabled = gcCTHocPhi.Enabled = !isUpdating;
        }

        private void ChangeUpdateMode_CTPM(bool isUpdating)
        {
            btnTaiCTPM.Enabled = btnThoat.Enabled = txtViTriCTDHP.Enabled = !isUpdating;
            btnThemCTPM.Enabled = !isUpdating && (bdsPhieuMuon.Count > 0);
            btnXoaCTPM.Enabled = !isUpdating && (bdsCTPM.Count > 0);
            btnGhiCTPM.Enabled = btnHuyCTPM.Enabled = isUpdating;
            gbCTPM.Enabled = isUpdating;

            gbTheDocGia.Enabled = gcCTHocPhi.Enabled = nvgtPhieuMuon.Enabled = gcHocPhi.Enabled = !isUpdating;
        }

        private void frmMuonSach_Load(object sender, EventArgs e)
        {
            bdsTheDocGia.DataSource = Data.Instance.TheDocGia.ToList();
            bdsSach.DataSource = Data.Instance.Sach.ToList();
            ChangeUpdateMode_PhieuMuon(false);
            ChangeUpdateMode_CTPM(false);
        }

        private void lkupMaTheDG_EditValueChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        private void gvCTPM_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (bdsPhieuMuon.Count > 0)
            {
                PhieuMuon phieu = bdsPhieuMuon.Current as PhieuMuon;
                bdsCTPM.DataSource = phieu.ChiTietPhieuMuon.ToList();
            }
        }

        private void gvCTPM_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {
            if (e.Column.FieldName == "Image" && e.IsGetData)
            {
                GridView view = sender as GridView;

                string fileName = (string)view.GetRowCellValue(e.ListSourceRowIndex, "Sach.TuaSach.HinhAnh");
                if (string.IsNullOrEmpty(fileName))
                {
                    e.Value = null;
                    return;
                }
                if (!ImageData.Images.ContainsKey(fileName))
                {
                    Image img = null;
                    try
                    {
                        string filePath = DevExpress.Utils.FilesHelper
                            .FindingFileName(Application.StartupPath, ImageData.ImageDir + fileName, false);
                        img = Image.FromFile(filePath);
                    }
                    catch
                    {
                    }
                    ImageData.Images.Add(fileName, img);
                }
                e.Value = ImageData.Images[fileName];
            }
        }

        private void gvlkSach_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {
            if (e.Column.FieldName == "Image" && e.IsGetData)
            {
                GridView view = sender as GridView;

                string fileName = (string)view.GetRowCellValue(e.ListSourceRowIndex, "TuaSach.HinhAnh");
                if (string.IsNullOrEmpty(fileName))
                {
                    e.Value = null;
                    return;
                }
                if (!ImageData.Images.ContainsKey(fileName))
                {
                    Image img = null;
                    try
                    {
                        string filePath = DevExpress.Utils.FilesHelper
                            .FindingFileName(Application.StartupPath, ImageData.ImageDir + fileName, false);
                        img = Image.FromFile(filePath);
                    }
                    catch
                    {
                    }
                    ImageData.Images.Add(fileName, img);
                }
                e.Value = ImageData.Images[fileName];
            }
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }

        private void btnThemPM_Click(object sender, EventArgs e)
        {
            option = true;
            viTriPM = bdsPhieuMuon.Position;
            bdsPhieuMuon.AddNew();
            txtMaPM.Text = CodeGenerator.SinhMaPhieuMuon();
            bdsTheDocGia.EndEdit();
            ChangeUpdateMode_PhieuMuon(true);
        }

        private void btnXoaPM_Click(object sender, EventArgs e)
        {
            PhieuMuon phieu = bdsPhieuMuon.Current as PhieuMuon;
            if (phieu.ChiTietPhieuMuon.Count > 0)
            {
                XDialog.Error("Không thể xóa phiếu mượn này vì phiếu mượn này đã có chi tiết!");
                return;
            }

            if (phieu.ChiTietPhieuTra.Count > 0)
            {
                XDialog.Error("Không thể xóa phiếu mượn này vì đã có phiếu trả có liên quan phiếu mượn này!");
                return;
            }

            if (XDialog.Confirm("Bạn có chắc muốn xóa phiếu mượn này không?") != DialogResult.OK) return;

            int position = bdsPhieuMuon.Position;
            try
            {
                Data.Instance.PhieuMuon.Remove(phieu);
                Data.Instance.SaveChanges();
                LoadData();
                XDialog.Inform("Đã xóa phiếu mượn!");
            }
            catch (Exception ex)
            {
                XDialog.Error("Đã xảy ra lỗi khi xóa phiếu mượn này!\n" + ex.Message);
                LoadData();
            }
            bdsPhieuMuon.Position = position;
            //ChangeUpdateMode_PhieuMuon(false);
            //ChangeUpdateMode_CTPM(false);
        }

        private void btnSuaPM_Click(object sender, EventArgs e)
        {
            option = false;
            viTriPM = bdsPhieuMuon.Position;
            ChangeUpdateMode_PhieuMuon(true);
        }

        private void btnGhiPM_Click(object sender, EventArgs e)
        {
            if (dateNgayMuon.Text.Trim() == "")
            {
                XDialog.Error("Bạn chưa chọn ngày mượn!");
                return;
            }
            if (dateNgayHenTra.Text.Trim() == "")
            {
                XDialog.Error("Bạn chưa chọn ngày hẹn trả!");
                return;
            }
            string maPhieuMuon = txtMaPM.Text.Trim();
            string maTheDG = lkupMaTheDG.EditValue.ToString();
            DateTime ngayMuon = dateNgayMuon.DateTime;
            DateTime ngayHenTra = dateNgayHenTra.DateTime;

            if (XDialog.Confirm("Bạn có chắc muốn ghi phiếu mượn này không?") != DialogResult.OK) return;

            try
            {
                if (option)
                {
                    PhieuMuon phieu = new PhieuMuon()
                    {
                        MaPhieuMuon = maPhieuMuon,
                        MaTheDocGia = maTheDG,
                        NgayMuon = ngayMuon,
                        NgayHenTra = ngayHenTra,
                        MaNV = Program.id
                    };
                    Data.Instance.PhieuMuon.Add(phieu);
                }
                else
                {
                    PhieuMuon phieu = Data.Instance.PhieuMuon.Find(maPhieuMuon);
                    phieu.NgayMuon = ngayMuon;
                    phieu.NgayHenTra = ngayHenTra;
                }
                Data.Instance.SaveChanges();
                LoadData();
                XDialog.Inform("Đã ghi thông tin phiếu mượn vào cơ sở dữ liệu!");
            }
            catch (Exception ex)
            {
                XDialog.Error("Đã xảy ra lỗi khi ghi phiếu mượn!\n" + ex.Message);
                LoadData();
            }
            //ChangeUpdateMode_PhieuMuon(false);
            //ChangeUpdateMode_CTPM(false);
        }

        private void btnHuyPM_Click(object sender, EventArgs e)
        {
            if (option)
            {
                bdsPhieuMuon.RemoveCurrent();
            }
            bdsPhieuMuon.CancelEdit();
            bdsPhieuMuon.Position = viTriPM;
            ChangeUpdateMode_PhieuMuon(false);
        }

        private void btnTaiPM_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dateNgayMuon_Enter(object sender, EventArgs e)
        {
            dateNgayMuon.Properties.MaxValue = DateTime.Now;
        }

        private void dateNgayHenTra_Enter(object sender, EventArgs e)
        {
            dateNgayHenTra.Properties.MinValue = dateNgayMuon.DateTime;
            dateNgayHenTra.Properties.MaxValue = DateTime.MaxValue;
        }

        private void btnThemCTPM_Click(object sender, EventArgs e)
        {
            option = true;
            viTriCTPM = bdsCTPM.Position;
            viTriPM = bdsPhieuMuon.Position;
            bdsCTPM.AddNew();
            ChangeUpdateMode_CTPM(true);
        }

        private void btnXoaCTPM_Click(object sender, EventArgs e)
        {
            if (XDialog.Confirm("Bạn có chắc muốn xóa chi tiết phiếu mượn này không?") != DialogResult.OK) return;

            int position = bdsCTPM.Position;
            viTriPM = bdsPhieuMuon.Position;
            try
            {
                ChiTietPhieuMuon chiTiet = bdsCTPM.Current as ChiTietPhieuMuon;
                chiTiet.TrangThai = true;
                chiTiet.Sach.TrangThai = true;
                Data.Instance.ChiTietPhieuMuon.Remove(chiTiet);
                Data.Instance.SaveChanges();
                LoadData();
                bdsPhieuMuon.Position = viTriPM;
                XDialog.Inform("Đã xóa chi tiết phiếu mượn!");
            }
            catch (Exception ex)
            {
                bdsPhieuMuon.Position = viTriPM;
                XDialog.Error("Đã xảy ra lỗi khi xóa chi tiết phiếu mượn này!\n" + ex.Message);
                LoadData();
                bdsCTPM.Position = position;
                return;
            }

            if (bdsCTPM.Count == 0) btnXoaCTPM.Enabled = false;
        }

        private void btnGhiCTPM_Click(object sender, EventArgs e)
        {
            if (lkSach.EditValue == null)
            {
                XDialog.Error("Bạn chưa chọn sách để cho mượn!");
                return;
            }
            int maSach = int.Parse(lkSach.EditValue.ToString());
            Sach book = Data.Instance.Sach.Find(maSach);
            if (book.TrangThai == false)
            {
                XDialog.Error("Sách này đã được mượn!");
                return;
            }

            if (XDialog.Confirm("Bạn có chắc muốn ghi chi tiết phiếu mượn này không?") != DialogResult.OK) return;

            PhieuMuon phieu = bdsPhieuMuon.Current as PhieuMuon;
            string maPM = phieu.MaPhieuMuon;
            try
            {
                if (option)
                {
                    ChiTietPhieuMuon chiTiet = new ChiTietPhieuMuon()
                    {
                        MaPhieuMuon = maPM,
                        MaSach = maSach,
                        TrangThai = false
                    };
                    Data.Instance.ChiTietPhieuMuon.Add(chiTiet);
                    book.TrangThai = false;
                }
                Data.Instance.SaveChanges();
                LoadData();
                bdsPhieuMuon.Position = viTriPM;
                XDialog.Inform("Đã ghi thông tin chi tiết phiếu mượn vào cơ sở dữ liệu!");

            }
            catch (Exception ex)
            {
                XDialog.Error("Đã xảy ra lỗi khi ghi chi tiết phiếu mượn!\n" + ex.Message);
                LoadData();
            }
            //ChangeUpdateMode_CTPM(false);
        }

        private void btnHuyCTPM_Click(object sender, EventArgs e)
        {
            bdsCTPM.CancelEdit();
            bdsCTPM.Position = viTriCTPM;
            ChangeUpdateMode_CTPM(false);
        }

        private void btnTaiCTPM_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}