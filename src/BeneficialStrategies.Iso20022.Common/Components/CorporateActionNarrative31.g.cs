﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CorporateActionNarrative31.  ISO2002 ID# _5X-ooWLLEeWR9ZSfjmHwUA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides additional information such as the taxation conditions.
/// </summary>
public partial record CorporateActionNarrative31
{
    #nullable enable
    
    /// <summary>
    /// Provides additional information or specifies in more detail the content of a message. This field may only be used when the information to be transmitted, cannot be coded.
    /// </summary>
    public IsoMax350Text? AdditionalText { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Provides information that can be ignored for automated processing; - reiteration of information that has been included within structured fields, - or narrative information not needed for automatic processing.
    /// </summary>
    public IsoMax350Text? NarrativeVersion { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Provides additional information regarding the party, for example, the contact unit or person responsible for the transaction identified in the message.
    /// </summary>
    public IsoMax350Text? PartyContactNarrative { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Provides taxation conditions that cannot be included within the structured fields of this message and has not been mentioned in the Service Level Agreement (SLA).
    /// </summary>
    public IsoMax350Text? TaxationConditions { get; init;  } // Warning: Don't know multiplicity.
    
    #nullable disable
}
