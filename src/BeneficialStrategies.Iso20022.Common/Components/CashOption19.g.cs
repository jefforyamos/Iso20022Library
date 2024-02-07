﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CashOption19.  ISO2002 ID# _gsrpcfo9EeCdeaSQAR2tKw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides information about the cash option.
/// </summary>
public partial record CashOption19
     : IIsoXmlSerilizable<CashOption19>
{
    #nullable enable
    
    /// <summary>
    /// Indicates whether the value is a debit or credit.
    /// </summary>
    public required CreditDebitCode CreditDebitIndicator { get; init; } 
    /// <summary>
    /// Choice between a cash account, a charges account or a tax account.
    /// </summary>
    public Account8Choice_? Account { get; init; } 
    /// <summary>
    /// Date/Time of the posting (credit or debit) to the account.
    /// </summary>
    public required DateAndDateTimeChoice_ PostingDate { get; init; } 
    /// <summary>
    /// Date/Time of the posting (credit or debit) to the account that was initially communicated in the confirmation.
    /// </summary>
    public DateAndDateTimeChoice_? OriginalPostingDate { get; init; } 
    /// <summary>
    /// Date/time when calculating economic benefit for a cash amount.
    /// </summary>
    public DateAndDateTimeChoice_? ValueDate { get; init; } 
    /// <summary>
    /// Amount of money that is to be/was posted to the account.
    /// </summary>
    public required IsoActiveCurrencyAndAmount PostingAmount { get; init; } 
    
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
        writer.WriteStartElement(null, "CdtDbtInd", xmlNamespace );
        writer.WriteValue(CreditDebitIndicator.ToString()); // Enum value
        writer.WriteEndElement();
        if (Account is Account8Choice_ AccountValue)
        {
            writer.WriteStartElement(null, "Acct", xmlNamespace );
            AccountValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "PstngDt", xmlNamespace );
        PostingDate.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (OriginalPostingDate is DateAndDateTimeChoice_ OriginalPostingDateValue)
        {
            writer.WriteStartElement(null, "OrgnlPstngDt", xmlNamespace );
            OriginalPostingDateValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (ValueDate is DateAndDateTimeChoice_ ValueDateValue)
        {
            writer.WriteStartElement(null, "ValDt", xmlNamespace );
            ValueDateValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "PstngAmt", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoActiveCurrencyAndAmount(PostingAmount)); // data type ActiveCurrencyAndAmount System.Decimal
        writer.WriteEndElement();
    }
    public static CashOption19 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
