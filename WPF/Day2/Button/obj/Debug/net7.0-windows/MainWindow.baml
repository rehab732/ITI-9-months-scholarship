   M S B A M L   `   `   `  ????A  =Button, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:ButtonButton  5   	       Button.MainWindow   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:Button     5   	     ? Title$  
MainWindow??5   	   $	??450??6   $	??800??6)    ? 	Resources 5	         BtnBackground ?? 
StartPoint ?? EndPoint ? Color ? Offset  BtnBackground2 ?? 
TargetType ?? Property ?? Value	 ?? Triggers
 P? Property P? Value??%?  &	        &	 ?     '?? ?    7  7   ?? 5
   
   $	 0,0&?64   $	 1,1&?6E   .??5      ? $ DeepPink??6   $	 .25Q?6,   6;   ? 5      $ HotPink??6   $ .5Q?6+   69   ? 5      $
 Pink??6   $	 .75Q?6(   67   5      ?? 5   
   $	 0,0&?65   $	 1,1&?6F   .??5      ? $ 
DarkViolet??6   $ .5Q?6.   6<   ? 5      $ Violet??6   $	 .25Q?6*   69   ? 5      $
 Pink??6   $	 .75Q?6(   67   5      ?? 5   
   " ??6   .?5      ??  ? ??
 ?? ??6+   ?? 5       ? ??$ 12(?6)   ?? 5       ? ??$ Normal"?6+   	 5      P? 5      
 ?@J?IsMouseOver$
 True??61   . ?5      ??  ? ??
 ?????63   ?? 5       ? ??$
 Bold"?63   ?? 5       ? ??$ 15(?61   6>   ?? 5       ? ??$	 150??6.   ?? 5       ? ??$	 150??6/   ?? 5        ? ??$ Hover??60   ?? 5!       ? ??8   63   5#      P? 5$      
 ?@J?	IsFocused$
 True??6/   . ?5%      ??  ? ??
 ?  ??63   ?? 5&       ? ??$ 15(?61   ?? 5'       ? ??$	 100??6.   ?? 5(       ? ??$	 100??6/   ?? 5)       ? ??$ Clicked??60   5+      P? 5,      
 ?@J?IsMouseOver$ False??61   . ?5-      ??  ? ??
 ?  ??63   ?? 5.       ? ??$ 13(?61   ?? 5/       ? ??$
 Bold"?63   ?? 50       ? ??$	 100??6.   ?? 51       ? ??$	 100??6/   ?? 52       ? ??$ Click Me??60   ?? 54       ? ??8  63   58      5:      5;      .??5<      ?? .+?5>      ?? 5A      5B      