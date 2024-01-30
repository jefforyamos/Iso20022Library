﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CompareSecurityIdentification2.  ISO2002 ID# _DmnrQdScEemZdYGWu384Zw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies two values to compare for a securities identification.
/// </summary>
public partial record CompareSecurityIdentification2
{
    #nullable enable
    
    /// <summary>
    /// Information for the first side of the transaction.
    /// </summary>
    public ISecurityIdentification26Choice? Value1 { get; init; } 
    /// <summary>
    /// Information for the second of the transaction.
    /// </summary>
    public ISecurityIdentification26Choice? Value2 { get; init; } 
    
    #nullable disable
}
