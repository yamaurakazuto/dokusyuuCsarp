namespace DokushuPractice;

// ============================================================================
//  第9章 オブジェクト指向構文（例外処理・列挙型・構造体・レコード・ジェネリックなど）
// ============================================================================
public static class Exercises
{
    /// <summary>
    /// 【9.2 例外処理（try/catch/finally）】
    /// "abc" を int.Parse しようとして発生する FormatException を catch し、
    /// finally で "処理終了" を必ず表示しなさい。
    /// 期待出力:
    ///   数値に変換できませんでした
    ///   処理終了
    /// </summary>
    public static void Ex01_TryCatch()
    {
        // TODO: try で int.Parse("abc")、catch (FormatException) でメッセージ、finally で "処理終了"
        throw new NotImplementedException();
    }

    /// <summary>
    /// 【9.2.6 例外クラスを拡張する（自作例外）】
    /// 下の ValidateAge を完成させなさい。年齢が負なら InvalidAgeException を throw する。
    /// 期待出力:
    ///   30 はOK
    ///   -5 は不正: 年齢が負の値です
    /// </summary>
    public static void Ex02_CustomException()
    {
        foreach (int age in new[] { 30, -5 })
        {
            try
            {
                ValidateAge(age);
                Console.WriteLine($"{age} はOK");
            }
            catch (InvalidAgeException ex)
            {
                Console.WriteLine($"{age} は不正: {ex.Message}");
            }
        }
    }

    /// <summary>
    /// 【9.3 列挙型】
    /// 下の SignalAction を完成させなさい（信号の色 → とるべき行動）。
    ///   Red→"止まれ" / Yellow→"注意" / Green→"進め"
    /// 期待出力:
    ///   Red → 止まれ
    ///   Green → 進め
    /// </summary>
    public static void Ex03_Enum()
    {
        Console.WriteLine($"Red → {SignalAction(Signal.Red)}");
        Console.WriteLine($"Green → {SignalAction(Signal.Green)}");
    }

    /// <summary>
    /// 【9.4 構造体】
    /// 下の Point 構造体の DistanceFromOrigin を完成させなさい（原点からの距離）。
    /// 期待出力:
    ///   (3,4) の原点からの距離: 5
    /// </summary>
    public static void Ex04_Struct()
    {
        var p = new Point { X = 3, Y = 4 };
        Console.WriteLine($"(3,4) の原点からの距離: {p.DistanceFromOrigin()}");
    }

    /// <summary>
    /// 【9.5 レコード型 / 9.5.2 with式】
    /// Product レコード（定義済み）を使う。
    ///   ・同じ内容の2つは == で等しいことを確認（値の等価性）
    ///   ・with 式で Price だけ変えたコピーを作る
    /// 期待出力:
    ///   等価判定: True
    ///   値引き後: Product { Name = ペン, Price = 80 }
    /// </summary>
    public static void Ex05_Record()
    {
        var a = new Product("ペン", 100);
        var b = new Product("ペン", 100);
        Console.WriteLine($"等価判定: {a == b}");
        // TODO: a を元に Price = 80 にした discounted を with 式で作り、表示する
        throw new NotImplementedException();
    }

    /// <summary>
    /// 【9.7.5 ジェネリックメソッド】
    /// 下の Max&lt;T&gt; を完成させなさい（2値の大きい方を返す。型制約 IComparable&lt;T&gt;）。
    /// 期待出力:
    ///   Max(3, 9) = 9
    ///   Max("apple","banana") = banana
    /// </summary>
    public static void Ex06_Generic()
    {
        Console.WriteLine($"Max(3, 9) = {Max(3, 9)}");
        Console.WriteLine($"Max(\"apple\",\"banana\") = {Max("apple", "banana")}");
    }

    /// <summary>
    /// 【9.9 演算子のオーバーロード】
    /// 下の Vector2 の + 演算子を完成させなさい。
    /// 期待出力:
    ///   (1,2) + (3,4) = (4,6)
    /// </summary>
    public static void Ex07_OperatorOverload()
    {
        var v = new Vector2(1, 2) + new Vector2(3, 4);
        Console.WriteLine($"(1,2) + (3,4) = ({v.X},{v.Y})");
    }

    /// <summary>
    /// 【ミニプロジェクト：電卓（列挙型＋例外）】
    /// 下の Calculate を完成させなさい。Operation 列挙で +,-,*,÷ を切り替える。
    /// 0 で割ろうとしたら DivideByZeroException を投げる（標準例外でOK）。
    /// 期待出力:
    ///   10 + 3 = 13
    ///   10 ÷ 0 → エラー: 0で割れません
    /// </summary>
    public static void Mini_Calculator()
    {
        Console.WriteLine($"10 + 3 = {Calculate(10, 3, Operation.Add)}");
        try
        {
            Calculate(10, 0, Operation.Divide);
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("10 ÷ 0 → エラー: 0で割れません");
        }
    }

    // ----- 実装するメソッド -----

    public static void ValidateAge(int age)
    {
        // TODO: age < 0 なら throw new InvalidAgeException("年齢が負の値です");
        throw new NotImplementedException();
    }

    public static string SignalAction(Signal signal)
    {
        // TODO: switch 式で色 → 行動 を返す
        throw new NotImplementedException();
    }

    public static T Max<T>(T a, T b) where T : IComparable<T>
    {
        // TODO: a.CompareTo(b) > 0 なら a、そうでなければ b
        throw new NotImplementedException();
    }

    public static double Calculate(double a, double b, Operation op)
    {
        // TODO: op に応じて四則演算。Divide かつ b==0 は DivideByZeroException を throw
        throw new NotImplementedException();
    }
}

// ===== Ex02: 自作例外（完成済み） =====
public class InvalidAgeException : Exception
{
    public InvalidAgeException(string message) : base(message) { }
}

// ===== Ex03 / Mini: 列挙型（完成済み） =====
public enum Signal { Red, Yellow, Green }
public enum Operation { Add, Subtract, Multiply, Divide }

// ===== Ex04: 構造体 =====
public struct Point
{
    public double X;
    public double Y;
    public double DistanceFromOrigin()
    {
        // TODO: Math.Sqrt(X*X + Y*Y)
        throw new NotImplementedException();
    }
}

// ===== Ex05: レコード（完成済み）=====
public record Product(string Name, decimal Price);

// ===== Ex07: 演算子オーバーロード =====
public struct Vector2
{
    public double X;
    public double Y;
    public Vector2(double x, double y) { X = x; Y = y; }

    public static Vector2 operator +(Vector2 a, Vector2 b)
    {
        // TODO: 各成分を足した新しい Vector2 を返す
        throw new NotImplementedException();
    }
}
