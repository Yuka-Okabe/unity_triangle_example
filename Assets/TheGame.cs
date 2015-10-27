using UnityEngine;
using System.Collections;

public class TheGame : MonoBehaviour {
	static readonly int[] triangle_indices = { 0, 1, 2 };//colouredone
    static readonly int[] line_indices = { 0, 1, 1, 2, 2, 0 };//not coloured one
	static readonly Vector3[] vertices = {//三角形の基礎かってことは？
		new Vector3(-10, -10, 0),
		new Vector3(  0,  10, 0),
		new Vector3( 10, -10, 0),
	};
    static readonly Vector3[] vertices2 = {//三角形の基礎かってことは？
		new Vector3(-5, -5, 0),
        new Vector3(  0,  5, 0),
        new Vector3( 5, -5, 0),
    };


    void make_triangle() {
		GameObject go = new GameObject ();
		go.name = "triangle";
		go.transform.localPosition = new Vector3 (-10, 0, 20);
		
		MeshFilter mf = go.AddComponent<MeshFilter> ();
		go.AddComponent<MeshRenderer> ();
		
		Mesh mesh = new Mesh ();
		mesh.vertices = vertices;
		mesh.triangles = triangle_indices;//colored one
		mf.mesh = mesh;
	}
	
	void make_wireframe() {
		GameObject go = new GameObject ();
		go.name = "wireframe";
		go.transform.localPosition = new Vector3 (10, 0, 20);

		MeshFilter mf = go.AddComponent<MeshFilter> ();
		go.AddComponent<MeshRenderer> ();

		Mesh mesh = new Mesh ();
		mesh.vertices = vertices;
		mesh.SetIndices (line_indices, MeshTopology.Lines, 0);//not colored one
		mf.mesh = mesh;
	}
    void make_triangle2()
    {
        GameObject go = new GameObject();
        go.name = "triangle2";
        go.transform.localPosition = new Vector3(-20, 0, 20);

        MeshFilter mf = go.AddComponent<MeshFilter>();
        go.AddComponent<MeshRenderer>();

        Mesh mesh = new Mesh();

       // mesh = GetComponent<MeshFilter>().mesh;
        

        mesh.vertices = vertices2;
        mesh.triangles = triangle_indices;//colored one
        mf.mesh = mesh;

    }




    // Use this for initialization
    void Start () {
		make_triangle ();
        make_wireframe ();
        make_triangle2();
    }

    // Update is called once per frame
    void Update () {
	
	}
}
