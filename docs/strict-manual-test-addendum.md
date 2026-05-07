# Strict Manual Test Addendum

Codex側では手動テスト未実施です。

## 作業ディレクトリ

`D:/AI/UnityEditor/grid-rect-snap-placement-tool`

## 必要ファイル

- `dist/grid-rect-snap-placement-tool-docs.zip`
- `docs/manual-test.md`
- `docs/strict-manual-test-addendum.md`
- `samples/representative-suite.json`

## セットアップ手順

```powershell
cd D:/AI/UnityEditor/grid-rect-snap-placement-tool
npm test
npm start
```

## ローカルサーバーやホストアプリ起動手順

Unity 2022.3 LTS 以降で空プロジェクトを作成し、将来の Unity package を取り込む想定。現 closed alpha は CLI validation core を自動検証する。

## 実施手順

1. 自動テスト結果を確認。
2. 代表シナリオを目視確認。
3. 公開先 GitHub Release / BOOTH の想定に合うか確認。
4. GitHub prerelease assets 3件を確認。

## 期待結果

error / warning / passed と docs ZIP / release evidence の関係が説明できる。

## 未実施の手動確認項目

- 実データでの使いやすさ。
- 公開先別の審査/販売ページ文言。
- S+ 昇格判断。
