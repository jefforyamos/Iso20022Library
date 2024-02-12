﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Organisation32.  ISO2002 ID# _Odd08dwtEeeKpa-yxjuKzQ.
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
/// Merchant performing the transaction.
/// </summary>
[IsoId("_Odd08dwtEeeKpa-yxjuKzQ")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Organisation")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Organisation32
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of the merchant.
    /// </summary>
    [IsoId("_Omf1IdwtEeeKpa-yxjuKzQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Identification")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public GenericIdentification32? Identification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public GenericIdentification32? Identification { get; init; } 
    #else
    public GenericIdentification32? Identification { get; set; } 
    #endif
    
    /// <summary>
    /// Name of the merchant as appearing on the receipt.
    /// </summary>
    [IsoId("_Omf1I9wtEeeKpa-yxjuKzQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Common Name")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax70Text? CommonName { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CommonName { get; init; } 
    #else
    public System.String? CommonName { get; set; } 
    #endif
    
    /// <summary>
    /// Location category of the place where the merchant actually performed the transaction.
    /// </summary>
    [IsoId("_Omf1JdwtEeeKpa-yxjuKzQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Location Category")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public LocationCategory1Code? LocationCategory { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public LocationCategory1Code? LocationCategory { get; init; } 
    #else
    public LocationCategory1Code? LocationCategory { get; set; } 
    #endif
    
    /// <summary>
    /// Location and contact information of the merchant performing the transaction.
    /// </summary>
    [IsoId("_Omf1J9wtEeeKpa-yxjuKzQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Location And Contact")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CommunicationAddress9? LocationAndContact { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CommunicationAddress9? LocationAndContact { get; init; } 
    #else
    public CommunicationAddress9? LocationAndContact { get; set; } 
    #endif
    
    /// <summary>
    /// Additional merchant data required by a card scheme.
    /// </summary>
    [IsoId("_Omf1KdwtEeeKpa-yxjuKzQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Scheme Data")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax140Text? SchemeData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? SchemeData { get; init; } 
    #else
    public System.String? SchemeData { get; set; } 
    #endif
    
    
    #nullable disable
    
}
