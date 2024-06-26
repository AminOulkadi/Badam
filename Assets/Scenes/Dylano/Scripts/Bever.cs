using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;

public class Bever : MonoBehaviour
{
    public int value;


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
            BeverCount.Instance.IncreasePoints(value);
        }
    }



}
