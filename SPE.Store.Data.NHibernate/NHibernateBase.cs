using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPE.Store.Data.NHibernate
{
    public class NHibernateBase
    {
        protected virtual ISession Session { get; private set; }

        public NHibernateBase(ISession session)
        {
            this.Session = session;
        }

        protected virtual TResult Transact<TResult>(
        Func<TResult> func)
        {
            if (!Session.Transaction.IsActive)
            {
                // Wrap in transaction
                TResult result;
                using (var tx = Session.BeginTransaction())
                {
                    result = func.Invoke();
                    tx.Commit();
                }
                return result;
            }
            // Don't wrap;
            return func.Invoke();
        }

        protected virtual void Transact(Action action)
        {
            Transact<bool>(() =>
            {
                action.Invoke();
                return false;
            });
        }
    }
}
