using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Framework.EFRepository
{
    /// <summary>

    /// 数据操作基类

    /// </summary>

    public abstract class RepositoryBase

    {

        #region 单件模式创建一个类对象

        /// <summary>

        /// 数据源对象

        /// </summary>

        private static OAContext dbContext = null;

        protected static OAContext CreateInstance()

        {

            if (dbContext == null)

                dbContext = new OAContext();

            return dbContext;

        }

        #endregion



        public OAContext _db = CreateInstance();



        /// <summary>

        /// 存储变化 service层可能也会使用本方法,所以声明为public

        /// </summary>

        public virtual void SaveChanges()

        {

            this._db.Configuration.ValidateOnSaveEnabled = false;

            this._db.SaveChanges();

        }

    }
}
