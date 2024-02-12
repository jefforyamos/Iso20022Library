﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for NameAndAddress3.  ISO2002 ID# _PZcUU9p-Ed-ak6NoX_4Aeg_-2099385393.
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
/// Information that locates and identifies a party.
/// </summary>
[IsoId("_PZcUU9p-Ed-ak6NoX_4Aeg_-2099385393")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Name And Address")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record NameAndAddress3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a NameAndAddress3 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public NameAndAddress3( System.String reqName,PostalAddress1 reqAddress )
    {
        Name = reqName;
        Address = reqAddress;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Name by which a party is known and is usually used to identify that identity.
    /// </summary>
    [IsoId("_PZcUVNp-Ed-ak6NoX_4Aeg_-2047670244")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Name")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax70Text Name { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public System.String Name { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String Name { get; init; } 
    #else
    public System.String Name { get; set; } 
    #endif
    
    /// <summary>
    /// Postal address of a party.
    /// </summary>
    [IsoId("_PZcUVdp-Ed-ak6NoX_4Aeg_-1111154172")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Address")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PostalAddress1 Address { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public PostalAddress1 Address { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PostalAddress1 Address { get; init; } 
    #else
    public PostalAddress1 Address { get; set; } 
    #endif
    
    
    #nullable disable
    
}
