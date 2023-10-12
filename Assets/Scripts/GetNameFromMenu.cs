using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetNameFromMenu : MonoBehaviour
{
    public string currName;
    // Start is called before the first frame update
    void Start()
    {
        MenuUIHandler.nameSetter.nameInputText = GetComponent<Text>();
        currName = MenuUIHandler.nameSetter.theName;
        GetComponent<Text>().text = "Current Player: " + currName;
    }


}
