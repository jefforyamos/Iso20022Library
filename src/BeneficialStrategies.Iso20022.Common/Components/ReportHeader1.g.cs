﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ReportHeader1.  ISO2002 ID# _UsI9ANp-Ed-ak6NoX_4Aeg_-265750880.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// General properties of the report.
/// </summary>
public partial record ReportHeader1
{
    #nullable enable
    
    /// <summary>
    /// Date and time at which the report was created.
    /// </summary>
    public required IsoISODateTime CreationDateTime { get; init; } 
    /// <summary>
    /// Identification of the type of report.
    /// </summary>
    public required IsoMax35Text ContentsType { get; init; } 
    
    #nullable disable
}
