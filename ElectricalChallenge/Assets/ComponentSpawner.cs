using UnityEngine;

public class ComponentSpawner : MonoBehaviour
{
    GameObject _objectToSpawn;
    [SerializeField] GameObject[] objectsArray;

    [SerializeField] Camera nonVRCamera;
    [SerializeField] Canvas canvas;
    private bool _isSelected = false;
    public void Spawn() 
    {
        Vector3 worldPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition, Camera.MonoOrStereoscopicEye.Mono);

        Vector3 adjustZ = new Vector3(worldPoint.x, worldPoint.y, _objectToSpawn.transform.position.z);
        GameObject prefab = Instantiate(_objectToSpawn);
        prefab.transform.position = adjustZ;
        _objectToSpawn = null;
        _isSelected = false;
    }

    public void SpawnUI() 
    {
        Vector3 worldPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition, Camera.MonoOrStereoscopicEye.Mono);

        Vector3 adjustZ = new Vector3(worldPoint.x, worldPoint.y, _objectToSpawn.transform.position.z);
        GameObject prefab = Instantiate(_objectToSpawn, canvas.transform, false);
        prefab.transform.position = adjustZ;
        _objectToSpawn = null;
        _isSelected = false;
    }


    public void SetFirstToSpawn() 
    {
        _objectToSpawn = objectsArray[0];
        _isSelected = true;
    }

    public void SetSecondToSpawn()
    {
        _objectToSpawn = objectsArray[1];
        _isSelected = true;
    }

    public void SetThirdToSpawn()
    {
        _objectToSpawn = objectsArray[2];
        _isSelected = true;
    }

    public void SetFourthToSpawn()
    {
        _objectToSpawn = objectsArray[3];
        _isSelected = true;
    }

    public void SetFifthToSpawn()
    {
        _objectToSpawn = objectsArray[4];
        _isSelected = true;
    }

    public void SetSixtToSpawn()
    {
        _objectToSpawn = objectsArray[5];
        _isSelected = true;
    }

    public void SetSevenToSpawn()
    {
        _objectToSpawn = objectsArray[6];
        _isSelected = true;
    }

    public void SetEightToSpawn()
    {
        _objectToSpawn = objectsArray[7];
        _isSelected = true;
    }

    public void SetNineToSpawn()
    {
        _objectToSpawn = objectsArray[8];
        _isSelected = true;
    }

    public void SetTenToSpawn()
    {
        _objectToSpawn = objectsArray[9];
        _isSelected = true;
    }

    public void SetElevenToSpawn()
    {
        _objectToSpawn = objectsArray[10];
        _isSelected = true;
    }

    public void SetTvelveToSpawn()
    {
        _objectToSpawn = objectsArray[11];
        _isSelected = true;
    }

    public void SetThirtineToSpawn()
    {
        _objectToSpawn = objectsArray[12];
        _isSelected = true;
    }

    public void SetFurteneToSpawn()
    {
        _objectToSpawn = objectsArray[13];
        _isSelected = true;
    }

    public void SetFifthenToSpawn()
    {
        _objectToSpawn = objectsArray[14];
        _isSelected = true;
    }

    public void SetSixtineToSpawn()
    {
        _objectToSpawn = objectsArray[15];
        _isSelected = true;
    }

    public void SetInputTextToSpawn() 
    {
        _objectToSpawn = objectsArray[16];
        _isSelected = true;
    }

    public void SetL1() 
    {
        _objectToSpawn = objectsArray[17];
        _isSelected = true;
    }
    public void SetL2()
    {
        _objectToSpawn = objectsArray[18];
        _isSelected = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0) && _isSelected)
        {

            if (_objectToSpawn== objectsArray[16])
            {
                SpawnUI();
            }else Spawn();
        }
    }
}
