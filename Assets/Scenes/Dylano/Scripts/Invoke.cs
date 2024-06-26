using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Invoke : MonoBehaviour
{
    void Start()
    {
        RestartGameInvoke();
    }

    void RestartGameInvoke()
    {
        CancelInvoke();
        Invoke("RestartGame", 10);
    }
    void RestartGame()
    {
        //
    }
}
