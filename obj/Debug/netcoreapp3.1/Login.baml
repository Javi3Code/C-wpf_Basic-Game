   M S B A M L   `   `   `  ����F  BJCode.Games, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:JCode.GamesJCode.Games  5   	       JCode.Games.Login   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:JCode.Games     5   	     � Title$  Login��5   	   $	��700��6   $
��1000��6$    � AllowsTransparency$
 True��5	   	   
������  J� 	AllowDrop$
 True��5   	    � 
ResizeMode$ NoResize=�5   	    � WindowStyle$
 None=�5   	    � WindowStartupLocation$ CenterScreen=�5   	    � 	Resources 5         FocusVisual �� Property �� Value	 �� StrokeDashArray
 J� SnapsToDevicePixels  Button.Static.Background �� Color  Button.Static.Border  Button.MouseOver.Background  Button.MouseOver.Border  Button.Pressed.Background  Button.Pressed.Border  Button.Disabled.Background  Button.Disabled.Border 	 Button.Disabled.Foreground 
 btnStyle �� 
TargetType �� 
TargetType ��Name ��Name �� Triggers P� Property P� Value �� 
TargetName��%�  &	        &	 �     &	 �     &	 �     &	     &	 ?    &	 b    &	 �    &	 �    &		 �    &	
 �    7   7  7  7  7  7 	 �� 5   
   .�5      ��  � �� 5      �� 5      .R�5      �� $��2q�6$   $		 1 2R�6/   $

 true��6E   $��1��6`   #��� ��6t   5      5      5      �� 5   
   $ 	#FFDDDDDD��6;   �� 5   
   $ 	#FF707070��67   �� 5   
   $ 	#FFBEE6FD��6>   �� 5   
   $ 	#FF3C7FB1��6:   �� 5   
   $ 	#FFC4E5F6��6<   �� 5   
   $ 	#FF2C628B��68   �� 5    
   $ 	#FFF4F4F4��6=   �� 5!   
   $ 	#FFADB2B5��69   �� 5"   
   $ 	#FF838383��6=   �� 5#   
   " ��6!   .�5$      ��  �@�FocusVisualStyle8   61   �� 5%       � ��8  6+   �� 5&       � ��8  6,   �� 5'       � ��# � ��6+   �� 5(       � ��$ 1q�60   �� 5)       � ��$ Center=�6;   �� 5*       � ��$ Center=�69   �� 5+       � ��$ 1q�6(   �� 5,       � �� 5-      �� 5.      " ��6&   .R�5/      �� $ border��6!   #��z��61   #��z��6[   #��z��6�   $

 true��6�   ._�50      �� $ contentPresenter��6/   $|�False��6I   #��z��6[   #��z��6�   $
��True��6�   #
 z
 6�   #��z��6  51       52      P� 53       �@��IsDefaulted$
 true��6=   . �54   "   �� $ border��6@   # � ��6T    � ��55      P� 56       �@J�IsMouseOver$
 true��6=   . �57   "   �� $ border��6?    � ��
 �����6S   �� 58   "   $ border��6@    � ��
 �����6T   59      P� 5:       � ��$
 true��6;   . �5;   "   �� $ border��6?    � ��
 �����6S   �� 5<   "   $ border��6@    � ��
 �����6T   5=      P� 5>       � {�$ false��6;   . �5?   "   �� $ border��6?   8   � ��6S   �� 5@   "   $ border��6@   8   � ��6T   �� 5A   "   $ contentPresenter��6K   8   � ��6i   5B      5D      5F      5G      5H      .��5I      � -   5         �Name$ 	loginGrid��5I      .+�5J   
   �� -   5         ��Name$ loginImg��5J      $
��Left=�6"   $	��229��6=   $��131,217,0,0q�5K      $	��Top=�6%   $	��241��6=   $��Rprincipal/loginImage.png��6I   $��Uniform=�6l    �� StretchDirection$ DownOnly=�6~   � 5L   
   -   5        $ loginDataGrid��5L      $��	500,0,0,0q�6'    J� RenderTransformOrigin$ 	0.5,0.606&�6:   ��5M      �� 5N       �� EndPoint$ 0.2,1.3&�6&    �� 
StartPoint$ 0.1,0&�69    � MappingMode$ RelativeToBoundingBox=�6L    � SpreadMethod$ Reflect=�6p   .��5O      �  � Color$ 	#FF79B5E0��6#    � Offset$ 0.074Q�65   � 5P      $ 	#FF0A423A��6#   $ 0.584Q�65   � 5Q      $ 	#FF136358��6#   $ 0.445Q�65   � 5R      $ 	#FF5482A3��6#   $ 0.147Q�65   � 5S      $ 	#FF6D9BD0��6#   $ 0.106Q�65   � 5T      $ 	#FF136362��6#   $
 0.36Q�65   � 5U      $ 	#FF9EDEEE��6#   $ 0.041Q�65   5V      .+�5X      �� 
�������$��4,4,4,4q�6/   5Y      �� 5Z       �� CornerRadius$ 20��6   
�������$��200,200,200,457q�6;   $��43��6T   $��2,2,2,2q�6a   �� 5[      -   5         ��Name$ loginLbl��5[      $��LOGIN��6&   $��Center=�66   $��	0,200,0,0q�6S   $	��Top=�6f   $��Center=�6~   $��Normal$�5\      $��30(�6(   $��Britannic Bold)�66   $��SemiExpanded&�6R   $��	ExtraBold"�6m   $	��101��6�   $��43��6�   ���	#FFD8E6EA5]      �� 5^      -   5        $ titleLbl��5^      $��DYNAMIC GAME��6&   $��Center=�6=   $��0,49,0,0q�6Z   $	��Top=�6l   $��Center=�6�   $��Normal$�5_      $��50(�6(   $��Britannic Bold)�66   $��SemiExpanded&�6R   $��	ExtraBold"�6m   $	��400��6�   $��67��6�   ���	#FFD8E6EA6�   �� 5`      -   5          ��Name$  closeBtn��5`      #��� 
 6'   ! �� IsCancel$
! True��6J   
������ 
������ $��45��6�   $��	448,4,4,0q�6�   $	��Top=�6�   .��5a      ]� .+�5b      �� $��UniformToFill=�6   $
 Both=�67   $��Rprincipal/close.png��6O   " � Cursor$
" Hand��6m   $��45��6{   5c      5d      �� 5e      -   5        $ loginLblPass��5e      $��	Password:��6*   $
��Left=�6>   $��
25,526,0,0q�6Y   $	��Top=�6m   $��Center=�6�   $��Normal$�5f      $��25(�6$   $��Britannic Bold)�62   $��SemiExpanded&�6N   $��	ExtraBold"�6i   $	��123��6�   $��44��6�   ���	#FFD8E6EA6�   �� 5g      -   5        $ loginLblUser��5g      $��User:��6*   $
��Left=�6:   $��
79,414,0,0q�6U   $	��Top=�6i   $��Center=�6�   $��Normal$�5h      $��25(�6$   $��Britannic Bold)�62   $��SemiExpanded&�6N   $��	ExtraBold"�6i   $��69��6�   $��43��6�   ���	#FFD8E6EA6�   G� 5i      -	   5        # G�Name$# txtPass��5i      $ G� 
CaretBrush
$ �����
�������$��0,0,0,2q�6t   
�������
������ $
��Left=�6�   $��Center=�6�   $��Center=�6�   $��164,526,0,0q�6"  $	��Top=�67  $	��259��6O  $��31��6[  $��18(�6g  �� 5j      -
   5        % ��Name$% txtUser��5j      & �� 
CaretBrush
& �����
�������$��0,0,0,2q�6p   
�������
������ $��Center=�6�   $��Center=�6�   $
��Left=�6  $��164,414,0,0q�6  ' �� TextWrapping$
' Wrap=�64  $	��Top=�6H  $	��259��6`  $��34��6l  $��Arial)�6x  $��18(�6�  �� 5k      -   5        $  btnOk��5k      #��� 
 6$   ( �� 	IsDefault$
( True��6G   $
" Hand��6�   
�������$��OK��6�   $��Britannic Bold)�6�   $��50(�6�   $��25,614,24,10q�6  ) �� 	ClickMode$) Press=�6"  ��5l      �� 5m      $ 0.5,1&�6*   $ 0.5,0&�6;   .��5n      � $ 	#FF15766D��6'   $ 0.732Q�69   � 5o      $ 	#FF17B9A9��6'   $ 1Q�69   � 5p      $ 	#FF28EEE4��6'   $ 0.027Q�69   � 5q      $ 	#FF21A39A��6'   $
 0.31Q�69   � 5r      $ 	#FF1E9088��6'   $ 0.404Q�69   � 5s      $ 	#FF158378��6'   $ 0.861Q�69   � 5t      $ 	#FF13AEA5��6'   $ 0.227Q�69   � 5u      $ 	#FF1FD3CA��6'   $ 0.091Q�69   � 5v      $ 	#FF1CBDB5��6'   $ 0.142Q�69   5w      5y      �� 5z      -   5        $ userErrorLbl��5z      
�������$�� ��6A   $��Center=�6L   $
��Left=�6p   $��Center=�6�   $��33��6�   $��162,376,0,0q�6�   $	��Top=�6�   $	��261��6�   $��14(�6�   �� 5{      -   5        $ passErrorLbl��5{      
�������$�� ��6@   $
��Left=�6K   $��Center=�6f   $��Center=�6�   $��33��6�   $��160,488,0,0q�6�   $	��Top=�6�   $	��263��6�   $��14(�6�   5|      5}      5~      