   M S B A M L   `   `   `  ����F  BCinema.View, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:Cinema.ViewCinema.View  5   	       Cinema.View.InfoOFilmie   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:Cinema.View     5   	     � Title$  Movie Information��5   	   $��510.305��6#   $��920.149��64    � AllowsTransparency .  � WindowStyle$
 None=�6^    J� OpacityMask 5	      �� 5
   
    �� EndPoint$ 0.5,1&�6    �� 
StartPoint$ 0.5,0&�6/   .��5      �  � Color$ 	#FF4D6CB3��6    � Offset$ 0Q�6-   � 5      $ White��6   $ 1Q�6)   5      .��5      � $��10,32,18,11q�6    � RowDefinitions 5   
   �� 5      $
��407* �6   �� 5      .+�5   
   �� $��Informacje o filmie:��6   $
��Left=�61   $	��875��6L   $��20(�6X   $��0,-4,0,0q�6f   $	��416��6x   $	��Top=�6�   .��5      �� -   5        	 ��Name$	 	opisZBazy��5      $
��Left=�6)   $	��212��6D   $��510,113,0,0q�6Q   
 �� TextWrapping$

 Wrap=�6f   $	��Top=�6z   $	��336��6�    J� RenderTransformOrigin$ 0.5,0.5&�6�   $��12(�6�   $��0q�6�   |�.   J� 	AllowDrop .  .��6  z�5      V� 5      .~�5      �� �� 5       �� AngleX$ -1.054Q�6(   �� 5      T� 5       T� X$ -0.782Q�6-   5      .��5   +   5      5      �� 5    
   -   5         ��Name$ image��5       $
��Left=�6   $	��355��6:   $��	25,39,0,0q�6G   $	��Top=�6Z   $	��314��6r   �� 5!   
   -   5         ��Name$ obsada��5!      $��Obsada:��6    $
��Left=�62   $��
449,33,0,0q�6M   $	��Top=�6a   $ -0.526,0.591&�6y   $��26��6�   $��60��6�   �� 5"   
   -   5        $ rezyser��5"      $��	Rezyser: ��6!   $
��Left=�65   $��
449,65,0,0q�6P   $	��Top=�6d   $ -0.242,0.525&�6|   $��26��6�   $��60��6�   �� 5#   
   -   5        $ dlugosc��5#      $��Długość trwania: ��6!   $
��Left=�6=   $��
405,95,0,0q�6X   $	��Top=�6l   $ 0.448,2.416&�6�   $��26��6�   $	��104��6�   �� 5$   
   -   5        $
 opis��5$      $��Opis: ��6   $
��Left=�6/   $��465,127,0,0q�6J   $	��Top=�6_   $ 0.498,-0.834&�6w   $��26��6�   $��40��6�   �� 5%   
   -   5        $ obsadaZBazy��5%      $
��Left=�6%   $��
509,33,0,0q�6@   $	��Top=�6T   $	��345��6l   $ 0.5,0.5&�6x   $��26��6�   �� 5&   
   -   5        $ rezyserZBazy��5&      $
��Left=�6'   $��
509,65,0,0q�6B   $	��Top=�6V   $ 2.022,4.151&�6n   $	��345��6�   $��26��6�   �� 5'   
   -	   5        $ dlugoscZBazy��5'      $
��Left=�6'   $��
509,95,0,0q�6B   $	��Top=�6V   $ 0.836,2.123&�6n   $	��345��6�   $��26��6�   �� 5(   
   -
   5         ��Name$ powrot��5(      $��Zamknij��6!   $
��Left=�63   $��760,370,0,0q�6N   $	��Top=�6c   $��94��6{   $��30.933��6�   $ -1.452,2.95&�6�    �� IsCancel .  � UseLayoutRounding .   � Cursor$
 Hand��6�   4  .System.Windows.Automation.AutomationProperties   HelpText$ Go to the Shadow��6     IsOffscreenBehavior$ FromClip=�68   �� 	IsDefault .  � ContextMenu 5)      �� 5*      $��Italic$�6   $��Black"�61    J� Effect 5,      3  -System.Windows.Media.Effects.DropShadowEffect  5-         Color$ 	#FFEADADA��6#      RenderingBias$ Quality=�65      Opacity$	 0.7Q�6M   5/      50      51      