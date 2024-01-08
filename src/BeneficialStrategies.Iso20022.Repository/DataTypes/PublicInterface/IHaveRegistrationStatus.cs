namespace BeneficialStrategies.Iso20022.Repository.DataTypes.PublicInterface;

public interface IHaveRegistrationStatus : IResolved
{
    string RegistrationStatus { get; }
}
