﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for DataSetCategory12Code.  ISO2002 ID# _NLHlwdqMEeearpaEPXv9UA.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Category of data set.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_NLHlwdqMEeearpaEPXv9UA")]
[Description(@"Category of data set.")]
[DerivedFrom(typeof(DataSetCategoryCode))]
public enum DataSetCategory12Code
{
    /// <summary>
    /// Acquirer specific configuration parameters for the point of interaction (POI) system.
    /// Encoded/decoded by serializers as "AQPR".
    /// </summary>
    [EnumMember(Value = "AQPR")]
    [IsoId("_NXsCIdqMEeearpaEPXv9UA")]
    [Description(@"Acquirer specific configuration parameters for the point of interaction (POI) system.")]
    AcquirerParameters = DataSetCategoryCode.AcquirerParameters, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Payment application specific configuration parameters for the point of interaction (POI) system.
    /// Encoded/decoded by serializers as "APPR".
    /// </summary>
    [EnumMember(Value = "APPR")]
    [IsoId("_NXsCI9qMEeearpaEPXv9UA")]
    [Description(@"Payment application specific configuration parameters for the point of interaction (POI) system.")]
    ApplicationParameters = DataSetCategoryCode.ApplicationParameters, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Batch upload of transaction data (data capture of a group of transactions).
    /// Encoded/decoded by serializers as "TXCP".
    /// </summary>
    [EnumMember(Value = "TXCP")]
    [IsoId("_NXsCJdqMEeearpaEPXv9UA")]
    [Description(@"Batch upload of transaction data (data capture of a group of transactions).")]
    BatchCapture = DataSetCategoryCode.BatchCapture, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Batch download response for the batch capture of transactions.
    /// Encoded/decoded by serializers as "AKCP".
    /// </summary>
    [EnumMember(Value = "AKCP")]
    [IsoId("_NXsCJ9qMEeearpaEPXv9UA")]
    [Description(@"Batch download response for the batch capture of transactions.")]
    CaptureResponse = DataSetCategoryCode.CaptureResponse, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Data needed to create a terminal management sub-domain.
    /// Encoded/decoded by serializers as "DLGT".
    /// </summary>
    [EnumMember(Value = "DLGT")]
    [IsoId("_NXsCKdqMEeearpaEPXv9UA")]
    [Description(@"Data needed to create a terminal management sub-domain.")]
    DelegationData = DataSetCategoryCode.DelegationData, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Configuration of management plan in the point of interaction.
    /// Encoded/decoded by serializers as "MGTP".
    /// </summary>
    [EnumMember(Value = "MGTP")]
    [IsoId("_NXsCK9qMEeearpaEPXv9UA")]
    [Description(@"Configuration of management plan in the point of interaction.")]
    ManagementPlan = DataSetCategoryCode.ManagementPlan, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Merchant configuration parameters for the point of interaction (POI).
    /// Encoded/decoded by serializers as "MRPR".
    /// </summary>
    [EnumMember(Value = "MRPR")]
    [IsoId("_NXsCLdqMEeearpaEPXv9UA")]
    [Description(@"Merchant configuration parameters for the point of interaction (POI).")]
    MerchantParameters = DataSetCategoryCode.MerchantParameters, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Point of interaction parameters related to the security of software application and application protocol.
    /// Encoded/decoded by serializers as "SCPR".
    /// </summary>
    [EnumMember(Value = "SCPR")]
    [IsoId("_NXsCL9qMEeearpaEPXv9UA")]
    [Description(@"Point of interaction parameters related to the security of software application and application protocol.")]
    SecurityParameters = DataSetCategoryCode.SecurityParameters, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Software module.
    /// Encoded/decoded by serializers as "SWPK".
    /// </summary>
    [EnumMember(Value = "SWPK")]
    [IsoId("_NXsCMdqMEeearpaEPXv9UA")]
    [Description(@"Software module.")]
    SoftwareModule = DataSetCategoryCode.SoftwareModule, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Report of software configuration and parameter status.
    /// Encoded/decoded by serializers as "STRP".
    /// </summary>
    [EnumMember(Value = "STRP")]
    [IsoId("_NXsCM9qMEeearpaEPXv9UA")]
    [Description(@"Report of software configuration and parameter status.")]
    StatusReport = DataSetCategoryCode.StatusReport, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Point of interaction parameters attached to the terminal as serial number or physical capabilities.
    /// Encoded/decoded by serializers as "TRPR".
    /// </summary>
    [EnumMember(Value = "TRPR")]
    [IsoId("_NXsCNdqMEeearpaEPXv9UA")]
    [Description(@"Point of interaction parameters attached to the terminal as serial number or physical capabilities.")]
    TerminalParameters = DataSetCategoryCode.TerminalParameters, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Point of interaction parameters defined by the manufacturer for instance the PIN verification capabilities.
    /// Encoded/decoded by serializers as "VDPR".
    /// </summary>
    [EnumMember(Value = "VDPR")]
    [IsoId("_NXsCN9qMEeearpaEPXv9UA")]
    [Description(@"Point of interaction parameters defined by the manufacturer for instance the PIN verification capabilities.")]
    VendorParameters = DataSetCategoryCode.VendorParameters, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Any combination of configuration parameters for the point of interaction (POI).
    /// Encoded/decoded by serializers as "PARA".
    /// </summary>
    [EnumMember(Value = "PARA")]
    [IsoId("_NXsCOdqMEeearpaEPXv9UA")]
    [Description(@"Any combination of configuration parameters for the point of interaction (POI).")]
    Parameters = DataSetCategoryCode.Parameters, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Configuration parameters for the TMS protocol.
    /// Encoded/decoded by serializers as "TMSP".
    /// </summary>
    [EnumMember(Value = "TMSP")]
    [IsoId("_NXsCO9qMEeearpaEPXv9UA")]
    [Description(@"Configuration parameters for the TMS protocol.")]
    TMSProtocolParameters = DataSetCategoryCode.TMSProtocolParameters, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Certificate provided by a terminal manager.
    /// Encoded/decoded by serializers as "CRTF".
    /// </summary>
    [EnumMember(Value = "CRTF")]
    [IsoId("_NXsCPdqMEeearpaEPXv9UA")]
    [Description(@"Certificate provided by a terminal manager.")]
    CertificateParameters = DataSetCategoryCode.CertificateParameters, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Any repository used for recording log traces.
    /// Encoded/decoded by serializers as "LOGF".
    /// </summary>
    [EnumMember(Value = "LOGF")]
    [IsoId("_Tlwt8dqMEeearpaEPXv9UA")]
    [Description(@"Any repository used for recording log traces.")]
    LogFile = DataSetCategoryCode.LogFile, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Trigger for CertificateManagementRequest.
    /// Encoded/decoded by serializers as "CMRQ".
    /// </summary>
    [EnumMember(Value = "CMRQ")]
    [IsoId("_UA4jsdqMEeearpaEPXv9UA")]
    [Description(@"Trigger for CertificateManagementRequest.")]
    CertificateManagementRequest = DataSetCategoryCode.CertificateManagementRequest, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class DataSetCategory12CodeMetadataExtensions
{
    private static readonly DataSetCategory12CodeDropdownSource _dropdownSource = new DataSetCategory12CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IDataSetCategory12CodeDropdownRow GetMetadata(this DataSetCategory12Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


