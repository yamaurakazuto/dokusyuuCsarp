# 独習C# 第5版 練習プロジェクト（第2章〜第11章）

『独習C# 第5版』の各章の内容を、**手を動かしながら**身につけるための学習用プロジェクトです。
章ごとに独立したコンソールアプリになっていて、`Exercises.cs` の中の TODO を自分で埋めていく形式です。

## 必要なもの

- .NET 8 SDK（`dotnet --version` で 8.x が表示されればOK）
- 任意のエディタ（Visual Studio / VS Code / Rider など）

## フォルダ構成

```
DokushuCSharpPractice/
├─ DokushuCSharpPractice.sln      ← まとめて開くためのソリューション
├─ Chapter02_Basics/             ← 第2章
│   ├─ Exercises.cs               ← ★あなたが編集するファイル（TODOを埋める）
│   ├─ 解答.md                    ← 模範解答（詰まったら見る）
│   ├─ Program.cs                 ← 実行用ランナー（編集不要）
│   └─ Chapter02_Basics.csproj
├─ Chapter03_Operators/           ← 第3章
│   …
└─ Chapter11_Advanced/            ← 第11章
```

各章は **`Exercises.cs`** に練習問題（`Ex01`〜）と、その章の総まとめになる小さなミニ課題（`Mini`〜）が入っています。

## 使い方

1. 取り組みたい章のフォルダに移動する
2. `Exercises.cs` を開き、`// TODO:` のコメントに従ってコードを書く
3. その章のフォルダで実行する

```bash
cd Chapter02_Basics
dotnet run
```

- まだ実装していない問題は **`🔲 未実装`** と表示されます
- 実装した問題は、その問題の出力が表示されます（各問題に「期待出力」をコメントで書いてあります）
- 詰まったら同じフォルダの **`解答.md`** を見てください

Visual Studio で使う場合は `DokushuCSharpPractice.sln` を開き、取り組む章のプロジェクトを右クリック →「スタートアッププロジェクトに設定」してから実行してください。

## 進め方のおすすめ

本を 1 セクション読む → 対応する `Ex` を解く → `dotnet run` で答え合わせ → `解答.md` と見比べる、を繰り返すのが効率的です。
章の最後の `Mini` は、その章で学んだことを組み合わせて作る小さなプログラムです。

## 章と本の対応

| フォルダ | 章 | テーマ | 主な内容 |
|---|---|---|---|
| Chapter02_Basics | 第2章 | C#の基本 | 変数・定数・データ型・型変換・配列・null許容参照型 |
| Chapter03_Operators | 第3章 | 演算子 | 算術・代入・関係・論理・ビット演算子 |
| Chapter04_ControlFlow | 第4章 | 制御構文 | if / switch式 / for / foreach / break・continue |
| Chapter05_StandardLibrary | 第5章 | 標準ライブラリ | 文字列操作・正規表現・日付時刻・Math・Random |
| Chapter06_Collections | 第6章 | コレクション | List / Stack / Queue / HashSet / Dictionary |
| Chapter07_OOP_Basics | 第7章 | オブジェクト指向（基本） | クラス・フィールド・メソッド・コンストラクター・static・引数の記法 |
| Chapter08_OOP_Inheritance | 第8章 | OOP（カプセル化/継承/ポリモーフィズム） | プロパティ・インデクサー・継承・抽象クラス・インターフェイス |
| Chapter09_OOP_Advanced | 第9章 | OOP（例外/ジェネリックなど） | 例外処理・列挙型・構造体・レコード型・ジェネリック・演算子オーバーロード |
| Chapter10_Lambda_LINQ | 第10章 | ラムダ式 / LINQ | デリゲート・ラムダ式・Where / OrderBy / Select / GroupBy |
| Chapter11_Advanced | 第11章 | 高度なプログラミング | async / await・Task.WhenAll・属性とリフレクション・dynamic・イベント |

## メモ

このプロジェクトのコードは生成時にローカルでビルド確認をしていないため、ごく一部に細かな修正が必要になる可能性があります。
その場合はエラーメッセージを手がかりに直してみると、それ自体が良い練習になります。
