﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CompareAgreementType2.  ISO2002 ID# _7a2ZUa5hEeuo-IflVgGqiA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies whether the infromation on the type of the master agrement is matching or not.
/// </summary>
[DataContract]
[XmlType]
public partial record CompareAgreementType2
{
    #nullable enable
    
    /// <summary>
    /// Information for the first side of the transaction.
    /// </summary>
    [DataMember]
    public AgreementType1Choice_? Value1 { get; init; } 
    /// <summary>
    /// Information for the second side of the transaction.
    /// </summary>
    [DataMember]
    public AgreementType1Choice_? Value2 { get; init; } 
    
    #nullable disable
}
