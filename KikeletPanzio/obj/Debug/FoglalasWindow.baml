   M S B A M L   `   `   `  ����H  DKikeletPanzio, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:KikeletPanzioKikeletPanzio  5   	   "    KikeletPanzio.FoglalasWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:KikeletPanzio     5   	     � Title$  Szobafoglalás��5   	   $	��450��6   $	��600��6,    � 	Resources 5	       �� 
TargetType �� Property �� Value��%S   '��       �� 5
   
   " ��6   .�5      ��  � ��$	 100��6&   5      5      .��5      �  � RowDefinitions 5   
   �� 5      $��40 �6   �� 5      $��50 �6   �� 5      $��50 �6   �� 5      $��50 �6   �� 5      $��50 �6   �� 5      $	��100 �6   .+�5   
   �� $��Szobafoglalás��6   $��Center=�6(   $
��Bold"�6E   $��18(�6W   $	��150��6e   �� 5   
    �� Orientation$ 
Horizontal=�6   $��5q�6.   $��1��69   $��Center=�6F   .+�5      �� $��	Ügyfél:��6   �� 5      -   5        $��CbxUgyfelValaszt��5      $	��200��6/   5      �� 5   
   $ 
Horizontal=�6   $��2��6.   $��5q�6;   $��Center=�6F   .+�5      �� $��Érkezés dátuma:��6   (  "System.Windows.Controls.DatePicker  5      -   5        $��	DPErkezes��5      $	��200��6*   5      �� 5    
   $ 
Horizontal=�6   $��3��6.   $��5q�6;   $��Center=�6F   .+�5!      �� $��Távozás dátuma:��6     5"      -   5        $��	DPTavozas��5"      $	��200��6*   5#      �� 5$   
   $��4��6   $ 
Horizontal=�6"   $��Center=�6;   .+�5%      �� $��Hány főre?��6   �� 5&      -   5         ��Name$ 	TbxFoSzam��5&      $	��100��6)   $��20��6c   5'      �� 5(   
   $��5��6   .+�5)      �� $��Éjszakák száma:��6   �� 5*      -   5        $ TbxEjszakak��5*      �� 5+      -   5        $��	FOglalás��5+      6(   5,      5-      5.      