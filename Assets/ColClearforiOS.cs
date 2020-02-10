using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ColClearforiOS : MonoBehaviour
{
    public Image join;
    public Button Attack;
    public Text ClearText;
    public Text Hint;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            ClearText.gameObject.SetActive(true);
            join.gameObject.SetActive(false);
            Attack.gameObject.SetActive(false);
            Hint.gameObject.SetActive(false);
            Invoke("Clear", 2);
        }
    }

    void Clear()
    {
        SceneManager.LoadScene("PirateScene for iOS");
    }
}
