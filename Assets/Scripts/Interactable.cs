using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
{

    // Start is called before the first frame update
    public Color originalColor;

    void Start()
    {
        
    }

    private void OnMouseEnter()
    {
        originalColor = GetComponent<MeshRenderer>().material.color;
        transform.Find("light kit").gameObject.SetActive(true);
        
    }

    private void OnMouseExit()
    {
        GetComponent<MeshRenderer>().material.color = Color.white;
        transform.Find("light kit").gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
