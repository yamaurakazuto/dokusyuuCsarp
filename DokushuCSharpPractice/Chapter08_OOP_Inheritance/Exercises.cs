namespace DokushuPractice;

// ============================================================================
//  第8章 オブジェクト指向構文（カプセル化・継承・ポリモーフィズム）
// ============================================================================
public static class Exercises
{
    /// <summary>
    /// 【8.1.1 アクセス修飾子 / 8.1.2 プロパティ】
    /// 下の Score クラスを完成させなさい。
    ///   Value プロパティは 0〜100 にクランプする（範囲外なら丸める）。
    /// 期待出力:
    ///   150を設定 → 100
    ///   -20を設定 → 0
    ///   77を設定 → 77
    /// </summary>
    public static void Ex01_Property()
    {
        var s = new Score();
        s.Value = 150; Console.WriteLine($"150を設定 → {s.Value}");
        s.Value = -20; Console.WriteLine($"-20を設定 → {s.Value}");
        s.Value = 77;  Console.WriteLine($"77を設定 → {s.Value}");
    }

    /// <summary>
    /// 【8.1.3 インデクサー】
    /// 下の Week クラスのインデクサーを完成させなさい（0=日曜 … 6=土曜）。
    /// 期待出力:
    ///   week[0] = 日
    ///   week[6] = 土
    /// </summary>
    public static void Ex02_Indexer()
    {
        var week = new Week();
        Console.WriteLine($"week[0] = {week[0]}");
        Console.WriteLine($"week[6] = {week[6]}");
    }

    /// <summary>
    /// 【8.2 継承 / 8.2.3 オーバーライド】
    /// 下の Dog と Cat の Speak() をオーバーライドして完成させなさい。
    /// 期待出力:
    ///   ポチ: ワン
    ///   タマ: ニャー
    ///   名無し: ...（基底クラスのまま）
    /// </summary>
    public static void Ex03_Inheritance()
    {
        Animal a = new Animal { Name = "名無し" };
        Animal dog = new Dog { Name = "ポチ" };
        Animal cat = new Cat { Name = "タマ" };
        Console.WriteLine($"{dog.Name}: {dog.Speak()}");
        Console.WriteLine($"{cat.Name}: {cat.Speak()}");
        Console.WriteLine($"{a.Name}: {a.Speak()}");
    }

    /// <summary>
    /// 【8.3.2 抽象メソッド】
    /// 下の Circle と RectShape の Area() を完成させなさい（Shape を継承）。
    /// 期待出力:
    ///   円(半径2)の面積: 12.566...（= π×4）
    ///   長方形(3×4)の面積: 12
    /// </summary>
    public static void Ex04_Abstract()
    {
        Shape circle = new Circle { Radius = 2 };
        Shape rect = new RectShape { Width = 3, Height = 4 };
        Console.WriteLine($"円(半径2)の面積: {circle.Area()}");
        Console.WriteLine($"長方形(3×4)の面積: {rect.Area()}");
    }

    /// <summary>
    /// 【8.3.3 インターフェイス】
    /// 下の IDiscountable を Member と Guest に実装しなさい。
    ///   Member は20%引き、Guest は割引なし。
    /// 期待出力:
    ///   会員価格: 800
    ///   ゲスト価格: 1000
    /// </summary>
    public static void Ex05_Interface()
    {
        IDiscountable member = new Member();
        IDiscountable guest = new Guest();
        Console.WriteLine($"会員価格: {member.ApplyDiscount(1000)}");
        Console.WriteLine($"ゲスト価格: {guest.ApplyDiscount(1000)}");
    }

    /// <summary>
    /// 【ミニプロジェクト：図形の面積を多態で集計】
    /// Shape のリスト（円・長方形・円）の面積を foreach で合計しなさい。
    /// 親クラス型のまま扱い、実体ごとに正しい Area() が呼ばれる（ポリモーフィズム）。
    /// 期待出力:
    ///   合計面積: 31.13...（= π×4 + 12 + π×1）
    /// </summary>
    public static void Mini_ShapeTotal()
    {
        var shapes = new List<Shape>
        {
            new Circle { Radius = 2 },
            new RectShape { Width = 3, Height = 4 },
            new Circle { Radius = 1 },
        };
        // TODO: foreach で各 shape.Area() を合計して表示
        throw new NotImplementedException();
    }
}

// ===== Ex01 =====
public class Score
{
    private int _value;
    public int Value
    {
        get => _value;
        set
        {
            // TODO: 0未満なら0、100超なら100、それ以外はそのまま代入
            throw new NotImplementedException();
        }
    }
}

// ===== Ex02 =====
public class Week
{
    private readonly string[] _days = { "日", "月", "火", "水", "木", "金", "土" };
    public string this[int index]
    {
        // TODO: _days[index] を返す
        get { throw new NotImplementedException(); }
    }
}

// ===== Ex03 =====
public class Animal
{
    public string Name = "";
    public virtual string Speak() => "...";
}

public class Dog : Animal
{
    // TODO: Speak() をオーバーライドして "ワン" を返す
}

public class Cat : Animal
{
    // TODO: Speak() をオーバーライドして "ニャー" を返す
}

// ===== Ex04 / Mini =====
public abstract class Shape
{
    public abstract double Area();
}

public class Circle : Shape
{
    public double Radius;
    public override double Area()
    {
        // TODO: π × 半径²（Math.PI を使う）
        throw new NotImplementedException();
    }
}

public class RectShape : Shape
{
    public double Width;
    public double Height;
    public override double Area()
    {
        // TODO: 幅 × 高さ
        throw new NotImplementedException();
    }
}

// ===== Ex05 =====
public interface IDiscountable
{
    decimal ApplyDiscount(decimal price);
}

// ※「: IDiscountable」がインターフェイスの実装宣言。メソッドの中身が TODO。
public class Member : IDiscountable
{
    public decimal ApplyDiscount(decimal price)
    {
        // TODO: 20%引き（price * 0.8m）を返す
        throw new NotImplementedException();
    }
}

public class Guest : IDiscountable
{
    public decimal ApplyDiscount(decimal price)
    {
        // TODO: 割引なし（price そのまま）を返す
        throw new NotImplementedException();
    }
}
