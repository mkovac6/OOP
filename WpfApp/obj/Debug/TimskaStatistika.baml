   M S B A M L   `   `   `  ����A  =WpfApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:WpfAppWpfApp  5   	   5clr-namespace:WpfApp.PropertiesWpfApp.Properties  5   	       WpfApp.TeamShowcaseWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:WpfApp     5   	   6
propertiesclr-namespace:WpfApp.Properties     5   	     � WindowStartupLocation$  CenterOwner=�5	   	    � Title$ TeamShowcaseWindow��5
   	   $	��450��6$   $	��800��61    � Triggers 5      :� 5   
    :� RoutedEvent$ Loaded��6   .[�5      �� .��5      ��  g� Duration$ 
00:00:00:5D�6    �� TargetProperty$ Opacity�63   .��5      W�  W� From$ 0X�6&   	 W� To$ 1X�6/   5      5      5      .��5      �  � RowDefinitions 5   
   �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      .+�5!   
   �� -   5        $��lblHeadline��5!      $��Center=�6D   $��20(�6a   $��	ExtraBold"�6o   ��6#   �� 	 �� Path$	 Country�6o   �� 5"   
   -   5        $��lblCode��5"      $��1��6   $��Center=�6N   $��20(�6k   $
��Bold"�6y   ��6,   �� $	 FifaCode�6y   �� 5#   
   $��2��6   $��Played Games��6   $��Center=�65   $��12(�6R   $��DemiBold"�6`   $	��Top=�6v   �� 5$   
   -   5        $��lblMatchesPlayed��5$      $��2��6(   $��Center=�6[   $��12(�6x   $��DemiBold"�6�   $��Bottom=�6�   ��65   �� $	 GamesPlayed�6�   �� 5%   
   $��3��6   $��	Won Games��6   $��Center=�62   $��12(�6O   $��DemiBold"�6]   $	��Top=�6s   �� 5&   
   -   5        $��lblMatchesWon��5&      $��3��6%   $��Center=�6Q   $��12(�6n   $��DemiBold"�6|   $��Bottom=�6�   ��62   �� $
	 Wins�6�   �� 5'   
   $��4��6   $��Drawn Games��6   $��Center=�64   $��12(�6Q   $��DemiBold"�6_   $	��Top=�6u   �� 5(   
   -   5        $��lblMatchesDrawn��5(      $��4��6'   $��Center=�6T   $��12(�6q   $��DemiBold"�6   $��Bottom=�6�   ��64   �� $	 Draws�6�   �� 5)   
   $��5��6   $��
Lost Games��6   $��Center=�63   $��12(�6P   $��DemiBold"�6^   $	��Top=�6t   �� 5*   
   -   5        $��lblMatchesLost��5*      $��5��6&   $��Center=�6T   $��12(�6q   $��DemiBold"�6   $��Bottom=�6�   ��63   �� $	 Losses�6�   �� 5+   
   $��6��6   $��Scored Goals��6   $��Center=�65   $��12(�6R   $��DemiBold"�6`   $	��Top=�6v   �� 5,   
   -   5        $��lblGoalsScored��5,      $��6��6&   $��Center=�6V   $��12(�6s   $��DemiBold"�6�   $��Bottom=�6�   ��63   �� $	 GoalsFor�6�   �� 5-   
   $��7��6   $��Taken Goals��6   $��Center=�64   $��12(�6Q   $��DemiBold"�6_   $	��Top=�6u   �� 5.   
   -   5        $��lblGoalsTaken��5.      $��7��6%   $��Center=�6Y   $��12(�6v   $��DemiBold"�6�   $��Bottom=�6�   ��62   �� $	 GoalsAgainst�6�   �� 5/   
   $��8��6   !   WpfApp.Properties.Resources
   
lblGoalDif#��Z
 6   $��Center=�6S   $��12(�6p   $��DemiBold"�6~   $	��Top=�6�   �� 50   
   -	   5        $��
lblGoalDif��50      $��8��6"   $��Center=�6Z   $��12(�6w   $��DemiBold"�6�   $��Bottom=�6�   ��6/   �� $	 GoalDifferential�6�   52      53      