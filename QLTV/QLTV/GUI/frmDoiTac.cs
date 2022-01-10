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
    public partial class frmDoiTac : DevExpress.XtraEditors.XtraForm
    {
        private int position = 0;
        private bool option; // true: thêm; false: sửa

        public frmDoiTac()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            bdsDoiTac.DataSource = Data.Instance.DoiTac.ToList();
            ChangeModeUpdate(false);
        }

        private void frmKho_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void ChangeModeUpdate(bool isUpdating)
        {
            btnThem.Enabled = btnReload.Enabled = btnThoat.Enabled = nvgt.Enabled = !isUpdating;
            btnXoa.Enabled = btnSua.Enabled = !isUpdating && (bdsDoiTac.Count > 0);
            btnGhi.Enabled = btnHuy.Enabled = isUpdating;
            gcKho.Enabled = !isUpdating;
            groupDoiTac.Enabled = isUpdating;
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            position = bdsDoiTac.Position;
            option = true;
            bdsDoiTac.AddNew();
            txtMaDoiTac.Text = CodeGenerator.SinhMaDoiTac();
            bdsDoiTac.EndEdit();
            ChangeModeUpdate(true);
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string maDoiTac = txtMaDoiTac.Text.Trim();
            string tenDoiTac = txtTenDoiTac.Text.Trim();
            string diaChi = txtDiaChi.Text.Trim();
            string sdt = txtSDT.Text.Trim();
            string email = txtEmail.Text.Trim();
            string moTa = txtMoTa.Text.Trim();
            bool laNXB = ckLaNXB.Checked;
            bool laNCC = ckLaNCC.Checked;
            bool laNTL = ckLaNTL.Checked;

            if (string.IsNullOrEmpty(tenDoiTac))
            {
                XDialog.Error("Bạn chưa nhập tên đối tác!");
                txtTenDoiTac.Focus();
                return;
            }

            if (option)
            {
                DoiTac dt = new DoiTac()
                {
                    MaDoiTac = maDoiTac,
                    TenDoiTac = tenDoiTac,
                    DiaChi = diaChi,
                    SDT = sdt,
                    Email = email,
                    MoTa = moTa,
                    LaNhaXuatBan = laNXB,
                    LaNhaCungCap = laNCC,
                    LaNhaThanhLy = laNTL
                };
                Data.Instance.DoiTac.Add(dt);
            }
            else
            {
                DoiTac dt = Data.Instance.DoiTac.Find(maDoiTac);
                dt.TenDoiTac = tenDoiTac;
                dt.DiaChi = diaChi;
                dt.DiaChi = diaChi;
                dt.SDT = sdt;
                dt.Email = email;
                dt.MoTa = moTa;
                dt.LaNhaXuatBan = laNXB;
                dt.LaNhaCungCap = laNCC;
                dt.LaNhaThanhLy = laNTL;
            }
            Data.Instance.SaveChanges();
            LoadData();
            XDialog.Inform("Đã lưu thông tin đối tác vào cơ sở dữ liệu!");
            ChangeModeUpdate(false);
        }

        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (option)
            {
                bdsDoiTac.RemoveCurrent();
            }
            bdsDoiTac.Position = position;
            ChangeModeUpdate(false);
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadData();
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            position = bdsDoiTac.Position;
            option = false;
            ChangeModeUpdate(true);
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (XDialog.Confirm("Bạn có chắc muốn xóa đối tác này không?") != DialogResult.OK)
            {
                return;
            }
            string maDoiTac = txtMaDoiTac.Text.Trim();
            Data.Instance.DoiTac.Remove(Data.Instance.DoiTac.Find(maDoiTac));
            Data.Instance.SaveChanges();
            LoadData();
        }
    }
}