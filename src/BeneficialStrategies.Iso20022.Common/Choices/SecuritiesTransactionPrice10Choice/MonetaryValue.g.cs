﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for MonetaryValue.  ISO2002 ID# _QtL74f9iEea3W_f2lS_aiw.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.SecuritiesTransactionPrice10Choice;

/// <summary>
/// Indicates that price is expressed as a monetary value.
/// </summary>
public partial record MonetaryValue : SecuritiesTransactionPrice10Choice_
     , IIsoXmlSerilizable<MonetaryValue>
{
    #nullable enable
    
    /// <summary>
    /// Amount of money that results in an increase (positively signed) or decrease (negatively signed), with specification of the currency.
    /// </summary>
    public required IsoActiveOrHistoricCurrencyAnd20Amount Amount { get; init; } 
    /// <summary>
    /// Indicates that the amount value is positive or negative.
    /// Usage: When absent, the amount is positive.
    /// </summary>
    public IsoPlusOrMinusIndicator? Sign { get; init; } 
    
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
        writer.WriteStartElement(null, "Amt", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoActiveOrHistoricCurrencyAnd20Amount(Amount)); // data type ActiveOrHistoricCurrencyAnd20Amount System.Decimal
        writer.WriteEndElement();
        if (Sign is IsoPlusOrMinusIndicator SignValue)
        {
            writer.WriteStartElement(null, "Sgn", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoPlusOrMinusIndicator(SignValue)); // data type PlusOrMinusIndicator System.String
            writer.WriteEndElement();
        }
    }
    public static new MonetaryValue Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
