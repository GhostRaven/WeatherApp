   M S B A M L   `   `   `  ����N  JExamples.MVVM.Basic, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:Examples.MVVM.BasicExamples.MVVM.Basic  5   	   $    Examples.MVVM.Basic.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:Examples.MVVM.Basic     5   	     � Title$  
MainWindow��5   	   $	��350��6   $	��525��6)    � 	Resources 5
       �� MergedDictionaries �� Source�� 5   
    5      �� 5      $% ./Resources/ComboBoxStyles.xaml?�6%   �� 5      $" ./Resources/ButtonStyle.xaml?�6%   %    5      .��5      � ���#0079F2 � ColumnDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5    
   (�  (� Stretch$ UniformToFill=�6   $��50��6*   .��5!      �� $��0��6   $��1��6$   $��64��6x   $��64��6�   ��65   �� *
FlagSource+ �� UpdateSourceTrigger$ PropertyChanged=�6�   5"      �� 5$   
   $��1��65   $��0��6E   $��Center=�6R   $��14(�6t   $��20,0,0,0q�6�    �� 
IsEditable .     CustomComboBoxStyle#���   5%   n   ��5$      �� *	Countries+	 �� SelectedItem	 5%      �� *SelectedCountry+
 �� Mode$
 TwoWay=�$ PropertyChanged=���5&      �� 5'      .R�5(      �� ��6    �� *Name+5)      5+      �� 5-   
   $��2��62   $��0��6B   $��Center=�6O   $��20,0,0,0q�6q   #���   5.      $��14(�5/      ��5-      �� *Cities+	 5.   A   �� *SelectedCity+$
 TwoWay=�$ PropertyChanged=���50      �� 51      .R�52      �� ��6    �� *Name+53      55      �� 58   
   $��2��6=   $��3��6J   
�������$��Stretch=�6z   ��6   �� *ActualViewModel+6z   ]� 5<   
   $��2��6   $��3��6$   $��Bottom=�61   $��Right=�6L   .+�5=      �� $=��7/Examples.MVVM.Basic;component/Resources/phone-call.png��6   $��64��6}   $��64��6�     CustomButtonStyle#���  6�   
������ ��6W   �� *CommandGetWeather+6�   �� 5>      $=��7/Examples.MVVM.Basic;component/Resources/phone-call.png��6   $��64��6~   $��64��6�   #���  6�   
������ ��6W   �� *CommandGetForecast+6�   5?      5@      5A      