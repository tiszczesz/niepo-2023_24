   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1  5   	       WpfApp1.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp1     5   	     � Title$  Okno główne��5   	   $	��300��6   $	��600��6*   .��5	      �  � RowDefinitions 5
   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6    � ColumnDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   .+�5   
   �� -   5         ��Name$ label��5      $��0��5      $��0��6   $��Witaj świecie��5      $��Center=�5      $��5,5,5,5q�5      �� 5   
   -   5         ��Name$ button��5      $��Klilknij mnie��6"   $��0��5      $��1��5      $��Center=�5      $	��276��6,   �� 5   
   -   5        $ label1��5   -   $��0��6   $��2��6   $��Label��6=   $��Center=�6M   $��Center=�6j   $��26��6�   $��84��6�   &   System.Windows.Controls.Calendar  5   
   -   5          Name$ calendar��5       $��1��5      $��0��6   5       �� 5!   
   -   5        $ label2��5!      $��1��6    $��1��6-   $��Label��6=   $��Center=�6M   $��0,10,0,0q�6j   $	��Top=�6}   $	��256��6�   $��64��6�   �� 5"   
   $��2��6   $��1��6%   $	��NaN��62   $��	0,0,0,-70q�6?   $	��NaN��6R   .+�5#      �� -   5        $ button1��5#      $��	Nowe okno��6'   $
��Left=�6;   $��	10,10,0,0q�6V   $	��Top=�6j   $	��125��6�   $��52��6�   6�   �� 5$      -   5        $ button2��5$      $��2��6&   $
��NWD ��66   $
��Left=�6E   $��	10,10,0,0q�6`   $��1��6s   $	��Top=�6�   $	��125��6�   $��52��6�   6�   5%      5(      5)      