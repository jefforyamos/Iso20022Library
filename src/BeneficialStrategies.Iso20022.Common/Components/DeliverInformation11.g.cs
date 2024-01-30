﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for DeliverInformation11.  ISO2002 ID# _ytfLYRgmEeK-_89we2b-bA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Completion of a securities settlement instruction, wherein securities are delivered/debited from a securities account and received/credited to the designated securities account.
/// </summary>
public partial record DeliverInformation11
{
    #nullable enable
    
    /// <summary>
    /// Date and time at which the securities are to be exchanged at the International Central Securities Depository (ICSD) or Central Securities Depository (CSD).
    /// </summary>
    public IsoISODate? RequestedSettlementDate { get; init; } 
    /// <summary>
    /// Date and time at which the securities were exchanged at the International Central Securities Depository (ICSD) or Central Securities Depository (CSD).
    /// </summary>
    public IDateAndDateTimeChoice? EffectiveSettlementDate { get; init; } 
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
    /// Chain of parties involved in the settlement of a transaction.
    /// </summary>
    public DeliveringPartiesAndAccount8? SettlementPartiesDetails { get; init; } 
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
