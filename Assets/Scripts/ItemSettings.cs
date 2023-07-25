using UnityEngine;

[CreateAssetMenu(fileName = "ItemSettings",menuName = "ScriptableObjects/ItemSettings")]
public class ItemSettings : ScriptableObject
{
   
    public string Name => _name;
    public string WeaponName =>_weaponName;
    public string HP => _hP;
    public string NumberHero => _numberHero;

    
    [SerializeField] private string _name;
    [SerializeField] private string _weaponName;
    [SerializeField] private string _hP;
    [SerializeField] private string _numberHero;



}
