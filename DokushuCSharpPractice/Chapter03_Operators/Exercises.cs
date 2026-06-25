namespace DokushuPractice;

// ============================================================================
//  第3章 演算子
//  各メソッドの throw を消して TODO を実装 → `dotnet run`
// ============================================================================
public static class Exercises
{
    /// <summary>
    /// 【3.1.4 除算とデータ型】
    /// 7 ÷ 2 を「整数の割り算」と「小数の割り算」の両方で計算し、違いを表示しなさい。
    /// さらに 7 % 2（剰余）も表示しなさい。
    /// 期待出力:
    ///   7 / 2 (整数) = 3
    ///   7 / 2 (小数) = 3.5
    ///   7 % 2 = 1
    /// </summary>
    public static void Ex01_Division()
    {
        // TODO: 整数同士の除算、7.0/2 などの小数除算、剰余 % を表示
        int n1 = 7;
        int n2 = 2;

        Console.WriteLine(n1 / n2);
        Console.WriteLine((double)n1 / n2);
        Console.WriteLine(n1 % n2);
    }

    /// <summary>
    /// 【3.1.3 インクリメント／デクリメント演算子】
    /// 前置(++a)と後置(a++)で結果がどう違うかを表示しなさい。
    /// 期待出力:
    ///   後置: b = 5, その後 a = 6
    ///   前置: c = 7, その後 a = 7
    /// </summary>
    public static void Ex02_IncrementDecrement()
    {
        int a = 5;
        // TODO: int b = a++;（後置）→ b と a を表示。続けて int c = ++a;（前置）→ c と a を表示
        int b = a++;
        Console.WriteLine(b + " " + a);

        int c = ++a;
        
        Console.WriteLine(c + " " + a);
    }

    /// <summary>
    /// 【3.3.4 条件演算子 (?:)】
    /// 整数 n が偶数なら "偶数"、奇数なら "奇数" を、三項演算子で判定して表示しなさい。
    /// 期待出力（n=8 のとき）:
    ///   8 は 偶数
    /// </summary>
    public static void Ex03_Ternary()
    {
        int n = 8;
        // TODO: n % 2 == 0 ? "偶数" : "奇数" を使って表示
        Console.WriteLine(n % 2 == 0 ? "偶数" :"奇数");
    }

    /// <summary>
    /// 【3.3.5 null合体演算子】
    /// int? score = null のとき、?? で「点数が無ければ 0 点とみなす」処理を書き表示しなさい。
    /// 期待出力:
    ///   今回の点数: 0
    /// </summary>
    public static void Ex04_NullCoalescing()
    {
        int? score = null;
        // TODO: score ?? 0 を表示
        Console.WriteLine($"今回の点数: {score ?? 0}");
    }

    /// <summary>
    /// 【3.4 論理演算子 / 3.4.1 ショートカット演算】
    /// 年齢 age が 18 以上 かつ 65 未満 のとき「現役世代」、それ以外は「対象外」と表示しなさい。
    /// && と論理式を使うこと。
    /// 期待出力（age=30 のとき）:
    ///   30歳 → 現役世代
    /// </summary>
    public static void Ex05_LogicalOperator()
    {
        int age = 30;
        // TODO: (age >= 18 && age < 65) の真偽で表示を切り替える（三項演算子でよい）
        throw new NotImplementedException();
    }

    /// <summary>
    /// 【3.5 ビット演算子】
    /// 権限フラグをビットで管理する。Read=1, Write=2, Execute=4 とする。
    /// 「Read と Execute」の権限を | で合成し、その値と、Write 権限を持つか（&）を表示しなさい。
    /// 期待出力:
    ///   合成フラグの値: 5
    ///   Write を持つ？: False
    ///   Read を持つ？: True
    /// </summary>
    public static void Ex06_BitOperator()
    {
        const int Read = 1, Write = 2, Execute = 4;
        // TODO: int perm = Read | Execute; 値を表示。 (perm & Write) != 0 などで判定
        throw new NotImplementedException();
    }

    /// <summary>
    /// 【ミニプロジェクト：BMI 計算機】
    /// 身長(m)と体重(kg)から BMI = 体重 / (身長*身長) を計算（小数）。
    /// 三項演算子で 18.5 未満なら "低体重"、25 未満なら "標準"、それ以上は "肥満" と判定し表示。
    /// 期待出力（身長1.70m, 体重65kg のとき。BMIは小数第1位まで）:
    ///   BMI: 22.5 → 標準
    /// ヒント: Math.Round(値, 1) で小数第1位に丸められます。
    /// </summary>
    public static void Mini_BmiCalculator()
    {
        double heightM = 1.70;
        double weightKg = 65;
        // TODO: BMI を計算し Math.Round で丸め、ネストした三項演算子で区分を判定して表示
        throw new NotImplementedException();
    }
}
