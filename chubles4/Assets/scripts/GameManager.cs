using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameManager : MonoBehaviour
{
    public int currentCake;
    public Text cakeText; 
        
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {



    }
    
    public void AddCake(int cakeToAdd)
    {
        currentCake += cakeToAdd;
        cakeText.text = "Cake score" + currentCake;
    }
}
