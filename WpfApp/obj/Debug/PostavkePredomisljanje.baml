   M S B A M L   `   `   `  ����A  =WpfApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:WpfApp.PropertiesWpfApp.Properties  5   	   clr-namespace:WpfAppWpfApp  5   	   #    WpfApp.SettingsShortcutWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   6
propertiesclr-namespace:WpfApp.Properties     5   	   &localclr-namespace:WpfApp     5   	     � Title$  SettingsWindow��5	   	   $	��450��6    $	��800��6-    � 	Resources 5
       �� 
TargetType   ctSizeSelection ��Name ��Name J� RenderTransformOrigin �� Triggers P� Property P� Value	 �� 
TargetName
 �� Property �� Value��%�  &	        �� 5   
   " 	�6   .R�5      � .+�5      �� $	 img��6   $��B:\Prog\windowPreview.png��6%   $
��Fill=�6H   #��z��6W   #��z��5      �� 5      $	 lbl��6   $��Center=�6%   $��Center=�5      
���   �$ .5, .5&�5      .��5      �� 5      5       5      P� 5       �@d�	IsChecked$
 TrueY�6/   . �5      �� $		 lbl��6   
 � ��$
 Bold"�6D   5      5      5      .��5      � -   5         �Name$ mainGrid��5       � RowDefinitions 5   
   �� 5       �� 5!      �� 5"      $��50 �6    � ColumnDefinitions 5$   
   �� 5%      �� 5&      �� 5'      �� 5(      .+�5+   
   � $��4��6    5,      �� 5-      $	��250 �6#   �� 5.      $	��275 �6#   �� 5/      $	��250 �6#   .+�52      �� !   WpfApp.Properties.Resources   lblChamp#��Z 6   $��0��6G   $��0��6T   $��Center=�6d   �� 53      -   5         ��Name$ cbChamp��53      $��0��6(   $��0��65   $��25��6E   $	��180��6Q   $��Center=�6]   $��Center=�6z   $��10(�6�   .@�54      �� $#��Men's 2018 World Championship��6   
 � Tag$ 0��6G   �� 55      $%��Women's 2019 World Championship��6   $ 1��6I   56      �� 58         lblLang#��Z 6   $��0��6F   $��1��6S   $��Center=�6c   �� 59      -   5        $ cbLang��59      $��0��6'   $��1��64   $��25��6E   $	��180��6Q   $��Center=�6]   $��Center=�6z   .@�5:      �� $��English��6   $ en��61   �� 5;      $��Croatian��6   $ hr��62   5<      �� 5>         	lblSource#��Z 6   $��0��6H   $��2��6U   $��Center=�6e   �� 5?      -   5        $ cbSource��5?      $��0��6)   $��2��66   $��25��6G   $	��180��6S   $��Center=�6_   $��Center=�6|   .@�5@      �� $	��API��6   $
 True��6-   �� 5A      $
��Disk��6   $ False��6.   5B      5D      �� 5G   
   $��1��6   $��0��6   $��4��6-      lblRes#��Z 6A   $	��Top=�6r   $��Center=�6�   	� 5H   
    d� 	IsChecked$
 TrueY�6   $��1��6'   $��0��64    	� 	GroupName$ 
screenSize��6D   $��
Fullscreen��6[   $ 0��6p   #��[  6x   $	��100��6�   $	��100��6�   	� 5J   
   $��1��6   $��1��6#   $ 
screenSize��63   $��700x700��6J   $ 700;700��6\   #��[  6j   $	��100��6�   $	��100��6�   	� 5L   
   $��1��6   $��2��6#   $ 
screenSize��63   $��800x800��6J   $ 800;800��6\   #��[  6j   $	��100��6�   $	��100��6�   	� 5N   
   $��1��6   $��3��6#   $ 
screenSize��63   $��900x900��6J   $ 900;900��6\   #��[  6j   $	��100��6�   $	��100��6�   �� 5P   
   -   5         ��Name$ 	btnSubmit��5P   .   $��2��6   $��1��6   $
��Save��6A   $	��100��6P   $��35��6\   6h   �� 5R   
   -   5        $ 	btnCancel��5R   /   $��2��6   $��2��6      btnCancelSettings#��Z 6B   $	��100��6~   $��35��6�   6�   5S      5T      