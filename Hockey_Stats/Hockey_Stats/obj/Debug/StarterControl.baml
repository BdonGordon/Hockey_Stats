   M S B A M L   `   `   `  ����G  CHockey_Stats, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:Hockey_StatsHockey_Stats  5      !    Hockey_Stats.StarterControl   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ,localclr-namespace:Hockey_Stats     5      .��5	      � 
�������  � RowDefinitions  5
   
   �� 5      $
��0.2* �6   �� 5      $
��0.2* �6   �� 5      .+�5   
   �� -   5        $��team_name_Start��5      $��0��6'   $
��Team��64   $��22(�6C   $��Bottom=�6Q   $��Center=�5      �� 5   
   -   5        $��position_Notifier��5      $��1��6)   $ ��Please select starting LW:��66   $	��Top=�6[   $��Center=�5      � 5   
   -   5        $��players_Section��5      $��2��6'   .+�5      �   5      �� 5      �� 5      �� 5      �� 5      �� 5       � ColumnDefinitions 5      �� 5      �� 5       �� 5!      �� 5"      �� 5#      .+�5(      �� -   5        $��player_1��5(      $��0��6)   $��0��66   $��51��6F   $	��6,3q�6T   
�������
�������$
��Bold"�5)   C   6U   �� 5*      -   5        $��player_2��5*      $��0��6)   $��1��66   $��52��6F   $	��6,3q�6T   
�������
�������$
��Bold"�5+   C   6U   �� 5,      -   5        $��player_3��5,      $��0��6)   $��2��66   $��53��6F   $	��6,3q�6T   
�������
�������$
��Bold"�5-   C   6U   �� 5.      -   5        $��player_4��5.      $��0��6)   $��3��66   $��54��6F   $	��6,3q�6T   
�������
�������$
��Bold"�5/   C   6U   �� 50      -   5        $��player_5��50      $��0��6)   $��4��66   $��55��6F   $	��6,3q�6T   
�������
�������$
��Bold"�51   C   6U   �� 53      -	   5        $��start_Button��53      $��4��6-   $��4��6=   $��Start��6J   6Z   54      55      56      57      