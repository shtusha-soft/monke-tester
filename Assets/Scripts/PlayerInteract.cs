using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
            float interactRange = 2f;
            Collider2D[] colliderArray = Physics2D.OverlapCircleAll(transform.position, interactRange);
            foreach (Collider2D collider in colliderArray)
            {
                Debug.Log(collider);
            }
        }
        
    }
}
