using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SceneMain()
    {
        SceneManager.LoadScene("Home");
    }

    public void SceneTime()
    {
        SceneManager.LoadScene("Time");
    }

    public void SceneSET()
    {
        SceneManager.LoadScene("Setting");
    }


    public void SceneBuild_select()
    {
        SceneManager.LoadScene("Build_select");
    }


    public void HowtoUse_S()
    {
        SceneManager.LoadScene("HowToUse");
    }

    public void destroy_obj()
    {
        Destroy(GameObject.Find("script"));
    }


}
