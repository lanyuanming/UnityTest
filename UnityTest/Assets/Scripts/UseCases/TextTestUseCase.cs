using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextTestUseCase : MonoBehaviour
{

    [SerializeField]
    private Text _text;

    // Start is called before the first frame update
    void Start()
    {
        _text.text = "1234124135";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
