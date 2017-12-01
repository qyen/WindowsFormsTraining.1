# Windows Forms Traning #1 とりあえず作ってみる

ド定番のメモ帳アプリです。

## 手順


1. 新しいプロジェクトでWindowsフォームアプリケーションを選んで新規作成
1. ツールボックスから `メニューとツールバー>MenuStrip`をダブルクリック
1. ツールボクスから `コモンコントロール>TextBox`をダブルクリック
1. フォーム上のTextBoxを選んでプロパティから以下を設定
    - Multiline : True
    - Dock : Fill
1. MenuStripを選んで`ここへ入力`のところに `File`と記入
1. 5で作成したFile を選んでその下に出てきた`ここへ入力`に以下を追加
   - Open
   - Save
   - Close
1. 6で作成したメニューを1つ選んでプロパティから`ShortcutKeys`を以下に設定
   - Open : Ctrl+O
   - Save : Ctrl+S
1. ツールボクスから `ダイアログ>OpenFileDialog`をダブルクリック
1. 8で作成されたopenFileDialog1を選んでプロパティに以下を設定
    - Filter : Text Files (.txt)|*.txt|All Files (*.*)|*.*
1. ツールボクスから `ダイアログ>SaveFileDialog`をダブルクリック
1. 8で作成されたsaveFileDialog1を選んでプロパティに以下を設定
    - Filter : Text Files (.txt)|*.txt|All Files (*.*)|*.*
1. 6で作成したメニューのOpenをダブルクリック
1. ダブルクリックして開いたエディタの`openToolStripMenuItem_Click()`の内容に以下をコピペ

```C#
if (openFileDialog1.ShowDialog() == DialogResult.OK) {
    string selectedFilename = openFileDialog1.FileName;
    using (var sreader = new System.IO.StreamReader(selectedFilename)) {
        this.textBox1.Text = sreader.ReadToEnd();
    }
}
```

14. 6で作成したメニューのSaveをダブルクリック
1. ダブルクリックして開いたエディタの`saveToolStripMenuItem_Click()`の内容に以下をコピペ

```C#
if (saveFileDialog1.ShowDialog() == DialogResult.OK) {
    string selectedFilename = this.saveFileDialog1.FileName;
    using (var swriter = new System.IO.StreamWriter(selectedFilename)) {
        swriter.Write(this.textBox1.Text);
    }
}
```
16. 6で作成したメニューのCloseをダブルクリック
1. ダブルクリックして開いたエディタの`closeToolStripMenuItem_Click()`の内容に以下をコピペ
```C#
this.Close();
```

18. F5キーを押して実行

## ドリル

1. テキストボックスのフォントを見やすいフォントに変えよう
2. フォントをユーザーが変更できるようにしよう
   - ヒント:FontDialog
1. 名前をつけて保存と上書き保存機能を作ろう


## コード解説

ぐぐれ。
