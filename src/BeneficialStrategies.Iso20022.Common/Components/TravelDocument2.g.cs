﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for TravelDocument2.  ISO2002 ID# _nTBeERyvEey6gI8SKlv7rg.
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
/// Details of travel document used for identification and/or authentication of the customer.
/// </summary>
[IsoId("_nTBeERyvEey6gI8SKlv7rg")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Travel Document")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TravelDocument2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a TravelDocument2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public TravelDocument2( OfficialDocumentType1Code reqType,System.String reqIdentification )
    {
        Type = reqType;
        Identification = reqIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Type of travel document.
    /// </summary>
    [IsoId("_nYcwoRyvEey6gI8SKlv7rg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Type")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required OfficialDocumentType1Code Type { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public OfficialDocumentType1Code Type { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OfficialDocumentType1Code Type { get; init; } 
    #else
    public OfficialDocumentType1Code Type { get; set; } 
    #endif
    
    /// <summary>
    /// Form of travel document.
    /// </summary>
    [IsoId("_nYcwoxyvEey6gI8SKlv7rg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Form")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PresentationMedium2Code? Form { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PresentationMedium2Code? Form { get; init; } 
    #else
    public PresentationMedium2Code? Form { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of travel document (for example, passport number).
    /// </summary>
    [IsoId("_nYdXsRyvEey6gI8SKlv7rg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Identification")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax70Text Identification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public System.String Identification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String Identification { get; init; } 
    #else
    public System.String Identification { get; set; } 
    #endif
    
    /// <summary>
    /// Party assigning the travel document.
    /// </summary>
    [IsoId("_nYdXsxyvEey6gI8SKlv7rg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Assigner")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax70Text? Assigner { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Assigner { get; init; } 
    #else
    public System.String? Assigner { get; set; } 
    #endif
    
    /// <summary>
    /// Issuance date of travel document.
    /// </summary>
    [IsoId("_nYdXtRyvEey6gI8SKlv7rg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Issuance Date")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? IssuanceDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? IssuanceDate { get; init; } 
    #else
    public System.DateOnly? IssuanceDate { get; set; } 
    #endif
    
    /// <summary>
    /// Expiration date of travel document (if and when relevant).
    /// </summary>
    [IsoId("_nYdXtxyvEey6gI8SKlv7rg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Expiration Date")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? ExpirationDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? ExpirationDate { get; init; } 
    #else
    public System.DateOnly? ExpirationDate { get; set; } 
    #endif
    
    /// <summary>
    /// Country issuing the travel document.
    /// </summary>
    [IsoId("_nYdXuRyvEey6gI8SKlv7rg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Country")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ISOMax3ACountryCode? Country { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? Country { get; init; } 
    #else
    public string? Country { get; set; } 
    #endif
    
    
    #nullable disable
    
}
