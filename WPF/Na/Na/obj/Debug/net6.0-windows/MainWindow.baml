   M S B A M L   `   `   `  ����=  9Na, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:NaNa  5   	       Na.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   "localclr-namespace:Na     5   	   -   5          � Title$  
MainWindow��5   	   $	��550��6   $	��800��6)   $��Times New Roman)�6L   $��18(�6i   .��5	      � .+�5   
   �� $��Số lượng��6   $
��Left=�6#   $��
61,235,0,0q�6>   $	��Top=�6R   $	��126��6j   $��48��6v   �� 5   
   $��
Đơn giá��6   $
��Left=�6"   $��
61,182,0,0q�6=   $	��Top=�6Q   $	��126��6i   $��48��6u   �� 5   
   $��Loại sản phẩm��6   $
��Left=�6(   $��
61,129,0,0q�6C   $	��Top=�6W   $	��126��6o   $��48��6{   �� 5   
   $��Tên sản phẩm��6   $
��Left=�6'   $��	61,76,0,0q�6B   $	��Top=�6U   $	��126��6m   $��48��6y   �� 5   
   $��Mã sản phẩm��6   $
��Left=�6&   $��	61,10,0,0q�6A   $	��Top=�6T   $	��126��6l   $��48��6x   �� 5   
   -   5        $��txtMaSP��5      $��Center=�6!   $��0,10,0,0q�6>    �� TextWrapping$
 Wrap=�6P   $�� ��6d   $	��Top=�6l   $	��353��6�   $��36��6�   �� 5   
   -   5        $��txtDG��5      $��Center=�6    $��	0,170,0,0q�6=   $
 Wrap=�6P   $�� ��6d   $	��Top=�6l   $	��353��6�   $��36��6�   �� 5   
   -   5        $��txtSL��5      $��Center=�6   $��	0,235,0,0q�6<   $
 Wrap=�6O   $�� ��6c   $	��Top=�6k   $	��353��6�   $��36��6�   �� 5   
   -   5        $��txtTenSP��5      $��Center=�6"   $��0,64,0,0q�6?   $
 Wrap=�6Q   $�� ��6e   $	��Top=�6m   $	��352��6�   $��36��6�   �� 5   
   -   5         ��Name$ 
combLoaisp��5      $
��Left=�6'   $��224,117,0,0q�6B   $	��Top=�6W   $	��202��6o   $��36��6{   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ 
dgvSanPham��5         AutoGenerateColumns$ False��5         AlternatingRowBackground
 � ��   CanUserAddRows$ False��5      $��61,280,53,92q�6%      Columns 5   
   0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Mã SP��6!   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 60   �� *MaSp+  5      $ Tên SP��6!   	 61   �� *TenSp+  5      $ Mã loại SP��6!   	 65   �� *MaLoai+  5      $ Số lượng��6!   	 63   �� *	SoLuong+  5      $ 
Đơn giá��6!   	 62   �� *DonGia+  5      $ Thành tiền��6!   
   Width5  /System.Windows.Controls.DataGridLengthConverter$
 * 6S   	 65   �� *	ThanhTien+6S   5!      �� 5"   
   -   5        $��Thêm��5"      $
��Left=�6    $��
61,460,0,0q�6;   $	��Top=�6O   $��85��6g   $��35��6r    J� RenderTransformOrigin$ 0.526,1.318&�6~   6�   �� 5#   
   -	   5        $
��Tìm��5#      $
��Left=�6   $��467,460,0,0q�6:   $	��Top=�6O   $��85��6g   $��35��6r   $ 0.478,1.235&�6~   6�   �� 5$   
   -
   5        $
��Xóa��5$      $
��Left=�6   $��319,460,0,0q�6:   $	��Top=�6O   $��85��6g   $��35��6r   $ 0.506,1.797&�6~   6�   �� 5%   
   -   5        $��Sửa��5%      $
��Left=�6   $��185,460,0,0q�6:   $	��Top=�6O   $��85��6g   $��35��6r   $ 0.497,1.173&�6~   6�   �� 5&   
   -   5        $��Thống kê��5&      $
��Left=�6$   $��596,459,0,0q�6?   $	��Top=�6T   $��85��6l   $��36��6w   $ 2.123,-0.273&�6�   6�   5(      5)      