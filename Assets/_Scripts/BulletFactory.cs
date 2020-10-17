using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class BulletFactory : MonoBehaviour
{
    [Header("Bullet Types")]
    public GameObject normalBullet;
    public GameObject fatBullet;
    public GameObject pulsatingBullet;

    public GameObject createBullet(BulletType type)
    {
        GameObject tempBullet = null;

        switch (type)
        {
            case BulletType.NORMAL:
                tempBullet = Instantiate(normalBullet);
                break;

            case BulletType.FAT:
                tempBullet = Instantiate(fatBullet);
                break;

            case BulletType.PULSATING:
                tempBullet = Instantiate(pulsatingBullet);
                break;
        }

        tempBullet.transform.parent = transform;
        tempBullet.SetActive(false);

        return tempBullet;
    }
}
