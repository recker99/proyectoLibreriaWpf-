   M S B A M L   `   `   `  ����G  CLibreria_GUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:Libreria_GUILibreria_GUI  5   	       Libreria_GUI.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:Libreria_GUI     5   	   -   5          � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      ]� ��.  .+�5
   
   o� -   5         o�Name$ mnPrincipal��5
   .   $
��Auto��6    o� 
IsMainMenu . $	��Top=�6C   .@�5      m� $��Administración de libros��6   .@�5      m� -   5         m�Name$ optAgregarLibro��5   2   $��Agregar libro��6   6K   m� 5      -   5        $ optListarLibros��5   2   $��Listar libros��6   6K   5      m� 5      -   5        $ optReportes��5   )   $��Reportes��6   6>   5      &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ dgListadoLibros��5      $
��Auto��6,   $
��Auto��69   {�.  $	��Top=�6Y   6n   5      5      