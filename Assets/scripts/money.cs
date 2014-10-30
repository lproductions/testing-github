using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class money : MonoBehaviour {

	// Use this for initialization
    static double moneyvalue = 10000D;
    static double moneypersecond = 10D;
	void Start () {
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
        
    }
}
