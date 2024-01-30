﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for OtherParties18.  ISO2002 ID# _AOPFx9okEeC60axPepSq7g_1209561399.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides details about business parties involved in the transaction.
/// </summary>
public partial record OtherParties18
{
    #nullable enable
    
    /// <summary>
    /// Party that identifies the underlying investor.
    /// </summary>
    public PartyIdentificationAndAccount79? Investor { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Party that identifies the stock exchange.
    /// </summary>
    public PartyIdentificationAndAccount87? StockExchange { get; init; } 
    /// <summary>
    /// Party that identifies the trade regulator.
    /// </summary>
    public PartyIdentificationAndAccount87? TradeRegulator { get; init; } 
    /// <summary>
    /// Party that handles tri-party transactions.
    /// </summary>
    public PartyIdentificationAndAccount83? TripartyAgent { get; init; } 
    /// <summary>
    /// Foreign Financial Institution which has been authorised by local authorities to act as account management institution in the country.
    /// </summary>
    public PartyIdentificationAndAccount77? QualifiedForeignIntermediary { get; init; } 
    
    #nullable disable
}
