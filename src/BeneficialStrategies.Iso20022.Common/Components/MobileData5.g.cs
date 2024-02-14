﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for MobileData5.  ISO2002 ID# _V4zFAXDdEe2MCaKO5AtGsA.
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
/// Data related to the mobile of stakeholder.
/// </summary>
[IsoId("_V4zFAXDdEe2MCaKO5AtGsA")]
[DisplayName("Mobile Data")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record MobileData5
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Identifies the country of a mobile phone operator.
    /// </summary>
    [IsoId("_V_ZcQXDdEe2MCaKO5AtGsA")]
    [DisplayName("Mobile Country Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MobCtryCd")]
    #endif
    [IsoXmlTag("MobCtryCd")]
    [IsoSimpleType(IsoSimpleType.Min2Max3AlphaText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMin2Max3AlphaText? MobileCountryCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? MobileCountryCode { get; init; } 
    #else
    public System.String? MobileCountryCode { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the mobile phone operator inside a country.
    /// </summary>
    [IsoId("_V_ZcQ3DdEe2MCaKO5AtGsA")]
    [DisplayName("Mobile Network Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MobNtwkCd")]
    #endif
    [IsoXmlTag("MobNtwkCd")]
    [IsoSimpleType(IsoSimpleType.Min2Max3NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMin2Max3NumericText? MobileNetworkCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? MobileNetworkCode { get; init; } 
    #else
    public System.String? MobileNetworkCode { get; set; } 
    #endif
    
    /// <summary>
    /// Masked Mobile Subscriber Integrated Service Digital Network.
    /// </summary>
    [IsoId("_V_ZcRXDdEe2MCaKO5AtGsA")]
    [DisplayName("Mobile Masked MSISDN")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MobMskdMSISDN")]
    #endif
    [IsoXmlTag("MobMskdMSISDN")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? MobileMaskedMSISDN { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? MobileMaskedMSISDN { get; init; } 
    #else
    public System.String? MobileMaskedMSISDN { get; set; } 
    #endif
    
    /// <summary>
    /// Geographic location specified by geographic or UTM coordinates.
    /// </summary>
    [IsoId("_V_ZcR3DdEe2MCaKO5AtGsA")]
    [DisplayName("Geolocation")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Glctn")]
    #endif
    [IsoXmlTag("Glctn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Geolocation1? Geolocation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Geolocation1? Geolocation { get; init; } 
    #else
    public Geolocation1? Geolocation { get; set; } 
    #endif
    
    /// <summary>
    /// Sensitive information related to the mobile phone.
    /// </summary>
    [IsoId("_V_ZcSXDdEe2MCaKO5AtGsA")]
    [DisplayName("Sensitive Mobile Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SnstvMobData")]
    #endif
    [IsoXmlTag("SnstvMobData")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SensitiveMobileData1? SensitiveMobileData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SensitiveMobileData1? SensitiveMobileData { get; init; } 
    #else
    public SensitiveMobileData1? SensitiveMobileData { get; set; } 
    #endif
    
    /// <summary>
    /// Sensitive information related to the mobile phone, protected by CMS.
    /// </summary>
    [IsoId("_V_ZcS3DdEe2MCaKO5AtGsA")]
    [DisplayName("Protected Mobile Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrtctdMobData")]
    #endif
    [IsoXmlTag("PrtctdMobData")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ContentInformationType35? ProtectedMobileData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ContentInformationType35? ProtectedMobileData { get; init; } 
    #else
    public ContentInformationType35? ProtectedMobileData { get; set; } 
    #endif
    
    
    #nullable disable
    
}
