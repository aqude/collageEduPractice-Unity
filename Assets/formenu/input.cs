using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class input : MonoBehaviour
{
    [SerializeField] private GameObject PanelName;
    [SerializeField] private InputField InputName;
    [SerializeField] private Text TextName;
    [SerializeField] private string Name;

    public void Start()
    {
        if(!PlayerPrefs.HasKey("name"))
        {
            PlayerPrefs.SetString("name", Name);
        }
        else
        {
            PlayerPrefs.GetString("name");
        }
    }
    public void Setname()
    {
        if(InputName.text == "")
        {
            Debug.Log("ќшибка");
        }
        else
        {
            PanelName.SetActive(false);
            TextName.text += " " + InputName.text;
            Name = InputName.text;
            Debug.Log("”пешно");
        }
    }
    private void OnApplicationQuit()
    {
        PlayerPrefs.SetString("name", Name);
    }
}
