﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for MobileData4.  ISO2002 ID# _21GCUVFIEeyApZmLzm74zA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Data related to the mobile of stakeholder.
/// </summary>
public partial record MobileData4
{
    #nullable enable
    
    /// <summary>
    /// Identifies the country of a mobile phone operator.
    /// </summary>
    public IsoMin2Max3AlphaText? MobileCountryCode { get; init; } 
    /// <summary>
    /// Identifies the mobile phone operator inside a country.
    /// </summary>
    public IsoMin2Max3NumericText? MobileNetworkCode { get; init; } 
    /// <summary>
    /// Masked Mobile Subscriber Integrated Service Digital Network.
    /// </summary>
    public IsoMax35Text? MobileMaskedMSISDN { get; init; } 
    /// <summary>
    /// Geographic location specified by geographic or UTM coordinates.
    /// </summary>
    public Geolocation1? Geolocation { get; init; } 
    /// <summary>
    /// Sensitive information related to the mobile phone.
    /// </summary>
    public SensitiveMobileData1? SensitiveMobileData { get; init; } 
    /// <summary>
    /// Sensitive information related to the mobile phone, protected by CMS.
    /// </summary>
    public ContentInformationType32? ProtectedMobileData { get; init; } 
    
    #nullable disable
}
