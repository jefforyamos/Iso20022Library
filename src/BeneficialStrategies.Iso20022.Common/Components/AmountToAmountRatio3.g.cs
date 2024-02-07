﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AmountToAmountRatio3.  ISO2002 ID# _WPPHedp-Ed-ak6NoX_4Aeg_1076834282.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Ratio expressed as a quotient of amounts.
/// </summary>
public partial record AmountToAmountRatio3
     : IIsoXmlSerilizable<AmountToAmountRatio3>
{
    #nullable enable
    
    /// <summary>
    /// Numerator of the quotient of amounts.
    /// </summary>
    public required IsoRestrictedFINActiveCurrencyAnd13DecimalAmount Amount1 { get; init; } 
    /// <summary>
    /// Denominator of the quotient of amounts.
    /// </summary>
    public required IsoRestrictedFINActiveCurrencyAnd13DecimalAmount Amount2 { get; init; } 
    
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
        writer.WriteStartElement(null, "Amt1", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoRestrictedFINActiveCurrencyAnd13DecimalAmount(Amount1)); // data type RestrictedFINActiveCurrencyAnd13DecimalAmount System.Decimal
        writer.WriteEndElement();
        writer.WriteStartElement(null, "Amt2", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoRestrictedFINActiveCurrencyAnd13DecimalAmount(Amount2)); // data type RestrictedFINActiveCurrencyAnd13DecimalAmount System.Decimal
        writer.WriteEndElement();
    }
    public static AmountToAmountRatio3 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
