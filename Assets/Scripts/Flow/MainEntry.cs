using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainEntry : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameFlow.Instance.SampleFunc();
        GameFlow.Instance.SampleFunc();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
