﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for RIC.  ISO2002 ID# _CSq4OSGQEeW7gKYhAMEFCw.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.SecurityIdentification23Choice;

/// <summary>
/// Reuters Identification Code (RIC). A numbering system used within the Reuters system to identify instruments worldwide. The RIC contains an X-character market specific code (can be the CUSIP or EPIC codes) followed by a full stop, then the two-digit ISO country code, for example, IBM in UK is IBM.UK.
/// </summary>
public partial record RIC : ISecurityIdentification23Choice
{
    public required IsoRICIdentifier Value { get; init; }
}
