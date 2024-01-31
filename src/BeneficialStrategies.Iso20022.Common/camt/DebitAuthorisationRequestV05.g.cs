﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for DebitAuthorisationRequestV05.  ISO2002 ID# _uH4KAUggEeaGKYpLDboHPQ.
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
/// Scope
/// The Debit Authorisation Request message is sent by an account servicing institution to an account owner. This message is used to request authorisation to debit an account.
/// Usage
/// The Debit Authorisation Request message must be answered with a Debit Authorisation Response message.
/// The Debit Authorisation Request message can be used to request debit authorisation in a:
/// - request to modify payment case (in the case of a lower final amount or change of creditor)
/// - request to cancel payment case (full amount)
/// - unable to apply case (the creditor whose account has been credited is not the intended beneficiary)
/// - claim non receipt case (the creditor whose account has been credited is not the intended beneficiary)
/// The Debit Authorisation Request message covers one and only one payment instruction at a time. If an account servicing institution needs to request debit authorisation for several instructions, then multiple Debit Authorisation Request messages must be sent.
/// The Debit Authorisation Request must be used exclusively between the account servicing institution and the account owner. It must not be used in place of a Request To Modify Payment or Request To Cancel Payment message between subsequent agents.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|The Debit Authorisation Request message is sent by an account servicing institution to an account owner. This message is used to request authorisation to debit an account.|Usage|The Debit Authorisation Request message must be answered with a Debit Authorisation Response message.|The Debit Authorisation Request message can be used to request debit authorisation in a:|- request to modify payment case (in the case of a lower final amount or change of creditor)|- request to cancel payment case (full amount)|- unable to apply case (the creditor whose account has been credited is not the intended beneficiary)|- claim non receipt case (the creditor whose account has been credited is not the intended beneficiary)|The Debit Authorisation Request message covers one and only one payment instruction at a time. If an account servicing institution needs to request debit authorisation for several instructions, then multiple Debit Authorisation Request messages must be sent.|The Debit Authorisation Request must be used exclusively between the account servicing institution and the account owner. It must not be used in place of a Request To Modify Payment or Request To Cancel Payment message between subsequent agents.")]
public partial record DebitAuthorisationRequestV05 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "DbtAuthstnReq";
    
    #nullable enable
    /// <summary>
    /// Identifies the assignment of an investigation case from an assigner to an assignee.|Usage: The Assigner must be the sender of this confirmation and the Assignee must be the receiver.
    /// </summary>
    [IsoId("_uH4KA0ggEeaGKYpLDboHPQ")]
    [Description(@"Identifies the assignment of an investigation case from an assigner to an assignee.|Usage: The Assigner must be the sender of this confirmation and the Assignee must be the receiver.")]
    [DataMember(Name="Assgnmt")]
    [XmlElement(ElementName="Assgnmt")]
    [Required]
    public required CaseAssignment3 Assignment { get; init; }
    
    /// <summary>
    /// Identifies the investigation case.
    /// </summary>
    [IsoId("_uH4KBUggEeaGKYpLDboHPQ")]
    [Description(@"Identifies the investigation case.")]
    [DataMember(Name="Case")]
    [XmlElement(ElementName="Case")]
    [Required]
    public required Case3 Case { get; init; }
    
    /// <summary>
    /// Identifies the underlying payment instruction.
    /// </summary>
    [IsoId("_uH4KB0ggEeaGKYpLDboHPQ")]
    [Description(@"Identifies the underlying payment instruction.")]
    [DataMember(Name="Undrlyg")]
    [XmlElement(ElementName="Undrlyg")]
    [Required]
    public required IUnderlyingTransaction3Choice Underlying { get; init; }
    
    /// <summary>
    /// Detailed information about the request.
    /// </summary>
    [IsoId("_uH4KCUggEeaGKYpLDboHPQ")]
    [Description(@"Detailed information about the request.")]
    [DataMember(Name="Dtl")]
    [XmlElement(ElementName="Dtl")]
    [Required]
    public required DebitAuthorisation2 Detail { get; init; }
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_uH4KC0ggEeaGKYpLDboHPQ")]
    [Description(@"Additional information that cannot be captured in the structured elements and/or any other specific block.")]
    [DataMember(Name="SplmtryData")]
    [XmlElement(ElementName="SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="DebitAuthorisationRequestV05Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public DebitAuthorisationRequestV05Document ToDocument()
    {
        return new DebitAuthorisationRequestV05Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="DebitAuthorisationRequestV05"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record DebitAuthorisationRequestV05Document : IOuterDocument<DebitAuthorisationRequestV05>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:camt.037.001.05";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="DebitAuthorisationRequestV05"/> is required.
    /// </summary>
    public required DebitAuthorisationRequestV05 Message { get; init; }
}
