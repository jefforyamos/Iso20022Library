﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for TransactionModification6.  ISO2002 ID# _AS0XgQKyEe2rHs6fbn9-0A.
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
/// Contains the requested modifications.
/// </summary>
[IsoId("_AS0XgQKyEe2rHs6fbn9-0A")]
[DisplayName("Transaction Modification")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TransactionModification6
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a TransactionModification6 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public TransactionModification6( PaymentIdentification7Choice_ reqPaymentIdentification,PaymentInstruction33 reqNewPaymentValueSet )
    {
        PaymentIdentification = reqPaymentIdentification;
        NewPaymentValueSet = reqNewPaymentValueSet;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Reference to the instruction related to the payment for which a modification is requested.
    /// </summary>
    [IsoId("_A9ynIQKyEe2rHs6fbn9-0A")]
    [DisplayName("Payment Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PmtId")]
    #endif
    [IsoXmlTag("PmtId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PaymentIdentification7Choice_ PaymentIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PaymentIdentification7Choice_ PaymentIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PaymentIdentification7Choice_ PaymentIdentification { get; init; } 
    #else
    public PaymentIdentification7Choice_ PaymentIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// New payment values.
    /// </summary>
    [IsoId("_A9ynIwKyEe2rHs6fbn9-0A")]
    [DisplayName("New Payment Value Set")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NewPmtValSet")]
    #endif
    [IsoXmlTag("NewPmtValSet")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PaymentInstruction33 NewPaymentValueSet { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PaymentInstruction33 NewPaymentValueSet { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PaymentInstruction33 NewPaymentValueSet { get; init; } 
    #else
    public PaymentInstruction33 NewPaymentValueSet { get; set; } 
    #endif
    
    
    #nullable disable
    
}
