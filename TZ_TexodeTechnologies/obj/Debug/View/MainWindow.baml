   M S B A M L   `   `   `  ����P  LTZ_TexodeTechnologies, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullQ-clr-namespace:TZ_TexodeTechnologies.ViewModelTZ_TexodeTechnologies.ViewModel  5      &     TZ_TexodeTechnologies.MainWindow   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ?local-clr-namespace:TZ_TexodeTechnologies.ViewModel     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5        � Title$  
MainWindow��5      $	��525��5	      $	��350��5
       � Topmost .  � 	Resources 5         ButtonStyle �� Property �� Value)  #System.Windows.Controls.DataGridRow �� 
TargetType �� Triggers P� Property P� Value  StudentsData	 � Source
 � XPath��%�  &	        '  �     &	 M    �� 5   
   .�5      ��  � ��$ Times new roman)�63   �� 5       � ��$ 14(�61   �� 5       � ��$
 Bold"�63   �� 5       � ��$ 30q�6/   5      �� 5   
   "  6    5      P� 5       �@ AlternationIndex$ 0��66   . �5      ��  � ��
 ����63   5      5      � 5   
   $	 ../Students.xml?�5       $
 Students��5!      5"       � DataContext 5$      9   3TZ_TexodeTechnologies.ViewModel.MainVindowViewModel  5%   
   .��5'      �  � RowDefinitions 5(   
   �� 5)      �� 5*      �� 5+       � ColumnDefinitions 5-   
   �� 5.      �� 5/      �� 50      .+�54   
   �� $��2��6   $��3��6(   .��55      &   System.Windows.Controls.DataGrid  $��3��56      $��3��57      $��10q�58       �� AlternationCount$ 2��59         AutoGenerateColumns .  "   VerticalScrollBarVisibility$
 Auto=�5>      ��5;      ��  �� Source# [  �� XPath$ Student�� �� SelectedIndex 5<      �� *CurrectElementIdMainWindow+ �� Mode$ TwoWay=� �� SelectedItem 5=      �� *
XElement+$ TwoWay=�   Columns 5@      0  *System.Windows.Controls.DataGridTextColumn  5A      ,  &System.Windows.Controls.DataGridColumn   MinWidth$ 20Q�5B         Header$ Id��5D      1  +System.Windows.Controls.DataGridBoundColumn   Binding 5C      �� $	 @Id��5D      4  .System.Windows.Controls.DataGridTemplateColumn  5E      $ 	Full Name��6-      CellTemplate 5F      �� 5G      .R�5H   "   ��  �� Orientation$ 
Horizontal=�6-   .+�5I   &   �� ��6,   �� $
 Last���� 5J   &   ��6,   �� $ 	FirstName��5K   #   5L      5N        5O         Width5  /System.Windows.Controls.DataGridLengthConverter$
 auto 5P      $	 Age��5R       5Q      �� $	 Age��5R        5S      $ 50Q�5T      $ Gender��5V       5U      �� $ Gender��5V      5Z      5[      �� 5^   
   $��2��5_      $��0��5`      $	��Add��5b      #��[  5c      ��5a      �� *
ClickAdd+5c      �� 5d   
   $��2��5e      $��1��5f      $
��Edit��5h      #��[  5i      ��5g      �� *	ClickEdit+5i      �� 5j   
   $��2��5k      $��2��5l      $��Remove��5n      #��[  5o      ��5m      �� *ClickRemove+5o      5p      5q      