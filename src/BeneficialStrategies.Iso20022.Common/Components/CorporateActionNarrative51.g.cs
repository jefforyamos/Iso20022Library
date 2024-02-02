﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CorporateActionNarrative51.  ISO2002 ID# _9zlaoRcBEeyroI8qKgB7Mg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides additional information such as the taxation conditions.
/// </summary>
[DataContract]
[XmlType]
public partial record CorporateActionNarrative51
{
    #nullable enable
    
    /// <summary>
    /// Provides additional information or specifies in more detail the content of a message. This field may only be used when the information to be transmitted, cannot be coded.
    /// </summary>
    [DataMember]
    public ValueList<UpdatedAdditionalInformation13> AdditionalText { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Provides information that can be ignored for automated processing; - reiteration of information that has been included within structured fields, - or narrative information not needed for automatic processing.
    /// </summary>
    [DataMember]
    public ValueList<UpdatedAdditionalInformation13> NarrativeVersion { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Provides conditional information related to the event, for example, an offer is subject to 50 percent acceptance, the offeror allows the securities holder to set some conditions.
    /// </summary>
    [DataMember]
    public ValueList<UpdatedAdditionalInformation13> InformationConditions { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Provides information conditions to the account owner that are to be complied with, for example, not open to US/Canadian residents, Qualified Institutional Buyers (QIB) or SIL (Sophisticated Investor Letter) to be provided.
    /// </summary>
    [DataMember]
    public ValueList<UpdatedAdditionalInformation13> InformationToComplyWith { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Provides taxation conditions that cannot be included within the structured fields of this message and has not been mentioned in the Service Level Agreement (SLA).
    /// </summary>
    [DataMember]
    public ValueList<UpdatedAdditionalInformation13> TaxationConditions { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Provides a disclaimer relative to the information provided in the message. It may be ignored for automated processing.
    /// </summary>
    [DataMember]
    public ValueList<UpdatedAdditionalInformation13> Disclaimer { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Provides additional information regarding the party, for example, the contact unit or person responsible for the transaction identified in the message.
    /// </summary>
    [DataMember]
    public ValueList<UpdatedAdditionalInformation13> PartyContactNarrative { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Provides information required for the registration.
    /// </summary>
    [DataMember]
    public ValueList<UpdatedAdditionalInformation13> RegistrationDetails { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Provides additional information on the basket or index underlying a security, for example a warrant.
    /// </summary>
    [DataMember]
    public ValueList<UpdatedAdditionalInformation13> BasketOrIndexInformation { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Provides additional information about the type of certification/breakdown required.
    /// </summary>
    [DataMember]
    public ValueList<UpdatedAdditionalInformation13> CertificationBreakdown { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Provides the web address published for the event, that is, the address for the Universal Resource Locator (URL), for example, used over the www (HTTP) service.
    /// </summary>
    [DataMember]
    public ValueList<UpdatedURLlnformation4> URLAddress { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Provides additional information from the account servicer or a service provider solely intended for the next immediate account holder to enable or facilitate event processing between parties.
    /// </summary>
    [DataMember]
    public ValueList<UpdatedAdditionalInformation13> ProcessingTextForNextIntermediary { get; init; } = []; // Warning: Don't know multiplicity.
    
    #nullable disable
}
