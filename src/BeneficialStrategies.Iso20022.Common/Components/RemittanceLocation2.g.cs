﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for RemittanceLocation2.  ISO2002 ID# _QF_4Udp-Ed-ak6NoX_4Aeg_-1849801133.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of elements used to provide information on the remittance advice.
/// </summary>
public partial record RemittanceLocation2
{
    #nullable enable
    
    /// <summary>
    /// Unique identification, as assigned by the initiating party, to unambiguously identify the remittance information sent separately from the payment instruction, such as a remittance advice.
    /// </summary>
    public IsoMax35Text? RemittanceIdentification { get; init; } 
    /// <summary>
    /// Method used to deliver the remittance advice information.
    /// </summary>
    public RemittanceLocationMethod2Code? RemittanceLocationMethod { get; init; } 
    /// <summary>
    /// Electronic address to which an agent is to send the remittance information.
    /// </summary>
    public IsoMax2048Text? RemittanceLocationElectronicAddress { get; init; } 
    /// <summary>
    /// Postal address to which an agent is to send the remittance information.
    /// </summary>
    public NameAndAddress10? RemittanceLocationPostalAddress { get; init; } 
    
    #nullable disable
}
