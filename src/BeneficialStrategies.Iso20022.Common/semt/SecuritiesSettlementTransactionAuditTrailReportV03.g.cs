﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for SecuritiesSettlementTransactionAuditTrailReportV03.  ISO2002 ID# _YSWG-wCTEeW_3KiG8SEjHA.
//

using System.ComponentModel.DataAnnotations;
using BeneficialStrategies.Iso20022.Components;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.semt;


/// <summary>
/// Scope
/// This message is sent by the Market Infrastructure to the CSD to advise of the history of all the statuses, modifications, replacement and cancellation of a specific transaction during its whole life cycle when the instructing party is a direct participant to the Settlement Infrastructure.
/// Usage
/// The message may also be used to: 
/// - re-send a message sent by the market infrastructure to the direct participant,
/// - provide a third party with a copy of a message being sent by the market infrastructure for information,
/// - re-send to a third party a copy of a message being sent by the market infrastructure for information
/// using the relevant elements in the Business Application Header.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|This message is sent by the Market Infrastructure to the CSD to advise of the history of all the statuses, modifications, replacement and cancellation of a specific transaction during its whole life cycle when the instructing party is a direct participant to the Settlement Infrastructure.||Usage|The message may also be used to: |- re-send a message sent by the market infrastructure to the direct participant,|- provide a third party with a copy of a message being sent by the market infrastructure for information,|- re-send to a third party a copy of a message being sent by the market infrastructure for information|using the relevant elements in the Business Application Header.")]
public partial record SecuritiesSettlementTransactionAuditTrailReportV03 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "SctiesSttlmTxAudtTrlRpt";
    
    #nullable enable
    /// <summary>
    /// Page number of the message (within a statement) and continuation indicator to indicate that the statement is to continue or that the message is the last page of the statement.
    /// </summary>
    [IsoId("_YSWHAQCTEeW_3KiG8SEjHA")]
    [Description(@"Page number of the message (within a statement) and continuation indicator to indicate that the statement is to continue or that the message is the last page of the statement.")]
    [DataMember(Name="Pgntn")]
    [XmlElement(ElementName="Pgntn")]
    [Required]
    public required Pagination Pagination { get; init; }
    
    /// <summary>
    /// Identification of the SecuritiesStatusQuery message sent to request this report.
    /// </summary>
    [IsoId("_YSWHAwCTEeW_3KiG8SEjHA")]
    [Description(@"Identification of the SecuritiesStatusQuery message sent to request this report.")]
    [DataMember(Name="QryRef")]
    [XmlElement(ElementName="QryRef")]
    public Identification14? QueryReference { get; init; }
    
    /// <summary>
    /// Provides unambiguous transaction identification information.
    /// </summary>
    [IsoId("_YSWHBQCTEeW_3KiG8SEjHA")]
    [Description(@"Provides unambiguous transaction identification information.")]
    [DataMember(Name="TxId")]
    [XmlElement(ElementName="TxId")]
    public TransactionIdentifications29? TransactionIdentification { get; init; }
    
    /// <summary>
    /// Account to or from which a securities entry is made.
    /// </summary>
    [IsoId("_YSWHBwCTEeW_3KiG8SEjHA")]
    [Description(@"Account to or from which a securities entry is made.")]
    [DataMember(Name="SfkpgAcct")]
    [XmlElement(ElementName="SfkpgAcct")]
    [Required]
    public required SecuritiesAccount24 SafekeepingAccount { get; init; }
    
    /// <summary>
    /// Party that legally owns the account.
    /// </summary>
    [IsoId("_YSWHCQCTEeW_3KiG8SEjHA")]
    [Description(@"Party that legally owns the account.")]
    [DataMember(Name="AcctOwnr")]
    [XmlElement(ElementName="AcctOwnr")]
    public PartyIdentification98? AccountOwner { get; init; }
    
    /// <summary>
    ///  Provides the history of status and reasons for a pending, posted or cancelled transaction.
    /// </summary>
    [IsoId("_YSWHCwCTEeW_3KiG8SEjHA")]
    [Description(@" Provides the history of status and reasons for a pending, posted or cancelled transaction.")]
    [DataMember(Name="StsTrl")]
    [XmlElement(ElementName="StsTrl")]
    public StatusTrail6? StatusTrail { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="SecuritiesSettlementTransactionAuditTrailReportV03Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public SecuritiesSettlementTransactionAuditTrailReportV03Document ToDocument()
    {
        return new SecuritiesSettlementTransactionAuditTrailReportV03Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="SecuritiesSettlementTransactionAuditTrailReportV03"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record SecuritiesSettlementTransactionAuditTrailReportV03Document : IOuterDocument<SecuritiesSettlementTransactionAuditTrailReportV03>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:semt.022.001.03";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="SecuritiesSettlementTransactionAuditTrailReportV03"/> is required.
    /// </summary>
    public required SecuritiesSettlementTransactionAuditTrailReportV03 Message { get; init; }
}
