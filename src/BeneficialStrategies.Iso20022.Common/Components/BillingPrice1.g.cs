﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for BillingPrice1.  ISO2002 ID# _6TrGHJqlEeGSON8vddiWzQ_-1572616191.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the billing price of a service.
/// </summary>
public partial record BillingPrice1
     : IIsoXmlSerilizable<BillingPrice1>
{
    #nullable enable
    
    /// <summary>
    /// Currency code in which the unit price and original charge price are expressed.
    /// </summary>
    public ActiveOrHistoricCurrencyCode? Currency { get; init; } 
    /// <summary>
    /// Price per item or unit used to calculate the charge expressed in the pricing currency.
    /// </summary>
    public AmountAndDirection34? UnitPrice { get; init; } 
    /// <summary>
    /// Identifies how the charge was calculated. ||Usage: The absence of this code assumes that the charge is calculated as the product of (volume x unit price).
    /// </summary>
    public BillingChargeMethod1Code? Method { get; init; } 
    /// <summary>
    /// Indicates that the charge calculation is based on a particular rule. The rule name is carried here and is defined by the trading partners.
    /// </summary>
    public IsoMax20Text? Rule { get; init; } 
    
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
        if (Currency is ActiveOrHistoricCurrencyCode CurrencyValue)
        {
            writer.WriteStartElement(null, "Ccy", xmlNamespace );
            writer.WriteValue(CurrencyValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (UnitPrice is AmountAndDirection34 UnitPriceValue)
        {
            writer.WriteStartElement(null, "UnitPric", xmlNamespace );
            UnitPriceValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (Method is BillingChargeMethod1Code MethodValue)
        {
            writer.WriteStartElement(null, "Mtd", xmlNamespace );
            writer.WriteValue(MethodValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (Rule is IsoMax20Text RuleValue)
        {
            writer.WriteStartElement(null, "Rule", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax20Text(RuleValue)); // data type Max20Text System.String
            writer.WriteEndElement();
        }
    }
    public static BillingPrice1 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
