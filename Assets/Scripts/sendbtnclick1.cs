using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class sendbtnclick1 : MonoBehaviour
{
    public InputField CodeField;
    public Button SendBtn;
    public string group_id;
    void Start()
    {
        SendBtn.onClick.AddListener(readcode);
        //DontDestroyOnLoad(transform.gameObject);
    }

    public void readcode()
    {
        group_id = CodeField.text;
        save.setkey(group_id);
        Debug.Log(group_id);
        SceneManager.LoadScene("map_scene");
    }


}

public static class save
{
    public static string key;

     public static void setkey(string s)
    {
        key = s;
    }
}
