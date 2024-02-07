﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Adjustment5.  ISO2002 ID# _SpUJrtp-Ed-ak6NoX_4Aeg_-1123474716.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Modification on the value of goods and / or services. For example: rebate, discount, surcharge.
/// </summary>
public partial record Adjustment5
     : IIsoXmlSerilizable<Adjustment5>
{
    #nullable enable
    
    /// <summary>
    /// Specifies whether the adjustment must be substracted or added to the total amount.
    /// </summary>
    public required AdjustmentDirection1Code Direction { get; init; } 
    /// <summary>
    /// Specifies the monetary amount of the adjustment.
    /// </summary>
    public required IsoActiveCurrencyAndAmount Amount { get; init; } 
    
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
        writer.WriteStartElement(null, "Drctn", xmlNamespace );
        writer.WriteValue(Direction.ToString()); // Enum value
        writer.WriteEndElement();
        writer.WriteStartElement(null, "Amt", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoActiveCurrencyAndAmount(Amount)); // data type ActiveCurrencyAndAmount System.Decimal
        writer.WriteEndElement();
    }
    public static Adjustment5 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
