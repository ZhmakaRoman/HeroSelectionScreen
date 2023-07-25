using TMPro;
using UnityEngine;

public class Item : MonoBehaviour
{
   [SerializeField] private ItemSettings _itemSettings;

   [SerializeField] private TextMeshProUGUI _nameText;
   [SerializeField] private TextMeshProUGUI _weaponNameText;
   [SerializeField] private TextMeshProUGUI _hPText;
   [SerializeField] private TextMeshProUGUI _numberHeroText;
 

 

   
   private void Update()
   {
      _nameText.text = _itemSettings.Name;
      _weaponNameText.text = _itemSettings.WeaponName;
      _hPText.text = _itemSettings.HP;
      _numberHeroText.text = _itemSettings.NumberHero;
    

   }
}
