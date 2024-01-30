﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Product7.  ISO2002 ID# _BiJBIfcsEeiW-auGnDPZIw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Product related to the transaction
/// </summary>
public partial record Product7
{
    #nullable enable
    
    /// <summary>
    /// Product code of the item.
    /// </summary>
    public IsoMax70Text? ProductCode { get; init; } 
    /// <summary>
    /// Provides the identifier assigned by the card acceptor that best categorizes the items being purchased in a standardized commodity group.
    /// </summary>
    public IsoMax35Text? SummaryCommodityIdentification { get; init; } 
    
    #nullable disable
}
