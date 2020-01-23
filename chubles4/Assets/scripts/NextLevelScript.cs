using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevelScript : MonoBehaviour
{
    private bool nextLevel = false;
    [SerializeField] private GameManager _gameManager;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")){
            print("portal");
            nextLevel = true;
            _gameManager.LevelAdvance(nextLevel);
        }
    }
}
