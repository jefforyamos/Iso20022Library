﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CardPaymentTransactionResult1.  ISO2002 ID# _TFi5egEcEeCQm6a_G2yO_w_-873337121.
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
/// Result of the transaction.
/// </summary>
[IsoId("_TFi5egEcEeCQm6a_G2yO_w_-873337121")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Card Payment Transaction Result")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CardPaymentTransactionResult1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CardPaymentTransactionResult1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CardPaymentTransactionResult1( ResponseType1 reqResponseToAuthorisation )
    {
        ResponseToAuthorisation = reqResponseToAuthorisation;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Type of party that has delivered or declined the card payment authorisation (the party is not identified).
    /// </summary>
    [IsoId("_TFi5ewEcEeCQm6a_G2yO_w_-1313656436")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Authorisation Entity")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public GenericIdentification33? AuthorisationEntity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public GenericIdentification33? AuthorisationEntity { get; init; } 
    #else
    public GenericIdentification33? AuthorisationEntity { get; set; } 
    #endif
    
    /// <summary>
    /// Response to an authorisation from the acquirer.
    /// </summary>
    [IsoId("_TFi5fAEcEeCQm6a_G2yO_w_-1341326750")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Response To Authorisation")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ResponseType1 ResponseToAuthorisation { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public ResponseType1 ResponseToAuthorisation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ResponseType1 ResponseToAuthorisation { get; init; } 
    #else
    public ResponseType1 ResponseToAuthorisation { get; set; } 
    #endif
    
    /// <summary>
    /// Value assigned by the authorising party.
    /// </summary>
    [IsoId("_TFi5fQEcEeCQm6a_G2yO_w_-100256564")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Authorisation Code")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 8 ,MinimumLength = 6)]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMin6Max8Text? AuthorisationCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AuthorisationCode { get; init; } 
    #else
    public System.String? AuthorisationCode { get; set; } 
    #endif
    
    
    #nullable disable
    
}
