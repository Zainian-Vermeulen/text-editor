   M S B A M L   `   `   `  ����B  >ToolDev, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:ToolDevToolDev  5   	   7 clr-namespace:ToolDev.ViewModelsToolDev.ViewModels  5   	       ToolDev.MainWindow   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:ToolDev     5   	   7
viewmodels clr-namespace:ToolDev.ViewModels     5   	     � Title$  	Notepad--��5	   	   $	��400��6   $	��600��6(    � DataContext 5      &    ToolDev.ViewModels.MainViewModel  5   
    J� InputBindings 5      �� 5   
    �� 	Modifiers$ Controlf�6   
 �� Key$ S��6)    �� Command 61   �� *File.SaveCommand+�� 5   
   $ Controlf�6   $ O��6)    61   �� *File.OpenCommand+�� 5   
   $ Controlf�6   $ N��6)    61   �� *File.NewCommand+�� 5   
   $	 Altf�6   $ F4��6%    6.   �� *File.ExitCommand+.��5      ]� .+�5   
   o� $	��Top=�6   @�5      m� 5      $��_File��6    6*   �� *File+.@�5      m� $
��_New��6    m� InputGestureText$ Ctrl+N��6-    m� Command 6G   �� *
NewCommand+m� 5      $��_Open��6   $ Ctrl+O��6.    6H   �� *OpenCommand+m� 5      $��
Save_As...��6   $ Ctrl+S��63    6M   �� *SaveCommand+m� 5       $��_Recent Files��6    66   �� *RecentCommand+�� 5!      $
��Left=�6    $��1��6;   $	��140��6F   6T   m� 5"      $��_Exit��6   $ Alt+F4��6.    6H   �� *ExitCommand+5$      m� 5&      $��Fo_rmat��6    6,   �� *Editor+.@�5'      m� $��Fo_nt��6    6.   �� *FormatCommand+m� 5(      $��
_Word Wrap��6    63   �� *WrapCommand+5)      m� 5+      $��_Help��6    6*   �� *Help+.@�5,      m� $��_About��6    6/   �� *HelpCommand+5-      50      ]� 52   
   .+�53      �� $��Bottom=�6    54      �� *File.Document+��55      �� *
FilePath+�� 57      $	��Top=�6   " �� VerticalScrollBarVisibility$ Visible=�58      	 �� AcceptsReturn$
	 True��5?      
 �� 
AcceptsTab$

 True��5@       59      �� *Editor+��5:      �� *Format.Family+��5;      �� *Format.Size+��5<      �� *Format.Style+��5=      �� *Format.Weight+ �� TextWrapping 5>      �� *Format.Wrap+��5A      �� *Document.Text+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�5B      5D      5F      