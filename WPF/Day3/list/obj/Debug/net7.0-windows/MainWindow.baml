   M S B A M L   `   `   `  ?????  ;list, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:listlist  5   	       list.MainWindow   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   #studclr-namespace:list     5   	     ? Title$  
MainWindow??5   	   $	??450??6   $	??800??6)    ? 	Resources 5	         back ?? 
StartPoint ?? EndPoint ? Color ? Offset   list.Student 	 Stud1	   Id   Name   Salary	   Description
   Image??%s  &	        &	 ?     ?? 5
   
   $	 0,0&?6+   $	 1,1&?6<   .??5      ? $ DeepPink??6   $	 .25Q?6,   6;   ? 5      $ HotPink??6   $ .5Q?6+   69   ? 5      $ 	LightPink??6   $	 .75Q?6-   6<   5        5   
   $ 10??5      $ Rehab??5      $ 20000??5      $	 Hello World??5      $
 /gws.jpg??5      5      5      .??5      ]? $??False??6   .+?5   
   ?? -   5        $
??list??5      $
??Left=?6   #??[  64   5      ?? 5   
    ? DataContext 5      ??  ?? ElementName$
 list?? ?? Path$ SelectedItem?.+?5       ?? $	??100??6   $	??100??6    ??6-   ?? *Image+?? 5!      ??6   ?? *Id+?? 5"      ??6   ?? *Name+?? 5$      ??6   ?? *Salary+?? 5%      ??6   ?? *Description+5&      5'      5(      