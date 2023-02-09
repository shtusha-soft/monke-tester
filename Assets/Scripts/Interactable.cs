using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
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
        
    }

    public void Interact()
    {
        Debug.Log("Interact!");
        interact_text.SetActive(true);
    }
}
