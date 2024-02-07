﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AmountAndDirection31.  ISO2002 ID# _nAYJZfNBEeCuA5Tr22BnwA_-22079.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Posting of an item to a cash account, in the context of a cash transaction, that results in an increase or decrease to the balance of the account.
/// </summary>
public partial record AmountAndDirection31
     : IIsoXmlSerilizable<AmountAndDirection31>
{
    #nullable enable
    
    /// <summary>
    /// Currency and value.
    /// </summary>
    public required IsoActiveOrHistoricCurrencyAndAmount Amount { get; init; } 
    /// <summary>
    /// Indication that the position is short or long.
    /// </summary>
    public ShortLong1Code? ShortLongIndicator { get; init; } 
    
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
        writer.WriteStartElement(null, "Amt", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoActiveOrHistoricCurrencyAndAmount(Amount)); // data type ActiveOrHistoricCurrencyAndAmount System.Decimal
        writer.WriteEndElement();
        if (ShortLongIndicator is ShortLong1Code ShortLongIndicatorValue)
        {
            writer.WriteStartElement(null, "ShrtLngInd", xmlNamespace );
            writer.WriteValue(ShortLongIndicatorValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
    }
    public static AmountAndDirection31 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
