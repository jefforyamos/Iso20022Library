﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Transfer26.  ISO2002 ID# _3GogcRgnEeK-_89we2b-bA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Completion of a securities settlement instruction, wherein securities are delivered/debited from a securities account and received/credited to the designated securities account.
/// </summary>
[DataContract]
[XmlType]
public partial record Transfer26
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identifier for a transfer execution, as assigned by a confirming party.
    /// </summary>
    [DataMember]
    public required IsoMax35Text TransferConfirmationReference { get; init; } 
    /// <summary>
    /// Unique and unambiguous identifier for a transfer instruction, as assigned by the instructing party.
    /// </summary>
    [DataMember]
    public required IsoMax35Text TransferReference { get; init; } 
    /// <summary>
    /// Unique and unambiguous investor's identification of a transfer. This reference can typically be used in a hub scenario to give the reference of the transfer as assigned by the underlying client.
    /// </summary>
    [DataMember]
    public IsoMax35Text? ClientReference { get; init; } 
    /// <summary>
    /// Unambiguous identification of the transfer allocated by the counterparty.
    /// </summary>
    [DataMember]
    public AdditionalReference2? CounterpartyReference { get; init; } 
    /// <summary>
    /// Date and time at which the transfer was executed.
    /// </summary>
    [DataMember]
    public required DateAndDateTimeChoice_ EffectiveTransferDate { get; init; } 
    /// <summary>
    /// Date and time at which the securities are to be exchanged at the International Central Securities Depository (ICSD) or Central Securities Depository (CSD).
    /// </summary>
    [DataMember]
    public IsoISODate? RequestedSettlementDate { get; init; } 
    /// <summary>
    /// Date and time at which the securities were exchanged at the International Central Securities Depository (ICSD) or Central Securities Depository (CSD).
    /// </summary>
    [DataMember]
    public DateAndDateTimeChoice_? EffectiveSettlementDate { get; init; } 
    /// <summary>
    /// Date and time at which a transaction is completed and cleared, ie, securities are delivered.
    /// </summary>
    [DataMember]
    public DateAndDateTimeChoice_? TradeDate { get; init; } 
    /// <summary>
    /// Identifies in which date the investor signed the transfer order form.
    /// </summary>
    [DataMember]
    public IsoISODate? TransferOrderDateForm { get; init; } 
    /// <summary>
    /// Specifies the reason for the assets transfer.
    /// </summary>
    [DataMember]
    public TransferReason1? TransferReason { get; init; } 
    /// <summary>
    /// Identifies whether or not saving plan or withdrawal or switch plan are included in the holdings.
    /// </summary>
    [DataMember]
    public ValueList<HoldingsPlanType1Code> HoldingsPlanType { get; init; } = [];
    /// <summary>
    /// Information related to the financial instrument received.
    /// </summary>
    [DataMember]
    public required FinancialInstrument13 FinancialInstrumentDetails { get; init; } 
    /// <summary>
    /// Total quantity of securities settled.
    /// </summary>
    [DataMember]
    public required FinancialInstrumentQuantity1 TotalUnitsNumber { get; init; } 
    /// <summary>
    /// Information about the units to be transferred.
    /// </summary>
    [DataMember]
    public ValueList<Unit3> UnitsDetails { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Value of a security, as booked in an account. Book value is often different from the current market value of the security.
    /// </summary>
    [DataMember]
    public IsoActiveOrHistoricCurrencyAnd13DecimalAmount? AveragePrice { get; init; } 
    /// <summary>
    /// Identifies the currency to be used to transfer the holdings.
    /// </summary>
    [DataMember]
    public CurrencyCode? TransferCurrency { get; init; } 
    /// <summary>
    /// Indicates whether the transfer results in a change of beneficial owner.
    /// </summary>
    [DataMember]
    public IsoYesNoIndicator? OwnAccountTransferIndicator { get; init; } 
    /// <summary>
    /// Additional specific settlement information for non-regulated traded funds.
    /// </summary>
    [DataMember]
    public IsoMax350Text? NonStandardSettlementInformation { get; init; } 
    /// <summary>
    /// Party that receives securities from the delivering agent via the place of settlement, for example, securities central depository.
    /// </summary>
    [DataMember]
    public PartyIdentificationAndAccount93? ReceivingAgentDetails { get; init; } 
    /// <summary>
    /// Party that delivers securities to the receiving agent at the place of settlement, for example, a central securities depository.
    /// </summary>
    [DataMember]
    public PartyIdentificationAndAccount93? DeliveringAgentDetails { get; init; } 
    
    #nullable disable
}
