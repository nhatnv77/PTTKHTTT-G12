using DevExpress.XtraBars;
using QLTV.Entity;
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
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmMain()
        {
            InitializeComponent();
            ShowMdiChildren(typeof(frmDangNhap));
        }

        public void PhanQuyen(NhanVien emp)
        {
            lblMa.Caption = "MÃ: " + emp.MaNV;
            lblHoTen.Caption = "HỌ VÀ TÊN: " + emp.Ho + " " + emp.Ten;
            lblNhom.Caption = "NHÓM: " + emp.LoaiNV.TenLoaiNV;
            switch (emp.LoaiNV.MaLoaiNV)
            {
                case "TT":
                    rpThuThu.Visible = true;
                    break;
                case "TK":
                    rpThuKho.Visible = true;
                    break;
                case "QLDG":
                    rpQLDG.Visible = true;
                    rpBaoCao.Visible = true; 
                    rpBaoCao.Visible = true;
                    break;
            }
            rpHeThong.Visible = true;
        }

        public void HienThi(DocGia reader)
        {
            lblMa.Caption = "MÃ: " + reader.MaDG;
            lblHoTen.Caption = "HỌ VÀ TÊN: " + reader.Ho + " " + reader.Ten;
            lblNhom.Caption = "NHÓM: Độc giả";
            rpDocGia.Visible = true;
            rpHeThong.Visible = true;
        }

        private void ShowMdiChildren(Type fType)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == fType)
                {
                    f.Activate();
                    return;
                }
            }
            Form form = (Form)Activator.CreateInstance(fType);
            form.MdiParent = this;
            form.Show();
        }

        private void CloseAllMdiChildren()
        {
            foreach (Form f in this.MdiChildren)
            {
                f.Close();
            }
        }

        private void btnLogout_ItemClick(object sender, ItemClickEventArgs e)
        {
            lblMa.Caption = lblHoTen.Caption = "";
            rpThuKho.Visible = rpThuThu.Visible = rpQLDG.Visible 
                = rpDocGia.Visible = rpBaoCao.Visible = rpHeThong.Visible = false;
            CloseAllMdiChildren();
            ShowMdiChildren(typeof(frmDangNhap));
        }

        private void btnKho_ItemClick(object sender, ItemClickEventArgs e)
        {
            ShowMdiChildren(typeof(frmKho));
        }

        private void btnKhu_ItemClick(object sender, ItemClickEventArgs e)
        {
            ShowMdiChildren(typeof(frmKhu));
        }

        private void btnKe_ItemClick(object sender, ItemClickEventArgs e)
        {
            ShowMdiChildren(typeof(frmKe));
        }

        private void btnDoiTac_ItemClick(object sender, ItemClickEventArgs e)
        {
            ShowMdiChildren(typeof(frmDoiTac));
        }

        private void btnTuaSach_ItemClick(object sender, ItemClickEventArgs e)
        {
            ShowMdiChildren(typeof(frmTuaSach));
        }

        private void btnTheLoai_ItemClick(object sender, ItemClickEventArgs e)
        {
            ShowMdiChildren(typeof(frmTheLoai));
        }

        private void btnTacGia_ItemClick(object sender, ItemClickEventArgs e)
        {
            ShowMdiChildren(typeof(frmTacGia));
        }

        private void btnReportListReader_ItemClick(object sender, ItemClickEventArgs e)
        {

            Form frm = this.CheckExists(typeof(frmRpListReader));
            if (frm != null) frm.Activate();
            else
            {
                Form form = new frmRpListReader();
                form.Show();
            }
        }

        private void btnNhapSach_ItemClick(object sender, ItemClickEventArgs e)
        {
            ShowMdiChildren(typeof(frmNhapSach));
        }

        private void btnThanhLySach_ItemClick(object sender, ItemClickEventArgs e)
        {
            ShowMdiChildren(typeof(frmThanhLySach));
        }

        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == ftype)
                {
                    return f;
                }
            }
            return null;
        }

        private void btnReportListReaderCard_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FrmRpListReaderCard));
            if (frm != null) frm.Activate();
            else
            {
                Form form = new FrmRpListReaderCard();
                form.Show();
            }
        }

        private void btnChuyenSachKho_ItemClick(object sender, ItemClickEventArgs e)
        {
            ShowMdiChildren(typeof(frmChuyenSachCacKho));
        }

        private void btnChuyenSachKhoKe_ItemClick(object sender, ItemClickEventArgs e)
        {
            ShowMdiChildren(typeof(frmChuyenSachKhoKe));
        }

        private void btnChuyenSachKe_ItemClick(object sender, ItemClickEventArgs e)
        {
            ShowMdiChildren(typeof(frmChuyenSachCacKe));
        }

        private void btnDocGia_ItemClick(object sender, ItemClickEventArgs e)
        {
            ShowMdiChildren(typeof(frmDocGia));
        }

        private void btnTheDocGia_ItemClick(object sender, ItemClickEventArgs e)
        {
            ShowMdiChildren(typeof(frmTheDocGia));
        }

        private void btnMuonSach_ItemClick(object sender, ItemClickEventArgs e)
        {
            ShowMdiChildren(typeof(frmMuonSach));
        }

        private void btnViewBook_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmReadBook));
            if (frm != null) frm.Activate();
            else
            {
                Form form = new frmReadBook();
                form.MdiParent = this;
                form.Show();
            }
        }

        private void tuaSachBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tuaSachBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLTVDataSet);

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            this.qLTVDataSet.EnforceConstraints = false;
            this.tuaSachTableAdapter.Connection.ConnectionString 
                = this.theDocGiaTableAdapter.Connection.ConnectionString 
                = Program.connstr;
            // TODO: This line of code loads data into the 'qLTVDataSet.TheDocGia' table. You can move, or remove it, as needed.
            this.theDocGiaTableAdapter.Fill(this.qLTVDataSet.TheDocGia);
            // TODO: This line of code loads data into the 'qLTVDataSet.TuaSach' table. You can move, or remove it, as needed.
            this.tuaSachTableAdapter.Fill(this.qLTVDataSet.TuaSach);

        }

        private void theDocGiaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.theDocGiaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLTVDataSet);

        }

        private void tuaSachBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.tuaSachBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLTVDataSet);

        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            String ma = lblMa.ToString().Replace("MÃ:", "");
            Form frm = this.CheckExists(typeof(frmInfoReader));
            if (frm != null) frm.Activate();
            else
            {
                Form form = new frmInfoReader(ma);
                form.Show();
            }
        }

        private void btnListBookBorrowed_ItemClick(object sender, ItemClickEventArgs e)
        {
            String ma = lblMa.ToString().Replace("MÃ:", "");
            Form frm = this.CheckExists(typeof(frmListBookBorrowed));
            if (frm != null) frm.Activate();
            else
            {
                Form form = new frmListBookBorrowed(ma.Trim());
                form.Show();
            }
        }

        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
            String ma = lblMa.ToString().Replace("MÃ:", "");
            Form frm = this.CheckExists(typeof(frmReview));
            if (frm != null) frm.Activate();
            else
            {
                Form form = new frmReview(ma.Trim());
                form.Show();
            }
        }
    }
}