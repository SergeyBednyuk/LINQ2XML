   M S B A M L   `   `   `  ����P  LTZ_TexodeTechnologies, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullQ-clr-namespace:TZ_TexodeTechnologies.ViewModelTZ_TexodeTechnologies.ViewModel  5      +    %TZ_TexodeTechnologies.View.EditWindow   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ?local-clr-namespace:TZ_TexodeTechnologies.ViewModel     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5        � Title$  
EditWindow��5      $	��300��5	      $	��300��5
       � 	Resources 5       	  Style �� Property �� Value��%K   &	        �� 5   
   .�5      ��  � ��$ 50,20q�6/   5      5       � DataContext 5      9   3TZ_TexodeTechnologies.ViewModel.EditWindowViewModel  5   
   .��5      �  � RowDefinitions 5   
   �� 5      �� 5      �� 5      �� 5       � ColumnDefinitions 5   
   �� 5      �� 5      .+�5    
   �� $��2��6   .+�5!      �� $��Center=�6   $��Id��61   �� 5"      -   5         ��Name$ EditWindowTxtBxId��5#      $
��50,5q�5$       �� 
IsReadOnly . ��5&      �� *Id+	 �� Mode$	 TwoWay=�5'      �� 5)   
   $��1��6   .+�5*      �� $��Center=�6   $��
First name��61   �� 5+      -   5        $ EditWindowTxtBxFirstName��5,      $
��30,5q�5-      ��5.      �� *	FirstName+$	 TwoWay=�5/      �� 51   
   $��1��6   $��1��6"   .+�52      �� $��Center=�6   $��	Last name��61   �� 53      -   5        $ EditWindowTxtBxLastName��54      $
��30,5q�55      ��56      �� *
LastName+$	 TwoWay=�57      �� 59   
   $��2��6   $��0��6"   .+�5:      �� $��Center=�6   $	��Age��61   �� 5;      -   5        $ EditWindowTxtBxAge��5<      $
��30,5q�5=      ��5>      �� *Age+$	 TwoWay=�5?      �� 5A   
   $��2��6   $��1��6"   .+�5B      �� $��Center=�6   $��Gender��61   �� 5C      -   5        $ EditWindowTxtBxGender��5D      $
��30,5q�5E      ��5F      �� *Gender+$	 TwoWay=�5G      �� 5I   
   $��3��5J      $��2��5K      $
��Edit��5M      #��[  5N      ��5L      �� *	ClickEdit+5N      5O      5P      