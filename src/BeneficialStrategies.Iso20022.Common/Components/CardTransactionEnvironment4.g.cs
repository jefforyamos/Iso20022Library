﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CardTransactionEnvironment4.  ISO2002 ID# _3RcX4Xu2EeS2Z_kGi7H1VQ.
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
/// Environment of the transaction.
/// </summary>
[IsoId("_3RcX4Xu2EeS2Z_kGi7H1VQ")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Card Transaction Environment")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CardTransactionEnvironment4
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CardTransactionEnvironment4 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CardTransactionEnvironment4( System.String reqAcquirerIdentification,PaymentCard15 reqCard )
    {
        AcquirerIdentification = reqAcquirerIdentification;
        Card = reqCard;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Acquirer identification of the card transaction.
    /// </summary>
    [IsoId("_3dz_8Xu2EeS2Z_kGi7H1VQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Acquirer Identification")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text AcquirerIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public System.String AcquirerIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String AcquirerIdentification { get; init; } 
    #else
    public System.String AcquirerIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the interconnected card scheme from which the request is coming.
    /// </summary>
    [IsoId("_dvwpIIPUEeSvn4rZUbUwhw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Card Scheme Identification")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? CardSchemeIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CardSchemeIdentification { get; init; } 
    #else
    public System.String? CardSchemeIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the card acceptor performing the transaction.
    /// </summary>
    [IsoId("_3dz_9Xu2EeS2Z_kGi7H1VQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Acceptor Identification")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? AcceptorIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AcceptorIdentification { get; init; } 
    #else
    public System.String? AcceptorIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the card terminal performing the transaction.
    /// </summary>
    [IsoId("_3dz_93u2EeS2Z_kGi7H1VQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Terminal Identification")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? TerminalIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? TerminalIdentification { get; init; } 
    #else
    public System.String? TerminalIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Card performing the transaction.
    /// </summary>
    [IsoId("_3dz_-Xu2EeS2Z_kGi7H1VQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Card")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PaymentCard15 Card { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public PaymentCard15 Card { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PaymentCard15 Card { get; init; } 
    #else
    public PaymentCard15 Card { get; set; } 
    #endif
    
    /// <summary>
    /// Payment token information.
    /// </summary>
    [IsoId("_3dz_-3u2EeS2Z_kGi7H1VQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Payment Token")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CardPaymentToken2? PaymentToken { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CardPaymentToken2? PaymentToken { get; init; } 
    #else
    public CardPaymentToken2? PaymentToken { get; set; } 
    #endif
    
    
    #nullable disable
    
}
