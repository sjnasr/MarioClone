using UnityEngine;
using System.Collections;

public static class MeshExtensions {

	public static void setVertexColor(this Mesh mesh, Color color){
		var vertColors = new Color[mesh.vertexCount];

		for (var i = 0; i < mesh.vertexCount; i++) {
			vertColors [i] = color;
		}

		mesh.colors = vertColors;
		mesh.RecalculateNormals ();
	}
}
