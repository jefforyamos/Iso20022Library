﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for ChequeDetails.  ISO2002 ID# _VKY_Stp-Ed-ak6NoX_4Aeg_734057995.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PaymentInstrument10Choice;

/// <summary>
/// Written order on which instructions are given to an account holder (a financial institution) to pay a stated sum to a named recipient (the payee).
/// </summary>
public partial record ChequeDetails : PaymentInstrument10Choice_
{
    #nullable enable
    /// <summary>
    /// Unique and unambiguous identifier for a cheque as assigned by the financial institution.
    /// </summary>
    public IsoMax35Text? Number { get; init; } 
    /// <summary>
    /// Party to which a cheque is made payable.
    /// </summary>
    public required PartyIdentification2Choice_ PayeeIdentification { get; init; } 
    /// <summary>
    /// Financial institution on which a cheque is drawn, ie, the financial institution that services the account of the entity that issued the cheque.
    /// </summary>
    public FinancialInstitutionIdentification3Choice_? DraweeIdentification { get; init; } 
    /// <summary>
    /// Account owner that issues a cheque ordering the drawee bank to pay a specific amount, upon demand, to the payee.
    /// </summary>
    public PartyIdentification2Choice_? DrawerIdentification { get; init; } 
    #nullable disable
}
