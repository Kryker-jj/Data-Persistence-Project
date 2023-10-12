using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.IO;

public class MenuUIHandler : MonoBehaviour
{
    public Text nameInputText;
    public Text titleText;
    public string theName;
    public static MenuUIHandler nameSetter;

    // Start is called before the first frame update
    public void Awake()
    {
        if(nameSetter == null)
        {
            nameSetter = this;
        }
        else
        {
            Destroy(this);
        }

        DontDestroyOnLoad(this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoadGame()
    {
        if(nameInputText.text != "")
        {
            theName = nameInputText.text;
            SceneManager.LoadScene(1);
        }
        else
        {
            titleText.text = "Enter your name :)";
        }
    }


}
