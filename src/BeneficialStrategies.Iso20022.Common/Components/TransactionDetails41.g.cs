﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for TransactionDetails41.  ISO2002 ID# _0chdGAlIEeGATtfOBToyew_-1939889920.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identifies the details of the transaction.
/// </summary>
public partial record TransactionDetails41
     : IIsoXmlSerilizable<TransactionDetails41>
{
    #nullable enable
    
    /// <summary>
    /// Unambiguous identification of the transaction as known by the account owner (or the instructing party managing the account).
    /// </summary>
    public required SettlementTypeAndIdentification3 AccountOwnerTransactionIdentification { get; init; } 
    /// <summary>
    /// Unambiguous identification of the transaction as known by the account servicer.
    /// </summary>
    public IsoMax35Text? AccountServicerTransactionIdentification { get; init; } 
    /// <summary>
    /// Identification of a transaction assigned by a market infrastructure other than a central securities depository, for example, Target2-Securities.
    /// </summary>
    public IsoMax35Text? MarketInfrastructureTransactionIdentification { get; init; } 
    /// <summary>
    /// Identification of the transaction assigned by the processor of the instruction other than the account owner the account servicer and the market infrastructure.
    /// </summary>
    public IsoMax35Text? ProcessorTransactionIdentification { get; init; } 
    /// <summary>
    /// Identification of a transaction that cannot be identified using a standard reference element present in the message.
    /// </summary>
    public IsoMax35Text? OtherTransactionIdentification { get; init; } 
    /// <summary>
    /// Party that legally owns the account.
    /// </summary>
    public PartyIdentification36Choice_? AccountOwner { get; init; } 
    /// <summary>
    /// Account to or from which a securities entry is made.
    /// </summary>
    public required SecuritiesAccount13 SafekeepingAccount { get; init; } 
    /// <summary>
    /// Provides additional details on the transaction which can not be included within the structured fields of the message.
    /// </summary>
    public TransactionDetails29? TransactionDetails { get; init; } 
    
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
        writer.WriteStartElement(null, "AcctOwnrTxId", xmlNamespace );
        AccountOwnerTransactionIdentification.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (AccountServicerTransactionIdentification is IsoMax35Text AccountServicerTransactionIdentificationValue)
        {
            writer.WriteStartElement(null, "AcctSvcrTxId", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(AccountServicerTransactionIdentificationValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (MarketInfrastructureTransactionIdentification is IsoMax35Text MarketInfrastructureTransactionIdentificationValue)
        {
            writer.WriteStartElement(null, "MktInfrstrctrTxId", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(MarketInfrastructureTransactionIdentificationValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (ProcessorTransactionIdentification is IsoMax35Text ProcessorTransactionIdentificationValue)
        {
            writer.WriteStartElement(null, "PrcrTxId", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(ProcessorTransactionIdentificationValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (OtherTransactionIdentification is IsoMax35Text OtherTransactionIdentificationValue)
        {
            writer.WriteStartElement(null, "OthrTxId", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(OtherTransactionIdentificationValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (AccountOwner is PartyIdentification36Choice_ AccountOwnerValue)
        {
            writer.WriteStartElement(null, "AcctOwnr", xmlNamespace );
            AccountOwnerValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "SfkpgAcct", xmlNamespace );
        SafekeepingAccount.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (TransactionDetails is TransactionDetails29 TransactionDetailsValue)
        {
            writer.WriteStartElement(null, "TxDtls", xmlNamespace );
            TransactionDetailsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static TransactionDetails41 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
