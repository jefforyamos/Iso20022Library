﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for DataSetCategoryCode.  ISO2002 ID# _TWrsygEcEeCQm6a_G2yO_w_-1624727429.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Category of data set to transfer.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_TWrsygEcEeCQm6a_G2yO_w_-1624727429")]
[Description(@"Category of data set to transfer.")]
public enum DataSetCategoryCode
{
    /// <summary>
    /// Software module.
    /// Encoded/decoded by serializers as "SWPK".
    /// </summary>
    [EnumMember(Value = "SWPK")]
    [IsoId("_TWrsywEcEeCQm6a_G2yO_w_890065487")]
    [Description(@"Software module.")]
    SoftwareModule,
    
    /// <summary>
    /// Point of interaction parameters defined by the manufacturer for instance the PIN verification capabilities.
    /// Encoded/decoded by serializers as "VDPR".
    /// </summary>
    [EnumMember(Value = "VDPR")]
    [IsoId("_TWrszAEcEeCQm6a_G2yO_w_705092016")]
    [Description(@"Point of interaction parameters defined by the manufacturer for instance the PIN verification capabilities.")]
    VendorParameters,
    
    /// <summary>
    /// Acquirer specific configuration parameters for the point of interaction (POI) system.
    /// Encoded/decoded by serializers as "AQPR".
    /// </summary>
    [EnumMember(Value = "AQPR")]
    [IsoId("_TWrszQEcEeCQm6a_G2yO_w_-978830293")]
    [Description(@"Acquirer specific configuration parameters for the point of interaction (POI) system.")]
    AcquirerParameters,
    
    /// <summary>
    /// Payment application specific configuration parameters for the point of interaction (POI) system.
    /// Encoded/decoded by serializers as "APPR".
    /// </summary>
    [EnumMember(Value = "APPR")]
    [IsoId("_KWm4MH1DEeCF8NjrBemJWQ_1196473739")]
    [Description(@"Payment application specific configuration parameters for the point of interaction (POI) system.")]
    ApplicationParameters,
    
    /// <summary>
    /// Merchant configuration parameters for the point of interaction (POI).
    /// Encoded/decoded by serializers as "MRPR".
    /// </summary>
    [EnumMember(Value = "MRPR")]
    [IsoId("_TWrszgEcEeCQm6a_G2yO_w_838762194")]
    [Description(@"Merchant configuration parameters for the point of interaction (POI).")]
    MerchantParameters,
    
    /// <summary>
    /// Batch upload of transaction data (data capture of a group of transactions).
    /// Encoded/decoded by serializers as "TXCP".
    /// </summary>
    [EnumMember(Value = "TXCP")]
    [IsoId("_TWrszwEcEeCQm6a_G2yO_w_885914243")]
    [Description(@"Batch upload of transaction data (data capture of a group of transactions).")]
    BatchCapture,
    
    /// <summary>
    /// Batch download response for the batch capture of transactions.
    /// Encoded/decoded by serializers as "AKCP".
    /// </summary>
    [EnumMember(Value = "AKCP")]
    [IsoId("_TWrs0AEcEeCQm6a_G2yO_w_1271467143")]
    [Description(@"Batch download response for the batch capture of transactions.")]
    CaptureResponse,
    
    /// <summary>
    /// Report of software configuration and parameter status.
    /// Encoded/decoded by serializers as "STRP".
    /// </summary>
    [EnumMember(Value = "STRP")]
    [IsoId("_TWrs0QEcEeCQm6a_G2yO_w_1700273536")]
    [Description(@"Report of software configuration and parameter status.")]
    StatusReport,
    
    /// <summary>
    /// Data needed to create a terminal management sub-domain.
    /// Encoded/decoded by serializers as "DLGT".
    /// </summary>
    [EnumMember(Value = "DLGT")]
    [IsoId("_TWrs0gEcEeCQm6a_G2yO_w_-1125240516")]
    [Description(@"Data needed to create a terminal management sub-domain.")]
    DelegationData,
    
    /// <summary>
    /// Configuration of management plan in the point of interaction.
    /// Encoded/decoded by serializers as "MGTP".
    /// </summary>
    [EnumMember(Value = "MGTP")]
    [IsoId("_TW1dwAEcEeCQm6a_G2yO_w_1610252393")]
    [Description(@"Configuration of management plan in the point of interaction.")]
    ManagementPlan,
    
    /// <summary>
    /// Point of interaction parameters related to the security of software application and application protocol.
    /// Encoded/decoded by serializers as "SCPR".
    /// </summary>
    [EnumMember(Value = "SCPR")]
    [IsoId("_sQS68b4pEeKkGaJ0UrThyA_1871138823")]
    [Description(@"Point of interaction parameters related to the security of software application and application protocol.")]
    SecurityParameters,
    
    /// <summary>
    /// Point of interaction parameters attached to the terminal as serial number or physical capabilities.
    /// Encoded/decoded by serializers as "TRPR".
    /// </summary>
    [EnumMember(Value = "TRPR")]
    [IsoId("_sQS68r4pEeKkGaJ0UrThyA_1126225102")]
    [Description(@"Point of interaction parameters attached to the terminal as serial number or physical capabilities.")]
    TerminalParameters,
    
    /// <summary>
    /// Any combination of configuration parameters for the point of interaction (POI).
    /// Encoded/decoded by serializers as "PARA".
    /// </summary>
    [EnumMember(Value = "PARA")]
    [IsoId("_sBIh4GpKEeSR-ZWLvO-1dg")]
    [Description(@"Any combination of configuration parameters for the point of interaction (POI).")]
    Parameters,
    
    /// <summary>
    /// The terminal manager is the master.
    /// Encoded/decoded by serializers as "MTMG".
    /// </summary>
    [EnumMember(Value = "MTMG")]
    [IsoId("_UGZh4GpcEeS4r8z7dKyh1g")]
    [Description(@"The terminal manager is the master.")]
    MasterTerminalManager,
    
    /// <summary>
    /// Monitoring of the terminal estate.
    /// Encoded/decoded by serializers as "MTOR".
    /// </summary>
    [EnumMember(Value = "MTOR")]
    [IsoId("_XbVdYGpcEeS4r8z7dKyh1g")]
    [Description(@"Monitoring of the terminal estate.")]
    Monitoring,
    
    /// <summary>
    /// Configuration parameters of the payment acquirer protocol.
    /// Encoded/decoded by serializers as "ACQP".
    /// </summary>
    [EnumMember(Value = "ACQP")]
    [IsoId("_YyqPIGp8EeSojYXQbRlLzA")]
    [Description(@"Configuration parameters of the payment acquirer protocol.")]
    AcquirerProtocolParameters,
    
    /// <summary>
    /// Creation of a subset of the configuration parameters of an application.
    /// Encoded/decoded by serializers as "APSB".
    /// </summary>
    [EnumMember(Value = "APSB")]
    [IsoId("_f_5R4Gp8EeSojYXQbRlLzA")]
    [Description(@"Creation of a subset of the configuration parameters of an application.")]
    ApplicationParametersSubsetCreation,
    
    /// <summary>
    /// Download of cryptographic keys with the related information.
    /// Encoded/decoded by serializers as "KDWL".
    /// </summary>
    [EnumMember(Value = "KDWL")]
    [IsoId("_lVMioGp8EeSojYXQbRlLzA")]
    [Description(@"Download of cryptographic keys with the related information.")]
    KeyDownload,
    
    /// <summary>
    /// Activate, deactivate or revoke loaded cryptographic keys.
    /// Encoded/decoded by serializers as "KMGT".
    /// </summary>
    [EnumMember(Value = "KMGT")]
    [IsoId("_qapZgGp8EeSojYXQbRlLzA")]
    [Description(@"Activate, deactivate or revoke loaded cryptographic keys.")]
    KeyManagement,
    
    /// <summary>
    /// Reporting on activity, status and error of a point of interaction.
    /// Encoded/decoded by serializers as "RPRT".
    /// </summary>
    [EnumMember(Value = "RPRT")]
    [IsoId("_thufMGp8EeSojYXQbRlLzA")]
    [Description(@"Reporting on activity, status and error of a point of interaction.")]
    Reporting,
    
    /// <summary>
    /// Configuration parameters for the TMS protocol.
    /// Encoded/decoded by serializers as "TMSP".
    /// </summary>
    [EnumMember(Value = "TMSP")]
    [IsoId("_xmFsgGp8EeSojYXQbRlLzA")]
    [Description(@"Configuration parameters for the TMS protocol.")]
    TMSProtocolParameters,
    
    /// <summary>
    /// ATM protocol parameters, including the configuration of the hosts.
    /// Encoded/decoded by serializers as "ATMP".
    /// </summary>
    [EnumMember(Value = "ATMP")]
    [IsoId("_Xm7TEIn9EeShMpas3885ww")]
    [Description(@"ATM protocol parameters, including the configuration of the hosts.")]
    ATMProtocol,
    
    /// <summary>
    /// Configuration parameters of the ATM.
    /// Encoded/decoded by serializers as "ATMC".
    /// </summary>
    [EnumMember(Value = "ATMC")]
    [IsoId("_Zx2SgIn9EeShMpas3885ww")]
    [Description(@"Configuration parameters of the ATM.")]
    ATMConfiguration,
    
    /// <summary>
    /// Configuration parameters of the card application.
    /// Encoded/decoded by serializers as "CRAP".
    /// </summary>
    [EnumMember(Value = "CRAP")]
    [IsoId("_cQffMIn9EeShMpas3885ww")]
    [Description(@"Configuration parameters of the card application.")]
    CardApplication,
    
    /// <summary>
    /// Configuration of the cards accepted by the terminal.
    /// Encoded/decoded by serializers as "CPRC".
    /// </summary>
    [EnumMember(Value = "CPRC")]
    [IsoId("_gTsO4In9EeShMpas3885ww")]
    [Description(@"Configuration of the cards accepted by the terminal.")]
    CardConfiguration,
    
    /// <summary>
    /// Local rates for currency exchanges.
    /// Encoded/decoded by serializers as "OEXR".
    /// </summary>
    [EnumMember(Value = "OEXR")]
    [IsoId("_iXyNkIn9EeShMpas3885ww")]
    [Description(@"Local rates for currency exchanges.")]
    OfflineExchangeRate,
    
    /// <summary>
    /// Predefined amounts to be presented to the customer.
    /// Encoded/decoded by serializers as "AMNT".
    /// </summary>
    [EnumMember(Value = "AMNT")]
    [IsoId("_lCPBoIn9EeShMpas3885ww")]
    [Description(@"Predefined amounts to be presented to the customer.")]
    PreDefinedAmount,
    
    /// <summary>
    /// Configuration of the location.
    /// Encoded/decoded by serializers as "LOCC".
    /// </summary>
    [EnumMember(Value = "LOCC")]
    [IsoId("_nZxgwIn9EeShMpas3885ww")]
    [Description(@"Configuration of the location.")]
    LocationConfiguration,
    
    /// <summary>
    /// Configuration of the mobile operator cards accepted by the terminal.
    /// Encoded/decoded by serializers as "MNOC".
    /// </summary>
    [EnumMember(Value = "MNOC")]
    [IsoId("_qRRSUIn9EeShMpas3885ww")]
    [Description(@"Configuration of the mobile operator cards accepted by the terminal.")]
    MobileOperator,
    
    /// <summary>
    /// Batch of transaction that have generated an error in the totals of the reconciliation.
    /// Encoded/decoded by serializers as "RCLE".
    /// </summary>
    [EnumMember(Value = "RCLE")]
    [IsoId("_7RiooI3IEeWjkqXgn_0Imw")]
    [Description(@"Batch of transaction that have generated an error in the totals of the reconciliation.")]
    ReconciliationError,
    
    /// <summary>
    /// Certificate provided by a terminal manager.
    /// Encoded/decoded by serializers as "CRTF".
    /// </summary>
    [EnumMember(Value = "CRTF")]
    [IsoId("_XWqJII3dEeW32YMP0mBeyw")]
    [Description(@"Certificate provided by a terminal manager.")]
    CertificateParameters,
    
    /// <summary>
    /// Trigger for CertificateManagementRequest.
    /// Encoded/decoded by serializers as "CMRQ".
    /// </summary>
    [EnumMember(Value = "CMRQ")]
    [IsoId("_86hsINqLEeearpaEPXv9UA")]
    [Description(@"Trigger for CertificateManagementRequest.")]
    CertificateManagementRequest,
    
    /// <summary>
    /// Any repository used for recording log traces.
    /// Encoded/decoded by serializers as "LOGF".
    /// </summary>
    [EnumMember(Value = "LOGF")]
    [IsoId("_C60aoNqMEeearpaEPXv9UA")]
    [Description(@"Any repository used for recording log traces.")]
    LogFile,
    
    /// <summary>
    /// Parameters related to the Sale to POI protocol.
    /// Encoded/decoded by serializers as "SAPR".
    /// </summary>
    [EnumMember(Value = "SAPR")]
    [IsoId("_RpdMwNqhEeearpaEPXv9UA")]
    [Description(@"Parameters related to the Sale to POI protocol.")]
    SaleToPOIProtocolParameters,
    
    /// <summary>
    /// Component of the Sale system.
    /// Encoded/decoded by serializers as "SACP".
    /// </summary>
    [EnumMember(Value = "SACP")]
    [IsoId("_W9RPwNqhEeearpaEPXv9UA")]
    [Description(@"Component of the Sale system.")]
    SaleComponent,
    
    /// <summary>
    /// Media file managed by an application of the POI.
    /// Encoded/decoded by serializers as "MDFL".
    /// </summary>
    [EnumMember(Value = "MDFL")]
    [IsoId("_XmVr8A0ZEeqUVL7sB4m7NA")]
    [Description(@"Media file managed by an application of the POI.")]
    MediaFile,
    
    /// <summary>
    /// Software Application or module of the POI.
    /// Encoded/decoded by serializers as "SOFT".
    /// </summary>
    [EnumMember(Value = "SOFT")]
    [IsoId("_8t9e0A0ZEeqUVL7sB4m7NA")]
    [Description(@"Software Application or module of the POI.")]
    SoftwareApplication,
    
    /// <summary>
    /// Configuration file relevant for the POI.
    /// Encoded/decoded by serializers as "CONF".
    /// </summary>
    [EnumMember(Value = "CONF")]
    [IsoId("_GrZ_YA0aEeqUVL7sB4m7NA")]
    [Description(@"Configuration file relevant for the POI.")]
    ConfigurationFile,
    
    /// <summary>
    /// Report file generated by the POI.
    /// Encoded/decoded by serializers as "RPFL".
    /// </summary>
    [EnumMember(Value = "RPFL")]
    [IsoId("_MPKi4A0aEeqUVL7sB4m7NA")]
    [Description(@"Report file generated by the POI.")]
    ReportFile,
    
    /// <summary>
    /// Service Provider specific parameters for the point of interaction (POI) system.
    /// Encoded/decoded by serializers as "SPRP".
    /// </summary>
    [EnumMember(Value = "SPRP")]
    [IsoId("_4cIaoDALEeugIJ3Gvoevmg")]
    [Description(@"Service Provider specific parameters for the point of interaction (POI) system.")]
    ServiceProviderParameters,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class DataSetCategoryCodeMetadataExtensions
{
    private static readonly DataSetCategoryCodeDropdownSource _dropdownSource = new DataSetCategoryCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IDataSetCategoryCodeDropdownRow GetMetadata(this DataSetCategoryCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


