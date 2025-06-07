using EasyCS;
using EasyCS.EntityFactorySystem;
using UnityEngine;
using TriInspector;

namespace EasyCS.Samples
{
    [DrawWithTriInspector]
    [CreateAssetMenu(fileName = "EntityDataFactoryHealthMax", menuName = "EasyCS/Entity Data Factories/EntityDataHealthMax")]
    public partial class EntityDataFactoryHealthMax : EntityDataFactory<EntityDataHealthMax>
    {
    }
}