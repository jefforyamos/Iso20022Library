﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for BusinessError.  ISO2002 ID# _kEyRE3SbEeiH1ZOt2UD8vQ.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.MemberReportOrError6Choice;

/// <summary>
/// Reason the requested business information is not given.
/// </summary>
public partial record BusinessError : MemberReportOrError6Choice_
{
    #nullable enable
    /// <summary>
    /// Specification of the error, in coded or proprietary form.
    /// </summary>
    public required ErrorHandling1Choice_ Error { get; init; } 
    /// <summary>
    /// Specification of the error, in free format.
    /// </summary>
    public IsoMax140Text? Description { get; init; } 
    #nullable disable
}
