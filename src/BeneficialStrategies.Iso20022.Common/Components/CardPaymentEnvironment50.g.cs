﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CardPaymentEnvironment50.  ISO2002 ID# _vfaJsY1MEeWXALXlV0Ei2w.
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
[IsoId("_vfaJsY1MEeWXALXlV0Ei2w")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Card Payment Environment")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CardPaymentEnvironment50
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CardPaymentEnvironment50 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CardPaymentEnvironment50( Acquirer4 reqAcquirer )
    {
        Acquirer = reqAcquirer;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Acquirer involved in the card payment reconciliation.
    /// </summary>
    [IsoId("_vqcVAY1MEeWXALXlV0Ei2w")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Acquirer")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Acquirer4 Acquirer { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public Acquirer4 Acquirer { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Acquirer4 Acquirer { get; init; } 
    #else
    public Acquirer4 Acquirer { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the merchant requesting the reconciliation.
    /// </summary>
    [IsoId("_vqcVA41MEeWXALXlV0Ei2w")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Merchant Identification")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public GenericIdentification53? MerchantIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public GenericIdentification53? MerchantIdentification { get; init; } 
    #else
    public GenericIdentification53? MerchantIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the POI (Point Of Interaction) requesting the reconciliation.
    /// </summary>
    [IsoId("_vqcVBY1MEeWXALXlV0Ei2w")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("POI Identification")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public GenericIdentification53? POIIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public GenericIdentification53? POIIdentification { get; init; } 
    #else
    public GenericIdentification53? POIIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Data related to the components of the POI (Point Of Interaction) that have been performed the payment transactions.
    /// </summary>
    [IsoId("_vqcVB41MEeWXALXlV0Ei2w")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("POI Component")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PointOfInteractionComponent6? POIComponent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PointOfInteractionComponent6? POIComponent { get; init; } 
    #else
    public PointOfInteractionComponent6? POIComponent { get; set; } 
    #endif
    
    
    #nullable disable
    
}
