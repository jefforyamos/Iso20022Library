﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for RestrictionIdentification1.  ISO2002 ID# _3d1RINj7EeiHnvcp3FV_5w.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Restriction References applied on the transaction for which the securities settlement condition modification is requested.
/// </summary>
public partial record RestrictionIdentification1
{
    #nullable enable
    
    /// <summary>
    /// Restriction identification removal or addition applied on the transaction expressed as a code.
    /// </summary>
    public required RestrictionReference1Code Code { get; init; } 
    /// <summary>
    /// Restriction identification applied on the transaction.
    /// </summary>
    public required IsoMax35Text Identification { get; init; } 
    
    #nullable disable
}
