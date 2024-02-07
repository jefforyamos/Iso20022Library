﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AmountAndDirection30.  ISO2002 ID# _nAYJaPNBEeCuA5Tr22BnwA_1167008361.
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
public partial record AmountAndDirection30
     : IIsoXmlSerilizable<AmountAndDirection30>
{
    #nullable enable
    
    /// <summary>
    /// Amount of money in the cash entry.
    /// </summary>
    public required IsoActiveOrHistoricCurrencyAndAmount Amount { get; init; } 
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
    public void Serialize(XmlWriter writer, string xmlNamespace)
    {
        writer.WriteStartElement(null, "Amt", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoActiveOrHistoricCurrencyAndAmount(Amount)); // data type ActiveOrHistoricCurrencyAndAmount System.Decimal
        writer.WriteEndElement();
        if (Sign is IsoPlusOrMinusIndicator SignValue)
        {
            writer.WriteStartElement(null, "Sgn", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoPlusOrMinusIndicator(SignValue)); // data type PlusOrMinusIndicator System.String
            writer.WriteEndElement();
        }
    }
    public static AmountAndDirection30 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
