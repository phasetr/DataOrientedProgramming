# Data Oriented Programming

- Original Work: [Data-Oriented Programming Reduce software complexity](https://www.manning.com/books/data-oriented-programming)
  - GitHub, [viebel/data-oriented-programming](https://github.com/viebel/data-oriented-programming)
  - Book in Japanese [データ指向プログラミング【PDF版】](https://www.seshop.com/product/detail/25689)
- Nuget: [lodash](https://www.nuget.org/packages/lodash)
- [Json Schema GitHub](https://github.com/gregsdennis/json-everything)
    - [Json Schema](https://json-everything.net/json-schema/) 

## Appendix1, Principles

### 原則`#1`：コードをデータから切り離す

- 主な利点
  - コードをさまざまなコンテキストで再利用できる
  - コードを単体でテストできる
  - システムがそれほど複雑にならない傾向にある
- 主なコスト
  - どのコードがどのデータにアクセスするのかを制御できない
  - パッケージ化がない
  - エンティティの数が増える

### 原則`#2`：データを汎用的なデータ構造で表す

- 主な利点
  - 特定のユースケースに限定されないジェネリック関数を利用できる
  - 柔軟なデータモデル
- 主なコスト
  - パフォーマンスが少し低下する
  - データスキーマがない
  - コンパイル時にデータの有効性が確認されない
  - 静的に型付けされる言語では、明示的な型変換(キャスト)が必要になることがある

### 原則`#3`：データはイミュータブルである

- 主な利点
  - すべての関数から自信を持ってデータにアクセスできる
  - コードの振る舞いが予測可能である
  - 等価のチェックが高速である
  - 並並行処理の安全性が自動的に確保される
- 主なコスト
  - パフォーマンスが低下する
  - 永続的なデータ構造のためのライブラリが必要である

### 原則`#4`：データスキーマをデータ表現から切り離す

- nuget: [JsonSchema.NET](https://www.nuget.org/packages/JsonSchema.Net)
  - ドキュメントサイト：[json-everything](https://json-everything.net/)
- 参考：[Schema to Instance page](https://json-everything.net/json-schema/)
- 主な利点
  - 検証すべきデータを自由に選択できる
  - オプションフィールドを利用できる
  - 高度なデータ検証条件を利用できる
  - データモデルを自動的に可視化できる
- 主なコスト
  - データとスキーマの結び付きが弱い
  - パフォーマンスが少し低下する
