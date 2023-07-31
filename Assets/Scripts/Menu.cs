using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public GameObject LevelMenu;
    public GameObject StartMenu;
    public GameOver GameOver;

    public Color on;
    public Color off;

    public Image level2_image;
    public Button level2_button;

    public Image level3_image;
    public Button level3_button;

    public Image level4_image;
    public Button level4_button;

    public Image level5_image;
    public Button level5_button;

    public Image level6_image;
    public Button level6_button;

    public Image level7_image;
    public Button level7_button;

    public Image level8_image;
    public Button level8_button;

    public void play(){
        LevelMenu.SetActive(true);
        StartMenu.SetActive(false);
    }

    public void X(){
        LevelMenu.SetActive(false);
        StartMenu.SetActive(true);
    }

    public void Quit(){
        Application.Quit();
    }

    public void level1(){
        SceneManager.LoadScene("level 1");
    }

    public void level2(){
        SceneManager.LoadScene("level 2");
    }

    public void level3(){
        SceneManager.LoadScene("level 3");
    }

    public void level4(){
        SceneManager.LoadScene("level 4");
    }

    public void level5(){
        SceneManager.LoadScene("level 5");
    }

    public void level6(){
        SceneManager.LoadScene("level 6");
    }

    public void level7(){
        SceneManager.LoadScene("level 7");
    }

    public void level8(){
        SceneManager.LoadScene("level 8");
    }

    public void Update() {
        if(GameOver.resolt_level2 == 0){
            level2_image.color = off;
            level2_button.enabled = false;
        }
        else if(GameOver.resolt_level2 == 1){
            level2_image.color = on;
            level2_button.enabled = true;
        }

        if(GameOver.resolt_level3 == 0){
            level3_image.color = off;
            level3_button.enabled = false;
        }
        else if(GameOver.resolt_level3 == 1){
            level3_image.color = on;
            level3_button.enabled = true;
        }

        if(GameOver.resolt_level4 == 0){
            level4_image.color = off;
            level4_button.enabled = false;
        }
        else if(GameOver.resolt_level4 == 1){
            level4_image.color = on;
            level4_button.enabled = true;
        }

        if(GameOver.resolt_level5 == 0){
            level5_image.color = off;
            level5_button.enabled = false;
        }
        else if(GameOver.resolt_level5 == 1){
            level5_image.color = on;
            level5_button.enabled = true;
        }

        if(GameOver.resolt_level6 == 0){
            level6_image.color = off;
            level6_button.enabled = false;
        }
        else if(GameOver.resolt_level6 == 1){
            level6_image.color = on;
            level6_button.enabled = true;
        }

        if(GameOver.resolt_level7 == 0){
            level7_image.color = off;
            level7_button.enabled = false;
        }
        else if(GameOver.resolt_level7 == 1){
            level7_image.color = on;
            level7_button.enabled = true;
        }

        if(GameOver.resolt_level8 == 0){
            level8_image.color = off;
            level8_button.enabled = false;
        }
        else if(GameOver.resolt_level8 == 1){
            level8_image.color = on;
            level8_button.enabled = true;
        }
    }
}
