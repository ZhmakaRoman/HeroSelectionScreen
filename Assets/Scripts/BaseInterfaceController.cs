using UnityEngine;
using UnityEngine.SceneManagement;


public class BaseInterfaceController : MonoBehaviour
{
 
  [SerializeField] private GameObject[] _charactersUserInterface;// массив эелементов инерфейса

  private int _index; // хранит индекс 
 
  private void Start()
  {
    _index = PlayerPrefs.GetInt("HeroScene");// Загружаем сохраненный индекс персонажа из PlayerPrefs.

    PopulateUserInterfaceArray();// Вызов метода для заполнения массива 
    SetActiveUserInterface(_index);// Вызов метода для установки активного элемента интерфейса на старте игры.
  
  }
 
  
  private void SetActiveUserInterface(int index)
  {
    // Отключаем всех видимых героев, делая их неактивными.
    foreach (GameObject heroOffHero in _charactersUserInterface)
    {
      heroOffHero.SetActive(false);
    }

    // Проверяем наличие персонажа по указанному индексу и включаем его (делаем активным).
    if (index >= 0 && index < _charactersUserInterface.Length)
    {
      _charactersUserInterface[index].SetActive(true);
    }
  }
  
   private void PopulateUserInterfaceArray()
  {
    // Массив _charactersHero будет состоять из дочерних объектов текущего объекта
    _charactersUserInterface = new GameObject[transform.childCount];
    // Заполняем массив _charactersHero (дочерние объекты), т.е. персонажей.
    for (int i = 0; i < transform.childCount; i++)
    {
      _charactersUserInterface[i] = transform.GetChild(i).gameObject;
    }
  }
  public void SelectLeft()
  {
    // Отключаем текущего персонажа по текущему индексу.
      _charactersUserInterface[_index].SetActive(false);
      _index--;
      if (_index < 0)
      {
        _index = _charactersUserInterface.Length - 1;
      }
      // Включаем нового выбранного персонажа по новому индексу.
      _charactersUserInterface[_index].SetActive(true);
  }
  public void SelectRight()
  {
    _charactersUserInterface[_index].SetActive(false);
    _index++;
    if (_index == _charactersUserInterface.Length )
    {
      _index = 0;
    }
    _charactersUserInterface[_index].SetActive(true);
  }

  public void SaveScene()
  {
    // Сохраняем текущий индекс персонажа в PlayerPrefs с ключом "HeroScene"
    PlayerPrefs.SetInt("HeroScene",_index);
    SceneManager.LoadScene("SampleScene");
  }
  
}
