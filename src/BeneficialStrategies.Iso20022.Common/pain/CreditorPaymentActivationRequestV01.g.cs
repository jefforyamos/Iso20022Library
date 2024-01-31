﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for CreditorPaymentActivationRequestV01.  ISO2002 ID# _GWSDldEvEd-BzquC8wXy7w_-1753887518.
//

using System.ComponentModel.DataAnnotations;
using BeneficialStrategies.Iso20022.Components;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.pain;


/// <summary>
/// Scope
/// This message is sent by the Creditor sending party to the Debtor receiving party, directly or through agents.
/// It is used to initiate a creditor payment activation request.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|This message is sent by the Creditor sending party to the Debtor receiving party, directly or through agents.|It is used to initiate a creditor payment activation request.")]
public partial record CreditorPaymentActivationRequestV01 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "CdtrPmtActvtnReq";
    
    #nullable enable
    /// <summary>
    /// Set of characteristics shared by all individual transactions included in the message.
    /// </summary>
    [IsoId("_GWSDltEvEd-BzquC8wXy7w_668976179")]
    [Description(@"Set of characteristics shared by all individual transactions included in the message.")]
    [DataMember(Name="GrpHdr")]
    [XmlElement(ElementName="GrpHdr")]
    [Required]
    public required GroupHeader45 GroupHeader { get; init; }
    
    /// <summary>
    /// Set of characteristics that applies to the debit side of the payment transactions included in the creditor payment initiation.
    /// </summary>
    [IsoId("_GWSDl9EvEd-BzquC8wXy7w_1980087289")]
    [Description(@"Set of characteristics that applies to the debit side of the payment transactions included in the creditor payment initiation.")]
    [DataMember(Name="PmtInf")]
    [XmlElement(ElementName="PmtInf")]
    [Required]
    public required PaymentInstruction5 PaymentInformation { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="CreditorPaymentActivationRequestV01Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public CreditorPaymentActivationRequestV01Document ToDocument()
    {
        return new CreditorPaymentActivationRequestV01Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="CreditorPaymentActivationRequestV01"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record CreditorPaymentActivationRequestV01Document : IOuterDocument<CreditorPaymentActivationRequestV01>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:pain.013.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="CreditorPaymentActivationRequestV01"/> is required.
    /// </summary>
    public required CreditorPaymentActivationRequestV01 Message { get; init; }
}
