﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for PercentageOfTotalRedemptionAmount.  ISO2002 ID# _SoRAxtp-Ed-ak6NoX_4Aeg_-1931221296.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.FinancialInstrumentQuantity6Choice;

/// <summary>
/// Percentage of the total redemption amount used for the subscription in an investment fund or investment fund class.
/// </summary>
public partial record PercentageOfTotalRedemptionAmount : FinancialInstrumentQuantity6Choice_
     , IIsoXmlSerilizable<PercentageOfTotalRedemptionAmount>
{
    #nullable enable
    
    /// <summary>
    /// Contains the main value for the container.
    /// Rate expressed as a percentage, that is, in hundredths, for example, 0.7 is 7/10 of a percent, and 7.0 is 7%.
    /// </summary>
    public required IsoPercentageRate Value { get; init; } 
    
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
        writer.WriteStartElement(null, "PctgOfTtlRedAmt", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoPercentageRate(Value)); // data type PercentageRate System.Decimal
        writer.WriteEndElement();
    }
    public static new PercentageOfTotalRedemptionAmount Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
