using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProcedGeometry : MonoBehaviour
{
	private MeshRenderer m_meshRenderer;
	private MeshFilter m_meshFilter;
	private Mesh m_mesh;
	public Material m_material;
	public Transform[] m_corners; //0 =-1, 1=+1;
	
    void Start()
    {
	    m_meshRenderer = gameObject.AddComponent<MeshRenderer>();
	    m_meshRenderer.material = m_material;
	    
	    m_mesh = new Mesh();
	    m_mesh.name = "Mesh Procedural";
	    
	    /*m_mesh.vertices = new Vector3[]{
	    	new Vector3(-1f,1f,0f),
	    	new Vector3(1f,1f,0f),
	    	new Vector3(1f,-1f,0f),
	    	new Vector3(-1f,-1f,0f)
	    };*/
	    
	    m_mesh.vertices = new Vector3[]{
		    new Vector3(m_corners[0].localPosition.x,m_corners[1].localPosition.y,m_corners[0].localPosition.z),
		    new Vector3(m_corners[1].localPosition.x,m_corners[1].localPosition.y,m_corners[0].localPosition.z),
		    new Vector3(m_corners[1].localPosition.x,m_corners[0].localPosition.y,m_corners[0].localPosition.z),
		    new Vector3(m_corners[0].localPosition.x,m_corners[0].localPosition.y,m_corners[0].localPosition.z),
		    
		    new Vector3(m_corners[1].localPosition.x,m_corners[0].localPosition.y,m_corners[1].localPosition.z),
		    new Vector3(m_corners[0].localPosition.x,m_corners[0].localPosition.y,m_corners[1].localPosition.z),
		    new Vector3(m_corners[0].localPosition.x,m_corners[1].localPosition.y,m_corners[1].localPosition.z),
		    new Vector3(m_corners[1].localPosition.x,m_corners[1].localPosition.y,m_corners[1].localPosition.z)
	    };
	    
	    m_mesh.colors = new Color[]{
	    	new Color(1,1,0,1),//amarillo
	    	new Color(1,1,1,1),//blanco
	    	new Color(1,0,1,1),//magenta
	    	new Color(1,0,0,1),//rojo
		    new Color(0,0,1,1),//azul
		    new Color(0,0,0,1),//negro
		    new Color(0,1,0,1),//verde
		    new Color(0,1,1,1)//cyan
	    };
	    
	    m_mesh.uv = new Vector2[]{
    		new Vector2(0,1),
    		new Vector2(1,1),
    		new Vector2(1,0),
    		new Vector2(0,0),
    		new Vector2(0,1),
    		new Vector2(1,1),
    		new Vector2(1,0),
    		new Vector2(0,0)
    	};
	    
    	m_mesh.triangles = new int[]{
    		0,1,2,//adelante
    		0,2,3,
    		
    		1,7,4,//derecha
    		1,4,2,
    		
    		0,6,7,//arriba
    		0,7,1,
    		
    		2,4,5,//abajo
    		2,5,3,
    		
    		6,0,3,//izquierda
    		6,3,5,
    		
    		7,6,5,
    		7,5,4//atras
    		
    	};
    	
    	
	    
	    m_meshFilter = gameObject.AddComponent<MeshFilter>();
	    m_meshFilter.mesh = m_mesh;
	    
    }

    void Update()
	{
		m_mesh.vertices = new Vector3[]{
			new Vector3(m_corners[0].localPosition.x,m_corners[1].localPosition.y,m_corners[0].localPosition.z),
			new Vector3(m_corners[1].localPosition.x,m_corners[1].localPosition.y,m_corners[0].localPosition.z),
			new Vector3(m_corners[1].localPosition.x,m_corners[0].localPosition.y,m_corners[0].localPosition.z),
			new Vector3(m_corners[0].localPosition.x,m_corners[0].localPosition.y,m_corners[0].localPosition.z),
		    
			new Vector3(m_corners[1].localPosition.x,m_corners[0].localPosition.y,m_corners[1].localPosition.z),
			new Vector3(m_corners[0].localPosition.x,m_corners[0].localPosition.y,m_corners[1].localPosition.z),
			new Vector3(m_corners[0].localPosition.x,m_corners[1].localPosition.y,m_corners[1].localPosition.z),
			new Vector3(m_corners[1].localPosition.x,m_corners[1].localPosition.y,m_corners[1].localPosition.z)
		};
	    
    }
}
