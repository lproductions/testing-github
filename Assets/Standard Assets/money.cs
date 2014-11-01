using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class money : MonoBehaviour {

	// Use this for initialization
    public static double moneyvalue;
    public static double moneypersecond = 10D;
    public static double totalmoney = 10000D;
    public GameObject moneypersecondobject;
	void Start () {
        moneyvalue = PlayerPrefs.GetInt("money");
        StartCoroutine(moneypersecondsomething());
	}
	
	// Update is called once per frame
	void Update () {
        
	}
    IEnumerator moneypersecondsomething() {
        while (true) {
            addmoney();
            yield return new WaitForSeconds(0.05f);
            
        }
    }
    void addmoney() {
        
        moneyvalue += moneypersecond / 20;
        GetComponentInChildren<Text>().text = "£" + System.Math.Truncate( moneyvalue);
        totalmoney += moneypersecond / 20;
        moneypersecondobject.GetComponent<Text>().text ="Money per second: £" + moneypersecond ;
        
        
    }
}
