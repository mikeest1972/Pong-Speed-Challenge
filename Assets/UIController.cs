using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    public Text pLabel;
    public Text eLabel;
    public GameObject gameOverLable;
    public GameObject wonLabel;
    // Start is called before the first frame update
    void Start()
    {
        gameOverLable.SetActive(false);
        wonLabel.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }
    public void gameOverProtocal()
    {
        gameOverLable.SetActive(true);
        wonLabel.SetActive(false);
    }
    public void wonProtocal()
    {
        gameOverLable.SetActive(false);
        wonLabel.SetActive(true);
    }
    public void updateScoreLabled(int pScore, int eScore)
    {
        pLabel.text = pScore.ToString();
        eLabel.text = eScore.ToString();

    }
}
