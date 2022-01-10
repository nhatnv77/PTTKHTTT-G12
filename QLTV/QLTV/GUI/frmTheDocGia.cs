using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using QLTV.DAO;
using QLTV.Entity;
using QLTV.Util;

namespace QLTV.GUI
{
    public partial class frmTheDocGia : DevExpress.XtraEditors.XtraForm
    {
        private int position = 0;
        private bool option; // true: thêm; false: sửa

        public frmTheDocGia()
        {
            InitializeComponent();
        }

        private void Binding()
        {
            TheDocGia current = bdsTheDocGia.Current as TheDocGia;
            if (current != null)
            {
                lkDocGia.EditValue = current.MaDG;
            }
            else
            {
                lkDocGia.EditValue = null;
            }
        }

        private void LoadData()
        {
            bdsDocGia.DataSource = Data.Instance.DocGia.ToList();
            bdsTheDocGia.DataSource = Data.Instance.TheDocGia.ToList();
            ChangeModeUpdate(false);
            Binding();
        }

        private void frmKho_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void ChangeModeUpdate(bool isUpdating)
        {
            btnThem.Enabled = btnReload.Enabled = btnThoat.Enabled = nvgt.Enabled = !isUpdating;
            btnXoa.Enabled = btnSua.Enabled = !isUpdating && (bdsTheDocGia.Count > 0);
            btnGhi.Enabled = btnHuy.Enabled = isUpdating;
            gcTheDG.Enabled = !isUpdating;
            groupTheDG.Enabled = isUpdating;
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            position = bdsTheDocGia.Position;
            option = true;
            bdsTheDocGia.AddNew();
            txtMaTheDG.Text = CodeGenerator.SinhMaTheDocGia();
            ckTrangThai.Checked = true;
            ckTrangThai.ReadOnly = true;
            bdsTheDocGia.EndEdit();
            ChangeModeUpdate(true);
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string maTheDG = txtMaTheDG.Text.Trim();
            if (lkDocGia.EditValue == null)
            {
                XDialog.Error("Bạn chưa chọn độc giả!");
                lkDocGia.Focus();
                return;
            }
            string maDG = lkDocGia.EditValue.ToString();

            if (option)
            {
                DocGia dg = Data.Instance.DocGia.Find(maDG);
                if (dg.TheDocGia.Where(t => t.TrangThai == true).ToList().Count > 0)
                {
                    XDialog.Error("Không thể lập thẻ độc giả cho độc giả này vì " +
                        "độc giả này có thẻ độc giả còn hạn!");
                    lkDocGia.Focus();
                    return;
                }
            }

            if (dateNgayLapThe.DateTime == DateTime.MinValue)
            {
                XDialog.Error("Bạn chưa chọn ngày lập thẻ!");
                dateNgayLapThe.Focus();
                return;
            }
            DateTime ngayLapThe = dateNgayLapThe.DateTime;
            if (dateNgayHetHan.DateTime == DateTime.MinValue)
            {
                XDialog.Error("Bạn chưa chọn ngày hết hạn!");
                dateNgayHetHan.Focus();
                return;
            }
            DateTime ngayHetHan = dateNgayHetHan.DateTime;
            int soLuongMuonToiDa = (int)spinSoLuongMuonToiDa.Value;
            bool trangThai = ckTrangThai.Checked;

            if (option)
            {
                TheDocGia the = new TheDocGia()
                {
                    MaTheDG = maTheDG,
                    MaDG = maDG,
                    NgayLapThe = ngayLapThe,
                    NgayHetHan = ngayHetHan,
                    SoLuongMuonToiDa = soLuongMuonToiDa,
                    TrangThai = trangThai
                };
                Data.Instance.TheDocGia.Add(the);
            }
            else
            {
                TheDocGia the = Data.Instance.TheDocGia.Find(maTheDG);
                the.MaDG = maDG;
                the.NgayLapThe = ngayLapThe;
                the.NgayHetHan = ngayHetHan;
                the.SoLuongMuonToiDa = soLuongMuonToiDa;
                the.TrangThai = trangThai;
            }
            Data.Instance.SaveChanges();
            LoadData();
            XDialog.Inform("Đã lưu thông tin thẻ độc giả vào cơ sở dữ liệu!");
            ChangeModeUpdate(false);
        }

        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (option)
            {
                bdsTheDocGia.RemoveCurrent();
            }
            bdsTheDocGia.Position = position;
            ChangeModeUpdate(false);
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadData();
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            position = bdsTheDocGia.Position;
            option = false;
            ckTrangThai.ReadOnly = false;
            ChangeModeUpdate(true);
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string maTheDG = txtMaTheDG.Text.Trim();
            TheDocGia the = Data.Instance.TheDocGia.Find(maTheDG);
            if (the.PhieuMuon.Count > 0)
            {
                XDialog.Error("Không thể xóa thẻ độc giả này vì đã có phiếu mượn lập cho thẻ này!");
                return;
            }
            if (the.PhieuTra.Count > 0)
            {
                XDialog.Error("Không thể xóa thẻ độc giả này vì đã có phiếu trả lập cho thẻ này!");
                return;
            }
            if (XDialog.Confirm("Bạn có chắc muốn xóa thẻ độc giả này không?") != DialogResult.OK)
            {
                return;
            }
            try
            {
                Data.Instance.TheDocGia.Remove(the);
                Data.Instance.SaveChanges();
            }
            catch (Exception ex)
            {
                XDialog.Error("Đã có lỗi xảy ra khi xóa thẻ độc giả!\n" + ex.Message);
                return;
            }
            LoadData();
        }

        private void dateNgayLapThe_Enter(object sender, EventArgs e)
        {
            dateNgayLapThe.Properties.MaxValue = System.DateTime.Today;
        }

        private void dateNgayHetHan_Enter(object sender, EventArgs e)
        {
            dateNgayHetHan.Properties.MinValue = dateNgayLapThe.DateTime;
            dateNgayHetHan.Properties.MaxValue = DateTime.MaxValue;
        }

        private void gvTheDG_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            Binding();
        }
    }
}