   M S B A M L   `   `   `  ����P  LKovatsNorbertBeadando, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:KovatsNorbertBeadandoKovatsNorbertBeadando  5   	   =#clr-namespace:KovatsNorbertBeadandoKovatsNorbertBeadando  5   	   '    !KovatsNorbertBeadando.TeacherView   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   :
Converters#clr-namespace:KovatsNorbertBeadando     5   	   5local#clr-namespace:KovatsNorbertBeadando     5   	   -   5          � Title$  Tanári felület��5	   	   $��442.009��6    $��741.091��61    � 
ResizeMode$ NoResize=�6q    � 	Resources 5
      ,   &KovatsNorbertBeadando.NewEDiaryDataSet   newEDiaryDataSet1   +KovatsNorbertBeadando.AvailabilityConverter  AvailabilityConverter  departmentsViewSource �� Source �� Source ! departmentsStudentsViewSource  teachersViewSource ! teachersDepartmentsViewSource & "departmentsStudentsMarksViewSource ( $departmentsStudentsAbsentsViewSource ( $departmentsStudentsParentsViewSource-   'KovatsNorbertBeadando.NewEDiaryDataSet1 	 newEDiaryDataSet1 
 departmentsViewSource1 " departmentsStudentsViewSource1 ) %departmentsStudentsAbsentsViewSource1 ' #departmentsStudentsMarksViewSource1 ) %departmentsStudentsParentsViewSource1  studentsViewSource  studentsParentsViewSource  teachersViewSource1 " teachersDepartmentsViewSource1��%�  &	        &	      &	 &     7   &	 W     7  &	 �     7   &	 �     7  &	 �     7  &	 -    7  &	 c    7  &		 �    &	
 �    7 	 &	 �    7 
 &	     7  &	 M    7  &	 �    7  &	 �    7 	 &	 �    7  &	     7 	 &	 I    7    5   
   6!     5   
   6+   �� 5   
    6=   �� *Departments+8   �� 5   
    6E   �� *Departments_Students+8   �� 5   
    6:   �� *
Teachers+8   �� 5   
    6E   �� *Teachers_Departments+8   �� 5   
    6J   �� *Students_Marks+8   �� 5   
    6L   �� *Students_Absents+8   �� 5   
    6L   �� *Students_Parents+8     5   
   6"   �� 5   
    6>   �� *Departments+8   �� 5   
    6F   �� *Departments_Students+8   �� 5   
    6M   �� *Students_Absents+8   �� 5   
    6K   �� *Students_Marks+8   �� 5   
    6M   �� *Students_Parents+8   �� 5   
    6:   �� *
Students+8   �� 5   
    6A   �� *Students_Parents+8   �� 5   
    6;   �� *
Teachers+8   �� 5   
    6F   �� *Teachers_Departments+8   5      .��5"      �  � DataContext# [ 6   .+�5#   
   �� -   5        $��Mentés��5#      $
��Left=�6"   $	��Top=�6=   $��75��6U   $��648,381,0,0q�6`   6u   �� 5$   
   -   5         ��Name$ 	ChangeBtn��5$      $��Tanuló elérhetőségek��6$   $
��Left=�6C   $	��Top=�6^   $	��148��6v   $��
575,66,0,0q�6�   6�   �� 5'   
   -   5         ��Name$ StudentAvailability��5'      $
��Left=�62   $	��153��6M   $��
382,99,0,0q�6Z   $	��Top=�6n   $	��341��6�   $y�Hidden=�6�   .+�5*      � -   5         �Name$ grid1��5*      # [ 6"   $
��Left=�6`   $	��Top=�6{   	 � ColumnDefinitions	 5+      �� 5,      $
��Auto �6'   �� 5-      $
��Auto �6'   
 � RowDefinitions
 5/      �� 50      $
��Auto �6$   .+�52      �� $��Tanuló telefonszáma:��6   $��0��67   $
��Left=�6G   $��3q�6b   $��0��6m   $��Center=�6z   �� 53      -   5         ��Name$ student_Phone_NumberLabel��53      $��1��6�   $
��Left=�6�   $��3q�6�   $��0��6�   $��Center=�6�   ��6;   �� *Student_Phone_Number+ �� 	Converter# [ 6�   54      � 55      -   5        $ grid5��55      # [ 6"   $
��Left=�6`   $��14,0,0,0q�6{   $	��Top=�6�   	 56      �� 57      $
��Auto �6'   �� 58      $
��Auto �6'   
 5:      �� 5;      $
��Auto �6$   .+�5=      �� $��Tanuló email címe:��6   $��0��65   $
��Left=�6E   $��3q�6`   $��0��6k   $��Center=�6x   �� 5>      -   5        $ student_EmailLabel��5>      $��1��6�   $
��Left=�6�   $��3q�6�   $��0��6�   $��Center=�6�   ��64   �� *Student_Email+# [ 6�   5?      � 5@      -	   5        $ grid6��5@      # [ 6"   $
��Left=�6g   $��51,0,0,0q�6�   $	��Top=�6�   	 5A      �� 5B      $
��Auto �6'   �� 5C      $
��Auto �6'   
 5E      �� 5F      $
��Auto �6$   .+�5H      �� $��Szülő neve:��6   $��0��6.   $
��Left=�6>   $��3q�6Y   $��0��6d   $��Center=�6q   �� 5I      -
   5        $ 	nameLabel��5I      $��1��6D   $
��Left=�6T   $��3q�6o   $��0��6z   $��Center=�6�   ��6+   �� *Name+6�   5J      � 5K      -   5        $ grid7��5K      # [ 6"   $
��Left=�6g   $��6,0,0,0q�6�   $	��Top=�6�   	 5L      �� 5M      $
��Auto �6'   �� 5N      $
��Auto �6'   
 5P      �� 5Q      $
��Auto �6$   .+�5S      �� $��Szülő telefonszáma:��6   $��0��66   $
��Left=�6F   $��3q�6a   $��0��6l   $��Center=�6y   �� 5T      -   5        $ parent_Phone_NumberLabel��5T      $��1��6�   $
��Left=�6�   $��3q�6�   $��0��6�   $��Center=�6�   ��6:   �� *Parent_Phone_Number+# [ 6�   5U      � 5V      -   5        $ grid8��5V      # [ 6"   $
��Left=�6g   $��19,0,0,0q�6�   $	��Top=�6�   	 5W      �� 5X      $
��Auto �6'   �� 5Y      $
��Auto �6'   
 5[      �� 5\      $
��Auto �6$   .+�5^      �� $��Szülő email címe:��6   $��0��64   $
��Left=�6D   $��3q�6_   $��0��6j   $��Center=�6w   �� 5_      -   5        $ parent_EmailLabel��5_      $��1��6�   $
��Left=�6�   $��3q�6�   $��0��6�   $��Center=�6�   ��63   �� *Parent_Email+# [ 6�   5`      5a      � 5b   
   -   5        $ grid9��5b      # [
 6   $
��Left=�6T   $��5,58,0,0q�6o   $	��Top=�6�   	 5c      �� 5d      $
��Auto �6#   �� 5e      $
��Auto �6#   
 5g      �� 5h      $
��Auto �6    .+�5j      �� $��Osztályok:��6   $��0��6)   $
��Left=�69   $��3q�6T   $��0��6_   $��Center=�6l   �� 5k      -   5         ��Name$ department_NameComboBox��5k      $��1��68    �� DisplayMemberPath$ Department_Name��6H   $
��Left=�6l   $
��Auto��6�   $��3,5,0,5q�6�   $��0��6�   $��Center=�6�   $��59��6�   ��6�   �� ��5l      �� 5m      .R�5n      $� 5o      5q      5r      &   System.Windows.Controls.DataGrid  5s   
   -   5          Name$ studentsDataGrid1��5s         AutoGenerateColumns .     EnableRowVirtualization . $��6,99,360,38q�6�      RowDetailsVisibilityMode$ VisibleWhenSelected=�6�   ��6i   �� # [    Columns 5t      0  *System.Windows.Controls.DataGridTextColumn  5u      -   5        student_NameColumn1��,  &System.Windows.Controls.DataGridColumn   Header$ Tanuló neve��5u   c      Width5  /System.Windows.Controls.DataGridLengthConverter$ SizeToHeader 6x   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6B   �� *Student_Name+6x     5v      -   5        student_OM_IDColumn1��$ OM azonosító��5v   e   $ SizeToHeader 6{    6C   �� *Student_OM_ID+6{     5w      -   5        addressColumn1��$ Lakcím��5w   Y   $ SizeToHeader 6i    6=   �� *	Address+6i   5y        5z   
   -   5        $ absentsDataGrid��5z       .   . $��382,249,10,38q�6�   $ VisibleWhenSelected=�6�   ��6g   �� # [  5{        5|      -   5        hoursColumn��$
 Óra��5|   T   $ SizeToHeader 6a    6:   �� *Hours+6a   4	  .System.Windows.Controls.DataGridTemplateColumn	  5}      -   5        absent_DateColumn��$ Dátum��5}   D   $	 100 6S    	  CellTemplate 5~      �� 5      .R�5�      (
  "System.Windows.Controls.DatePicker
   
  SelectedDate 6)   �� *Absent_Date+ �� Mode$ TwoWay=� �� NotifyOnValidationError .  �� ValidatesOnExceptions . 5�      5�      4  .System.Windows.Controls.DataGridCheckBoxColumn  5�      -   5        isProvenColumn��$ Igazolt��5�   ^   $ 70 6o    6A   �� *
IsProven+6o   5�        5�   
   -   5        $ marksDataGrid1��5�       .   . $��382,99,10,167q�6�   $ VisibleWhenSelected=�6�   ��6f   �� # [  5�        5�      -   5        course_IDColumn1��$ Tanóra az.��5�   ]   $ SizeToHeader 6q    6?   �� *	Course_ID+6q     5�      -   5        markColumn1��$ 
Érdemjegy��5�   S   $ SizeToHeader 6f    6:   �� *Mark+6f   	  5�      -   5        mark_DateColumn1��$ Érdemjegy Dátuma��5�   C   $ SizeToHeader 6]    5�      �� 5�      .R�5�      
   6)   �� *	Mark_Date+$ TwoWay=� .  . 5�      5�      5�      � 5�   
   -   5        $ grid10��5�      # [ 6   $
��Left=�6]   $��4,33,0,0q�6x   $	��Top=�6�   	 5�      �� 5�      $
��Auto �6#   �� 5�      $
��Auto �6#   
 5�      �� 5�      $
��Auto �6    .+�5�      �� $��Osztályfőnök:��6   $��0��6,   $
��Left=�6<   $��3q�6W   $��0��6b   $��Center=�6o   �� 5�      -   5        $ department_NameLabel1��5�      $��1��6W   $
��Left=�6g   $��3q�6�   $��0��6�   $��Center=�6�   ��63   �� *Department_Name+6�   5�      � 5�   
   -   5        $ grid12��5�      # [ 6   $
��Left=�6R   $��
516,17,0,0q�6m   $	��Top=�6�   $y�Hidden=�6�   	 5�      �� 5�      $
��Auto �6#   �� 5�      $
��Auto �6#   
 5�      �� 5�      $
��Auto �6    .+�5�      �� $��Teacher ID:��6   $��0��6*   $
��Left=�6:   $��3q�6U   $��0��6`   $��Center=�6m   �� 5�      -    5        $ teacher_IDComboBox��5�      $��1��63   $ 
Teacher_ID��6C   $
��Left=�6b   $
��Auto��6}   $��3q�6�   $��0��6�   $��Center=�6�   $	��120��6�   ��6�   �� ��5�      �� 5�      .R�5�      $� 5�      5�      5�      � 5�   
   -!   5        $ grid13��5�      # [ 6   $
��Left=�6R   $��4,8,0,0q�6m   $	��Top=�6~   	 5�      �� 5�      $
��Auto �6#   �� 5�      $
��Auto �6#   
 5�      �� 5�      $
��Auto �6    .+�5�      �� $��Név:��6   $��0��6#   $
��Left=�63   $��3q�6N   $��0��6Y   $��Center=�6f   �� 5�      -"   5        $ teacher_NameLabel1��5�      $��1��6Q   $
��Left=�6a   $��3q�6|   $��0��6�   $��Center=�6�   ��60   �� *Teacher_Name+6�   5�      5�      5�      