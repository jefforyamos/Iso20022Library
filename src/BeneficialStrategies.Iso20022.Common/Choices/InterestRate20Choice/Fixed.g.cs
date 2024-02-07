﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Fixed.  ISO2002 ID# _hFv8Eax2Eem81-uIvTF5rQ.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.InterestRate20Choice;

/// <summary>
/// Details of the fixed rate.
/// </summary>
public partial record Fixed : InterestRate20Choice_
     , IIsoXmlSerilizable<Fixed>
{
    #nullable enable
    
    /// <summary>
    /// Annualised interest rate on the principal amount of the repurchase transaction in accordance with the day count convention.
    /// </summary>
    public IsoPercentageRate? Rate { get; init; } 
    /// <summary>
    /// Method for calculating the accrued interest on the principal amount for a fixed rate.
    /// </summary>
    public InterestComputationMethodFormat6Choice_? DayCountBasis { get; init; } 
    
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
        if (DayCountBasis is InterestComputationMethodFormat6Choice_ DayCountBasisValue)
        {
            writer.WriteStartElement(null, "DayCntBsis", xmlNamespace );
            DayCountBasisValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static new Fixed Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
