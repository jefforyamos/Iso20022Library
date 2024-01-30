﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for DirectDebitDetails.  ISO2002 ID# _VKshRNp-Ed-ak6NoX_4Aeg_-703232645.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PaymentInstrument8Choice;

/// <summary>
/// Instruction, initiated by the creditor, to debit a debtor's account in favour of the creditor. A direct debit can be pre-authorised or not. In most countries, authorisation is in the form of a mandate between the debtor and creditor.
/// </summary>
public partial record DirectDebitDetails : IPaymentInstrument8Choice
{
    #nullable enable
    /// <summary>
    /// Unique and unambiguous identification for the account between the account owner and the account servicer.
    /// </summary>
    public required ICashAccountIdentification1Choice DebtorAccountIdentification { get; init; } 
    /// <summary>
    /// Party that owes the cash to the creditor/final party. The debtor is also the debit account owner.
    /// </summary>
    public IPartyIdentification2Choice? DebtorIdentification { get; init; } 
    /// <summary>
    /// Party that receives an amount of money from the debtor. In the context of the payment model, the creditor is also the credit account owner.
    /// </summary>
    public IPartyIdentification2Choice? CreditorIdentification { get; init; } 
    /// <summary>
    /// Financial institution that receives the direct debit instruction from the creditor or other authorised party.
    /// </summary>
    public required IFinancialInstitutionIdentification3Choice FirstAgent { get; init; } 
    /// <summary>
    /// Financial institution that receives the payment transaction on behalf of the creditor, or other nominated party, and credits the account.
    /// </summary>
    public IFinancialInstitutionIdentification3Choice? FinalAgent { get; init; } 
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
