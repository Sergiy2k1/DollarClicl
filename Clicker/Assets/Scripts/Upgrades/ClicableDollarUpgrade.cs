using UnityEngine;

public class ClicableDollarUpgrade : UpgradeBase
{
    public ClicableDollarUpgrade(UpgradePrototype prototype) : base(prototype)
    {
        
    }

    public override void Apply()
    {
        base.Apply();
        AudioManager.Instance.PlaySFX("Upgrade");
        GameObject.FindObjectOfType<ClickableDollar>().MoneyPerClick = Prototype.Levels[Level].EffectiveValue;
    }
}
