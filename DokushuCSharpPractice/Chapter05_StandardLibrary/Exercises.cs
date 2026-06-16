using System.Text.RegularExpressions;

namespace DokushuPractice;

// ============================================================================
//  第5章 標準ライブラリ（文字列・正規表現・日付/時刻・Math・Random）
// ============================================================================
public static class Exercises
{
    /// <summary>
    /// 【5.1 文字列の操作】
    /// 文字列 "  Hello, C# World  " に対して次を行い、それぞれ表示しなさい。
    ///   ・前後の空白を除去（Trim）
    ///   ・すべて大文字（ToUpper）
    ///   ・"C#" を含むか（Contains）
    /// 期待出力:
    ///   Trim: 'Hello, C# World'
    ///   Upper: HELLO, C# WORLD
    ///   C#を含む: True
    /// </summary>
    public static void Ex01_StringBasics()
    {
        string s = "  Hello, C# World  ";
        // TODO: Trim() / ToUpper() / Contains("C#") を使って表示
        throw new NotImplementedException();
    }

    /// <summary>
    /// 【5.1.7 文字列を分割する / 5.1.8 整形】
    /// "apple,banana,cherry" をカンマで分割し、要素数と、各要素を「番号付き」で表示しなさい。
    /// 期待出力:
    ///   要素数: 3
    ///   1: apple
    ///   2: banana
    ///   3: cherry
    /// </summary>
    public static void Ex02_SplitAndFormat()
    {
        string csv = "apple,banana,cherry";
        // TODO: Split(',') して Length と、index+1 付きで各要素を表示
        throw new NotImplementedException();
    }

    /// <summary>
    /// 【5.2 正規表現】
    /// 文字列がメールアドレスっぽい形式か正規表現で判定しなさい。
    /// パターン例: ^[\w.]+@[\w.]+\.\w+$
    /// 期待出力:
    ///   taro@example.com → True
    ///   not-an-email     → False
    /// </summary>
    public static void Ex03_Regex()
    {
        string ok = "taro@example.com";
        string ng = "not-an-email";
        // TODO: Regex.IsMatch(対象, @"^[\w.]+@[\w.]+\.\w+$") で判定して表示
        throw new NotImplementedException();
    }

    /// <summary>
    /// 【5.3 日付／時刻】
    /// 2025/1/1 と 2025/12/31 の「日数の差」を求めて表示しなさい。
    /// 期待出力:
    ///   日数の差: 364 日
    /// ヒント: new DateTime(年,月,日)、引き算の結果は TimeSpan、その .Days。
    /// </summary>
    public static void Ex04_DateTime()
    {
        // TODO: 2つの DateTime を作り、差(TimeSpan)の Days を表示
        throw new NotImplementedException();
    }

    /// <summary>
    /// 【5.5.1 Math クラス】
    /// 点(0,0)と点(3,4)の距離を求めて表示しなさい（三平方の定理 + Math.Sqrt）。
    /// 期待出力:
    ///   距離: 5
    /// </summary>
    public static void Ex05_Math()
    {
        double x1 = 0, y1 = 0, x2 = 3, y2 = 4;
        // TODO: Math.Sqrt(Math.Pow(...) + Math.Pow(...)) で距離を求める
        throw new NotImplementedException();
    }

    /// <summary>
    /// 【5.5.2 Random クラス】
    /// 1〜6 のサイコロを 5 回振った結果を表示しなさい（毎回変わる）。
    /// 期待出力（例）:
    ///   サイコロ: 4 2 6 1 3
    /// ヒント: var rnd = new Random(); rnd.Next(1, 7) は 1〜6。
    /// </summary>
    public static void Ex06_Random()
    {
        // TODO: Random で 1〜6 を 5 回生成して表示
        throw new NotImplementedException();
    }

    /// <summary>
    /// 【ミニプロジェクト：パスワード強度チェッカー】
    /// パスワード文字列について次を満たすか正規表現で判定し、すべて満たせば「強い」と表示。
    ///   ・8文字以上    ・英大文字を含む    ・数字を含む
    /// 期待出力（password = "Hello123" のとき）:
    ///   8文字以上: True
    ///   大文字あり: True
    ///   数字あり: True
    ///   → 強いパスワードです
    /// </summary>
    public static void Mini_PasswordChecker()
    {
        string password = "Hello123";
        // TODO: password.Length >= 8、Regex.IsMatch(password, "[A-Z]")、"[0-9]" を判定
        throw new NotImplementedException();
    }
}
