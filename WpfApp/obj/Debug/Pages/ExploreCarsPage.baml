   M S B A M L   `   `   `  ����O  Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089I2clr-namespace:System.Collections;assembly=mscorlibSystem.Collections  5      A =WpfApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:WpfAppWpfApp 5         WpfApp.ExploreCarsPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      >d2http://schemas.microsoft.com/expression/blend/2008    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      _ [MaterialDesignThemes.Wpf, Version=5.2.2.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      <col2clr-namespace:System.Collections;assembly=mscorlib  5       localclr-namespace:WpfApp  5        N� Title$  ExploreCarsPage��5
      .��5      ��    FloatingBorder#��[  6   $��20q�65   $��Stretch=�6A   ._�5   
   �  � ColumnDefinitions 5      �� 5      $
��auto �6#   �� 5      .+�5      �� -   5         ��Name$ ListViewExploreCars��5      $
��Left=�6_   ��5      �� 5       �� 
TargetType" ��6   .�5      ��  �� Property � �� �� Value$ 5q�63   �� 5       � ��  MaterialDesignBackground# �  67   �� 5       � ��$ Stretch=�6G   �� 5       � ��$ Stretch=�6E   �� 5       � �� 5      �� 5   "    �� 
TargetType" ��62   .R�5   &   �� #��z��6-    �� CornerRadius$ 15��5   !    �� Padding$ 5q�5   !   $��0q�5   !   ._�5   *   �� 5    '   5!   #   5#      5$      ��5(      �� 5)      .R�5*      �� $ 20��6!   $	��370��63   ._�5+      � 	 � RowDefinitions	 5,   "   �� 5-   &   $
��Auto �64   �� 5.   &   $
��Auto �64    50   "   �� 51   &   $
��Auto �67   �� 52   &   $��* �67   .+�55   "   �� $��2��6)   $��0,0,10,0q�6:   $ 	16,0,0,16��6a   $	��135��6z   $	��180��6�   ��56   &   �� 57   *   
 j� Stretch$
 UniformToFill=�6Z    �� ImageSource 65   �� *VehicleImage+6Z   59   #   �� 5;   "   $��1��6,    �� Padding$ 5q�6<   $
��Wrap=�6H   $
��Bold"�6\   $��16(�6n   ��5<   &   `� 5=   *    �� StringFormat$ {0} {1} {2}��67   .1�5>   .   ��  �� Path$
 Make�66   �� 5?   .   $ Model�66   �� 5@   .   $
 Year�66   5A   +   5C   #   �� 5E   "   $ 5q�6,   $��1��68   $��2��6H   $��14(�6p   ��6U   �� *	DailyRate+6p   5F      5G      5H       � 	Resources 5K      "   System.Collections.ArrayList  vehicles  WpfApp.Vehicle   Make   LicensePlate��%  &	         5L        5M      $ Toyota��6(   $ aa777��66     5N      $
 Ford��6(   $ bb777��65     5O      $ 
Volkswagen��6(   $ cc777��6:     5P      $ Geely��6(   $ dd777��65     5Q      $ Tesla��6(   $ ee777��65   5R      5S      5T      �� 5e      $��1��6   .+�5f      �� -   5         ��Name$ textBlockMakeModel��5f      $��20(�68   $
��Bold"�6F   �� 5g      -   5        $ textBlockLicensePlate��5g      $��16(�6;   �� 5h      -   5        $ textBlockDailyRate��5h      $��16(�68   �� 5j      -   5         ��Name$ imageVehicle��5j      $	��260��6.   $��Uniform=�6;   �� 5l      $��Reviews��6   $��18(�6+   $
��Bold"�69   $��
10,20,10,5q�6K   �� 5m      -   5         ��Name$ listBoxReviews��5m      �� 5o      $��
Add Review��6     RaisedLightButton#��[ 6/   $��10q�6Z   5p      5q      5r      5s      