﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for OriginalMandate.  ISO2002 ID# _eBUvc9cZEeqRFcf2R4bPBw.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.OriginalMandate9Choice;

/// <summary>
/// Provides the original mandate data.
/// </summary>
public partial record OriginalMandate : OriginalMandate9Choice_
{
    #nullable enable
    /// <summary>
    /// Unique identification, as assigned by the responsible party (such as the creditor) or agent (such as the debtor agent), to unambiguously identify the mandate.
    /// </summary>
    public required IsoMax35Text MandateIdentification { get; init; } 
    /// <summary>
    /// Identification for the mandate request, as assigned by the initiating party.
    /// </summary>
    public IsoMax35Text? MandateRequestIdentification { get; init; } 
    /// <summary>
    /// Specifies the transport authentication details related to the mandate.
    /// </summary>
    public MandateAuthentication1? Authentication { get; init; } 
    /// <summary>
    /// Specifies the type of mandate, such as paper, electronic or scheme.
    /// </summary>
    public MandateTypeInformation2? Type { get; init; } 
    /// <summary>
    /// Provides details of the duration of the mandate and occurrence of the underlying transactions.
    /// </summary>
    public MandateOccurrences5? Occurrences { get; init; } 
    /// <summary>
    /// Specifies whether the direct debit instructions should be automatically re-submitted periodically when bilaterally agreed.
    /// </summary>
    public required IsoTrueFalseIndicator TrackingIndicator { get; init; } 
    /// <summary>
    /// Amount different from the collection amount, as it includes the costs associated with the first debited amount.
    /// </summary>
    public IsoActiveOrHistoricCurrencyAndAmount? FirstCollectionAmount { get; init; } 
    /// <summary>
    /// Fixed amount to be collected from the debtor's account.
    /// </summary>
    public IsoActiveOrHistoricCurrencyAndAmount? CollectionAmount { get; init; } 
    /// <summary>
    /// Maximum amount that may be collected from the debtor's account, per instruction.
    /// </summary>
    public IsoActiveOrHistoricCurrencyAndAmount? MaximumAmount { get; init; } 
    /// <summary>
    /// Specifies the characteristics of the adjustment applied to the collection amount of a direct debit instruction.
    /// </summary>
    public MandateAdjustment1? Adjustment { get; init; } 
    /// <summary>
    /// Provides the reason for the setup of the mandate.
    /// </summary>
    public MandateSetupReason1Choice_? Reason { get; init; } 
    /// <summary>
    /// Credit party that signs the mandate.
    /// </summary>
    public PartyIdentification135? CreditorSchemeIdentification { get; init; } 
    /// <summary>
    /// Party that signs the mandate and to whom an amount of money is due.
    /// </summary>
    public required PartyIdentification135 Creditor { get; init; } 
    /// <summary>
    /// Unambiguous identification of the account of the creditor to which a credit entry will be posted as a result of the payment transaction.
    /// </summary>
    public CashAccount40? CreditorAccount { get; init; } 
    /// <summary>
    /// Financial institution servicing an account for the creditor.
    /// </summary>
    public BranchAndFinancialInstitutionIdentification6? CreditorAgent { get; init; } 
    /// <summary>
    /// Ultimate party to which an amount of money is due.
    /// </summary>
    public PartyIdentification135? UltimateCreditor { get; init; } 
    /// <summary>
    /// Party that signs the mandate and owes an amount of money to the (ultimate) creditor.
    /// </summary>
    public required PartyIdentification135 Debtor { get; init; } 
    /// <summary>
    /// Unambiguous identification of the account of the debtor, to which a debit entry will be made as a result of the transaction.
    /// </summary>
    public CashAccount40? DebtorAccount { get; init; } 
    /// <summary>
    /// Financial institution servicing an account for the debtor.
    /// </summary>
    public required BranchAndFinancialInstitutionIdentification6 DebtorAgent { get; init; } 
    /// <summary>
    /// Ultimate party that owes an amount of money to the (ultimate) creditor.
    /// </summary>
    public PartyIdentification135? UltimateDebtor { get; init; } 
    /// <summary>
    /// Reference assigned by a creditor or ultimate creditor for internal usage for the mandate.
    /// </summary>
    public IsoMax35Text? MandateReference { get; init; } 
    /// <summary>
    /// Provides information to identify the underlying documents associated with the mandate.
    /// </summary>
    public ReferredMandateDocument1? ReferredDocument { get; init;  } // Warning: Don't know multiplicity.
    #nullable disable
}
