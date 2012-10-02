using System;
using System.Data;

namespace NHibernate.Dialect
{
	public class MigratorDialect : Dialect
	{
		public MigratorDialect()
		{
            foreach (DbType ty in Enum.GetValues(typeof(DbType)))
                RegisterColumnType(ty, "DbType."+ty.ToString());
		}

        public new bool SupportsCommentOn
        {
            get { return true; }
        }
	}
}