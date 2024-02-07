﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Fixed.  ISO2002 ID# _GPqvsQ1IEeqV4s5SpzR1dQ.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.InterestRate21Choice;

/// <summary>
/// Attributes related specifically to fixed rate of an interest rate contract.
/// </summary>
public partial record Fixed : InterestRate21Choice_
     , IIsoXmlSerilizable<Fixed>
{
    #nullable enable
    
    /// <summary>
    /// An indication of the fixed rate used.
    /// </summary>
    public IsoPercentageRate? Rate { get; init; } 
    /// <summary>
    /// Actual number of days in the relevant fixed rate calculation period.
    /// </summary>
    public IsoMax35Text? DayCount { get; init; } 
    /// <summary>
    /// Information related to payment frequency.
    /// </summary>
    public InterestRateFrequency2Choice_? PaymentFrequency { get; init; } 
    
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
        if (Rate is IsoPercentageRate RateValue)
        {
            writer.WriteStartElement(null, "Rate", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoPercentageRate(RateValue)); // data type PercentageRate System.Decimal
            writer.WriteEndElement();
        }
        if (DayCount is IsoMax35Text DayCountValue)
        {
            writer.WriteStartElement(null, "DayCnt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(DayCountValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (PaymentFrequency is InterestRateFrequency2Choice_ PaymentFrequencyValue)
        {
            writer.WriteStartElement(null, "PmtFrqcy", xmlNamespace );
            PaymentFrequencyValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static new Fixed Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
