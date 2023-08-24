using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.XPath;

namespace XML
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                var xPathDoc = new System.Xml.XPath.XPathDocument(Server.MapPath("BankData.xml"));
                XPathNavigator xNavigator;
                XPathNodeIterator iterator;

                xNavigator = xPathDoc.CreateNavigator();
                iterator = xNavigator.Select("banco/cuenta/@cuentanum");
                while (iterator.MoveNext())
                {
                    DropDownList1.Items.Remove(iterator.Current.Value);
                    DropDownList1.Items.Add(iterator.Current.Value);
                }

                iterator = xNavigator.Select("banco/cuenta/cuentanombre");
                while (iterator.MoveNext())
                {
                    DropDownList2.Items.Remove(iterator.Current.Value);
                    DropDownList2.Items.Add(iterator.Current.Value);
                }
            }
            
        }

        protected void button1_Click(object sender, EventArgs e)
        {
            
            string cuenta = DropDownList1.SelectedItem.Text.Trim();
            string titular = DropDownList2.SelectedItem.Text.Trim();

            var xPathDoc = new System.Xml.XPath.XPathDocument(Server.MapPath("BankData.xml"));
            XPathNavigator xNavigator;
            XPathNodeIterator iterator;

            xNavigator = xPathDoc.CreateNavigator();

            iterator = xNavigator.Select("banco/cuenta[@cuentanum= '" + cuenta + "']/cuentasaldo");
            iterator.MoveNext();
            textbox1.Text = iterator.Current.Value;

            iterator = xNavigator.Select("banco/cuenta[cuentanombre= '" + titular + "']/cuentasaldo");
            iterator.MoveNext();
            textbox2.Text = iterator.Current.Value;


        }
    }
}