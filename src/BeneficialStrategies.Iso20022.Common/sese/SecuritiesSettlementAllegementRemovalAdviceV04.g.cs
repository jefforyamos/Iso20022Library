﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for SecuritiesSettlementAllegementRemovalAdviceV04.  ISO2002 ID# _XVkhjQCUEeW_3KiG8SEjHA.
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
using Helper = BeneficialStrategies.Iso20022.Framework.IsoXmlSerializationHelper<BeneficialStrategies.Iso20022.sese.SecuritiesSettlementAllegementRemovalAdviceV04>;

namespace BeneficialStrategies.Iso20022.sese;


/// <summary>
/// This record is an implementation of the sese.029.001.04 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// An account servicer sends a SecuritiesSettlementAllegementRemovalAdvice to an account owner to acknowledge that a previously sent allegement is no longer outstanding, because the alleged party sent its instruction.
/// The account servicer/owner relationship may be:
/// - a central securities depository or another settlement market infrastructure acting on behalf of their participants
/// - an agent (sub-custodian) acting on behalf of their global custodian customer, or
/// - a custodian acting on behalf of an investment management institution or a broker/dealer.
/// 
/// Usage
/// The message may also be used to:
/// - re-send a message previously sent,
/// - provide a third party with a copy of a message for information,
/// - re-send to a third party a copy of a message for information
/// using the relevant elements in the Business Application Header.
/// </summary>
[Serializable]
[Description(@"Scope|An account servicer sends a SecuritiesSettlementAllegementRemovalAdvice to an account owner to acknowledge that a previously sent allegement is no longer outstanding, because the alleged party sent its instruction.|The account servicer/owner relationship may be:|- a central securities depository or another settlement market infrastructure acting on behalf of their participants|- an agent (sub-custodian) acting on behalf of their global custodian customer, or|- a custodian acting on behalf of an investment management institution or a broker/dealer.||Usage|The message may also be used to:|- re-send a message previously sent,|- provide a third party with a copy of a message for information,|- re-send to a third party a copy of a message for information|using the relevant elements in the Business Application Header.")]
public partial record SecuritiesSettlementAllegementRemovalAdviceV04 : IOuterRecord<SecuritiesSettlementAllegementRemovalAdviceV04,SecuritiesSettlementAllegementRemovalAdviceV04Document>
    ,IIsoXmlSerilizable<SecuritiesSettlementAllegementRemovalAdviceV04>, ISerializeInsideARootElement
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "sese.029.001.04";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "SctiesSttlmAllgmtRmvlAdvc";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => SecuritiesSettlementAllegementRemovalAdviceV04Document.DocumentNamespace;
    
    #nullable enable
    /// <summary>
    /// Provides transaction type and identification information.
    /// </summary>
    [IsoId("_XVkhkwCUEeW_3KiG8SEjHA")]
    [Description(@"Provides transaction type and identification information.")]
    [DataMember(Name="AcctSvcrTxId")]
    [XmlElement(ElementName="AcctSvcrTxId")]
    [Required]
    public required SettlementTypeAndIdentification18 AccountServicerTransactionIdentification { get; init; }
    
    /// <summary>
    /// Identification of a transaction assigned by a market infrastructure other than a central securities depository, for example, Target2-Securities.
    /// </summary>
    [IsoId("_XVkhlQCUEeW_3KiG8SEjHA")]
    [Description(@"Identification of a transaction assigned by a market infrastructure other than a central securities depository, for example, Target2-Securities.")]
    [DataMember(Name="MktInfrstrctrTxId")]
    [XmlElement(ElementName="MktInfrstrctrTxId")]
    public Identification14? MarketInfrastructureTransactionIdentification { get; init; }
    
    /// <summary>
    /// Party that legally owns the account.
    /// </summary>
    [IsoId("_XVkhlwCUEeW_3KiG8SEjHA")]
    [Description(@"Party that legally owns the account.")]
    [DataMember(Name="AcctOwnr")]
    [XmlElement(ElementName="AcctOwnr")]
    public PartyIdentification98? AccountOwner { get; init; }
    
    /// <summary>
    /// Account to or from which a securities entry is made.
    /// </summary>
    [IsoId("_XVkhmQCUEeW_3KiG8SEjHA")]
    [Description(@"Account to or from which a securities entry is made.")]
    [DataMember(Name="SfkpgAcct")]
    [XmlElement(ElementName="SfkpgAcct")]
    [Required]
    public required SecuritiesAccount19 SafekeepingAccount { get; init; }
    
    /// <summary>
    /// Identifies the details of the transaction.
    /// </summary>
    [IsoId("_XVkhmwCUEeW_3KiG8SEjHA")]
    [Description(@"Identifies the details of the transaction.")]
    [DataMember(Name="TxDtls")]
    [XmlElement(ElementName="TxDtls")]
    public TransactionDetails74? TransactionDetails { get; init; }
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_XVkhnQCUEeW_3KiG8SEjHA")]
    [Description(@"Additional information that cannot be captured in the structured elements and/or any other specific block.")]
    [DataMember(Name="SplmtryData")]
    [XmlElement(ElementName="SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="SecuritiesSettlementAllegementRemovalAdviceV04Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public SecuritiesSettlementAllegementRemovalAdviceV04Document ToDocument()
    {
        return new SecuritiesSettlementAllegementRemovalAdviceV04Document { Message = this };
    }
    public static XName RootElement => Helper.CreateXName("SctiesSttlmAllgmtRmvlAdvc");
    
    /// <summary>
    /// Used to format the various primative types during serialization.
    /// </summary>
    public static SerializationFormatter SerializationFormatter { get; set; } = SerializationFormatter.GlobalInstance;
    
    /// <summary>
    /// Serializes the state of this record according to Iso20022 specifications.
    /// </summary>
    public void Serialize(XmlWriter writer, string xmlNamespace)
    {
        writer.WriteStartElement(null, "AcctSvcrTxId", xmlNamespace );
        AccountServicerTransactionIdentification.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (MarketInfrastructureTransactionIdentification is Identification14 MarketInfrastructureTransactionIdentificationValue)
        {
            writer.WriteStartElement(null, "MktInfrstrctrTxId", xmlNamespace );
            MarketInfrastructureTransactionIdentificationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (AccountOwner is PartyIdentification98 AccountOwnerValue)
        {
            writer.WriteStartElement(null, "AcctOwnr", xmlNamespace );
            AccountOwnerValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "SfkpgAcct", xmlNamespace );
        SafekeepingAccount.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (TransactionDetails is TransactionDetails74 TransactionDetailsValue)
        {
            writer.WriteStartElement(null, "TxDtls", xmlNamespace );
            TransactionDetailsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (SupplementaryData is SupplementaryData1 SupplementaryDataValue)
        {
            writer.WriteStartElement(null, "SplmtryData", xmlNamespace );
            SupplementaryDataValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static SecuritiesSettlementAllegementRemovalAdviceV04 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="SecuritiesSettlementAllegementRemovalAdviceV04"/>.
/// </summary>
[Serializable]
public partial record SecuritiesSettlementAllegementRemovalAdviceV04Document : IOuterDocument<SecuritiesSettlementAllegementRemovalAdviceV04>, IXmlSerializable
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:sese.029.001.04";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="SecuritiesSettlementAllegementRemovalAdviceV04"/> is required.
    /// </summary>
    [DataMember(Name=SecuritiesSettlementAllegementRemovalAdviceV04.XmlTag)]
    public required SecuritiesSettlementAllegementRemovalAdviceV04 Message { get; init; }
    public void WriteXml(XmlWriter writer)
    {
        writer.WriteStartElement(null, DocumentElementName, DocumentNamespace );
        writer.WriteStartElement(SecuritiesSettlementAllegementRemovalAdviceV04.XmlTag);
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
