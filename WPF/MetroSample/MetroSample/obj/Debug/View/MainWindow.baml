   M S B A M L   `   `   `  ����T  PMahApps.Metro, Version=1.3.0.0, Culture=neutral, PublicKeyToken=f4fb5a3c4d1e5b4fV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls  5   	   F BMetroSample, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:MetroSample.ViewModelMetroSample.ViewModel 5   	   !   MetroSample.View.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   PControls;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro     5   	   9	ViewModel#clr-namespace:MetroSample.ViewModel     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -   5          � Title$  History��5   	   $	��340��6   $	��570��6&   (   "MahApps.Metro.Controls.MetroWindow   WindowTitleBrush
 �  ��$	��340��6M   $	��570��6]   $	��340��6l   $	��570��6|    � 	Resources 5      /  )MetroSample.ViewModel.MainWindowViewModel !  MainWindowViewModelDataSource��%   &	          5   
   6(   5      .��5      �  � DataContext 6   ��  �� Source# [  .+�5   
   &   System.Windows.Controls.DataGrid     
IsReadOnly . $
��Left=�6�   $	��254��6�   $��
183,37,0,0q�6�   $	��Top=�6�   $	��350��6�      AutoGenerateColumns .     GridLinesVisibility$	 All=�6   �� AlternationCount$ 1��6  	 �� SelectedItem	 6%   �� *SelectedPurchaseHistoryDto+
 �� Mode$
 TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=���64  �� *
MasterData+ 6W  ��    Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$
 Name��6>   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� *Name+6>     5      $
 Cost��6>    6%   �� *Cost+6>     5      $
 Type��6>    6%   �� *Type+6>     5      $ Brand��6?    6%   �� *Brand+6?     5      $
 Date��6>      Width5  /System.Windows.Controls.DataGridLengthConverter$ 90 6L    6%   �� *Date+6L   5      �� 5   
   *   $MahApps.Metro.Controls.TextBoxHelper   	Watermark$
 Name��6      ClearTextButton . $
��Left=�6h   $��32��6�   $��	28,37,0,0q�6�    �� TextWrapping$
 Wrap=�6�   $	��Top=�6�   $	��121��6�   ��6�   �� *!SelectedPurchaseHistoryDto.Name+�� 5   
   $
 Cost��6    . $
��Left=�6h   $��31��6�   $��	28,77,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $	��121��6�   ��6�   �� *!SelectedPurchaseHistoryDto.Cost+�� 5   
    . $
 Type��6@   $
��Left=�6h   $��32��6�   $��
28,117,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $	��121��6�   ��6�   �� *!SelectedPurchaseHistoryDto.Type+�� 5   
    . $ Brand��6@   $
��Left=�6i   $��32��6�   $��
28,157,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $	��121��6�   ��6�   �� *" SelectedPurchaseHistoryDto.Brand+�� 5   
    �� 
IsReadOnly . $
 Date��6$   $
��Left=�6L   $��64��6g   $��
28,197,0,0q�6s   $
 Wrap=�6�   $	��Top=�6�   $	��121��6�   ��6�   �� *!SelectedPurchaseHistoryDto.Date+�� 5!   
   $��Total Records :��6   $
��Left=�6*   $��	180,7,0,0q�6E   $	��Top=�6X   $��98��6p   
�������$��27��6�   $
��Bold"�6�    J� RenderTransformOrigin$ 1.328,-3.752&�6�   �� 5"   
   $
��Left=�65   $��	290,7,0,0q�6P   $	��Top=�6c   $��51��6{   $ 3.583,2.994&�6�   ��6   �� *MasterData.Count+6�   �� 5#   
   $
��Left=�6A   $��25,0,0,0q�6\   $	��Top=�6n   $��85��6�   $ 1,2.994&�6�   
�������$��20(�6�   $��Calibri)�6�   $��Heavy"�6�   ��6   �� *IPurchaseHistoryBll.Nickname+6�   �� 5%   
   $	��Add��6   $
��Left=�6    $��
28,267,0,0q�6;   $	��Top=�6O   $��55��6g   ��6r   �� *
AddCommand+�� 5&   
   $��Delete��6   $
��Left=�6"   $��
94,267,0,0q�6=   $	��Top=�6Q   $��55��6i   ��6t   �� *DeleteCommand+5)      5*      