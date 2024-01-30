﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for BusinessError.  ISO2002 ID# _w64j45lcEeeE1Ya-LgRsuQ.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.BusinessDayReportOrError8Choice;

/// <summary>
/// Reason the requested business information is not given.
/// </summary>
public partial record BusinessError : IBusinessDayReportOrError8Choice
{
    #nullable enable
    /// <summary>
    /// Specification of the error, in coded or proprietary form.
    /// </summary>
    public required IErrorHandling2Choice Error { get; init; } 
    /// <summary>
    /// Specification of the error, in free format.
    /// </summary>
    public IsoMax140Text? Description { get; init; } 
    #nullable disable
}
