﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for CancelTransactionV09.  ISO2002 ID# _ThK7gdb6Eeq_l4BJLVUF2Q.
//

using System.ComponentModel.DataAnnotations;
using BeneficialStrategies.Iso20022.Components;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.camt;


/// <summary>
/// This record is an implementation of the camt.008.001.09 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The CancelTransaction message is sent by a member to the transaction administrator.
/// It is used to request the cancellation of one payment instruction held at the transaction administrator and sent by the member.
/// Usage
/// Following normal business flows, transactions registered by the transaction administrator may be queued for later settlement (because of insufficient funds available, because of risk or liquidity limits, etc.). A transaction may have a series of statuses. These can be transient (such as pending or related types), final (such as rejected, revoked and/or settled) or the status may even be defined as a proprietary status.
/// Members of a system need to have information about the payments queue(s), and must have the ability to take action (that is, to cancel or modify the transaction(s) to be settled). Note, however, that actions by a member will always concern transactions in a transient status.
/// For this reason, at any time during the operating hours of the system, the member can request the cancellation of a transaction that has not received a final status.
/// The member will submit a CancelTransaction message containing the identification of the transaction to be cancelled.
/// Based on the criteria received within the CancelTransaction message, the transaction administrator will execute or reject the requested cancellation.
/// The transaction administrator may send a Receipt message as a reply to the CancelTransaction request.
/// To verify the outcome of the request, the member may submit a GetTransaction message with the appropriate search criteria.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|The CancelTransaction message is sent by a member to the transaction administrator.|It is used to request the cancellation of one payment instruction held at the transaction administrator and sent by the member.|Usage|Following normal business flows, transactions registered by the transaction administrator may be queued for later settlement (because of insufficient funds available, because of risk or liquidity limits, etc.). A transaction may have a series of statuses. These can be transient (such as pending or related types), final (such as rejected, revoked and/or settled) or the status may even be defined as a proprietary status.|Members of a system need to have information about the payments queue(s), and must have the ability to take action (that is, to cancel or modify the transaction(s) to be settled). Note, however, that actions by a member will always concern transactions in a transient status.|For this reason, at any time during the operating hours of the system, the member can request the cancellation of a transaction that has not received a final status.|The member will submit a CancelTransaction message containing the identification of the transaction to be cancelled.|Based on the criteria received within the CancelTransaction message, the transaction administrator will execute or reject the requested cancellation.|The transaction administrator may send a Receipt message as a reply to the CancelTransaction request.|To verify the outcome of the request, the member may submit a GetTransaction message with the appropriate search criteria.")]
public partial record CancelTransactionV09 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "camt.008.001.09";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "CclTx";
    
    #nullable enable
    /// <summary>
    /// Common business identification for the message.
    /// </summary>
    [IsoId("_ThK7h9b6Eeq_l4BJLVUF2Q")]
    [Description(@"Common business identification for the message.")]
    [DataMember(Name="MsgHdr")]
    [XmlElement(ElementName="MsgHdr")]
    [Required]
    public required MessageHeader9 MessageHeader { get; init; }
    
    /// <summary>
    /// Reference to the instruction related to the payment for which information is requested.
    /// </summary>
    [IsoId("_ThK7idb6Eeq_l4BJLVUF2Q")]
    [Description(@"Reference to the instruction related to the payment for which information is requested.")]
    [DataMember(Name="PmtId")]
    [XmlElement(ElementName="PmtId")]
    [Required]
    public required PaymentIdentification6Choice_ PaymentIdentification { get; init; }
    
    /// <summary>
    /// Account to or from which a cash entry is made.
    /// </summary>
    [IsoId("_ThK7i9b6Eeq_l4BJLVUF2Q")]
    [Description(@"Account to or from which a cash entry is made.")]
    [DataMember(Name="CshAcct")]
    [XmlElement(ElementName="CshAcct")]
    public CashAccount40? CashAccount { get; init; }
    
    /// <summary>
    /// Provides detailed information on the cancellation reason.
    /// </summary>
    [IsoId("_ThK7jdb6Eeq_l4BJLVUF2Q")]
    [Description(@"Provides detailed information on the cancellation reason.")]
    [DataMember(Name="CxlRsn")]
    [XmlElement(ElementName="CxlRsn")]
    public PaymentCancellationReason5? CancellationReason { get; init; }
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_ThK7j9b6Eeq_l4BJLVUF2Q")]
    [Description(@"Additional information that cannot be captured in the structured elements and/or any other specific block.")]
    [DataMember(Name="SplmtryData")]
    [XmlElement(ElementName="SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="CancelTransactionV09Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public CancelTransactionV09Document ToDocument()
    {
        return new CancelTransactionV09Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="CancelTransactionV09"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record CancelTransactionV09Document : IOuterDocument<CancelTransactionV09>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:camt.008.001.09";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="CancelTransactionV09"/> is required.
    /// </summary>
    public required CancelTransactionV09 Message { get; init; }
}
