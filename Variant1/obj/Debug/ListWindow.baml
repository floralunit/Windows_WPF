   M S B A M L   `   `   `  ����C  ?Variant1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:Variant1Variant1  5   	       Variant1.ListWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:Variant1     5   	   -   5          � Title$(  "Работа со списками��5   	   $��239.729��6$   $��334.762��65   .��5	      � $��0,0,0.4,-19.6q�6    � ColumnDefinitions 5
   
   �� 5      $��3* �6   �� 5      $	��10* �6   .+�5   
   �� -   5         ��Name$ num_textBox��5      $
��Left=�6'   $��23��6B   $��	10,41,0,0q�6N    �� TextWrapping$
 Wrap=�6a   $	��Top=�6u   $	��185��6�   $��2��6�   �� 5   
   -   5         ��Name$ label��5      $9��3Введите слова через пробел: ��6   $
��Left=�6F   $��	10,10,0,0q�6a   $	��Top=�6t    J� RenderTransformOrigin$ -0.752,-0.002&�6�   $��2��6�   $	��185��6�   �� 5   
   -   5         ��Name$ listBox��5      $
��Left=�6#   $	��100��6>   $��	10,69,0,0q�6K   $	��Top=�6^   $	��308��6v   $ -0.139,0.278&�6�   $��2��6�   �� 5   
   -   5         ��Name$ 
res_button��5      $!��Создать список��6%   $��145.4,41,10,0q�6>   $	��Top=�6U   $ 0.962,0.496&�6m   $��1��6�   $��23��6�   6�   �� 5   
   -   5        $ exit_button��5      $��
Назад��6&   $
��Left=�66   $��167,174,0,0q�6Q   $	��Top=�6f   $��75��6~   $ 1.733,-6.955&�6�   $��1��6�   5      5      