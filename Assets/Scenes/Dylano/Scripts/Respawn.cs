using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    [SerializeField] private Transform Bever;
    [SerializeField] private Transform Bever1;
    [SerializeField] private Transform Bever2;
    [SerializeField] private Transform Bever3;
    [SerializeField] private Transform Bever4;
    [SerializeField] private Transform Spawn;

    void OnTriggerEnter(Collider other)
    {
        Bever.transform.position = Spawn.transform.position;
        Bever1.transform.position = Spawn.transform.position;
        Bever2.transform.position = Spawn.transform.position;
        Bever3.transform.position = Spawn.transform.position;
        Bever4.transform.position = Spawn.transform.position;
    }
}
