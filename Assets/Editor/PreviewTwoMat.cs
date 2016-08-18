using UnityEngine;
using System.Collections;
using UnityEditor;

public class PreviewTwoMat : EditorWindow {
	public Material mat1;
	public Material mat2;
	Editor gameObjectEditor;
	Editor gameObjectEditor2;

	[MenuItem("Tools/GameObject Editor")]
	static void ShowWindow() {
		GetWindow<PreviewTwoMat>("GameObject Editor");    
	}

	void OnGUI() {
		mat1 = (Material) EditorGUILayout.ObjectField(mat1, typeof(Material), true);

		if (mat1 != null) {
			if (gameObjectEditor == null)
				gameObjectEditor = Editor.CreateEditor(mat1);
		}

		mat2 = (Material) EditorGUILayout.ObjectField(mat2, typeof(Material), true);

		if (mat2 != null) {
			if (gameObjectEditor2 == null)
				gameObjectEditor2 = Editor.CreateEditor(mat2);

			//gameObjectEditor2.OnPreviewGUI(GUILayoutUtility.GetRect(500, 500), EditorStyles.whiteLabel);
		}

		gameObjectEditor.OnPreviewGUI(GUILayoutUtility.GetRect(100, 100), EditorStyles.whiteLabel);
		gameObjectEditor2.OnPreviewGUI (GUILayoutUtility.GetRect (100, 100), EditorStyles.whiteLabel);
		if(GUILayout.Button("Enable/Disable")){
			//gameObjectEditor.OnPreviewGUI(GUILayoutUtility.GetRect(500, 500), EditorStyles.whiteLabel);
			//gameObjectEditor2.OnPreviewGUI(GUILayoutUtility.GetRect(500, 500), EditorStyles.whiteLabel);
			Debug.Log("Used to enable or disable on click");
		}
	}
}
