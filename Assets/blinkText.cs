using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class blinkText : MonoBehaviour
{
    public float duracion;
    public Image textBox;

    void Start ()
    {
        textBox = GameObject.Find("text box").GetComponent<Image>();
        textBox.enabled = true;
    }


    public IEnumerator blinkTalk()
    {
        yield return new WaitForSeconds(duracion);
        textBox.enabled = false;

    }

    
        void OnTriggerEnter(Collider other){

        if (other.CompareTag("Player")){
           
            StartCoroutine(blinkTalk());
        }
    }

    
}
