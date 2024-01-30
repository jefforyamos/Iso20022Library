﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AdditionalService1.  ISO2002 ID# _tv_4oJ8NEei6TYPuA7AYQg.
//

using BeneficialStrategies.Iso20022.Choices;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Additional functions or services to be performed in conjunction with the transaction.
/// </summary>
public partial record AdditionalService1
{
    #nullable enable
    
    /// <summary>
    /// Type of additional service applied to the transaction.
    /// </summary>
    public required AdditionalServiceType1Code Type { get; init; } 
    /// <summary>
    /// Other additional service applied to the transaction.
    /// </summary>
    public IsoMax35Text? OtherType { get; init; } 
    
    #nullable disable
}
