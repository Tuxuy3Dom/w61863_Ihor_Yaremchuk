   M S B A M L   `   `   `  ����F  BAdd student, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:Add_studentAdd_student  5   	       Add_student.MainWindow   5   	   \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:Add_student     5   	     � Title$  Main Window��5   	   $	��450��6   $	��800��6*   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $��0* �6   �� 5      .+�5   
   �� -   5         ��Name$ bAddStudent��5      $��Add Student��6&   $
��Left=�6<   $��	40,65,0,0q�6W   $	��Top=�6j   $��30��6�   $	��102��6�   $��1��6�   6�   �� 5   
   -   5        $ bRemoveStudent��5      $��Remove student��6)   $
��Left=�6B   $��
200,65,0,0q�6]   $	��Top=�6q   $��30��6�   $	��101��6�   $��1��6�   6�   �� 5   
   -   5        $ bEditStudent��5      $��Edit Student��6'   $��Center=�6>   $��0,65,0,0q�6[   $	��Top=�6m   $��30��6�   $	��100��6�   $��1��6�   6�   �� 5   
   -   5        $ bAddSchoolGrades��5      $��Add school grades��6+   $
��Left=�6G   $��
487,65,0,0q�6b   $	��Top=�6v   $��30��6�   $	��124��6�   $��1��6�   6�   �� 5   
   -   5        $ bSchoolGrades��5      $��School grades��6(   $
��Left=�6@   $��
640,65,0,0q�6[   $	��Top=�6o   $��30��6�   $	��124��6�   $��1��6�   6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ 	dgStudent��5      $��
5,112,5,10q�6&   $��5��6:   5      5      5      