using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UKLanguageHandler : MonoBehaviour
{
    private int status;

    [SerializeField]
    public Sprite[] buttonSprites;
    private string[] texts;
    private string[] buttonTexts;
    public Text welcomeMessageText;
    public Text buttonText;
    public Sprite grImage;
    public Sprite ukImage;
    public Image buttonImage;

    void Start()
    {
        status = 0;
        buttonSprites = new Sprite[2];
        //when we display the greek text, we want the english flag! etc.
        buttonSprites[0] = ukImage;
        buttonSprites[1] = grImage;
        texts = new string[2];
        texts[0] = "Καλώς ήρθατε στην εφαρμογή Foodiscovery! Μπορείτε είτε να πατήσετε μια περιφεριακή ενότητα για να δείτε τις συνταγές τις, είτε να πατήσετε το πλήκτρο αναζήτησης στην πάνω δεξιά γωνία κάτω απο την σημαία!";
        texts[1] = "Welcome to Foodiscovery app! You can either press on a region on the map to view it's recipes, or press on the search button at the upper right corner under the flag";
        buttonTexts = new string[2];
        buttonTexts[0] = "Εντάξει!";
        buttonTexts[1] = "Okay!";
        buttonImage = GetComponent<Button>().image;
        buttonImage.sprite = buttonSprites[status];
        welcomeMessageText.text = texts[status];
        buttonText.text = buttonTexts[status];
        status = 1;
    }

    public void TaskOnClick()
    {
        Debug.Log("flag was pressed");
        buttonImage.sprite = buttonSprites[status];
        welcomeMessageText.text = texts[status];
        buttonText.text = buttonTexts[status];
        status = 1 - status;
    }
}
