namespace DokushuPractice;

// ============================================================================
//  第6章 コレクション（List / Stack / Queue / HashSet / Dictionary）
// ============================================================================
public static class Exercises
{
    /// <summary>
    /// 【6.2.1 List】
    /// 空の List&lt;string&gt; を作り "りんご" "みかん" "ぶどう" を追加。
    /// "みかん" を削除し、残った要素数と中身を表示しなさい。
    /// 期待出力:
    ///   要素数: 2
    ///   りんご, ぶどう
    /// </summary>
    public static void Ex01_List()
    {
        // TODO: new List<string>() に Add → Remove("みかん") → Count と string.Join(", ", list)
        throw new NotImplementedException();
    }

    /// <summary>
    /// 【6.2.3 Stack（後入れ先出し）】
    /// Stack&lt;int&gt; に 1,2,3 を Push し、Pop で全部取り出して順に表示しなさい。
    /// 期待出力:
    ///   取り出し順: 3 2 1
    /// </summary>
    public static void Ex02_Stack()
    {
        // TODO: Push(1),Push(2),Push(3) → while(Count>0) で Pop して表示
        throw new NotImplementedException();
    }

    /// <summary>
    /// 【6.2.4 Queue（先入れ先出し）】
    /// Queue&lt;string&gt; に "A","B","C" を Enqueue し、Dequeue で全部取り出して表示しなさい。
    /// 期待出力:
    ///   取り出し順: A B C
    /// </summary>
    public static void Ex03_Queue()
    {
        // TODO: Enqueue → while(Count>0) で Dequeue して表示
        throw new NotImplementedException();
    }

    /// <summary>
    /// 【6.3 セット（HashSet）】
    /// 配列 {1,2,2,3,3,3,4} から重複を除いた要素数と中身を表示しなさい。
    /// 期待出力:
    ///   ユニーク数: 4
    ///   1, 2, 3, 4
    /// </summary>
    public static void Ex04_HashSet()
    {
        int[] data = { 1, 2, 2, 3, 3, 3, 4 };
        // TODO: new HashSet<int>(data) を作り Count と中身を表示
        throw new NotImplementedException();
    }

    /// <summary>
    /// 【6.4.1 Dictionary】
    /// 文章中の単語の出現回数を数えて表示しなさい。
    /// 入力: "apple banana apple cherry banana apple"
    /// 期待出力（順不同でよい）:
    ///   apple: 3
    ///   banana: 2
    ///   cherry: 1
    /// ヒント: ContainsKey でなければ 0 から、あれば +1。
    /// </summary>
    public static void Ex05_Dictionary()
    {
        string text = "apple banana apple cherry banana apple";
        // TODO: Split(' ') して Dictionary<string,int> で集計し、foreach で表示
        throw new NotImplementedException();
    }

    /// <summary>
    /// 【6.4.2 SortedDictionary】
    /// キーが自動で昇順に並ぶことを確認する。
    /// 3→"three", 1→"one", 2→"two" の順で追加し、foreach で表示しなさい。
    /// 期待出力:
    ///   1 => one
    ///   2 => two
    ///   3 => three
    /// </summary>
    public static void Ex06_SortedDictionary()
    {
        // TODO: SortedDictionary<int,string> に追加し foreach で kvp.Key/kvp.Value を表示
        throw new NotImplementedException();
    }

    /// <summary>
    /// 【ミニプロジェクト：簡易在庫管理】
    /// Dictionary&lt;string,int&gt; を商品名→在庫数として使う。
    ///   ・初期在庫: りんご=10, みかん=5
    ///   ・りんごを3個出荷（減らす）
    ///   ・バナナを8個入荷（新規追加）
    /// 最終的な全在庫を表示しなさい。
    /// 期待出力（順不同）:
    ///   りんご: 7
    ///   みかん: 5
    ///   バナナ: 8
    /// </summary>
    public static void Mini_Inventory()
    {
        // TODO: Dictionary を作り、出荷は -=、入荷は ContainsKey で分岐して加算、最後に全件表示
        throw new NotImplementedException();
    }
}
