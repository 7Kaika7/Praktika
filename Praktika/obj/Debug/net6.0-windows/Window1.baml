   M S B A M L   `   `   `  ����C  ?Praktika, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:PraktikaPraktika  5   	       Praktika.Window1   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:Praktika     5   	     � Title$  
MainWindow��5      $	��450��6   $	��600��6,   ���	#FF167682
�������.��5	      �  � ColumnDefinitions 5
   
   �� 5      �� 5       � RowDefinitions 5   
   �� 5      �� 5      .+�5   
   �� $��Регистрация��6   $��2��6(   $��0��6<   $
��Left=�6I   $	��Top=�6d   $��25(�6|   $��
225,33,0,0q�6�   $��Segoe Print)�6�   �� 5   
   $��
Логин��6   $��0��6!   $��Center=�6.   $	��Top=�6K   $��25(�6c   $��	0,109,0,0q�6q   $��Segoe Print)�6�   �� 5   
   -   5         ��Name$ login��5      $��1��6!   $��0��61   $��Center=�6>   $	��Top=�6[   $��30��6s   $	��200��6   $��20(�6�   $��	0,112,0,0q�6�   $��Segoe Print)�6�   �� 5   
   $��Пароль��6   $��Center=�6"   $	��Top=�6?   $��25(�6W   $��Segoe Print)�6e   $��	0,177,0,0q�6~   $��2��6�   �� 5   
   -   5        $ 
povt_parol��5      $��1��6&   $��1��66   $��Center=�6C   $	��Top=�6`   $��30��6x   $	��200��6�   $��20(�6�   $��Segoe Print)�6�   $��0,37,0,0q�6�   �� 5   
   $%��Повторите пароль��6   $��1��6,   $
��Left=�69   $	��Top=�6T   $��25(�6l   $��Segoe Print)�6z   $��	27,30,0,0q�6�   �� 5   
   -   5        $ parol��5      $��1��6!   $��Center=�61   $	��Top=�6N   $��30��6f   $	��200��6r   $��20(�6   $��Segoe Print)�6�   $��	0,187,0,0q�6�   �� 5   
   -   5        $��Вернуться��5      $��2��6%   $��1��69   $
��Left=�6F   $	��Top=�6a   $��35��6y   $	��200��6�   $��20(�6�   $��200,149,0,0q�6�   $��Segoe Print)�6�   $
��Bold"�6�   6�   �� 5   
   -   5        $*��$Зарегистрироваться��5      $��2��6/   $��1��6C   $
��Left=�6P   $	��Top=�6k   $��35��6�   $	��300��6�   $��20(�6�   $��150,102,0,0q�6�   $��Segoe Print)�6�   $
��Bold"�6�   6�   5      5      