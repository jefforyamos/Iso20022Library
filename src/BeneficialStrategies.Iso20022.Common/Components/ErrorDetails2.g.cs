﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ErrorDetails2.  ISO2002 ID# _9egA0dBHEeuFC7k3JpyaRA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details of the error
/// </summary>
public partial record ErrorDetails2
{
    #nullable enable
    
    /// <summary>
    /// Code list containing a code that identifies the error condition.
    /// </summary>
    public required MessageError1Code MessageErrorType { get; init; } 
    /// <summary>
    /// Other message error type defined at national or private level.
    /// </summary>
    public IsoMax35Text? OtherMessageErrorType { get; init; } 
    /// <summary>
    /// Code that identifies the specific error found.
    /// </summary>
    public IsoMax35Text? ErrorCode { get; init; } 
    /// <summary>
    /// Description of the error found.
    /// </summary>
    public IsoMax500Text? ErrorDescription { get; init; } 
    /// <summary>
    /// Data element in error. 
    /// </summary>
    public IsoMax4000Text[] DataElementInError { get; init; } = []; // Warning: Don't know multiplicity.
    
    #nullable disable
}
