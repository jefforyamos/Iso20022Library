﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for RetailerMessage1Code.  ISO2002 ID# _nGL_MNj5EeiojJsa6FYyew.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Identifies the type of process related to the message.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_nGL_MNj5EeiojJsa6FYyew")]
[Description(@"Identifies the type of process related to the message.")]
[DerivedFrom(typeof(RetailerMessageCode))]
public enum RetailerMessage1Code
{
    /// <summary>
    /// Abort the current process or the last request.
    /// Encoded/decoded by serializers as "Abort".
    /// </summary>
    [EnumMember(Value = "SSAB")]
    [IsoId("_rSuREdj5EeiojJsa6FYyew")]
    [Description(@"Abort the current process or the last request.")]
    Abort,
    
    /// <summary>
    /// To select and start customised administrative services provided by the POI, using a "menu" for an interactive or software interface, initiated by the Sale system.
    /// Encoded/decoded by serializers as "AdminRequest".
    /// </summary>
    [EnumMember(Value = "SAAQ")]
    [IsoId("_rXdnIdj5EeiojJsa6FYyew")]
    [Description(@"To select and start customised administrative services provided by the POI, using a ""menu"" for an interactive or software interface, initiated by the Sale system.")]
    AdminRequest,
    
    /// <summary>
    /// Response to the Admin request.
    /// Encoded/decoded by serializers as "AdminResponse".
    /// </summary>
    [EnumMember(Value = "SAAP")]
    [IsoId("_rbyGcdj5EeiojJsa6FYyew")]
    [Description(@"Response to the Admin request.")]
    AdminResponse,
    
    /// <summary>
    /// Request one or several functions of the device, from user Interface or payment peripherals on the POI system or on the Sale system. Functions can be Display, Input, Print, play sound, Card reader capabilities or Transmit a message.
    /// Encoded/decoded by serializers as "DeviceRequest".
    /// </summary>
    [EnumMember(Value = "SDDR")]
    [IsoId("_rf048dj5EeiojJsa6FYyew")]
    [Description(@"Request one or several functions of the device, from user Interface or payment peripherals on the POI system or on the Sale system. Functions can be Display, Input, Print, play sound, Card reader capabilities or Transmit a message.")]
    DeviceRequest,
    
    /// <summary>
    /// Response to a Device request.
    /// Encoded/decoded by serializers as "DeviceResponse".
    /// </summary>
    [EnumMember(Value = "SDDP")]
    [IsoId("_rultsdj5EeiojJsa6FYyew")]
    [Description(@"Response to a Device request.")]
    DeviceResponse,
    
    /// <summary>
    /// Notify the other party of an event that occurs on its side.
    /// Encoded/decoded by serializers as "EventNotification".
    /// </summary>
    [EnumMember(Value = "SSEN")]
    [IsoId("_ryxqIdj5EeiojJsa6FYyew")]
    [Description(@"Notify the other party of an event that occurs on its side.")]
    EventNotification,
    
    /// <summary>
    /// Request the status of a previous message for which the Sale system has no response.
    /// Encoded/decoded by serializers as "MessageStatusRequest".
    /// </summary>
    [EnumMember(Value = "SSMQ")]
    [IsoId("_r2hhsdj5EeiojJsa6FYyew")]
    [Description(@"Request the status of a previous message for which the Sale system has no response.")]
    MessageStatusRequest,
    
    /// <summary>
    /// Response to a Message Status request.
    /// Encoded/decoded by serializers as "MessageStatusResponse".
    /// </summary>
    [EnumMember(Value = "SSMR")]
    [IsoId("_r6olodj5EeiojJsa6FYyew")]
    [Description(@"Response to a Message Status request.")]
    MessageStatusResponse,
    
    /// <summary>
    /// Reject a previous received message, for technical or functional reasons.
    /// Encoded/decoded by serializers as "Rejection".
    /// </summary>
    [EnumMember(Value = "SSRJ")]
    [IsoId("_r-X2Idj5EeiojJsa6FYyew")]
    [Description(@"Reject a previous received message, for technical or functional reasons.")]
    Rejection,
    
    /// <summary>
    /// To request, by the Sale System, a report on a list of transactions on the POI system, or the status of a transaction.
    /// Encoded/decoded by serializers as "ReportRequest".
    /// </summary>
    [EnumMember(Value = "SARQ")]
    [IsoId("_sFLowdj5EeiojJsa6FYyew")]
    [Description(@"To request, by the Sale System, a report on a list of transactions on the POI system, or the status of a transaction.")]
    ReportRequest,
    
    /// <summary>
    /// Response to a Report request.
    /// Encoded/decoded by serializers as "ReportResponse".
    /// </summary>
    [EnumMember(Value = "SARP")]
    [IsoId("_sKIaMdj5EeiojJsa6FYyew")]
    [Description(@"Response to a Report request.")]
    ReportResponse,
    
    /// <summary>
    /// Response to a Reconciliation Request.
    /// Encoded/decoded by serializers as "SaleFinancialReconciliationResponse".
    /// </summary>
    [EnumMember(Value = "SFRP")]
    [IsoId("_sOFGEdj5EeiojJsa6FYyew")]
    [Description(@"Response to a Reconciliation Request.")]
    SaleFinancialReconciliationResponse,
    
    /// <summary>
    /// Request a reconciliation (different types) between Sale System and POI System.
    /// Encoded/decoded by serializers as "SaleFinancialReconciliationRequest".
    /// </summary>
    [EnumMember(Value = "SFRQ")]
    [IsoId("_sSuVgdj5EeiojJsa6FYyew")]
    [Description(@"Request a reconciliation (different types) between Sale System and POI System.")]
    SaleFinancialReconciliationRequest,
    
    /// <summary>
    /// Request a financial service like payment, reversal, loyalty, Balance Inquiry, etc.
    /// Encoded/decoded by serializers as "SaleFinancialServiceRequest".
    /// </summary>
    [EnumMember(Value = "SFSQ")]
    [IsoId("_sbiTQdj5EeiojJsa6FYyew")]
    [Description(@"Request a financial service like payment, reversal, loyalty, Balance Inquiry, etc.")]
    SaleFinancialServiceRequest,
    
    /// <summary>
    /// Response to a financial service request.
    /// Encoded/decoded by serializers as "SaleFinancialServiceResponse".
    /// </summary>
    [EnumMember(Value = "SFSP")]
    [IsoId("_sfJA4dj5EeiojJsa6FYyew")]
    [Description(@"Response to a financial service request.")]
    SaleFinancialServiceResponse,
    
    /// <summary>
    /// Request the management of a session: login, logout and diagnosis services. Initiated by the Sale system.
    /// Encoded/decoded by serializers as "SessionManagementRequest".
    /// </summary>
    [EnumMember(Value = "SASQ")]
    [IsoId("_sjzecdj5EeiojJsa6FYyew")]
    [Description(@"Request the management of a session: login, logout and diagnosis services. Initiated by the Sale system.")]
    SessionManagementRequest,
    
    /// <summary>
    /// Response to a session management request to initiate/terminate a session.
    /// Encoded/decoded by serializers as "SessionManagementResponse".
    /// </summary>
    [EnumMember(Value = "SASP")]
    [IsoId("_spX68dj5EeiojJsa6FYyew")]
    [Description(@"Response to a session management request to initiate/terminate a session.")]
    SessionManagementResponse,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class RetailerMessage1CodeMetadataExtensions
{
    private static readonly RetailerMessage1CodeDropdownSource _dropdownSource = new RetailerMessage1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IRetailerMessage1CodeDropdownRow GetMetadata(this RetailerMessage1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


