using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Xml.Linq;
using System.Data;

namespace EffectiveSearchInXML
{
    /// <summary>
    /// Interaction logic for SearchAnyXML.xaml
    /// </summary>
    public partial class SearchAnyXML : Window
    {
        public SearchAnyXML()
        {
            InitializeComponent();
            txtXMLPath.Text = @"AppData\book.xml";
        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            dgSearchResults.ItemsSource = null;
            DataTable dtData = new DataTable("Contents");

            XElement XMLDocument = XElement.Load(txtXMLPath.Text.Trim());

            String NodeName = (XMLDocument.FirstNode as XElement).Name.ToString();
            String SearchText = txtSearchKey.Text.Trim().Equals("Enter your search key.") ? String.Empty : txtSearchKey.Text.Trim();

            foreach (XElement elemet in XMLDocument.Descendants().ElementAtOrDefault(0).Elements())
            {
                dtData.Columns.Add(elemet.Name.ToString());
            }
            DataView DataDisplay = dtData.DefaultView;
            int NodeIte = 0;
            foreach (XContainer node in XMLDocument.Nodes())
            {
                Boolean IsAddRecord = false;
                foreach (XElement element in node.Elements())
                {
                    IsAddRecord = element.Value.ToString().ToLower().Equals(SearchText.ToLower()) || (SearchText.Length == 0);
                    if (IsAddRecord)
                    {
                        break;
                    }
                }
                if (IsAddRecord)
                {
                    int ElementIte = 0;
                    foreach (XElement element in node.Elements())
                    {
                        if (DataDisplay.Count < NodeIte + 1)
                        {
                            DataDisplay.AddNew();
                        }
                        DataDisplay[NodeIte][ElementIte] = element.Value.ToString();
                        ElementIte++;
                    }
                    NodeIte++;
                }
            }
            dgSearchResults.ItemsSource = DataDisplay;
        }

        private void txtSearchKey_PreviewLostKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            txtSearchKey.Text = txtSearchKey.Text.Trim().Equals(String.Empty) ? "Enter your search key." : txtSearchKey.Text;
        }

        private void txtSearchKey_PreviewGotKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            txtSearchKey.Text = txtSearchKey.Text.Trim().Equals("Enter your search key.") ? String.Empty : txtSearchKey.Text;
        }
    }
}
