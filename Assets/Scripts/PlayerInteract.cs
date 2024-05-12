using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerInteract : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            float interactRange = 2;
            Collider[] colliderarray = Physics.OverlapSphere(transform.position, interactRange);
            foreach (Collider collider in colliderarray)
            {
                Debug.Log(collider.gameObject.name);
            }
        } 
    }
}
