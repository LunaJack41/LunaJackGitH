   M S B A M L   `   `   `  ����E  AOurDevices, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:OurDevices.ViewsOurDevices.Views  5   	        OurDevices.Views.ShellView   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:OurDevices.Views     5   	   $��18(�5        � Title$  
OurDevices��5   	   $	��700��6   $
��1200��6*   
�������.��5	      �  � ColumnDefinitions 5
   
   �� 5      $��20 �6   �� 5      $
��auto �6   �� 5      $��* �6   �� 5      $	��100 �6    � RowDefinitions 5   
   �� 5      $��20 �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $��* �6   �� 5      $��20 �6   .+�5   
   �� $��1��6   $��1��6!   $��2��61   $��Center=�5      $��36(�61   Our Devices5      �� 5   
    �� Orientation$ Vertical=�6   $��1��6,   $��1��6<   .+�5      �� $��Center=�6   $��
ExtraBlack"�65   
Controls6W   � 5       5       �� 5"      $
��auto �6$   �� 5#      $
��auto �6$   �� 5$      $
��auto �6$   �� 5%      $
��auto �6$   �� 5&      $
��auto �6$   �� 5'      $
��auto �6$   �� 5(      $
��auto �6$   �� 5)      $
��auto �6$   �� 5*      $
��auto �6$   �� 5+      $
��auto �6$   �� 5,      $
��auto �6$   �� 5-      $��* �6$   .+�51      �� -   5         ��Name$ LaunchCreateDevice��51      $��Create Device��65   $��1��6M   $��2��6]   ���	#FF7E25256�   �� 53      -   5        $ LaunchCreatePerson��53      $��Create Person��65   $��1��6M   $��3��6]   6l   �� 55      -   5        $ LaunchCreateRoom��55      $��Create Room��63   $��1��6I   $��4��6Y   6h   �� 57      -   5        $ LaunchCreateDeviceAddress��57      $��Create IPAddress��6<   $��1��6W   $��5��6g   6v   �� 59      -   5        $ 	ListRooms��59      $��
List Rooms��6,   $��1��6A   $��6��6Q   6`   �� 5;      -   5        $ DevicesDataGrid��5;      $��Devices Grid��62   $��1��6I   $��7��6Y   6h   �� 5=      -   5        $ PeopleDataGrid��5=      $��People Grid��61   $��1��6G   $��8��6W   6f   5A      5C      �� 5D   
   $ Vertical=�6   $��3��6,   $��1��6<   .+�5E      �� $��
ExtraBlack"�6   Lists Window6>   �� 5F      $��
ExtraBlack"�6   $��5��60   $��Center=�6=   Lists6a   �� 5H      -   5         ��Name$ ExistingRooms��5H       �� DisplayMemberPath$ RoomName��6-   $��20��6J   $��7��6Y   $��1��6f    �� SelectedItem 5I      ��  �� Path$ SelectedRoom�	 �� Mode$	 OneWayToSource=��� 5L      -	   5        
 ��Name$
 SelectedRoom_RoomName��5L      $��8��67   $��30��6D   6U   5N      �� 5O   
   $ 
Horizontal=�6   $��2��6.   $��2��6>   .+�5P      �� -
   5         ��Name$ 
ActiveItem��5P      $��2��61   $��2��6>   5Q      5S      5T      