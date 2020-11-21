using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Start_Scene : MonoBehaviour
{
    void Start()
    {

    }
    public void Change_Scene()
    {
        SceneManager.LoadScene("__WordGame_Scene_0");
    }
    
}
