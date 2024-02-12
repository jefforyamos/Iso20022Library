﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CardPaymentEnvironment12.  ISO2002 ID# _ZtSRkQvWEeKzJ69IWwzB9Q.
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
/// Environment of the cancellation.
/// </summary>
[IsoId("_ZtSRkQvWEeKzJ69IWwzB9Q")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Card Payment Environment")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CardPaymentEnvironment12
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CardPaymentEnvironment12 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CardPaymentEnvironment12( PointOfInteraction2 reqPOI,PaymentCard6 reqCard )
    {
        POI = reqPOI;
        Card = reqCard;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Acquirer involved in the card payment.
    /// </summary>
    [IsoId("_Z4TOwQvWEeKzJ69IWwzB9Q")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Acquirer")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Acquirer2? Acquirer { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Acquirer2? Acquirer { get; init; } 
    #else
    public Acquirer2? Acquirer { get; set; } 
    #endif
    
    /// <summary>
    /// Merchant performing the card payment cancellation.
    /// Usage: In some cases, merchant and acceptor may be regarded as the same entity.
    /// </summary>
    [IsoId("_Z4TOxQvWEeKzJ69IWwzB9Q")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Merchant")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Organisation8? Merchant { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Organisation8? Merchant { get; init; } 
    #else
    public Organisation8? Merchant { get; set; } 
    #endif
    
    /// <summary>
    /// Point of interaction (POI) performing the transaction.
    /// </summary>
    [IsoId("_Z4TOyQvWEeKzJ69IWwzB9Q")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("POI")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PointOfInteraction2 POI { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public PointOfInteraction2 POI { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PointOfInteraction2 POI { get; init; } 
    #else
    public PointOfInteraction2 POI { get; set; } 
    #endif
    
    /// <summary>
    /// Payment card performing the transaction.
    /// </summary>
    [IsoId("_Z4TOzQvWEeKzJ69IWwzB9Q")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Card")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PaymentCard6 Card { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public PaymentCard6 Card { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PaymentCard6 Card { get; init; } 
    #else
    public PaymentCard6 Card { get; set; } 
    #endif
    
    
    #nullable disable
    
}
