﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for PaymentTransaction70.  ISO2002 ID# _vsxKiTbsEead9bDRE_1DAQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Payment processes required to transfer cash from the debtor to the creditor.
/// </summary>
public partial record PaymentTransaction70
{
    #nullable enable
    
    /// <summary>
    /// Choice between types of payment instrument, for example, cheque, credit transfer, direct debit, investment account or payment card.
    /// </summary>
    public required IPaymentInstrument20Choice PaymentInstrument { get; init; } 
    
    #nullable disable
}
