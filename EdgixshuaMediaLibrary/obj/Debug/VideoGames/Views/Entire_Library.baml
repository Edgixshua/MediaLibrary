   M S B A M L   `   `   `  ����P  LEdgixshuaMediaLibrary, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullU/clr-namespace:EdgixshuaMediaLibrary.Video_Games!EdgixshuaMediaLibrary.Video_Games  5   	   6    0EdgixshuaMediaLibrary.Video_Games.Entire_Library   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Alocal/clr-namespace:EdgixshuaMediaLibrary.Video_Games     5   	     � Title$  Entire_Library��5   	   $��419.653��6    $��727.456��61   .��5	      � $��0,0,0,2q�6    � ColumnDefinitions 5
   
   �� 5      $
��467* �6   �� 5      $
��125* �6    � RowDefinitions 5   
   �� 5      $	��32* �6   �� 5      $
��103* �6   .+�5   
   �� -   5         ��Name$ videoGameLibraryLabel��5      $��Video Game Library��6/   $
��Left=�6L   $	��Top=�6g   $
��Bold"�6   $
��25px(�6�   $��
248,10,0,0q�6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ dataGrid��5      $
��Left=�6%   $	��Top=�6@   $��
157,74,0,0q�6X      ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ 75 6�      AutoGenerateColumns .  $��2��6�   $��2��6�      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Title��6%   	   Width$		 200 6N   
   CanUserSort
 . 1  +System.Windows.Controls.DataGridBoundColumn   Binding 64   �� *Title+6o     5      $ Edition��6%   $		 100 6R   
 .  66   �� *	Edition+6s     5      $ Platform��6%   $		 100 6T   
 .  67   �� *
Platform+6u     5      $
 Year��6%   $	 50 6L   
 .  63   �� *Year+6l   5      �� 5   
   -   5         ��Name$ gameReturnButton��5      $��Return To Video Game Menu��6L   $
��Left=�6p   $	��Top=�6�   $	��172��6�   $
��Bold"�6�   $��	10,10,0,0q�6�   $��44��6�   �� 5   
   -   5        $ totalGameLabel��5      $��Total Game Count��6(   $
��Bold"�6C   $
��Left=�6U   $	��Top=�6p   $��	10,10,0,0q�6�   $��1��6�   �� 5   
   -   5        $ totalGameCountLabel��5      $�� ��6-   $
��Bold"�68   $��30(�6J   $
��Left=�6X   $	��Top=�6s   $��	41,41,0,0q�6�   $��1��6�   �� 5   
   -   5        $ refreshButton��5      $��Refresh��6(   $
��Bold"�6W   $
��Left=�6i   $	��Top=�6�   $��75��6�   $��
27,147,0,0q�6�   $��1��6�   $��37��6�   5      5       