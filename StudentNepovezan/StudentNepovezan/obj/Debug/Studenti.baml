   M S B A M L   `   `   `  ����K  GStudentNepovezan, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:StudentNepovezanStudentNepovezan  5   	       StudentNepovezan.Studenti   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:StudentNepovezan     5   	   -   5          � Title$  Studenti��5   	   $��507.398��6   $	��800��6+    � 	Resources 5	      )   #StudentNepovezan.ŠtudentNetDataSet   študentNetDataSet  oceneViewSource �� Source �� Source  študentViewSource  študentOceneViewSource��%�   &	        &	      7   &	 >     7   &	 l     7    5
   
   6"   �� 5   
    67   �� *Ocene+8   �� 5   
    69   �� *
Študent+8   �� 5   
    6>   �� *	fk_Št_oc+8   5      .��5      �  � DataContext# [ 6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ študentDataGrid��5         AutoGenerateColumns .     EnableRowVirtualization . $��0,10,461,260q�6�      RowDetailsVisibilityMode$ VisibleWhenSelected=�6�   ��6g   �� # [ 	   Columns	 5      0  *System.Windows.Controls.DataGridTextColumn  5      -   5        idVpisaColumn��,  &System.Windows.Controls.DataGridColumn
   Header$
 Id Vpisa��5   X      
IsReadOnly .    Width5  /System.Windows.Controls.DataGridLengthConverter$ SizeToHeader 6|   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6<   �� *	IdVpisa+6|     5      -   5        imeŠtudentaColumn��$
 Ime Študenta��5   `   $ SizeToHeader 6v    6@   �� *ImeŠtudenta+6v     5      -   5        povprečnaOcenaColumn��$
 Povprečna Ocena��5   f   $ SizeToHeader 6    6C   �� *PovprečnaOcena+6   5        5   
   -   5        $ oceneDataGrid��5       .   . $��382,10,10,260q�6�   $ VisibleWhenSelected=�6�   ��6e   �� # [ 	 5        5      -   5        idOceneColumn��$
 Id Ocene��5   X    . $ SizeToHeader 6|    6<   �� *	IdOcene+6|     5      -   5        idŠtudentaColumn��$
 Id Študenta��5   ^   $ SizeToHeader 6s    6?   �� *IdŠtudenta+6s     5      -	   5        idPredmetaColumn��$
 id Predmeta��5   ^   $ SizeToHeader 6s    6?   �� *
idPredmeta+6s     5      -
   5        ocenaColumn��$
 ocena��5   T   $ SizeToHeader 6c    6:   �� *ocena+6c   5      � 5   
   -   5         �Name$ grid1��5      # [ 6   $
��Left=�6O   $��
94,248,0,0q�6j   $	��Top=�6~    � ColumnDefinitions 5       �� 5!      $
��Auto �6#   �� 5"      $
��Auto �6#    � RowDefinitions 5$      �� 5%      $
��Auto �6    �� 5&      $
��Auto �6    �� 5'      $
��Auto �6    .+�5)      �� $��	Id Vpisa:��6   $��0��6(   $
��Left=�68   $��3q�6S   $��0��6^   $��Center=�6k   �� 5*      -   5         ��Name$ idVpisaTextBox��5*      $��1��6.   $
��Left=�6>   $��23��6Y   $��3q�6e   $��0��6p   $��Center=�6�   $	��120��6�   ��6}   �� *	IdVpisa+ �� Mode$ OneWay=�6�   �� 5+      $��Ime Študenta:��6   $��0��6,   $
��Left=�6<   $��3q�6W   $��1��6b   $��Center=�6o   �� 5,      -   5        $ imeŠtudentaTextBox��5,      $��1��62   $
��Left=�6B   $��23��6]   $��3q�6i   $��1��6t   $��Center=�6�   $	��120��6   ��6�   �� *ImeŠtudenta+$ TwoWay=� �� NotifyOnValidationError .  �� ValidatesOnExceptions . 6   �� 5-      $��Povprečna Ocena:��6   $��0��6/   $
��Left=�6?   $��3q�6Z   $��2��6e   $��Center=�6r   �� 5.      -   5        $ povprečnaOcenaTextBox��5.      $��1��65   $
��Left=�6E   $��23��6`   $��3q�6l   $��2��6w   $��Center=�6�   $	��120��6  ��6�   �� *PovprečnaOcena+$ TwoWay=� .  . 6  5/      50      51      