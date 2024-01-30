﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ProformaStatusReason1.  ISO2002 ID# _GeducUzDEeafiMTDrtSnyw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Reason for an proforma status.
/// </summary>
public partial record ProformaStatusReason1
{
    #nullable enable
    
    /// <summary>
    /// Reason for the proforma account status.
    /// </summary>
    public required IProformaStatusReason2Choice Code { get; init; } 
    /// <summary>
    /// Additional information about the reason for the proforma account status.
    /// </summary>
    public IsoMax350Text? AdditionalInformation { get; init; } 
    
    #nullable disable
}
