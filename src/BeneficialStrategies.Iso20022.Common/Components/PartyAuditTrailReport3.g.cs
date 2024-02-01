﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for PartyAuditTrailReport3.  ISO2002 ID# _QqREEZ9uEee7Qpz45yWJJw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Report information about party reference data.
/// </summary>
public partial record PartyAuditTrailReport3
{
    #nullable enable
    
    /// <summary>
    /// Identifies the returned party reference data or error information.
    /// </summary>
    public required PartyAuditTrailOrError2Choice_ PartyAuditTrailOrError { get; init; } 
    /// <summary>
    /// Period in dates for which the audit trail is provided.
    /// </summary>
    public DatePeriod3Choice_? DatePeriod { get; init; } 
    /// <summary>
    /// Identifies the party for which the audit trail is provided.
    /// </summary>
    public required SystemPartyIdentification8 PartyIdentification { get; init; } 
    
    #nullable disable
}
