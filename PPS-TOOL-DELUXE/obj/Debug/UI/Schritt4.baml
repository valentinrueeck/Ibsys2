   M S B A M L   `   `   `  ����J  FPPS-TOOL-DELUXE, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:PPS_TOOL_DELUXE.PropertiesPPS_TOOL_DELUXE.Properties  5   	   1clr-namespace:PPS_TOOL_DELUXEPPS_TOOL_DELUXE  5   	       PPS_TOOL_DELUXE.UI.Step4   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   6p(clr-namespace:PPS_TOOL_DELUXE.Properties     5   	   /localclr-namespace:PPS_TOOL_DELUXE     5   	   -   5          �Name$  Schritt4��5   	    � WindowStartupLocation$ CenterScreen=�5	   	    � Title$ 	Schritt 4��5
   	   $��432.901��6   $	��325��6,    � DataContext 5   	   �� *Step4+   Locator �� Source# [   � 	Resources 5       �� 
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
 6*   50      51      52      54      55      56      .��57      � -   5         �Name$ 
layoutRoot��57      ���#2e3641.+�5;   
   �� )   #PPS_TOOL_DELUXE.Properties.Resource%   breadcrumb_construction_orders#��Z 6   $��Center=�6O   $	��Top=�6l   $��21,20,110.667,0q�6�   $��18(�6�   $
��Bold"�6�   $	��187��6�   ���#e9f0f46�   �� 5<   
   -   5         ��Name$ Schritt4_abbrechen��5<         cancel#��Z 6-   $
��Left=�6T   $	��Top=�6o   $��75��6�   $��
226,45,0,0q�6�   $��10(�6�   ���#9eb2c0���#9eb2c0���#e9f0f4$��22��6  �� 5=   
   -   5        $ Schritt4_weiter��5=         next#��Z 6*   $��Right=�6O   $	��Top=�6k   $��75��6�   $��0,18,9.667,0q�6�   $��10(�6�   ���#16a085���#e9f0f4���#16a085$��22��6  ��6�   �� *NextCommand+6  &   System.Windows.Controls.DataGrid  5>   
   -   5          Name$ producesGrid��5>         AutoGenerateColumns .  $��51,76,46.667,49.333q�5@      $	��221��5A      ��. $
��Auto=�5C         SelectionMode$ Single=�5D      $��Center=�6$   ��6A   �� *ProduceItemsAll+ �� NotifyOnSourceUpdated .  �� SelectedItem 5G   q   �� *SelectedRow+   ColumnHeaderStyle 5H      �� 5I      =  7System.Windows.Controls.Primitives.DataGridColumnHeader"  6   .�5J      ��  � ��	 �#16a08563   �� 5K       � ��	 �#e9f0f463   �� 5L       � ��$		 8pt(�61   �� 5M       � ��$
	 Bold"�63   �� 5N       � ��$	 Center=�6C   �� 5O       � ��$
	 Auto��6.   �� 5P       �@ SeparatorBrush
	 �����67   �� 5Q       �@ SeparatorVisibility$	 Visible=�6<   �� 5R       � ��	 5S      �� 5T      .R�5U   "   �� $	��5,0q�6=   $
��Wrap=�6J   $
��Auto��6^   $��45��6k    �� TextAlignment$ Center=�6y    �� IsHyphenationEnabled .  � Language$ de-DE�6�   ��6,   �� 6�   5V      5X      5Y         Columns 5[      4  .System.Windows.Controls.DataGridTemplateColumn  5\      ,  &System.Windows.Controls.DataGridColumn   Header$ Id��5]   *      Width5  /System.Windows.Controls.DataGridLengthConverter$ 4* 66      ClipboardContentBinding 5\   )   Z�     CellTemplate  5^      �� 5_      .R�5`      �� ��6'   �� *Step4.ProduceItemIds+# [   6u   �� *SelectedItem+! �� Mode$! TwoWay=�" �� UpdateSourceTrigger$" PropertyChanged=�5a      5c      0  *System.Windows.Controls.DataGridTextColumn  5d      #   step_four_count# Z# 5e      $ 6* 6D   1  +System.Windows.Controls.DataGridBoundColumn$   Binding$ 5d   %   �� *Number+%   ClipboardContentBinding% 6@   Z� 5e   D   5g      � 5j   
   -   5        & �Name$& popup1��5k      ' J� IsHitTestVisible' .  $��RelativePoint=�5m      ( � AllowsTransparency( . ) � PlacementTarget) 5n      �� * �� ElementName$* Schritt4��.��5p      �� 
����İ�$��2q�5r      
�������+ J� Opacity$
+ 0.75Q�5t      ._�5u      �� $ 
Horizontal=�5v      $��4,3,8,3q�5w      .+�5x      �� $��/Ressource/DragInsert.png��5y      $��16��5z      $��16��5{      �� 5|      $��14(�5}      $
��Bold"�5~      $��Center=�5      $��8,0,0,0q�5�      ��5�      �� $* Schritt4��, �� Path$, DraggedItem.SelectedItem�5�      5�      5�      5�      �� 5�   
   -   5        $ btn_plus��5�      $��+��6#   $��Center=�6/   $��Bottom=�6L   $��137,0,164.667,24.333q�6g   $��10(�6�   ���#e9f0f4���#1abc9c���#1abc9c$��17��6�   $��17��6   ��6�   �� *AddRowCommand+6   �� 5�   
   -   5        $ 	btn_minus��5�      $��-��6$   $��Center=�60   $��Bottom=�6M   $��167,0,134.667,24.333q�6h   $��10(�6�   ���#9eb2c0���#9eb2c0���#e9f0f4$��17��6�   $��17��6  {�.  ��6�   �� *DeleteRowCommand+6  5�      5�      