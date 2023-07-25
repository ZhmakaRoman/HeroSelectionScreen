using TMPro;
using UnityEngine;


public class Wallet : MonoBehaviour
{
   
    [SerializeField] private TextMeshProUGUI _cointCount;
    public int Money = 30000; //общее количество очков
  


    private void Start()
    {
        _cointCount.text = Money.ToString();
        if (PlayerPrefs.HasKey("Money"))
        {
            Money = PlayerPrefs.GetInt("Money");
            _cointCount.text = Money.ToString();
        }
      
    }

    public void  UpdateAndSaveMoney(int money)
    {
        _cointCount.text = money.ToString();
        PlayerPrefs.SetInt("Money", money);
    }
    
}
