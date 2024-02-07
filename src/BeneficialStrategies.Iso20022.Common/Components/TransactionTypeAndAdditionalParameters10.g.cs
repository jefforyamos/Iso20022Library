﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for TransactionTypeAndAdditionalParameters10.  ISO2002 ID# _KdYsITxFEeW5v6FXICU4Ew.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the conditions under which the order/trade is to be settled.
/// </summary>
public partial record TransactionTypeAndAdditionalParameters10
     : IIsoXmlSerilizable<TransactionTypeAndAdditionalParameters10>
{
    #nullable enable
    
    /// <summary>
    /// Unambiguous identification of the transaction (unique per piece of collateral) as known by the account owner (or the instructing party managing the account).
    /// </summary>
    public required IsoMax35Text AccountOwnerTransactionIdentification { get; init; } 
    /// <summary>
    /// Unambiguous identification of the transaction (unique per piece of collateral) as known by the account servicer.
    /// </summary>
    public IsoMax35Text? AccountServicerTransactionIdentification { get; init; } 
    /// <summary>
    /// Specifies the type of securities financing transaction, that is, repurchase agreement, reverse repurchase agreement, securities lending or securities borrowing.
    /// </summary>
    public required SecuritiesFinancingTransactionType1Code SecuritiesFinancingTransactionType { get; init; } 
    /// <summary>
    /// Specifies if the movement on a securities account results from a deliver or a receive instruction.
    /// </summary>
    public required ReceiveDelivery1Code SecuritiesMovementType { get; init; } 
    /// <summary>
    /// Specifies how the transaction is to be settled, for example, against payment.
    /// </summary>
    public required DeliveryReceiptType2Code Payment { get; init; } 
    /// <summary>
    /// Unique reference agreed upon by the two trade counterparties to identify the trade.
    /// </summary>
    public IsoMax35Text? CommonIdentification { get; init; } 
    /// <summary>
    /// Collective reference identifying a set of messages.
    /// </summary>
    public IsoMax35Text? PoolIdentification { get; init; } 
    /// <summary>
    /// Identification assigned by the account servicer to unambiguously identify a corporate action event.
    /// </summary>
    public IsoMax35Text? CorporateActionEventIdentification { get; init; } 
    
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
        writer.WriteValue(SerializationFormatter.IsoMax35Text(AccountOwnerTransactionIdentification)); // data type Max35Text System.String
        writer.WriteEndElement();
        if (AccountServicerTransactionIdentification is IsoMax35Text AccountServicerTransactionIdentificationValue)
        {
            writer.WriteStartElement(null, "AcctSvcrTxId", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(AccountServicerTransactionIdentificationValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "SctiesFincgTxTp", xmlNamespace );
        writer.WriteValue(SecuritiesFinancingTransactionType.ToString()); // Enum value
        writer.WriteEndElement();
        writer.WriteStartElement(null, "SctiesMvmntTp", xmlNamespace );
        writer.WriteValue(SecuritiesMovementType.ToString()); // Enum value
        writer.WriteEndElement();
        writer.WriteStartElement(null, "Pmt", xmlNamespace );
        writer.WriteValue(Payment.ToString()); // Enum value
        writer.WriteEndElement();
        if (CommonIdentification is IsoMax35Text CommonIdentificationValue)
        {
            writer.WriteStartElement(null, "CmonId", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(CommonIdentificationValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (PoolIdentification is IsoMax35Text PoolIdentificationValue)
        {
            writer.WriteStartElement(null, "PoolId", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(PoolIdentificationValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (CorporateActionEventIdentification is IsoMax35Text CorporateActionEventIdentificationValue)
        {
            writer.WriteStartElement(null, "CorpActnEvtId", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(CorporateActionEventIdentificationValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
    }
    public static TransactionTypeAndAdditionalParameters10 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
