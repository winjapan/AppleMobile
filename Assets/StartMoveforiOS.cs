using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartMoveforiOS : MonoBehaviour
{
    public Image StartPanel;
    public Image TutorialPanel;
    public Text CountDown;
    public Text Countchest;
    public Text Countpirate;
    public Image join;
    public Button Attack;
    public int countTime;
    // Start is called before the first frame update
    void Start()
    {
        countTime = 3;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnButtonClicked()
    {
        StartCoroutine(MethodTutorial());
        StartPanel.gameObject.SetActive(false);
        TutorialPanel.gameObject.SetActive(true);
    }

    IEnumerator MethodTutorial()
    {

        countTime = 3;
        CountDown.text = countTime.ToString();
        yield return new WaitForSeconds(1f);
        countTime = 2;
        CountDown.text = countTime.ToString();
        yield return new WaitForSeconds(1f);
        countTime = 1;
        CountDown.text = countTime.ToString();
        yield return new WaitForSeconds(1f);
        CountDown.text = "Good Luck!".ToString();
        yield return new WaitForSeconds(1f);
        CountDown.gameObject.SetActive(false);
        TutorialPanel.gameObject.SetActive(false);
        Countchest.gameObject.SetActive(true);
        Countpirate.gameObject.SetActive(true);
        Attack.gameObject.SetActive(true);
        join.gameObject.SetActive(true);
        GameObject.Find("Main Camera").GetComponent<AudioSource>().enabled = true;
        GameObject.Find("Player").GetComponent<PlayerControllerforiOS>().enabled = true;
    }
}
