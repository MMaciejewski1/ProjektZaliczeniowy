   M S B A M L   `   `   `  ����F  BCinema.View, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:Cinema.ViewCinema.View  5   	       Cinema.View.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:Cinema.View     5   	     � Title$  Movie Showtimes��5   	   $��365.889��6!   $��587.778��62    � 
ResizeMode$ NoResize=�6B   .��5	      � $��
0,0,-6.4,4q�6   ��5
   
   �� 5       �� EndPoint$ 0.5,1&�6"    �� 
StartPoint$ 0.5,0&�63   .��5      �  � Color$ 	#FF4D6CB3��6    � Offset$ 0.064Q�61   � 5      $ White��6   $
 0.63Q�6-   5      .+�5   
   �� $��	Repertuar��6   $
��Left=�6&   $��	10,37,0,0q�6A   $	��Top=�6T   $	��263��6l   $	��543��6y   $��20(�6�   .��5      �� -   5        $��listView��5      $��20,74,188,43q�6'   $��14(�6j    �� View 5      �� 5      .P�5      �� $��Title��6)    �� Width$
 auto��68    �� DisplayMemberBinding 6F   �� *Title+5      5      5      �� 5   
   -   5        $��
filmsHours��5      $��373,140,55,0q�6%   $��14(�6e   $��94��6s   $	��Top=�6   (  "System.Windows.Controls.DatePicker  5   
   -   5        	  Name$	 calendar��5      $��
137,83,0,0q�6'   $	��Top=�6<   $
��Left=�6T   $	��161��6o   $��24��6�   
   SelectedDateFormat$
 Short=�6�   �� 5   
   -   5        $��Info o filmie��5      $
��Left=�6)   $��
36,269,0,0q�6D   $	��Top=�6X   $��96��6p   $��26��6�   ���	#FFF4F7FC���	#FF5879B0 � Cursor$	 Pen��6�    J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         Color$ 	#FF739CE2��6#      Opacity$	 0.5Q�65      ShadowDepth$ 3Q�6C   5       �� 5!   
   -   5        $��Dalej��5!      $
��Left=�6!   $��26��6<   $��433,269,0,0q�6H   $	��Top=�6]   $��96��6u    J� RenderTransformOrigin$ 0.562,-0.208&�6�    �� 	IsDefault . $
 Hand��6�   ���	#FFF4F7FC 5"        5#      $	 0.7Q�6#   $ 	#FF739CE2��61   5%      �� 5&   
   -   5         ��Name$ label1��5&      $��Wybierz dzień:��6    $	��Top=�69   $��35,81,408,0q�6Q   $��25��6f   �� 5'   
   -   5        $ label2��5'      $��Wybierz godzinę:��6    $��373,112,55,0q�6;   $	��Top=�6Q   $ 0.316,6.385&�6i   �� 5(   
   -   5        $ label3��5(      $��Wybrany film:��6    $	��Top=�68   $��35,112,379,0q�6P   $��25��6f   �� 5)   
   -	   5        $ wybranyFilm��5)      $�� ��6%   $
��Left=�60   $��131,112,0,0q�6K   $	��Top=�6`   $	��172��6x   �� 5*   
   -
   5        $��Wstecz��5*      $
��Left=�6"   $��26��6=   $��324,269,0,0q�6I   $	��Top=�6^   $	��104��6v   ���	#FFF4F7FC$
 Hand��6�    5+        5,      $	 0.5Q�6#   $ 	#FF739CE2��61   $ 3Q�6C   5.      5/      50      