using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;


public class text_trigger : MonoBehaviour
{
    public string mensaje;
    public float duracion;
    public Text MessageBox;
    
    public IEnumerator ClearMessageBox()
    {
        yield return new WaitForSeconds(duracion);
        MessageBox.text = "";
        Destroy(this.gameObject);
    }
    
    private void OnTriggerEnter (Collider other)
    {
        if (other.CompareTag("Player"))
        {
            MessageBox.text = mensaje;
            StartCoroutine(ClearMessageBox());
            
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        MessageBox = GameObject.Find("MessageBox").GetComponent<Text>();
            
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
