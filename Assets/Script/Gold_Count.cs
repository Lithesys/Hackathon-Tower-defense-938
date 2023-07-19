using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Gold_Count : MonoBehaviour
{
    public TMP_Text Gold;
    public int gold = 200;
    // Start is called before the first frame update
    void Start()
    {
        Gold.text = gold.ToString("0");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
