   M S B A M L   `   `   `  ����J  FPPS-TOOL-DELUXE, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:PPS_TOOL_DELUXE.PropertiesPPS_TOOL_DELUXE.Properties  5   	   E'clr-namespace:PPS_TOOL_DELUXE.ViewModelPPS_TOOL_DELUXE.ViewModel  5   	   "    PPS_TOOL_DELUXE.UI.Dashboard   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   6p(clr-namespace:PPS_TOOL_DELUXE.Properties     5   	   =	ViewModel'clr-namespace:PPS_TOOL_DELUXE.ViewModel     5   	     � WindowStartupLocation$  CenterScreen=�5
   	    � Title$ MegaPPS��5   	   $	��350��6\   $	��560��6i   $	��560��6u   $	��300��6�    � Icon$7 1/PPS-TOOL-DELUXE;component/Ressource/iconTool.png��6�    � 
ResizeMode$ NoResize=�6�   ���#2e3641 � DataContext 6   �� *	Dashboard+   Locator �� Source# [  .��5      � .+�5   
   �� -   5         ��Name$ LabPage��5      $��	Dashboard��6!   $��Center=�65   $	��Top=�6R    J� RenderTransformOrigin$ 3.158,0.577&�6j   $��19,10,319.667,0q�6�   $��26(�6�   $
��Bold"�6�   $	��216��6�   ���#e9f0f46�   �� 5   
   -   5         ��Name$ 	BtnImport��5      )   #PPS_TOOL_DELUXE.Properties.Resource 	   dashboard_btnImportPeriod#��Z	 6$   $	��Top=�6^   $��
303,37,0,0q�6v   $��10(�6�   $
��Left=�6�   ���#16a085���#e9f0f4���#16a0856  �� 5   
   -   5        $ BtnPlan��5      
   dashboard_btnNewPeriod#��Z
 5      $��Right=�5      $	��Top=�5      $��0,37,49.667,0q�5      $��10(�5      ���#16a085���#16a085���#e9f0f4$ 0.531,3.183&�5   /   {�6   �� *	CanPlan+6S   �� 5   
   -   5        $ LabMasterAdmin��5      $   dashboard_masterdata_headline#��Z 6(   $��Center=�6f   $��Bottom=�6�   $��
0,240,0,40q�6�   ���#e9f0f46�   �� 5   
   -   5        $ BtnWorkplaces��5      *   #dashboard_masterdata_btn_workplaces#��Z 6(   $��Center=�6l   $��Bottom=�6�   $��142,0,301.667,20q�6�   $��10(�6�   ���#16a085���#2e3641���#e9f0f4$��75��6  $ 0.844,0.442&�6  6<  �� 5   
   -   5        $ BtnProduces��5      ,   %dashboard_masterdata_btn_produceItems#��Z 6&   $��Center=�6l   $��Bottom=�6�   $��75��6�   $��0,0,0,20q�6�   $��10(�6�   ���#16a085���#2e3641���#e9f0f46  �� 5   
   -   5        $ BtnPurchases��5      -   &dashboard_masterdata_btn_purchaseItems#��Z 6'   $��Center=�6n   $��Bottom=�6�   $��75��6�   $��302,0,141.667,20q�6�   $��10(�6�   ���#16a085���#2e3641���#e9f0f46  �� 5   
   -   5        $ 	BtnGerman��5      $�� ��6$   $��Right=�6/   $��Bottom=�6K   $��25��6f   $��0,0,9.667,194q�6q   $��10(�6�   ���	#FFD4CCCC��5      �� 5       �� ImageSource$< 6/PPS-TOOL-DELUXE;component/Ressource/buttonGermany.png��6   5!      �� 5"   
   -	   5        $ 
BtnEnglish��5"      $�� ��6%   $��Right=�60   $��Bottom=�6L   $��25��6g   $��0,0,9.667,172q�6r   $��10(�6�   ���	#FFD4CCCC��5#      �� 5$      $7 1/PPS-TOOL-DELUXE;component/Ressource/buttonUk.png��6   5&      &   System.Windows.Controls.DataGrid  5'   
   -
   5          Name$ GridPeriods��5'         AutoGenerateColumns .  $��22,66,49.667,80q�6E      
IsReadOnly . ��6^   �� *	Periods+   ColumnHeaderStyle 5(      �� 5)       �� 
TargetType=  7System.Windows.Controls.Primitives.DataGridColumnHeader"  6   .�5*      ��  �� Property � �� �� Value �#16a08563   �� 5+       � �� �#e9f0f463   �� 5,       � ��$	 8pt(�61   �� 5-       � ��$
 Bold"�63   �� 5.       � ��$ Center=�6C   �� 5/       � ��$
 Auto��6.   �� 50       �@ SeparatorBrush
 �����67   �� 51       �@ SeparatorVisibility$ Visible=�6<   �� 52       � �� 53      �� 54      .R�55   "   �� $	��5,0q�6=   $
��Wrap=�6J   $
��Auto��6^   $	��100��6k    �� TextAlignment$ Center=�6z    �� IsHyphenationEnabled .  � Language$ de-DE�6�   ��6,   �� 6�   56      58      59         Columns 5;      0  *System.Windows.Controls.DataGridTextColumn  5<      ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$ 2* 6%      dashboard_tcPeriod   Header# Z 6j   1  +System.Windows.Controls.DataGridBoundColumn   Binding 60   �� *Id+   ClipboardContentBinding 6G   Z� 6j     5=      $ 2* 6%       dashboard_tcEfficiency# Z  6r    60   �� *
Efficiency+ 6O   Z� 6r     5>      $ 3* 6%   !   dashboard_tcWorkload# Z! 6p    60   �� *
Workload+ 6M   Z� 6p     5?      $ 4* 6%   "   dashboard_tcProfit# Z" 6n    60   �� *Profit+ 6K   Z� 6n     5@      $ 4* 6%   $ Total��6s    60   �� *Totalprofit+ 6P   Z� 6s   5B      �� 5C   
   -   5        $ 	BtnFrench��5C      $�� ��6$   $��Right=�6/   $��Bottom=�6K   $��25��6f   $��0,0,9.667,150q�6q   $��10(�6�   ���	#FFD4CCCC$ 0.627,0.519&�6�   ��5D      �� 5E      $; 5/PPS-TOOL-DELUXE;component/Ressource/buttonFrance.png��6   5G      �� 5H   
   ���#9eb2c0$��2,2,2,2q�6'   $��Center=�6A   $��66��6^   $��150,0,150.667,9q�6j   $��Bottom=�6�   $	��254��6�   # �� Padding$# 0q�6�   5J      5K      