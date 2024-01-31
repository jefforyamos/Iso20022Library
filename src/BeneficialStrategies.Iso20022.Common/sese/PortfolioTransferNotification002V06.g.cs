﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for PortfolioTransferNotification002V06.  ISO2002 ID# _IPiiUwn-Eeqvb4kQR8No8g.
//

using System.ComponentModel.DataAnnotations;
using BeneficialStrategies.Iso20022.Components;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.sese;


/// <summary>
/// This record is an implementation of the sese.037.002.06 ISO standard message type.
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
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|The  PortfolioTransferNotification is sent by an account servicer to another account servicer to exchange transfer settlement details information during a retail or institutional client portfolio transfer.|The account servicer will typically be local agent or global custodian acting on behalf of an investment management institution, a broker/dealer or a retail client.||Usage|The exchange of transfer settlement details is the provision, by the delivering account servicer to the receiving account servicer, of the settlement data (such as trade date, settlement date, delivering settlement chain, quantities) of the individual transfers that will take place during a full or partial portfolio transfer. This delivering account servicer message may also include, for validation, the receiving settlement chain as provided by the client. In case the receiving settlement chain is not available to the delivering account servicer, the receiving account servicer may in return provide to the delivering account servicer the receiving settlement chain using the same message.||The message may also be used to:|- re-send a message previously sent,|- provide a third party with a copy of a message for information,|- re-send to a third party a copy of a message for information|using the relevant elements in the Business Application Header.")]
public partial record PortfolioTransferNotification002V06 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "sese.037.002.06";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "PrtflTrfNtfctn";
    
    #nullable enable
    /// <summary>
    /// Page number of the message (within a statement) and continuation indicator to indicate that the statement is to continue or that the message is the last page of the statement.
    /// </summary>
    [IsoId("_IPiiWgn-Eeqvb4kQR8No8g")]
    [Description(@"Page number of the message (within a statement) and continuation indicator to indicate that the statement is to continue or that the message is the last page of the statement.")]
    [DataMember(Name="Pgntn")]
    [XmlElement(ElementName="Pgntn")]
    [Required]
    public required Pagination1 Pagination { get; init; }
    
    /// <summary>
    /// Provides general information on the notification.
    /// </summary>
    [IsoId("_IPiiXAn-Eeqvb4kQR8No8g")]
    [Description(@"Provides general information on the notification.")]
    [DataMember(Name="StmtGnlDtls")]
    [XmlElement(ElementName="StmtGnlDtls")]
    [Required]
    public required Statement68 StatementGeneralDetails { get; init; }
    
    /// <summary>
    /// Party that legally owns the account.
    /// </summary>
    [IsoId("_IPiiXgn-Eeqvb4kQR8No8g")]
    [Description(@"Party that legally owns the account.")]
    [DataMember(Name="AcctOwnr")]
    [XmlElement(ElementName="AcctOwnr")]
    public PartyIdentification156? AccountOwner { get; init; }
    
    /// <summary>
    /// Account to or from which a securities entry is made.
    /// </summary>
    [IsoId("_IPiiYAn-Eeqvb4kQR8No8g")]
    [Description(@"Account to or from which a securities entry is made.")]
    [DataMember(Name="SfkpgAcct")]
    [XmlElement(ElementName="SfkpgAcct")]
    [Required]
    public required SecuritiesAccount30 SafekeepingAccount { get; init; }
    
    /// <summary>
    /// Details of the transfer.
    /// </summary>
    [IsoId("_IPiiYgn-Eeqvb4kQR8No8g")]
    [Description(@"Details of the transfer.")]
    [DataMember(Name="TrfNtfctnDtls")]
    [XmlElement(ElementName="TrfNtfctnDtls")]
    public SecuritiesTradeDetails114? TransferNotificationDetails { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="PortfolioTransferNotification002V06Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public PortfolioTransferNotification002V06Document ToDocument()
    {
        return new PortfolioTransferNotification002V06Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="PortfolioTransferNotification002V06"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record PortfolioTransferNotification002V06Document : IOuterDocument<PortfolioTransferNotification002V06>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:sese.037.002.06";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="PortfolioTransferNotification002V06"/> is required.
    /// </summary>
    public required PortfolioTransferNotification002V06 Message { get; init; }
}
