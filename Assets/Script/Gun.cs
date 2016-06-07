using UnityEngine;
using System.Collections;

public class Gun : MonoBehaviour
{
    RaycastHit ray;

    public GameObject bullet;
    public GameObject bullet2;
    public Transform spawn;
    public float speed;
    public float torque;

    // Update is called once per frame(毎フレーム呼ばれる)
    void Update()
    {
        //（重要）マウスカーソルを非表示
        //Cursor.visible = false;

        //右クリック
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
        //左クリック
        if (Input.GetButtonDown("Fire2"))
        {
            Shoot2();
        }
    }

    void Shoot()
    {
        GameObject obj = Instantiate(bullet) as GameObject;
        obj.transform.position = spawn.position;
        Vector3 force = this.gameObject.transform.forward * speed;
        obj.GetComponent<Rigidbody>().AddForce(force);

        //三秒後に消す
        Destroy(obj, 3f);
    }

    void Shoot2()
    {
        GameObject bullet2obj = (GameObject)Instantiate(bullet2, transform.position, Quaternion.identity);
        Rigidbody bullet2Rigidbody = bullet2obj.GetComponent<Rigidbody>();
        // 手榴弾の移動速度。『プレイヤー正面に向けての速度ベクトル』を５。
        Vector3 bom_speed = transform.TransformDirection(Vector3.forward) * 5;
        // 手榴弾の『高さ方向の速度』を加算
        bom_speed += Vector3.up * 5;
        // 手榴弾の速度を代入
        bullet2obj.GetComponent<Rigidbody>().velocity = bom_speed;

        //30秒後に消す
        Destroy(bullet2obj, 30f);
    }
}
