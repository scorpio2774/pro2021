   M S B A M L   `   `   `  ����K  GStudentNepovezan, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:StudentNepovezanStudentNepovezan  5   	       StudentNepovezan.Ocene   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:StudentNepovezan     5   	   -   5          � Title$  Ocene��5   	   $��500.41��6   $	��800��6'    � 	Resources 5	      )   #StudentNepovezan.ŠtudentNetDataSet   študentNetDataSet  oceneViewSource �� Source �� Source��%V   &	        &	      7     5
   
   6"   �� 5   
    67   �� *Ocene+8   5      .��5      �  � DataContext# [ 6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ oceneDataGrid��5         AutoGenerateColumns .     EnableRowVirtualization . $��378,28,103,191q�6}      RowDetailsVisibilityMode$ VisibleWhenSelected=�6�   ��6e   �� 	   Columns	 5      0  *System.Windows.Controls.DataGridTextColumn  5      -   5        idOceneColumn��,  &System.Windows.Controls.DataGridColumn
   Header$
 Id Ocene��5   X      
IsReadOnly .    Width5  /System.Windows.Controls.DataGridLengthConverter$ SizeToHeader 6|   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6<   �� *	IdOcene+6|     5      -   5        idŠtudentaColumn��$
 Id Študenta��5   ^   $ SizeToHeader 6s    6?   �� *IdŠtudenta+6s     5      -   5        idPredmetaColumn��$
 id Predmeta��5   ^   $ SizeToHeader 6s    6?   �� *
idPredmeta+6s     5      -   5        ocenaColumn��$
 ocena��5   T   $ SizeToHeader 6c    6:   �� *ocena+6c   5      � 5   
   -   5         �Name$ grid1��5      $
��Left=�6   $��	34,28,0,0q�69   $	��Top=�6L    � ColumnDefinitions 5      �� 5      $
��Auto �6#   �� 5      $
��Auto �6#    � RowDefinitions 5      �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    .+�5!      �� $��	Id Ocene:��6   $��0��6(   $
��Left=�68   $��3q�6S   $��0��6^   $��Center=�6k   �� 5"      -   5         ��Name$ idOceneTextBox��5"      $��1��6.   $
��Left=�6>   $��23��6Y   $��3q�6e   $��0��6p   $��Center=�6�   $	��120��6�   ��6}   �� *	IdOcene+ �� Mode$ OneWay=�6�   �� 5#      $��Id Študenta:��6   $��0��6+   $
��Left=�6;   $��3q�6V   $��1��6a   $��Center=�6n   �� 5$      -	   5        $ idŠtudentaTextBox��5$      $��1��61   $
��Left=�6A   $��23��6\   $��3q�6h   $��1��6s   $��Center=�6�   $	��120��6�   ��6�   �� *IdŠtudenta+$ TwoWay=� �� NotifyOnValidationError .  �� ValidatesOnExceptions . 6�   �� 5%      $��id Predmeta:��6   $��0��6+   $
��Left=�6;   $��3q�6V   $��2��6a   $��Center=�6n   �� 5&      -
   5        $ idPredmetaTextBox��5&      $��1��61   $
��Left=�6A   $��23��6\   $��3q�6h   $��2��6s   $��Center=�6�   $	��120��6�   ��6�   �� *
idPredmeta+$ TwoWay=� .  . 6�   �� 5'      $��ocena:��6   $��0��6%   $
��Left=�65   $��3q�6P   $��3��6[   $��Center=�6h   �� 5(      -   5        $ ocenaTextBox��5(      $��1��6,   $
��Left=�6<   $��23��6W   $��3q�6c   $��3��6n   $��Center=�6�   $	��120��6�   ��6{   �� *ocena+$ TwoWay=� .  . 6�   5)      5+      5,      