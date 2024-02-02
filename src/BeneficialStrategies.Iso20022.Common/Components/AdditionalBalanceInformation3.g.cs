﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AdditionalBalanceInformation3.  ISO2002 ID# _QZqbMdp-Ed-ak6NoX_4Aeg_223622935.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Net position of a segregated holding of a single security within the overall position held in the securities account, eg, sub-balance per status.
/// </summary>
[DataContract]
[XmlType]
public partial record AdditionalBalanceInformation3
{
    #nullable enable
    
    /// <summary>
    /// Quantity of securities in the sub-balance.
    /// </summary>
    [DataMember]
    public required SubBalanceQuantity1Choice_ Quantity { get; init; } 
    /// <summary>
    /// Net position of a segregated holding of a single security within the overall position held in the securities account, eg, sub-balance per status.
    /// </summary>
    [DataMember]
    public required SubBalanceType1Choice_ AdditionalBalanceInformation { get; init; } 
    
    #nullable disable
}
