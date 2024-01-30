﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for PartyAuditTrailReport.  ISO2002 ID# _QqH6IZ9uEee7Qpz45yWJJw.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PartyAuditTrailOrError1Choice;

/// <summary>
/// Report information about party reference data.
/// </summary>
public partial record PartyAuditTrailReport : IPartyAuditTrailOrError1Choice
{
    #nullable enable
    /// <summary>
    /// Identifies the returned party reference data or error information.
    /// </summary>
    public required IPartyAuditTrailOrError2Choice PartyAuditTrailOrError { get; init; } 
    /// <summary>
    /// Period in dates for which the audit trail is provided.
    /// </summary>
    public IDatePeriod3Choice? DatePeriod { get; init; } 
    /// <summary>
    /// Identifies the party for which the audit trail is provided.
    /// </summary>
    public required SystemPartyIdentification8 PartyIdentification { get; init; } 
    #nullable disable
}
