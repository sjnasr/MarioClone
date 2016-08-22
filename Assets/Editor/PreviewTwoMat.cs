using UnityEngine;
using System.Collections;
using UnityEditor;

public class PreviewTwoMat : EditorWindow {
	public Material material1;
	public Material material2;
	bool enabled;
	Editor gameObjectEditor;
	Editor gameObjectEditor2;

	[MenuItem("Tools/GameObject Editor")]
	static void ShowWindow() {
		GetWindow<PreviewTwoMat>("GameObject Editor");
	}
		

	void OnGUI() {
		material1 = (Material) EditorGUILayout.ObjectField(material1, typeof(Material), true);

		/*if (material1 != null) {
			if (gameObjectEditor == null)
				gameObjectEditor = Editor.CreateEditor(material1);
		}*/

		material2 = (Material) EditorGUILayout.ObjectField(material2, typeof(Material), true);

		/*if (material2 != null) {
			if (gameObjectEditor2 == null)
				gameObjectEditor2 = Editor.CreateEditor(material2);

			//gameObjectEditor2.OnPreviewGUI(GUILayoutUtility.GetRect(500, 500), EditorStyles.whiteLabel);
		}*/
			
		//gameObjectEditor.OnPreviewGUI(GUILayoutUtility.GetRect(100, 100), EditorStyles.whiteLabel);
		//gameObjectEditor2.OnPreviewGUI (GUILayoutUtility.GetRect (100, 100), EditorStyles.whiteLabel);
		if(GUILayout.Button("Show materials")){
			Debug.Log ("Display materials is being clicked");
			if (material1 != null && material2 != null) {
				if (gameObjectEditor == null)
					gameObjectEditor = Editor.CreateEditor(material1);
				
				if (gameObjectEditor2 == null)
					gameObjectEditor2 = Editor.CreateEditor(material2);

				gameObjectEditor.OnPreviewGUI(GUILayoutUtility.GetRect(500, 500), EditorStyles.whiteLabel);
				gameObjectEditor2.OnPreviewGUI(GUILayoutUtility.GetRect(500, 500), EditorStyles.whiteLabel);
			}
			/*if (material1 != null) {
				gameObjectEditor.OnPreviewGUI (GUILayoutUtility.GetRect (20, 20), EditorStyles.whiteLabel);
				//EditorGUI.DrawPreviewTexture (Rect (26, 60, 100, 100), material1);
			}
			if (material2) {
				//EditorGUI.DrawPreviewTexture (Rect (26, 60, 100, 100), material2);
			}*/
			//gameObjectEditor.OnPreviewGUI(GUILayoutUtility.GetRect(500, 500), EditorStyles.whiteLabel);
			//gameObjectEditor2.OnPreviewGUI(GUILayoutUtility.GetRect(500, 500), EditorStyles.whiteLabel);

		}
	}
}
