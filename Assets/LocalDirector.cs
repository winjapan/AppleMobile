using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LocalDirector : MonoBehaviour
{
    public enum Language
    {
        Japanese,
        English
    }

    public static Language language;
    private AudioSource audioSource;



    public void LocalJpClicked()
    {
        language = Language.Japanese;

    }

    public void LocalEnClicked()
    {
        language = Language.English;
       
    }

   
}

