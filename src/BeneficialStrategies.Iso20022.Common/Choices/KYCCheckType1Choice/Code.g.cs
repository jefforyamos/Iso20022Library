﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _CsmgIBRyEeOKWo1NF21OVw.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.KYCCheckType1Choice;

/// <summary>
/// Type of Know Your Customer (KYC) check type expressed as a code.
/// </summary>
public partial record Code : IKYCCheckType1Choice
{
    public required KnowYourCustomerCheckType1Code Value { get; init; }
}
