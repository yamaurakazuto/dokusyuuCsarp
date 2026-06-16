// このファイルは編集不要です。
// 練習問題の本体は Exercises.cs にあります。そちらの TODO を実装してから実行してください。
//
// 実行方法（このフォルダで）:  dotnet run
using System.Reflection;
using DokushuPractice;

Console.OutputEncoding = System.Text.Encoding.UTF8;

var asmName = typeof(Exercises).Assembly.GetName().Name;
Console.WriteLine($"================ {asmName} 練習問題ランナー ================\n");

var methods = typeof(Exercises)
    .GetMethods(BindingFlags.Public | BindingFlags.Static)
    .Where(m => m.Name.StartsWith("Ex") || m.Name.StartsWith("Mini"))
    .OrderBy(m => m.Name, StringComparer.Ordinal)
    .ToArray();

if (methods.Length == 0)
{
    Console.WriteLine("Exercises に実行できる問題が見つかりませんでした。");
    return;
}

foreach (var m in methods)
{
    Console.WriteLine($"────────── {m.Name} ──────────");
    try
    {
        var result = m.Invoke(null, null);
        if (result is Task task)
            task.GetAwaiter().GetResult();   // 非同期メソッドの完了を待つ
    }
    catch (TargetInvocationException tie) when (tie.InnerException is NotImplementedException)
    {
        Console.WriteLine("🔲 未実装です。Exercises.cs の TODO を実装してください。");
    }
    catch (NotImplementedException)   // async メソッドが await 後に投げた場合
    {
        Console.WriteLine("🔲 未実装です。Exercises.cs の TODO を実装してください。");
    }
    catch (TargetInvocationException tie)
    {
        var ex = tie.InnerException!;
        Console.WriteLine($"⚠ 実行中に例外: {ex.GetType().Name}: {ex.Message}");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"⚠ 実行中に例外: {ex.GetType().Name}: {ex.Message}");
    }
    Console.WriteLine();
}

Console.WriteLine("================ 完了 ================");
