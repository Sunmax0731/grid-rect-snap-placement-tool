using UnityEditor;
using UnityEngine;

namespace Sunmax0731.GridRectSnapPlacementTool
{
    public sealed class GridRectSnapPlacementToolWindow : EditorWindow
    {
        [MenuItem("Tools/Sunmax0731/grid-rect-snap-placement-tool")]
        public static void Open() => GetWindow<GridRectSnapPlacementToolWindow>("grid-rect-snap-placement-tool");

        private void OnGUI()
        {
            GUILayout.Label("グリッド矩形スナップ配置ツール", EditorStyles.boldLabel);
            GUILayout.Label("Closed alpha editor package is importable.");
        }
    }
}
