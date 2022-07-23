using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ReadInput : MonoBehaviour
{
    public InputField inputFiledName;
    public Text infoText;
    private string currentPlayerName;
    // Start is called before the first frame update
    void Start()
    {
        infoText.text = $"Best Score: {PlayerPrefs.GetInt(GameConst.HIGHT_SCORE, 0)}, Name: {PlayerPrefs.GetString(GameConst.PLAYER_HIGHT_SCORE, "")}";
        inputFiledName.text = $"{PlayerPrefs.GetString(GameConst.CURRENT_PLAYER_NAME, "")}";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SetTextWhenEnd()
    {
        currentPlayerName = inputFiledName.text;
        PlayerPrefs.SetString(GameConst.CURRENT_PLAYER_NAME, currentPlayerName);
    }
    public void LoadScene()
    {
        SceneManager.LoadScene(1);
    }
    public void ClearSave()
    {
        PlayerPrefs.DeleteAll();
        SceneManager.LoadScene(0);
    }
}
