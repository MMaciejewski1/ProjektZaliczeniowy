   M S B A M L   `   `   `  ����F  BCinema.View, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:Cinema.ViewCinema.View  5   	   !    Cinema.View.AllFilmsPreview   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:Cinema.View     5   	     � Title$  AllFilmsPreview��5   	   $��675.5��6!   $��683.695��60   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $	��99* �6   �� 5      $	��47* �6   .+�5   
   �� -   5         ��Name$ 	filmsList��5      $
��Left=�6&   $	��600��6A   $��	10,10,0,0q�6N   $	��Top=�6a   $	��438��6y    �� View 5      �� 5      .P�5      �� $��Title��6%    �� Width$
 auto��64    �� DisplayMemberBinding 6B   �� *Title+�� 5      $��Image��6%   $
 auto��64    �� CellTemplate 5      �� 5      .R�5   "   �� $	��200��6D   $	��200��6P   ��6(   �� *
imageSrc+6P   5      5      5      5      �� 5   
   -   5        $ dateList��5      $
��Left=�6%   $	��100��6@   $��	27,36,0,0q�6M   $	��Top=�6`   $	��169��6x   $��1��6�    5      �� 5      .P�5      �� 5       5"      �� 5#   
   -   5        $ hourList��5#      $
��Left=�6%   $	��100��6@   $��
27,162,0,0q�6M   $	��Top=�6a   $	��169��6y   $��1��6�    5$      �� 5%      .P�5&      �� 5'      5)      �� 5*   
   -   5         ��Name$ 	dateLabel��5*      $��Wybierz datę:��6#   $
��Left=�6;   $��	27,10,0,0q�6V   $	��Top=�6i   $	��112��6�   $��1��6�   �� 5+   
   -   5        $ 	hourLabel��5+      $��Wybierz godzinę:��6#   $
��Left=�6>   $��
27,136,0,0q�6Y   $	��Top=�6m   $	��112��6�   $��1��6�   �� 5,   
   -   5         ��Name$ button��5,      $��	Kup bilet��6!   $��1��65   $
��Left=�6E   $��
50,308,0,0q�6`   $	��Top=�6t   $��74��6�   6�   5.      5/      