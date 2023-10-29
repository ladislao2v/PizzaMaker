using UnityEngine;

namespace Assets.Code.Configs
{
    [CreateAssetMenu(menuName = "UpgradeInfoConfig", fileName = "new UpgradeInfoConfig")]
    public class UpgradeInfoConfig : ScriptableObject
    {
        [field: SerializeField] public string Name { get; private set; }
        [field: SerializeField] public Sprite Icon { get; private set; }
        [field: SerializeField] public Sprite BuffSprite { get; private set; }
        [field: SerializeField] public int StartPrice { get;  private set; }
    }
}
