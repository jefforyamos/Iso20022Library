﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for ChequeDetails.  ISO2002 ID# _4MizFTbsEead9bDRE_1DAQ.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PaymentInstrument21Choice;

/// <summary>
/// Written order on which instructions are given to an account holder (a financial institution) to pay a stated sum to a named recipient (the payee).
/// </summary>
public partial record ChequeDetails : IPaymentInstrument21Choice
{
    #nullable enable
    /// <summary>
    /// Unique and unambiguous identifier for a cheque as assigned by the financial institution.
    /// </summary>
    public IsoMax35Text? Number { get; init; } 
    /// <summary>
    /// Party to which a cheque is made payable.
    /// </summary>
    public required PartyIdentification113 PayeeIdentification { get; init; } 
    /// <summary>
    /// Financial institution on which a cheque is drawn, that is, the financial institution that services the account of the entity that issued the cheque.
    /// </summary>
    public FinancialInstitutionIdentification10? DraweeIdentification { get; init; } 
    /// <summary>
    /// Account owner that issues a cheque ordering the drawee bank to pay a specific amount, upon demand, to the payee.
    /// </summary>
    public PartyIdentification113? DrawerIdentification { get; init; } 
    #nullable disable
}
