   M S B A M L   `   `   `  ����V  RКонтроль цехов, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullQ-clr-namespace:УППО_Пропуски.PagesУППО_Пропуски.Pages  5      1    +УППО_Пропуски.Pages.ForemanPage   5      W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ?local-clr-namespace:УППО_Пропуски.Pages     5      -   5        $	��350��5      $	��900��6@     N� Title$  ForemanPage��5	      .��5      �  � ColumnDefinitions 5   
   �� 5      $��0.05* �6   �� 5      �� 5      $��0.05* �6    � RowDefinitions 5   
   �� 5      $��0.05* �6   �� 5      �� 5      $��0.05* �6   .+�5   
   � $��1��6   $��1��6    5      �� 5      $��50 �6    �� 5       5      �� 5      �� 5      $
��auto �6#   .+�5       �� -   5         ��Name$ TabControlMain��5       $��2��61   $��2��6B   .@�5!      ��    MainTabItem#���   6   ��5"      �� 5#      $+��%../Assets/Button Icons/table-icon.png��6    $��40��6O    � ToolTip$  В виде таблицы��6Z   .��5%      &   System.Windows.Controls.DataGrid  -   5          Name$ EmployeesDataGrid��5%         AutoGenerateColumns$ False��6:      
IsReadOnly$
 True��6V    �� AlternationCount$ 1��6h   ���	#FFD3D9FF	   AlternatingRowBackground	 �	#FFECEFFF
   GridLinesVisibility$
 
Horizontal=�6�      HorizontalGridLinesBrush �	#FF80ABFF   CanUserAddRows$ False��6�      CanUserDeleteRows$ False��6     CanUserResizeRows$ False��60     Columns 5&      0  *System.Windows.Controls.DataGridTextColumn  5'      ,  &System.Windows.Controls.DataGridColumn   Header$ Фамилия��61      FontSize$ 20Q�6B      Width5  /System.Windows.Controls.DataGridLengthConverter$
 auto 6P   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6]   ��  �� Path$ Surname�  5(   "   $ Имя��65   $ 20Q�6B   $
 auto 6P    6]   �� $
 Name�  5)   "   $ Отчество��65   $ 20Q�6G   $
 auto 6U    6b   �� $ 
Patronomic�  5*   "   $ Пол��65   $ 20Q�6B   $
 auto 6P    6]   �� $ Gender�  5+   "   $ День рождения��65   $ 20Q�6L   $
 auto 6Z    6g   �� $ BirthdateShortString�  5,   "   $  Подразделение��65   $ 20Q�6L   $
 auto 6Z    6g   �� $ DivisionName�  5-   "   $ Статус��65   $ 20Q�6E   $
 auto 6S    6`   �� $ Status�  5.   "   $ Подтвержден��65   $ 20Q�6J   $
 auto 6X    6e   �� $ IsVerificatedString�  5/   "   $1 +Проходить в другие цеха��65   $ 20Q�6V   $
 auto 6d    6q   �� $" StringCanVisitOtherWorkshops�51      52      �� 53      #���   6   ��54      �� 55      $ В виде списка��6    $*��$../Assets/Button Icons/list-icon.png��68   $��40��6f   .��57      �� -   5         ��Name$ EmployeesListBox��57      
����  �$��Stretch=�6O   58      59      �� 5;      -   5         ��Name$ SearchTextBox��5;   ?     MainTextBox#���  6   $��0��6V   $	��Top=�6c   $��110,10,60,0q�6{   6�   �� 5<      -   5         ��Name$ SearchTextBlock��5<      $M��GВведите текст чтобы найти сотрудника...��61   $	��Top=�6`   $
��Left=�6x   $��130,10,50,0q�6�   ���	#FFE9F7FF6�   �� 5>      -   5         ��Name$ SendRequestButton��5>   :     
MainButton#���  6   ���	#FFE9F7FF$8 2Отправить служебный запрос��6l   $��Right=�6�   .��5?      �� $.��(../Assets/Button Icons/send-document.png��6   $��40��6J   $��40��6U   5@      �� 5B      -   5        $ 
QuitButton��5B      #���  6   
���  �����	#FFFF8787$��Right=�6c   $$ Выйти из системы��6�   $��1��6�   .��5C      �� $%��../Assets/Button Icons/exit.png��6   $��5q�6A   $��40��6L   5D      5F      5G      5H      