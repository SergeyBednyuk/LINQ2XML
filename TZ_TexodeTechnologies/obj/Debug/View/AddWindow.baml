   M S B A M L   `   `   `  ����P  LTZ_TexodeTechnologies, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullQ-clr-namespace:TZ_TexodeTechnologies.ViewModelTZ_TexodeTechnologies.ViewModel  5      *    $TZ_TexodeTechnologies.View.AddWindow   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ?local-clr-namespace:TZ_TexodeTechnologies.ViewModel     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5        � Title$  	AddWindow��5      $	��300��5	      $	��300��5
       � DataContext 5      8  2TZ_TexodeTechnologies.ViewModel.AddWindowViewModel  5   
    � 	Resources 5       	  Style �� Property �� Value��%K   &	        �� 5   
   .�5      ��  � ��$ 50,20q�6/   5      5      .��5      �  � RowDefinitions 5   
   �� 5      �� 5      �� 5      �� 5       � ColumnDefinitions 5   
   �� 5      �� 5      .+�5    
   �� $��2��6   .+�5!      �� $��Center=�6   $��Id��61   �� 5"      $
��50,5q�6   ��6$   �� *Id+5$      �� 5&   
   $��1��6   .+�5'      �� $��Center=�6   $��
First name��61   �� 5(      $
��30,5q�6   ��6$   �� *	FirstName+5)      �� 5+   
   $��1��6   $��1��6"   .+�5,      �� $��Center=�6   $��	Last name��61   �� 5-      $
��30,5q�6   ��6$   �� *
LastName+5.      �� 50   
   $��2��6   $��0��6"   .+�51      �� $��Center=�6   $	��Age��61   �� 52      $
��30,5q�6   ��6$   �� *Age+53      �� 55   
   $��2��6   $��1��6"   .+�56      �� $��Center=�6   $��Gender��61   �� 57      $
��30,5q�6   ��6$   �� *Gender+58      �� 5:   
   $��3��5;      $��2��5<      $��Ok��5>      #��[  5?      ��5=      �� *	AddInfo+5?      5@      5A      