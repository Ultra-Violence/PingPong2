using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public Score_script score;
    public ColliderBall ColliderBall;
    public GameObject GameOver_HUD;
    public Text GameOver_text;

    public static int resolt_level2;
    public static int resolt_level3;
    public static int resolt_level4;
    public static int resolt_level5;
    public static int resolt_level6;
    public static int resolt_level7;
    public static int resolt_level8;

    public void Update()
    {   

        if(SceneManager.GetActiveScene().buildIndex > 0 ){
            if(GameOver_HUD.activeInHierarchy == true)
                Time.timeScale = 0;
            else{
                Time.timeScale = 1;
        }
        }

        if(Input.GetKeyDown(KeyCode.Escape) & SceneManager.GetActiveScene().buildIndex > 0 ){
            GameOver_HUD.SetActive(!GameOver_HUD.activeInHierarchy);
        }
        
        resolt_level2 = PlayerPrefs.GetInt("Score2_save");
        resolt_level3 = PlayerPrefs.GetInt("Score3_save");
        resolt_level4 = PlayerPrefs.GetInt("Score4_save");
        resolt_level5 = PlayerPrefs.GetInt("Score5_save");
        resolt_level6 = PlayerPrefs.GetInt("Score6_save");
        resolt_level7 = PlayerPrefs.GetInt("Score7_save");
        resolt_level8 = PlayerPrefs.GetInt("Score8_save");

        if(SceneManager.GetActiveScene().buildIndex == 1){
            if(score.score == 36 | ColliderBall.inGame == false){
                GameOver_HUD.SetActive(true);
                if(score.score == 36 ){
                    GameOver_text.text = "Victory";
                    PlayerPrefs.SetInt("Score2_save", 1);
                }
                else if(ColliderBall.inGame == false){
                    GameOver_text.text = "Game Over";
                }
            }
            }

        else if(SceneManager.GetActiveScene().buildIndex == 2){
            if(score.score == 56 | ColliderBall.inGame == false){
                GameOver_HUD.SetActive(true);
                if(score.score == 56){
                    GameOver_text.text = "Victory";
                    PlayerPrefs.SetInt("Score3_save", 1);
                }
                else if(ColliderBall.inGame == false){
                    GameOver_text.text = "Game Over";
                }
            }
            }
        else if(SceneManager.GetActiveScene().buildIndex == 3){
            if(score.score == 64 | ColliderBall.inGame == false){
                GameOver_HUD.SetActive(true);
                if(score.score == 64){
                    GameOver_text.text = "Victory";
                    PlayerPrefs.SetInt("Score4_save", 1);
                }
                else if(ColliderBall.inGame == false){
                    GameOver_text.text = "Game Over";
                }
            }
            }
        else if(SceneManager.GetActiveScene().buildIndex == 4){
            if(score.score == 48 | ColliderBall.inGame == false){
                GameOver_HUD.SetActive(true);
                if(score.score == 48){
                    GameOver_text.text = "Victory";
                    PlayerPrefs.SetInt("Score5_save", 1);
                }
                else if(ColliderBall.inGame == false){
                    GameOver_text.text = "Game Over";
                }
            }
            }
        else if(SceneManager.GetActiveScene().buildIndex == 5){
            if(score.score == 72 | ColliderBall.inGame == false){
                GameOver_HUD.SetActive(true);
                if(score.score == 72){
                    GameOver_text.text = "Victory";
                    PlayerPrefs.SetInt("Score6_save", 1);
                }
                else if(ColliderBall.inGame == false){
                    GameOver_text.text = "Game Over";
                }
            }
            }
        else if(SceneManager.GetActiveScene().buildIndex == 6){
            if(score.score == 64 | ColliderBall.inGame == false){
                GameOver_HUD.SetActive(true);
                if(score.score == 64){
                    GameOver_text.text = "Victory";
                    PlayerPrefs.SetInt("Score7_save", 1);
                }
                else if(ColliderBall.inGame == false){
                    GameOver_text.text = "Game Over";
                }
            }
            }
        else if(SceneManager.GetActiveScene().buildIndex == 7){
            if(score.score == 48 | ColliderBall.inGame == false){
                GameOver_HUD.SetActive(true);
                if(score.score == 48){
                    GameOver_text.text = "Victory";
                    PlayerPrefs.SetInt("Score8_save", 1);
                }
                else if(ColliderBall.inGame == false){
                    GameOver_text.text = "Game Over";
                }
            }
            }
        else if(SceneManager.GetActiveScene().buildIndex == 8){
            if(score.score == 74 | ColliderBall.inGame == false){
                GameOver_HUD.SetActive(true);
                if(score.score == 74){
                    GameOver_text.text = "Victory";
                }
                else if(ColliderBall.inGame == false){
                    GameOver_text.text = "Game Over";
                }
            }
            }
    }

    public void retry(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        GameOver_HUD.SetActive(false);
    }

    public void next(){
        if(SceneManager.GetActiveScene().buildIndex == 1 & resolt_level2 == 1){
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
            GameOver_HUD.SetActive(false);
            }
        else if(SceneManager.GetActiveScene().buildIndex == 2 & resolt_level3 == 1){
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
            GameOver_HUD.SetActive(false);
            }
        else if(SceneManager.GetActiveScene().buildIndex == 3 & resolt_level4 == 1){
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
            GameOver_HUD.SetActive(false);
            }
        else if(SceneManager.GetActiveScene().buildIndex == 4 & resolt_level5 == 1){
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
            GameOver_HUD.SetActive(false);
            }
        else if(SceneManager.GetActiveScene().buildIndex == 5 & resolt_level6 == 1){
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
            GameOver_HUD.SetActive(false);
            }
        else if(SceneManager.GetActiveScene().buildIndex == 6 & resolt_level7 == 1){
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
            GameOver_HUD.SetActive(false);
            }
        else if(SceneManager.GetActiveScene().buildIndex == 7 & resolt_level8 == 1){
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
            GameOver_HUD.SetActive(false);
            }
    }

    public void LevelMenu(){
        SceneManager.LoadScene(0);
    }
}
