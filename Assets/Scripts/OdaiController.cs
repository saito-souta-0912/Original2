using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OdaiController : MonoBehaviour
{
     public Text[] odai;
     public Text[] choicesLeft;
     public Text[] choicesUp;
     public Text[] choicesRight;
     public GameObject title;
     public GameObject UnCollectGameObject;
     public GameObject FifthCollectGameObject;
     int odaiNumber = 0;
     int choiceLeftNumber = 0;
     int choiceUpNumber = 0;
     int choiceRightNumber = 0;
     [SerializeField]string[] colorString = {"#FF0000","#0000FF","#00FF00","#000000","#FFFF00"};
     int colorNumber = 0;
     public Text skipText;

     public Text timeCounterText;
     float timeCount;
     int changeRecorder = 0;
     int playerHp;
     int collectNumber = 0;

     [SerializeField] private AudioSource a;//AudioSource型の変数aを宣言 使用するAudioSourceコンポーネントをアタッチ必要

     [SerializeField] private AudioClip b1;//AudioClip型の変数b1を宣言 使用するAudioClipをアタッチ必要
     [SerializeField] private AudioClip b2;//AudioClip型の変数b2を宣言 使用するAudioClipをアタッチ必要 
     [SerializeField] private AudioClip b3;//AudioClip型の変数b3を宣言 使用するAudioClipをアタッチ必要 


     
     
     

    

    // Start is called before the first frame update
    void Start()
    {
        this.title.SetActive(false);
        skipText.gameObject.SetActive(true);
        ChoiceChanger();
        OdaiChanger();
        timeCount = 7.0f;
        playerHp = 3;
        //odaiNumber = Random.Range(0,5);
        //Text a = odai[odaiNumber];
        //colorNumber = Random.Range(0,5);
        
        //ColorUtility.TryParseHtmlString(colorString[colorNumber], out var tmpColor);
        //a.color = tmpColor;
        //a.gameObject.SetActive(true);
        
    }

    // Update is called once per frame
    void Update()
    {
        timeCount -= Time.deltaTime;
        timeCounterText.text = "Time:" + timeCount.ToString("f1");

        if(Input.GetKeyDown(KeyCode.LeftArrow))
        {
            Debug.Log("左");
            if(colorNumber == choiceLeftNumber)
            {
                OdaiChanger();
                ChoiceChanger();
                changeRecorder++;
                collectNumber++;
                if(collectNumber % 5 ==0 && collectNumber != 0)
                {
                     FifthCollectSound();
                }
                else
                {
                    CollectSound();
                }

                
                //if(collectNumber % 5 == 0 && collectNumber != 0)
                //{
                   // GameObject objectA = GameObject.FindGameObjectWithTag("FifthCollect");
                   // objectA.SendMessage("FifthCollect");
               // }
                if(changeRecorder <= 10)
                {
                    timeCount = 7.0f;
                }
                else if(changeRecorder <= 17)
                {
                    timeCount = 5.0f;
                }
                else if(changeRecorder <= 22)
                {
                    timeCount = 3.0f;
                }
                else if(changeRecorder <= 25)
                {
                    timeCount = 2.5f;
                }
                else
                {
                    timeCount = 2.0f;
                }
            }
            else
            {
                playerHp--;
                Debug.Log(playerHp);
                UnCollectSound();
                if(playerHp <= 0)
                {

                }
            }

            
            
        }

        if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            Debug.Log("上");
            if(colorNumber == choiceUpNumber)
            {
                OdaiChanger();
                ChoiceChanger();
                changeRecorder++;

                
                collectNumber++;
                if(collectNumber % 5 ==0 && collectNumber != 0)
                {
                    FifthCollectSound();
                }
                else
                {
                    CollectSound();
                }

                
                if(changeRecorder <= 10)
                {
                    timeCount = 7.0f;
                }
                else if(changeRecorder <= 17)
                {
                    timeCount = 5.0f;
                }
                else if(changeRecorder <= 22)
                {
                    timeCount = 3.0f;
                }
                else if(changeRecorder <= 25)
                {
                    timeCount = 2.5f;
                }
                else
                {
                    timeCount = 2.0f;
                }

            }
            else
            {
                playerHp--;
                Debug.Log(playerHp);
                UnCollectSound();
                
                if(playerHp <= 0)
                {

                }
            }

           
        }

        if(Input.GetKeyDown(KeyCode.RightArrow))
        {
            Debug.Log("右");
            if(colorNumber == choiceRightNumber)
            {
                OdaiChanger();
                ChoiceChanger();
                changeRecorder++;
                
                collectNumber++;
                if(collectNumber % 5 ==0 && collectNumber != 0)
                {
                     FifthCollectSound();
                }
                else
                {
                    CollectSound();
                }

                if(changeRecorder <= 10)
                {
                    timeCount = 7.0f;
                }
                else if(changeRecorder <= 17)
                {
                    timeCount = 5.0f;
                }
                else if(changeRecorder <= 22)
                {
                    timeCount = 3.0f;
                }
                else if(changeRecorder <= 25)
                {
                    timeCount = 2.5f;
                }
                else
                {
                    timeCount = 2.0f;
                }
            }
            else
            {
                playerHp--;
                Debug.Log(playerHp);
                UnCollectSound();
                if(playerHp <= 0)
                {

                }
            }

            
        }

        if(Input.GetKeyDown(KeyCode.DownArrow))
        {
            Debug.Log("下");
            
            if(colorNumber != choiceLeftNumber && colorNumber != choiceUpNumber && colorNumber != choiceRightNumber)
            {
                OdaiChanger();
                ChoiceChanger();
                changeRecorder++;
                
                collectNumber++;
                if(collectNumber % 5 ==0 && collectNumber != 0)
                {
                    FifthCollectSound();
                }
                else
                {
                    CollectSound();
                }

                if(changeRecorder <= 10)
                {
                    timeCount = 7.0f;
                }
                else if(changeRecorder <= 17)
                {
                    timeCount = 5.0f;
                }
                else if(changeRecorder <= 22)
                {
                    timeCount = 3.0f;
                }
                else if(changeRecorder <= 25)
                {
                    timeCount = 2.5f;
                }
                else
                {
                    timeCount = 2.0f;
                }

            }
            else
            {
                //UnCollectGameObject = GameObject.FindGameObjectWithTag("UnCollect");
                //UnCollectGameObject.SendMessage("UnCollectSound");
                UnCollectSound();
                playerHp--;
                Debug.Log(playerHp);
                if(playerHp <= 0)
                {

                }
            }

            
        }

        if(timeCount <= 0.0f)
        {
            Debug.Log("時間切れ、次の問題へ");
            playerHp--;
            Debug.Log(playerHp);
            if(playerHp <= 0)
                {

                }

            UnCollectSound();
            OdaiChanger();
            ChoiceChanger();
            if(changeRecorder <= 10)
                {
                    timeCount = 7.0f;
                }
                else if(changeRecorder <= 17)
                {
                    timeCount = 5.0f;
                }
                else if(changeRecorder <= 22)
                {
                    timeCount = 3.0f;
                }
                else if(changeRecorder <= 25)
                {
                    timeCount = 2.5f;
                }
                else
                {
                    timeCount = 2.0f;
                }
        }
    }

   void OdaiChanger()
   {
       Text a = odai[odaiNumber];
       a.gameObject.SetActive(false);
       odaiNumber = Random.Range(0,18);
       a = odai[odaiNumber];
       colorNumber = Random.Range(0,6);
        ColorUtility.TryParseHtmlString(colorString[colorNumber], out var tmpColor);
        a.color = tmpColor;
       a.gameObject.SetActive(true);
   }

   void ChoiceChanger()
   {
       Text b = choicesLeft[choiceLeftNumber];
       Text c = choicesUp[choiceUpNumber];
       Text d = choicesRight[choiceRightNumber];
       b.gameObject.SetActive(false);
       c.gameObject.SetActive(false);
       d.gameObject.SetActive(false);
       choiceLeftNumber = Random.Range(0,6);
       b = choicesLeft[choiceLeftNumber];

       choiceUpNumber = Random.Range(0,6);
       while(choiceUpNumber == choiceLeftNumber)
       {
           choiceUpNumber = Random.Range(0,6);
       }
       c = choicesUp[choiceUpNumber];

       choiceRightNumber = Random.Range(0,6);
       while(choiceRightNumber == choiceUpNumber || choiceRightNumber == choiceLeftNumber )
       {
           choiceRightNumber = Random.Range(0,6);
       }
       d = choicesRight[choiceRightNumber];

       b.gameObject.SetActive(true);
       c.gameObject.SetActive(true);
       d.gameObject.SetActive(true);
       


   }

   

   void CollectSound()
   {
       a.PlayOneShot(b1);
   }

   void FifthCollectSound()
   {
       a.PlayOneShot(b2);
   }

   void UnCollectSound()
   {
       a.PlayOneShot(b3);
   }
}

