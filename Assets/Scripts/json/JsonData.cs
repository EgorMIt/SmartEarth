using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using  System;
public class JsonData : MonoBehaviour
{
    [SerializeField]  TextAsset json;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

[System.Serializable]
public class JSON
{
    public points points;
}

[Serializable]
public class points
{
    public dom_kuptsa_vtorova dom_kuptsa_vtorova;
    public moskvor moskvor;
    public dom_nartv dom_nartv;
    public rk_kostel rk_kostel;
    public irksina irksina;
    public irkhudmuz irkhudmuz;
    public kazchas kazchas;
    public dmtru dmtru;
    public exvt exvt;
    public mpooh mpooh;
}

//классы всех точек
[Serializable]
public class dom_kuptsa_vtorova
{
    public int x;
    public int y;
    public coords coords;
    public int delay_time;
}
[Serializable]
public class moskvor
{
    public int x;
    public int y;
    public coords coords;
    public int delay_time;
}
[Serializable]
public class dom_nartv
{
    public int x;
    public int y;
    public coords coords;
    public int delay_time;
}

[Serializable]
public class rk_kostel
{
    public int x;
    public int y;
    public coords coords;
    public int delay_time;
}

[Serializable]
public class irksina
{
    public int x;
    public int y;
    public coords coords;
    public int delay_time;
}

[Serializable]
public class irkhudmuz
{
    public int x;
    public int y;
    public coords coords;
    public int delay_time;
}

[Serializable]
public class kazchas
{
    public int x;
    public int y;
    public coords coords;
    public int delay_time;
}

[Serializable]
public class dmtru
{
    public int x;
    public int y;
    public coords coords;
    public int delay_time;
}

[Serializable]
public class exvt
{
    public int x;
    public int y;
    public coords coords;
    public int delay_time;
}

[Serializable]
public class mpooh
{
    public int x;
    public int y;
    public coords coords;
    public int delay_time;
}

[Serializable]
public class coords
{
    public float latitude;
    public float longitude;
}

//графы
//[Serializable]
    
