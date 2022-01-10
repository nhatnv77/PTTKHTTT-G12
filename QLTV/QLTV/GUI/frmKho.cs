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
    public partial class frmKho : DevExpress.XtraEditors.XtraForm
    {
        private int position = 0;
        private bool option; // true: thêm; false: sửa

        public frmKho()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            bdsKho.DataSource = Data.Instance.Kho.ToList();
            ChangeModeUpdate(false);
        }

        private void frmKho_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void ChangeModeUpdate(bool isUpdating)
        {
            btnThem.Enabled = btnReload.Enabled = btnThoat.Enabled = nvgt.Enabled = !isUpdating;
            btnXoa.Enabled = btnSua.Enabled = !isUpdating && (bdsKho.Count > 0);
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
            position = bdsKho.Position;
            option = true;
            bdsKho.AddNew();
            txtMaKho.Text = CodeGenerator.SinhMaKho();
            bdsKho.EndEdit();
            ChangeModeUpdate(true);
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string maKho = txtMaKho.Text.Trim();
            string tenKho = txtTenKho.Text.Trim();
            string viTri = txtViTri.Text.Trim();
            string moTa = txtMoTa.Text.Trim();
            bool trangThai = ckTrangThai.Checked;

            if (string.IsNullOrEmpty(maKho))
            {
                XDialog.Error("Bạn chưa nhập mã kho!");
                txtMaKho.Focus();
                return;
            }
            if (string.IsNullOrEmpty(tenKho))
            {
                XDialog.Error("Bạn chưa nhập tên kho!");
                txtTenKho.Focus();
                return;
            }

            if (option)
            {
                Kho kho = new Kho()
                {
                    MaKho = maKho,
                    TenKho = tenKho,
                    ViTri = viTri,
                    MoTa = moTa,
                    TrangThai = trangThai
                };
                Data.Instance.Kho.Add(kho);
                
            }
            else
            {
                Kho kho = Data.Instance.Kho.Find(maKho);
                kho.TenKho = tenKho;
                kho.ViTri = viTri;
                kho.MoTa = moTa;
                kho.TrangThai = trangThai;
            }
            Data.Instance.SaveChanges();
            LoadData();
            XDialog.Inform("Đã lưu thông tin kho vào cơ sở dữ liệu!");
            ChangeModeUpdate(false);
        }

        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (option)
            {
                bdsKho.RemoveCurrent();
            }
            bdsKho.Position = position;
            ChangeModeUpdate(false);
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadData();
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            position = bdsKho.Position;
            option = false;
            ChangeModeUpdate(true);
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (XDialog.Confirm("Bạn có chắc muốn xóa kho này không?") != DialogResult.OK)
            {
                return;
            }
            string maKho = txtMaKho.Text.Trim();
            Data.Instance.Kho.Remove(Data.Instance.Kho.Find(maKho));
            Data.Instance.SaveChanges();
            LoadData();
        }
    }
}