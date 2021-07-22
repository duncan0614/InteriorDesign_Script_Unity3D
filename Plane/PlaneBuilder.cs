//PlaneBuilder.cs

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#region Editor

#if UNITY_EDITOR

using UnityEditor;

[CustomEditor(typeof(PlaneBuilder))]
public class PlaneBuilderEditor : Editor
{
    public override void OnInspectorGUI()
    {
        PlaneBuilder builder = (PlaneBuilder)target;

        EditorGUI.BeginChangeCheck();

        base.OnInspectorGUI();

        if (EditorGUI.EndChangeCheck())
        {
            builder.UpdateMesh();
        }

        if (GUILayout.Button("更新網格"))
        {
            builder.UpdateMesh();
        }
    }
}

#endif

#endregion Editor

[RequireComponent(typeof(MeshFilter), typeof(MeshRenderer))]
public class PlaneBuilder : MonoBehaviour
{

    public Slider sliderx;
    public Slider slidery;

    [SerializeField]
    private MeshFilter _meshFilter;

    [SerializeField]
    private MeshRenderer _meshRenderer;

    /// <summary>
    /// 單元格大小
    /// </summary>
    [SerializeField]
    private Vector2 _cellSize = new Vector2(1, 1);

    /// <summary>
    /// 網格大小
    /// </summary>
    [SerializeField]
    private Vector2Int _gridSize = new Vector2Int(2, 2);

    public MeshRenderer MeshRenderer
    {
        get
        {
            return _meshRenderer;
        }
    }

    public MeshFilter MeshFilter
    {
        get
        {
            return _meshFilter;
        }
    }

    private void Awake()
    {
        _meshFilter = GetComponent<MeshFilter>();
        _meshRenderer = GetComponent<MeshRenderer>();
        UpdateMesh();
    }

    public void UpdateMesh()
    {
        Mesh mesh = new Mesh();

        //計算Plane大小
        Vector2 size;
        size.x = sliderx.value * _gridSize.x;
        size.y = slidery.value * _gridSize.y;

        //計算Plane一半大小
        Vector2 halfSize = size / 2;

        //計算頂點及UV
        List<Vector3> vertices = new List<Vector3>();
        List<Vector2> uvs = new List<Vector2>();

        Vector3 vertice = Vector3.zero;
        Vector2 uv = Vector3.zero;

        for (int y = 0; y < _gridSize.y + 1; y++)
        {
            vertice.z = y * slidery.value - halfSize.y;//計算頂點Y軸
            uv.y = y * slidery.value / size.y;//計算頂點紋理座標V

            for (int x = 0; x < _gridSize.x + 1; x++)
            {
                vertice.x = x * sliderx.value - halfSize.x;//計算頂點X軸
                uv.x = x * sliderx.value / size.x;//計算頂點紋理座標U

                vertices.Add(vertice);//新增到頂點陣列
                uvs.Add(uv);//新增到紋理座標陣列
            }
        }

        //頂點序列
        int a = 0;
        int b = 0;
        int c = 0;
        int d = 0;
        int startIndex = 0;
        int[] indexs = new int[_gridSize.x * _gridSize.y * 2 * 3];//頂點序列
        for (int y = 0; y < _gridSize.y; y++)
        {
            for (int x = 0; x < _gridSize.x; x++)
            {
                //四邊形四個頂點
                a = y * (_gridSize.x + 1) + x;//0
                b = (y + 1) * (_gridSize.x + 1) + x;//1
                c = b + 1;//2
                d = a + 1;//3

                //計算在陣列中的起點序號
                startIndex = y * _gridSize.x * 2 * 3 + x * 2 * 3;

                //左上三角形
                indexs[startIndex] = a;//0
                indexs[startIndex + 1] = b;//1
                indexs[startIndex + 2] = c;//2

                //右下三角形
                indexs[startIndex + 3] = c;//2
                indexs[startIndex + 4] = d;//3
                indexs[startIndex + 5] = a;//0
            }
        }

        //
        mesh.SetVertices(vertices);//設定頂點
        mesh.SetUVs(0, uvs);//設定UV
        mesh.SetIndices(indexs, MeshTopology.Triangles, 0);//設定頂點序列
        mesh.RecalculateNormals();
        mesh.RecalculateBounds();
        mesh.RecalculateTangents();

        _meshFilter.mesh = mesh;
    }

#if UNITY_EDITOR

    private void OnValidate()
    {
        if (null == _meshFilter)
        {
            _meshFilter = GetComponent<MeshFilter>();
        }
        if (null == _meshRenderer)
        {
            _meshRenderer = GetComponent<MeshRenderer>();
            if (null == _meshRenderer.sharedMaterial)
            {
                _meshRenderer.sharedMaterial = new Material(Shader.Find("Standard"));
            }
        }
    }

#endif
}