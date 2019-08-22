using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Util.Domains;

namespace Util.Datas.Ef {
    /// <summary>
    /// 实体映射
    /// </summary>
    /// <typeparam name="TEntity">实体类型</typeparam>
    public abstract class EntityMapBase<TEntity> : IEntityTypeConfiguration<TEntity>, IMap where TEntity : class, IEntity {
        

        /// <summary>
        /// 映射表
        /// </summary>
        protected abstract void MapTable(EntityTypeBuilder<TEntity> builder);

        /// <summary>
        /// 映射标识
        /// </summary>
        protected abstract void MapId(EntityTypeBuilder<TEntity> builder);
        
        /// <summary>
        /// 映射属性
        /// </summary>
        protected virtual void MapProperties(EntityTypeBuilder<TEntity> builder) {
        }

        /// <summary>
        /// 映射导航属性
        /// </summary>
        protected virtual void MapAssociations(EntityTypeBuilder<TEntity> builder) {
            
        }

        /// <summary>
        /// 将配置添加到管理器
        /// </summary>
        /// <param name="registrar">配置管理器</param>
        public void AddTo(ModelBuilder registrar ) {
            registrar.ApplyConfiguration( this);
        }

        /// <summary>
        ///     Configures the entity of type <typeparamref name="TEntity" />.
        /// </summary>
        /// <param name="builder"> The builder to be used to configure the entity type. </param>
        public void Configure(EntityTypeBuilder<TEntity> builder)
        {
            MapTable(builder);
            MapId(builder);
            MapProperties(builder);
            MapAssociations(builder);
        }
    }
}
