using System;
using NHibernate;

namespace WFMVC.Common
{
    public static class StringUtil
    {
        /// <summary>
        /// Gera o SQL de uma ICriteria
        /// </summary>
        /// <param name="criteria">a criteria a ser logada</param>
        /// <returns></returns>
        public static string GenerateSQL(this ICriteria criteria)
        {
            NHibernate.Impl.CriteriaImpl criteriaImpl = (NHibernate.Impl.CriteriaImpl)criteria;
            NHibernate.Engine.ISessionImplementor session = criteriaImpl.Session;
            NHibernate.Engine.ISessionFactoryImplementor factory = session.Factory;

            NHibernate.Loader.Criteria.CriteriaQueryTranslator translator =
                new NHibernate.Loader.Criteria.CriteriaQueryTranslator(
                    factory,
                    criteriaImpl,
                    criteriaImpl.EntityOrClassName,
                    NHibernate.Loader.Criteria.CriteriaQueryTranslator.RootSqlAlias);

            String[] implementors = factory.GetImplementors(criteriaImpl.EntityOrClassName);

            NHibernate.Loader.Criteria.CriteriaJoinWalker walker = new NHibernate.Loader.Criteria.CriteriaJoinWalker(
                (NHibernate.Persister.Entity.IOuterJoinLoadable)factory.GetEntityPersister(implementors[0]),
                                    translator,
                                    factory,
                                    criteriaImpl,
                                    criteriaImpl.EntityOrClassName,
                                    session.EnabledFilters);

            return walker.SqlString.ToString()
                .Replace(",", "," + Environment.NewLine + "\t")
                .Replace("left", Environment.NewLine + "left")
                .Replace("FROM", Environment.NewLine + "FROM")
                .Replace("WHERE", Environment.NewLine + "WHERE")
                .Replace("ORDER BY", Environment.NewLine + "ORDER BY");
        }
    }
}
