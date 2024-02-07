﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for TotalVariationMargin1.  ISO2002 ID# _Uk2CNNp-Ed-ak6NoX_4Aeg_-526751507.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Margin required to cover the risk because of the price fluctuations occurred on the unsettled exposures towards the central counterparty.
/// </summary>
public partial record TotalVariationMargin1
     : IIsoXmlSerilizable<TotalVariationMargin1>
{
    #nullable enable
    
    /// <summary>
    /// Specifies whether the variation margin position is short or long, that is, wether the balance is a negative or positive balance.
    /// </summary>
    public ShortLong1Code? ShortLongIndicator { get; init; } 
    /// <summary>
    /// Provides the variation margin amount in the reporting currency and optionally in the original currency.
    /// </summary>
    public required Amount2 AmountDetails { get; init; } 
    
    #nullable disable
    
    
    /// <summary>
    /// Used to format the various primative types during serialization.
    /// </summary>
    public static SerializationFormatter SerializationFormatter { get; set; } = SerializationFormatter.GlobalInstance;
    
    /// <summary>
    /// Serializes the state of this record according to Iso20022 specifications.
    /// </summary>
    public void Serialize(XmlWriter writer, string xmlNamespace)
    {
        if (ShortLongIndicator is ShortLong1Code ShortLongIndicatorValue)
        {
            writer.WriteStartElement(null, "ShrtLngInd", xmlNamespace );
            writer.WriteValue(ShortLongIndicatorValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "AmtDtls", xmlNamespace );
        AmountDetails.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
    }
    public static TotalVariationMargin1 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
