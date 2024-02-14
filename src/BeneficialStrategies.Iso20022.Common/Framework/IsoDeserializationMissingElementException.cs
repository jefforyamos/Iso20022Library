namespace BeneficialStrategies.Iso20022.Framework;

#if DECLARE_INTERNALSERIALIZATION
public class IsoDeserializationMissingElementException : System.Exception
{
    public IsoDeserializationMissingElementException(Type deserializationTargetType, string localName)
        : base($@"Deserialiation of {deserializationTargetType.Name} could not find required element ""{localName}"".")
    {
    }
}
#endif
