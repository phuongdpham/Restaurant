   M S B A M L   `   `   `  ����  RestaurantManager1!    RestaurantManager1.AddOrder   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5        N� Title$  	Add Order��5       N� 
Background
 �����.��5
      �  � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $
��0.8* �6   �� 5      $��4* �6   �� 5      $��* �6   .+�5   
   �� $��1��6    �� Orientation$ 
Horizontal=�6"   .+�5      �� $��	Table No:��6   $��20(�5      $��1��5      $��40��5      $
��Left=�5      $��10q�5      �� 5      -   5         ��Name$ 	tableNoCB��5      $��36��5      $	��100��5      $��Center=�5      $��10q�5      $��16(�5      $��Center=�5       5!      ]� 5"   
   $��2��6   .+�5#      &   System.Windows.Controls.DataGrid  -   5          Name$ gridMenu��5#         AutoGenerateColumns .  $	��371��6]   $
��Left=�6i   ��6)   ��    Columns 5$      0  *System.Windows.Controls.DataGridTextColumn  5%      -   5        stt��,  &System.Windows.Controls.DataGridColumn   Header$ No��5&      	   Width5  /System.Windows.Controls.DataGridLengthConverter$	 40 5(      
   
IsReadOnly
 . 1  +System.Windows.Controls.DataGridBoundColumn   Binding 5'      �� *DishId+5)        5+      -   5        nameCol��$
 Name��5,      $		 185 5.      
 .  5-      �� *Name+5/        51      $ Status��6)   
 .  6K   �� *Status+   ElementStyle 52      �� 53      .�54   "   ��  �� Property �@��TextAlignment �� Value$ Center=�6L   55      57        59      -   5        	price��$ Price��5;      $	 60 5<      
 .  5:      �� *Price+ 5?      �� 5@      .�5A   "   ��  �@��TextAlignment$ Right=�6L   5B      5D      5F      �� 5H      .+�5I      �� $��Your Order:��6   $��16(�5J       �� Left$ 10��5K      
 �� Top$ 10��5L      �� 5N      -   5         ��Name$ orderTB��5N      $ 10��5O      $ 46��5P       �� Right$ 10��5Q      $	��535��5R      �� 5T      $W��QAdd orders form like this: 1 2, 3 4; with 1 and 3 is dish ID, 2 and 4 is quantity��6   $
��Wrap=�5U      $ 10��5V      $ 77��5W      $��16(�5X      �� 5Z      -   5         ��Name$ addOrder��5Z      $��	Add Order��5[      $	 106��5\      $	 150��5]      5^      5a      5c      �� 5f   
   $��3��6   $ 
Horizontal=�6"   $��Right=�6;   .+�5g      �� -   5        $ mainPage��5g      $��	Main Page��5h      $��40��5i      $	��100��5j      $��5q�5k      6    �� 5m      -	   5        $ finishOrder��5m      $��Finish Order��5n      $��40��5o      $	��100��5p      $��Right=�5q      $��5q�5r      6   5s      5t      5u      