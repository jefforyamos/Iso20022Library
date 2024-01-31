﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for StatusChangeRequestV02.  ISO2002 ID# _xjvgaNE8Ed-BzquC8wXy7w_-2117703681.
//

using System.ComponentModel.DataAnnotations;
using BeneficialStrategies.Iso20022.Components;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.tsmt;


/// <summary>
/// This record is an implementation of the tsmt.026.001.02 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The StatusChangeRequest message is sent by a party involved in a transaction to the matching application.
/// This message is used to request a change in the status of a transaction.
/// Usage
/// The StatusChangeRequest message can be sent by either party involved in a transaction to the matching application to request a change in the status of a transaction.
/// The matching application will pass on the request by sending a StatusChangeRequestNotification message to the counterparty which can accept or reject the request by sending a SatausChangeRequestAcceptance or StatusChangeRequestRejection message.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|The StatusChangeRequest message is sent by a party involved in a transaction to the matching application.|This message is used to request a change in the status of a transaction.|Usage|The StatusChangeRequest message can be sent by either party involved in a transaction to the matching application to request a change in the status of a transaction.|The matching application will pass on the request by sending a StatusChangeRequestNotification message to the counterparty which can accept or reject the request by sending a SatausChangeRequestAcceptance or StatusChangeRequestRejection message.")]
public partial record StatusChangeRequestV02 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "tsmt.026.001.02";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "StsChngReq";
    
    #nullable enable
    /// <summary>
    /// Identifies the request message.
    /// </summary>
    [IsoId("_xjvgadE8Ed-BzquC8wXy7w_-2117703678")]
    [Description(@"Identifies the request message.")]
    [DataMember(Name="ReqId")]
    [XmlElement(ElementName="ReqId")]
    [Required]
    public required MessageIdentification1 RequestIdentification { get; init; }
    
    /// <summary>
    /// Unique identification assigned by the matching application to the transaction.|This identification is to be used in any communication between the parties.
    /// </summary>
    [IsoId("_xjvgatE8Ed-BzquC8wXy7w_-2117703649")]
    [Description(@"Unique identification assigned by the matching application to the transaction.|This identification is to be used in any communication between the parties.")]
    [DataMember(Name="TxId")]
    [XmlElement(ElementName="TxId")]
    [Required]
    public required SimpleIdentificationInformation TransactionIdentification { get; init; }
    
    /// <summary>
    /// Reference to the transaction for the requesting financial institution.
    /// </summary>
    [IsoId("_xjvga9E8Ed-BzquC8wXy7w_-2117703588")]
    [Description(@"Reference to the transaction for the requesting financial institution.")]
    [DataMember(Name="SubmitrTxRef")]
    [XmlElement(ElementName="SubmitrTxRef")]
    public SimpleIdentificationInformation? SubmitterTransactionReference { get; init; }
    
    /// <summary>
    /// Specifies the baseline status requested by the submitter by means of a code.
    /// </summary>
    [IsoId("_xjvgbNE8Ed-BzquC8wXy7w_-2117703618")]
    [Description(@"Specifies the baseline status requested by the submitter by means of a code.")]
    [DataMember(Name="ReqdSts")]
    [XmlElement(ElementName="ReqdSts")]
    [Required]
    public required TransactionStatus3 RequestedStatus { get; init; }
    
    /// <summary>
    /// Specifies the reason for the request to change status.
    /// </summary>
    [IsoId("_xjvgbdE8Ed-BzquC8wXy7w_-2117703557")]
    [Description(@"Specifies the reason for the request to change status.")]
    [DataMember(Name="ReqRsn")]
    [XmlElement(ElementName="ReqRsn")]
    public Reason2? RequestReason { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="StatusChangeRequestV02Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public StatusChangeRequestV02Document ToDocument()
    {
        return new StatusChangeRequestV02Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="StatusChangeRequestV02"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record StatusChangeRequestV02Document : IOuterDocument<StatusChangeRequestV02>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:tsmt.026.001.02";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="StatusChangeRequestV02"/> is required.
    /// </summary>
    public required StatusChangeRequestV02 Message { get; init; }
}
