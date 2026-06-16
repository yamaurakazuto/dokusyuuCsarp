using System.Reflection;   // Ex03 のリフレクションで使用

namespace DokushuPractice;

// ============================================================================
//  第11章 高度なプログラミング（マルチスレッド/非同期・属性・dynamic・イベント）
// ============================================================================
public static class Exercises
{
    /// <summary>
    /// 【11.1.2 タスクの生成 / 11.1.4 async・await】
    /// 0.1秒待ってから 1〜100 の合計を返す非同期メソッドを await して結果を表示しなさい。
    /// 期待出力:
    ///   計算中...
    ///   合計: 5050
    /// </summary>
    public static async Task Ex01_AsyncAwait()
    {
        Console.WriteLine("計算中...");
        // TODO: await Task.Delay(100); の後、1〜100 の合計を計算して表示
        await Task.Delay(0);            // この行は仮。実装時に書き換えてよい
        throw new NotImplementedException();
    }

    /// <summary>
    /// 【11.1.2 複数タスクの待機（Task.WhenAll）】
    /// 3つの非同期タスク（それぞれ与えた数を2倍して返す）を同時に走らせ、
    /// すべて完了したら結果を表示しなさい。
    /// 期待出力:
    ///   結果: 2 4 6
    /// </summary>
    public static async Task Ex02_WhenAll()
    {
        async Task<int> DoubleAsync(int n)
        {
            await Task.Delay(50);
            return n * 2;
        }
        // TODO: DoubleAsync(1),(2),(3) を Task.WhenAll で待ち、結果配列を string.Join で表示
        await Task.Delay(0);
        throw new NotImplementedException();
    }

    /// <summary>
    /// 【11.2 属性 / 11.2.4 属性の自作 / 11.2.5 リフレクション】
    /// 下の SampleData クラスに付いた [Author] 属性を、リフレクションで読み取って表示しなさい。
    /// 期待出力:
    ///   作者: 山田太郎
    /// ヒント: typeof(SampleData).GetCustomAttribute&lt;AuthorAttribute&gt;()
    /// </summary>
    public static void Ex03_Attribute()
    {
        // TODO: System.Reflection を使い SampleData の AuthorAttribute を取得して Name を表示
        throw new NotImplementedException();
    }

    /// <summary>
    /// 【11.3 動的型付け変数（dynamic）】
    /// dynamic 変数に「文字列」と「数値」を順に入れ、それぞれで使える操作が変わることを示しなさい。
    /// 期待出力:
    ///   文字列の長さ: 5
    ///   数値の2倍: 84
    /// </summary>
    public static void Ex04_Dynamic()
    {
        // TODO: dynamic x = "hello"; → x.Length を表示。 x = 42; → x * 2 を表示
        throw new NotImplementedException();
    }

    /// <summary>
    /// 【11.4 イベント】
    /// 下の Button クラスの Clicked イベントを発火できるよう OnClick を完成させなさい。
    /// 期待出力:
    ///   ボタンが押されました！
    ///   ログ: クリックを記録
    /// </summary>
    public static void Ex05_Event()
    {
        var button = new Button();
        button.Clicked += () => Console.WriteLine("ボタンが押されました！");
        button.Clicked += () => Console.WriteLine("ログ: クリックを記録");
        button.OnClick();   // ここで2つの購読者が呼ばれるようにする
    }

    /// <summary>
    /// 【ミニプロジェクト：非同期ダウンロードのシミュレーション】
    /// 3つのファイル名を渡し、それぞれ非同期で「ダウンロード」（少し待つ）して、
    /// 完了したものから "○○ 完了" を表示。最後に全件完了メッセージを出しなさい。
    /// 期待出力（順不同・完了は前後する場合あり）:
    ///   a.txt 完了
    ///   b.txt 完了
    ///   c.txt 完了
    ///   すべてのダウンロードが完了しました
    /// </summary>
    public static async Task Mini_AsyncDownload()
    {
        string[] files = { "a.txt", "b.txt", "c.txt" };

        async Task DownloadAsync(string name)
        {
            await Task.Delay(50);
            Console.WriteLine($"{name} 完了");
        }
        // TODO: files を Select(f => DownloadAsync(f)) して Task.WhenAll で待つ
        //       最後に "すべてのダウンロードが完了しました" を表示
        await Task.Delay(0);
        throw new NotImplementedException();
    }
}

// ===== Ex03: 自作属性とそれを付けたクラス（完成済み） =====
[AttributeUsage(AttributeTargets.Class)]
public class AuthorAttribute : Attribute
{
    public string Name { get; }
    public AuthorAttribute(string name) => Name = name;
}

[Author("山田太郎")]
public class SampleData
{
}

// ===== Ex05: イベントを持つクラス =====
public class Button
{
    // 引数なし・戻り値なしのイベント
    public event Action? Clicked;

    public void OnClick()
    {
        // TODO: Clicked を発火する（購読者がいないこともあるので ?.Invoke() を使う）
        throw new NotImplementedException();
    }
}
