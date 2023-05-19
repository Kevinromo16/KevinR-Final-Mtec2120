using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCoinScript : MonoBehaviour
{
    public GameObject coinPrefab;
   
    // Update is called once per frame
    void Update()
    {
     if (Input.GetKeyDown(KeyCode.Space))
        {
           Vector3 randomPosition = new Vector3(Random.Range(190, 250), 1, Random.Range(350, 450));
            Instantiate(coinPrefab, randomPosition, Quaternion.identity); 
        }
 
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Vector3 randomPosition = new Vector3(Random.Range(190, 250), 1, Random.Range(350, 450));
            Instantiate(coinPrefab, randomPosition, Quaternion.identity);
        }
        
    }
}
