   M S B A M L   `   `   `  ����J  FPPS-TOOL-DELUXE, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:PPS_TOOL_DELUXE.PropertiesPPS_TOOL_DELUXE.Properties  5   	   1clr-namespace:PPS_TOOL_DELUXEPPS_TOOL_DELUXE  5   	       PPS_TOOL_DELUXE.UI.Step5   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   6p(clr-namespace:PPS_TOOL_DELUXE.Properties     5   	   /localclr-namespace:PPS_TOOL_DELUXE     5   	   -   5          �Name$  Schritt5��5   	    � WindowStartupLocation$ CenterScreen=�5	   	    � Title$ 	Schritt 5��5
   	   $��430.454��6   $	��550��6,    � DataContext 5   	   �� *Step5+   Locator �� Source# [   � 	Resources 5       �� 
TargetType �� 	Resources  Key �� Property	 �� Value  	NormalDot
 �� BasedOn �� 
TargetType ��Name �� Orientation  ProgressDot��%-  '�       7  7  7  7  7  7  7  7  7  7  7  �� 5   
   " �6    5      ���� 5      	NormalDot " A�6*   .�5      ��  � ��$	 4q�6/   �� 5       � ��$	 25��6.   �� 5       � ��$	 25��6/   �� 5       � ��
	 �����6-   5      �� 5      ProgressDot 8
   " A�5      .�5      ��  � ��
	 � ���6-   5      5      .�5      ��  � ��	 �	#FFF8F9FB6+   �� 5       � ��$	 18��6'   �� 5       � ��	 5      �� 5      " �6&   .R�5      � #��z��6   .+�5       �� $ 
PART_Track��6)   $ 
Horizontal=�6=   $
��Left=�5!   !   $��Center=�6<   .+�5"   "   A� 8�� 6*   A� 5#   "   8�� 6*   A� 5$   "   8�� 6*   A� 5%   "   8�� 6*   A� 5&   "   8�� 6*   5'      �� 5)      $ PART_Indicator��6)   $ 
Horizontal=�6A   $
��Left=�5*   !   $��Center=�6<   .+�5+   "   A� 8�� 6*   A� 5,   "   8�� 6*   A� 5-   "   8�� 6*   A� 5.   "   8��	 6*   A� 5/   "   8��
 6*   50      51      52      54      55      56      .��57      � $��0,0,0.333,-2q�6   ���#2e3641.+�58   
   �� )   #PPS_TOOL_DELUXE.Properties.Resource#   breadcrumb_capacity_planning#��Z 6   $��Center=�6M   $	��Top=�6j   $��10,23,312,0q�6�   $��18(�6�   $
��Bold"�6�   $	��221��6�   ���#e9f0f46�   �� 59   
   -   5         ��Name$ Schritt5_export��59      $��Export��6*   $��Right=�6;   $	��Top=�6W   $��75��6o   $��	0,30,20,0q�6z   $��10(�5:      ���#16a085���#e9f0f4���#16a085$��18��6   ��6_   �� *NextCommand+6   &   System.Windows.Controls.DataGrid  5;   
   -   5          Name$ producesGrid��5;         AutoGenerateColumns .  $
��Left=�5=      $	��313��5>      $��	10,63,0,0q�5?      $	��Top=�5@      $	��523��5A      ��. $
��Auto=�5C         
IsReadOnly .     SelectionMode$ Single=�5D       ��67   �� *WorkplacesTimesNew+   ColumnHeaderStyle 5E      �� 5F      =  7System.Windows.Controls.Primitives.DataGridColumnHeader"  6   .�5G      ��  � ��	 �#16a08563   �� 5H       � ��	 �#e9f0f463   �� 6Z    � ��$		 8pt(�6u   �� 5I       � ��$
	 Bold"�63   �� 5J       � ��$	 Center=�6C   �� 5K       � ��$
	 Auto��6.   �� 5L       �@ SeparatorBrush
	 �����67   �� 5M       �@ SeparatorVisibility$	 Visible=�6<   �� 5N       � ��	 5O      �� 5P      .R�5Q   "   �� $	��5,0q�6=   $
��Wrap=�6J   $
��Auto��6^   $��45��6k    �� TextAlignment$ Center=�6y    �� IsHyphenationEnabled .  � Language$ de-DE�6�   ��6,   �� 6�   5R      5T      5U         Columns 5W      0  *System.Windows.Controls.DataGridTextColumn  5X      ,  &System.Windows.Controls.DataGridColumn   Header$	 Nr.��6_   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� *Id+   ClipboardContentBinding 6<   Z� 6_     5Y         step_five_label# Z 5Z       5Y   %   �� *Label+ 6?   Z� 5Z        5[      # Z 5\       5[   %   �� *
SetUpNew+ 6B   Z� 5\        5]      )   "step_five_neededCapacityLastPeriod# Z 5^       5]   %   �� *	KapaOld+ 6A   Z� 5^        5_      $   step_five_setUpTimeLastPeriod# Z 5`       5_   %   �� *
SetUpOld+ 6B   Z� 5`        5a         step_five_total# Z 5b       5a   %   �� *Total+ 6?   Z� 5b      4  .System.Windows.Controls.DataGridTemplateColumn  5c          step_five_shifts# Z  5d   )   !   Width5  /System.Windows.Controls.DataGridLengthConverter$! 4* 6Y   "   ClipboardContentBinding" 5c   )   Z� #   CellTemplate# 5e      �� 5f      .R�5g      �� ��6'   �� *Step5.LayersList+# [  $ �� SelectedItem$ 6q   �� *Shifts+% �� Mode$% TwoWay=�& �� UpdateSourceTrigger$& PropertyChanged=�5h      5j        5k      '   step_five_overtime# Z' 5l   %    5k   %   �� *
Overtime+ 6B   Z� 5l   %   5n      5o      5p      