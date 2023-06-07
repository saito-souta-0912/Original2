using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class OdaiController : MonoBehaviour
{
     public Text[] odai;
     public Text[] choicesLeft;
     public Text[] choicesUp;
     public Text[] choicesRight;
     public GameObject title;
     public GameObject UnCollectGameObject;
     public GameObject FifthCollectGameObject;
     public Slider hpSlider;
     public Text hpText;
     

     int odaiNumber = 0;
     int choiceLeftNumber = 0;
     int choiceUpNumber = 0;
     int choiceRightNumber = 0;
     [SerializeField]string[] colorString = {"#FF0000","#0000FF","#00FF00","#000000","#FFFF00"};
     int colorNumber = 0;
     public Text skipText;
     public static int scoreRecordNumber = 0;
     int titleScore = 0;
     public Text scoreText;

     public Text timeCounterText;
     float timeCount;
     int changeRecorder = 0;
     int playerHp;
     int collectNumber = 0;


     [SerializeField] private AudioSource a;//AudioSource�^�̕ϐ�a��錾 �g�p����AudioSource�R���|�[�l���g���A�^�b�`�K�v

     [SerializeField] private AudioClip b1;//AudioClip�^�̕ϐ�b1��錾 �g�p����AudioClip���A�^�b�`�K�v
     [SerializeField] private AudioClip b2;//AudioClip�^�̕ϐ�b2��錾 �g�p����AudioClip���A�^�b�`�K�v 
     [SerializeField] private AudioClip b3;//AudioClip�^�̕ϐ�b3��錾 �g�p����AudioClip���A�^�b�`�K�v 

     [SerializeField] private AudioClip c1;

     
     
     

    

    // Start is called before the first frame update
    void Start()
    {
        this.title.SetActive(false);
        skipText.gameObject.SetActive(true);
        
        ChoiceChanger();
        OdaiChanger();
        timeCount = 7.0f;
        playerHp = 3;
        hpSlider.value = 3;

        scoreText.text = "Score:" + titleScore.ToString();
        QuestionSound();
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
            Debug.Log("��");
            if(colorNumber == choiceLeftNumber)
            {
                OdaiChanger();
                ChoiceChanger();
                changeRecorder++;
                collectNumber++;
                ScoreControll();

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

                Invoke("QuestionSound",0.1f);
            }
            else
            {
                playerHp--;
                Debug.Log(playerHp);
                hpSlider.value--;
                UnCollectSound();
                if(playerHp <= 0)
                {
                   timeCount�@= 10000f;
                    naichilab.RankingLoader.Instance.SendScoreAndShowRanking (scoreRecordNumber);
                }
            }

            
            
        }

        if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            Debug.Log("��");
            if(colorNumber == choiceUpNumber)
            {
                OdaiChanger();
                ChoiceChanger();
                changeRecorder++;

                
                collectNumber++;
                ScoreControll();
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

                Invoke("QuestionSound",0.1f);
            }
            else
            {
                playerHp--;
                hpSlider.value--;
                Debug.Log(playerHp);
                UnCollectSound();
                
                if(playerHp <= 0)
                {
                    timeCount�@= 10000f;
                    naichilab.RankingLoader.Instance.SendScoreAndShowRanking (scoreRecordNumber);
                }
            }

           
        }

        if(Input.GetKeyDown(KeyCode.RightArrow))
        {
            Debug.Log("�E");
            if(colorNumber == choiceRightNumber)
            {
                OdaiChanger();
                ChoiceChanger();
                changeRecorder++;
                
                collectNumber++;
                ScoreControll();
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

                Invoke("QuestionSound",0.1f);
            }
            else
            {
                playerHp--;
                hpSlider.value--;
                Debug.Log(playerHp);
                UnCollectSound();
                if(playerHp <= 0)
                {
                    timeCount�@= 10000f;
                    naichilab.RankingLoader.Instance.SendScoreAndShowRanking (scoreRecordNumber);
                }
            }

            
        }

        if(Input.GetKeyDown(KeyCode.DownArrow))
        {
            Debug.Log("��");
            
            if(colorNumber != choiceLeftNumber && colorNumber != choiceUpNumber && colorNumber != choiceRightNumber)
            {
                OdaiChanger();
                ChoiceChanger();
                changeRecorder++;
                
                collectNumber++;
                ScoreControll();
                
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

                Invoke("QuestionSound",0.1f);
            }
            else
            {
                //UnCollectGameObject = GameObject.FindGameObjectWithTag("UnCollect");
                //UnCollectGameObject.SendMessage("UnCollectSound");
                UnCollectSound();
                playerHp--;
                hpSlider.value--;
                Debug.Log(playerHp);
                if(playerHp <= 0)
                {
                    timeCount�@= 10000f;
                    naichilab.RankingLoader.Instance.SendScoreAndShowRanking (scoreRecordNumber);
                }
            }

            
        }

        if(timeCount <= 0.0f)
        {
            Debug.Log("���Ԑ؂�A���̖���");
            playerHp--;
            Debug.Log(playerHp);
            if(playerHp <= 0)
                {
                    timeCount�@= 10000f;
                    naichilab.RankingLoader.Instance.SendScoreAndShowRanking (scoreRecordNumber);
                }

            UnCollectSound();
            OdaiChanger();
            ChoiceChanger();
            Invoke("QuestionSound",0.1f);
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

   void QuestionSound()
   {
       a.PlayOneShot(c1);
   }

   

   public void ScoreControll()
   {
       if(collectNumber <= 10)
       {
           scoreRecordNumber += 10 * collectNumber * (int)timeCount;
           scoreText.text = "Score:" + scoreRecordNumber.ToString();
       }
       else if(collectNumber <= 17)
       {
           scoreRecordNumber += 50 * collectNumber * (int)timeCount;
           scoreText.text = "Score:" + scoreRecordNumber.ToString();
       }
       else if(collectNumber <= 22)
       {
           scoreRecordNumber += 500 * collectNumber * (int)timeCount;
           scoreText.text = "Score:" + scoreRecordNumber.ToString();
       }
       else if(collectNumber <= 27)
       {
           scoreRecordNumber += 1000 * collectNumber * (int)timeCount;
           scoreText.text = "Score:" + scoreRecordNumber.ToString();
       }
       
   }

    
}

