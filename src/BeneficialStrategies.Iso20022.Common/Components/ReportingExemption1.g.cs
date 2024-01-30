﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ReportingExemption1.  ISO2002 ID# _F10woBaIEe27wrM4RUjLog.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides details on the reporting exemption of a counterparty.
/// </summary>
public partial record ReportingExemption1
{
    #nullable enable
    
    /// <summary>
    /// Code specifying exemption applicable to a counterparty.
    /// </summary>
    public required IsoMax4Text Reason { get; init; } 
    /// <summary>
    /// Textual description of applicable exemption.
    /// </summary>
    public IsoMax1000Text? Description { get; init; } 
    
    #nullable disable
}
