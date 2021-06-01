using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButtonHandler : MonoBehaviour
{
    public void TaskOnClick()
    {
        SceneManager.LoadScene("MainScreen");
    }
}
