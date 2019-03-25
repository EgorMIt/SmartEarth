using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Converter : MonoBehaviour
{
    public GameObject GridController;
 
    // Start is called before the first frame update
    
    public static float convertX( float width)
    {
        
        float d_lat = 52.293666f  - 52.283627f;
        
        
        float scale_x = width / d_lat;
        
        float target_x = (52.293666f - 52.283627f) * scale_x;
        
        return target_x;
    }

    public static float convertY(float height)
    {

        
        float d_lon = 104.283216f - 104.301892f;

        
        float scale_y = height / d_lon;
      
        float target_y = (104.283216f - 104.301892f) * scale_y;
        return target_y;
    }
}
