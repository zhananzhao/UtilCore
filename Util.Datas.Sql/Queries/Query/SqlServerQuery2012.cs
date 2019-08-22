using Util.Datas.Sql.Queries.Builders;

namespace Util.Datas.Sql.Queries.Query {
    /// <summary>
    /// SqlServer2012查询对象
    /// </summary>
    public class SqlServerQuery2012 : SqlQueryBase {
        /// <summary>
        /// 创建Sql生成器
        /// </summary>
        protected override ISqlBuilder CreateSqlBuilder() {
            return new SqlBuilder2012();
        }
    }
}
