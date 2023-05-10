using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generador : MonoBehaviour
{
    public GameObject prefab;
    public int n;

    // Start is called before the first frame update
    void Start()
    {
        for (int k =0; k<n; ) 
        {
            float y = transform.position.y + transform.localScale.y / 2;
            float x = transform.position.x + Random.Range(-transform.localScale.x / 2, transform.localScale.x / 2);
            float z = transform.position.z + Random.Range(-transform.localScale.z / 2, transform.localScale.z / 2);
            Vector3 from = new Vector3(x, y, z);
            RaycastHit hit;
            if (Physics.Raycast(from, -Vector3.up, out hit)) {
                Instantiate(prefab, hit.point + new Vector3(0.0f, -0.001f, 0.0f), prefab.transform.rotation);
                k = k + 1;
            }
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
