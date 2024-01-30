﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for DeliverInformation8.  ISO2002 ID# _4Nxqo_soEeCFJsO61PplcQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Parameters applied to the settlement of a security transfer.
/// </summary>
public partial record DeliverInformation8
{
    #nullable enable
    
    /// <summary>
    /// Total amount of money paid /to be paid or received in exchange for the financial instrument in the individual order.
    /// </summary>
    public IsoActiveCurrencyAndAmount? SettlementAmount { get; init; } 
    /// <summary>
    /// Indicates whether the settlement amount includes the stamp duty amount.
    /// </summary>
    public StampDutyType2Code? StampDuty { get; init; } 
    /// <summary>
    /// Deal amount.
    /// </summary>
    public IsoActiveCurrencyAndAmount? NetAmount { get; init; } 
    /// <summary>
    /// Chain of parties involved in the settlement of a transaction.
    /// </summary>
    public required DeliveringPartiesAndAccount8 SettlementPartiesDetails { get; init; } 
    /// <summary>
    /// Charge related to the transfer of a financial instrument.
    /// </summary>
    public Charge20? ChargeDetails { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Commission related to the transfer of a financial instrument.
    /// </summary>
    public Commission12? CommissionDetails { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Tax related to the transfer of a financial instrument.
    /// </summary>
    public Tax15? TaxDetails { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Indicates whether the financial instrument is to be physically delivered.
    /// </summary>
    public PhysicalTransferType1Code? PhysicalTransfer { get; init; } 
    /// <summary>
    /// Parameters of a physical delivery.
    /// </summary>
    public DeliveryParameters4? PhysicalTransferDetails { get; init; } 
    
    #nullable disable
}
