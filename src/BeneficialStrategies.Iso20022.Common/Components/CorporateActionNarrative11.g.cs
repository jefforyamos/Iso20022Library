﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CorporateActionNarrative11.  ISO2002 ID# _ULEQUNp-Ed-ak6NoX_4Aeg_-1561052303.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides additional information such as the taxation conditions.
/// </summary>
public partial record CorporateActionNarrative11
{
    #nullable enable
    
    /// <summary>
    /// Provides additional information or specifies in more detail the content of a message. This field may only be used when the information to be transmitted, cannot be coded.
    /// </summary>
    public UpdatedAdditionalInformation2? AdditionalText { get; init; } 
    /// <summary>
    /// Provides information that can be ignored for automated processing; - reiteration of information that has been included within structured fields of this message, - or narrative information not needed for automatic processing.
    /// </summary>
    public UpdatedAdditionalInformation2? NarrativeVersion { get; init; } 
    /// <summary>
    /// Provides conditional information related to the event, for example, an offer is subject to 50 percent acceptance, the offeror allows the securities holder to set some conditions.
    /// </summary>
    public UpdatedAdditionalInformation2? InformationConditions { get; init; } 
    /// <summary>
    /// Provides information conditions to the account owner that are to be complied with, for example, not open to US/Canadian residents, Qualified Institutional Buyers (QIB) or SIL (Sophisticated Investor Letter) to be provided.
    /// </summary>
    public UpdatedAdditionalInformation2? InformationToComplyWith { get; init; } 
    /// <summary>
    /// Provides taxation conditions that cannot be included within the structured fields of this message and has not been mentioned in the Service Level Agreement (SLA).
    /// </summary>
    public UpdatedAdditionalInformation2? TaxationConditions { get; init; } 
    /// <summary>
    /// Provides a disclaimer relative to the information provided in the message. It may be ignored for automated processing.
    /// </summary>
    public UpdatedAdditionalInformation2? Disclaimer { get; init; } 
    /// <summary>
    /// Provides additional information regarding the party, for example, the contact unit or person responsible for the transaction identified in the message.
    /// </summary>
    public UpdatedAdditionalInformation2? PartyContactNarrative { get; init; } 
    /// <summary>
    /// Provides declaration details narrative relative to the financial instrument, for example, beneficial ownership.
    /// </summary>
    public UpdatedAdditionalInformation2? DeclarationDetails { get; init; } 
    /// <summary>
    /// Provides information required for the registration.
    /// </summary>
    public UpdatedAdditionalInformation2? RegistrationDetails { get; init; } 
    /// <summary>
    /// Provides additional information on the basket or index underlying a security, for example a warrant.
    /// </summary>
    public UpdatedAdditionalInformation2? BasketOrIndexInformation { get; init; } 
    
    #nullable disable
}
