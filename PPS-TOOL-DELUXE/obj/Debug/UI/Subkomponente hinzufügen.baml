   M S B A M L   `   `   `  ����J  FPPS-TOOL-DELUXE, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:PPS_TOOL_DELUXEPPS_TOOL_DELUXE  5   	   6    0PPS_TOOL_DELUXE.Utility.SubkomponenteHinzufügen   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:PPS_TOOL_DELUXE     5   	   -   5          �Name$$  SubKomponenteHinzufuegenWindow��5   	    � WindowStartupLocation$ CenterScreen=�5   	    � Title$ Subkomponente hinzufügen��5	      $	��140��6)   $	��320��66    � DataContext 6B   �� *
Produces+   Locator �� Source# [   � 	Resources 5
        ProducesViewSource �� Source  PurchasesViewSource-  'System.Windows.Data.CompositeCollection  CombinedCollection �� 
Collection��%�   &	       7   &	 7     7   &	 p     7  7  �� 5   
    6:   �� *Produces.Produces+8   �� 5   
    6;   �� *Purchases.Purchases+8     5   
   �� 5       6"   �� 8   �� 5       6"   �� 8  5      5      .��5      � $��0,0,3,4.667q�6   ���#2e3641.+�5   
   �� $��Subkomponente:��6   $
��Left=�6)   $	��Top=�6D   $��	20,20,0,0q�6\   $��10(�6o   ���#e9f0f46}   �� 5   
   $��Anzahl:��6   $
��Left=�6"   $	��Top=�6=   $��	20,60,0,0q�6U   $��10(�6h    J� RenderTransformOrigin$ 0.5,0.5&�6v   ���#e9f0f46�   �� 5   
   $�� ��6   $
��Left=�6   $	��Top=�66   $��	16,85,0,0q�6N   $��10(�6a   $ 0.5,0.5&�6o   �� 5   
   -   5        $��Drop_Down_Arbeitsplatz��5      $
��Left=�61   $	��Top=�6L   $��70��6d   $��
110,27,0,0q�6o   $��10(�6�   
�������
�������#��[ 6�   	 �� DisplayMemberPath$	 id��6�   
 �� SelectedValuePath$
 id��6B   �� SelectedValue 6  �� *NewProduceSubcomponent.id+ �� Mode$ TwoWay=�6B  �� 5   
   -   5        $��btn_abbrechen��5      $��	Abbrechen��6&   $��Right=�6:   $	��Top=�6V   $��75��6n   $��	0,27,20,0q�6y   $��16��6�   $��10(�6�   ���#9eb2c0���#9eb2c0���#e9f0f46�   �� 5   
   -   5        $��btn_hinzufügen��5      $��Hinzufügen��6'   $��Right=�6<   $	��Top=�6X   $��75��6p   $��	0,60,20,0q�6{   $ 0.5,0.5&�6�   $��16��6�   $��10(�6�   ���#16a085���#e9f0f4���#16a085��6  �� *AddComponentCommand+60  �� 5   
   -   5         ��Name$ Textbox_Rüstzeit��5      $
��Left=�6,   $��13��6G    �� TextWrapping$
 Wrap=�6S   $	��Top=�6g   $��70��6   $��
110,65,0,0q�6�   $��10(�6�   ��6�   �� *NewProduceSubcomponent.need+$ TwoWay=�5      5      