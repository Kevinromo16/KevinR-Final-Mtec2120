using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCollect : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        ScoreManager.scoreCount += 1;
    }
}
