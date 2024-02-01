﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Cheque3.  ISO2002 ID# _QbdK-9p-Ed-ak6NoX_4Aeg_-241775444.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of characteristics related to a cheque instruction, such as cheque type or cheque number.
/// </summary>
public partial record Cheque3
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
