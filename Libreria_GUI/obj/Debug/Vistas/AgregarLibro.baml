   M S B A M L   `   `   `  ����G  CLibreria_GUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:Libreria_GUI.VistasLibreria_GUI.Vistas  5   	   &     Libreria_GUI.Vistas.AgregarLibro   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:Libreria_GUI.Vistas     5   	     � Title$  Agregar nuevo libro��5   	   $	��450��6%   $	��800��62   .��5	      � .+�5
   
   �� -   5         ��Name$ lblIsbn��5
      $
��ISBN��6!   $
��Left=�60   $��	73,81,0,0q�6K   $	��Top=�6^   �� 5   
   -   5        $ 	lblTitulo��5      $��Título libro��6#   $
��Left=�6:   $��
73,112,0,0q�6U   $	��Top=�6i   �� 5   
   -   5        $ lblAutorLibro��5      $��Autor��6'   $
��Left=�67   $��
73,143,0,0q�6R   $	��Top=�6f   �� 5   
   -   5        $ lblDisponibilidad��5      $��
Disponible��6+   $
��Left=�6@   $��
73,174,0,0q�6[   $	��Top=�6o   �� 5   
   -   5         ��Name$ txtIsbn��5      $
��Left=�6#   $��
179,85,0,0q�6>    �� TextWrapping$ NoWrap=�6R   $	��Top=�6h   $	��519��6�    �� 	MaxLength$ 13��5      ��5      �� *Isbn+ �� UpdateSourceTrigger$ PropertyChanged=� �� ValidatesOnDataErrors .  � ToolTip 5      �� *ErrorCollection[Isbn]+�� 5   
   -   5        $ txtTituloLibro��5      $
��Left=�6*   $��179,116,0,0q�6E   $ NoWrap=�6Z   $	��Top=�6p   $	��519��6�   $ 50��5      ��5      �� *Titulo+$ PropertyChanged=� .  5      �� *ErrorCollection[Titulo]+�� 5   
   -   5        $ txtAutorLibro��5      $
��Left=�6)   $��179,147,0,0q�6D   $ NoWrap=�6Y   $	��Top=�6o   $	��519��6�   $ 50��5      ��5      �� *Autor+$ PropertyChanged=� .  5      �� *ErrorCollection[Autor]+�� 5   
   -   5         ��Name$ chkDisponible��5      $��Está disponible��6*   $
��Left=�6D   $��179,179,0,0q�6_   $	��Top=�6t   	 d� 	IsChecked	 5      �� *EstaDisponible+$ PropertyChanged=��� 5    
   -	   5        
 ��Name$
 btnAgregarLibro��5       $��Agregar libro��6*   $
��Left=�6B   $��343,236,0,0q�6]   $	��Top=�6r   6�   5"      5#      