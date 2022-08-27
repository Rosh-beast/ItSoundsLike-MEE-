
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    
    public float health;
    // Start is called before the first frame update
    void Start()
    {
        //health = 3f;
    }

    // Update is called once per frame
    void Update()
    {
        if (health == 0)
        {
            Destroy(gameObject);
            
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "enemy") 
        {
            Debug.Log("collided");
            DeductHealth();
            
        }
    }
    public void DeductHealth()
    {
        health--;
    }
}
