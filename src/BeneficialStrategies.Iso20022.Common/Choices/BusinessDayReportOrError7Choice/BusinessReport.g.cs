﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for BusinessReport.  ISO2002 ID# _wq9RgZlcEeeE1Ya-LgRsuQ.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.BusinessDayReportOrError7Choice;

/// <summary>
/// Reports either business day information or a business error.
/// </summary>
public partial record BusinessReport : BusinessDayReportOrError7Choice_
{
    #nullable enable
    /// <summary>
    /// Identification of a particular market infrastructure.
    /// </summary>
    public SystemIdentification2Choice_? SystemIdentification { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Requested information on the system availability for a specific business day or business error when information has not been found.
    /// </summary>
    public required BusinessDayReportOrError8Choice_ BusinessDayOrError { get; init; } 
    #nullable disable
}
