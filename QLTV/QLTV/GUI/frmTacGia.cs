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
    public partial class frmTacGia : DevExpress.XtraEditors.XtraForm
    {
        private int position = 0;
        private bool option; // true: thêm; false: sửa

        public frmTacGia()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            bdsTacGia.DataSource = Data.Instance.TacGia.ToList();
            ChangeModeUpdate(false);
        }

        private void frmKho_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void ChangeModeUpdate(bool isUpdating)
        {
            btnThem.Enabled = btnReload.Enabled = btnThoat.Enabled = nvgt.Enabled = !isUpdating;
            btnXoa.Enabled = btnSua.Enabled = !isUpdating && (bdsTacGia.Count > 0);
            btnGhi.Enabled = btnHuy.Enabled = isUpdating;
            gcKho.Enabled = !isUpdating;
            groupKho.Enabled = isUpdating;
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            position = bdsTacGia.Position;
            option = true;
            bdsTacGia.AddNew();
            txtMaTacGia.Text = CodeGenerator.SinhMaTacGia();
            bdsTacGia.EndEdit();
            ChangeModeUpdate(true);
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string maTacGia = txtMaTacGia.Text.Trim();
            string ho = txtHo.Text.Trim();
            string ten = txtTen.Text.Trim();
            DateTime ngaySinh = dateNgaySinh.DateTime.Date;
            DateTime ngayMat = dateNgayMat.DateTime.Date;
            string queQuan = txtQueQuan.Text.Trim();
            string moTa = txtMoTa.Text.Trim();

            if (string.IsNullOrEmpty(ho))
            {
                XDialog.Error("Bạn chưa nhập họ của tác giả!");
                txtHo.Focus();
                return;
            }
            if (string.IsNullOrEmpty(ten))
            {
                XDialog.Error("Bạn chưa nhập tên của tác giả!");
                txtTen.Focus();
                return;
            }

            if (option)
            {
                TacGia writer = new TacGia()
                {
                    MaTacGia = maTacGia,
                    Ho = ho,
                    Ten = ten,
                    NgaySinh = ngaySinh,
                    NgayMat = ngayMat,
                    QueQuan = queQuan,
                    MoTa = moTa,
                };
                Data.Instance.TacGia.Add(writer);
            }
            else
            {
                TacGia writer = Data.Instance.TacGia.Find(maTacGia);
                writer.Ho = ho;
                writer.Ten = ten;
                writer.NgaySinh = ngaySinh;
                writer.NgayMat = ngayMat;
                writer.QueQuan = queQuan;
                writer.MoTa = moTa;
            }
            Data.Instance.SaveChanges();
            LoadData();
            XDialog.Inform("Đã lưu thông tin tác giả vào cơ sở dữ liệu!");
            ChangeModeUpdate(false);
        }

        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (option)
            {
                bdsTacGia.RemoveCurrent();
            }
            bdsTacGia.Position = position;
            ChangeModeUpdate(false);
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadData();
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            position = bdsTacGia.Position;
            option = false;
            ChangeModeUpdate(true);
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (XDialog.Confirm("Bạn có chắc muốn xóa tác giả này không?") != DialogResult.OK)
            {
                return;
            }
            string maTG = txtMaTacGia.Text.Trim();
            Data.Instance.TacGia.Remove(Data.Instance.TacGia.Find(maTG));
            Data.Instance.SaveChanges();
            LoadData();
        }

        private void dateNgaySinh_Enter(object sender, EventArgs e)
        {
            dateNgaySinh.Properties.MaxValue = System.DateTime.Today;
        }

        private void dateNgayMat_Enter(object sender, EventArgs e)
        {
            dateNgayMat.Properties.MaxValue = System.DateTime.Today;
        }
    }
}