namespace BeneficialStrategies.Iso20022.Repository.DataTypes.PublicInterface;

public interface IResolvedLookupSet<T> 
    where T : IResolved
    {
        public IReadOnlySet<T> Items { get; }

        public IReadOnlyDictionary<string, T> ById { get; }
    }
