﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AmountAndDirection7.  ISO2002 ID# _SUTi-tp-Ed-ak6NoX_4Aeg_-1729353607.
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
public partial record AmountAndDirection7
     : IIsoXmlSerilizable<AmountAndDirection7>
{
    #nullable enable
    
    /// <summary>
    /// Amount of money in the cash entry.
    /// </summary>
    public required IsoActiveCurrencyAndAmount Amount { get; init; } 
    /// <summary>
    /// Indicates whether an entry is a credit or a debit.
    /// </summary>
    public required CreditDebitCode CreditDebitIndicator { get; init; } 
    
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
        writer.WriteValue(SerializationFormatter.IsoActiveCurrencyAndAmount(Amount)); // data type ActiveCurrencyAndAmount System.Decimal
        writer.WriteEndElement();
        writer.WriteStartElement(null, "CdtDbtInd", xmlNamespace );
        writer.WriteValue(CreditDebitIndicator.ToString()); // Enum value
        writer.WriteEndElement();
    }
    public static AmountAndDirection7 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
