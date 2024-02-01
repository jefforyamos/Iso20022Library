﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for CHIPSParticipantIdentification.  ISO2002 ID# _VwSCabNIEeejueAciesPMA.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ClearingSystemMemberIdentification4Choice;

/// <summary>
/// (United States) Clearing House Interbank Payment System (CHIPS) Participant Identifier (ID) - identifies financial institutions participating on CHIPS. The CHIPS Participant ID is assigned by the New York Clearing House.
/// </summary>
public partial record CHIPSParticipantIdentification : ClearingSystemMemberIdentification4Choice_
{
    public required IsoCHIPSParticipantIdentifier Value { get; init; }
}
