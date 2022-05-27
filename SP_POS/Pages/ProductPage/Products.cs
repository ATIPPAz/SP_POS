using SP_POS.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SP_POS.Pages.ProductPage
{
  public partial class Products : UserControl
  {
    DataTable dt = new DataTable();
    public Products()
    {
      InitializeComponent();
      SetType();
      SetBrand();
      SetStatus();
      Addtable();
    }
    void SetType()
    {
      Sql sql = new Sql();
      var data = sql.Select("Select TypeID,TypeName from [dbo].[ProductTypes]");
            comboType.ValueMember = "TypeID";
            comboType.DisplayMember = "TypeName";
            comboType.DataSource = data;
            cbProdType.ValueMember = "TypeID";
      cbProdType.DisplayMember = "TypeName";
      cbProdType.DataSource = data;
    }
    void SetBrand()
    {
      Sql sql = new Sql();
      var data = sql.Select("Select BrandID, BrandName from [dbo].[Brands]");
      cbProdBrand.ValueMember = "BrandID";
      cbProdBrand.DisplayMember = "BrandName";
      cbProdBrand.DataSource = data;
            comboBrand.ValueMember = "BrandID";
            comboBrand.DisplayMember = "BrandName";
            comboBrand.DataSource = data;
        }
    void SetStatus()
    {
      Sql sql = new Sql();
      var data = sql.Select("Select ProdStatusID,ProdStatus from [dbo].[ProductStatuses]");
      cbProdStatus.ValueMember = "ProdStatusID";
      cbProdStatus.DisplayMember = "ProdStatus";
      cbProdStatus.DataSource = data;
            comboStatus.ValueMember = "ProdStatusID";
            comboStatus.DisplayMember = "ProdStatus";
            comboStatus.DataSource = data;
        }
    void Addtable()
    {
      Sql sql = new Sql();
      var data = sql.Select("Select ProdDetailID,ProdCost,BrandID as ProdBrand,ProdStatusID  as ProdStatus,TypeID as ProdType,Annotation,ProdID,ProdName,ProdPrice,ProdDest,ProdQty,ProdImage from [dbo].[ProductData]");
      DatagridviewProduct.DataSource = data;
      dt = data;
    }

    private void DatagridviewProduct_CellValueChanged(object sender, DataGridViewCellEventArgs e)
    {
            try
            {
                if (DatagridviewProduct.CurrentRow != null)
                {

                    DataGridViewRow dgv = DatagridviewProduct.CurrentRow;
                    Sql sql = new Sql();
                    string[] column;
                    object[] value;
                    if (dgv.Cells["txtProdID"].Value != DBNull.Value)
                    {
                        if (MessageBox.Show("กรุณากดยืนยันเพื่อแก้ไขข้อมูล", "ต้องการแก้ไขหรือไม่", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                        {
                            Console.WriteLine(dgv.Cells["txtProdID"].Value.ToString());
                            column = new string[]{
                        "@ProdID",
                        "@ProdName",
                        "@ProdPrice",
                        "@ProdDest",
                        "@ProdQty",
                        "@ProdDetailID" ,
                        "@ProdImage" ,
                        "@ProdCost" ,
                        "@BrandID" ,
                        "@ProdStatusID" ,
                        "@TypeID" ,
                        "@Annotation"
                    };
                            value = new object[]{
                        dgv.Cells["txtProdID"].Value.ToString(),
                        dgv.Cells["txtProdName"].Value.ToString(),
                        Convert.ToInt32(dgv.Cells["txtProdPrice"].Value),
                        dgv.Cells["txtProdDest"].Value.ToString(),
                        Convert.ToInt32(dgv.Cells["txtProdQty"].Value),
                        dgv.Cells["txtProdDetailID"].Value.ToString(),
                        dgv.Cells["txtProdImage"].Value.ToString(),
                        Convert.ToInt32(dgv.Cells["txtProdCost"].Value),
                        dgv.Cells["cbProdBrand"].Value.ToString(),
                        dgv.Cells["cbProdStatus"].Value.ToString(),
                        dgv.Cells["cbProdType"].Value.ToString(),
                        dgv.Cells["txtAnnotation"].Value.ToString(),
                    };
                            sql.Update("ProductEdit", column, value);
                            Addtable();
                        }

                    }

                    else
                    {
                        Console.WriteLine("sdasda");
                       
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("กรุณาตรวจสอบค่าที่กรอกเข้ามาอีกครั้ง", "ข้อมูลที่กรอกผิดรูปแบบ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Addtable();
            }


        }

        private void SearchBartxt_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (e.KeyChar == (char)13)
      {
        if (!String.IsNullOrEmpty(SearchBartxt.Text))
        {
          DataView dv = dt.DefaultView;
          dv.RowFilter = String.Format("ProdName like '%{0}%'", SearchBartxt.Text);
          DatagridviewProduct.DataSource = dv.ToTable();
        }
        else
        {
          Addtable();
        }

      }
    }

   

      
        


        private void AddProduct_Click(object sender, EventArgs e)
        {
           
            Sql sql = new Sql();
            string[] column;
            object[] value;
           
            if (!string.IsNullOrEmpty(textName.Text)&& !string.IsNullOrEmpty(textBPrice.Text)&&
                !string.IsNullOrEmpty(textDes.Text) &&! string.IsNullOrEmpty(textQty.Text) &&
                !string.IsNullOrEmpty(textImage.Text) && !string.IsNullOrEmpty(textCost.Text) &&
                !string.IsNullOrEmpty(comboBrand.SelectedValue.ToString()) && !string.IsNullOrEmpty(comboStatus.SelectedValue.ToString()) &&
                !string.IsNullOrEmpty(comboType.SelectedValue.ToString()) && !string.IsNullOrEmpty(textAnno.Text) )
            {
                Console.WriteLine("ss");
                if (MessageBox.Show("กรุณากดยืนยันเพื่อเพิ่มข้อมูล", "ต้องการเพิ่มข้อมูลหรือไม่?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    column = new string[]{
                        "@ProdName",
                        "@ProdPrice",
                        "@ProdDest",
                        "@ProdQty",
                        "@ProdImage" ,
                        "@ProdCost" ,
                        "@BrandID" ,
                        "@ProdStatusID" ,
                        "@TypeID" ,
                        "@Annotation"
                    };
                    value = new object[]{
                  textName.Text,
                        Convert.ToInt32(textBPrice.Text),
                        textDes.Text,
                        Convert.ToInt32(textQty.Text),
                       textImage.Text,
                        Convert.ToInt32(textCost.Text),
                        comboBrand.SelectedValue.ToString(),
                       comboStatus.SelectedValue.ToString(),
                       comboType.SelectedValue.ToString(),
                        textAnno.Text,
                    };
                    sql.Insert("ProductInsert", column, value);
                    
                    Addtable();
                }
            }
            else
            {
                MessageBox.Show("กรุณากรอกข้อมูลให้ตรบ");
            }
        }

        private void DatagridviewProduct_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            try
            {
                if (DatagridviewProduct.CurrentRow.Cells["txtProdID"].Value != DBNull.Value)
                {
                    if (MessageBox.Show("กรุณากดยืนยินเพื่อลบข้อมูล", "ต้องการลบหรือไม่", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        Sql delete = new Sql();
                        string id = DatagridviewProduct.CurrentRow.Cells["txtProdID"].Value.ToString();
                        delete.Delete("ProductDelete", "@ProdID", id);
                    }
                }
            }
          catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
