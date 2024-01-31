﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by MainMessageGenerator for AgentCAElectionAdviceV01.  ISO2002 ID# _TMtG-tEwEd-BzquC8wXy7w_1166385439.
//

using System.ComponentModel.DataAnnotations;
using BeneficialStrategies.Iso20022.Components;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.seev;


/// <summary>
/// Scope
/// This message is sent by a CSD to the issuer (or its agent) to provide information about the clients' election instruction, the registration details, the delivery details, etc. In case of an election with underlying resource movements, it also confirms that these have been completed. This message may also be sent in case of an amendment of an election, once the CSD has completed the required resource movements.
/// Usage
/// This message can be used for a new election advice or an amended election advice.
/// If this message is used for a new election advice, the function of the message must be 'new election'.
/// If this message is used for an amended election advice, the function of the message must be 'option change' and the identification of the previously sent election advice must be present.
/// This message can include the cash movements and/or securities movements in the case of an election with underlying resource movements. Additionally, this message can include delivery, certification and beneficial owner details.
/// Note: this information can be also sent separately in the Agent Corporate Action Information advice message.
/// </summary>
[Serializable]
[DataContract(Name = XmlTag)]
[XmlType(TypeName = XmlTag)]
[Description(@"Scope|This message is sent by a CSD to the issuer (or its agent) to provide information about the clients' election instruction, the registration details, the delivery details, etc. In case of an election with underlying resource movements, it also confirms that these have been completed. This message may also be sent in case of an amendment of an election, once the CSD has completed the required resource movements.|Usage|This message can be used for a new election advice or an amended election advice.|If this message is used for a new election advice, the function of the message must be 'new election'.|If this message is used for an amended election advice, the function of the message must be 'option change' and the identification of the previously sent election advice must be present.|This message can include the cash movements and/or securities movements in the case of an election with underlying resource movements. Additionally, this message can include delivery, certification and beneficial owner details.|Note: this information can be also sent separately in the Agent Corporate Action Information advice message.")]
public partial record AgentCAElectionAdviceV01 : IOuterRecord
{
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AgtCAElctnAdvc";
    
    #nullable enable
    /// <summary>
    /// Identification assigned by the Sender to unambiguously identify the advice.
    /// </summary>
    [IsoId("_TMtG-9EwEd-BzquC8wXy7w_-42698000")]
    [Description(@"Identification assigned by the Sender to unambiguously identify the advice.")]
    [DataMember(Name="Id")]
    [XmlElement(ElementName="Id")]
    [Required]
    public required DocumentIdentification8 Identification { get; init; }
    
    /// <summary>
    /// Provides information about the type of election advice and linked messages.
    /// </summary>
    [IsoId("_TM238NEwEd-BzquC8wXy7w_-1990867488")]
    [Description(@"Provides information about the type of election advice and linked messages.")]
    [DataMember(Name="ElctnAdvcTpAndLkg")]
    [XmlElement(ElementName="ElctnAdvcTpAndLkg")]
    [Required]
    public required ElectionAdviceFunction1 ElectionAdviceTypeAndLinkage { get; init; }
    
    /// <summary>
    /// General information about the corporate action event.
    /// </summary>
    [IsoId("_TM238dEwEd-BzquC8wXy7w_1272192692")]
    [Description(@"General information about the corporate action event.")]
    [DataMember(Name="CorpActnGnlInf")]
    [XmlElement(ElementName="CorpActnGnlInf")]
    [Required]
    public required CorporateActionInformation1 CorporateActionGeneralInformation { get; init; }
    
    /// <summary>
    /// Provides information about the election(s).
    /// </summary>
    [IsoId("_TM238tEwEd-BzquC8wXy7w_-1547276927")]
    [Description(@"Provides information about the election(s).")]
    [DataMember(Name="ElctnDtls")]
    [XmlElement(ElementName="ElctnDtls")]
    [Required]
    public required CorporateActionElection3 ElectionDetails { get; init; }
    
    /// <summary>
    /// Provides additional information about the delivery details, beneficial owner details, etc.
    /// </summary>
    [IsoId("_TM2389EwEd-BzquC8wXy7w_-1731981881")]
    [Description(@"Provides additional information about the delivery details, beneficial owner details, etc.")]
    [DataMember(Name="AddtlInf")]
    [XmlElement(ElementName="AddtlInf")]
    public CorporateActionAdditionalInformation1? AdditionalInformation { get; init; }
    
    /// <summary>
    /// Contact responsible for the transaction identified in the message.
    /// </summary>
    [IsoId("_TM239NEwEd-BzquC8wXy7w_-741674043")]
    [Description(@"Contact responsible for the transaction identified in the message.")]
    [DataMember(Name="CtctDtls")]
    [XmlElement(ElementName="CtctDtls")]
    public ContactPerson1? ContactDetails { get; init; }
    
    #nullable disable
    
    /// <summary>
    /// Using the state of this record, returns a populated <seealso cref="AgentCAElectionAdviceV01Document"/>, usually for the purpose of ISO20022 standard serialization.
    /// </summary>
    public AgentCAElectionAdviceV01Document ToDocument()
    {
        return new AgentCAElectionAdviceV01Document { Message = this };
    }
}

/// <summary>
/// This is the outer document that contains the XML serialization wrapper and necessary namespaces for proper serialization.
/// For a more complete description of the business meaning of the message, see the underlying <seealso cref="AgentCAElectionAdviceV01"/>.
/// </summary>
[Serializable]
[DataContract(Name = DocumentElementName, Namespace = DocumentNamespace )]
[XmlRoot(ElementName = DocumentElementName, Namespace = DocumentNamespace )]
public partial record AgentCAElectionAdviceV01Document : IOuterDocument<AgentCAElectionAdviceV01>
{
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:seev.012.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The instance of <seealso cref="AgentCAElectionAdviceV01"/> is required.
    /// </summary>
    public required AgentCAElectionAdviceV01 Message { get; init; }
}
