   M S B A M L   `   `   `  ����E  AITAPS_LIDL, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:ITAPS_LIDL
ITAPS_LIDL  5   	       ITAPS_LIDL.Users   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:ITAPS_LIDL     5   	   -   5          � Title$  	All users��5   	   $��712.953��6   $��1146.471��6,    � SizeToContent$ Width=�5	   	    � 
ResizeMode$ CanMinimize=�5
   	   .��5      � .+�5   
   &   System.Windows.Controls.DataGrid  -   5        $��datagrid��5      $��	0,72,0,40q�6#   $
��auto��66      RowStyle 5      �� 5       �� 
TargetType)  #System.Windows.Controls.DataGridRow"  6    �� Triggers 5      �� 5       �� Binding 6&   ��  �� Path$ State� �� Value
 State16E   .a�5      �� 	 �� Property	 � ��
 �� Value

 �  ��6I   5      �� 5       6&   �� $ State�
 State26E   .a�5      �� 	 � ��

 � ���6L   5      5         Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ ID usera��6%      
IsReadOnly .    Width5  /System.Windows.Controls.DataGridLengthConverter$
 auto 6I   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6V   �� $ Id�6t     5      $ Spolocnost usera��6%    . $
 auto 6R    6_   �� $ Company�6�     5      $ 
Meno usera��6%    . $
 auto 6K    6X   �� $
 Name�6x     5      $ Kategoria usera��6%    . $
 auto 6Q    6^   �� $ 	Categhory�6�   4  .System.Windows.Controls.DataGridCheckBoxColumn  5      $ Potrebuje skolenie��6)    .    MinWidth$ 80Q�6W    6e   �� $
 TypA�  5      $ Posledne skolenie robil/a��6%    . $
 auto 6Z    6g   �� $ PosledneSkolenie�6�     5       $ Potrebuje skusku��6)    . $ 80Q�6U    6c   �� $
 TypB�  5!      $ Poslednu skusku robil/a��6%    . $
 auto 6Y    6f   �� $ PoslednyTest�6�     5"      $ Email��6%    . $
 auto 6F    6S   �� $ Email�6t     5#      $ Pocet hodin��6%    . $
 auto 6M    6Z   �� $ Hours�6{     5$      $ Poznamka��6%    . $
 auto 6I    6V   �� $
 Note�6v   5&      �� 5'   
   -   5        $��Log Off��5'      $��	0,25,10,0q�6"   $	��Top=�65   
����  � J� RenderTransformOrigin$ 
5.28,0.962&�6�   $��Right=�6�   $��50��6�   ��5(      �� 5)      " ��6    5*      P� 5+       P� Property �@J�IsMouseOver P� Value . . �5,      �� 	 �@�Cursor$

 Hand��67   5-      5/      51      �� 52   
   -   5        $��choosePageCombobox��52       �� SelectedValuePath$ Content��6-   $��
0,29,491,0q�6I   $	��Top=�6]   $��Right=�6u   $	��120��6�   .@�53      �� $��Tabulka Uvery��6   �� 54      $��
Log Skusky��6   �� 55      $��Log Skolenia��6   56      �� 57   
   $��Choose page��6   $��Right=�6&   $��
0,25,616,0q�6B   $	��Top=�6V   59      5:      