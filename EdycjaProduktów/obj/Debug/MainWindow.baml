   M S B A M L   `   `   `  ����K  GEdycjaProduktów, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:EdycjaProduktówEdycjaProduktów  5   	   !    EdycjaProduktów.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:EdycjaProduktów     5   	     � Title$  Edycja produktów��5   	   $	��300��6"   $	��420��6/   .��5	      &   System.Windows.Controls.DataGrid  -   5        $��gridProdukty��5	         AutoGenerateColumns .     AlternatingRowBackground
 ��ح�   GridLinesVisibility$
 None=�6d      Columns 5
   
   0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Symbol��6!   1  +System.Windows.Controls.DataGridBoundColumn   Binding 61   �� *Symbol+  5      $ Nazwa��6!    60   �� *Nazwa+  5      $ Liczba sztuk��6!    67   �� *LiczbaSztuk+   ElementStyle 5      �� 5       �� 
TargetType" ��6   .�5      �� 	 �� Property	 � ��
 �� Value$
 Right=�6@   5      5      4  .System.Windows.Controls.DataGridComboBoxColumn  5      -   5        nazwaMagazynu��$ Magazyn��5   <      SelectedItemBinding 6M   �� *	Magazyn+4  .System.Windows.Controls.DataGridTemplateColumn  5      $ Zdjęcie��6%      MaxWidth$ 50Q�66      
IsReadOnly .    CellTemplate 5      �� 5      .R�5      �� ��6    ��  �� Path$ Zdjecie�5      5         RowDetailsTemplate 5   
   �� 5      .R�5      ��  �� Orientation$ 
Horizontal=�6   .+�5       �� $��10q�6    $��Opis produktu:��6,   �� 5!      $��10q�6    �� TextWrapping$
 Wrap=�6E   $
��Bold"�6Y   
����+��$	��150��6�   ��6*   �� $
 Opis�6�   �� 5"       ��Name$ 
btnZdjecie��6   -   5        $��10q�5"   1   $��Dodaj lub zmień zdjęcie��6V   $��30��6x   5#      5$       �� 
GroupStyle 5&   
   (  "System.Windows.Controls.GroupStyle  5'         ContainerStyle 5(      �� 5)      " ��6   .�5*      �� 	 � ��
 5+      �� 5,   "    �� 
TargetType" ��62   .R�5-   &   9� ��5.   *   �� 5/   .   $ 
Horizontal=�69   .+�50   2   �� $��Magazyn:��6<   $��5q�6L   �� 51   2   $��5q�6W   $
��Bold"�52   2   
����  ���51   <   �� $
 Name�52   D   �� 53   2   $��Liczba produktów:��6<   $��5q�6U   �� 54   2   $��5q�55   )   $
��Bold"�64   
����  ���54   <   �� $ 	ItemCount�55   F   56   /   .��58   *   �� 59   '   5:   #   5<      5=      5?      5A      5B      