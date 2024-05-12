using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using UnityEditor.VersionControl;
using UnityEngine;

public class switch_camera : MonoBehaviour
{
    public Camera wide;
    public Camera character;
    public Camera closeup;
    public Camera window;
    // Start is called before the first frame update
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            wide.enabled = true;
            character.enabled = false;
            closeup.enabled = false;
            window.enabled = false;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            wide.enabled = false;
            character.enabled = true;
            closeup.enabled = false;
            window.enabled = false;
        }
       else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            wide.enabled = false;
            character.enabled = false;
            closeup.enabled = true;
            window.enabled = false;
        }
       else if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            wide.enabled = false;
            character.enabled = false;
            closeup.enabled = false;
            window.enabled = true;
        }
    }
    public int camnum = 1;
    public void togglecams()
    {
        if (camnum == 1)
        {
            wide.enabled = true;
            character.enabled = false;
            closeup.enabled = false;
            window.enabled = false;
            camnum += 1;
        }
        else if (camnum == 2)
        {
            wide.enabled = false;
            character.enabled = true;
            closeup.enabled = false;
            window.enabled = false;
            camnum += 1;
        }
        else if (camnum == 3)
        {
            wide.enabled = false;
            character.enabled = false;
            closeup.enabled = true;
            window.enabled = false;
            camnum += 1;
        }
        else if (camnum == 4)
        {
            wide.enabled = false;
            character.enabled = false;
            closeup.enabled = false;
            window.enabled = true;
            camnum = 1;
        }
    }    }     
        