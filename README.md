# グリッド矩形スナップ配置ツール

ワールド空間またはローカル空間に任意単位のグリッドを設定し、グリッドの四隅、中心、辺、セルに沿って3Dオブジェクトを配置するEditor拡張。1m、10cm、任意単位の目盛りを切り替え、3Dオブジェクトごとに矩形フットプリントを設定してグリッドと照合する。Mesh boundsから矩形を自動生成し、X/Y/Z軸ごとに位置合わせのON/OFFを切り替え、高さ方向のスナップも行う。

| 項目 | 内容 |
| --- | --- |
| Rank | 70 |
| Domain | UnityEditor |
| Idea No. | 8 |
| Repository | grid-rect-snap-placement-tool |
| 主な公開先 | GitHub Release / BOOTH |

## Implementation

- `src/product-profile.mjs`: プロダクト定義。
- `src/core.mjs`: 入力正規化とバッチ評価。
- `src/validators.mjs`: 必須項目と warning 項目の検査。
- `src/review-model.mjs`: UI/レビュー向けモデル。
- `src/report.mjs`: Markdown / HTML レポート生成。
- `src/cli.mjs`: CLI。

## Validation

`npm test` で代表シナリオ、QCDS、docs ZIP、文字化けを検証します。

## Strict QCDS Docs

- [Remote benchmark](docs/qcds-remote-benchmark.md)
- [Strict metrics](docs/qcds-strict-metrics.json)
- [Traceability matrix](docs/traceability-matrix.md)
- [Release evidence](docs/release-evidence.json)
