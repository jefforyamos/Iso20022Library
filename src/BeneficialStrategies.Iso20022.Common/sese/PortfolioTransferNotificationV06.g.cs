﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for PortfolioTransferNotificationV06.  ISO2002 ID# _Pw4F8ekGEemm4qhb2yFPOw.
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
using Helper = BeneficialStrategies.Iso20022.Framework.IsoXmlSerializationHelper<BeneficialStrategies.Iso20022.sese.PortfolioTransferNotificationV06>;

namespace BeneficialStrategies.Iso20022.sese;


/// <summary>
/// This record is an implementation of the sese.037.001.06 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The  PortfolioTransferNotification is sent by an account servicer to another account servicer to exchange transfer settlement details information during a retail or institutional client portfolio transfer.
/// The account servicer will typically be local agent or global custodian acting on behalf of an investment management institution, a broker/dealer or a retail client.
/// 
/// Usage
/// The exchange of transfer settlement details is the provision, by the delivering account servicer to the receiving account servicer, of the settlement data (such as trade date, settlement date, delivering settlement chain, quantities) of the individual transfers that will take place during a full or partial portfolio transfer. This delivering account servicer message may also include, for validation, the receiving settlement chain as provided by the client. In case the receiving settlement chain is not available to the delivering account servicer, the receiving account servicer may in return provide to the delivering account servicer the receiving settlement chain using the same message.
/// 
/// The message may also be used to:
/// - re-send a message previously sent,
/// - provide a third party with a copy of a message for information,
/// - re-send to a third party a copy of a message for information
/// using the relevant elements in the Business Application Header.
/// </summary>
[Serializable]
[Description(@"Scope|The  PortfolioTransferNotification is sent by an account servicer to another account servicer to exchange transfer settlement details information during a retail or institutional client portfolio transfer.|The account servicer will typically be local agent or global custodian acting on behalf of an investment management institution, a broker/dealer or a retail client.||Usage|The exchange of transfer settlement details is the provision, by the delivering account servicer to the receiving account servicer, of the settlement data (such as trade date, settlement date, delivering settlement chain, quantities) of the individual transfers that will take place during a full or partial portfolio transfer. This delivering account servicer message may also include, for validation, the receiving settlement chain as provided by the client. In case the receiving settlement chain is not available to the delivering account servicer, the receiving account servicer may in return provide to the delivering account servicer the receiving settlement chain using the same message.||The message may also be used to:|- re-send a message previously sent,|- provide a third party with a copy of a message for information,|- re-send to a third party a copy of a message for information|using the relevant elements in the Business Application Header.")]
public partial record PortfolioTransferNotificationV06 : IOuterRecord<PortfolioTransferNotificationV06,PortfolioTransferNotificationV06Document>
    ,IIsoXmlSerilizable<PortfolioTransferNotificationV06>, ISerializeInsideARootElement
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "sese.037.001.06";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "PrtflTrfNtfctn";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => PortfolioTransferNotificationV06Document.DocumentNamespace;
    
    #nullable enable
    /// <summary>
    /// Page number of the message (within a statement) and continuation indicator to indicate that the statement is to continue or that the message is the last page of the statement.
    /// </summary>
    [IsoId("_Pw4F--kGEemm4qhb2yFPOw")]
    [Description(@"Page number of the message (within a statement) and continuation indicator to indicate that the statement is to continue or that the message is the last page of the statement.")]
    [DataMember(Name="Pgntn")]
    [XmlElement(ElementName="Pgntn")]
    [Required]
    public required Pagination1 Pagination { get; init; }
    
    /// <summary>
    /// Provides general information on the notification.
    /// </summary>
    [IsoId("_Pw4F_ekGEemm4qhb2yFPOw")]
    [Description(@"Provides general information on the notification.")]
    [DataMember(Name="StmtGnlDtls")]
    [XmlElement(ElementName="StmtGnlDtls")]
    [Required]
    public required Statement62 StatementGeneralDetails { get; init; }
    
    /// <summary>
    /// Party that legally owns the account.
    /// </summary>
    [IsoId("_Pw4F_-kGEemm4qhb2yFPOw")]
    [Description(@"Party that legally owns the account.")]
    [DataMember(Name="AcctOwnr")]
    [XmlElement(ElementName="AcctOwnr")]
    public PartyIdentification144? AccountOwner { get; init; }
    
    /// <summary>
    /// Account to or from which a securities entry is made.
    /// </summary>
    [IsoId("_Pw4GAekGEemm4qhb2yFPOw")]
    [Description(@"Account to or from which a securities entry is made.")]
    [DataMember(Name="SfkpgAcct")]
    [XmlElement(ElementName="SfkpgAcct")]
    [Required]
    public required SecuritiesAccount19 SafekeepingAccount { get; init; }
    
    /// <summary>
    /// Details of the transfer.
    /// </summary>
    [IsoId("_Pw4GA-kGEemm4qhb2yFPOw")]
    [Description(@"Details of the transfer.")]
    [DataMember(Name="TrfNtfctnDtls")]
    [XmlElement(ElementName="TrfNtfctnDtls")]
    public SecuritiesTradeDetails111? TransferNotificationDetails { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="PortfolioTransferNotificationV06Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public PortfolioTransferNotificationV06Document ToDocument()
    {
        return new PortfolioTransferNotificationV06Document { Message = this };
    }
    public static XName RootElement => Helper.CreateXName("PrtflTrfNtfctn");
    
    /// <summary>
    /// Used to format the various primative types during serialization.
    /// </summary>
    public static SerializationFormatter SerializationFormatter { get; set; } = SerializationFormatter.GlobalInstance;
    
    /// <summary>
    /// Serializes the state of this record according to Iso20022 specifications.
    /// </summary>
    public void Serialize(XmlWriter writer, string xmlNamespace)
    {
        writer.WriteStartElement(null, "Pgntn", xmlNamespace );
        Pagination.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "StmtGnlDtls", xmlNamespace );
        StatementGeneralDetails.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (AccountOwner is PartyIdentification144 AccountOwnerValue)
        {
            writer.WriteStartElement(null, "AcctOwnr", xmlNamespace );
            AccountOwnerValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "SfkpgAcct", xmlNamespace );
        SafekeepingAccount.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (TransferNotificationDetails is SecuritiesTradeDetails111 TransferNotificationDetailsValue)
        {
            writer.WriteStartElement(null, "TrfNtfctnDtls", xmlNamespace );
            TransferNotificationDetailsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static PortfolioTransferNotificationV06 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="PortfolioTransferNotificationV06"/>.
/// </summary>
[Serializable]
public partial record PortfolioTransferNotificationV06Document : IOuterDocument<PortfolioTransferNotificationV06>, IXmlSerializable
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:sese.037.001.06";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="PortfolioTransferNotificationV06"/> is required.
    /// </summary>
    [DataMember(Name=PortfolioTransferNotificationV06.XmlTag)]
    public required PortfolioTransferNotificationV06 Message { get; init; }
    public void WriteXml(XmlWriter writer)
    {
        writer.WriteStartElement(null, DocumentElementName, DocumentNamespace );
        writer.WriteStartElement(PortfolioTransferNotificationV06.XmlTag);
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
