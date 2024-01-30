﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for OtherParties32.  ISO2002 ID# _IYTBIZBfEeakHoV5BVecAQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides details about business parties involved in the transaction.
/// </summary>
public partial record OtherParties32
{
    #nullable enable
    
    /// <summary>
    /// Party that identifies the underlying investor.
    /// </summary>
    public PartyIdentificationAndAccount150? Investor { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Party that identifies the stock exchange.
    /// </summary>
    public PartyIdentificationAndAccount152? StockExchange { get; init; } 
    /// <summary>
    /// Party that identifies the trade regulator.
    /// </summary>
    public PartyIdentificationAndAccount152? TradeRegulator { get; init; } 
    /// <summary>
    /// Party that handles tri-party transactions.
    /// </summary>
    public PartyIdentificationAndAccount154? TripartyAgent { get; init; } 
    /// <summary>
    /// Foreign Financial Institution which has been authorised by local authorities to act as account management institution in the country.
    /// </summary>
    public PartyIdentificationAndAccount151? QualifiedForeignIntermediary { get; init; } 
    
    #nullable disable
}
