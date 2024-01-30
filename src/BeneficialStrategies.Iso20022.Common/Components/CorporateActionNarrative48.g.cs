﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CorporateActionNarrative48.  ISO2002 ID# _x_UOzx9REeuFz_FaCzCLgQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides additional information such as the taxation conditions.
/// </summary>
public partial record CorporateActionNarrative48
{
    #nullable enable
    
    /// <summary>
    /// Provides additional information or specifies in more detail the content of a message. This field may only be used when the information to be transmitted, cannot be coded.
    /// </summary>
    public UpdatedAdditionalInformation14? AdditionalText { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Provides information that can be ignored for automated processing; - reiteration of information that has been included within structured fields, - or narrative information not needed for automatic processing.
    /// </summary>
    public UpdatedAdditionalInformation14? NarrativeVersion { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Provides conditional information related to the event, for example, an offer is subject to 50 percent acceptance, the offeror allows the securities holder to set some conditions.
    /// </summary>
    public UpdatedAdditionalInformation15? InformationConditions { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Provides information conditions to the account owner that are to be complied with, for example, not open to US/Canadian residents, Qualified Institutional Buyers (QIB) or SIL (Sophisticated Investor Letter) to be provided.
    /// </summary>
    public UpdatedAdditionalInformation15? InformationToComplyWith { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Provides restriction(s) on securities.
    /// </summary>
    public UpdatedAdditionalInformation15? SecurityRestriction { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Provides taxation conditions that cannot be included within the structured fields of this message and has not been mentioned in the Service Level Agreement (SLA).
    /// </summary>
    public UpdatedAdditionalInformation15? TaxationConditions { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Provides a disclaimer relative to the information provided in the message. It may be ignored for automated processing.
    /// </summary>
    public UpdatedAdditionalInformation15? Disclaimer { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Provides additional information about the type of certification/breakdown required.
    /// </summary>
    public UpdatedAdditionalInformation15? CertificationBreakdown { get; init;  } // Warning: Don't know multiplicity.
    
    #nullable disable
}
