   M S B A M L   `   `   `  ����  EffectiveSearchInXML$    EffectiveSearchInXML.SearchXML   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  Search��5   	   $	��450��6   $	��500��6%    � WindowStartupLocation$ CenterScreen=�61    � WindowStyle$ 
ToolWindow=�6V   .��5      � $��10,10,10,10q�6    � 	Resources 5   
   ��%    5       � RowDefinitions 5	   
   �� 5
      $��30 �6   �� 5      $��30 �6   �� 5      $��30 �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $��60 �6   �� 5      $��* �6   .+�5   
   �� $��0��6   $��0��6"   $��2��62    �� Orientation$ 
Horizontal=�6F   $��Center=�6_   .+�5      �� -   5        $��ddlTableType��5      $	��100��6+   67   �� 5      -   5        $��ddlSearchCriteria��5      $	��150��60   5      �� 5   
   -   5        $��tbSearchKey��5   1   $��1��6   $��0��6!   $��Center=�6D   $��
Search Key��6_   �� 5   
   -   5        $��txtSearchKey��5      $��1��5      $��1��6   $��10,0,0,0q�6/   $��Center=�6A   $��Center=�6\   $��Enter your search key.��5   &   .��5   �   ��5      �� 5       �� 
TargetType" ��6    �� Triggers 5      �� 5       	 �� Binding	 6&   �� 
 �� ElementName$
 txtSearchKey�� �� Path$
 Text� �� Value Enter your search key.6^   .a�5!      ��  �� Property � �� �� Value
 �����6;   5"      5$      .��5%      5&      �� 5(   
   $��2��6   $��0��6"   $��2��62   $ 
Horizontal=�6F   $��Right=�6_   .+�5)   
   �� -   5        $��	btnSearch��5)      $��Search��6"   63   �� 5*   
   -   5        $��btnSearchAnyXML��5*      $��Switch��6(   69   5+      &   System.Windows.Controls.DataGrid  5-   
   -   5        $��dgSearchResults��51      $��3��5-      $��0��5.      $��2��5/      $��0,10,0,0q�50         CanUserAddRows .     CanUserDeleteRows .     CanUserReorderColumns .     AlternatingRowBackground
 �����   AutoGenerateColumns .    
IsReadOnly .    ColumnHeaderHeight$ 30Q�58       5:      *  $System.Windows.Controls.DataGridCell��%z   '        �� 5;      "  6   .�5<      ��  � ��$ 25��6/   �� 5=       � ��$ Center=�6A   5>      5?      5@      5A      5B      