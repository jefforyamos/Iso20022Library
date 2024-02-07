﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ATMTransaction6.  ISO2002 ID# _9qsqQYqvEeSIDtZ76p6McQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Inquiry information for the transaction.
/// </summary>
public partial record ATMTransaction6
     : IIsoXmlSerilizable<ATMTransaction6>
{
    #nullable enable
    
    /// <summary>
    /// Identification of the transaction assigned by the ATM.
    /// </summary>
    public required TransactionIdentifier1 TransactionIdentification { get; init; } 
    /// <summary>
    /// Unprotected account information.
    /// </summary>
    public CardAccount3? AccountData { get; init; } 
    /// <summary>
    /// Encryption of account information.
    /// </summary>
    public ContentInformationType10? ProtectedAccountData { get; init; } 
    /// <summary>
    /// Amount to be authorised by the issuer.
    /// </summary>
    public AmountAndCurrency1? TotalRequestedAmount { get; init; } 
    /// <summary>
    /// Amounts of the withdrawal transaction.
    /// </summary>
    public DetailedAmount12? DetailedRequestedAmount { get; init; } 
    /// <summary>
    /// Sequence of one or more TLV data elements from the ATM application, in accordance with ISO 7816-6, not in a specific order. Present if the transaction is performed with an EMV chip card application.
    /// </summary>
    public IsoMax10000Binary? ICCRelatedData { get; init; } 
    
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
        writer.WriteStartElement(null, "TxId", xmlNamespace );
        TransactionIdentification.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (AccountData is CardAccount3 AccountDataValue)
        {
            writer.WriteStartElement(null, "AcctData", xmlNamespace );
            AccountDataValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (ProtectedAccountData is ContentInformationType10 ProtectedAccountDataValue)
        {
            writer.WriteStartElement(null, "PrtctdAcctData", xmlNamespace );
            ProtectedAccountDataValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (TotalRequestedAmount is AmountAndCurrency1 TotalRequestedAmountValue)
        {
            writer.WriteStartElement(null, "TtlReqdAmt", xmlNamespace );
            TotalRequestedAmountValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (DetailedRequestedAmount is DetailedAmount12 DetailedRequestedAmountValue)
        {
            writer.WriteStartElement(null, "DtldReqdAmt", xmlNamespace );
            DetailedRequestedAmountValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (ICCRelatedData is IsoMax10000Binary ICCRelatedDataValue)
        {
            writer.WriteStartElement(null, "ICCRltdData", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax10000Binary(ICCRelatedDataValue)); // data type Max10000Binary System.Byte[]
            writer.WriteEndElement();
        }
    }
    public static ATMTransaction6 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
