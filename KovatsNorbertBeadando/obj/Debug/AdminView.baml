   M S B A M L   `   `   `  ����P  LKovatsNorbertBeadando, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:KovatsNorbertBeadandoKovatsNorbertBeadando  5   	   %    KovatsNorbertBeadando.AdminView   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:KovatsNorbertBeadando     5   	   -   5          � Title$  Adminisztációs Menü��5   	   $��489.186��6%   $��867.48��66    � 
ResizeMode$ NoResize=�6u    � 	Resources 5	      ,   &KovatsNorbertBeadando.NewEDiaryDataSet   newEDiaryDataSet  studentsViewSource �� Source �� Source  teachersViewSource  studentsParentsViewSource  teachersTDCViewSource ! teachersDepartmentsViewSource  studentsAbsentsViewSource  studentsMarksViewSource-   'KovatsNorbertBeadando.NewEDiaryDataSet1  newEDiaryDataSet1 	 usersViewSource��%=  &	        &	      7   &	 A     7   &	 o     7  &	 �     7  &	 �     7  &	     7  &	 G    7  &	 {    &		 �    7    5
   
   6!   �� 5   
    6:   �� *
Students+8   �� 5   
    6:   �� *
Teachers+8   �� 5   
    6A   �� *Students_Parents+8   �� 5   
    6=   �� *Teachers_TDC+8   �� 5   
    6E   �� *Teachers_Departments+8   �� 5   
    6A   �� *Students_Absents+8   �� 5   
    6?   �� *Students_Marks+8     5   
   6"   �� 5   
    67   �� *Users+8   5      .��5      �  � DataContext# [ 6    � ColumnDefinitions 5   
   �� 5      .+�5   
   �� -   5         ��Name$ saveBtn��5      $��Mentés��6"   $
��Left=�63   $	��Top=�6N   $��75��6f   $��768,422,0,0q�6q   $��20��6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ studentsDataGrid��5   E   # [ 6   	   AutoGenerateColumns	 .  
   EnableRowVirtualization
 . $��10,64,421,46q�6�   ��6�   ��    Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      -   5        student_IDColumn��,  &System.Windows.Controls.DataGridColumn   Header$ Tanuló azonosító��5   ^      Width5  /System.Windows.Controls.DataGridLengthConverter$ 60 6x   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6?   �� *
Student_ID+6x     5       -   5        student_NameColumn��$
 Név��5    b   $	 100 6o    6A   �� *Student_Name+6o     5!      -   5        student_First_NameColumn��$ Vezetéknév��5!   n   $ SizeToHeader 6�    6G   �� *Student_First_Name+6�     5"      -   5        student_Last_NameColumn��$ Keresztnév��5"   l   $ SizeToHeader 6�    6F   �� *Student_Last_Name+6�     5#      -   5        student_OM_IDColumn��$ OM azonosító��5#   d   $	 100 6z    6B   �� *Student_OM_ID+6z     5$      -	   5        addressColumn��$
 Cím��5$   X   $	 150 6e    6<   �� *	Address+6e     5%      -
   5        student_Phone_NumberColumn��$ Telefonszám��5%   r   $ 80 6�    6I   �� *Student_Phone_Number+6�     5&      -   5        student_EmailColumn��$ 
Email Cím��5&   d   $	 100 6w    6B   �� *Student_Email+6w     5'      -   5        student_User_IDColumn��$ Felhasználó azonosító��5'   h   $ 50 6�    6D   �� *Student_User_ID+6�     5(      -   5        departments_IDColumn��$ Osztály Azonosító��5(   f   $ 45 6�    6C   �� *Departments_ID+6�   5*        5+   
   -   5        $ teachersDataGrid��5+   F   # [ 6   	 .  
 . $��10,64,421,46q�6�      RowDetailsVisibilityMode$ VisibleWhenSelected=�6�   ��6�   ��  5,        5-      -   5        teacher_IDColumn��$ Tanár azonosító��5-   ^   $ 70 6w    6?   �� *
Teacher_ID+6w     5.      -   5        teacher_NameColumn��$
 Név��5.   b   $	 100 6o    6A   �� *Teacher_Name+6o     5/      -   5        teacher_First_nameColumn��$ Vezetéknév��5/   n   $ SizeToHeader 6�    6G   �� *Teacher_First_name+6�     50      -   5        teacher_Last_NameColumn��$ Keresztnév��50   l   $ SizeToHeader 6�    6F   �� *Teacher_Last_Name+6�     51      -   5        teacher_AddressColumn��$
 Cím��51   h   $	 200 6u    6D   �� *Teacher_Address+6u     52      -   5        teacher_Phone_NumberColumn��$ Telefonszám��52   r   $	 100 6�    6I   �� *Teacher_Phone_Number+6�     53      -   5        teacher_EmailColumn��$ 
Email Cím��53   d   $	 100 6w    6B   �� *Teacher_Email+6w     54      -   5        teacher_User_idColumn��$ Felhasználó azonosító��54   h   $ 50 6�    6D   �� *Teacher_User_id+6�   56      �� 57   
   -   5        $ studentOrTeacers��57      $��Diákok��6+   $
��Left=�6<   $	��Top=�6W   $��75��6o   $��	776,7,0,0q�6z   $��20��6�   �� 58   
   -   5         ��Name$ teacherStudentLabel��58      $��Tanár adatai:��6-   $
��Left=�6E   $��	10,33,0,0q�6`   $	��Top=�6s     59   
   -   5        $ marksDataGrid��59      	 .  
 . $��450,166,9,151q�6�   $ VisibleWhenSelected=�6�   $y�Hidden=�6�   ��6e   �� # [  5:        5;      -   5        mark_IDColumn��$ Jegy az.��5;   X   $ SizeToHeader 6j    6<   �� *	Mark_ID+6j     5<      -   5        student_Mark_IDColumn��$ Tanuló az.��5<   h   $ SizeToHeader 6|    6D   �� *Student_Mark_ID+6|     5=      -   5        course_IDColumn��$ Tanóra az.��5=   \   $ SizeToHeader 6p    6>   �� *	Course_ID+6p     5>      -   5        
markColumn��$
 Jegy��5>   R   $ SizeToHeader 6`    69   �� *Mark+6`   4  .System.Windows.Controls.DataGridTemplateColumn  5?      -   5        mark_DateColumn��$ Dátum��5?   B   $	 100 6Q      CellTemplate 5@      �� 5A      .R�5B      (	  "System.Windows.Controls.DatePicker	   	  SelectedDate 6)   �� *	Mark_Date+ �� Mode$ TwoWay=� �� NotifyOnValidationError .  �� ValidatesOnExceptions . 5C      5E      5G        5H   
   -   5        $ parentsDataGrid��5H      	 .  
 . $��449,64,10,297q�6   $ VisibleWhenSelected=�6�   $y�Visible=�6�   ��6g   ��  5I        5J      -    5        
nameColumn��$
 Név��5J   R   $	 100 6_    69   �� *Name+6_     5K      -!   5        first_NameColumn��$ Vezetéknév��5K   ^   $ SizeToHeader 6r    6?   �� *
First_Name+6r     5L      -"   5        last_NameColumn��$ Keresztnév��5L   \   $ SizeToHeader 6p    6>   �� *	Last_Name+6p     5M      -#   5        parent_Phone_NumberColumn��$ Telefonszám��5M   p   $ SizeToHeader 6�    6H   �� *Parent_Phone_Number+6�     5N      -$   5        parent_EmailColumn��$ 
Email cím��5N   b   $	 100 6u    6A   �� *Parent_Email+6u     5O      -%   5        parent_Student_IDColumn��$! Szülő tanuló azonosító��5O   l   $ 10 6�    6F   �� *Parent_Student_ID+6�   5Q      �� 5R   
   -&   5        $ depParLabel��5R      $��Osztályőnök adatok:��6%   $
��Left=�6C   $��
449,33,0,0q�6^   $	��Top=�6r     5S   
   -'   5        $ absentsDataGrid��5S      	 .  
 . $��449,312,10,46q�6�   $ VisibleWhenSelected=�6�   ��6g   �� # [  5T        5U      -(   5        student_Absent_IDColumn��$ Tanuló az.��5U   l   $ SizeToHeader 6�    6F   �� *Student_Absent_ID+6�     5V      -)   5        hoursColumn��$
 Óra��5V   T   $ SizeToHeader 6a    6:   �� *Hours+6a     5X      -*   5        absent_DateColumn��$ Dátum��5X   D   $	 100 6S    5Y      �� 5Z      .R�5[      	   6)   �� *Absent_Date+$ TwoWay=� .  . 5\      5^      5`        5a   
   -+   5        $ tDCDataGrid��5a      	 .  
 . $��449,268,10,46q�6�   $ VisibleWhenSelected=�6�   ��6c   �� # [  5b        5c      -,   5        tDC_Teacher_IDColumn��$ 
Tanár az.��5c   f   $ SizeToHeader 6y    6C   �� *TDC_Teacher_ID+6y     5d      --   5        tDC_Department_IDColumn��$ Osztály az.��5d   l   $ SizeToHeader 6�    6F   �� *TDC_Department_ID+6�     5e      -.   5        tDC_Course_IDColumn��$ Tanóra az.��5e   d   $ SizeToHeader 6x    6B   �� *TDC_Course_ID+6x   5g        5h   
   -/   5        $ departmentsDataGrid��5h      	 .  
 . $��449,64,10,223q�6�   $ VisibleWhenSelected=�6�   ��6k   �� # [  5i        5j      -0   5        department_IDColumn��$ Osztály az.��5j   d   $ SizeToHeader 6y    6B   �� *Department_ID+6y     5k      -1   5        department_Teacher_IDColumn��$ Osztályfőnök az.��5k   t   $ SizeToHeader 6�    6J   �� *Department_Teacher_ID+6�     5l      -2   5        department_NameColumn��$ Osztály neve��5l   H   $ SizeToHeader 6^    5m      �� 5n      .R�5o      �� ��6$   �� *Department_Name+5p      5r      5t      �� 5u   
   -3   5        $ 
classLabel��5u      $!��Órarend kialakításához:��6$   $
��Left=�6F   $��449,237,0,0q�6a   $	��Top=�6v   �� 5v   
   -4   5        $��Felhasználó felvétele��5v      $
��Left=�61   $	��Top=�6L   $	��121��6d   $��	11,10,0,0q�6p   6�     5w   
   -5   5        $ usersDataGrid��5w      	 .  
 . $��11,64,421,46q�6�   $ VisibleWhenSelected=�6�   $y�Hidden=�6�   ��6e   �� # [	  5x        5y      -6   5        user_IDColumn��$ Felhasználó az.��5y   X   $ SizeToHeader 6q    6<   �� *	User_ID+6q     5z      -7   5        user_NameColumn��$ Felhasználónév��5z   \   $	 125 6t    6>   �� *	User_Name+6t     5{      -8   5        passwordColumn��$ Jelszó��5{   Z   $	 125 6j    6=   �� *
Password+6j     5|      -9   5        user_Access_RankColumn��$' !Felhasználó hozzáférési rang��5|   j   $ * 6�    6E   �� *User_Access_Rank+6�   5~      5�      5�      