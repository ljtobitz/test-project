using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuHandler : MonoBehaviour
{
    [SerializeField] private GameObject blockButton;
    [SerializeField] private GameObject warning;
    [SerializeField] private GameObject vayMainMenuPrefab;
    [SerializeField] private GameObject botMainMenuPrefab;
    [SerializeField] private Transform myCharacterImage;
    public string mySelectedCharacterName;

    // Start is called before the first frame update
    void Start()
    {
        if (ES3.KeyExists("My character"))
        {
            mySelectedCharacterName = ES3.Load<string>("My character");

            if (mySelectedCharacterName == "")
            {
                blockButton.SetActive(true);
                warning.SetActive(true);
            }
            else
            {
                if (mySelectedCharacterName == "Vay")
                {
                    Instantiate(vayMainMenuPrefab, myCharacterImage);
                }
                else if (mySelectedCharacterName == "Bot")
                {
                    Instantiate(botMainMenuPrefab, myCharacterImage);
                }
            }
        }
        else
        {
            blockButton.SetActive(true);
            warning.SetActive(true);
        }

        Debug.Log(ES3.Load<string>("My character"));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
