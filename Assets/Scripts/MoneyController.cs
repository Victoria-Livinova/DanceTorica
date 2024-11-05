using UnityEngine;
using TMPro;
public class MoneyController : MonoBehaviour
{
    static public int moneyCount;
    TextMeshProUGUI text;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        text = GetComponent<TextMeshProUGUI>(); 
        moneyCount = 0;
    }

    public void changeMoneyText()
    {
        text.text = moneyCount.ToString();
    }
}
