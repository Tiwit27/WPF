   M S B A M L   `   `   `  ����I  EWPF_Tutorial_8, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:WPF_Tutorial_8WPF_Tutorial_8  5          WPF_Tutorial_8.MainWindow   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      .localclr-namespace:WPF_Tutorial_8     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5        � Title$  
MainWindow��5      $	��400��5	      $	��400��5
      .��5      �  � RowDefinitions 5   
   �� 5      $��75 �5      �� 5       � ColumnDefinitions 5   
   �� 5      �� 5      .+�5   
   �� -   5        $��txtEntry��5      $��35��5      $��16(�5      �� 5   
   -   5        $��btnAdd��5      $��1��5      $��50��5      $
��Left=�5      $	��Add��5!      �� 5"   
   -   5        $��	btnDelete��5#      $��1��5$      $��50��5%      $��60,0,0,0q�5&      $
��Left=�5'      $	��Del��5)      �� 5*   
   -   5        $��btnClear��5+      $��1��5,      $��50��5-      $��	120,0,0,0q�5.      $
��Left=�5/      $��Clear��51      �� 53   
   -   5        $��	lvEntries��54      $��1��55      $��2��56      ��57      �� *	Entries+ �� SelectedItem 58      �� *SeletedItem+5:      5;      