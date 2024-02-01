﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for PaymentInstruction40.  ISO2002 ID# _e0lYYdcZEeqRFcf2R4bPBw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Characteristics that apply to the debit side of the payment transactions included in the credit transfer initiation.
/// </summary>
public partial record PaymentInstruction40
{
    #nullable enable
    
    /// <summary>
    /// Unique identification, as assigned by a sending party, to unambiguously identify the payment information group within the message.
    /// </summary>
    public required IsoMax35Text PaymentInformationIdentification { get; init; } 
    /// <summary>
    /// Specifies the means of payment that will be used to move the amount of money.
    /// </summary>
    public required PaymentMethod3Code PaymentMethod { get; init; } 
    /// <summary>
    /// Type of advice details requested.
    /// </summary>
    public AdviceType1? RequestedAdviceType { get; init; } 
    /// <summary>
    /// Identifies whether a single entry per individual transaction or a batch entry for the sum of the amounts of all transactions within the group of a message is requested.|Usage: Batch booking is used to request and not order a possible batch booking.
    /// </summary>
    public IsoBatchBookingIndicator? BatchBooking { get; init; } 
    /// <summary>
    /// Number of individual transactions contained in the payment information group.
    /// </summary>
    public IsoMax15NumericText? NumberOfTransactions { get; init; } 
    /// <summary>
    /// Total of all individual amounts included in the group, irrespective of currencies.
    /// </summary>
    public IsoDecimalNumber? ControlSum { get; init; } 
    /// <summary>
    /// Set of elements used to further specify the type of transaction.
    /// </summary>
    public PaymentTypeInformation26? PaymentTypeInformation { get; init; } 
    /// <summary>
    /// Date at which the initiating party requests the clearing agent to process the payment. |Usage: This is the date on which the debtor's account is to be debited. If payment by cheque, the date when the cheque must be generated by the bank.
    /// </summary>
    public required DateAndDateTime2Choice_ RequestedExecutionDate { get; init; } 
    /// <summary>
    /// Date used for the correction of the value date of a cash pool movement that has been posted with a different value date.
    /// </summary>
    public IsoISODate? PoolingAdjustmentDate { get; init; } 
    /// <summary>
    /// Party that owes an amount of money to the (ultimate) creditor.
    /// </summary>
    public required PartyIdentification135 Debtor { get; init; } 
    /// <summary>
    /// Unambiguous identification of the account of the debtor to which a debit entry will be made as a result of the transaction.
    /// </summary>
    public required CashAccount40 DebtorAccount { get; init; } 
    /// <summary>
    /// Financial institution servicing an account for the debtor.
    /// </summary>
    public required BranchAndFinancialInstitutionIdentification6 DebtorAgent { get; init; } 
    /// <summary>
    /// Unambiguous identification of the account of the debtor agent at its servicing agent in the payment chain.
    /// </summary>
    public CashAccount40? DebtorAgentAccount { get; init; } 
    /// <summary>
    /// Further information related to the processing of the payment instruction, that may need to be acted upon by the debtor agent, depending on agreement between debtor and the debtor agent.
    /// Usage: when present, then the instructions for the debtor agent apply for all credit transfer transaction information occurrences, present in the payment information.
    /// </summary>
    public IsoMax140Text? InstructionForDebtorAgent { get; init; } 
    /// <summary>
    /// Ultimate party that owes an amount of money to the (ultimate) creditor.
    /// </summary>
    public PartyIdentification135? UltimateDebtor { get; init; } 
    /// <summary>
    /// Specifies which party/parties will bear the charges associated with the processing of the payment transaction.
    /// </summary>
    public ChargeBearerType1Code? ChargeBearer { get; init; } 
    /// <summary>
    /// Account used to process charges associated with a transaction.||Usage: Charges account should be used when charges have to be booked to an account different from the account identified in debtor's account.
    /// </summary>
    public CashAccount40? ChargesAccount { get; init; } 
    /// <summary>
    /// Agent that services a charges account.||Usage: Charges account agent should only be used when the charges account agent is different from the debtor agent.
    /// </summary>
    public BranchAndFinancialInstitutionIdentification6? ChargesAccountAgent { get; init; } 
    /// <summary>
    /// Provides information on the individual transaction(s) included in the message.
    /// </summary>
    public CreditTransferTransaction54[] CreditTransferTransactionInformation { get; init; } = []; // Warning: Don't know multiplicity.
    
    #nullable disable
}
