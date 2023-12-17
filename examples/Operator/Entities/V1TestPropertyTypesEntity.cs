using k8s.Models;

using KubeOps.Abstractions.Entities;

namespace Operator.Entities;

[KubernetesEntity(Group = "testing.dev", ApiVersion = "v1", Kind = "TestPropertyTypesEntity")]
public partial class V1TestPropertyTypesEntity : CustomKubernetesEntity<V1TestPropertyTypesEntity.EntitySpec>
{
    public class EntitySpec
    {
        public string SomeString { get; set; } = string.Empty;
        public string? SomeStringNullable { get; set; } = null;
        
        public int SomeInt { get; set; } = 0;
        public int? SomeIntNullable { get; set; } = null;
        
        public long SomeLong { get; set; } = 0;
        public long? SomeLongNullable { get; set; } = null;
        
        public float SomeFloat { get; set; } = 0;
        public float? SomeFloatNullable { get; set; } = null;
        
        public double SomeDouble { get; set; } = 0;
        public double? SomeDoubleNullable { get; set; } = null;

        public DateTime SomeDate { get; set; } = DateTime.MaxValue;
        public DateTime? SomeDateNullable { get; set; } = null;

        public Guid SomeGuid { get; set; } = Guid.Empty;
        public Guid? SomeGuidNullable { get; set; } = null;
    }
}
