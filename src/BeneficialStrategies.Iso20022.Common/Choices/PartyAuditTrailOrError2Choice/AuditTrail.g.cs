﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for AuditTrail.  ISO2002 ID# _HK0lEWjHEeiCUdTMLdZoIg.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.PartyAuditTrailOrError2Choice;

/// <summary>
/// Provides the details of the audit trail data reported.
/// </summary>
public partial record AuditTrail : IPartyAuditTrailOrError2Choice
{
    #nullable enable
    /// <summary>
    /// Individual record of the party audit trail.
    /// </summary>
    public IUpdateLogPartyRecord1Choice? Record { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Timestamp of the change.
    /// </summary>
    public required IsoISODateTime OperationTimeStamp { get; init; } 
    /// <summary>
    /// User who instructed the change.
    /// </summary>
    public required IsoMax256Text InstructingUser { get; init; } 
    /// <summary>
    /// User who approved the change instructed by the instructing user.
    /// </summary>
    public IsoMax256Text? ApprovingUser { get; init; } 
    #nullable disable
}
