namespace DokushuPractice;

// ============================================================================
//  第7章 オブジェクト指向構文（基本）
//   クラスの定義・フィールド・メソッド・コンストラクター・static・引数の記法
//
//  ※ この章は「クラスを完成させる」問題が中心です。
//    Exercises のメソッドは完成済みのことが多く、下の各クラスの TODO を実装します。
// ============================================================================
public static class Exercises
{
    /// <summary>
    /// 【7.1〜7.3 クラス・フィールド・メソッド】
    /// 下の Rectangle クラスを完成させなさい（Width, Height フィールドと Area メソッド）。
    /// 期待出力:
    ///   幅4 × 高さ5 の面積: 20
    /// </summary>
    public static void Ex01_ClassBasics()
    {
        var rect = new Rectangle { Width = 4, Height = 5 };
        Console.WriteLine($"幅{rect.Width} × 高さ{rect.Height} の面積: {rect.Area()}");
    }

    /// <summary>
    /// 【7.4 コンストラクター（オーバーロード）】
    /// 下の Person クラスのコンストラクターを完成させなさい。
    ///   ・名前だけ受け取る版（年齢は -1 = 不明 とする）
    ///   ・名前と年齢を受け取る版
    /// 期待出力:
    ///   山田 (年齢: 不明)
    ///   鈴木 (年齢: 20)
    /// </summary>
    public static void Ex02_Constructor()
    {
        var p1 = new Person("山田");
        var p2 = new Person("鈴木", 20);
        Console.WriteLine(p1.Describe());
        Console.WriteLine(p2.Describe());
    }

    /// <summary>
    /// 【7.5 クラスフィールド／クラスメソッド（static）】
    /// 下の Counter クラスを完成させなさい（static フィールドで生成数を数える）。
    /// 期待出力:
    ///   生成された Counter の数: 3
    /// </summary>
    public static void Ex03_Static()
    {
        Counter.Reset();
        var a = new Counter();
        var b = new Counter();
        var c = new Counter();
        Console.WriteLine($"生成された Counter の数: {Counter.Count}");
    }

    /// <summary>
    /// 【7.6.1 引数の既定値 / 7.6.2 名前付き引数】
    /// 下の Greet メソッドを完成させなさい（greeting の既定値は "こんにちは"）。
    /// 期待出力:
    ///   こんにちは、太郎さん
    ///   おはよう、花子さん
    /// </summary>
    public static void Ex04_DefaultArgs()
    {
        Console.WriteLine(Greet("太郎"));
        Console.WriteLine(Greet("花子", greeting: "おはよう"));
    }

    /// <summary>
    /// 【7.6.4 値渡しと参照渡し（ref） / 7.6.6 出力引数（out）】
    /// 下の Swap(ref) と TryHalf(out) を完成させなさい。
    ///   TryHalf: 偶数なら半分を out で返して true、奇数なら false。
    /// 期待出力:
    ///   swap後: x=20, y=10
    ///   10の半分: True, 5
    ///   7の半分: False, 0
    /// </summary>
    public static void Ex05_RefOut()
    {
        int x = 10, y = 20;
        Swap(ref x, ref y);
        Console.WriteLine($"swap後: x={x}, y={y}");

        bool ok1 = TryHalf(10, out int h1);
        bool ok2 = TryHalf(7, out int h2);
        Console.WriteLine($"10の半分: {ok1}, {h1}");
        Console.WriteLine($"7の半分: {ok2}, {h2}");
    }

    /// <summary>
    /// 【7.6.7 タプル】
    /// 下の MinMax を完成させなさい（配列の最小値と最大値をタプルで返す）。
    /// 期待出力:
    ///   最小=3, 最大=42
    /// </summary>
    public static void Ex06_Tuple()
    {
        int[] data = { 12, 3, 42, 7 };
        var (min, max) = MinMax(data);
        Console.WriteLine($"最小={min}, 最大={max}");
    }

    /// <summary>
    /// 【ミニプロジェクト：銀行口座】
    /// 下の BankAccount クラスを完成させなさい（Deposit / Withdraw / Balance）。
    /// 残高不足の引き出しは無視する（残高は変えず "残高不足" と表示）。
    /// 期待出力:
    ///   入金後の残高: 1000
    ///   出金後の残高: 700
    ///   残高不足
    ///   最終残高: 700
    /// </summary>
    public static void Mini_BankAccount()
    {
        var acc = new BankAccount();
        acc.Deposit(1000);
        Console.WriteLine($"入金後の残高: {acc.Balance}");
        acc.Withdraw(300);
        Console.WriteLine($"出金後の残高: {acc.Balance}");
        acc.Withdraw(99999);   // 残高不足
        Console.WriteLine($"最終残高: {acc.Balance}");
    }

    // ----- Ex04 / Ex05 / Ex06 用のメソッド（ここを実装） -----

    public static string Greet(string name, string greeting = "こんにちは")
    {
        // TODO: $"{greeting}、{name}さん" を返す（既定値は引数側で設定済み）
        throw new NotImplementedException();
    }

    public static void Swap(ref int a, ref int b)
    {
        // TODO: a と b を入れ替える
        throw new NotImplementedException();
    }

    public static bool TryHalf(int value, out int half)
    {
        // TODO: 偶数なら half に value/2 を入れて true、奇数なら half=0 で false
        throw new NotImplementedException();
    }

    public static (int min, int max) MinMax(int[] data)
    {
        // TODO: 最小値と最大値を求めて (min, max) を返す
        throw new NotImplementedException();
    }
}

// ===== Ex01: 完成させるクラス =====
public class Rectangle
{
    public int Width;
    public int Height;

    public int Area()
    {
        // TODO: 面積（Width * Height）を返す
        throw new NotImplementedException();
    }
}

// ===== Ex02: 完成させるクラス =====
public class Person
{
    public string Name;
    public int Age;

    // TODO: 名前だけのコンストラクター（Age = -1）
    // TODO: 名前と年齢のコンストラクター
    public Person(string name)
    {
        throw new NotImplementedException();
    }

    public Person(string name, int age)
    {
        throw new NotImplementedException();
    }

    public string Describe()
    {
        string ageText = Age < 0 ? "不明" : Age.ToString();
        return $"{Name} (年齢: {ageText})";
    }
}

// ===== Ex03: 完成させるクラス =====
public class Counter
{
    // TODO: static のフィールド count を用意し、コンストラクターで +1 する
    public static int Count
    {
        get { throw new NotImplementedException(); }
    }

    public Counter()
    {
        // TODO: 生成のたびに static のカウントを増やす
        throw new NotImplementedException();
    }

    public static void Reset()
    {
        // TODO: カウントを 0 に戻す（テスト用）
        throw new NotImplementedException();
    }
}

// ===== Mini: 完成させるクラス =====
public class BankAccount
{
    // TODO: 残高フィールドと Balance プロパティ
    public int Balance
    {
        get { throw new NotImplementedException(); }
    }

    public void Deposit(int amount)
    {
        // TODO: 残高に加算
        throw new NotImplementedException();
    }

    public void Withdraw(int amount)
    {
        // TODO: 残高が足りれば減算、足りなければ "残高不足" と表示
        throw new NotImplementedException();
    }
}
