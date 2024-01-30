﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ListIdentification1.  ISO2002 ID# _SzmHBtp-Ed-ak6NoX_4Aeg_1241706785.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Unique identifier for a list as assigned by institution, used to associate multiple individual orders. Uniqueness must be guaranteed within a single trading day. Institutions which generate multi-day orders should consider embedding a date to assure uniqueness across days.
/// </summary>
public partial record ListIdentification1
{
    #nullable enable
    
    /// <summary>
    /// Unique identifier for a list, as assigned by the trading party. The identifier must be unique within a single trading day.
    /// </summary>
    public required IsoMax35Text ListIdentification { get; init; } 
    
    #nullable disable
}
