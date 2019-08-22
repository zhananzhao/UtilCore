using System.Configuration;
using System.Text;

namespace Util {
    /// <summary>
    /// 配置
    /// </summary>
    public static class Config {

        #region DefaultEncoding(默认编码)

        /// <summary>
        /// 默认编码,值为utf-8
        /// </summary>
        public static Encoding DefaultEncoding {
            get { return Encoding.GetEncoding( "utf-8" ); }
        }

        #endregion

        

        #region GetLogContextKey(获取日志上下文键名)

        /// <summary>
        /// 获取日志上下文键名
        /// </summary>
        public static string GetLogContextKey() {
            return "Util.Logs.ContextLogger";
        }

        #endregion
    }
}
