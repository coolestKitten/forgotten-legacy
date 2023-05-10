using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class playerInteractions : MonoBehaviour
{
    public float health = 0.5f;
    public float ammo = 0.11f;
    public GameObject collectFXfirstaid;
    public GameObject collectFXammo;
    public Image healthB;
    public Image ammoB;

    void playerDie()
    {
        SceneManager.LoadScene("gameover");
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("firstaid"))
        {
            health = health + 0.1f;
            Instantiate(collectFXfirstaid, other.transform.position, other.transform.rotation);
            Destroy(other.gameObject);
        }
        if (other.CompareTag("ammo"))
        {
            ammo = ammo + 0.11f;
            ammoB.fillAmount = ammo;
            Instantiate(collectFXammo, other.transform.position, other.transform.rotation);
            Destroy(other.gameObject);
        }
        if (other.CompareTag("gunbasic"))
        {
            Instantiate(collectFXammo, other.transform.position, other.transform.rotation);
            Destroy(other.gameObject);
            transform.Find("Gun").gameObject.SetActive(true);
        }

        if (other.CompareTag("battlebot"))
        {
            health = health - 0.05f;
            
    }


        

    }


    // Start is called before the first frame update
    void Start()
    {

        healthB = GameObject.Find("healthB").GetComponent<Image>();
        ammoB = GameObject.Find("ammoB").GetComponent<Image>(); // <------------ 3


        if (Input.GetKeyDown(KeyCode.T))
        {
            Vector3 p = transform.position + new Vector3(Random.Range(-5, 5), Random.Range(0, 10), Random.Range(-5, 5));
            Instantiate(collectFXammo, p, transform.rotation);
        }

    }

    // Update is called once per frame
    void Update()
    {
        healthB.fillAmount = Mathf.Lerp(healthB.fillAmount, health, 0.5f);


        if (health <= 0f)
        {
            playerDie();
        }
    }

    


}



