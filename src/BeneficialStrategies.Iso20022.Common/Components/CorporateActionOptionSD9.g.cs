﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CorporateActionOptionSD9.  ISO2002 ID# _OOwPW3h4EeOF3uSOaAf1Lg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides additional information regarding corporate action option details.
/// </summary>
public partial record CorporateActionOptionSD9
{
    #nullable enable
    
    /// <summary>
    /// xPath to the element that is being extended.
    /// </summary>
    public required IsoMax350Text PlaceAndName { get; init; } 
    /// <summary>
    /// Used for options that have particular proprietary feature that cannot be represented in standard ISO message.
    /// </summary>
    public ExtendedOptionFeature1Code? ExtendedOptionFeatures { get; init; } 
    /// <summary>
    /// Identifies whether the option will be processed as default by DTC (The Depository Trust Corporation) when no election is made.
    /// </summary>
    public IsoYesNoIndicator? DTCDefaultOptionFlag { get; init; } 
    /// <summary>
    /// Indicates whether optional dividend supplementary data are required in the ISO 20022 CAIN instructions for this event.
    /// </summary>
    public IsoYesNoIndicator? OptionalDividendSupplementaryDataRequiredFlag { get; init; } 
    /// <summary>
    /// Unique DTCC legacy reference used for matching and reconciling legacy records. The number algorhithm is as follows: Department ID (1:1), Activity Type (2:3), Cusip Country Code (5:2), Cusip (7:9), Record Date (15:8), Payable Date (22:8), Sequence Number (29:3), RDP Issue Type (31:1). 
    /// USAGE RULE: this sequence can be populated /extended to event details, option details or a movement, depending on sequence number coordinality to an event.
    /// </summary>
    public IsoExact32AlphaNumericText? RDPReferenceNumber { get; init; } 
    
    #nullable disable
}
