   M S B A M L   `   `   `  ����J  FPPS-TOOL-DELUXE, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:PPS_TOOL_DELUXE.PropertiesPPS_TOOL_DELUXE.Properties  5   	   1clr-namespace:PPS_TOOL_DELUXEPPS_TOOL_DELUXE  5   	   F    @PPS_TOOL_DELUXE.Masterdata.Workplaces.UI.ArbeitsplatzHinzufügen   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   6p(clr-namespace:PPS_TOOL_DELUXE.Properties     5   	   /localclr-namespace:PPS_TOOL_DELUXE     5   	     � WindowStartupLocation$  CenterScreen=�5	   	    � Title$ Arbeitsplatz hinzufügen��5
   	   $��154.285��6)   $��332.164��6:   ���#2e3641 � DataContext 6J   �� *
Produces+   Locator �� Source# [  .��5      �  � ColumnDefinitions 5   
   �� 5      $
��100* �6   �� 5      $	��140 �6   �� 5      $
��137* �6   .+�5   
   �� )   #PPS_TOOL_DELUXE.Properties.Resource"   produceItems_edit_workplace#��Z 6   $
��Left=�6L   $	��Top=�6g   $��	16,25,0,0q�6   $��10(�6�   $��23��6�   $��65��6�   ���#e9f0f46�   �� 5   
   "   produceItems_edit_setUpTime#��Z 6   $
��Left=�6L   $	��Top=�6g   $��	33,55,0,0q�6   $��10(�6�    J� RenderTransformOrigin$ 0.5,0.5&�6�   $��24��6�   $��48��6�   ���#e9f0f46�   �� 5   
      produceItems_edit_time#��Z 6   $
��Left=�6G   $	��Top=�6b   $��6,85,0,0q�6z   $��10(�6�   $ 0.5,0.5&�6�   $��23��6�   $��75��6�   ���#e9f0f46�   �� 5   
   -   5        $��Drop_Down_Arbeitsplatz��5      $
��Left=�61   $	��Top=�6L   $	��110��6d   $��	11,30,0,0q�6p   $��10(�6�   
�������
�������$��1��6�   	 �� DisplayMemberPath$	 id��6  
 �� SelectedValuePath$
 id��6l  ��6�   �� *Workplaces.Workspaces+# [   �� SelectedValue 6.  �� *NewProduceWorkspace.id+ �� Mode$ TwoWay=�6l  �� 5   
   -   5        $��btn_abbrechen��5         cancel#��Z 6&   $
��Left=�6M   $	��Top=�6h   $��75��6�   $��	10,30,0,0q�6�   $��10(�6�   ���#9eb2c0���#9eb2c0���#e9f0f4$��2��6�   6�   �� 5   
   -   5        $��btn_hinzufügen��5      "   produceItems_dialog_confirm#��Z 6'   $
��Left=�6c   $	��Top=�6~   $��75��6�   $��	10,85,0,0q�6�   $ 0.5,0.5&�6�   $��10(�6�   ���#16a085���#e9f0f4���#16a085$��2��6"  ��6O  �� *AddWorkspaceCommand+�� 5   
   -   5         ��Name$ Textbox_Rüstzeit��5      $
��Left=�6,   $��13��6G    �� TextWrapping$
 Wrap=�6S   $	��Top=�6g   $	��110��6   $��	11,60,0,0q�6�   $��10(�6�   $��1��6�   ��6�   �� *NewProduceWorkspace.setUpTime+�� 5   
   -   5        $ Textbox_Fertigungszeit��5      $
��Left=�62   $��13��6M   $
 Wrap=�6Y   $	��Top=�6m   $	��110��6�   $��	11,90,0,0q�6�   $��10(�6�   $��1��6�   ��6�   �� *NewProduceWorkspace.time+5      5      