using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace JMGEngineCore
{
    public partial class FormHelloWorld : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnClick_Click(object sender, EventArgs e)
        {
            lblDisplay.Text = txtInput.Text; //클릭했을 때 txtInput의 내용을 그대로 출력(보여)함
            txtInput.Text = String.Empty; //다시 클릭 했을 때 공백을 출력(보여)함
        }
    }
}