﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Transaction146.  ISO2002 ID# _BmYzEYKzEeu4svNQ5N-l6w.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Contains transaction details.
/// </summary>
public partial record Transaction146
     : IIsoXmlSerilizable<Transaction146>
{
    #nullable enable
    
    /// <summary>
    /// Type of transaction associated with the main service.
    /// For valid values, see "Transaction type codes" in ISO 8583 "Financial transaction card originated messages — Interchange message specifications"
    /// </summary>
    public required ISO8583TransactionTypeCode TransactionType { get; init; } 
    /// <summary>
    /// Further breakdown of the transaction type being performed.
    /// </summary>
    public IsoMax35Text? TransactionSubType { get; init; } 
    /// <summary>
    /// Attribute of the transaction.
    /// ISO 8583:87 bit 25
    /// ISO 8583:2003 bit 22-3 & bit 24
    /// </summary>
    public TransactionAttribute2Code? TransactionAttribute { get; init; } 
    /// <summary>
    /// Other transaction attribute defined at national or private level.
    /// </summary>
    public IsoMax35Text? OtherTransactionAttribute { get; init; } 
    /// <summary>
    /// Reason or purpose to send the message.
    /// The ISO 8583 maintenance agency (MA) manages this code list.
    /// </summary>
    public ISO8583MessageReasonCode? MessageReason { get; init; } 
    /// <summary>
    /// Supports message reason codes that are not defined  in external code list. 
    /// </summary>
    public IsoMax256Text? AlternateMessageReason { get; init; } 
    /// <summary>
    /// Additional functions or services to be performed in conjunction with the transaction.
    /// </summary>
    public AdditionalService2? AdditionalService { get; init; } 
    /// <summary>
    /// Data to qualify for incentive or other related programmes.
    /// </summary>
    public SpecialProgrammeQualification1? SpecialProgrammeQualification { get; init; } 
    /// <summary>
    /// Identification of the transaction.
    /// </summary>
    public required TransactionIdentification18 TransactionIdentification { get; init; } 
    /// <summary>
    /// Transaction currency of the acceptor.
    /// ISO 4217
    /// </summary>
    public ISO3NumericCurrencyCode? TransactionCurrency { get; init; } 
    /// <summary>
    /// Further details of some or all amounts in the transaction amount.   
    /// The detailed amount is used to calculate the reconciliation amount for messages in which the transaction amount is absent. 
    /// </summary>
    public DetailedAmount23? DetailedAmount { get; init; } 
    /// <summary>
    /// Amount used for reconciliation. 
    /// Calculated based on the transaction amount, except when the transaction amount is absent. When transaction amount is absent, the reconciliation amount is calculated on the detailed amount field 
    /// </summary>
    public Amount15? ReconciliationAmount { get; init; } 
    /// <summary>
    /// Amounts that are not part of the transaction amount and not included in reconciliation.
    /// </summary>
    public AdditionalAmounts3? AdditionalAmount { get; init; } 
    /// <summary>
    /// Fees not included in the transaction amount.
    /// </summary>
    public AdditionalFee2? AdditionalFee { get; init; } 
    /// <summary>
    /// Financial services related to the account.
    /// </summary>
    public FundingService2? FundsServices { get; init; } 
    /// <summary>
    /// Identifies a customer account or a relationship to its account affected for debit, inquiries and the source of funding for transfers.
    /// </summary>
    public AccountDetails3? AccountFrom { get; init; } 
    /// <summary>
    /// Identifies a customer account or a relationship to its account affected for credits, inquiries and the destination account for funds transfers.
    /// </summary>
    public AccountDetails3? AccountTo { get; init; } 
    /// <summary>
    /// Transaction data related to programmes and services, content and format based on bilateral agreements.
    /// </summary>
    public IsoMax1000Text? TransactionDescription { get; init; } 
    /// <summary>
    /// Contains additional data.
    /// </summary>
    public AdditionalData1? AdditionalData { get; init; } 
    
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
        writer.WriteStartElement(null, "TxTp", xmlNamespace );
        writer.WriteValue(TransactionType.ToString()); // Enum value
        writer.WriteEndElement();
        if (TransactionSubType is IsoMax35Text TransactionSubTypeValue)
        {
            writer.WriteStartElement(null, "TxSubTp", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(TransactionSubTypeValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (TransactionAttribute is TransactionAttribute2Code TransactionAttributeValue)
        {
            writer.WriteStartElement(null, "TxAttr", xmlNamespace );
            writer.WriteValue(TransactionAttributeValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (OtherTransactionAttribute is IsoMax35Text OtherTransactionAttributeValue)
        {
            writer.WriteStartElement(null, "OthrTxAttr", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(OtherTransactionAttributeValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (MessageReason is ISO8583MessageReasonCode MessageReasonValue)
        {
            writer.WriteStartElement(null, "MsgRsn", xmlNamespace );
            writer.WriteValue(MessageReasonValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (AlternateMessageReason is IsoMax256Text AlternateMessageReasonValue)
        {
            writer.WriteStartElement(null, "AltrnMsgRsn", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax256Text(AlternateMessageReasonValue)); // data type Max256Text System.String
            writer.WriteEndElement();
        }
        if (AdditionalService is AdditionalService2 AdditionalServiceValue)
        {
            writer.WriteStartElement(null, "AddtlSvc", xmlNamespace );
            AdditionalServiceValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (SpecialProgrammeQualification is SpecialProgrammeQualification1 SpecialProgrammeQualificationValue)
        {
            writer.WriteStartElement(null, "SpclPrgrmmQlfctn", xmlNamespace );
            SpecialProgrammeQualificationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "TxId", xmlNamespace );
        TransactionIdentification.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (TransactionCurrency is ISO3NumericCurrencyCode TransactionCurrencyValue)
        {
            writer.WriteStartElement(null, "TxCcy", xmlNamespace );
            writer.WriteValue(TransactionCurrencyValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (DetailedAmount is DetailedAmount23 DetailedAmountValue)
        {
            writer.WriteStartElement(null, "DtldAmt", xmlNamespace );
            DetailedAmountValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (ReconciliationAmount is Amount15 ReconciliationAmountValue)
        {
            writer.WriteStartElement(null, "RcncltnAmt", xmlNamespace );
            ReconciliationAmountValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (AdditionalAmount is AdditionalAmounts3 AdditionalAmountValue)
        {
            writer.WriteStartElement(null, "AddtlAmt", xmlNamespace );
            AdditionalAmountValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (AdditionalFee is AdditionalFee2 AdditionalFeeValue)
        {
            writer.WriteStartElement(null, "AddtlFee", xmlNamespace );
            AdditionalFeeValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (FundsServices is FundingService2 FundsServicesValue)
        {
            writer.WriteStartElement(null, "FndsSvcs", xmlNamespace );
            FundsServicesValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (AccountFrom is AccountDetails3 AccountFromValue)
        {
            writer.WriteStartElement(null, "AcctFr", xmlNamespace );
            AccountFromValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (AccountTo is AccountDetails3 AccountToValue)
        {
            writer.WriteStartElement(null, "AcctTo", xmlNamespace );
            AccountToValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (TransactionDescription is IsoMax1000Text TransactionDescriptionValue)
        {
            writer.WriteStartElement(null, "TxDesc", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax1000Text(TransactionDescriptionValue)); // data type Max1000Text System.String
            writer.WriteEndElement();
        }
        if (AdditionalData is AdditionalData1 AdditionalDataValue)
        {
            writer.WriteStartElement(null, "AddtlData", xmlNamespace );
            AdditionalDataValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static Transaction146 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
