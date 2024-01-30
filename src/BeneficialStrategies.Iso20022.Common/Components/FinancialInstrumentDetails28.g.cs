﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for FinancialInstrumentDetails28.  ISO2002 ID# _v--6saOAEeeDTpy0mhI4TQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Reporting per financial instrument.
/// </summary>
public partial record FinancialInstrumentDetails28
{
    #nullable enable
    
    /// <summary>
    /// Financial instruments representing a sum of rights of the investor vis-a-vis the issuer.
    /// </summary>
    public required SecurityIdentification19 FinancialInstrumentIdentification { get; init; } 
    /// <summary>
    /// Information regarding the price of the instrument.
    /// </summary>
    public PriceInformation18? PriceDetails { get; init; } 
    /// <summary>
    /// Place where the securities are safe-kept, physically or notionally. This place can be, for example, a local custodian, a Central Securities Depository (CSD) or an International Central Securities Depository (ICSD).
    /// </summary>
    public SafeKeepingPlace1? SafekeepingPlace { get; init; } 
    /// <summary>
    /// Opening balance for the statement period (first opening balance) or of this page (intermediary opening balance).
    /// </summary>
    public OpeningBalance3? OpeningBalance { get; init; } 
    /// <summary>
    /// Closing balance for the statement period (final closing balance) or of this page (intermediary closing balance).
    /// </summary>
    public ClosingBalance3? ClosingBalance { get; init; } 
    /// <summary>
    /// Transaction details.
    /// </summary>
    public Transaction62? Transaction { get; init;  } // Warning: Don't know multiplicity.
    
    #nullable disable
}
