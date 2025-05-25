using EasyCS;
using EasyCS.EntityFactorySystem;
using UnityEngine; // Required for CreateAssetMenu

namespace EasyCS.Samples
{
    [CreateAssetMenu(fileName = "EntityDataFactoryAttack", menuName = "EasyCS/Entity Data Factories/EntityDataAttack")] // Menu name based on base name
    public partial class EntityDataFactoryAttack : EntityDataFactory<EntityDataAttack> // Use partial
    {
    }
}