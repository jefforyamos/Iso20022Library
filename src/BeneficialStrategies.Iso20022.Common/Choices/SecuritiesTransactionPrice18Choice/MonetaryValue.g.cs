﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for MonetaryValue.  ISO2002 ID# _m8q24MgpEeuGrNSsxk3B0A.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices.SecuritiesTransactionPrice18Choice;

/// <summary>
/// Indicates that price is expressed as a monetary value.
/// </summary>
public partial record MonetaryValue : SecuritiesTransactionPrice18Choice_
     , IIsoXmlSerilizable<MonetaryValue>
{
    #nullable enable
    
    /// <summary>
    /// Amount of money in the cash entry.
    /// </summary>
    public required IsoActiveOrHistoricCurrencyAnd20DecimalAmount Amount { get; init; } 
    /// <summary>
    /// Indicates that the amount value is positive or negative.
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
        writer.WriteValue(SerializationFormatter.IsoActiveOrHistoricCurrencyAnd20DecimalAmount(Amount)); // data type ActiveOrHistoricCurrencyAnd20DecimalAmount System.Decimal
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
