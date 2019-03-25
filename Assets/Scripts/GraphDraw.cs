using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.UIElements;

public class GraphDraw : MonoBehaviour
{
    public GameObject GridController;
    //public GameObject btn;    
    private int[,] coord;
    private int[,] startcoords;
    private Vector3[] uCoords;
    private LineRenderer drawer;
    private Dictionary<string, int> graphID = new Dictionary<string, int>();

    private GameObject keykeeper;
   // private Dictionary<string, int> ByuildID = ;
    void Start()
    {
        graphID["7014"] = 1;
        graphID["5266"] = 2;
        graphID["4321"] = 3;
        graphID["1703"] = 4;
        graphID["9378"] = 5;
        graphID["2514"] = 6;
        graphID["3828"] = 7;
        keykeeper = GameObject.Find("SendBtn");
        string key = save.key;
        //string  key = "5266    ";
        Debug.Log("key" + key);
        startcoords = GridController.GetComponent<GridDraw>().GetCoords();
        /*coord = GridController.GetComponent<GridDraw>().GetCoords();
        uCoords = GridController.GetComponent<GridDraw>().GetuCoords();
        drawer = GetComponent<LineRenderer>();
        for (int i = 0; i < coord.Length; i++)
        {
            uCoords[i]= new Vector3(uCoords[i].x, uCoords[i].y + 5, uCoords[i].z);
            
        }*/
        drawer = GetComponent<LineRenderer>();
        uCoords = GridController.GetComponent<GridDraw>().GetuCoords();
        if (key == "7014")
        {
            coord = GridController.GetComponent<GridDraw>().graph1;
        }
        if (key == "5266")
        {
            coord = GridController.GetComponent<GridDraw>().graph2;
        }
        if (key == "4321")
        {
            coord = GridController.GetComponent<GridDraw>().graph3;
        }
        if (key == "1703")
        {
            coord = GridController.GetComponent<GridDraw>().graph4;
        }
        if (key == "9378")
        {
            coord = GridController.GetComponent<GridDraw>().graph5;
        }
        if (key == "2514")
        {
            coord = GridController.GetComponent<GridDraw>().graph6;
        }
        if (key == "3828")
        {
            coord = GridController.GetComponent<GridDraw>().graph7;
        }
        for (int i = 0; i < coord.Length; i++)
        {
            uCoords[i]= new Vector3(uCoords[i].x, uCoords[i].y + 5, uCoords[i].z);
            
        }
    }
    
    // Update is called once per frame
    void Update()
    {
        //Debug.Log("length = "  + coord.Length);
        for (int i = 0; i < 10; i++)
        {
            //Debug.Log("y " +  uCoords[i].y);
            int ind = -1;
            for (int j = 0; j < 10; j++)
            {
                Debug.Log(startcoords[j,0] + " " + startcoords[j,1]);
            }
            Debug.Log(" ");
            for (int j = 0; j < 10; j++)
            {
                Debug.Log(coord[j,0] + " " +coord[j,1]);
            }

            for (int j = 0; j < 10; j++)
            {
                if (coord[i, 0] == startcoords[j, 0] && coord[i, 1] == startcoords[j, 1])
                {
                    ind = j;
                    break;
                }
            }
            Vector3 setVec = new Vector3(uCoords[ind].x, 0.02f, uCoords[ind].z);
            drawer.SetPosition(i, setVec);   
        }
    }
}
