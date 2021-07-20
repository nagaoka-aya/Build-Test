using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextView : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Environment environment = EnvironmentConfig.GetEnvironment();
        GetComponent<Text>().text = environment.type;
    }

}

