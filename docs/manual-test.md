# 手動テスト

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

1. README と対象 Rank を確認。
2. 代表シナリオ4件を確認。
3. 生成 report を開く。
4. GitHub prerelease assets 3件を確認。

## 期待結果

error / warning / passed の意味が明確で、手順どおり再現できる。

## 未実施の手動確認項目

- 実ホストまたは実ブラウザでの継続利用確認。
- 公開先での表示確認。
- ユーザーによる S+ 昇格判断。
