﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for ClearingSystemMemberIdentification.  ISO2002 ID# _iR9BhXSbEeiH1ZOt2UD8vQ.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.MemberIdentification3Choice;

/// <summary>
/// Information used to identify a member within a clearing system.
/// </summary>
public partial record ClearingSystemMemberIdentification : IMemberIdentification3Choice
{
    #nullable enable
    /// <summary>
    /// Specification of a pre-agreed offering between clearing agents or the channel through which the payment instruction is processed.
    /// </summary>
    public IClearingSystemIdentification2Choice? ClearingSystemIdentification { get; init; } 
    /// <summary>
    /// Identification of a member of a clearing system.
    /// </summary>
    public required IsoMax35Text MemberIdentification { get; init; } 
    #nullable disable
}
