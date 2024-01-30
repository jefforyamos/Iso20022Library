﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for MandateInformation3.  ISO2002 ID# _T3P8a9p-Ed-ak6NoX_4Aeg_1018029248.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information that serves as a basis to debit an account.
/// </summary>
public partial record MandateInformation3
{
    #nullable enable
    
    /// <summary>
    /// Unique identification, as assigned by the creditor, to unambiguously identify the mandate.
    /// </summary>
    public required IsoMax35Text MandateIdentification { get; init; } 
    /// <summary>
    /// Identification for the mandate request, as assigned by the initiating party.
    /// </summary>
    public IsoMax35Text? MandateRequestIdentification { get; init; } 
    /// <summary>
    /// Specifies the type of mandate, such as paper, electronic or scheme.
    /// </summary>
    public MandateTypeInformation1? Type { get; init; } 
    /// <summary>
    /// Set of elements used to provide details of the duration of the mandate and occurrence of the underlying transactions.
    /// </summary>
    public MandateOccurrences1? Occurrences { get; init; } 
    /// <summary>
    /// Fixed amount to be collected from the debtor's account.
    /// </summary>
    public IsoActiveCurrencyAndAmount? CollectionAmount { get; init; } 
    /// <summary>
    /// Maximum amount that may be collected from the debtor's account, per instruction.
    /// </summary>
    public IsoActiveCurrencyAndAmount? MaximumAmount { get; init; } 
    /// <summary>
    /// Credit party that signs the mandate.
    /// </summary>
    public PartyIdentification32? CreditorSchemeIdentification { get; init; } 
    /// <summary>
    /// Party that signs the mandate and to whom an amount of money is due.
    /// </summary>
    public PartyIdentification32? Creditor { get; init; } 
    /// <summary>
    /// Unambiguous identification of the account of the creditor to which a credit entry will be posted as a result of the payment transaction.
    /// </summary>
    public CashAccount16? CreditorAccount { get; init; } 
    /// <summary>
    /// Financial institution servicing an account for the creditor.
    /// </summary>
    public BranchAndFinancialInstitutionIdentification4? CreditorAgent { get; init; } 
    /// <summary>
    /// Ultimate party to which an amount of money is due.
    /// </summary>
    public PartyIdentification32? UltimateCreditor { get; init; } 
    /// <summary>
    /// Party that signs the mandate and owes an amount of money to the (ultimate) creditor.
    /// </summary>
    public PartyIdentification32? Debtor { get; init; } 
    /// <summary>
    /// Unambiguous identification of the account of the debtor, to which a debit entry will be made as a result of the transaction.
    /// </summary>
    public CashAccount16? DebtorAccount { get; init; } 
    /// <summary>
    /// Financial institution servicing an account for the debtor.
    /// </summary>
    public BranchAndFinancialInstitutionIdentification4? DebtorAgent { get; init; } 
    /// <summary>
    /// Ultimate party that owes an amount of money to the (ultimate) creditor.
    /// </summary>
    public PartyIdentification32? UltimateDebtor { get; init; } 
    /// <summary>
    /// Set of elements used to provide information to identify the underlying documents associated with the mandate.
    /// </summary>
    public ReferredDocumentInformation3? ReferredDocument { get; init; } 
    
    #nullable disable
}
