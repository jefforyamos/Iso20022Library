﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AcceptorDiagnosticRequest8.  ISO2002 ID# _kRo00QujEeqw5uEXxQ9H4g.
// Copyright 2024 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Diagnostic request from an acceptor.
/// </summary>
[IsoId("_kRo00QujEeqw5uEXxQ9H4g")]
[DisplayName("Acceptor Diagnostic Request")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record AcceptorDiagnosticRequest8
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a AcceptorDiagnosticRequest8 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public AcceptorDiagnosticRequest8( CardPaymentEnvironment74 reqEnvironment )
    {
        Environment = reqEnvironment;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    [IsoId("_kceL0QujEeqw5uEXxQ9H4g")]
    [DisplayName("Environment")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Envt")]
    #endif
    [IsoXmlTag("Envt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CardPaymentEnvironment74 Environment { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CardPaymentEnvironment74 Environment { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CardPaymentEnvironment74 Environment { get; init; } 
    #else
    public CardPaymentEnvironment74 Environment { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates if the availability of the acquirer must be tested.
    /// </summary>
    [IsoId("_yq_gAQujEeqw5uEXxQ9H4g")]
    [DisplayName("Acquirer Availability Requested")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcqrrAvlbtyReqd")]
    #endif
    [IsoXmlTag("AcqrrAvlbtyReqd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoTrueFalseIndicator? AcquirerAvailabilityRequested { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AcquirerAvailabilityRequested { get; init; } 
    #else
    public System.String? AcquirerAvailabilityRequested { get; set; } 
    #endif
    
    
    #nullable disable
    
}
