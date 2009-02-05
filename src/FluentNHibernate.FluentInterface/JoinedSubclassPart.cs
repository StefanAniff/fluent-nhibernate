using FluentNHibernate.FluentInterface;
using FluentNHibernate.MappingModel;

namespace FluentNHibernate.Testing.FluentInterface
{
    public class JoinedSubclassPart<TSubclassType> : ClassMapBase<TSubclassType>
    {
        private readonly JoinedSubclassMapping _subclass;

        public JoinedSubclassPart(JoinedSubclassMapping subclassMapping)
            : base(subclassMapping)
        {
            _subclass = subclassMapping;
        }
    }
}