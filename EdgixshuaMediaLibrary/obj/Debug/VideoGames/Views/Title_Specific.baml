   M S B A M L   `   `   `  ����P  LEdgixshuaMediaLibrary, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullS.clr-namespace:EdgixshuaMediaLibrary.VideoGames EdgixshuaMediaLibrary.VideoGames  5   	   5    /EdgixshuaMediaLibrary.VideoGames.Title_Specific   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   @local.clr-namespace:EdgixshuaMediaLibrary.VideoGames     5   	     � Title$  Title_Specific��5   	   $��399.13��6    $��480.652��60   .��5	      � .+�5
   
   �� -   5         ��Name$ searchbByTitleLabel��5
      $��Search By Title��6-   $
��Left=�6G   $	��Top=�6b   $
��Bold"�6z   $
��25px(�6�   $��
146,18,0,0q�6�   �� 5   
   -   5         ��Name$ titleSearchTextBox��5      $
��Left=�6.   $��23��6I    �� TextWrapping$
 Wrap=�6U   $	��Top=�6i   $	��170��6�   $��
239,85,0,0q�6�   �� 5   
   -   5        $ titleSearchLabel��5      $#��Enter a keyword or game title��6*   $
��Bold"�6R   $
��Left=�6d   $	��Top=�6   $��	37,82,0,0q�6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ dataGrid��5      $
��Left=�6%   $	��Top=�6@   $��
10,157,0,0q�6X      ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ 75 6l      AutoGenerateColumns .     Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Title��6%   	   Width$		 200 6N   
   CanUserSort
 . 1  +System.Windows.Controls.DataGridBoundColumn   Binding 64   �� *Title+6Z     5      $ Edition��6%   $		 100 6R   
 .  66   �� *	Edition+6^     5      $ Platform��6%   $		 100 6T   
 .  67   �� *
Platform+6`     5      $
 Year��6%   $	 50 6L   
 .  63   �� *Year+6W   5      �� 5   
   -   5         ��Name$ titleSearchButton��5      $��Search��6,   $
��Bold"�6=   $
��Left=�6a   $	��Top=�6|   $��75��6�   $��198,123,0,0q�6�   �� 5   
   -   5        $ gameReturnButton��5      $��10(�6+   $
��Left=�6Z   $	��Top=�6u   $	��112��6�   $
��Bold"�6�   $��	10,10,0,0q�6�   $��39��6�   .��5      �� 	Return To�� 6"   Video Game Menu6>   5      5      5      