   M S B A M L   `   `   `  ����G  CHockey_Stats, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:Hockey_StatsHockey_Stats  5   	       Hockey_Stats.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:Hockey_Stats     5   	     � Title$  
MainWindow��5   	   $	��350��6   $	��525��6)   .��5
      �  � RowDefinitions 5   
    � ColumnDefinitions 5   
   �� 5      .+�5   
   �  � Orientation$ Vertical=�6   $��Center=�6+   $��Center=�5      .+�5      �� $��Hockey Stats App��6    �� Padding$ 10q�5      ��5      �� 5      .�5      ��  �� Property � �� �� Value$ 36(�6?   5      5      �� 5      -   5        $��createTeam_button��5      $��0q�6.   
�������$��Center=�5    (   $��16(�5!      $
��Bold"�6#   $��5q�5"      .��6A   Manage Team5$      �� 5%      -   5        $��gameStart_button��5%      $��0q�6-   
�������$��Center=�5&   (   $��16(�5'      $
��Bold"�6#   .��5(   4   
Game Start5*      50       � 52   
   -   5          �Name$ 	MainFrame��52        � NavigationUIVisibility$ Hidden=�6#   54      55      