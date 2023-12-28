﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for POIComponentType3Code.  ISO2002 ID# _ufANwAxqEeKa_56Jbsi1RQ.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Type of component belonging to a POI (Point of Interaction) Terminal.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ufANwAxqEeKa_56Jbsi1RQ")]
[Description(@"Type of component belonging to a POI (Point of Interaction) Terminal.")]
[DerivedFrom(typeof(POIComponentTypeCode))]
public enum POIComponentType3Code
{
    /// <summary>
    /// Parameters for acquirer interface of the point of interaction, including acquirer host configuration parameters.
    /// Encoded/decoded by serializers as "AcquirerProtocolParameters".
    /// </summary>
    [EnumMember(Value = "AQPP")]
    [IsoId("_rxFZgQxrEeKa_56Jbsi1RQ")]
    [Description(@"Parameters for acquirer interface of the point of interaction, including acquirer host configuration parameters.")]
    AcquirerProtocolParameters,
    
    /// <summary>
    /// Parameters of a payment application running on the point of interaction.
    /// Encoded/decoded by serializers as "ApplicationParameters".
    /// </summary>
    [EnumMember(Value = "APPR")]
    [IsoId("_sfD50wxrEeKa_56Jbsi1RQ")]
    [Description(@"Parameters of a payment application running on the point of interaction.")]
    ApplicationParameters,
    
    /// <summary>
    /// Manufacturer configuration parameters of the point of interaction.
    /// Encoded/decoded by serializers as "TerminalParameters".
    /// </summary>
    [EnumMember(Value = "TLPR")]
    [IsoId("_tdZKUwxrEeKa_56Jbsi1RQ")]
    [Description(@"Manufacturer configuration parameters of the point of interaction.")]
    TerminalParameters,
    
    /// <summary>
    /// Security parameters of the point of interaction.
    /// Encoded/decoded by serializers as "SecurityParameters".
    /// </summary>
    [EnumMember(Value = "SCPR")]
    [IsoId("_ue2nUQxrEeKa_56Jbsi1RQ")]
    [Description(@"Security parameters of the point of interaction.")]
    SecurityParameters,
    
    /// <summary>
    /// Payment server of a point of interaction system.
    /// Encoded/decoded by serializers as "Server".
    /// </summary>
    [EnumMember(Value = "SERV")]
    [IsoId("_xKPPgQxrEeKa_56Jbsi1RQ")]
    [Description(@"Payment server of a point of interaction system.")]
    Server,
    
    /// <summary>
    /// Payment terminal point of interaction.
    /// Encoded/decoded by serializers as "Terminal".
    /// </summary>
    [EnumMember(Value = "TERM")]
    [IsoId("_xXLfUwxrEeKa_56Jbsi1RQ")]
    [Description(@"Payment terminal point of interaction.")]
    Terminal,
    
    /// <summary>
    /// Device sub-component of a component of the point of interaction.
    /// Encoded/decoded by serializers as "Device".
    /// </summary>
    [EnumMember(Value = "DVCE")]
    [IsoId("_xtWjoQxrEeKa_56Jbsi1RQ")]
    [Description(@"Device sub-component of a component of the point of interaction.")]
    Device,
    
    /// <summary>
    /// Security module.
    /// Encoded/decoded by serializers as "SecureModule".
    /// </summary>
    [EnumMember(Value = "SECM")]
    [IsoId("_y3cYMQxrEeKa_56Jbsi1RQ")]
    [Description(@"Security module.")]
    SecureModule,
    
    /// <summary>
    /// Payment application software.
    /// Encoded/decoded by serializers as "PaymentApplication".
    /// </summary>
    [EnumMember(Value = "APLI")]
    [IsoId("_zGUhsQxrEeKa_56Jbsi1RQ")]
    [Description(@"Payment application software.")]
    PaymentApplication,
    
    /// <summary>
    /// EMV application kernel (EMV is the chip card specifications initially defined by Eurocard, Mastercard and Visa).
    /// Encoded/decoded by serializers as "EMVKernel".
    /// </summary>
    [EnumMember(Value = "EMVK")]
    [IsoId("_0NbTsQxrEeKa_56Jbsi1RQ")]
    [Description(@"EMV application kernel (EMV is the chip card specifications initially defined by Eurocard, Mastercard and Visa).")]
    EMVKernel,
    
    /// <summary>
    /// EMV physical interface (EMV is the chip card specifications initially defined by Eurocard, Mastercard and Visa).
    /// Encoded/decoded by serializers as "EMVLevel1".
    /// </summary>
    [EnumMember(Value = "EMVO")]
    [IsoId("_0URikwxrEeKa_56Jbsi1RQ")]
    [Description(@"EMV physical interface (EMV is the chip card specifications initially defined by Eurocard, Mastercard and Visa).")]
    EMVLevel1,
    
    /// <summary>
    /// Software module of the point of interaction.
    /// Encoded/decoded by serializers as "Middleware".
    /// </summary>
    [EnumMember(Value = "MDWR")]
    [IsoId("_1LeQUQxrEeKa_56Jbsi1RQ")]
    [Description(@"Software module of the point of interaction.")]
    Middleware,
    
    /// <summary>
    /// Driver module of the point of interaction.
    /// Encoded/decoded by serializers as "Driver".
    /// </summary>
    [EnumMember(Value = "DRVR")]
    [IsoId("_1WemcQxrEeKa_56Jbsi1RQ")]
    [Description(@"Driver module of the point of interaction.")]
    Driver,
    
    /// <summary>
    /// Software that manages hardware to provide common services to the applications.
    /// Encoded/decoded by serializers as "OperatingSystem".
    /// </summary>
    [EnumMember(Value = "OPST")]
    [IsoId("_2Dju4wxrEeKa_56Jbsi1RQ")]
    [Description(@"Software that manages hardware to provide common services to the applications.")]
    OperatingSystem,
    
    /// <summary>
    /// Merchant configuration parameters for the point of interaction (POI).
    /// Encoded/decoded by serializers as "MerchantParameters".
    /// </summary>
    [EnumMember(Value = "MRPR")]
    [IsoId("_dvTqIS9EEeKd3ZKpOzeAxg")]
    [Description(@"Merchant configuration parameters for the point of interaction (POI).")]
    MerchantParameters,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class POIComponentType3CodeMetadataExtensions
{
    private static readonly POIComponentType3CodeDropdownSource _dropdownSource = new POIComponentType3CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IPOIComponentType3CodeDropdownRow GetMetadata(this POIComponentType3Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


