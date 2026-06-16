namespace DokushuPractice;

// ============================================================================
//  第10章 ラムダ式／LINQ
// ============================================================================
public static class Exercises
{
    /// <summary>
    /// 【10.1.1 デリゲート（Func / Action）】
    /// Func&lt;int,int,int&gt; add に「2数を足すラムダ」を、
    /// Action&lt;string&gt; shout に「大文字にして表示するラムダ」を代入して使いなさい。
    /// 期待出力:
    ///   add(3, 4) = 7
    ///   HELLO
    /// </summary>
    public static void Ex01_Delegate()
    {
        // TODO: Func<int,int,int> add = (a, b) => ...; と Action<string> shout = s => ...;
        // それぞれ呼び出して結果を表示する
        throw new NotImplementedException();
    }

    /// <summary>
    /// 【10.1 ラムダ式 + List のメソッド】
    /// List の FindAll / ForEach を使い、4文字以上の単語だけを表示しなさい。
    /// 期待出力:
    ///   apple
    ///   grape
    /// </summary>
    public static void Ex02_Lambda()
    {
        var words = new List<string> { "apple", "fig", "grape", "kiwi" };
        // TODO: words.FindAll(w => w.Length >= 4) を ForEach で表示
        throw new NotImplementedException();
    }

    /// <summary>
    /// 【10.2.2 where句（Where メソッド）】
    /// 1〜10 のうち偶数だけを LINQ で抽出し、スペース区切りで表示しなさい。
    /// 期待出力:
    ///   2 4 6 8 10
    /// </summary>
    public static void Ex03_Where()
    {
        var numbers = Enumerable.Range(1, 10);
        // TODO: numbers.Where(n => n % 2 == 0) を string.Join(" ", ...) で表示
        throw new NotImplementedException();
    }

    /// <summary>
    /// 【10.2.3 orderby / 10.2.4 select】
    /// 名前を「文字数の短い順」に並べ替え、"名前(文字数)" の形で表示しなさい。
    /// 期待出力:
    ///   Bob(3)
    ///   Anna(4)
    ///   Charlie(7)
    /// </summary>
    public static void Ex04_OrderBySelect()
    {
        var names = new[] { "Anna", "Bob", "Charlie" };
        // TODO: OrderBy(n => n.Length) → Select(n => $"{n}({n.Length})") を foreach で表示
        throw new NotImplementedException();
    }

    /// <summary>
    /// 【10.2.9 group句（GroupBy メソッド）】
    /// 商品をカテゴリ別にグループ化し、カテゴリ名と件数を表示しなさい。
    /// 期待出力（順不同）:
    ///   果物: 2件
    ///   野菜: 1件
    /// </summary>
    public static void Ex05_GroupBy()
    {
        var items = new[]
        {
            ("りんご", "果物"),
            ("バナナ", "果物"),
            ("にんじん", "野菜"),
        };
        // TODO: items.GroupBy(x => x.Item2) して g.Key と g.Count() を表示
        throw new NotImplementedException();
    }

    /// <summary>
    /// 【10.2 集計（Sum / Average / Max / Count）】
    /// 点数配列の 合計・平均・最高点・件数 を LINQ で求めて表示しなさい。
    /// 期待出力:
    ///   合計: 240 / 平均: 80 / 最高: 95 / 件数: 3
    /// </summary>
    public static void Ex06_Aggregate()
    {
        int[] scores = { 70, 75, 95 };
        // TODO: scores.Sum(), Average(), Max(), Count() を表示
        throw new NotImplementedException();
    }

    /// <summary>
    /// 【ミニプロジェクト：学生データの分析】
    /// 下の students から LINQ で次を求めて表示しなさい。
    ///   ・合格者(score >= 60)の名前一覧
    ///   ・全体の平均点
    ///   ・最高得点の学生の名前
    /// 期待出力:
    ///   合格者: 田中, 佐藤
    ///   平均点: 65
    ///   最高得点者: 佐藤
    /// </summary>
    public static void Mini_StudentAnalysis()
    {
        var students = new[]
        {
            new Student("田中", 80),
            new Student("鈴木", 40),
            new Student("佐藤", 75),
        };
        // TODO:
        //  1) Where(s => s.Score >= 60).Select(s => s.Name) → string.Join(", ", ...)
        //  2) Average(s => s.Score)
        //  3) OrderByDescending(s => s.Score).First().Name （または MaxBy）
        throw new NotImplementedException();
    }
}

public record Student(string Name, int Score);
