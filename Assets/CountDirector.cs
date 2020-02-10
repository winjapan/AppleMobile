using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDirector : MonoBehaviour
{
    public int chestCount;
    public int pirateCount;
   
    // Start is called before the first frame update
    private int scoreCount;
    public Text chest;
    public Text pirate;
    public GameObject Aura;
    public GameObject Door;
    public GameObject chest3;
    public Text Hint;
    public Text Hint2;
    public void ColBox()
    {
        chestCount+= 1;
        
        if (chestCount == 3)
        {
            Door.SetActive(false);
            Aura.SetActive(true);
            Hint2.gameObject.SetActive(true);
            Hint.gameObject.SetActive(false);
        }
    }

    public void KillPirate()
    {
        pirateCount += 1;

        if (pirateCount == 3)
        {
            chest3.SetActive(true);
            Hint.gameObject.SetActive(true);
        }
    }
    // Update is called once per frame
    void Update()
    {
      chest.GetComponent<Text>().text = "chest"+chestCount+"/3".ToString();
        pirate.GetComponent<Text>().text = "pirate"+pirateCount + "/3".ToString();
    }

}
