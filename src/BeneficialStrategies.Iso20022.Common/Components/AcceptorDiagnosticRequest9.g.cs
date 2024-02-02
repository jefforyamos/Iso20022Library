﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AcceptorDiagnosticRequest9.  ISO2002 ID# _4-EsAS5IEeunNvJlR_vCbg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Diagnostic request from an acceptor.
/// </summary>
[DataContract]
[XmlType]
public partial record AcceptorDiagnosticRequest9
{
    #nullable enable
    
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    [DataMember]
    public required CardPaymentEnvironment77 Environment { get; init; } 
    /// <summary>
    /// Indicates if the availability of the acquirer must be tested.
    /// </summary>
    [DataMember]
    public IsoTrueFalseIndicator? AcquirerAvailabilityRequested { get; init; } 
    
    #nullable disable
}
