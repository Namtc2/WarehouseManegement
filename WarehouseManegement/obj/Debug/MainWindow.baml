   M S B A M L   `   `   `  ????N  JWarehouseManegement, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:WarehouseManegementWarehouseManegement  5   	   [2clr-namespace:WarehouseManegement.UserControlNamtc$WarehouseManegement.UserControlNamtc  5   	   $    WarehouseManegement.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:WarehouseManegement     5   	   c _System.Windows.Interactivity, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5	   	   _ [MaterialDesignThemes.Wpf, Version=4.8.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5
   	   ;uc2clr-namespace:WarehouseManegement.UserControlNamtc  5   	   -   5        $??Main_Window??5   	      MaterialDesignBody#???   5      $??Regular"?5      $??13(?5      &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=?5         TextRenderingMode$
 Auto=?5        MaterialDesignPaper#???  5        MaterialDesignFont#???  5       ? 
ResizeMode$ NoResize=?5   	    ? WindowStyle$
 None=?5   	    
 MainVM ? DataContext# [ 5   	    ? WindowStartupLocation$ CenterScreen=?5   	    ? Title$! Phần mềm quản lý kho??5   	   $	??600??6&   $	??800??63   .  (System.Windows.Interactivity.Interaction   Triggers 5      /  )System.Windows.Interactivity.EventTrigger  5   
      	EventName$ Loaded??6   .  (System.Windows.Interactivity.TriggerBase	   Actions.	 5      6  0System.Windows.Interactivity.InvokeCommandAction  
   Command
 5      ?? *LoadedWindowCommand+   CommandParameter 5      ??  ?? ElementName$ Main_Window??5      5      .??5!      ?  ? RowDefinitions 5"   
   ?? 5#      $
??auto ?6   6,   ?? 5$      6   .+?5&   
   ? $??0??6   .+?5'      ;   5WarehouseManegement.UserControlNamtc.CustomControlBar  
 ? Tag 6"   ?? *Title+$ Main_Window??6S   5(      ? 5)   
   $??1??6    5*      ?? 5+      $
??auto ?6    60   ?? 5,      6"   .+?5/      ? $??0??6   .+?50      ? $??Stretch=?6   $??Stretch=?63    ? ColumnDefinitions 51      ?? 52      6-   ?? 53      6-   ?? 54      6-   ?? 55      6-   ?? 56      6-   ?? 57      6-   ?? 58      6-   .+?5:      ?? $??0??6   $??2q?6-   $??50??68    # MaterialDesignRaisedLightButton#??[ 5<       ? ToolTip$ 
Nhập kho??5=      ??5;      ?? *InputCommand+.??5>      ?  5?      ?? 5@   "   62   ?? 5A   "   62   .+?5C      ? $??0??6#   .+?5D   "   ?? $??
Nhập kho??6,   6>   5E      ? 5F      $??1??6#   .+?5G   "   '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ ArchiveArrowDownOutline=?6:   $??24??6Y   $??24??6d   $??Center=?6p   5H      5I      5J      ?? 5L      $??1??6   $??2q?6-   $??50??68   #??[ 5N      $ 
Xuất kho??5O      ??5M      ?? *OutputCommand+.??5P      ?  5Q      ?? 5R   "   62   ?? 5S   "   62   .+?5U      ? $??0??6#   .+?5V   "   ?? $??
Xuất kho??6,   6>   5W      ? 5X      $??1??6#   .+?5Y   "     $ ArchiveArrowUpOutline=?6:   $??24??6W   $??24??6b   $??Center=?6n   5Z      5[      5\      ?? 5^      $??2??6   $??2q?6-   $??50??68   #??[ 5`      $ 
Hàng hóa??5a      ??5_      ?? *ObjectCommand+.??5b      ?  5c      ?? 5d   "   62   ?? 5e   "   62   .+?5g      ? $??0??6#   .+?5h   "   ?? $??
Hàng hóa??6,   6>   5i      ? 5j      $??1??6#   .+?5k   "     $ AnimationOutline=?6:   $??24??6R   $??24??6]   $??Center=?6i   5l      5m      5n      ?? 5p      $??3??6   $??2q?6-   $??50??68   #??[ 5r      $ Đơn vị đo??5t      ??5q      ?? *UnitCommand+??5s      ?? $ ucControlBar??.??5u      ?  5v      ?? 5w   "   62   ?? 5x   "   62   .+?5z      ? $??0??6#   .+?5{   "   ?? $??Đơn vị đo??6,   6?   5|      ? 5}      $??1??6#   .+?5~   "     $ Ruler=?6:   $??24??6G   $??24??6R   $??Center=?6^   5      5?      5?      ?? 5?      $??4??6   $??2q?6-   $??50??68   $??0q?6D   #??[ 5?      $ Nhà cung cấp??5?      ??5?      ?? *SuplierCommand+.??5?      ?  5?      ?? 5?   "   62   ?? 5?   "   62   .+?5?      ? $??0??6#   .+?5?   "   ?? $??Nhà cung cấp??6,   6B   5?      ? 5?      $??1??6#   .+?5?   "     $ Factory=?6:   $??24??6I   $??24??6T   $??Center=?6`   5?      5?      5?      ?? 5?      $??5??6   $??2q?6-   $??50??68   #??[ 5?      $ Khách hàng??5?      ??5?      ?? *CustomersCommand+.??5?      ?  5?      ?? 5?   "   62   ?? 5?   "   62   .+?5?      ? $??0??6#   .+?5?   "   ?? $??Khách hàng??6,   6@   5?      ? 5?      $??1??6#   .+?5?   "     $ HumanMaleFemaleChild=?6:   $??24??6V   $??24??6a   $??Center=?6m   5?      5?      5?      ?? 5?      $??6??6   $??2q?6-   $??50??68   #??[ 5?      $ Người dùng??5?      ??5?      ?? *UserCommand+.??5?      ?  5?      ?? 5?   "   62   ?? 5?   "   62   .+?5?      ? $??0??6#   .+?5?   "   ?? $??Người dùng??6,   6@   5?      ? 5?      $??1??6#   .+?5?   "     $ AccountBoxOutline=?6:   $??24??6S   $??24??6^   $??Center=?6j   5?      5?      5?      5?      5?      ? 5?      $??1??6    5?      ?? 5?      $
??auto ?6$   64   ?? 5?      6&   .+?5?      ? $??0??6   .+?5?      #  MaterialDesignThemes.Wpf.Card  .??5?      ? $??0??6    5?      ?? 5?   "   $
??auto ?60   6@   ?? 5?   "   $
??auto ?60   6@   ?? 5?   "   62   .+?5?      ? $??0??6#    5?   "   ?? 5?   &   $
??auto ?67   6F   ?? 5?   &   $
??auto ?67   6F   ?? 5?   &   $
??auto ?67   6F   .+?5?   "   ? $??0??6'   .+?5?   &   (	  "System.Windows.Controls.DatePicker	  $	??150??5?   +   $??10q?5?   +   $??Center=?5?   +   )
  #MaterialDesignThemes.Wpf.HintAssist 
  Hint$ Ngày bắt đầu??5?   +   .  (MaterialDesignThemes.Wpf.TextFieldAssist   HasClearButton .  ( $MaterialDesignFloatingHintDatePicker#??[ 5?   +   5?   #   ? 5?   "   $??1??6'   .+?5?   &   	  $	??150??5?   +   $??10q?5?   +   $??Center=?5?   +   $ Ngày kết thúc??5?   +    . #??[ 5?   +   5?   #   ? 5?   "   $??2??6'   .+?5?   &   ?? $??Lọc??5?   +   $??10q?5?   +   $??Center=?5?   +   $	??100??5?   +    " MaterialDesignRaisedDarkButton#??[ 5?   +   $3 -Resource name: MaterialDesignRaisedDarkButton??5?   +   {?5?   +   ?? *DataContext.ControlsEnabled+ ?? RelativeSource ?? *FindAncestor+ ?? AncestorType$ WindowL?5?   +   5?   #   5?      ? 5?      $??1??6#   .+?5?   "   ?? $??5q?6,   69   5?      ? 5?      $??2??6#    5?   "   ?? 5?   &   $
??auto ?67   6F   ?? 5?   &   $
??auto ?67   6F   ?? 5?   &   $
??auto ?67   6F   .+?5?   "   ? $??0??6'   .+?5?   &     $	??200??5?   )   $??0q?5?   )   $??10q?5?   )   ???#03a9f4 ! PrimaryHueDarkForegroundBrush#???  5?   )   .??5?   *   ?  5?   .   ?? 5?   2   $
??Auto ?6@   ?? 5?   2   $
??Auto ?6@   ?? 5?   2   $
??Auto ?6@   .+?5   .   ?? $??0??68   $??
16,16,16,4q?6E    $  MaterialDesignHeadline5TextBlock#??[ 5  2   $??Lượng nhập??5  2   ?? 6^   $??1??5  2     	 MaterialDesignLightSeparator#??[	 5  2   ?? 5  .   $??2??5  2   $??	16,0,16,8q?5  2   $
??Left=?5  2   $??Center=?5	  2    $
  MaterialDesignHeadline4TextBlock#??[
 5
  2   $??100000??5  2   '  !MaterialDesignThemes.Wpf.PopupBox  5  2   $??0??6J   $??2,0,2,0q?5  5   $??Right=?5  5      PopupContent. 5  6   ?? .+?5  :   ?? $
??More??5  =   ?? 5  :   $??Options??5  =   5  7   5  3   5  +   5  '   5  #   ? 5  "   $??1??6'   .+?5  &     $	??200??5  )   $??10q?5  )   $??0q?5  )   ???#03a9f4#???  5  )   .??5   *   ?  5!  .   ?? 5"  2   $
??Auto ?6@   ?? 5#  2   $
??Auto ?6@   ?? 5$  2   $
??Auto ?6@   .+?5&  .   ?? $??0??68   $??
16,16,16,4q?6E   #??[ 5'  2   $??Lượng xuất??5(  2   ?? 5)  .   $??1??5*  2   #??[	 5+  2   ?? 5,  .   $??2??5-  2   $??	16,0,16,8q?5.  2   $
??Left=?5/  2   $??Center=?50  2   #??[
 51  2   $??100000??52  2     53  .   $??0??6F   $??2,0,2,0q?54  5   $??Right=?55  5   . 56  2   ?? .+?57  6   ?? $
??More??58  =   ?? 59  6   $??Options??5:  =   5;  3   5<  /   5=  +   5>  '   5?  #   ? 5@  "   $??2??6'   .+?5A  &     $	??200??5B  )   $??0q?5C  )   $??10q?5D  )   ???#03a9f4#???  5F  )   .??5G  *   ?  5H  .   ?? 5I  2   $
??Auto ?6@   ?? 5J  2   $
??Auto ?6@   ?? 5K  2   $
??Auto ?6@   .+?5M  .   ?? $??0??68   $??
16,16,16,4q?6E   #??[ 5N  2   $??	Tồn kho??5O  2   ?? 5P  .   $??1??5Q  2   #??[	 5R  2   ?? 5S  .   $??2??5T  2   $??	16,0,16,8q?5U  2   $
??Left=?5V  2   $??Center=?5W  2   #??[
 5X  2   $??100000??5Y  2     5Z  .   $??0??6F   $??2,0,2,0q?5[  5   $??Right=?5\  5   . 5]  2   ?? .+?5^  6   ?? $
??More??5_  =   ?? 5`  6   $??Options??5a  =   5b  3   5c  /   5d  +   5e  '   5f  #   5g     5h     5i     5j       5l     $??1??6&   $??5q?63   $??Stretch=?6>   .??5m     ?  5n     ?? 5o     $
??auto ?6,   6<   ?? 5p     $
??auto ?6,   6<   ?? 5q     6.   .+?5s     ? $??0??6    5t     ?? 5u  "   $
??auto ?63   6B   ?? 5v  "   $
??auto ?63   6B   ?? 5w  "   $
??auto ?63   6B   .+?5y     ? $??0??6#   .+?5z  "   	  $	??150??5{  +   $??10q?5|  +   $??Center=?5}  +   $ Ngày bắt đầu??5~  +    . #??[ 5?  +   5?     ? 5?     $??1??6#   .+?5?  "   	  $	??150??5?  +   $??10q?5?  +   $??Center=?5?  +   $ Ngày kết thúc??5?  +    . #??[ 5?  +   5?     ? 5?     $??2??6#   .+?5?  "   ?? $??Lọc??5?  +   $??Center=?5?  +   $??10q?5?  +   $	??100??5?  +   #??[ 5?  +   $3 -Resource name: MaterialDesignRaisedDarkButton??5?  +   {?5?  +   ?? *DataContext.ControlsEnabled+ ?? *FindAncestor+$ WindowL?5?  +   5?     5?     ? 5?     $??1??6   .+?5?     ?? 6*   5?     ? 5?     $??2??6   .+?5?     ?? ??6'   ?? *
TonKhoList+ ?? View 5?  "   ?? 5?  &   .P?5?  *   ?? $	??STT??69    ?? DisplayMemberBinding 6F   ?? *STT+6m   ?? 5?  *   $??Tên hàng hóa??69    6O   ?? *Object.DisplayName+6?   ?? 5?  *   $??Số lượng tồn kho??69    6S   ?? *Count+6|   5?  '   5?     5?     5?     5?     5?     5?     5?     5?     