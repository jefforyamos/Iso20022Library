﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for DataSetCategory6Code.  ISO2002 ID# _2Bzp4Gp8EeSojYXQbRlLzA.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Maintenance service to delegate.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_2Bzp4Gp8EeSojYXQbRlLzA")]
[Description(@"Maintenance service to delegate.")]
[DerivedFrom(typeof(DataSetCategoryCode))]
public enum DataSetCategory6Code
{
    /// <summary>
    /// Configuration parameters of the payment acquirer protocol.
    /// Encoded/decoded by serializers as "ACQP".
    /// </summary>
    [EnumMember(Value = "ACQP")]
    [IsoId("_6LDXMWp8EeSojYXQbRlLzA")]
    [Description(@"Configuration parameters of the payment acquirer protocol.")]
    AcquirerProtocolParameters = DataSetCategoryCode.AcquirerProtocolParameters, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Payment application specific configuration parameters for the point of interaction (POI) system.
    /// Encoded/decoded by serializers as "APPR".
    /// </summary>
    [EnumMember(Value = "APPR")]
    [IsoId("_6ZgC42p8EeSojYXQbRlLzA")]
    [Description(@"Payment application specific configuration parameters for the point of interaction (POI) system.")]
    ApplicationParameters = DataSetCategoryCode.ApplicationParameters, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Creation of a subset of the configuration parameters of an application.
    /// Encoded/decoded by serializers as "APSB".
    /// </summary>
    [EnumMember(Value = "APSB")]
    [IsoId("_6jo2U2p8EeSojYXQbRlLzA")]
    [Description(@"Creation of a subset of the configuration parameters of an application.")]
    ApplicationParametersSubsetCreation = DataSetCategoryCode.ApplicationParametersSubsetCreation, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Download of cryptographic keys with the related information.
    /// Encoded/decoded by serializers as "KDWL".
    /// </summary>
    [EnumMember(Value = "KDWL")]
    [IsoId("_7TeX02p8EeSojYXQbRlLzA")]
    [Description(@"Download of cryptographic keys with the related information.")]
    KeyDownload = DataSetCategoryCode.KeyDownload, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Activate, deactivate or revoke loaded cryptographic keys.
    /// Encoded/decoded by serializers as "KMGT".
    /// </summary>
    [EnumMember(Value = "KMGT")]
    [IsoId("_7b0bg2p8EeSojYXQbRlLzA")]
    [Description(@"Activate, deactivate or revoke loaded cryptographic keys.")]
    KeyManagement = DataSetCategoryCode.KeyManagement, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Reporting on activity, status and error of a point of interaction.
    /// Encoded/decoded by serializers as "RPRT".
    /// </summary>
    [EnumMember(Value = "RPRT")]
    [IsoId("_-PTPwWp8EeSojYXQbRlLzA")]
    [Description(@"Reporting on activity, status and error of a point of interaction.")]
    Reporting = DataSetCategoryCode.Reporting, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Software module.
    /// Encoded/decoded by serializers as "SWPK".
    /// </summary>
    [EnumMember(Value = "SWPK")]
    [IsoId("_-mGmM2p8EeSojYXQbRlLzA")]
    [Description(@"Software module.")]
    SoftwareModule = DataSetCategoryCode.SoftwareModule, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Configuration parameters for the TMS protocol.
    /// Encoded/decoded by serializers as "TMSP".
    /// </summary>
    [EnumMember(Value = "TMSP")]
    [IsoId("_AyxSE2p9EeSojYXQbRlLzA")]
    [Description(@"Configuration parameters for the TMS protocol.")]
    TMSProtocolParameters = DataSetCategoryCode.TMSProtocolParameters, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Merchant configuration parameters for the point of interaction (POI).
    /// Encoded/decoded by serializers as "MRPR".
    /// </summary>
    [EnumMember(Value = "MRPR")]
    [IsoId("_lLgEYXcPEeSrj6VUY5LyCg")]
    [Description(@"Merchant configuration parameters for the point of interaction (POI).")]
    MerchantParameters = DataSetCategoryCode.MerchantParameters, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Point of interaction parameters attached to the terminal as serial number or physical capabilities.
    /// Encoded/decoded by serializers as "TRPR".
    /// </summary>
    [EnumMember(Value = "TRPR")]
    [IsoId("_mynMIXcPEeSrj6VUY5LyCg")]
    [Description(@"Point of interaction parameters attached to the terminal as serial number or physical capabilities.")]
    TerminalParameters = DataSetCategoryCode.TerminalParameters, // same ordinal as derivation source for type conversions
    
}
