using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Quit_Scene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void Home_Screen(string scene)
    {
        SceneManager.LoadScene(scene);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
