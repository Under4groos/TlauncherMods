   M S B A M L   `   `   `  ����H  DTlauncherMods, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:TlauncherModsTlauncherMods  5   	   ?$clr-namespace:TlauncherMods.ControlsTlauncherMods.Controls  5   	       TlauncherMods.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:TlauncherMods     5   	   9Controls$clr-namespace:TlauncherMods.Controls     5   	      WindowStyle#���   5        � Title$  
MainWindow��5	   	   $	��800��6   $
��1200��6)   .��5
      � .+�5   
   � $	��Top=�6   $��30��6'   .+�5      ��  �� Orientation$ 
Horizontal=�6   $��Right=�62   .+�5      $   TlauncherMods.Controls.LBorder  -   5          Name$
 bmin��5   #      Content$	 ��61     StyleBorderHover#��[ 6E     SegoeMDL2StyleLabelText   
LabelStyle# [ 6o   $��48��6�     5      -   5        $
 bmax��5   #   $	 ��61   #��[ 6E   # [ 6o   $��48��6�     5      -   5        $ bclose��5   #   $	 ��63   #��[ 6G   # [ 6q   $��48��6�   5      5      � 5   
   $��	0,35,0,35q�6   .+�5      �� $
��Left=�6   $	��100��60   ���	#0CFFFFFF._�5      � .+�5      �� -   5         ��Name$ list_versions��5      $��Hidden=�65     _ListBoxItemStyle_hover#���  6g   $��0,0,0,0q�6�   ��6�   Z� ��6�   Z� 5      5      5       �� 5!      ���	#0CFFFFFF$��	105,0,0,0q�6,   ._�5"      � -   5         �Name$ 	grid_ccle��5"      .+�5#      �� $ 
Horizontal=�6!   $	��Top=�6:   $��5,5,0,0q�6R   $
��Left=�6c   .+�5$      �� -   5         ��Name$ 	tx_search��5$   "     StyleTextBox#���  65   $��35��6]   $	��250��6i   6w     5%      $   TlauncherMods.Controls.LBorder!   PreviewMouseLeftButtonDown$* $LBorder_PreviewMouseLeftButtonDown_2��6�   	 �� CornerRadius$	 10��6+   $��5,0,0,0q�6=   $	 ��6N   
   FontSize$
 24Q�6a   #��[ 6o   # [ 6�   $��50��6�   6�   5'      �� 5)      -   5        $ find_list_addons��5)      $y�	Collapsed=�68   $��	0,40,0,30q�6O   ��.  $��Hidden=�6�   #���  6�   ��6�   Z� ��6  Z� ��6&  Z� 5+      �� 5-      -   5        $ list_addons��5-      $��	0,40,0,30q�63   ��.  $��Hidden=�6l   #���  6�   ��6�   Z� ��6�   Z� ��6
  Z� 5/      �� 50      $ 
Horizontal=�6!   $��Bottom=�6:   $
��Left=�6U   .+�51      �� -	   5         ��Name$ min_count_frame��51       $��0��69     StyleLabelText#��[ 6E   $��30��6m   $��Center=�6y   6�     52      $( "LBorder_PreviewMouseLeftButtonDown��6�   $	 ��6,   $
 24Q�6?   #��[ 6M   # [ 6w   $��48��6�   $��30��6�   6�   �� 53      -
   5        $ 	cur_frame��53       $	��400��63   #��[ 6A   $��30��6i   $��Center=�6u   6�     55      $* $LBorder_PreviewMouseLeftButtonDown_1��6�   $	 ��6,   $
 24Q�6?   #��[ 6M   # [ 6w   $��48��6�   $��30��6�   6�   �� 56      -   5        $ max_count_frame��56       $	��800��69   #��[ 6G   $��30��6o   $��Center=�6{   6�   57      58      59      5:      �� 5;   
   -   5         ��Name$ resizeborder��5;      $��20��6'   $��20��62   $��Right=�6>   $��Bottom=�6Z   ���	#02FFFFFF J� Opacity$	 0.1Q�6�   6�   5<      5=      