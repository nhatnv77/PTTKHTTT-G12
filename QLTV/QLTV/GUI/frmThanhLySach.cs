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
    public partial class frmThanhLySach : DevExpress.XtraEditors.XtraForm
    {
        public frmThanhLySach()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            bdsKho.DataSource = Data.Instance.Kho.ToList();
            bdsDoiTac.DataSource = Data.Instance.DoiTac.Where(d => d.LaNhaThanhLy == true).ToList();
            dateNgayThanhLy.DateTime = DateTime.Now;

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
                btnThanhLySach.Enabled = bdsSach.Count > 0;
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

        private void btnThanhLySach_Click(object sender, EventArgs e)
        {
            if (lkKho.EditValue == null)
            {
                XDialog.Error("Bạn chưa chọn kho chứa sách cần thanh lý!");
                return;
            }
            if (lkNhaTL.EditValue == null)
            {
                XDialog.Error("Bạn chưa chọn nhà thanh lý sách");
                return;
            }

            if (XDialog.Confirm("Bạn có chắc muốn thanh lý sách đã chọn không?") != DialogResult.OK)
            {
                return;
            }

            string maKho = lkKho.EditValue.ToString();
            Kho kho = Data.Instance.Kho.Find(maKho);
            DateTime ngayThanhLy = dateNgayThanhLy.DateTime;
            string maNhaTL = lkNhaTL.EditValue.ToString();
            try
            {
                // Lấy đối tượng sách cần thanh lý
                Sach book = bdsSach.Current as Sach;
                // Trạng thái => false?
                // ...
                // Thêm vào chi tiết thanh lý
                ChiTietThanhLy chiTiet = new ChiTietThanhLy()
                {
                    Sach = book,
                    MaNhaThanhLy = maNhaTL,
                    NgayThanhLy = ngayThanhLy
                };
                Data.Instance.ChiTietThanhLy.Add(chiTiet);
                // Xóa khỏi kho tương ứng
                kho.Sach.Remove(book);
                // Lưu thay đổi
                Data.Instance.SaveChanges();
                LoadData();
                XDialog.Inform("Đã thanh lý sách thành công!");
            }
            catch (Exception ex)
            {
                XDialog.Error("Đã có lỗi xảy ra khi thanh lý sách!\n" + ex.Message);
                return;
            }
        }

        private void dateNgayNhap_Enter(object sender, EventArgs e)
        {
            dateNgayThanhLy.Properties.MaxValue = System.DateTime.Today;
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