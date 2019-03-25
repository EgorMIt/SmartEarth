using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DBManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Send());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private IEnumerator Send()
    {
        WWWForm form = new WWWForm();
        form.AddField("Device-Id","111");
        form.AddField("Group-Id", "2");
        WWW www = new WWW("hector.nti-ar.ru/put_coords.php", form);
        yield return www;
        Debug.Log("Сервер ответил " + www.text);
    }
    
}
