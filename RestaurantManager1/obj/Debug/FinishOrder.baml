   M S B A M L   `   `   `  ����  RestaurantManager1$    RestaurantManager1.FinishOrder   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5        N� Title$  Finish Order��5      .��5
      � 
������� � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��4* �6   �� 5      $��* �6   .+�5   
   ��  �� Orientation$ 
Horizontal=�6   $��1��6.   .+�5      &   System.Windows.Controls.DataGrid  -   5          Name$ 
gridResult��5         AutoGenerateColumns .  $	��540��6_   $
��Left=�6k   $��10, 0, 0, 0q�6�   ��6+   ��    Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Table No��6)      Width5  /System.Windows.Controls.DataGridLengthConverter$ 80 6;   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6F   �� *	TableNo+  5      $ DishId��6)   $ 60 69    6D   �� *DishId+  5      $
 Name��6)   $	 200 67    6C   �� *Name+  5      $ 
Unit Price��6)   $	 100 6=    6I   �� *Price+  5      $ Quantity��6)   $	 100 6;    6G   �� *
Quantity+5      �� 5      $��10, 0, 0, 0q�6   .+�5      �� $��Enter your table no:��6   $��16(�67   	 �� Left$	 10��6E   

 �� Top$
 0��6V   �� 5      -   5         ��Name$
 tbCB��5      $��50��6)   $		 165��64   $
 5��6F   �� 5      $��Total:��6   $��16(�6)   $	 10��67   $
 50��6H   �� 5       -   5         ��Name$ totalTBl��5       $	 64��6.   $
 55��6?   $��26��6O   $��0��6[   $��16(�6d   $
��Auto��6r   �� 5!      $��(VND)��6   $��16(�6(   $		 219��66   $
 50��6H   �� 5"      -   5         ��Name$ 
getReusult��5"      $��
Get Result��6-   $	 10��6B   $
 90��6S   6c   �� 5#      -   5        $ clearOrders��5#      $��Clear orders��6.   $	 90��6E   $
 90��6V   6f   5$      5&      5(      5)      