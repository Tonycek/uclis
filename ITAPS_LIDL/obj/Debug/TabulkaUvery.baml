   M S B A M L   `   `   `  ����E  AITAPS_LIDL, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:ITAPS_LIDL
ITAPS_LIDL  5   	       ITAPS_LIDL.TabulkaUvery   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:ITAPS_LIDL     5   	   -   5          � Title$  Tabulka Uvery��5   	   $��712.953��6   $��1146.471��60    � SizeToContent$ Width=�5	   	    � 
ResizeMode$ CanMinimize=�5
   	   .��5      � .+�5   
   &   System.Windows.Controls.DataGrid  -   5        $��datagrid��5      $��	0,72,0,40q�6#   $
��auto��66      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Termin obnovy skusky��6%      
IsReadOnly .    MinWidth$	 140Q�6U   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6d   ��  �� Path$ Termin�6�     5      $ Email��6%    . $	 180Q�6G    6V   �� $ Email�6w     5      $ Hours��6%    . 	   Width5  /System.Windows.Controls.DataGridLengthConverter$	 80 6F    6Q   �� $ Hours�6r     5      $
 Note��6%    . $	 150Q�6F    6U   �� $
 Note�6u   5      �� 5   
   -   5        $��choosePageCombobox��5      
 �� SelectedValuePath$
 Content��6-   $��
270,29,0,0q�6I   $	��Top=�6]   $
��Left=�6u   $	��120��6�   .@�5      �� $��Tabulka Uvery��6   �� 5      $��
Log Skusky��6   �� 5      $��Log Skolenia��6   5      �� 5   
   $��Choose page��6   $
��Left=�6&   $��
186,25,0,0q�6A   $	��Top=�6U    J� RenderTransformOrigin$ 1.563,0.462&�6m   �� 5   
   -   5        $��Log Off��5      $��	0,25,10,0q�6"   $	��Top=�65   
����  �$ 
5.28,0.962&�6�   $��Right=�6�   $��50��6�   ��5      �� 5       �� 
TargetType" ��6    �� Triggers 5      P� 5       P� Property �@J�IsMouseOver P� Value . . �5       ��  �� Property �@�Cursor �� Value$
 Hand��67   5!      5#      5%      5'      5(      