﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ReportHeader2.  ISO2002 ID# _Rq4LdNp-Ed-ak6NoX_4Aeg_891312394.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies generic information about an investigation report.
/// </summary>
public partial record ReportHeader2
{
    #nullable enable
    
    /// <summary>
    /// Point to point reference as assigned by the case assigner to unambiguously identify the case status report.
    /// </summary>
    public required IsoMax35Text Identification { get; init; } 
    /// <summary>
    /// Party reporting the status of the investigation case.
    /// </summary>
    public required Party7Choice_ From { get; init; } 
    /// <summary>
    /// Party to which the status of the case is reported.
    /// </summary>
    public required Party7Choice_ To { get; init; } 
    /// <summary>
    /// Date and time at which the message was created.
    /// </summary>
    public required IsoISODateTime CreationDateTime { get; init; } 
    
    #nullable disable
}
