using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class GridDraw : MonoBehaviour
{
    public Transform a;
    public Transform b;

    public Transform acopy;
    public Transform bcopy;
    
    private LineRenderer drawer;
    public float hordist, verdist;
    public static int verAmount = 7;
    public static int horAmount = 8;
    public float width = 0.05f;
    public GameObject[] obj;
    private int[,] coord = new int[,] { {4, 2}, {0,2}, {6, 1}, { 2, 0 }, { 5, 6 }, { 7, 2 }, { 3, 0 }, { 3, 8 }, {3,5}, { 6, 7 } };
    private Vector3[] uCoords = new Vector3[10];
    private Vector3[] edges = new Vector3[4];
    private List<GameObject> verLines = new List<GameObject>();
    private List<GameObject> objects = new List<GameObject>();
    private List<GameObject> horLines = new List<GameObject>();
    public int[,] graph1 = new int[,] {{5, 6}, {6, 7}, {3,8 }, {3,5}, {4,2}, {2,0}, {0,2}, {3,0}, {6,1}, {7,2}};
    public int[,] graph2 = new int[,] {{0,2}, {2,0}, {3,0}, {4,2}, {6,1}, {7,2}, {5, 6}, {6,7}, {3,8}, {3,5}};
    public int[,] graph3 = new int[,] {{3,0}, {0,2}, {2,0}, {4,2}, {6,1}, {7,2}, {5,6}, {6,7}, {3,5}, {3,8}};
    public int[,] graph4 = new int[,] {{3,0}, {0,2}, {2,0}, {4,2}, {6,1}, {7,2}, {5,6}, {6,7}, {3,5}, {3,8}}; 
    public int[,] graph5 = new int[,] {{3,5}, {4,2}, {0,2}, {3,0}, {2,0}, {6,1}, {7,2}, {6,7}, {3,8}, {5,6}}; 
    public int[,] graph6 = new int[,] {{6,1}, {7,2}, {3,0}, {2,0}, {4,2}, {0,2}, {3,5}, {5,6}, {3,8}, {6,7}}; 
    public int[,] graph7 = new int[,] {{7,2}, {6,1}, {4,2}, {3,0}, {2,0}, {0,2}, {3,5}, {3,8}, {5,6}, {6,7}};
    public Vector3[] uCoords1 = new Vector3[10];
    public Vector3[] uCoords2 = new Vector3[10];
    public Vector3[] uCoords3 = new Vector3[10];
    public Vector3[] uCoords4 = new Vector3[10];
    public Vector3[] uCoords5 = new Vector3[10];
    public Vector3[] uCoords6 = new Vector3[10];
    public Vector3[] uCoords7 = new Vector3[10];
    void Start()
    {
        acopy = a;
        bcopy = b;
        
        
        drawer = GetComponent<LineRenderer>();
        
        float verdist = (a.position.x - b.position.x) / verAmount - 1;
        for (int i = 0; i < verAmount; i++)
        {
            verLines.Add(new GameObject());
        }
        foreach (GameObject i in verLines){
            i.AddComponent<LineRenderer>();
            i.GetComponent<LineRenderer>().positionCount = 2;
            i.GetComponent<LineRenderer>().SetWidth(width, width);
            i.GetComponent<LineRenderer>().material = Resources.Load<Material>("Models/Texture");
            i.name = "verLine_" + verLines.IndexOf(i);
            //Instantiate(i);
        }

        for (int i = 0; i < horAmount; i++)
        {
            horLines.Add(new GameObject());
        }
        foreach (GameObject i in horLines)
        {
            i.AddComponent<LineRenderer>();
            i.GetComponent<LineRenderer>().positionCount = 2;
            i.GetComponent<LineRenderer>().SetWidth(width, width);
            i.GetComponent<LineRenderer>().material = Resources.Load<Material>("Models/Texture");
            i.name = "horLine_" + horLines.IndexOf(i);
            //Instantiate(i);
        }
        
        for (int i = 0; i < obj.Length; i++)
        {
            if (i == 0)
            {
                GameObject cube = new GameObject();
                cube.AddComponent<MeshFilter>();
                cube.GetComponent<MeshFilter>().mesh = Resources.Load<Mesh>("Models/ДомВторовых");
                cube.AddComponent<MeshRenderer>();
                cube.GetComponent<Renderer>().material = Resources.Load<Material>("Models/Mat");
                objects.Add(cube);
            }
            if (i == 1)
            {
                GameObject cube = new GameObject();
                cube.AddComponent<MeshFilter>();
                cube.GetComponent<MeshFilter>().mesh = Resources.Load<Mesh>("Models/arka");
                cube.AddComponent<MeshRenderer>();
                cube.GetComponent<Renderer>().material = Resources.Load<Material>("Models/Arka_Mat");
                cube.transform.Rotate(new Vector3(0, -90, 0));
                objects.Add(cube);

            }
            if (i == 2)
            {
                GameObject cube = new GameObject();
                cube.AddComponent<MeshFilter>();
                cube.GetComponent<MeshFilter>().mesh = Resources.Load<Mesh>("Models/ДомТвор");
                cube.AddComponent<MeshRenderer>();
                cube.GetComponent<Renderer>().material = Resources.Load<Material>("Models/Творч");
                cube.transform.Rotate(new Vector3(-90, 0, 0));
                objects.Add(cube);

            }
            if (i == 3)
            {
                GameObject cube = new GameObject();
                cube.AddComponent<MeshFilter>();
                cube.GetComponent<MeshFilter>().mesh = Resources.Load<Mesh>("Models/Костел");
                cube.AddComponent<MeshRenderer>();
                cube.GetComponent<Renderer>().material = Resources.Load<Material>("Models/Собор");
                objects.Add(cube);

            }
            if (i == 4)
            {
                GameObject cube = new GameObject();
                cube.AddComponent<MeshFilter>();
                cube.GetComponent<MeshFilter>().mesh = Resources.Load<Mesh>("Models/Синагога");
                cube.AddComponent<MeshRenderer>();
                cube.GetComponent<Renderer>().material = Resources.Load<Material>("Models/Mat");
                objects.Add(cube);

            }
            if (i == 5)
            {
                GameObject cube = new GameObject();
                cube.AddComponent<MeshFilter>();
                cube.GetComponent<MeshFilter>().mesh = Resources.Load<Mesh>("Models/Худож.Музей");
                cube.AddComponent<MeshRenderer>();
                cube.GetComponent<Renderer>().material = Resources.Load<Material>("Models/ХудожМузей");
                cube.transform.Rotate(new Vector3(-90, -90, 0));
                objects.Add(cube);

            }
            if (i == 6)
            {
                GameObject cube = new GameObject();
                cube.AddComponent<MeshFilter>();
                cube.GetComponent<MeshFilter>().mesh = Resources.Load<Mesh>("Models/Часовня");
                cube.transform.Rotate(new Vector3(-90, 0, 0));
                cube.AddComponent<MeshRenderer>();
                cube.GetComponent<Renderer>().material = Resources.Load<Material>("Models/Часовня");
                objects.Add(cube);

            }
            if (i == 7)
            {
                GameObject cube = new GameObject();
                cube.AddComponent<MeshFilter>();
                cube.GetComponent<MeshFilter>().mesh = Resources.Load<Mesh>("Models/Вокзал");
                cube.AddComponent<MeshRenderer>();
                cube.GetComponent<Renderer>().material = Resources.Load<Material>("Models/Vokzal_mat");
                objects.Add(cube);

            }
            if (i == 8)
            {
                GameObject cube = new GameObject();
                cube.AddComponent<MeshFilter>();
                cube.GetComponent<MeshFilter>().mesh = Resources.Load<Mesh>("Models/Танк");
                cube.AddComponent<MeshRenderer>();
                cube.GetComponent<Renderer>().material = Resources.Load<Material>("Models/Mat");
                objects.Add(cube);

            }
            if (i == 9)
            {
                GameObject cube = new GameObject();
                cube.AddComponent<MeshFilter>();
                cube.GetComponent<MeshFilter>().mesh = Resources.Load<Mesh>("Models/Пожарная ст.");
                cube.AddComponent<MeshRenderer>();
                cube.GetComponent<Renderer>().material = Resources.Load<Material>("Models/Пожарная");
                cube.transform.Rotate(new Vector3(-90, 0, 0));
                objects.Add(cube);

            }
        }
        foreach (GameObject i in objects)
        {
            i.AddComponent<MeshRenderer>();
        }
    }


    // Update is called once per frame
    void Update()
    {//создание обводки
        
        edges[0] = a.position;
        edges[1] = new Vector3(b.position.x, a.position.y, a.position.z);
        edges[2] = b.position;
        edges[3] = new Vector3(a.position.x, a.position.y, b.position.z);
        for (int i = 0; i < 4; i++)
        {
            drawer.SetPosition(i, edges[i]);
        }
        drawer.SetPosition(4, edges[0]);

        // создание сетки
        //float verdist = Mathf.Abs(a.position.x + b.position.x) / (verAmount + 1);
        
        verdist = Vector3.Distance(a.position, new Vector3(b.position.x, a.position.y, a.position.z)) / (verAmount + 1);
        if (b.position.x < a.position.x)
        {
            verdist = -verdist;
        }
        //Debug.Log("verdist = " + verdist);
        foreach (GameObject i in verLines) {
            i.GetComponent<LineRenderer>().SetPosition(0, new Vector3(a.position.x + verdist * (verLines.IndexOf(i) + 1), a.position.y, a.position.z));
            i.GetComponent<LineRenderer>().SetPosition(1, new Vector3(a.position.x + verdist * (verLines.IndexOf(i) + 1), a.position.y, b.position.z));
        }

        hordist =   - 1 * Vector3.Distance(b.position, new Vector3(b.position.x, b.position.y, a.position.z)) / (horAmount + 1);
        if (a.position.z < b.position.z)
        {
            hordist = -hordist;
        }
        //Debug.Log(hordist);
        foreach(GameObject i in horLines)
        {
            i.GetComponent<LineRenderer>().SetPosition(0, new Vector3(a.position.x, a.position.y, a.position.z + hordist * (horLines.IndexOf(i) + 1)));
            i.GetComponent<LineRenderer>().SetPosition(1, new Vector3(b.position.x, a.position.y, a.position.z + hordist * (horLines.IndexOf(i) + 1)));
        }


        for (int i = 0; i < obj.Length; i++)
        {
            uCoords[i] = new Vector3(a.position.x + verdist * coord[i,0] + verdist * 0.5f, a.position.y, a.position.z + hordist * coord[i, 1] + hordist * 0.5f);
            objects[i].transform.position = uCoords[i];
            if (i == 0) 
            {
                objects[i].transform.localScale = new Vector3(Mathf.Abs((Mathf.Abs(verdist) + Mathf.Abs(hordist)) / 2)*0.9f, Mathf.Abs((Mathf.Abs(verdist) + Mathf.Abs(hordist)) / 2) * 0.9f, Mathf.Abs((Mathf.Abs(verdist) + Mathf.Abs(hordist)) / 2)) * 0.9f;
            }
            if (i == 1)
            {
                objects[i].transform.localScale = new Vector3(Mathf.Abs((Mathf.Abs(verdist) + Mathf.Abs(hordist)) / 2) * 1.2f, Mathf.Abs((Mathf.Abs(verdist) + Mathf.Abs(hordist)) / 2) * 1.2f, Mathf.Abs((Mathf.Abs(verdist) + Mathf.Abs(hordist)) / 2)) * 1.2f;
            }
            if (i == 9)
            {
                objects[i].transform.localScale = new Vector3(Mathf.Abs((Mathf.Abs(verdist) + Mathf.Abs(hordist)) / 2) * 0.5f, Mathf.Abs((Mathf.Abs(verdist) + Mathf.Abs(hordist)) / 2) * 0.5f, Mathf.Abs((Mathf.Abs(verdist) + Mathf.Abs(hordist)) / 2)) * 0.4f;
            }
            if (i == 6 || i == 5 || i==3)
            {
                objects[i].transform.localScale = new Vector3(Mathf.Abs((Mathf.Abs(verdist) + Mathf.Abs(hordist)) / 2) * 1.2f, Mathf.Abs((Mathf.Abs(verdist) + Mathf.Abs(hordist)) / 2) * 1.2f, Mathf.Abs((Mathf.Abs(verdist) + Mathf.Abs(hordist)) / 2)) * 1.2f;
            }
            if (i == 4)
            {
                objects[i].transform.localScale = new Vector3(Mathf.Abs((Mathf.Abs(verdist) + Mathf.Abs(hordist)) / 2) * 1.4f, Mathf.Abs((Mathf.Abs(verdist) + Mathf.Abs(hordist)) / 2) * 1.4f, Mathf.Abs((Mathf.Abs(verdist) + Mathf.Abs(hordist)) / 2)) * 1.4f;
            }
            if (i == 8)
            {
                objects[i].transform.localScale = new Vector3(Mathf.Abs((Mathf.Abs(verdist) + Mathf.Abs(hordist)) / 2) * 0.7f, Mathf.Abs((Mathf.Abs(verdist) + Mathf.Abs(hordist)) / 2) * 0.7f, Mathf.Abs((Mathf.Abs(verdist) + Mathf.Abs(hordist)) / 2)) * 0.7f;
            }
            if (i ==2|| i == 7)
            {
                objects[i].transform.localScale = new Vector3(Mathf.Abs((Mathf.Abs(verdist) + Mathf.Abs(hordist)) / 2) * 0.9f, Mathf.Abs((Mathf.Abs(verdist) + Mathf.Abs(hordist)) / 2) * 0.9f, Mathf.Abs((Mathf.Abs(verdist) + Mathf.Abs(hordist)) / 2)) * 0.9f;
            }
        }
        //Debug.Log(verdist);
       // Debug.Log(hordist);
    }

    public int[,] GetCoords()
    {
        return coord;
    }

    public Vector3[] GetuCoords()
    {
        return uCoords;
    }
    
}
