using Assets.Code.Configs;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Code.UI.Upgrades
{
    public class UpgradeView : MonoBehaviour
    {
        [Header("Information")]
        [SerializeField] private TextMeshProUGUI _name;
        [SerializeField] private Image _icon;
        [SerializeField] private Image _buffIcon;
        [SerializeField] private TextMeshProUGUI _price;

        [Header("Buttons")] 
        [SerializeField] private Button _buyButton;
        [SerializeField] private Button _adButton;

        public void Construct(UpgradeInfoConfig config)
        {
            _name.text = config.Name;
            _icon.sprite = config.Icon;
            _buffIcon.sprite = config.BuffSprite;
            _price.text = config.StartPrice + "$";
        }
    }
}