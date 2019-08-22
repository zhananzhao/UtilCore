
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Util.Domains;

namespace Util.Datas.Ef {
    /// <summary>
    /// 聚合根映射
    /// </summary>
    /// <typeparam name="TEntity">聚合根类型</typeparam>
    /// <typeparam name="TKey">实体标识类型</typeparam>
    public abstract class AggregateMapBase<TEntity, TKey> : EntityMapBase<TEntity> where TEntity : AggregateRoot<TKey> {
        /// <summary>
        /// 映射标识
        /// </summary>
        protected override void MapId(EntityTypeBuilder<TEntity> builder)
        {
            builder.HasKey(t=>t.Id);
        }
    }
}
