   M S B A M L   `   `   `  ���� F  BJCode.Games, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:JCode.GamesJCode.Games      JCode.Games.Login   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     +localclr-namespace:JCode.Games       � Title$  Login��$	��700��$
��1000�� � AllowsTransparency$
 True��
������  J� 	AllowDrop$
 True�� � 
ResizeMode$ NoResize=� � WindowStyle$
 None=� � WindowStartupLocation$ CenterScreen=� � 	Resources    FocusVisual �� Property �� Value	 �� StrokeDashArray
 J� SnapsToDevicePixels  Button.Static.Background �� Color  Button.Static.Border  Button.MouseOver.Background  Button.MouseOver.Border  Button.Pressed.Background  Button.Pressed.Border  Button.Disabled.Background  Button.Disabled.Border 	 Button.Disabled.Foreground 
 btnStyle �� 
TargetType �� 
TargetType ��Name ��Name �� Triggers P� Property P� Value �� 
TargetName��%�  &	        &	 R     &	 g     &	 |     &	 �     &	 �     &	 �     &	 �     &	 �     &		 �     &	
     7   7  7  7  7  7 	 �� .���  � �� �� .R��� $��2q�$		 1 2R�$

 true��$��1��#��� ���� $ 	#FFDDDDDD���� $ 	#FF707070���� $ 	#FFBEE6FD���� $ 	#FF3C7FB1���� $ 	#FFC4E5F6���� $ 	#FF2C628B���� $ 	#FFF4F4F4���� $ 	#FFADB2B5���� $ 	#FF838383���� " ��.���  �@�FocusVisualStyle8   ��  � ��8  ��  � ��8  ��  � ��# � ����  � ��$ 1q���  � ��$ Center=���  � ��$ Center=���  � ��$ 1q���  � �� �� " ��.R��� $ border��#��z��#��z��#��z��$

 true��._��� $ contentPresenter��$|�False��#��z��#��z��$
��True��#
 z
 #��z�� P�  �@��IsDefaulted$
 true��. ��� $ border��# � �� � ��P�  �@J�IsMouseOver$
 true��. ��� $ border�� � ��
 ������� $ border�� � ��
 �����P�  � ��$
 true��. ��� $ border�� � ��
 ������� $ border�� � ��
 �����P�  � {�$ false��. ��� $ border��8   � ���� $ border��8   � ���� $ contentPresenter��8   � ��.��� -    �Name$ 	loginGrid��.+��� -    ��Name$ loginImg��$
��Left=�$	��229��$��131,217,0,0q�$	��Top=�$	��241��$��Rprincipal/loginImage.png��$��Uniform=� �� StretchDirection$ DownOnly=�� -   $ loginDataGrid��$��	500,0,0,0q� J� RenderTransformOrigin$ 	0.5,0.606&�����  �� EndPoint$ 0.2,1.3&� �� 
StartPoint$ 0.1,0&� � MappingMode$ RelativeToBoundingBox=� � SpreadMethod$ Reflect=�.���  � Color$ 	#FF79B5E0�� � Offset$ 0.074Q�� $ 	#FF0A423A��$ 0.584Q�� $ 	#FF136358��$ 0.445Q�� $ 	#FF5482A3��$ 0.147Q�� $ 	#FF6D9BD0��$ 0.106Q�� $ 	#FF136362��$
 0.36Q�� $ 	#FF9EDEEE��$ 0.041Q�.+��� 
�������$��4,4,4,4q���  �� CornerRadius$ 20��
�������$��200,200,200,457q�$��43��$��2,2,2,2q��� -    ��Name$ loginLbl��$��LOGIN��$��Center=�$��	0,200,0,0q�$	��Top=�$��Center=�$��Normal$�$��30(�$��Britannic Bold)�$��SemiExpanded&�$��	ExtraBold"�$	��101��$��43�����	#FFD8E6EA�� -   $ titleLbl��$��DYNAMIC GAME��$��Center=�$��0,49,0,0q�$	��Top=�$��Center=�$��Normal$�$��50(�$��Britannic Bold)�$��SemiExpanded&�$��	ExtraBold"�$	��400��$��67�����	#FFD8E6EA�� -     ��Name$  closeBtn��#��� 
 ! �� IsCancel$
! True��
������ 
������ $��45��$��	448,4,4,0q�$	��Top=�.��]� .+��� $��UniformToFill=�$
 Both=�$��Rprincipal/close.png��" � Cursor$
" Hand��$��45���� -   $ loginLblPass��$��	Password:��$
��Left=�$��
25,526,0,0q�$	��Top=�$��Center=�$��Normal$�$��25(�$��Britannic Bold)�$��SemiExpanded&�$��	ExtraBold"�$	��123��$��44�����	#FFD8E6EA�� -   $ loginLblUser��$��User:��$
��Left=�$��
79,414,0,0q�$	��Top=�$��Center=�$��Normal$�$��25(�$��Britannic Bold)�$��SemiExpanded&�$��	ExtraBold"�$��69��$��43�����	#FFD8E6EAG� -	   # G�Name$# txtPass��$ G� 
CaretBrush
$ �����
�������$��0,0,0,2q�
�������
������ $
��Left=�$��Center=�$��Center=�$��164,526,0,0q�$	��Top=�$	��259��$��31��$��18(��� -
   % ��Name$% txtUser��& �� 
CaretBrush
& �����
�������$��0,0,0,2q�
�������
������ $��Center=�$��Center=�$
��Left=�$��164,414,0,0q�' �� TextWrapping$
' Wrap=�$	��Top=�$	��259��$��34��$��Arial)�$��18(��� -   $  btnOk��#��� 
 ( �� 	IsDefault$
( True��$
" Hand��
�������$��OK��$��Britannic Bold)�$��50(�$��25,614,24,10q�) �� 	ClickMode$) Press=����� $ 0.5,1&�$ 0.5,0&�.��� $ 	#FF15766D��$ 0.732Q�� $ 	#FF17B9A9��$ 1Q�� $ 	#FF28EEE4��$ 0.027Q�� $ 	#FF21A39A��$
 0.31Q�� $ 	#FF1E9088��$ 0.404Q�� $ 	#FF158378��$ 0.861Q�� $ 	#FF13AEA5��$ 0.227Q�� $ 	#FF1FD3CA��$ 0.091Q�� $ 	#FF1CBDB5��$ 0.142Q��� -   $ userErrorLbl��
�������$�� ��$��Center=�$
��Left=�$��Center=�$��33��$��162,376,0,0q�$	��Top=�$	��261��$��14(��� -   $ passErrorLbl��
�������$�� ��$
��Left=�$��Center=�$��Center=�$��33��$��160,488,0,0q�$	��Top=�$	��263��$��14(�