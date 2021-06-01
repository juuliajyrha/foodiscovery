using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LanguageHandler : MonoBehaviour
{
    public const int GR = 0;
    public const int ENG = 1;
    private int language;

    void Start()
    {
        language = GR;
    }

    public void englishSelected()
    {
        Debug.Log("eng");
    }
}
