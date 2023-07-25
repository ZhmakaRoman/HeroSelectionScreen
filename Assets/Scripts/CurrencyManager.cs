using JetBrains.Annotations;
using UnityEngine;


public class CurrencyManager : MonoBehaviour
{
   
    [SerializeField] private int _price;//цена за персонажа
    [SerializeField] private Wallet _wallet;// Ссылка на объект Wallet, представляющий кошелек игрока.

    /// <summary>
    ///Метод выполняет  покупку персонажа
    /// </summary>
    [UsedImplicitly]
    public void BuyCharacter()
    {
        if (_wallet.Money >= _price)
        {
            _wallet.Money -= _price;
            // Вызов метода CheckWallet из объекта Wallet для обновления отображения баланса в кошельке.
            _wallet. UpdateAndSaveMoney(_wallet.Money);
        }
    }

}
