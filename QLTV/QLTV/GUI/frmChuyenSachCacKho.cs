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
    public partial class frmChuyenSachCacKho : DevExpress.XtraEditors.XtraForm
    {
        public frmChuyenSachCacKho()
        {
            InitializeComponent();
        }

        private void LoadKho1()
        {
            if (lkKho1.EditValue != null)
            {
                if (lkKho1.EditValue == lkKho2.EditValue)
                {
                    XDialog.Error("Đã hiển thị sách trong kho này! Vui lòng chọn kho khác!");
                    lkKho1.EditValue = null;
                    bdsSach.DataSource = null;
                }
                else
                {
                    string maKho = lkKho1.EditValue.ToString();
                    Kho kho = Data.Instance.Kho.Find(maKho);
                    bdsSach.DataSource = kho.Sach.ToList();
                }
            }
            btnChuyenXuong.Enabled = bdsSach.Count > 0;
        }

        private void LoadKho2()
        {

            if (lkKho2.EditValue != null)
            {
                if (lkKho2.EditValue == lkKho1.EditValue)
                {
                    XDialog.Error("Đã hiển thị sách trong kho này! Vui lòng chọn kho khác!");
                    lkKho2.EditValue = null;
                    bdsSach2.DataSource = null;
                }
                else
                {
                    string maKho = lkKho2.EditValue.ToString();
                    Kho kho = Data.Instance.Kho.Find(maKho);
                    bdsSach2.DataSource = kho.Sach.ToList();
                }
            }
            btnChuyenLen.Enabled = bdsSach2.Count > 0;
        }

        private void LoadData()
        {
            bdsKho.DataSource = Data.Instance.Kho.ToList();
            bdsKho2.DataSource = Data.Instance.Kho.ToList();
            LoadKho1();
            LoadKho2();
        }

        private void frmChuyenSachCacKho_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void lkKho1_EditValueChanged(object sender, EventArgs e)
        {
            LoadKho1();
        }

        private void lkKho2_EditValueChanged(object sender, EventArgs e)
        {
            LoadKho2();
        }

        private void gvSach1_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
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

        private void gvSach2_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
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

        private void btnChuyenXuong_Click(object sender, EventArgs e)
        {
            Sach book = bdsSach.Current as Sach;
            if (lkKho2.EditValue == null)
            {
                XDialog.Error("Bạn chưa chọn kho cần chuyển sách tới!");
                return;
            }
            string maKho = lkKho2.EditValue.ToString();
            Kho kho = Data.Instance.Kho.Find(maKho);
            book.Kho = kho;
            try
            {
                Data.Instance.SaveChanges();

            }
            catch (Exception ex)
            {
                XDialog.Error("Đã xảy ra lỗi khi chuyển sách!\n" + ex.Message);
            }
            LoadData();
        }

        private void btnChuyenLen_Click(object sender, EventArgs e)
        {
            Sach book = bdsSach2.Current as Sach;
            if (lkKho1.EditValue == null)
            {
                XDialog.Error("Bạn chưa chọn kho cần chuyển sách tới!");
                return;
            }
            string maKho = lkKho1.EditValue.ToString();
            Kho kho = Data.Instance.Kho.Find(maKho);
            book.Kho = kho;
            try
            {
                Data.Instance.SaveChanges();

            }
            catch (Exception ex)
            {
                XDialog.Error("Đã xảy ra lỗi khi chuyển sách!\n" + ex.Message);
            }
            LoadData();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}