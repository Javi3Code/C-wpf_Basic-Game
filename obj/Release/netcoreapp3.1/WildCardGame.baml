   M S B A M L   `   `   `  ���� F  BJCode.Games, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:JCode.GamesJCode.Games      JCode.Games.WildCardGame   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     +localclr-namespace:JCode.Games       � Title$  ComodinGame��$	��450��$	��800�� � 
ResizeMode$ NoResize=� � AllowsTransparency$
 True��
������  � WindowStyle$
 None=� � WindowStartupLocation$ CenterScreen=� � 	Resources    FocusVisual �� Property �� Value �� StrokeDashArray	 J� SnapsToDevicePixels  Button.Static.Background
 �� Color  Button.Static.Border  Button.MouseOver.Background  Button.MouseOver.Border  Button.Pressed.Background  Button.Pressed.Border  Button.Disabled.Background  Button.Disabled.Border 	 Button.Disabled.Foreground 
 btnStyle �� 
TargetType �� 
TargetType ��Name ��Name �� Triggers P� Property P� Value �� 
TargetName��%�  &	        &	 R     &	 g     &	 |     &	 �     &	 �     &	 �     &	 �     &	 �     &		 �     &	
     7   7  7  7  7  7 	 �� .���  � �� �� .R��� $��2q�$	 1 2R�$
	 true��$��1��#��� ���� $
 	#FFDDDDDD���� $
 	#FF707070���� $
 	#FFBEE6FD���� $
 	#FF3C7FB1���� $
 	#FFC4E5F6���� $
 	#FF2C628B���� $
 	#FFF4F4F4���� $
 	#FFADB2B5���� $
 	#FF838383���� " ��.���  �@�FocusVisualStyle8   ��  � ��8  ��  � ��8  ��  � ��# � ����  � ��$ 1q���  � ��$ Center=���  � ��$ Center=���  � ��$ 1q���  � �� �� " ��.R��� $ border��#��z��#��z��#��z��$
	 true��._��� $ contentPresenter��$|�False��#��z��#��z��$
��True��#	 z	 #��z�� P�  �@��IsDefaulted$
 true��. ��� $ border��# � �� � ��P�  �@J�IsMouseOver$
 true��. ��� $ border�� � ��
 ������� $ border�� � ��
 �����P�  � ��$
 true��. ��� $ border�� � ��
 ������� $ border�� � ��
 �����P�  � {�$ false��. ��� $ border��8   � ���� $ border��8   � ���� $ contentPresenter��8   � ��.��� .+��� 
�������$��10,10,10,10q�$��0,1,528,245q��� ���	#FF919FD6$��6,6,6,6q�$��10,10,537,255q�._�� -    �Name$
 user��$��
-1,0,-1,-1q��� 
�������$��10,10,10,10q�$��527,1,1,244q��� ���	#FF919FD6$��6,6,6,6q�$��537,10,10,254q�._�� -   $	 cpu���� $��Rfirstgame/vs.png��$��301,26,321,270q�� ���	#FF919FD6$��0,205,405,0q�.+�	� -    	�Name$ piedra��$��Piedra��$
��Left=�$��	10,10,0,0q�$	��Top=� �� 	ClickMode$ Press=�$$��Bahnschrift SemiBold Condensed)�$"��25                          (� � Cursor$
 Hand��$��76��	� -   $ papel��$��Papel��$
��Left=�$��	91,10,0,0q�$	��Top=�$ Press=�$$��Bahnschrift SemiBold Condensed)�$	��25 (�$
 Hand��$��73�� J� RenderTransformOrigin$ 0.653,0.531&�	� -   $ tijera��$��Tijera��$
��Left=�$��
172,10,0,0q�$	��Top=�$ Press=�$$��Bahnschrift SemiBold Condensed)�$	��25 (�$
 Hand��$��73��$ 0.653,0.531&��� -    ��Name$ imgUser��$
��Left=�$	��151��$��0,93,0,0q�$	��Top=�$	��388���� -    ��Name$ closeBtn��#��� 
  �� IsCancel$
 True��
������ 
������ $��68��$	��Top=�$ 0.5,0.5&�$��	325,0,0,0q�.��]� $��62��$��64��.+��� -   $ lc��$��UniformToFill=� �� StretchDirection$
 Both=�$��Rprincipal/close.png��$
 Hand��$��61��$��57��� ���	#FF919FD6$��395,205,1,0q�.+��� -	    ��Name$ lblAleat��$��Control Aleatorio��$��Center=�$��0,10,0,0q�$	��Top=�$	��316��$��47��$��35(�$��Arial Rounded MT Bold)��� -
   $ startBtn��#��� 
  �� 	IsDefault$
 True��$��START��$��Center=�$��	0,144,0,0q�$	��Top=�$��91��$	��384��$��60(�$��Arial Rounded MT Bold)�����  �� EndPoint$ 0.5,1&� �� 
StartPoint$ 0.5,0&�.���   � Color$  	#FFC1E8E0��! � Offset$! 1Q�� $  White��$! 0.489Q�� $  	#FFD7EEE9��$! 0.844Q�� $  	#FFB9C2C0��$! 0.018Q����� $ 0.5,1&�$ 0.5,0&�.��� $  Black��� $  White��$! 1Q�