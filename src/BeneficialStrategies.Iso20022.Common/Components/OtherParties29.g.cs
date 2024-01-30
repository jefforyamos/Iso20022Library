﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for OtherParties29.  ISO2002 ID# _5nIEFZNLEeWGlc8L7oPDIg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Other parties information.
/// </summary>
public partial record OtherParties29
{
    #nullable enable
    
    /// <summary>
    /// Party, either an individual or organisation, whose assets are being invested.
    /// </summary>
    public PartyIdentificationAndAccount135? Investor { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Foreign Financial Institution which has been authorised by local authorities to act as account management institution in the country.
    /// </summary>
    public PartyIdentificationAndAccount136? QualifiedForeignIntermediary { get; init; } 
    /// <summary>
    /// Identification of the stock exchange to which transaction reporting will be done.
    /// </summary>
    public PartyIdentificationAndAccount137? StockExchange { get; init; } 
    /// <summary>
    /// Institution to which a trade must be reported.
    /// </summary>
    public PartyIdentificationAndAccount137? TradeRegulator { get; init; } 
    /// <summary>
    /// Party responsible for the administration of a tri-party collateral transaction including collateral allocation, marking to market and substitution of collateral.
    /// </summary>
    public PartyIdentificationAndAccount136? TripartyAgent { get; init; } 
    /// <summary>
    /// Party that identifies a broker when required (for example, authorised broker, prime broker, etc).
    /// </summary>
    public PartyIdentificationAndAccount136? Broker { get; init; } 
    
    #nullable disable
}
