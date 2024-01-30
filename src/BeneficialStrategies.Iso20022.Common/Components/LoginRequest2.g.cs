﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for LoginRequest2.  ISO2002 ID# _Mn8iYQ0yEeqUVL7sB4m7NA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Content of the Login Request message.
/// </summary>
public partial record LoginRequest2
{
    #nullable enable
    
    /// <summary>
    /// Date and Time of Login.
    /// </summary>
    public required IsoISODateTime LoginDateTime { get; init; } 
    /// <summary>
    /// Information related to the software of the Sale System which manages the Sale to POI protocol.
    /// </summary>
    public PointOfInteractionComponent10? SaleSoftware { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Information related to the software and hardware feature of the Sale Terminal.
    /// </summary>
    public SaleTerminalData1? SaleTerminalData { get; init; } 
    /// <summary>
    /// Training mode.
    /// </summary>
    public IsoTrueFalseIndicator? TrainingModeFlag { get; init; } 
    /// <summary>
    /// Identification of the cashier.
    /// </summary>
    public IsoMax35Text? CashierIdentification { get; init; } 
    /// <summary>
    /// Language of the cashier.
    /// </summary>
    public required LanguageCode CashierLanguage { get; init; } 
    /// <summary>
    /// Shift number of the cashier.
    /// </summary>
    public IsoMax2NumericText? ShiftNumber { get; init; } 
    /// <summary>
    /// Type of token replacing the PAN of a payment card to identify the payment mean of the customer.
    /// </summary>
    public SaleTokenScope1Code? TokenRequestedType { get; init; } 
    /// <summary>
    /// Type of customer orders that must be sent in response message.
    /// </summary>
    public CustomerOrderRequest1Code? CustomerOrderRequest { get; init; } 
    /// <summary>
    /// POI Terminal identification.
    /// </summary>
    public PointOfInteractionComponentIdentification1? POIIdentification { get; init; } 
    /// <summary>
    /// Default group identification for transaction consolidation (Totals).
    /// </summary>
    public IsoMax35Text? TotalsGroupIdentification { get; init; } 
    /// <summary>
    /// Message to be displayed.
    /// </summary>
    public ActionMessage7? OutputDisplay { get; init; } 
    
    #nullable disable
}
