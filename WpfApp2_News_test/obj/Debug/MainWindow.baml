   M S B A M L   `   `   `  ����L  HWpfApp2_News_test, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:WpfApp2_News_testWpfApp2_News_test  5   	   "    WpfApp2_News_test.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:WpfApp2_News_test     5   	     � Title$  
MainWindow��5   	   $	��500��6   $	��500��6)    � 
ResizeMode$ CanMinimize=�65    � 	Resources 5	       �� 
TargetType �� Property �� Value   HeadingStyle  NewsTypeStyle  	TextStyle  ImagePathStyle��%�  '��       '�� G     &	  �     &	 �     &	 �    &	     �� 5
   
   " ��6   .�5      ��  � ��$ 5q�6'   5      �� 5   
   " ��6   .�5      ��  � ��$ 5q�6'   5      �� 5   
   " ��6%   .�5      ��  � ��$ 14(�6)   �� 5       � ��$
 Bold"�6+   5      �� 5   
   " ��6&   .�5      ��  � ��$ 13(�6)   �� 5       � ��$ DemiBold"�6+   �� 5       � ��
 �ݠ��6+   5      �� 5   
   " ��6"   .�5      ��  � ��$ 12(�6)   �� 5       � ��$ Regular"�6+   5      �� 5   
   " ��6'   .�5      ��  � ��$ 10(�6)   �� 5       � ��$
 Thin"�6+   �� 5        � ��
 �-R��6+   5!      5"      .��5#      �  � ColumnDefinitions 5$   
   �� 5%      $��* �6   �� 5&      $��* �6    � RowDefinitions 5(   
   �� 5)      $��* �6   �� 5*      $��* �6   .+�5-   
   �� -   5         ��Name$ ListBox��5-   /   $��0��6   $��0��6   $��15q�6@   ��5.      �� *News+	 �� SelectedItem	 5/      �� *SelectedNews+��50      �� 51      .R�52      �� 
 ��Name$
 
StackPanel��6!   .+�53      �� #��[  6$   ��6J   ��  �� Path$ Heading� �� Mode$ TwoWay=��� 54      #��[ 6$   ��6K   �� $
 Type�$ TwoWay=��� 55      #��[ 6$   ��6G   �� $ NewsText�$ TwoWay=��� 56      #��[ 6$   ��6L   �� $ 	ImagePath�$ TwoWay=�57      58      5:      �� 5<   
    �� Orientation$ Vertical=�5=      $��0��5>      $��1��5?      $��10q�5@      .+�5B      �� $��Заголовок:��6   �� 5C      -   5         ��Name$ 
HeadingTxt��5C      ��6*   �� *HeadingText+ �� UpdateSourceTrigger$ PropertyChanged=��� 5D      $(��"Категория новости:��6   �� 5E      -   5         ��Name$ ComboBoxType��5E      $��5q�6-   ��68   �� *GetNewsTypes+�� 5F      $��Текст:��6   �� 5G      -   5        $ NewsTextTxt��5G      ��6+   �� *NewsTextText+$ PropertyChanged=��� 5H      $%��Путь до картинки:��6   �� 5I      -   5        $ ImagePathTxt��5I      ��6,   �� *ImagePathText+$ PropertyChanged=�5J      �� 5L   
   -   5         ��Name$ AddBtn��5O      $��1��5L      $��1��6   $��50��5M      $	��150��5N      $��Добавить��5P      $�� ��5R      ��5Q      �� *
AddCommand+5S      5U      5W      