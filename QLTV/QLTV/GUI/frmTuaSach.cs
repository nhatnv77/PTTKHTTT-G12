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
using System.Collections;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraEditors.Repository;

namespace QLTV.GUI
{
    public partial class frmTuaSach : DevExpress.XtraEditors.XtraForm
    {
        private int position = 0;
        private bool option; // true: thêm; false: sửa

        public frmTuaSach()
        {
            InitializeComponent();
        }

        //string ImageDir = @"Images\Books\";
        //Hashtable Images = new Hashtable();

        private void gridView1_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {
            if (e.Column.FieldName == "Image" && e.IsGetData)
            {
                GridView view = sender as GridView;

                string fileName = (string)view.GetRowCellValue(e.ListSourceRowIndex, "HinhAnh");
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

        private void LoadData()
        {
            bdsTheLoai.DataSource = Data.Instance.TheLoai.ToList();
            bdsTacGia.DataSource = Data.Instance.TacGia.ToList();
            bdsDoiTac.DataSource = Data.Instance.DoiTac.Where(d => d.LaNhaXuatBan == true).ToList();
            if (lkChonTheLoai.EditValue != null)
            {
                string maTheLoai = lkChonTheLoai.EditValue.ToString();
                bdsTuaSach.DataSource = Data.Instance.TuaSach.Where(t => t.MaTheLoai == maTheLoai).ToList();
            }
            ChangeModeUpdate(false);
            Binding();
        }

        private void Binding()
        {
            TuaSach current = bdsTuaSach.Current as TuaSach;
            if (current != null)
            {
                lkTheLoai.EditValue = current.MaTheLoai;
                lkTacGia.EditValue = current.MaTacGia;
                lkNhaXB.EditValue = current.MaNXB;
                if (string.IsNullOrEmpty(current.HinhAnh))
                {
                    picHinhAnh.Image = null;
                    return;
                }
                picHinhAnh.Image = Image.FromFile(DevExpress.Utils.FilesHelper
                    .FindingFileName(Application.StartupPath, ImageData.ImageDir + current.HinhAnh, false));
            }
            else
            {
                lkTheLoai.EditValue = lkTacGia.EditValue = lkNhaXB.EditValue = picHinhAnh.Image = null;
            }
        }

        private void frmKho_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void ChangeModeUpdate(bool isUpdating)
        {
            btnThem.Enabled = !(lkChonTheLoai.EditValue == null || isUpdating);
            btnReload.Enabled = btnThoat.Enabled = nvgt.Enabled = !isUpdating;
            btnXoa.Enabled = btnSua.Enabled = !isUpdating && (bdsTuaSach.Count > 0);
            btnGhi.Enabled = btnHuy.Enabled = isUpdating;
            gcTuaSach.Enabled = !isUpdating;
            groupTuaSach.Enabled = isUpdating;
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            position = bdsTuaSach.Position;
            option = true;
            bdsTuaSach.AddNew();
            txtMaISBN.Properties.ReadOnly = false;
            ChangeModeUpdate(true);
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string maISBN = txtMaISBN.Text.Trim();
            if (string.IsNullOrEmpty(maISBN))
            {
                XDialog.Error("Bạn chưa nhập mã ISBN!");
                txtMaISBN.Focus();
                return;
            }
            string tenSach = txtTenSach.Text.Trim();
            if (string.IsNullOrEmpty(tenSach))
            {
                XDialog.Error("Bạn chưa nhập tên sách!");
                txtTenSach.Focus();
                return;
            }
            if (lkTheLoai.EditValue == null)
            {
                XDialog.Error("Bạn chưa chọn thể loại!");
                lkTheLoai.Focus();
                return;
            }
            string maTheLoai = lkTheLoai.EditValue.ToString();
            if (lkTacGia.EditValue == null)
            {
                XDialog.Error("Bạn chưa chọn tác giả!");
                lkTacGia.Focus();
                return;
            }
            string maTacGia = lkTacGia.EditValue.ToString();
            if (lkNhaXB.EditValue == null)
            {
                XDialog.Error("Bạn chưa chọn nhà xuất bản!");
                lkNhaXB.Focus();
                return;
            }
            string maNhaXB = lkNhaXB.EditValue.ToString();
            if (dateNgayXB.DateTime.Date == DateTime.MinValue)
            {
                XDialog.Error("Bạn chưa chọn ngày xuất bản");
                dateNgayXB.Focus();
                return;
            }
            DateTime ngayXB = dateNgayXB.DateTime;
            int soTrang = (int)spinSoTrang.Value;
            int chieuDai = (int)spinChieuDai.Value;
            int chieuRong = (int)spinChieuRong.Value;
            string chatLieuGiay = txtChatLieuGiay.Text.Trim();
            int giaTien = (int)spinGiaTien.Value;
            string moTa = txtMoTa.Text.Trim();
            string hinhAnh;
            string filePath = picHinhAnh.GetLoadedImageLocation();
            if (!string.IsNullOrEmpty(filePath))
            {
                hinhAnh = filePath.Substring(filePath.IndexOf(ImageData.ImageDir)
                    + ImageData.ImageDir.Length);
            }
            else
            {
                hinhAnh = (bdsTuaSach.Current as TuaSach).HinhAnh;
            }
            if (option)
            {
                TuaSach tuaSach = new TuaSach()
                {
                    MaISBN = maISBN,
                    TenSach = tenSach,
                    MaTheLoai = maTheLoai,
                    MaTacGia = maTacGia,
                    MaNXB = maNhaXB,
                    NgayXuatBan = ngayXB,
                    SoTrang = soTrang,
                    ChieuDai = chieuDai,
                    ChieuRong = chieuRong,
                    ChatLieuGiay = chatLieuGiay,
                    GiaTien = giaTien,
                    HinhAnh = hinhAnh,
                    MoTa = moTa,
                };
                Data.Instance.TuaSach.Add(tuaSach);
            }
            else
            {
                TuaSach tuaSach = Data.Instance.TuaSach.Find(maISBN);
                tuaSach.TenSach = tenSach;
                tuaSach.MaTheLoai = maTheLoai;
                tuaSach.MaTacGia = maTacGia;
                tuaSach.MaNXB = maNhaXB;
                tuaSach.NgayXuatBan = ngayXB;
                tuaSach.SoTrang = soTrang;
                tuaSach.ChieuDai = chieuDai;
                tuaSach.ChieuRong = chieuRong;
                tuaSach.ChatLieuGiay = chatLieuGiay;
                tuaSach.GiaTien = giaTien;
                tuaSach.HinhAnh = hinhAnh;
                tuaSach.MoTa = moTa;
            }
            Data.Instance.SaveChanges();
            LoadData();
            XDialog.Inform("Đã lưu thông tin tựa sách vào cơ sở dữ liệu!");
            ChangeModeUpdate(false);
        }

        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsTuaSach.CancelEdit();
            bdsTuaSach.Position = position;
            ChangeModeUpdate(false);
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadData();
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            position = bdsTuaSach.Position;
            option = false;
            txtMaISBN.Properties.ReadOnly = true;
            ChangeModeUpdate(true);
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (XDialog.Confirm("Bạn có chắc muốn xóa tựa sách này không?") != DialogResult.OK)
            {
                return;
            }
            string maISBN = txtMaISBN.Text.Trim();
            Data.Instance.TuaSach.Remove(Data.Instance.TuaSach.Find(maISBN));
            Data.Instance.SaveChanges();
            LoadData();
        }

        private void lkTheLoai_EditValueChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        private void gvTuaSach_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            Binding();
        }

        private void dateNgayXB_Enter(object sender, EventArgs e)
        {
            dateNgayXB.Properties.MaxValue = System.DateTime.Today;
        }
    }
}