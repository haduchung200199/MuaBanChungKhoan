using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MuaBanChungKhoan
{
    public partial class frm_Main : DevExpress.XtraEditors.XtraForm
    {
        public frm_Main()
        {
            InitializeComponent();
        }


        private void btn_LamLai_Click(object sender, EventArgs e)
        {
            tb_MaCP.ResetText();
            se_KL.Value = 0;
            se_Gia.Value = 0;
            cb_MuaBan.SelectedIndex=0;
        }

        private void btn_MuaBan_Click(object sender, EventArgs e)
        {
            String Message1 = "", Message2 = "", Message = "";
            String MaCK = tb_MaCP.Text;
            if (MaCK == "")
            {
                Message1 = "Mã chứng khoán";
            }
            if (Message1 != "")
            {
                Message1 = Message1 + " không được để trống !!!";
            }
            if (se_KL.Value == 0)
            {
                Message2 = Message2 + "Khối lượng";
            }
            if (se_Gia.Value == 0)
            {
                if (Message2 != "")
                {
                    Message2 = Message2 + ", ";
                }
                Message2 = Message2 + "Giá";
            }
            if(Message2 != "")
            {
                Message2 = Message2 + " Không hợp lệ!!!!";
            }
            if(Message1 !="" && Message2 != "")
            {
                Message = Message1 + " " + Message2;
            }
            else
            {
                Message = "Giao dịch thành công!!";
            }
            MessageBox.Show(Message);
        }

        private void cb_MuaBan_SelectedIndexChanged(object sender, EventArgs e)
        {
            btn_MuaBan.Text = cb_MuaBan.SelectedItem.ToString();
        }

        private void frm_Main_Load(object sender, EventArgs e)
        {
            cb_LoaiLenh.Items.Add("Lệnh khớp liên tục");
            cb_LoaiLenh.SelectedIndex = 0;
            cb_Lenh.Items.Add("LO");
            cb_Lenh.SelectedIndex = 0;
            cb_MuaBan.Items.Add("Mua");
            cb_MuaBan.Items.Add("Bán");
            cb_MuaBan.SelectedIndex = 0;

        }

    }
}
