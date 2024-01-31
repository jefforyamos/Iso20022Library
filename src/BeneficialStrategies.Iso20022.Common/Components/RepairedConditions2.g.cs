﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for RepairedConditions2.  ISO2002 ID# _U3USS9p-Ed-ak6NoX_4Aeg_-1187208577.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Charge or commission of the original individual order details that have been repaired so that the order can be accepted.
/// </summary>
public partial record RepairedConditions2
{
    #nullable enable
    
    /// <summary>
    /// Charge from the original individual order details that has been repaired so that the order can be accepted.
    /// </summary>
    public IReadOnlyCollection<Charge11> RepairedCharge { get; init; } = [];
    /// <summary>
    /// Commission from the original individual order details that has been repaired so that the order can be accepted.
    /// </summary>
    public IReadOnlyCollection<Commission7> RepairedCommission { get; init; } = [];
    
    #nullable disable
}
