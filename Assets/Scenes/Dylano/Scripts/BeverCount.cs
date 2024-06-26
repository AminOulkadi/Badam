using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BeverCount : MonoBehaviour
{
    public static BeverCount Instance;

    public TMP_Text coinText;
    public int currentCoins = 0;

    private void Awake()
    {
        Instance = this; 
    }
    // Start is called before the first frame update
    void Start()
    {
        coinText.text = ":" + currentCoins.ToString();
    }

    public void IncreasePoints (int v)
    {
        currentCoins += v;
        coinText.text = ":" + currentCoins.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
