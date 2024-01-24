﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for AgentCAGlobalDistributionAuthorisationRequestV01.  ISO2002 ID# _TNwP1dEwEd-BzquC8wXy7w_690310315.
//
namespace BeneficialStrategies.Iso20022.seev;

/// <summary>
/// Scope
/// This message is sent by a CSD to an issuer (or its agent) to request the authorisation to process the entitlement movements (cash and/or securities) calculated by the CSD for a given corporate action entire event, a given corporate action option and optionally a given resource.
/// This message can also be sent to request the issuer (or its agent) to make available / deliver the relevant resources to the CSD.
/// Usage
/// This message is used to request the authorisation to process the entitlement movements calculated by the CSD for a given corporate action event and option. An Agent Corporate Action Global Distribution Authorisation Request message must be sent for each option and if several resources are associated to an option, an Agent Corporate Action Global Distribution Authorisation Request message can be sent for each resource.
/// This message can also be used to pre-advise a global distribution authorisation request, in which case the value of the field pre-advice indicator must be set to yes.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|This message is sent by a CSD to an issuer (or its agent) to request the authorisation to process the entitlement movements (cash and/or securities) calculated by the CSD for a given corporate action entire event, a given corporate action option and optionally a given resource.|This message can also be sent to request the issuer (or its agent) to make available / deliver the relevant resources to the CSD.|Usage|This message is used to request the authorisation to process the entitlement movements calculated by the CSD for a given corporate action event and option. An Agent Corporate Action Global Distribution Authorisation Request message must be sent for each option and if several resources are associated to an option, an Agent Corporate Action Global Distribution Authorisation Request message can be sent for each resource.|This message can also be used to pre-advise a global distribution authorisation request, in which case the value of the field pre-advice indicator must be set to yes.")]
public partial record AgentCAGlobalDistributionAuthorisationRequestV01 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AgtCAGblDstrbtnAuthstnReq";
    
    /* ------------------------------------------ Underlying data types not ready yet
    public required string SomeProperty { get; init; }
    */
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="AgentCAGlobalDistributionAuthorisationRequestV01Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public AgentCAGlobalDistributionAuthorisationRequestV01Document ToDocument()
    {
        return new AgentCAGlobalDistributionAuthorisationRequestV01Document { Message = this };
    }
}

/// <summary>
/// Scope
/// This message is sent by a CSD to an issuer (or its agent) to request the authorisation to process the entitlement movements (cash and/or securities) calculated by the CSD for a given corporate action entire event, a given corporate action option and optionally a given resource.
/// This message can also be sent to request the issuer (or its agent) to make available / deliver the relevant resources to the CSD.
/// Usage
/// This message is used to request the authorisation to process the entitlement movements calculated by the CSD for a given corporate action event and option. An Agent Corporate Action Global Distribution Authorisation Request message must be sent for each option and if several resources are associated to an option, an Agent Corporate Action Global Distribution Authorisation Request message can be sent for each resource.
/// This message can also be used to pre-advise a global distribution authorisation request, in which case the value of the field pre-advice indicator must be set to yes.
/// This is the outer document that contains <seealso cref="AgentCAGlobalDistributionAuthorisationRequestV01"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record AgentCAGlobalDistributionAuthorisationRequestV01Document : IOuterDocument<AgentCAGlobalDistributionAuthorisationRequestV01>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:seev.017.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="AgentCAGlobalDistributionAuthorisationRequestV01"/> is required.
    /// </summary>
    public required AgentCAGlobalDistributionAuthorisationRequestV01 Message { get; init; }
}
