   M S B A M L   `   `   `  ����P  LShopdrawing.Framework, Version=4.1.0.0, Culture=neutral, PublicKeyToken=nulls>clr-namespace:Microsoft.VisualStudio.PlatformUI.Shell.Controls0Microsoft.VisualStudio.PlatformUI.Shell.Controls  5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089B    <Microsoft.VisualStudio.PlatformUI.Shell.Controls.GlyphButton  �� 
TargetType �� Property �� Value �� Path �� RelativeSource �� 
TargetType ��Name �� Triggers P� Property	 P� Value
 �� 
TargetName�� 5      D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    :x,http://schemas.microsoft.com/winfx/2006/xaml     5      Evs>clr-namespace:Microsoft.VisualStudio.PlatformUI.Shell.Controls  5      ResourceDictionary_1��%�  '         �� 5      Style_1��"    6   .�5      �� Setter_1�� � �� 5      �� 5   
   $ ActualHeight�6    6&   �� *Self+5
      �� 5      Setter_2�� � �� 5      �� 5   
   $ GlyphForeground�6    6)   �� *Self+5      �� 5      Setter_3�� � ��
 ���� 6<   �� 5      Setter_4�� � |� .  6=   �� 5      Setter_5�� � �� 5      �� 5   
   ControlTemplate_1��"   64   .R�5      �� $ Border��6   
Border��#��z��62   #��z��5      #��z��5      ._�5      �� ContentPresenter_1��6   5       5      P� 5      	Trigger_1�� �@J�IsMouseOver	 . . �5      �� Setter_6��$
 Border��6(    5      �� *HoverBackground+ �� *TemplatedParent+ � ��5      �� 5      Setter_7��$
 Border��6(    5       �� *HoverBorderBrush+ �� *TemplatedParent+ � ��5!      �� 5"      Setter_8��$
 Border��6(    5#      �� *HoverBorderThickness+ �� *TemplatedParent+ � ��5$      �� 5%      Setter_9�� 6(   �� *HoverForeground+ �� *Self+ � ��5&      5'      P� 5(      	Trigger_2�� � ��	 . . �5)      �� 	Setter_10��$
 Border��6)    5*      �� *PressedBackground+ �� *TemplatedParent+ � ��5+      �� 5,      	Setter_11��$
 Border��6)    5-      �� *PressedBorderBrush+ �� *TemplatedParent+ � ��5.      �� 5/      	Setter_12��$
 Border��6)    50      �� *PressedBorderThickness+ �� *TemplatedParent+ � ��51      �� 52      	Setter_13�� 6)   �� *PressedForeground+ �� *Self+ � ��53      54      56      58      59      5:      