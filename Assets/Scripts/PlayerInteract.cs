using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteract : MonoBehaviour
{
    public GameObject interact_text;

    // Start is called before the first frame update
    void Start()
    {
        interact_text.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        float interactRange = 2f;
        Collider2D[] colliderArray = Physics2D.OverlapCircleAll(transform.position, interactRange);
        foreach (Collider2D collider in colliderArray)
        {
            if (collider.TryGetComponent(out Interactable interactable))
            {
                interactable.Interact();
                interact_text.SetActive(true);
            }
            else
            {
                interact_text.SetActive(false);
            }
        }
        if (Input.GetKeyDown(KeyCode.E) && interact_text.activeSelf)
        {
            Debug.Log("omg banana");
        }
        
    }
}
