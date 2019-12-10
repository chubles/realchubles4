using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.GameCenter;

public class DamageModel : MonoBehaviour
{
    public GameObject damagedModel;
    public GameObject newChubles; 
    

    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            Instantiate(damagedModel, transform.position, transform.rotation);
            Destroy(damagedModel);

        }
        else
        {
            Instantiate(newChubles, transform.position, transform.rotation);
            Destroy();
        }
        
    }
}
