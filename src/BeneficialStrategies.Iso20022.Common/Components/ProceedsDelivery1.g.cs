﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ProceedsDelivery1.  ISO2002 ID# _UK6fTNp-Ed-ak6NoX_4Aeg_-1336818380.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides information about the account.
/// </summary>
[DataContract]
[XmlType]
public partial record ProceedsDelivery1
{
    #nullable enable
    
    /// <summary>
    /// identification of the securities account to which the securities have to be delivered.
    /// </summary>
    [DataMember]
    public required IsoMax35Text SecuritiesAccountIdentification { get; init; } 
    /// <summary>
    /// Identification of the cash account to which the cash has to be delivered.
    /// </summary>
    [DataMember]
    public required CashAccountIdentification1Choice_ CashAccountIdentification { get; init; } 
    /// <summary>
    /// Identification of the party that owns the account.
    /// </summary>
    [DataMember]
    public PartyIdentification2Choice_? AccountOwnerIdentification { get; init; } 
    /// <summary>
    /// Identification of the institution servicing the account.
    /// </summary>
    [DataMember]
    public PartyIdentification2Choice_? AccountServicerIdentification { get; init; } 
    
    #nullable disable
}
