using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _111_1MIDDEMO1 {
    public partial class Q2 : System.Web.UI.Page {
        string[] s_City = new string[2] { "台北市", "新北市" };
        string[,] s_Area = new string[2, 3] {
            {"中正區", "文山區", "大安區"},
            {"淡水區", "石碇區", "土城區"}
        };

        protected void Page_Load(object sender, EventArgs e) {
            if (!IsPostBack) {
                for (int i_Ct = 0; i_Ct < s_City.Length; i_Ct++) {
                    ListItem a_C = new ListItem();
                    a_C.Text = s_City[i_Ct];
                    a_C.Value = s_City[i_Ct];

                    dpl_City.Items.Add(a_C);
                }
                mt_GenSecondList();
            }

        }

        protected void dpl_City_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void mt_GenSecondList()
        {
            Response.Write();
            Response.Write(dpl_City.SelectedIndex);
        }
    }
}