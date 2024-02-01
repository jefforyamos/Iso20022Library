﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CorporateActionNarrative21.  ISO2002 ID# _zRqDUfocEeCs84bkrlkROA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides additional information such as the registration details.
/// </summary>
public partial record CorporateActionNarrative21
{
    #nullable enable
    
    /// <summary>
    /// Provides additional information or specifies in more detail the content of a message. This field may only be used when the information to be transmitted, cannot be coded.
    /// </summary>
    public IsoMax350Text[] AdditionalText { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Provides information that can be ignored for automated processing; - reiteration of information that has been included within structured fields of this message, - or narrative information not needed for automatic processing.
    /// </summary>
    public IsoMax350Text[] NarrativeVersion { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Provides information required for the registration.
    /// </summary>
    public IsoMax350Text[] RegistrationDetails { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Provides additional information regarding the party, for example, the contact unit or person responsible for the transaction identified in the message.
    /// </summary>
    public IsoMax350Text[] PartyContactNarrative { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Disclaimer relative to the information provided in the message. It may be ignored for automated processing. No information about the instruction itself is allowed here.
    /// </summary>
    public IsoMax350Text[] Disclaimer { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Provides additional information on the basket or index underlying a security, for example a warrant.
    /// </summary>
    public IsoMax350Text[] BasketOrIndexInformation { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Provides information required for the certification/breakdown.
    /// </summary>
    public IsoMax350Text[] CertificationBreakdown { get; init; } = []; // Warning: Don't know multiplicity.
    
    #nullable disable
}
