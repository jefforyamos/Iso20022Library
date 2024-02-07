﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AmountAndCurrency1.  ISO2002 ID# _nuIgAIolEeSaAcF2oE2GNQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Amount to be authorised by the issuer.
/// </summary>
public partial record AmountAndCurrency1
     : IIsoXmlSerilizable<AmountAndCurrency1>
{
    #nullable enable
    
    /// <summary>
    /// Amount value.
    /// </summary>
    public required IsoImpliedCurrencyAndAmount Amount { get; init; } 
    /// <summary>
    /// Currency of the amount.
    /// </summary>
    public ActiveCurrencyCode? Currency { get; init; } 
    
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
        writer.WriteValue(SerializationFormatter.IsoImpliedCurrencyAndAmount(Amount)); // data type ImpliedCurrencyAndAmount System.Decimal
        writer.WriteEndElement();
        if (Currency is ActiveCurrencyCode CurrencyValue)
        {
            writer.WriteStartElement(null, "Ccy", xmlNamespace );
            writer.WriteValue(CurrencyValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
    }
    public static AmountAndCurrency1 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
