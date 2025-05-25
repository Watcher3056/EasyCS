using EasyCS;
using EasyCS.EntityFactorySystem;
using UnityEngine; // Required for CreateAssetMenu

namespace EasyCS.Samples
{
    [CreateAssetMenu(fileName = "EntityDataFactoryMoveSpeed", menuName = "EasyCS/Entity Data Factories/EntityDataMoveSpeed")] // Menu name based on base name
    public partial class EntityDataFactoryMoveSpeed : EntityDataFactory<EntityDataMoveSpeed> // Use partial
    {
    }
}