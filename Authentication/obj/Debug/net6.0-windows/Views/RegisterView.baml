   M S B A M L   `   `   `  ????I  EAuthentication, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:Authentication.ViewsAuthentication.Views  5      J FPasswordBoxMVVM, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null`Aclr-namespace:PasswordBoxMVVM.Components;assembly=PasswordBoxMVVMPasswordBoxMVVM.Components 5      E'clr-namespace:Authentication.ViewModelsAuthentication.ViewModels  6c   '    !Authentication.Views.RegisterView   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      4local"clr-namespace:Authentication.Views     5      X
componentsAclr-namespace:PasswordBoxMVVM.Components;assembly=PasswordBoxMVVM     5      >
viewmodels'clr-namespace:Authentication.ViewModels     6c   .??5      ? $??25q?6   $	??500??6     ? RowDefinitions  5   
   ?? 5      $
??auto ?6   6,   ?? 5      $
??auto ?6   6,   .+?5   
   ?? $??0??5      $??32(?5      $??Register??5      ? 5   
   $??1??6   $??0 20 0 0q?6     5      ?? 5      $
??auto ?6    ?? 5      $
??auto ?6    ?? 5      $
??auto ?6    ?? 5      $
??auto ?6    ?? 5      $
??auto ?6    ?? 5      $
??auto ?6    .+?5       ?? $??0??6   .+?5!      ?? $??Email??6   ?? 5"      ??6   ?? *Email+ ?? UpdateSourceTrigger$ PropertyChanged=?5#      ?? 5%      $??1??6   $??0 10 0 0q?6&   .+?5&      ?? $??Username??6   ?? 5'      ??6   ?? *
Username+$ PropertyChanged=?5(      ?? 5*      $??2??6   $??0 10 0 0q?6&   .+?5+      ?? $??Password??6   4  .PasswordBoxMVVM.Components.BindablePasswordBox  5,         Password 61   ?? *
Password+$ PropertyChanged=?5-      ?? 5/      $??3??6   $??0 10 0 0q?6&   .+?50      ?? $??Confirm Password??6     51       61   ?? *ConfirmPassword+$ PropertyChanged=?52      ?? 54      $??4??6   $??0 20 0 0q?55      $??Submit??57      ??56      ?? *SubmitCommand+57      ?? 59      $??5??5:      $??0 10 0 0q?5;      $%??Already have an account? Log in??5<      ??5=      ?? *NaviagateLoginCommand+??5>      ?? 5?       ?? BasedOn# [B??6    ?? 
TargetType" ??6G   .?5@      ??  ?? Property ? ?? ?? Value
 ???? 67   ?? 5A       ? ??$ 0q?6<   5B      5E      5F      5G      5H      