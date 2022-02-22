using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SayHello : MonoBehaviour
{
    private TextMeshProUGUI holaText;

    private void Awake()
    {
        holaText = GetComponent<TextMeshProUGUI>();
    }

    // Start is called before the first frame update
    void Start()
    {
        holaText.text = $"¡Hola, (DataPersistence.sharedInstance.userName)!";
    }
}
