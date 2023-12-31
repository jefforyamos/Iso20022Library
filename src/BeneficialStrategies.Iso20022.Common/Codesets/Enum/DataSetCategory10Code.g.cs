﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for DataSetCategory10Code.  ISO2002 ID# _Ue5BEY35EeWRwov1g9WL_A.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Maintenance services provided by a terminal manager.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Ue5BEY35EeWRwov1g9WL_A")]
[Description(@"Maintenance services provided by a terminal manager.")]
[DerivedFrom(typeof(DataSetCategoryCode))]
public enum DataSetCategory10Code
{
    /// <summary>
    /// Acquirer specific configuration parameters for the point of interaction (POI) system.
    /// Encoded/decoded by serializers as "AcquirerParameters".
    /// </summary>
    [EnumMember(Value = "AQPR")]
    [IsoId("_UpxbYY35EeWRwov1g9WL_A")]
    [Description(@"Acquirer specific configuration parameters for the point of interaction (POI) system.")]
    AcquirerParameters,
    
    /// <summary>
    /// Payment application specific configuration parameters for the point of interaction (POI) system.
    /// Encoded/decoded by serializers as "ApplicationParameters".
    /// </summary>
    [EnumMember(Value = "APPR")]
    [IsoId("_UpxbY435EeWRwov1g9WL_A")]
    [Description(@"Payment application specific configuration parameters for the point of interaction (POI) system.")]
    ApplicationParameters,
    
    /// <summary>
    /// The terminal manager is the master.
    /// Encoded/decoded by serializers as "MasterTerminalManager".
    /// </summary>
    [EnumMember(Value = "MTMG")]
    [IsoId("_UpxbZY35EeWRwov1g9WL_A")]
    [Description(@"The terminal manager is the master.")]
    MasterTerminalManager,
    
    /// <summary>
    /// Merchant configuration parameters for the point of interaction (POI).
    /// Encoded/decoded by serializers as "MerchantParameters".
    /// </summary>
    [EnumMember(Value = "MRPR")]
    [IsoId("_UpxbZ435EeWRwov1g9WL_A")]
    [Description(@"Merchant configuration parameters for the point of interaction (POI).")]
    MerchantParameters,
    
    /// <summary>
    /// Monitoring of the terminal estate.
    /// Encoded/decoded by serializers as "Monitoring".
    /// </summary>
    [EnumMember(Value = "MTOR")]
    [IsoId("_UpxbaY35EeWRwov1g9WL_A")]
    [Description(@"Monitoring of the terminal estate.")]
    Monitoring,
    
    /// <summary>
    /// Point of interaction parameters related to the security of software application and application protocol.
    /// Encoded/decoded by serializers as "SecurityParameters".
    /// </summary>
    [EnumMember(Value = "SCPR")]
    [IsoId("_Upxba435EeWRwov1g9WL_A")]
    [Description(@"Point of interaction parameters related to the security of software application and application protocol.")]
    SecurityParameters,
    
    /// <summary>
    /// Software module.
    /// Encoded/decoded by serializers as "SoftwareModule".
    /// </summary>
    [EnumMember(Value = "SWPK")]
    [IsoId("_UpxbbY35EeWRwov1g9WL_A")]
    [Description(@"Software module.")]
    SoftwareModule,
    
    /// <summary>
    /// Point of interaction parameters attached to the terminal as serial number or physical capabilities.
    /// Encoded/decoded by serializers as "TerminalParameters".
    /// </summary>
    [EnumMember(Value = "TRPR")]
    [IsoId("_Upxbb435EeWRwov1g9WL_A")]
    [Description(@"Point of interaction parameters attached to the terminal as serial number or physical capabilities.")]
    TerminalParameters,
    
    /// <summary>
    /// Certificate provided by a terminal manager.
    /// Encoded/decoded by serializers as "CertificateParameters".
    /// </summary>
    [EnumMember(Value = "CRTF")]
    [IsoId("_YHlmEY35EeWRwov1g9WL_A")]
    [Description(@"Certificate provided by a terminal manager.")]
    CertificateParameters,
    
    /// <summary>
    /// Configuration parameters for the TMS protocol.
    /// Encoded/decoded by serializers as "TMSProtocolParameters".
    /// </summary>
    [EnumMember(Value = "TMSP")]
    [IsoId("_Yhq6AY35EeWRwov1g9WL_A")]
    [Description(@"Configuration parameters for the TMS protocol.")]
    TMSProtocolParameters,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class DataSetCategory10CodeMetadataExtensions
{
    private static readonly DataSetCategory10CodeDropdownSource _dropdownSource = new DataSetCategory10CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IDataSetCategory10CodeDropdownRow GetMetadata(this DataSetCategory10Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


