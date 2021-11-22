# C#  筆記

參考微軟提供官方文件[C#文件](https://docs.microsoft.com/zh-tw/dotnet/csharp/)

## 範例學習

參考基礎中的範例教學，建立銀行帳戶系統。

## 筆記
- 相較於javascript屬於動態偏向弱型別語言，C#屬於靜態偏向強型別語言，使用尚須先宣告其型態，且大多情況需指定轉換型態，不會像javascript自動轉換。
- 
  - 常見層級
- using
  - 指示詞，使用指定的命名空間(namespace)
  - exapmle
  ```C#
  using System;
  ```
  - 加入上述程式後，原本須以System.Console.WriteLine()即可變成Console.WriteLine()
- main()
  - 依照慣例為預設的程式進入點。
  - static為靜態方法，不需要參考特定物件。
  - void為設定不回傳。
```C#
static void Main(string[] args)
    {
        Console.WriteLine("Hello, World");
    }
```

## 參考
- [你不可不知的 JavaScript 二三事#Day2：資料型態的夢魘——動態型別加弱型別(1)](https://ithelp.ithome.com.tw/articles/10201839)
- [你不可不知的 JavaScript 二三事#Day3：資料型態的夢魘——動態型別加弱型別(2)](https://ithelp.ithome.com.tw/articles/10202260)
- [存取範圍層級 (C# 參考)](https://docs.microsoft.com/zh-tw/dotnet/csharp/language-reference/keywords/accessibility-levels) 
- [c# Public? Private? protected? 比較各種修飾詞存取範圍](https://aihuadesign.com/2020/03/16/access-modifiers-c-sharp/)
