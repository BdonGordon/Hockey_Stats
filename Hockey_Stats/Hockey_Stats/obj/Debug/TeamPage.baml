   M S B A M L   `   `   `  ����G  CHockey_Stats, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:Hockey_StatsHockey_Stats  5          Hockey_Stats.TeamPage   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ,localclr-namespace:Hockey_Stats     5        N� Title$  TeamPage��5	       � 	Resources 5          BooleanToVisibilityConverter  EntryFieldStyle �� 
TargetType �� Property �� Value��%�   &	        &	      �� 5   
   6'   �� 5   
   " �6(   .�5      ��  � ��$ Stretch=�64   �� 5       � ��$ Center=�62   �� 5       � ��$
 20,0q�6'   5      5      .��5      � 
������� � RowDefinitions 5   
   �� 5      6   �� 5      $��6* �6   6*   .+�5   
   �� $	��5,2q�6   $��	Team Name��6!   $��0��62   $��20(�5      
�������$��Center=�5       $��Center=�62   y�5      ��  �� ElementName$ teamName_Input�� �� Path$ Text.IsEmpty� �� 	Converter# [  5    2   �� 5!   
   -   5        $��teamName_Input��5!      
������ $��0��6A   $��20(�5"      $��Center=�6#   $��Center=�6@   $	��105��5#      $��0q�6$   �� 5'   
   $��1��6   ��. 	 �� PanningMode$	 VerticalOnly=�5(      .��5)      � -   5        $��
Inner_Grid��5)       5*      �� 5+      $
��Auto �6$   �� 5,      $
��Auto �6$   �� 5-      $
��Auto �6$   �� 5.      $
��Auto �6$   �� 5/      $
��Auto �6$   �� 50      $
��Auto �6$   �� 51      $
��Auto �6$   �� 52      $
��Auto �6$   �� 53      $
��Auto �6$   �� 54      $
��Auto �6$   �� 55      $
��Auto �6$   �� 56      $
��Auto �6$   �� 57      $
��Auto �6$   �� 58      $
��Auto �6$   �� 59      $
��Auto �6$   �� 5:      $
��Auto �6$   �� 5;      $
��Auto �6$   �� 5<      $
��Auto �6$   �� 5=      $
��Auto �6$   �� 5>      $
��Auto �6$   �� 5?      $
��Auto �6$   �� 5@      $
��Auto �6$   �� 5A      $
��Auto �6$   �� 5B      $��40 �6$   
 � ColumnDefinitions
 5F      �� 5G      $
��Auto �6'   �� 5I      $
��Auto �6'   �� 5K      $
��Auto �6'   �� 5M      $
��Auto �6'   �� 5N      $
��Auto �6'   .+�5U      �� -   5        $��add_player_Text��5U      $��21��60   $��Bottom=�6>   
������ $��0q�5V   3   $	��5,2q�5W      $��Right=�6&   $
��30,0q�6B   .��5X      �� $��+ Add Player��6     �� TextEffects 5Z      z�  z� PositionStart$ 0��6)    z� PositionCount$ 1��6;    z� 
Foreground
 � � �6M   5\      5]      �� 5^      -   5        $��submit_button��5^      $��23��6.   $��Bottom=�5_      $��50��65   .��6@   Save5`      �� 5a      -   5        $��cancel_button��5a      $��23��6.   $��2��6<   $��Bottom=�5b      $��50��64   .��6\   	Discard5d      5i      5j       � 5k   
   -   5          �Name$ 	TeamFrame��5k        � NavigationUIVisibility$ Hidden=�6#   5l      5n      