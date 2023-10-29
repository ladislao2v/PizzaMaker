using Assets.Code.Configs;
using UnityEngine;

namespace Code.UI.Upgrades
{
    public class UpgradePanelView : MonoBehaviour
    {
        [SerializeField] private UpgradeInfoConfig[] _configs;
        
        private UpgradeView[] _views;

        private void Awake()
        {
            _views = GetComponentsInChildren<UpgradeView>();

            for(int i = 0; i < _views.Length; i++)
            {
                _views[i].Construct(_configs[i]);
            }
        }
    }
}