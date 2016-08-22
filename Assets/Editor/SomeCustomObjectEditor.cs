using UnityEngine;
using System.Collections;
using UnityEditor;

[CustomEditor(typeof(SomeCustomObject))]
public class SomeCustomObjectEditor : Editor {
	private Color color;

	public override void OnInspectorGUI(){
		//base.OnInspectorGUI ();

		EditorGUILayout.LabelField ("Vertex Colorizer");

		color = EditorGUILayout.ColorField ("Color", color);

		if (GUILayout.Button ("Set Vertex Color")) {
			var customObject = target as SomeCustomObject;
			var meshFilter = customObject.GetComponent<MeshFilter> ();
			meshFilter.sharedMesh.setVertexColor (color);
		}
	}

}
