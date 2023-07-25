using System;
using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.UIElements;
using Button = UnityEngine.UI.Button;

public class ButtonController : MonoBehaviour
{
   [SerializeField] private GameObject _prefabBuyButton;//префаб кнопки покупки
   [SerializeField] public Button _prefabSelectButton;//префаб кнопки Select
   [SerializeField] private string objectButtonName; // Переменная для хранения имени объекта.
   private int access ; // Переменная для хранения статуса доступа. 0 (доступ разрешен), 1(доступ запрещен).


   private void Start()
   {
       CheckAccess(); // Вызов метода для проверки статуса доступа при запуске скрипта.
   }
   
   /// <summary>
   /// // Метод для проверки статуса доступа к объекту.
   /// </summary>
   private void CheckAccess()
   {
       // Получаем  PlayerPrefs, используя имя объекта.
       access = PlayerPrefs.GetInt(objectButtonName + "Access");
       if (access == 1)
       {
           _prefabBuyButton.SetActive(false);// Отключаем кнопку покупки, деактивируя ее GameObject.
           _prefabSelectButton.interactable= true;// Делаем кнопку выбора активной, разрешая взаимодействие с ней.
             
       }
   }
/// <summary>
/// Данный метод изменяет статус доступа к объекту на противоположный
/// </summary>
   [UsedImplicitly]
   public void ChangeAccessStatus()
   {
       if (access == 0)
       {
           PlayerPrefs.SetInt(objectButtonName + "Access",1);
           CheckAccess();// Проверяем статус доступа заново.
       }
   }
}
