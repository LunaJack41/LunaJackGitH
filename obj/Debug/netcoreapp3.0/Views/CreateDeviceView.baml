   M S B A M L   `   `   `  ����E  AOurDevices, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:OurDevices.ViewsOurDevices.Views  5      '    !OurDevices.Views.CreateDeviceView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      0localclr-namespace:OurDevices.Views     5      
�������.��5	      � .+�5
   
   ��   �� Orientation$  Vertical=�6   $��	10,0,10,0q�6,   .+�5      �  � ColumnDefinitions 5      �� 5      $
��auto �6'   �� 5      $��* �6'    � RowDefinitions 5      �� 5      $��20 �6$   �� 5      $
��auto �6$   �� 5      $
��auto �6$   �� 5      $
��auto �6$   �� 5      $
��auto �6$   �� 5      $
��auto �6$   �� 5      $
��auto �6$   �� 5      $
��auto �6$   �� 5      $
��auto �6$   �� 5      $
��auto �6$   �� 5      $
��auto �6$   �� 5      $
��auto �6$   �� 5      $��* �6$   �� 5      $��20 �6$   .+�5"      �� $��	5 0 10 10q�6   $��0��6/   $��1��6?   $��20(�6L   $��Oblique$�6Z   Enter Devices5$      �� 5'      $��	5 0 10 10q�6   $��0��6/   $��2��6?   Device Name6Y   �� 5(      -   5         ��Name$ 
DeviceName��5(      $��0 0 5 10q�6.   $��1��6@   $��2��6P   6_   �� 5+      $��	5 0 10 10q�6   $��0��6/   $��3��6?   Choose Device6[   �� 5,      -   5         ��Name$ AvailableDevices��5,      $��0 0 5 10q�65   $��1��6G   $��3��6W    �� DisplayMemberPath$ 
DeviceName��5.       �� SelectedItem 5-      ��  �� Path$ SelectedDeviceToEdit� �� Mode$ OneWayToSource=�5.      �� 52      $��	5 0 10 10q�6   $��0��6/   $��4��6?   Device Type6Y   �� 53      -   5        $ 
DeviceType��53      $��0 0 5 10q�6.   $��1��6@   $��4��6P   6_   �� 55      $��	5 0 10 10q�6   $��0��6/   $��5��6?   
IP Address6X   �� 56      -   5        $ AvailableIPAddress��56      $��0 0 5 10q�67   $��1��6I   $��5��6Y   $ 	IPAddress��58       57      �� $ SelectedIPAdressToAdd�$ OneWayToSource=�58      �� 5;      $��	5 0 10 10q�6   $��0��6/   $��6��6?   MAC Address6Y   �� 5<      -   5        $ 
MACAddress��5<      $��0 0 5 10q�6.   $��1��6@   $��6��6P   6_   �� 5>      $��	5 0 10 10q�6   $��0��6/   $��7��6?   Mobile6T   �� 5?      -   5        	 ��Name$	 Mobile��5?      
 d� 	IsChecked$

 TrueY�6+   $��0 0 5 10q�6<   $��1��6N   $��7��6^   5A      �� 5G      $  
Horizontal=�6   $��11��67   $��1��6E   $��Center=�5H      $��	5 0 10 10q�6:   .+�5I      �� -   5         ��Name$ CreateDevice��5I      
��� � �$��0 0 5 0q�6F   $��1��6X   $��2��5J      $��11��6.   $��10q�6<   .��6I   Create Device5L      �� 5M      -   5        $ Update��5M      
�������$��10q�6@   .��6O   Update6W   �� 5N      -	   5        $ DeleteDevice��5N      
�������$��10q�6F   .��6U   Delete Device6d   �� 5O      -
   5        $ CancelCreation��5O      
���  ��$��5 0 0 0q�6F   $��20q�6W   .��6f   Cancel6n   5P      5U      5X      5Z      5[      