using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OdaiController : MonoBehaviour
{
     public Text[] odai;
     public GameObject title;
     int odaiNumber = 0;
     [SerializeField]string[] colorString = {"#FF0000","#0000FF","#00FF00","#000000","#FFFF00"};
     int colorNumber = 0;

     
     
     

    

    // Start is called before the first frame update
    void Start()
    {
        this.title.SetActive(false);
        OdaiChanger();
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
        if(Input.GetKeyDown(KeyCode.LeftArrow))
        {
            OdaiChanger();
        }

        if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            Debug.Log("è„");
            OdaiChanger();
        }

        if(Input.GetKeyDown(KeyCode.RightArrow))
        {
            Debug.Log("âE");
            OdaiChanger();
        }
    }

   void OdaiChanger()
   {
       Text a = odai[odaiNumber];
       a.gameObject.SetActive(false);
       odaiNumber = Random.Range(0,5);
       a = odai[odaiNumber];
       colorNumber = Random.Range(0,5);
        ColorUtility.TryParseHtmlString(colorString[colorNumber], out var tmpColor);
        a.color = tmpColor;
       a.gameObject.SetActive(true);
   }
}
