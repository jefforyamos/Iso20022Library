﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for POIComponentType5Code.  ISO2002 ID# _Ezi00dqiEeearpaEPXv9UA.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Type of component belonging to a POI (Point of Interaction) Terminal.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Ezi00dqiEeearpaEPXv9UA")]
[Description(@"Type of component belonging to a POI (Point of Interaction) Terminal.")]
[DerivedFrom(typeof(POIComponentTypeCode))]
public enum POIComponentType5Code
{
    /// <summary>
    /// Parameters for acquirer interface of the point of interaction, including acquirer host configuration parameters.
    /// Encoded/decoded by serializers as "AcquirerProtocolParameters".
    /// </summary>
    [EnumMember(Value = "AQPP")]
    [IsoId("_E8pGcdqiEeearpaEPXv9UA")]
    [Description(@"Parameters for acquirer interface of the point of interaction, including acquirer host configuration parameters.")]
    AcquirerProtocolParameters,
    
    /// <summary>
    /// Parameters of a payment application running on the point of interaction.
    /// Encoded/decoded by serializers as "ApplicationParameters".
    /// </summary>
    [EnumMember(Value = "APPR")]
    [IsoId("_E8pGc9qiEeearpaEPXv9UA")]
    [Description(@"Parameters of a payment application running on the point of interaction.")]
    ApplicationParameters,
    
    /// <summary>
    /// Manufacturer configuration parameters of the point of interaction.
    /// Encoded/decoded by serializers as "TerminalParameters".
    /// </summary>
    [EnumMember(Value = "TLPR")]
    [IsoId("_E8pGddqiEeearpaEPXv9UA")]
    [Description(@"Manufacturer configuration parameters of the point of interaction.")]
    TerminalParameters,
    
    /// <summary>
    /// Security parameters of the point of interaction.
    /// Encoded/decoded by serializers as "SecurityParameters".
    /// </summary>
    [EnumMember(Value = "SCPR")]
    [IsoId("_E8pGd9qiEeearpaEPXv9UA")]
    [Description(@"Security parameters of the point of interaction.")]
    SecurityParameters,
    
    /// <summary>
    /// Payment server of a point of interaction system.
    /// Encoded/decoded by serializers as "Server".
    /// </summary>
    [EnumMember(Value = "SERV")]
    [IsoId("_E8pGedqiEeearpaEPXv9UA")]
    [Description(@"Payment server of a point of interaction system.")]
    Server,
    
    /// <summary>
    /// Payment terminal point of interaction.
    /// Encoded/decoded by serializers as "Terminal".
    /// </summary>
    [EnumMember(Value = "TERM")]
    [IsoId("_E8pGe9qiEeearpaEPXv9UA")]
    [Description(@"Payment terminal point of interaction.")]
    Terminal,
    
    /// <summary>
    /// Device sub-component of a component of the point of interaction.
    /// Encoded/decoded by serializers as "Device".
    /// </summary>
    [EnumMember(Value = "DVCE")]
    [IsoId("_E8pGfdqiEeearpaEPXv9UA")]
    [Description(@"Device sub-component of a component of the point of interaction.")]
    Device,
    
    /// <summary>
    /// Security module.
    /// Encoded/decoded by serializers as "SecureModule".
    /// </summary>
    [EnumMember(Value = "SECM")]
    [IsoId("_E8pGf9qiEeearpaEPXv9UA")]
    [Description(@"Security module.")]
    SecureModule,
    
    /// <summary>
    /// Payment application software.
    /// Encoded/decoded by serializers as "PaymentApplication".
    /// </summary>
    [EnumMember(Value = "APLI")]
    [IsoId("_E8pGgdqiEeearpaEPXv9UA")]
    [Description(@"Payment application software.")]
    PaymentApplication,
    
    /// <summary>
    /// EMV application kernel (EMV is the chip card specifications initially defined by Eurocard, Mastercard and Visa).
    /// Encoded/decoded by serializers as "EMVKernel".
    /// </summary>
    [EnumMember(Value = "EMVK")]
    [IsoId("_E8pGg9qiEeearpaEPXv9UA")]
    [Description(@"EMV application kernel (EMV is the chip card specifications initially defined by Eurocard, Mastercard and Visa).")]
    EMVKernel,
    
    /// <summary>
    /// EMV physical interface (EMV is the chip card specifications initially defined by Eurocard, Mastercard and Visa).
    /// Encoded/decoded by serializers as "EMVLevel1".
    /// </summary>
    [EnumMember(Value = "EMVO")]
    [IsoId("_E8pGhdqiEeearpaEPXv9UA")]
    [Description(@"EMV physical interface (EMV is the chip card specifications initially defined by Eurocard, Mastercard and Visa).")]
    EMVLevel1,
    
    /// <summary>
    /// Software module of the point of interaction.
    /// Encoded/decoded by serializers as "Middleware".
    /// </summary>
    [EnumMember(Value = "MDWR")]
    [IsoId("_E8pGh9qiEeearpaEPXv9UA")]
    [Description(@"Software module of the point of interaction.")]
    Middleware,
    
    /// <summary>
    /// Driver module of the point of interaction.
    /// Encoded/decoded by serializers as "Driver".
    /// </summary>
    [EnumMember(Value = "DRVR")]
    [IsoId("_E8pGidqiEeearpaEPXv9UA")]
    [Description(@"Driver module of the point of interaction.")]
    Driver,
    
    /// <summary>
    /// Software that manages hardware to provide common services to the applications.
    /// Encoded/decoded by serializers as "OperatingSystem".
    /// </summary>
    [EnumMember(Value = "OPST")]
    [IsoId("_E8pGi9qiEeearpaEPXv9UA")]
    [Description(@"Software that manages hardware to provide common services to the applications.")]
    OperatingSystem,
    
    /// <summary>
    /// Merchant configuration parameters for the point of interaction (POI).
    /// Encoded/decoded by serializers as "MerchantParameters".
    /// </summary>
    [EnumMember(Value = "MRPR")]
    [IsoId("_E8pGjdqiEeearpaEPXv9UA")]
    [Description(@"Merchant configuration parameters for the point of interaction (POI).")]
    MerchantParameters,
    
    /// <summary>
    /// Certificate provided by a terminal manager.
    /// Encoded/decoded by serializers as "CertificateParameters".
    /// </summary>
    [EnumMember(Value = "CRTF")]
    [IsoId("_E8pGj9qiEeearpaEPXv9UA")]
    [Description(@"Certificate provided by a terminal manager.")]
    CertificateParameters,
    
    /// <summary>
    /// Configuration parameters for the TMS protocol.
    /// Encoded/decoded by serializers as "TMSProtocolParameters".
    /// </summary>
    [EnumMember(Value = "TMSP")]
    [IsoId("_E8pGkdqiEeearpaEPXv9UA")]
    [Description(@"Configuration parameters for the TMS protocol.")]
    TMSProtocolParameters,
    
    /// <summary>
    /// Component of the Sale system.
    /// Encoded/decoded by serializers as "SaleComponent".
    /// </summary>
    [EnumMember(Value = "SACP")]
    [IsoId("_GEI6AdqiEeearpaEPXv9UA")]
    [Description(@"Component of the Sale system.")]
    SaleComponent,
    
    /// <summary>
    /// Parameters related to the Sale to POI protocol.
    /// Encoded/decoded by serializers as "SaleToPOIProtocolParameters".
    /// </summary>
    [EnumMember(Value = "SAPR")]
    [IsoId("_GOH8cdqiEeearpaEPXv9UA")]
    [Description(@"Parameters related to the Sale to POI protocol.")]
    SaleToPOIProtocolParameters,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class POIComponentType5CodeMetadataExtensions
{
    private static readonly POIComponentType5CodeDropdownSource _dropdownSource = new POIComponentType5CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IPOIComponentType5CodeDropdownRow GetMetadata(this POIComponentType5Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


