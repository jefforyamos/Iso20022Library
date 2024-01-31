﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for DebitAuthorisationRequest.  ISO2002 ID# _SKFrANE-Ed-BzquC8wXy7w_1061473966.
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
/// This record is an implementation of the camt.037.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
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
public partial record DebitAuthorisationRequest : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "camt.037.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "camt.037.001.01";
    
    #nullable enable
    /// <summary>
    /// Identifies the case assignment.
    /// </summary>
    [IsoId("_SKFrAdE-Ed-BzquC8wXy7w_-1292767181")]
    [Description(@"Identifies the case assignment.")]
    [DataMember(Name="Assgnmt")]
    [XmlElement(ElementName="Assgnmt")]
    [Required]
    public required CaseAssignment Assignment { get; init; }
    
    /// <summary>
    /// Identifies the case.
    /// </summary>
    [IsoId("_SKFrAtE-Ed-BzquC8wXy7w_-1288148931")]
    [Description(@"Identifies the case.")]
    [DataMember(Name="Case")]
    [XmlElement(ElementName="Case")]
    [Required]
    public required Case Case { get; init; }
    
    /// <summary>
    /// Identifies the underlying payment instructrion.
    /// </summary>
    [IsoId("_SKFrA9E-Ed-BzquC8wXy7w_-1277989749")]
    [Description(@"Identifies the underlying payment instructrion.")]
    [DataMember(Name="Undrlyg")]
    [XmlElement(ElementName="Undrlyg")]
    [Required]
    public required PaymentInstructionExtract Underlying { get; init; }
    
    /// <summary>
    /// Detailed information about the request.
    /// </summary>
    [IsoId("_SKFrBNE-Ed-BzquC8wXy7w_1784796933")]
    [Description(@"Detailed information about the request.")]
    [DataMember(Name="Dtl")]
    [XmlElement(ElementName="Dtl")]
    [Required]
    public required DebitAuthorisationDetails Detail { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="DebitAuthorisationRequestDocument"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public DebitAuthorisationRequestDocument ToDocument()
    {
        return new DebitAuthorisationRequestDocument { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="DebitAuthorisationRequest"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record DebitAuthorisationRequestDocument : IOuterDocument<DebitAuthorisationRequest>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:camt.037.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="DebitAuthorisationRequest"/> is required.
    /// </summary>
    public required DebitAuthorisationRequest Message { get; init; }
}
