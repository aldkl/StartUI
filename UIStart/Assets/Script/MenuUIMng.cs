using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuUIMng : MonoBehaviour
{
    public GameObject Logo;
    public GameObject LogoBack;
    public GameObject StartBtn;
    public GameObject one;
    public GameObject oneBack;
    public GameObject Two;
    public GameObject TwoBack;
    public GameObject Thr;
    public GameObject ThrBack;
    public GameObject Start1;
    public GameObject StartBack;
    public Camera MainCamera;

    public Vector3 ThrStartPos;
    public Vector3 TwoStartPos;
    public Vector3 OneStartPos;
    public Color Backcolor;
    int nCount;
    // Start is called before the first frame update
    void Start()
    {
        nCount = 8;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnStertBtn()
    {
        Logo.SetActive(false);
        LogoBack.SetActive(false);
        StartBtn.SetActive(false);
        StartCoroutine("CountDown");
    }
    IEnumerator CountDown()
    {
        while (nCount > 0)
        {
            yield return new WaitForSeconds(0.5f);
            switch(nCount)
            {
                case 1:
                    Vector3 StartSan = Start1.transform.position - StartBack.transform.position;
                    //one.transform.position = ThrStartPos;
                    //oneBack.transform.position = ThrStartPos + OneSan;
                    Start1.transform.localScale = new Vector3(2, 2, 2);
                    StartBack.transform.localScale = new Vector3(2, 2, 2);
                    break;
                case 2:
                    one.SetActive(false);
                    oneBack.SetActive(false);

                    Start1.SetActive(true);
                    StartBack.SetActive(true);
                    break;
                case 3:
                    Vector3 OneSan = one.transform.position - oneBack.transform.position;
                   //one.transform.position = ThrStartPos;
                   //oneBack.transform.position = ThrStartPos + OneSan;
                    one.transform.localScale = new Vector3(2, 2, 2);
                    oneBack.transform.localScale = new Vector3(2, 2, 2);
                    break;
                case 4:
                    Two.SetActive(false);
                    TwoBack.SetActive(false);

                    one.SetActive(true);
                    oneBack.SetActive(true);
                    break;
                case 5:
                    Vector3 TWoSan = Two.transform.position - TwoBack.transform.position;
                    //Two.transform.position = ThrStartPos;
                    //TwoBack.transform.position = ThrStartPos + TWoSan;
                    Two.transform.localScale = new Vector3(2, 2, 2);
                    TwoBack.transform.localScale = new Vector3(2, 2, 2);
                    break;
                case 6:
                    Thr.SetActive(false);
                    ThrBack.SetActive(false);

                    Two.SetActive(true);
                    TwoBack.SetActive(true);
                    break;
                case 7:
                    Vector3 ThrSan = Thr.transform.position - ThrBack.transform.position;
                    //Thr.transform.position = ThrStartPos;
                    //ThrBack.transform.position = ThrStartPos + ThrSan;
                    Thr.transform.localScale = new Vector3(2, 2, 2);
                    ThrBack.transform.localScale = new Vector3(2, 2, 2);
                    break;
                case 8:
                    Thr.SetActive(true);
                    ThrBack.SetActive(true);
                    MainCamera.backgroundColor = Backcolor;
                    break;
            }
            nCount--;
        }
        nCount = 8;
        yield return new WaitForSeconds(0.5f);
        Start1.SetActive(false);
        StartBack.SetActive(false);
    }
}