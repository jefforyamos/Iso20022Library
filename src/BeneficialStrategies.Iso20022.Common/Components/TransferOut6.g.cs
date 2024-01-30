﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for TransferOut6.  ISO2002 ID# _RNN_ENp-Ed-ak6NoX_4Aeg_-755638591.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about the confirmation of a transfer out transaction.
/// </summary>
public partial record TransferOut6
{
    #nullable enable
    
    /// <summary>
    /// General information related to the transfer of a financial instrument.
    /// </summary>
    public required Transfer10 TransferDetails { get; init; } 
    /// <summary>
    /// Information related to the financial instrument withdrawn.
    /// </summary>
    public required FinancialInstrument13 FinancialInstrumentDetails { get; init; } 
    /// <summary>
    /// Information related to the account from which the financial instrument was withdrawn.
    /// </summary>
    public required InvestmentAccount22 AccountDetails { get; init; } 
    /// <summary>
    /// Information related to the receiving side of the transfer.
    /// </summary>
    public required ReceiveInformation4 SettlementDetails { get; init; } 
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    public Extension1? Extension { get; init;  } // Warning: Don't know multiplicity.
    
    #nullable disable
}
