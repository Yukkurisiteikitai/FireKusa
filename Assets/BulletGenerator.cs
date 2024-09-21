using UnityEngine;
public class BulletGenerator : MonoBehaviour
{
    public Transform muzzleTran;
    public GameObject bulletPrefab;

    public AudioClip shotSound;
    public float shotSpeed;

    public float offset;

    public int shotCount;


    private void Start()
    {
        AudioSource AudioC = GetComponent<AudioSource>();

        shotCount = 0;
    }

    void Update()
    {
        // マウスの左クリックをしたら
        if (Input.GetMouseButtonDown(0))
        {
            // 弾の生成と発射
            Shot();
            shotCount++;
        }
    }

    /// <summary>
    /// 弾を生成して発射するメソッド
    /// </summary>
    private void Shot()
    {

        // 銃の発射口の位置に弾を生成
        GameObject bullet = Instantiate(bulletPrefab, transform.position, Quaternion.identity);

        // 弾の先端の向きを、銃の発射口の向いている方向に合わせる
        bullet.transform.forward = muzzleTran.forward;

        // 弾の回転角度を調整する
        bullet.transform.eulerAngles = new Vector3(bullet.transform.eulerAngles.x + offset, bullet.transform.eulerAngles.y, bullet.transform.eulerAngles.z);

        //Debug.Log("弾の回転角度 : " +bullet.transform.eulerAngles);

        // 弾にアタッチされている Rigidbody の取得を行い、取得できたら
        if (bullet.TryGetComponent(out Rigidbody rb))
        {

            // 弾を発射
            rb.AddForce(transform.forward * shotSpeed);

            // SE 鳴らす
            //AudioSource.PlayClipAtPoint(shotSound, Camera.main.transform.position);
        }
        else
        {
            Debug.Log("Rigidbody が取得できないため、弾を発射出来ません。");
        }
    }
}