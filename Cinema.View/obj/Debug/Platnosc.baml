   M S B A M L   `   `   `  ����F  BCinema.View, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:Cinema.ViewCinema.View  5   	       Cinema.View.Platnosc   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:Cinema.View     5   	     � Title$  Płatność��5   	   $��272.5��6   $	��600��6)    � 
ResizeMode$ NoResize=�65   .��5	      � |�. ��5
   
   �� 5       �� EndPoint$ 0.5,1&�6"    �� 
StartPoint$ 0.5,0&�63   .��5      �  � Color$ 	#FF4D6CB3��6    � Offset$ 0Q�61   � 5      $ White��6   $
 0.88Q�6-   5      .+�5   
   �� $��Informacje o płatności:��6   $
��Left=�64   $��	10,37,0,0q�6O   $	��Top=�6b   $	��177��6z   $	��561��6�   $��20(�6�   �� 5   
   -   5         ��Name$ CreditCardNumber_label��5   �   $��Numer Karty Kredytowej:��6   
���  ��$
��Left=�6D   $��	26,81,0,0q�6_   $	��Top=�6r   $	��141��6�   6�   �� 5   
   -   5         ��Name$ CreditCardNumber_textbox��5   �   $
��Left=�6   $��25��6-   $��
172,82,0,0q�69    �� TextWrapping$
 Wrap=�6M   $	��Top=�6a   $	��115��6y   	 �� 	MaxLength$	 16��6�   
 J� RenderTransformOrigin$
 
0.978,0.68&�6�   �� 5   
   -   5        $��Zapłać��5      $
��Left=�6"   $��460,178,0,0q�6=   $	��Top=�6R   $��75��6j    �� 	IsDefault .  � Cursor$
 Hand��6�    J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         Color$ 	#FF739CE2��6#      Opacity$	 0.7Q�65   5      �� 5   
   -   5        $��Anuluj��5      $
��Left=�6"   $��378,178,0,0q�6=   $	��Top=�6R   $��75��6j   $
 Hand��6�   4  .System.Windows.Automation.AutomationProperties   HelpText$ Go Back to the Shadow��6�    �� 	ClickMode$ Press=�6�    � UseLayoutRounding .   5        5      $ 	#FF739CE2��6#   $	 0.5Q�65      ShadowDepth$ 3Q�6C   5      �� 5   
   $��System płatności:��6   $
��Left=�6,   $��
314,82,0,0q�6G   $	��Top=�6[   $��28��6s   �� 5   
   -   5         ��Name$ Type_combobox��5   f   $
��Left=�6   $��
415,82,0,0q�6.   $	��Top=�6B   $	��120��6Z   .@�5       �� $
��Visa��6   $
��Left=�6*   $	��118��6E   �� 5!      $��Master Card��6   $
��Left=�61   $	��118��6L   5"      �� 5#   
   $��Data Ważności (mm/yy):��6   $
��Left=�61   $��
26,119,0,0q�6L   $	��Top=�6`   $	��141��6x   �� 5$   
   $��Kod :��6   $
��Left=�6    $��350,123,0,0q�6;   $	��Top=�6P   $��65��6h   �� 5%   
   -   5        $ ExpireDateMm_textbox��5%   �   $
��Left=�6   $��23��6-   $��172,123,0,0q�69   $
 Wrap=�6N   $	��Top=�6b   $��49��6z   $	 2��6�   �� 5&   
   -   5        $ ExpireDateYy_textbox��5&   �   $
��Left=�6   $��23��6-   $��238,124,0,0q�69   $
 Wrap=�6N   $	��Top=�6b   $��49��6z   $	 2��6�   �� 5'   
   $��/��6   $
��Left=�6   $��221,121,0,0q�67   $	��Top=�6L   $��28��6d   $��16��6p   $
 0.938,0.536&�6{   G� 5(   
   -   5         G�Name$ SecurityCode_passwordBox��5(   �   $
��Left=�6   $��415,123,0,0q�61   $	��Top=�6F   $	��120��6^   $��22��6j    G� 	MaxLength$ 3��6v   6�   5*      5+      