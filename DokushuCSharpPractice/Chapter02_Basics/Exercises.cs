namespace DokushuPractice;

// ============================================================================
//  第2章 C#の基本（変数・データ型・リテラル・型変換・参照型）
//
//  使い方:
//   1) 各メソッドの「throw new NotImplementedException();」を消して TODO を実装する
//   2) このフォルダで `dotnet run` を実行する
//   3) 表示結果が「期待出力」と一致すれば正解。詰まったら 解答.md を見る
// ============================================================================
public static class Exercises
{
    /// <summary>
    /// 【2.1.1 変数の宣言 / 2.1.4 定数】
    /// 円周率を const double PI = 3.14 として宣言し、半径 radius = 3 の円の
    /// 「面積」と「円周」を計算して表示しなさい。
    /// 期待出力:
    ///   半径3の円 → 面積: 28.26 / 円周: 18.84
    /// </summary>
    public static void Ex01_VariableAndConst()
    {
        // TODO: const で円周率を宣言し、面積(PI*r*r)と円周(2*PI*r)を計算して表示
        const double Pi = 3.14;
        int radius = 3;

        double area = Pi * radius * radius;
        double circumference = 2 * Pi * radius;
        Console.WriteLine($"半径3の円{area}/ {circumference}");
    }

    /// <summary>
    /// 【2.2 データ型 / 2.2.7 型推論】
    /// var を使って 整数・小数・文字列・真偽値 をそれぞれ宣言し、
    /// 各変数の「実際の型名」を GetType().Name で表示しなさい。
    /// 期待出力（例）:
    ///   100 は Int32
    ///   3.14 は Double
    ///   Hello は String
    ///   True は Boolean
    /// </summary>
    public static void Ex02_TypeInference()
    {
        // TODO: var n = 100; のように4種類宣言し、$"{n} は {n.GetType().Name}" を表示
        var n = 100;
        var a = 2;
        var b = 39;
        var m = 4;

        Console.WriteLine($"{n}は{n.GetType().Name}");
        Console.WriteLine($"{a}は{a.GetType().Name}");
        Console.WriteLine($"{b}は{b.GetType().Name}");
        Console.WriteLine($"{m}は{m.GetType().Name}");
    }

    /// <summary>
    /// 【2.2.2 整数型】
    /// int 型と long 型それぞれの「最大値」を表示しなさい（int.MaxValue 等を使う）。
    /// さらに int.MaxValue に 1 を足すと何が起きるか（オーバーフロー）を表示しなさい。
    /// 期待出力:
    ///   int 最大値: 2147483647
    ///   long 最大値: 9223372036854775807
    ///   int最大値+1: -2147483648
    /// </summary>
    public static void Ex03_IntegerRange()
    {
        // TODO: int.MaxValue, long.MaxValue, そして unchecked(int.MaxValue + 1) を表示
        int a = int.MaxValue;
        long b = long.MaxValue;
        int c = a + 1;
        Console.WriteLine(a);
        Console.WriteLine(b);
        Console.WriteLine(c);

    }

    /// <summary>
    /// 【2.4 型変換 / 2.4.3 文字列⇔数値の変換】
    /// 文字列 "42" と "8" を int に変換して足し算し、結果を表示しなさい。
    /// その後、合計を再び文字列にして "合計は50です" の形で表示しなさい。
    /// 期待出力:
    ///   42 + 8 = 50
    ///   合計は50です
    /// </summary>
    public static void Ex04_StringNumberConversion()
    {
        string a = "42";
        string b = "8";
        // TODO: int.Parse で数値化 → 加算 → 結果を表示、合計を ToString して文章に埋め込む
        int n = int.Parse(a);
        int c = int.Parse(b);
        int sum = n + c;
        Console.WriteLine($"合計は{sum}です");
        
    }

    /// <summary>
    /// 【2.4.2 明示的な変換（キャスト）】
    /// double 値 3.99 を int にキャストすると小数部はどうなるか確認しなさい（切り捨て）。
    /// 期待出力:
    ///   3.99 を int にキャスト → 3
    /// </summary>
    public static void Ex05_ExplicitCast()
    {
        double value = 3.99;
        // TODO: (int)value を表示
        Console.WriteLine($"{(int)value}");


    }                                               

    /// <summary>
    /// 【2.5.4 配列型】
    /// int 配列 {10, 20, 30, 40, 50} の「合計」と「平均」を計算して表示しなさい。
    /// （ループは第4章の内容ですが、foreach か for を使ってよい）
    /// 期待出力:
    ///   合計: 150 / 平均: 30
    /// </summary>
    public static void Ex06_Array()
    {
        var sum = 0;
        
        int[] numbers = { 10, 20, 30, 40, 50 };
        // TODO: 合計を求め、平均(合計/要素数)を表示
        foreach(var num in numbers )
        {
           
            sum += num;
        }

        var average = sum / numbers.Length;
        
        Console.WriteLine($"合計:{sum}");
        Console.WriteLine($"平均:{average}");

    }

    /// <summary>
    /// 【2.5.2 null値 / 2.5.3 null許容参照型 / 3.3.5 null合体演算子（先取り）】
    /// string? name = null のとき、null合体演算子 ?? を使って
    /// 「名前が無ければ "名無し" を使う」処理を書き、表示しなさい。
    /// 期待出力:
    ///   ようこそ、名無し さん
    /// </summary>
    public static void Ex07_NullCoalescing()
    {
        string? name = null;
        // TODO: name ?? "名無し" を使って表示
        Console.WriteLine($"ようこそ{name ?? "名無し"}さん");
    }

    /// <summary>
    /// 【ミニプロジェクト：自己紹介カード】
    /// この章で学んだ「変数・データ型・型変換・文字列補間」を総動員。
    /// 名前(string)・年齢(int)・身長(double)を変数に入れ、次の形式で表示しなさい。
    /// 期待出力（例）:
    ///   ==== 自己紹介 ====
    ///   名前 : 田中太郎
    ///   年齢 : 25 歳
    ///   身長 : 170.5 cm
    ///   来年は 26 歳になります。
    /// </summary>
    public static void Mini_ProfileCard()
    {
        // TODO: 変数を用意し、$"..." の文字列補間で整形して表示

        string name = "田中太郎";
        int age = 25;
        double height = 170.5;
        int nextage = age + 1;

        Console.WriteLine($"名前：{name}");
        Console.WriteLine($"年齢：{age}");
        Console.WriteLine($"身長：{height}");
        Console.WriteLine($"来年は{nextage}歳になります");

    }
}
