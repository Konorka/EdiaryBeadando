   M S B A M L   `   `   `  ����P  LKovatsNorbertBeadando, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:KovatsNorbertBeadandoKovatsNorbertBeadando  5   	   =#clr-namespace:KovatsNorbertBeadandoKovatsNorbertBeadando  5   	   '    !KovatsNorbertBeadando.StudentView   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:KovatsNorbertBeadando     5   	   :
Converters#clr-namespace:KovatsNorbertBeadando     5   	   -   5          � Title$  Tanulói felület��5	   	   $��359.344��6!   $��505.354��62    � 
ResizeMode$ NoResize=�6r    � 	Resources 5
      )  #KovatsNorbertBeadando.DateConverter   DateConverter+   %KovatsNorbertBeadando.CourseConverter  CoursConverter-  'KovatsNorbertBeadando.IsProvenConverter  IsProvenConverter,   &KovatsNorbertBeadando.NewEDiaryDataSet  newEDiaryDataSet  studentsViewSource �� Source �� Source  studentsMarksViewSource ! studentsDepartmentsViewSource  coursesViewSource  coursesMarksViewSource 	 marksViewSource "
 studentsMarksCoursesViewSource  absentsViewSource  studentsAbsentsViewSource-   'KovatsNorbertBeadando.NewEDiaryDataSet1  newEDiaryDataSet1  studentsViewSource1  studentsAbsentsViewSource1  studentsMarksViewSource1 " studentsDepartmentsViewSource1��%�  &	        &	      &	 &     &	 9     &	 L     7  &	 z     7  &	 �     7  &	 �     7  &	     7  &		 H    7  &	
 s    7  &	 �    7  &	 �    7  &	 	    &	     7  &	 J    7  &	 �    7  &	 �    7    5   
   6#     5   
   6%     5   
   6'     5   
   6!   �� 5   
    6:   �� *
Students+8   �� 5   
    6?   �� *Students_Marks+8   �� 5   
    6E   �� *Students_Departments+8   �� 5   
    69   �� *	Courses+8   �� 5   
    6>   �� *Courses_Marks+8   �� 5   
    67   �� *Marks+8   �� 5   
    6F   �� *Marks_Courses+8   �� 5   
    69   �� *	Absents+8   �� 5   
    6A   �� *Students_Absents+8     5   
   6'   �� 5   
    6;   �� *
Students+8   �� 5   
    6B   �� *Students_Absents+8   �� 5   
    6@   �� *Students_Marks+8   �� 5   
    6F   �� *Students_Departments+8   5      .��5"      �  � DataContext# [ 6   .+�5#   
   � -   5         �Name$ grid4��5#      # [ 6   $
��Left=�6O   $��8,65,0,0q�6j   $	��Top=�6|    � ColumnDefinitions 5$      �� 5%      $
��Auto �6#   �� 5&      $
��Auto �6#    � RowDefinitions 5(      �� 5)      $
��Auto �6    5+      &   System.Windows.Controls.DataGrid  5,   
   -   5        	  Name$	 marksDataGrid1��5,      
   AutoGenerateColumns
 .     EnableRowVirtualization . $��10,118,220,10q�6�      RowDetailsVisibilityMode$ VisibleWhenSelected=�6�   ��6f   �� # [    Columns 5-      0  *System.Windows.Controls.DataGridTextColumn  5/      -   5        course_IDColumn1��,  &System.Windows.Controls.DataGridColumn   Header$ 	Tantárgy��5/   �      Width5	  /System.Windows.Controls.DataGridLengthConverter$	 100	 6�   1
  +System.Windows.Controls.DataGridBoundColumn 
  Binding 6?   �� *	Course_ID+ �� 	Converter# [ 6�     50      -   5        markColumn1��$ 
Érdemjegy��50   S   $ SizeToHeader	 6f    6:   �� *Mark+6f     51      -   5        mark_DateColumn1��$ Dátum��51   �   $ *	 6�    6?   �� *	Mark_Date+# [  6�   53      � 54   
   -   5        $ grid5��54      # [ 6   $
��Left=�6O   $��7,80,0,0q�6j   $	��Top=�6|    55      �� 56      $
��Auto �6#   �� 57      $
��Auto �6#    59      �� 5:      $
��Auto �6    .+�5<      �� $��Tantárgy átlag:��6   $��0��6.   $
��Left=�6>   $��3q�6Y   $��0��6d   $��Center=�6q   �� 5=      -   5         ��Name$ titleComboBox��5=      $��1��6.    �� DisplayMemberPath$ Title��6>   $
��Left=�6X   $
��Auto��6s   $��3q�6�   $��0��6�   $��Center=�6�   $	��120��6�   ��6�   �� ��5>      �� 5?      .R�5@      $� 5A      5C      5D      �� 5E   
   -	   5         ��Name$ coursAVG��5E      $�� ��6"   $
��Left=�6-   $��
233,83,0,0q�6H   $	��Top=�6\   $��79��6t   � 5F   
   -
   5        $ grid6��5F      # [ 6   $
��Left=�6Q   $��
272,14,0,0q�6l   $	��Top=�6�   $y�Hidden=�6�    5G      �� 5H      $
��Auto �6#   �� 5I      $
��Auto �6#    5K      �� 5L      $
��Auto �6    .+�5N      �� $��Student ID:��6   $��0��6*   $
��Left=�6:   $��3q�6U   $��0��6`   $��Center=�6m   �� 5O      -   5        $ student_IDComboBox��5O      $��1��63   $ 
Student_ID��6C   $
��Left=�6b   $
��Auto��6}   $��3q�6�   $��0��6�   $��Center=�6�   $	��120��6�   ��6�   �� ��5P      �� 5Q      .R�5R      $� 5S      5U      5V        5W   
   -   5        $	 absentsDataGrid��5W      
 .   . $��284,118,5,10q�6�   $ VisibleWhenSelected=�6�   ��6g   �� # [  5X      4  .System.Windows.Controls.DataGridTemplateColumn  5Z      -   5        hoursColumn��$ Órák��5Z   >   $ 35	 6L      CellTemplate 5[      �� 5\      .R�5]      �� ��6$   �� *Hours+5^      5`        5a      -   5        absent_DateColumn��$ Hiányzás Dáduma��5a   D   $ 80	 6]    5b      �� 5c      .R�5d      �� ��6$   �� *Absent_Date+# [  5e      5g        5h      -   5        isProvenColumn��$ Igazolt��5h   A   $ *	 6R    5i      �� 5j      .R�5k      �� ��6$   �� *
IsProven+# [ 5l      5n      5p      � 5q   
   -   5        $ grid1��5q      # [ 6   $
��Left=�6Q   $��7,4,0,0q�6l   $	��Top=�6}    5r      �� 5s      $
��Auto �6#   �� 5t      $
��Auto �6#    5v      �� 5w      $
��Auto �6    .+�5y      �� $��Név:��6   $��0��6#   $
��Left=�63   $��3q�6N   $��0��6Y   $��Center=�6f   �� 5z      -   5        $ student_NameLabel1��5z      $��1��6Q   $
��Left=�6a   $��3q�6|   $��0��6�   $��Center=�6�   ��60   �� *Student_Name+6�   5{      � 5|   
   -   5        $ grid2��5|      # [ 6   $
��Left=�6\   $��7,28,0,0q�6w   $	��Top=�6�    5}      �� 5~      $
��Auto �6#   �� 5      $
��Auto �6#    5�      �� 5�      $
��Auto �6    .+�5�      �� $��	Osztály:��6   $��0��6'   $
��Left=�67   $��3q�6R   $��0��6]   $��Center=�6j   �� 5�      -   5        $ department_NameLabel1��5�      $��1��6W   $
��Left=�6g   $��3q�6�   $��0��6�   $��Center=�6�   ��63   �� *Department_Name+6�   5�      5�      5�      