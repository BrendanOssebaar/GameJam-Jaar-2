using UnityEngine;

public class WeaponSwitch : MonoBehaviour
{


    public int SelectedWeapon = 0;
    // Start is called before the first frame update
    void Start()
    {
        SelectWeapon();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SelectWeapon()
    {
        int i = 0;
        foreach (Transform weapon in transform)
        {
            if (i== SelectedWeapon)
                weapon.gameObject.SetActive(true);
            else
                weapon.gameObject.SetActive(true);
            i++;
        }
    }
}
