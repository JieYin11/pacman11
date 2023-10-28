using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadscene : MonoBehaviour
{
    public void LoadAssessment3Scene()
    {
        SceneManager.LoadScene("mainscene"); 

    }
    public void LoadStartScene()
    {
        SceneManager.LoadScene("StartScene");
    }
}
