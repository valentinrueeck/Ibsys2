   M S B A M L   `   `   `  ����   PPS-TOOL-DELUXE/    )PPS_TOOL_DELUXE.UI.Arbeitsplatzverwaltung   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     -     �Name$"  ArbeitsplatzverwaltungWindow�� � Title$ Arbeitsplatzverwaltung�� � WindowStartupLocation$ CenterScreen=�$	��400��$	��570��$	��570��$	��400�� � 
ResizeMode$ NoResize=� � DataContext �� *
Workplaces+   Locator �� Source# [  .��� .+��� $��Arbeitsplatzverwaltung��$��Center=�$	��Top=�$��0,38,0,0q�$��Italic$��� $��OptiPPS��$��Center=�$	��Top=� J� RenderTransformOrigin$ 3.158,0.577&�$��0,15,0,0q�$��14(�$
��Bold"��� -    ��Name$ BtnWorkspacesBack��$��Zurück��$
��Left=�$	��Top=�$��75��$��	20,30,0,0q�$��10(����	#FFD4CCCC���� *CloseWindowCommand+ �� Mode$ OneWay=����� 	 �� ElementName$"	 ArbeitsplatzverwaltungWindow���� -   $+ %btn_Arbeitsplatzverwaltung_bearbeiten��$��
Bearbeiten��$��Right=�$	��Top=�$��75��$��	0,30,20,0q�$��10(����	#FFD1D1D1{�.  &   System.Windows.Controls.DataGrid  -   
  Name$
 workspacesGrid��   AutoGenerateColumns .  $
��Left=�$	��296��$��	20,66,0,0q�$	��Top=�$	��543����. $
��Auto=�   
IsReadOnly .    SelectionMode$ Single=����� *
Workspaces+ �� SelectedItem �� *SelectedWorkspace+$ TwoWay=�   Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Header$ Id��1  +System.Windows.Controls.DataGridBoundColumn   Binding �� *id+   ClipboardContentBinding Z�    HeaderStyle ��  �� 
TargetType=  7System.Windows.Controls.Primitives.DataGridColumnHeader"  .���  �� Property � �� �� Value
 ��ح���  � ��$	 8pt(���  � ��$
 Bold"���  � ��$ Center=���  � ��$ 20��  $ Bezeichnung�� �� *
label.de+ Z�  �� "  .���  � ��
 ��ح���  � ��$	 8pt(���  � ��$
 Bold"���  � ��$ Center=���  � ��$	 120��  $ 1.Schicht
 [€/min]�� �� *costs.firstStint+ Z�  �� "  .���  � ��
 ��ح���  � ��$	 8pt(���  � ��$
 Bold"���  � ��$ Center=���  � ��$ 60��  $ 2.Schicht
 [€/min]�� �� *costs.secondStint+ Z�  �� "  .���  � ��
 ��ح���  � ��$	 8pt(���  � ��$
 Bold"���  � ��$ Center=���  � ��$ 60��  $ 3.Schicht
 [€/min]�� �� *costs.thirdStint+ Z�  �� "  .���  � ��
 ��ح���  � ��$	 8pt(���  � ��$
 Bold"���  � ��$ Center=���  � ��$ 60��  $ Überstunden
   [€/min]�� �� *costs.extraHour+ Z�  �� "  .���  � ��
 ��ح���  � ��$	 8pt(���  � ��$
 Bold"���  � ��$ Center=���  � ��$ 70��  $  Masch.kosten
fix [€/min]�� �� *costs.maschine.fix+ Z�  �� "  .���  � ��
 ��ح���  � ��$	 8pt(���  � ��$
 Bold"���  � ��$ Center=���  � ��$ 70��  $  Masch.kosten
var [€/min]�� �� *costs.maschine.variable+ Z�  �� "  .���  � ��
 ��ح���  � ��$	 8pt(���  � ��$
 Bold"���  � ��$ Center=���  � ��$ 70��