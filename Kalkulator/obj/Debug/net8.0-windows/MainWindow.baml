   M S B A M L   `   `   `  ����E  AKalkulator, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:Kalkulator
Kalkulator  5      K*clr-namespace:Kalkulator.View.userControlsKalkulator.View.userControls  5          Kalkulator.MainWindow   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      *localclr-namespace:Kalkulator     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      CuserControls*clr-namespace:Kalkulator.View.userControls     5        � Title$  
MainWindow��5	      $	��400��5
      $	��700��5      ���#7edfe6.��5      � $��15q�6    � RowDefinitions 5   
   �� 5      �� 5      $
��0.4* �6   �� 5      �� 5      �� 5      �� 5      �� 5       � ColumnDefinitions 5   
   �� 5      �� 5      �� 5      �� 5      .+�5   
   �� -   5        $��
textVisual��5      $��4��5       $��5q�5!      $��Stretch=�5"      $��Center=�5#      ���#60D9E2
���   �$��2q�5&      $��60(�5'       �� 
IsReadOnly$
 True��5(      $��0��5)       �� TextAlignment$ Right=�5*      .��6#    � 	Resources 5+       �� 
TargetType �� Property �� Value��%^   '��       �� 5,      " ��6   .�5-      ��  �@��CornerRadius$ 5��65   5.      5/      .��6!   50      /   )Kalkulator.View.userControls.NumberButton  51   
   $��3��52      $��0��53      	   
NumberText$	 7��54        55   
   $��3��56      $��1��57      $	 8��58        59   
   $��3��5:      $��2��5;      $	 9��5<        5=   
   $��4��5>      $��0��5?      $	 4��5@        5A   
   $��4��5B      $��1��5C      $	 5��5D        5E   
   $��4��5F      $��2��5G      $	 6��5H        5I   
   $��5��5J      $��0��5K      $	 1��5L        5M   
   $��5��5N      $��1��5O      $	 2��5P        5Q   
   $��5��5R      $��2��5S      $	 3��5T        5U   
   $��6��5V      $��0��5W      $��2��5X      $	 0��5Y        5[   
   $��2��5\      $��3��5]      
   BackgroundColor$
 #60f062��5^         MethodChoose$ Make_Calkulation=�5_      $	 x��5`      
���   �6     5a   
   $��3��5b      $��3��5c      $
 #60f062��5d      $ Make_Calkulation=�5e      $	 ÷��5f        5g   
   $��4��5h      $��3��5i      $
 #60f062��5j      $ Make_Calkulation=�5k      $	 -��5l        5m   
   $��5��5n      $��3��5o      $
 #60f062��5p      $ Make_Calkulation=�5q      $	 +��5r        5s   
   $��6��5t      $��3��5u      $
 #60f062��5v      $ 	Calculate=�5w      $	 =��5x        5y   
   $��6��5z      $��2��5{      $	 Dot=�5|      $	 .��5}        5~   
   $��2��5      $��2��5�      $
 #3987ed��5�      $ DelLast=�5�      $	 <-��5�        5�   
   $��2��5�      $��0��5�      $��2��5�      $
 #db2c2c��5�      $ Clear=�5�      $	 C��5�      5�      5�      