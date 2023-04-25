using UnityEngine;

public class FollingCoinController : MonoBehaviour
{
    public int CoinCollectReward = 100;
    [SerializeField] private GameObject _dollarPrefab;

    [SerializeField] private Transform _dollarSpawnPoint1;
    [SerializeField] private Transform _dollarSpawnPoint2;

    [SerializeField] private float _minSpawnInterwal;
    [SerializeField] private float _maxSpawnInterwal;

    private float _spawnActualInterval;

    private void Start()
    {
        SetSpawnInterval();
    }

    private void Update()
    {
        _spawnActualInterval -= Time.deltaTime;

        if(_spawnActualInterval <= 0 )
        {
            SpawnDollar();
            SetSpawnInterval();
        }
    }

    private void SpawnDollar()
    {
        var spawnPosition = _dollarSpawnPoint1.position;
        spawnPosition.x = Mathf.Lerp(_dollarSpawnPoint1.position.x, _dollarSpawnPoint2.position.x, Random.Range(0, 1f));
        var go = Instantiate(_dollarPrefab, spawnPosition,Quaternion.identity);
        go.GetComponent<FallingCoin>()._collectReward = CoinCollectReward;
        Destroy(go, 12f);
    }

    private void SetSpawnInterval()
    {
        _spawnActualInterval = Random.Range(_minSpawnInterwal, _maxSpawnInterwal);
    }
}
