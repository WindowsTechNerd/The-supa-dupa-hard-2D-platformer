using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class FunctionManagerScript : MonoBehaviour
{
    
    public int coins = 0;
    public GameObject text;
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void respawn()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void mainmenu()
    {
        SceneManager.LoadScene(0);
    }

    public void play()
    {
        if (PlayerPrefs.HasKey("Level"))
        {
            SceneManager.LoadScene(PlayerPrefs.GetInt("Level"));
        }
        else
        {
            SceneManager.LoadScene(1);
            setLevel(1);
        }
    }

    public void quit()
    {
        Application.Quit();
    }

    public void setLevel(int level)
    {
        PlayerPrefs.SetInt("Level", level);
    }

    public void setCoins(int number)
    {
        PlayerPrefs.SetInt("Coins", number);
    }

    public void saveData()
    {
        PlayerPrefs.Save();
    }

    public void nextLevel()
    {
        int level = SceneManager.GetActiveScene().buildIndex + 1;
        setLevel(level);
        SceneManager.LoadScene(level);
    }

    public void addCoins(int number)
    {
        coins += number;
        setCoins(coins);
        saveData();
        updateCoins(coins);
    }

    public void updateCoins(int number)
    {
        text.GetComponent<TextMeshProUGUI>().text = number.ToString();
    }
}
