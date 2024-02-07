﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Floating.  ISO2002 ID# _GPqvsw1IEeqV4s5SpzR1dQ.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.InterestRate21Choice;

/// <summary>
/// Attributes related specifically to floating rate of an interest rate contract.
/// </summary>
public partial record Floating : InterestRate21Choice_
     , IIsoXmlSerilizable<Floating>
{
    #nullable enable
    
    /// <summary>
    /// Indication of the floating rate used.
    /// </summary>
    public FloatingRateIdentification3Choice_? Rate { get; init; } 
    /// <summary>
    /// Information related to reference period.
    /// </summary>
    public InterestRateContractTerm3? ReferencePeriod { get; init; } 
    /// <summary>
    /// Spread expressed as a rate.
    /// </summary>
    public IsoPercentageRate? Spread { get; init; } 
    /// <summary>
    /// Information related to payment frequency.
    /// </summary>
    public InterestRateFrequency2Choice_? PaymentFrequency { get; init; } 
    /// <summary>
    /// Information related to reset of payment frequency.
    /// </summary>
    public InterestRateFrequency2Choice_? ResetFrequency { get; init; } 
    
    #nullable disable
    
    
    /// <summary>
    /// Used to format the various primative types during serialization.
    /// </summary>
    public static SerializationFormatter SerializationFormatter { get; set; } = SerializationFormatter.GlobalInstance;
    
    /// <summary>
    /// Serializes the state of this record according to Iso20022 specifications.
    /// </summary>
    public override void Serialize(XmlWriter writer, string xmlNamespace)
    {
        if (Rate is FloatingRateIdentification3Choice_ RateValue)
        {
            writer.WriteStartElement(null, "Rate", xmlNamespace );
            RateValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (ReferencePeriod is InterestRateContractTerm3 ReferencePeriodValue)
        {
            writer.WriteStartElement(null, "RefPrd", xmlNamespace );
            ReferencePeriodValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (Spread is IsoPercentageRate SpreadValue)
        {
            writer.WriteStartElement(null, "Sprd", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoPercentageRate(SpreadValue)); // data type PercentageRate System.Decimal
            writer.WriteEndElement();
        }
        if (PaymentFrequency is InterestRateFrequency2Choice_ PaymentFrequencyValue)
        {
            writer.WriteStartElement(null, "PmtFrqcy", xmlNamespace );
            PaymentFrequencyValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (ResetFrequency is InterestRateFrequency2Choice_ ResetFrequencyValue)
        {
            writer.WriteStartElement(null, "RstFrqcy", xmlNamespace );
            ResetFrequencyValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static new Floating Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
