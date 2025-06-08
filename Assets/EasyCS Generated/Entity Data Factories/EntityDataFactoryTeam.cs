using EasyCS;
using EasyCS.EntityFactorySystem;
using UnityEngine;
using TriInspector;

namespace EasyCS
{
    [DrawWithTriInspector]
    [CreateAssetMenu(fileName = "EntityDataFactoryTeam", menuName = "EasyCS/Entity Data Factories/EntityDataTeam")]
    public partial class EntityDataFactoryTeam : EntityDataFactory<EntityDataTeam>
    {
    }
}