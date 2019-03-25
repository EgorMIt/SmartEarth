using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapScale : MonoBehaviour
{
    public GameObject GridController;
    private float hordist, verdist;
    float kx = 0.9f, ky = 0.9f, kz = 0.8f;
    float xpos, ypos, zpos, xpos2, ypos2, zpos2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        verdist = GridController.GetComponent<GridDraw>().verdist;
        hordist = GridController.GetComponent<GridDraw>().hordist;
        xpos = GridController.GetComponent<GridDraw>().a.position.x;
        ypos = GridController.GetComponent<GridDraw>().a.position.y;    
        zpos = GridController.GetComponent<GridDraw>().a.position.z;
        xpos2 = GridController.GetComponent<GridDraw>().b.position.x;
        ypos2 = GridController.GetComponent<GridDraw>().b.position.y;
        zpos2 = GridController.GetComponent<GridDraw>().b.position.z;
        
        transform.position = new Vector3(xpos + verdist * 4, ypos, zpos + hordist * 4 + hordist * 0.5f);
        if (zpos2 > zpos && xpos2 > xpos)
            transform.localScale = new Vector3(Mathf.Abs(hordist) * kx, Mathf.Abs((Mathf.Abs(verdist) + Mathf.Abs(hordist)) / 2) * ky, Mathf.Abs(verdist) * kz);
        if (zpos2 < zpos && xpos2 > xpos)
            transform.localScale = new Vector3(Mathf.Abs(hordist) * -kx, Mathf.Abs((Mathf.Abs(verdist) + Mathf.Abs(hordist)) / 2) * ky, Mathf.Abs(verdist) * kz);
        if (zpos2 > zpos && xpos2 < xpos)
            transform.localScale = new Vector3(Mathf.Abs(hordist) * kx, Mathf.Abs((Mathf.Abs(verdist) + Mathf.Abs(hordist)) / 2) * ky, Mathf.Abs(verdist) * -kz);
        if (zpos2 < zpos && xpos2 < xpos)
            transform.localScale = new Vector3(Mathf.Abs(hordist) * -kx, Mathf.Abs((Mathf.Abs(verdist) + Mathf.Abs(hordist)) / 2) * ky, Mathf.Abs(verdist) * -kz);
    }
}
