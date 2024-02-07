﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for IntraBalanceMovementStatusAdviceV01.  ISO2002 ID# _DLtLcTncEem7JZMuWtwtsg.
//

using System.ComponentModel.DataAnnotations;
using BeneficialStrategies.Iso20022.Components;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;
using Helper = BeneficialStrategies.Iso20022.Framework.IsoXmlSerializationHelper<BeneficialStrategies.Iso20022.camt.IntraBalanceMovementStatusAdviceV01>;

namespace BeneficialStrategies.Iso20022.camt;


/// <summary>
/// This record is an implementation of the camt.067.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The IntraBalanceMovementStatusAdvice message is sent from a settlement infrastructure to an account owner/requestor to advise the status of an intra-balance movement instruction previously sent by the account owner/requestor.||Usage: |The message may be used to: |- re-send a message previously sent (the sub-function of the message is "Duplicate")|- provide a third party with a copy of a message for information (the sub-function of the message is "Copy")|- re-send to a third party a copy of a message for information (the sub-function of the message is "CopyDuplicate").
/// </summary>
[Serializable]
[Description(@"The IntraBalanceMovementStatusAdvice message is sent from a settlement infrastructure to an account owner/requestor to advise the status of an intra-balance movement instruction previously sent by the account owner/requestor.||Usage: |The message may be used to: |- re-send a message previously sent (the sub-function of the message is ""Duplicate"")|- provide a third party with a copy of a message for information (the sub-function of the message is ""Copy"")|- re-send to a third party a copy of a message for information (the sub-function of the message is ""CopyDuplicate"").")]
public partial record IntraBalanceMovementStatusAdviceV01 : IOuterRecord<IntraBalanceMovementStatusAdviceV01,IntraBalanceMovementStatusAdviceV01Document>
    ,IIsoXmlSerilizable<IntraBalanceMovementStatusAdviceV01>, ISerializeInsideARootElement
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "camt.067.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "IntraBalMvmntStsAdvc";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => IntraBalanceMovementStatusAdviceV01Document.DocumentNamespace;
    
    #nullable enable
    /// <summary>
    /// Unambiguous identification of the message as known by the account servicer or settlement infrastructure.
    /// </summary>
    [IsoId("_DLtLeTncEem7JZMuWtwtsg")]
    [Description(@"Unambiguous identification of the message as known by the account servicer or settlement infrastructure.")]
    [DataMember(Name="Id")]
    [XmlElement(ElementName="Id")]
    public DocumentIdentification51? Identification { get; init; }
    
    /// <summary>
    /// Unambiguous identification of a transaction as per the account owner (or the instructing party managing the account).
    /// </summary>
    [IsoId("_DLtLezncEem7JZMuWtwtsg")]
    [Description(@"Unambiguous identification of a transaction as per the account owner (or the instructing party managing the account).")]
    [DataMember(Name="TxId")]
    [XmlElement(ElementName="TxId")]
    [Required]
    public required TransactionIdentifications24 TransactionIdentification { get; init; }
    
    /// <summary>
    /// Provides details on the processing status of the transaction.
    /// </summary>
    [IsoId("_DLtLfTncEem7JZMuWtwtsg")]
    [Description(@"Provides details on the processing status of the transaction.")]
    [DataMember(Name="PrcgSts")]
    [XmlElement(ElementName="PrcgSts")]
    public ProcessingStatus67Choice_? ProcessingStatus { get; init; }
    
    /// <summary>
    /// Provides the settlement status of a transaction.
    /// </summary>
    [IsoId("_DLtLfzncEem7JZMuWtwtsg")]
    [Description(@"Provides the settlement status of a transaction.")]
    [DataMember(Name="SttlmSts")]
    [XmlElement(ElementName="SttlmSts")]
    public SettlementStatus16Choice_? SettlementStatus { get; init; }
    
    /// <summary>
    /// Account to or from which an entry is made.
    /// </summary>
    [IsoId("_DLtLgTncEem7JZMuWtwtsg")]
    [Description(@"Account to or from which an entry is made.")]
    [DataMember(Name="CshAcct")]
    [XmlElement(ElementName="CshAcct")]
    [Required]
    public required CashAccount38 CashAccount { get; init; }
    
    /// <summary>
    /// Party that legally owns the cash account.
    /// </summary>
    [IsoId("_-M0_4jp7EemwKdP955WBJQ")]
    [Description(@"Party that legally owns the cash account.")]
    [DataMember(Name="CshAcctOwnr")]
    [XmlElement(ElementName="CshAcctOwnr")]
    public SystemPartyIdentification8? CashAccountOwner { get; init; }
    
    /// <summary>
    /// Party that manages the cash account on behalf of the account owner, that is manages the registration and booking of entries on the account, calculates balances on the account and provides information about the account.
    /// </summary>
    [IsoId("_-M0_4zp7EemwKdP955WBJQ")]
    [Description(@"Party that manages the cash account on behalf of the account owner, that is manages the registration and booking of entries on the account, calculates balances on the account and provides information about the account.")]
    [DataMember(Name="CshAcctSvcr")]
    [XmlElement(ElementName="CshAcctSvcr")]
    public BranchAndFinancialInstitutionIdentification6? CashAccountServicer { get; init; }
    
    /// <summary>
    /// Intra-balance movement transaction details.
    /// </summary>
    [IsoId("_DLtLgzncEem7JZMuWtwtsg")]
    [Description(@"Intra-balance movement transaction details.")]
    [DataMember(Name="UndrlygIntraBal")]
    [XmlElement(ElementName="UndrlygIntraBal")]
    public IntraBalance5? UnderlyingIntraBalance { get; init; }
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_DLtLhTncEem7JZMuWtwtsg")]
    [Description(@"Additional information that cannot be captured in the structured elements and/or any other specific block.")]
    [DataMember(Name="SplmtryData")]
    [XmlElement(ElementName="SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="IntraBalanceMovementStatusAdviceV01Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public IntraBalanceMovementStatusAdviceV01Document ToDocument()
    {
        return new IntraBalanceMovementStatusAdviceV01Document { Message = this };
    }
    public static XName RootElement => Helper.CreateXName("IntraBalMvmntStsAdvc");
    
    /// <summary>
    /// Used to format the various primative types during serialization.
    /// </summary>
    public static SerializationFormatter SerializationFormatter { get; set; } = SerializationFormatter.GlobalInstance;
    
    /// <summary>
    /// Serializes the state of this record according to Iso20022 specifications.
    /// </summary>
    public void Serialize(XmlWriter writer, string xmlNamespace)
    {
        if (Identification is DocumentIdentification51 IdentificationValue)
        {
            writer.WriteStartElement(null, "Id", xmlNamespace );
            IdentificationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "TxId", xmlNamespace );
        TransactionIdentification.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (ProcessingStatus is ProcessingStatus67Choice_ ProcessingStatusValue)
        {
            writer.WriteStartElement(null, "PrcgSts", xmlNamespace );
            ProcessingStatusValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (SettlementStatus is SettlementStatus16Choice_ SettlementStatusValue)
        {
            writer.WriteStartElement(null, "SttlmSts", xmlNamespace );
            SettlementStatusValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "CshAcct", xmlNamespace );
        CashAccount.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (CashAccountOwner is SystemPartyIdentification8 CashAccountOwnerValue)
        {
            writer.WriteStartElement(null, "CshAcctOwnr", xmlNamespace );
            CashAccountOwnerValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (CashAccountServicer is BranchAndFinancialInstitutionIdentification6 CashAccountServicerValue)
        {
            writer.WriteStartElement(null, "CshAcctSvcr", xmlNamespace );
            CashAccountServicerValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (UnderlyingIntraBalance is IntraBalance5 UnderlyingIntraBalanceValue)
        {
            writer.WriteStartElement(null, "UndrlygIntraBal", xmlNamespace );
            UnderlyingIntraBalanceValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (SupplementaryData is SupplementaryData1 SupplementaryDataValue)
        {
            writer.WriteStartElement(null, "SplmtryData", xmlNamespace );
            SupplementaryDataValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static IntraBalanceMovementStatusAdviceV01 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="IntraBalanceMovementStatusAdviceV01"/>.
/// </summary>
[Serializable]
public partial record IntraBalanceMovementStatusAdviceV01Document : IOuterDocument<IntraBalanceMovementStatusAdviceV01>, IXmlSerializable
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:camt.067.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="IntraBalanceMovementStatusAdviceV01"/> is required.
    /// </summary>
    [DataMember(Name=IntraBalanceMovementStatusAdviceV01.XmlTag)]
    public required IntraBalanceMovementStatusAdviceV01 Message { get; init; }
    public void WriteXml(XmlWriter writer)
    {
        writer.WriteStartElement(null, DocumentElementName, DocumentNamespace );
        writer.WriteStartElement(IntraBalanceMovementStatusAdviceV01.XmlTag);
        Message.Serialize(writer, DocumentNamespace);
        writer.WriteEndElement();
        writer.WriteEndElement();
        writer.WriteEndDocument();
    }
    
    public void ReadXml(XmlReader reader)
    {
        throw new NotImplementedException();
    }
    
    public System.Xml.Schema.XmlSchema GetSchema() => null;
}
