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
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace EffectiveSearchInXML
{
	/// <summary>
	/// Interaction logic for SearchXML.xaml
	/// </summary>
	public partial class SearchXML : Window
	{
		public SearchXML()
		{
			InitializeComponent();
			ddlTableType.ItemsSource = new List<String>()
			{
				"Person",
				"Employee"
			};
			ddlTableType.SelectedIndex = 0;
		}

		private void txtSearchKey_PreviewGotKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
		{
			txtSearchKey.Text = txtSearchKey.Text.Trim().Equals("Enter your search key.") ? String.Empty : txtSearchKey.Text;
		}

		private void txtSearchKey_PreviewLostKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
		{
			txtSearchKey.Text = txtSearchKey.Text.Trim().Equals(String.Empty) ? "Enter your search key." : txtSearchKey.Text;
		}

		private void btnSearch_Click(object sender, RoutedEventArgs e)
		{
			String strSearchKey = txtSearchKey.Text.Trim().Equals("Enter your search key.") ? String.Empty : txtSearchKey.Text.Trim();
			String strTableType = ddlTableType.SelectedItem.ToString();
			switch (strTableType)
			{
				case "Person":
					dgSearchResults.ItemsSource = StructuresClass.GetResults<Person>(ddlSearchCriteria.Text,strSearchKey);
					break;
				case "Employee":
					dgSearchResults.ItemsSource = StructuresClass.GetResults<Employee>(ddlSearchCriteria.Text, strSearchKey);
					break;
			}
		}

		private void ddlTableType_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			ddlSearchCriteria.ItemsSource = StructuresClass.GetCriterias(ddlTableType.SelectedItem.ToString());
			ddlSearchCriteria.SelectedIndex = 0;
		}

        private void btnSearchAnyXML_Click(object sender, RoutedEventArgs e)
        {
            new SearchAnyXML().Show();
            this.Close();
        }
	}
}
