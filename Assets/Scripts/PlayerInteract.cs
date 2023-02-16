using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteract : MonoBehaviour
{
    public GameObject interactText;

    // Start is called before the first frame update
    void Start()
    {
        interactText.SetActive(false);
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
                interactText.SetActive(true);
            }
            else
            {
                interactText.SetActive(false);
            }
        }
        if (Input.GetKeyDown(KeyCode.E) && interactText.activeSelf)
        {
            Debug.Log("omg banana");
        }
        
    }
}
