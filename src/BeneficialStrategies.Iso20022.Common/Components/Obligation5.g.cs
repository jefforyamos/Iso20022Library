﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Obligation5.  ISO2002 ID# _oZfTEa_XEeaiqo1qOdNaWg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides information like the identification of the party or parties associated with the collateral agreement, the exposure type and the valuation date.
/// </summary>
public partial record Obligation5
{
    #nullable enable
    
    /// <summary>
    /// Defines one of the entities associated with the collateral agreement.
    /// </summary>
    public required PartyIdentification100Choice_ PartyA { get; init; } 
    /// <summary>
    /// Specifies the party that is acting on behalf of party A and that offers collateral management services.
    /// </summary>
    public PartyIdentification100Choice_? ServicingPartyA { get; init; } 
    /// <summary>
    /// Defines the other entity associated with the collateral agreement.
    /// </summary>
    public required PartyIdentification100Choice_ PartyB { get; init; } 
    /// <summary>
    /// Specifies the party that is acting on behalf of party B and that offers collateral management services.
    /// </summary>
    public PartyIdentification100Choice_? ServicingPartyB { get; init; } 
    /// <summary>
    /// Provides additional information on the collateral account of the party delivering/receiving the collateral.
    /// </summary>
    public CollateralAccount3? CollateralAccountIdentification { get; init; } 
    /// <summary>
    /// Specifies the underlying business area or type of trade causing the collateral movement.
    /// </summary>
    public ExposureType5Code? ExposureType { get; init; } 
    /// <summary>
    /// Indicates the close of business date on which the initiating party is valuing the margin call.
    /// </summary>
    public required DateAndDateTimeChoice_ ValuationDate { get; init; } 
    
    #nullable disable
}
