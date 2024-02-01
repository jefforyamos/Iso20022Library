﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Reference19.  ISO2002 ID# _Ql4SRdp-Ed-ak6NoX_4Aeg_1999754651.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides the references of the underlying trade leg(s) and/or the reference to the related NetPosition report message.
/// </summary>
public partial record Reference19
{
    #nullable enable
    
    /// <summary>
    /// Reference allocated by the central counterparty - central counterpatry trade leg reference identification that uniquely identifies the trade.
    /// </summary>
    public IsoMax35Text[] TradeLegNotificationIdentification { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// After netting, reference that is common to a net transaction to settle and all its underlying trades.
    /// </summary>
    public IsoMax35Text? NetPositionIdentification { get; init; } 
    
    #nullable disable
}
