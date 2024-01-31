﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for DataSetCategory18Code.  ISO2002 ID# _zT5JgXC7Ee2bmOA3bkVsMg.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Category of data set.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_zT5JgXC7Ee2bmOA3bkVsMg")]
[Description(@"Category of data set.")]
[DerivedFrom(typeof(DataSetCategoryCode))]
public enum DataSetCategory18Code
{
    /// <summary>
    /// Acquirer specific configuration parameters for the point of interaction (POI) system.
    /// Encoded/decoded by serializers as "AQPR".
    /// </summary>
    [EnumMember(Value = "AQPR")]
    [IsoId("_zbWcYXC7Ee2bmOA3bkVsMg")]
    [Description(@"Acquirer specific configuration parameters for the point of interaction (POI) system.")]
    AcquirerParameters = DataSetCategoryCode.AcquirerParameters, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Payment application specific configuration parameters for the point of interaction (POI) system.
    /// Encoded/decoded by serializers as "APPR".
    /// </summary>
    [EnumMember(Value = "APPR")]
    [IsoId("_zbWcY3C7Ee2bmOA3bkVsMg")]
    [Description(@"Payment application specific configuration parameters for the point of interaction (POI) system.")]
    ApplicationParameters = DataSetCategoryCode.ApplicationParameters, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Batch upload of transaction data (data capture of a group of transactions).
    /// Encoded/decoded by serializers as "TXCP".
    /// </summary>
    [EnumMember(Value = "TXCP")]
    [IsoId("_zbWcZXC7Ee2bmOA3bkVsMg")]
    [Description(@"Batch upload of transaction data (data capture of a group of transactions).")]
    BatchCapture = DataSetCategoryCode.BatchCapture, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Batch download response for the batch capture of transactions.
    /// Encoded/decoded by serializers as "AKCP".
    /// </summary>
    [EnumMember(Value = "AKCP")]
    [IsoId("_zbWcZ3C7Ee2bmOA3bkVsMg")]
    [Description(@"Batch download response for the batch capture of transactions.")]
    CaptureResponse = DataSetCategoryCode.CaptureResponse, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Data needed to create a terminal management sub-domain.
    /// Encoded/decoded by serializers as "DLGT".
    /// </summary>
    [EnumMember(Value = "DLGT")]
    [IsoId("_zbWcaXC7Ee2bmOA3bkVsMg")]
    [Description(@"Data needed to create a terminal management sub-domain.")]
    DelegationData = DataSetCategoryCode.DelegationData, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Configuration of management plan in the point of interaction.
    /// Encoded/decoded by serializers as "MGTP".
    /// </summary>
    [EnumMember(Value = "MGTP")]
    [IsoId("_zbWca3C7Ee2bmOA3bkVsMg")]
    [Description(@"Configuration of management plan in the point of interaction.")]
    ManagementPlan = DataSetCategoryCode.ManagementPlan, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Merchant configuration parameters for the point of interaction (POI).
    /// Encoded/decoded by serializers as "MRPR".
    /// </summary>
    [EnumMember(Value = "MRPR")]
    [IsoId("_zbWcbXC7Ee2bmOA3bkVsMg")]
    [Description(@"Merchant configuration parameters for the point of interaction (POI).")]
    MerchantParameters = DataSetCategoryCode.MerchantParameters, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Point of interaction parameters related to the security of software application and application protocol.
    /// Encoded/decoded by serializers as "SCPR".
    /// </summary>
    [EnumMember(Value = "SCPR")]
    [IsoId("_zbWcb3C7Ee2bmOA3bkVsMg")]
    [Description(@"Point of interaction parameters related to the security of software application and application protocol.")]
    SecurityParameters = DataSetCategoryCode.SecurityParameters, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Software module.
    /// Encoded/decoded by serializers as "SWPK".
    /// </summary>
    [EnumMember(Value = "SWPK")]
    [IsoId("_zbWccXC7Ee2bmOA3bkVsMg")]
    [Description(@"Software module.")]
    SoftwareModule = DataSetCategoryCode.SoftwareModule, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Report of software configuration and parameter status.
    /// Encoded/decoded by serializers as "STRP".
    /// </summary>
    [EnumMember(Value = "STRP")]
    [IsoId("_zbWcc3C7Ee2bmOA3bkVsMg")]
    [Description(@"Report of software configuration and parameter status.")]
    StatusReport = DataSetCategoryCode.StatusReport, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Point of interaction parameters attached to the terminal as serial number or physical capabilities.
    /// Encoded/decoded by serializers as "TRPR".
    /// </summary>
    [EnumMember(Value = "TRPR")]
    [IsoId("_zbWcdXC7Ee2bmOA3bkVsMg")]
    [Description(@"Point of interaction parameters attached to the terminal as serial number or physical capabilities.")]
    TerminalParameters = DataSetCategoryCode.TerminalParameters, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Point of interaction parameters defined by the manufacturer for instance the PIN verification capabilities.
    /// Encoded/decoded by serializers as "VDPR".
    /// </summary>
    [EnumMember(Value = "VDPR")]
    [IsoId("_zbWcd3C7Ee2bmOA3bkVsMg")]
    [Description(@"Point of interaction parameters defined by the manufacturer for instance the PIN verification capabilities.")]
    VendorParameters = DataSetCategoryCode.VendorParameters, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Any combination of configuration parameters for the point of interaction (POI).
    /// Encoded/decoded by serializers as "PARA".
    /// </summary>
    [EnumMember(Value = "PARA")]
    [IsoId("_zbWceXC7Ee2bmOA3bkVsMg")]
    [Description(@"Any combination of configuration parameters for the point of interaction (POI).")]
    Parameters = DataSetCategoryCode.Parameters, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Configuration parameters for the TMS protocol.
    /// Encoded/decoded by serializers as "TMSP".
    /// </summary>
    [EnumMember(Value = "TMSP")]
    [IsoId("_zbWce3C7Ee2bmOA3bkVsMg")]
    [Description(@"Configuration parameters for the TMS protocol.")]
    TMSProtocolParameters = DataSetCategoryCode.TMSProtocolParameters, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Certificate provided by a terminal manager.
    /// Encoded/decoded by serializers as "CRTF".
    /// </summary>
    [EnumMember(Value = "CRTF")]
    [IsoId("_zbWcfXC7Ee2bmOA3bkVsMg")]
    [Description(@"Certificate provided by a terminal manager.")]
    CertificateParameters = DataSetCategoryCode.CertificateParameters, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Any repository used for recording log traces.
    /// Encoded/decoded by serializers as "LOGF".
    /// </summary>
    [EnumMember(Value = "LOGF")]
    [IsoId("_zbWcf3C7Ee2bmOA3bkVsMg")]
    [Description(@"Any repository used for recording log traces.")]
    LogFile = DataSetCategoryCode.LogFile, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Trigger for CertificateManagementRequest.
    /// Encoded/decoded by serializers as "CMRQ".
    /// </summary>
    [EnumMember(Value = "CMRQ")]
    [IsoId("_zbWcgXC7Ee2bmOA3bkVsMg")]
    [Description(@"Trigger for CertificateManagementRequest.")]
    CertificateManagementRequest = DataSetCategoryCode.CertificateManagementRequest, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Media file managed by an application of the POI.
    /// Encoded/decoded by serializers as "MDFL".
    /// </summary>
    [EnumMember(Value = "MDFL")]
    [IsoId("_zbWcg3C7Ee2bmOA3bkVsMg")]
    [Description(@"Media file managed by an application of the POI.")]
    MediaFile = DataSetCategoryCode.MediaFile, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Configuration file relevant for the POI.
    /// Encoded/decoded by serializers as "CONF".
    /// </summary>
    [EnumMember(Value = "CONF")]
    [IsoId("_zbWchXC7Ee2bmOA3bkVsMg")]
    [Description(@"Configuration file relevant for the POI.")]
    ConfigurationFile = DataSetCategoryCode.ConfigurationFile, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Report file generated by the POI.
    /// Encoded/decoded by serializers as "RPFL".
    /// </summary>
    [EnumMember(Value = "RPFL")]
    [IsoId("_zbWch3C7Ee2bmOA3bkVsMg")]
    [Description(@"Report file generated by the POI.")]
    ReportFile = DataSetCategoryCode.ReportFile, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Parameters related to the Sale to POI protocol.
    /// Encoded/decoded by serializers as "SAPR".
    /// </summary>
    [EnumMember(Value = "SAPR")]
    [IsoId("_-eojoXC7Ee2bmOA3bkVsMg")]
    [Description(@"Parameters related to the Sale to POI protocol.")]
    SaleToPOIProtocolParameters = DataSetCategoryCode.SaleToPOIProtocolParameters, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Service Provider specific parameters for the point of interaction (POI) system.
    /// Encoded/decoded by serializers as "SPRP".
    /// </summary>
    [EnumMember(Value = "SPRP")]
    [IsoId("__x_o8XC7Ee2bmOA3bkVsMg")]
    [Description(@"Service Provider specific parameters for the point of interaction (POI) system.")]
    ServiceProviderParameters = DataSetCategoryCode.ServiceProviderParameters, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class DataSetCategory18CodeMetadataExtensions
{
    private static readonly DataSetCategory18CodeDropdownSource _dropdownSource = new DataSetCategory18CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IDataSetCategory18CodeDropdownRow GetMetadata(this DataSetCategory18Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


