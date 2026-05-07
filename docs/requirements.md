# 要件定義

| 項目 | 内容 |
| --- | --- |
| Rank | 70 |
| Domain | UnityEditor |
| Idea No. | 8 |
| Repository | grid-rect-snap-placement-tool |
| 主な公開先 | GitHub Release / BOOTH |

## 背景

建物、家具、床、壁、モジュール素材をScene上に配置する時、Meshの大きさ、基準点、高さ、ローカル回転、グリッド単位がずれて、手作業の微調整が増えやすい。

## 目的

ワールド空間またはローカル空間に任意単位のグリッドを設定し、グリッドの四隅、中心、辺、セルに沿って3Dオブジェクトを配置するEditor拡張。1m、10cm、任意単位の目盛りを切り替え、3Dオブジェクトごとに矩形フットプリントを設定してグリッドと照合する。Mesh boundsから矩形を自動生成し、X/Y/Z軸ごとに位置合わせのON/OFFを切り替え、高さ方向のスナップも行う。

## 必須要件

- grid placement rule を複数件まとめて検証できる。
- required fields: `id`, `title`, `gridSize`, `rectSize`, `snapRule`, `owner`。
- warning field: `collisionPolicy`。
- 代表シナリオ、QCDS metrics、docs ZIP、release evidence を再生成できる。
