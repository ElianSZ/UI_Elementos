using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManagerMenu : MonoBehaviour
{
    public static UIManagerMenu sharedInstance;
    public TMP_InputField InputField;

    private void Awake()
    {
        if (sharedInstance == null)
        {
            sharedInstance = this;
        }

        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        string existingUserName = PlayerPrefs.GetString("USER_NAME");

        if (existingUserName != "")
        {
            InputField.placeholder.GetComponent<TextMeshProUGUI>().text = existingUserName;
        }
    }

    public void SaveUserName()
    {
        if (userName == "")
        {
            DataPersistence.sharedInstance.userName = InputField.placeholder.GetComponent<TextMeshProUGUI>().text;
        }

        else
        {
            DataPersistence.sharedInstance.userName = userName;
        }

        PlayerPrefs.SetString("USER_NAME", DataPersistence.sharedInstance.userName);
    }
}
