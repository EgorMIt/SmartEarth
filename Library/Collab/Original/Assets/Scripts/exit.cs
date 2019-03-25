using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SendbtnClick : MonoBehaviour
{
    public InputField CodeField;
    public Button Errbtn;
    public string group_id;
    void Start()
    {
        Errbtn.onClick.AddListener(readcode);
    }

    public void exittt()
    {
        SceneManager.LoadScene("start_scene");
    }

    // Update is called once per frame
    void Update()
    {

    }
}
