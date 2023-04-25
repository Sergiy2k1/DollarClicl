using UnityEngine;

public class FallingCoinUpgrade : UpgradeBase
{
    public FallingCoinUpgrade(UpgradePrototype prototype) : base(prototype)
    {

    }

    public override void Apply()
    {
        base.Apply();
        AudioManager.Instance.PlaySFX("Upgrade");
        GameObject.FindObjectOfType<FollingCoinController>().CoinCollectReward  = Prototype.Levels[Level].EffectiveValue;
    }
}
