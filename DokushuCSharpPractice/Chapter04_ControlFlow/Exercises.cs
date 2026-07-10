namespace DokushuPractice;

// ============================================================================
//  第4章 制御構文（条件分岐・繰り返し・ループ制御）
// ============================================================================
public static class Exercises
{
    /// <summary>
    /// 【4.1.2 if命令（多岐分岐）】
    /// 点数 score を成績に変換して表示しなさい。
    ///   90以上→A / 80以上→B / 70以上→C / 60以上→D / それ未満→F
    /// 期待出力（score=85 のとき）:
    ///   85点 → B
    /// </summary>
    public static void Ex01_IfElseIf()
    {
        int score = 85;
        // TODO: if / else if で成績を求めて表示
        string getResult;

        if (score >= 90) getResult = "A";
        else if (score >= 80) getResult = "B";
        else if (score >= 70) getResult = "C";
        else if (score >= 60) getResult = "D";
        else getResult = "F";

        Console.WriteLine($"{getResult}");



    }

    /// <summary>
    /// 【4.1.7 switch式】
    /// 曜日番号 day（0=日, 1=月, … 6=土）を switch 式で曜日名に変換して表示しなさい。
    /// 範囲外は "不明" とすること。
    /// 期待出力（day=3 のとき）:
    ///   3 は 水曜日
    /// </summary>
    public static void Ex02_SwitchExpression()
    {
        int day = 3;
        // TODO: var name = day switch { 0 => "日曜日", ... , _ => "不明" }; を使う
        var name = day switch
        {
            0 => "日曜日",
            1 => "月曜日",
            2 => "火曜日",
            3 => "水曜日",
            4 => "木曜日",
            5 => "金曜日",
            6 => "土曜日",
            _ => "不明"
        };
        Console.WriteLine($"{day}は{name}");
    }

    /// <summary>
    /// 【4.2.3 for命令】
    /// 1 から n までの合計を for ループで求めて表示しなさい。
    /// 期待出力（n=10 のとき）:
    ///   1〜10 の合計: 55
    /// </summary>
    public static void Ex03_ForSum()
    {
        int n = 10;
        // TODO: for ループで合計
       
    }

    /// <summary>
    /// 【4.2.4 foreach命令】
    /// 配列の中の「最大値」を foreach で求めて表示しなさい（Max は使わず自分で）。
    /// 期待出力:
    ///   最大値: 42
    /// </summary>
    public static void Ex04_ForeachMax()
    {
        int[] data = { 12, 7, 42, 3, 28 };
        // TODO: foreach で最大値を探す
        
    }

    /// <summary>
    /// 【4.3 ループの制御（break / continue）】
    /// 2 以上の整数 n が素数かどうかを判定して表示しなさい。
    /// 2 から n-1 まで割り切れる数があれば素数でない（break）。
    /// 期待出力（n=29 のとき）:
    ///   29 は素数: True
    /// </summary>
    public static void Ex05_PrimeCheck()
    {
        int n = 29;
        // TODO: ループで割り切れるか調べ、bool で判定して表示
       
    }

    /// <summary>
    /// 【4.3.3 ループのネスト】
    /// 二重ループで九九（1×1〜3×3 の一部）を表示しなさい。1〜3段だけ。
    /// 期待出力:
    ///   1x1=1 1x2=2 1x3=3
    ///   2x1=2 2x2=4 2x3=6
    ///   3x1=3 3x2=6 3x3=9
    /// ヒント: 内側ループは Console.Write、行末で Console.WriteLine()。
    /// </summary>
    public static void Ex06_NestedLoop()
    {
        // TODO: for を二重にして九九を表示（1〜3）
       
    }

    /// <summary>
    /// 【ミニプロジェクト：FizzBuzz】
    /// 1 から 20 まで表示。ただし
    ///   3の倍数 → Fizz / 5の倍数 → Buzz / 両方の倍数 → FizzBuzz
    /// 期待出力（先頭部分）:
    ///   1 2 Fizz 4 Buzz Fizz 7 ... 14 FizzBuzz ...
    /// </summary>
    public static void Mini_FizzBuzz()
    {
        // TODO: for + if/else if で判定。15の倍数の判定を最初に行うのがコツ
        
    }
}
