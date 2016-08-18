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
			Debug.Log ("Clicked Button");
		}
	}

}
