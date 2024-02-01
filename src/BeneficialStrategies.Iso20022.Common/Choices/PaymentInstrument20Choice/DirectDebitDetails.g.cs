﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for DirectDebitDetails.  ISO2002 ID# _weKLHTbsEead9bDRE_1DAQ.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PaymentInstrument20Choice;

/// <summary>
/// Instruction, initiated by the creditor, to debit a debtor's account in favour of the creditor. A direct debit can be pre-authorised or not. In most countries, authorisation is in the form of a mandate between the debtor and creditor.
/// </summary>
public partial record DirectDebitDetails : PaymentInstrument20Choice_
{
    #nullable enable
    /// <summary>
    /// Unambiguous identification of the account of the debtor to which a debit entry will be made as a result of the transaction.
    /// </summary>
    public required AccountIdentificationAndName5 DebtorAccount { get; init; } 
    /// <summary>
    /// Party that owes the cash to the creditor/final party. The debtor is also the debit account owner.
    /// </summary>
    public PartyIdentification113? Debtor { get; init; } 
    /// <summary>
    /// Number assigned by a tax authority to an entity.
    /// </summary>
    public IsoMax35Text? DebtorTaxIdentificationNumber { get; init; } 
    /// <summary>
    /// Number assigned by a national registration authority to an entity.
    /// </summary>
    public IsoMax35Text? DebtorNationalRegistrationNumber { get; init; } 
    /// <summary>
    /// Party that receives an amount of money from the debtor. In the context of the payment model, the creditor is also the credit account owner.
    /// </summary>
    public PartyIdentification113? Creditor { get; init; } 
    /// <summary>
    /// Financial institution that receives the direct debit instruction from the creditor or other authorised party.
    /// </summary>
    public required FinancialInstitutionIdentification10 DebtorAgent { get; init; } 
    /// <summary>
    /// Information identifying a specific branch of a financial institution.||Usage: this component should be used in case the identification information in the financial institution component does not provide identification up to branch level.
    /// </summary>
    public BranchData? DebtorAgentBranch { get; init; } 
    /// <summary>
    /// Financial institution that receives the payment transaction on behalf of the creditor, or other nominated party, and credits the account.
    /// </summary>
    public FinancialInstitutionIdentification10? CreditorAgent { get; init; } 
    /// <summary>
    /// Information identifying a specific branch of a financial institution.||Usage: this component should be used in case the identification information in the financial institution component does not provide identification up to branch level.
    /// </summary>
    public BranchData? CreditorAgentBranch { get; init; } 
    /// <summary>
    /// Reference assigned to a creditor by its financial institution, or relevant authority, authorising the creditor to take part in a direct debit scheme.
    /// </summary>
    public IsoMax35Text? RegistrationIdentification { get; init; } 
    /// <summary>
    /// Reference of the direct debit mandate that has been agreed upon by the debtor and creditor.
    /// </summary>
    public IsoMax35Text? MandateIdentification { get; init; } 
    #nullable disable
}
