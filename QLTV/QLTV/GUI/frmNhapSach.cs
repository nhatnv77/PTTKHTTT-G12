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
    public partial class frmNhapSach : DevExpress.XtraEditors.XtraForm
    {
        public frmNhapSach()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            bdsKho.DataSource = Data.Instance.Kho.ToList();
            bdsDoiTac.DataSource = Data.Instance.DoiTac.Where(d => d.LaNhaCungCap == true).ToList();
            dateNgayNhap.DateTime = DateTime.Now;

            if (lkKho.EditValue == null)
            {
                pnlNhapLieu.Enabled = false;
                return;
            }
            else
            {
                string maKho = lkKho.EditValue.ToString();
                Kho kho = Data.Instance.Kho.Find(maKho);
                bdsSach.DataSource = kho.Sach.ToList();
                pnlNhapLieu.Enabled = true;
            }
        }

        private void frmNhapSach_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void lkKho_EditValueChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnNhapSach_Click(object sender, EventArgs e)
        {
            if (lkTuaSach.EditValue == null)
            {
                XDialog.Error("Bạn chưa chọn tựa sách nhập!");
                return;
            }
            if (lkKho.EditValue == null)
            {
                XDialog.Error("Bạn chưa chọn kho để nhập sách vào!");
                return;
            }
            if (lkNhaCC.EditValue == null)
            {
                XDialog.Error("Bạn chưa chọn nhà cung cấp sách");
                return;
            }
            string maKho = lkKho.EditValue.ToString();
            Kho kho = Data.Instance.Kho.Find(maKho);
            string maISBN = lkTuaSach.EditValue.ToString();
            int soLuong = (int)spinSoLuong.Value;
            DateTime ngayNhap = dateNgayNhap.DateTime;
            string maNhaCC = lkNhaCC.EditValue.ToString();
            try
            {
                for (int i = 0; i < soLuong; i++)
                {
                    // Tạo đối tượng sách mới trong hệ thống
                    Sach book = new Sach()
                    {
                        MaISBN = maISBN,
                        TrangThai = true
                    };
                    // Thêm vào chi tiết nhập
                    Data.Instance.Sach.Add(book);
                    ChiTietNhap chiTiet = new ChiTietNhap()
                    {
                        Sach = book,
                        MaNCC = maNhaCC,
                        NgayNhap = ngayNhap
                    };
                    Data.Instance.ChiTietNhap.Add(chiTiet);
                    // Thêm vào kho tương ứng
                    kho.Sach.Add(book);
                    // Lưu thay đổi cho mỗi quyển sách
                    Data.Instance.SaveChanges();
                }
                LoadData();
                XDialog.Inform("Đã nhập các sách mới vào kho thành công!");
            }
            catch (Exception ex)
            {
                XDialog.Error("Đã có lỗi xảy ra khi nhập sách!\n" + ex.Message);
                return;
            }
        }

        private void dateNgayNhap_Enter(object sender, EventArgs e)
        {
            dateNgayNhap.Properties.MaxValue = System.DateTime.Today;
        }

        private void gvNhapSach_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}