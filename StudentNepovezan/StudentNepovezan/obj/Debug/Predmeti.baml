   M S B A M L   `   `   `  ����K  GStudentNepovezan, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:StudentNepovezanStudentNepovezan  5   	       StudentNepovezan.Predmeti   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:StudentNepovezan     5   	   -   5          � Title$  Predmeti��5   	   $	��450��6   $	��800��6'    � 	Resources 5	      )   #StudentNepovezan.ŠtudentNetDataSet   študentNetDataSet  predmetViewSource �� Source �� Source  predmetOceneViewSource��%�   &	        &	      7   &	 @     7    5
   
   6"   �� 5   
    69   �� *	Predmet+8   �� 5   
    6>   �� *
fk_Pr_oc+8   5      .��5      �  � DataContext# [ 6   .+�5   
   � -   5         �Name$ grid1��5      # [ 6   $
��Left=�6O   $��343,316,0,0q�6j   $	��Top=�6    � ColumnDefinitions 5      �� 5      $
��Auto �6#   �� 5      $
��Auto �6#    � RowDefinitions 5      �� 5      $
��Auto �6    �� 5      $
��Auto �6    .+�5      �� $��Id Predmeta:��6   $��0��6+   $
��Left=�6;   $��3q�6V   $��0��6a   $��Center=�6n   �� 5      -   5         ��Name$ idPredmetaTextBox��5      $��1��61   $
��Left=�6A   $��23��6\   $��3q�6h   $��0��6s   $��Center=�6�   $	��120��6�   ��6�   �� *
IdPredmeta+	 �� Mode$	 OneWay=�6�   �� 5      $��Ime Predmeta:��6   $��0��6,   $
��Left=�6<   $��3q�6W   $��1��6b   $��Center=�6o   �� 5      -   5        $ imePredmetaTextBox��5      $��1��62   $
��Left=�6B   $��23��6]   $��3q�6i   $��1��6t   $��Center=�6�   $	��120��6   ��6�   �� *ImePredmeta+$	 TwoWay=�
 �� NotifyOnValidationError
 .  �� ValidatesOnExceptions . 6   5      &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ predmetDataGrid��5         AutoGenerateColumns .     EnableRowVirtualization . $��36,42,563,177q�6      RowDetailsVisibilityMode$ VisibleWhenSelected=�6�   ��6g   ��    Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      -   5        idPredmetaColumn��,  &System.Windows.Controls.DataGridColumn   Header$ Id Predmeta��5   ^      
IsReadOnly .    Width5  /System.Windows.Controls.DataGridLengthConverter$ SizeToHeader 6�   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6?   �� *
IdPredmeta+6�     5       -   5        imePredmetaColumn��$ Ime Predmeta��5    `   $ SizeToHeader 6v    6@   �� *ImePredmeta+6v   5"        5#   
   -   5        $ oceneDataGrid��5#       .   . $��424,42,87,177q�6�   $ VisibleWhenSelected=�6�   ��6e   �� # [  5$        5%      -	   5        idOceneColumn��$ Id Ocene��5%   X    . $ SizeToHeader 6|    6<   �� *	IdOcene+6|     5&      -
   5        idŠtudentaColumn��$ Id Študenta��5&   ^   $ SizeToHeader 6s    6?   �� *IdŠtudenta+6s     5'      -   5        idPredmetaColumn1��$ id Predmeta��5'   _   $ SizeToHeader 6t    6@   �� *
idPredmeta+6t     5(      -   5        ocenaColumn��$ ocena��5(   T   $ SizeToHeader 6c    6:   �� *ocena+6c   5*      5,      5-      