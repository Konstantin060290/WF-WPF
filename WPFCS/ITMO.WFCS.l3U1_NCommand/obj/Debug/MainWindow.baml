   M S B A M L   `   `   `  ����R  NITMO.WFCS.l3U1_NCommand, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:ITMO.WFCS.l3U1_NCommandITMO.WFCS.l3U1_NCommand  5   	   A%clr-namespace:ITMO.WFCS.l3U1_NCommandITMO.WFCS.l3U1_NCommand  5   	   (    "ITMO.WFCS.l3U1_NCommand.MainWindow   5   	   /Local%clr-namespace:ITMO.WFCS.l3U1_NCommand  5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   7local%clr-namespace:ITMO.WFCS.l3U1_NCommand     5   	     � Title$  
MainWindow��5	   	   $	��450��6   $	��800��6)   .��5      � .+�5   
   o� $
��Left=�6   $��30��6*   $	��Top=�66   $��70��6N   $��	10,20,0,0q�6Y   .@�5      m� $��MenuItem��6   $��0,0,0,10q�6)   .@�5      m� $��Launch��6    m� Command$! local:CustomCommands.Launch��6+   5      5      �� 5   
   -   5         ��Name$ textBox��5      $
��Left=�6#   $��23��6>   $��205,130,0,0q�6J    �� TextWrapping$
 Wrap=�6_   $��TextBox��6s   $	��Top=�6�   $	��120��6�   �� 5   
   -   5         ��Name$ richTextBox��5      $
��Left=�6+   $	��100��6F   $��445,105,0,0q�6S   $	��Top=�6h   $	��100��6�   . �5      /� .T�5      J� .*�6   .*�5      �� $�RichTextBox��6   5      5      5      �� 5   
   $!��local:CustomCommands.Launch��6   $��Launch��67   $
��Left=�6H   $��345,275,0,0q�6c   $	��Top=�6x   $��75��6�   �� 5   
   -   5         ��Name$ checkBox��5      $��Enable Launch Command��6%   $
��Left=�6E   $��454,275,0,0q�6`   $	��Top=�6u   5      5      