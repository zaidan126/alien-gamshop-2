using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIScript : MonoBehaviour
{
 public void quit()
    {
     Application.Quit();
        UnityEditor.EditorApplication.isPlaying = false;    }
}
