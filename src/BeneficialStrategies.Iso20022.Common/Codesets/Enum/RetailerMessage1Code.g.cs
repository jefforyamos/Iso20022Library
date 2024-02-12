﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for RetailerMessage1Code.  ISO2002 ID# _nGL_MNj5EeiojJsa6FYyew.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

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
    /// Encoded/decoded by serializers as "SSAB".
    /// </summary>
    [EnumMember(Value = "SSAB")]
    [IsoId("_rSuREdj5EeiojJsa6FYyew")]
    [Description(@"Abort the current process or the last request.")]
    Abort = RetailerMessageCode.Abort, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// To select and start customised administrative services provided by the POI, using a "menu" for an interactive or software interface, initiated by the Sale system.
    /// Encoded/decoded by serializers as "SAAQ".
    /// </summary>
    [EnumMember(Value = "SAAQ")]
    [IsoId("_rXdnIdj5EeiojJsa6FYyew")]
    [Description(@"To select and start customised administrative services provided by the POI, using a ""menu"" for an interactive or software interface, initiated by the Sale system.")]
    AdminRequest = RetailerMessageCode.AdminRequest, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Response to the Admin request.
    /// Encoded/decoded by serializers as "SAAP".
    /// </summary>
    [EnumMember(Value = "SAAP")]
    [IsoId("_rbyGcdj5EeiojJsa6FYyew")]
    [Description(@"Response to the Admin request.")]
    AdminResponse = RetailerMessageCode.AdminResponse, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Request one or several functions of the device, from user Interface or payment peripherals on the POI system or on the Sale system. Functions can be Display, Input, Print, play sound, Card reader capabilities or Transmit a message.
    /// Encoded/decoded by serializers as "SDDR".
    /// </summary>
    [EnumMember(Value = "SDDR")]
    [IsoId("_rf048dj5EeiojJsa6FYyew")]
    [Description(@"Request one or several functions of the device, from user Interface or payment peripherals on the POI system or on the Sale system. Functions can be Display, Input, Print, play sound, Card reader capabilities or Transmit a message.")]
    DeviceRequest = RetailerMessageCode.DeviceRequest, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Response to a Device request.
    /// Encoded/decoded by serializers as "SDDP".
    /// </summary>
    [EnumMember(Value = "SDDP")]
    [IsoId("_rultsdj5EeiojJsa6FYyew")]
    [Description(@"Response to a Device request.")]
    DeviceResponse = RetailerMessageCode.DeviceResponse, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Notify the other party of an event that occurs on its side.
    /// Encoded/decoded by serializers as "SSEN".
    /// </summary>
    [EnumMember(Value = "SSEN")]
    [IsoId("_ryxqIdj5EeiojJsa6FYyew")]
    [Description(@"Notify the other party of an event that occurs on its side.")]
    EventNotification = RetailerMessageCode.EventNotification, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Request the status of a previous message for which the Sale system has no response.
    /// Encoded/decoded by serializers as "SSMQ".
    /// </summary>
    [EnumMember(Value = "SSMQ")]
    [IsoId("_r2hhsdj5EeiojJsa6FYyew")]
    [Description(@"Request the status of a previous message for which the Sale system has no response.")]
    MessageStatusRequest = RetailerMessageCode.MessageStatusRequest, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Response to a Message Status request.
    /// Encoded/decoded by serializers as "SSMR".
    /// </summary>
    [EnumMember(Value = "SSMR")]
    [IsoId("_r6olodj5EeiojJsa6FYyew")]
    [Description(@"Response to a Message Status request.")]
    MessageStatusResponse = RetailerMessageCode.MessageStatusResponse, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Reject a previous received message, for technical or functional reasons.
    /// Encoded/decoded by serializers as "SSRJ".
    /// </summary>
    [EnumMember(Value = "SSRJ")]
    [IsoId("_r-X2Idj5EeiojJsa6FYyew")]
    [Description(@"Reject a previous received message, for technical or functional reasons.")]
    Rejection = RetailerMessageCode.Rejection, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// To request, by the Sale System, a report on a list of transactions on the POI system, or the status of a transaction.
    /// Encoded/decoded by serializers as "SARQ".
    /// </summary>
    [EnumMember(Value = "SARQ")]
    [IsoId("_sFLowdj5EeiojJsa6FYyew")]
    [Description(@"To request, by the Sale System, a report on a list of transactions on the POI system, or the status of a transaction.")]
    ReportRequest = RetailerMessageCode.ReportRequest, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Response to a Report request.
    /// Encoded/decoded by serializers as "SARP".
    /// </summary>
    [EnumMember(Value = "SARP")]
    [IsoId("_sKIaMdj5EeiojJsa6FYyew")]
    [Description(@"Response to a Report request.")]
    ReportResponse = RetailerMessageCode.ReportResponse, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Response to a Reconciliation Request.
    /// Encoded/decoded by serializers as "SFRP".
    /// </summary>
    [EnumMember(Value = "SFRP")]
    [IsoId("_sOFGEdj5EeiojJsa6FYyew")]
    [Description(@"Response to a Reconciliation Request.")]
    SaleFinancialReconciliationResponse = RetailerMessageCode.SaleFinancialReconciliationResponse, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Request a reconciliation (different types) between Sale System and POI System.
    /// Encoded/decoded by serializers as "SFRQ".
    /// </summary>
    [EnumMember(Value = "SFRQ")]
    [IsoId("_sSuVgdj5EeiojJsa6FYyew")]
    [Description(@"Request a reconciliation (different types) between Sale System and POI System.")]
    SaleFinancialReconciliationRequest = RetailerMessageCode.SaleFinancialReconciliationRequest, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Request a financial service like payment, reversal, loyalty, Balance Inquiry, etc.
    /// Encoded/decoded by serializers as "SFSQ".
    /// </summary>
    [EnumMember(Value = "SFSQ")]
    [IsoId("_sbiTQdj5EeiojJsa6FYyew")]
    [Description(@"Request a financial service like payment, reversal, loyalty, Balance Inquiry, etc.")]
    SaleFinancialServiceRequest = RetailerMessageCode.SaleFinancialServiceRequest, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Response to a financial service request.
    /// Encoded/decoded by serializers as "SFSP".
    /// </summary>
    [EnumMember(Value = "SFSP")]
    [IsoId("_sfJA4dj5EeiojJsa6FYyew")]
    [Description(@"Response to a financial service request.")]
    SaleFinancialServiceResponse = RetailerMessageCode.SaleFinancialServiceResponse, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Request the management of a session: login, logout and diagnosis services. Initiated by the Sale system.
    /// Encoded/decoded by serializers as "SASQ".
    /// </summary>
    [EnumMember(Value = "SASQ")]
    [IsoId("_sjzecdj5EeiojJsa6FYyew")]
    [Description(@"Request the management of a session: login, logout and diagnosis services. Initiated by the Sale system.")]
    SessionManagementRequest = RetailerMessageCode.SessionManagementRequest, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Response to a session management request to initiate/terminate a session.
    /// Encoded/decoded by serializers as "SASP".
    /// </summary>
    [EnumMember(Value = "SASP")]
    [IsoId("_spX68dj5EeiojJsa6FYyew")]
    [Description(@"Response to a session management request to initiate/terminate a session.")]
    SessionManagementResponse = RetailerMessageCode.SessionManagementResponse, // same ordinal as derivation source for type conversions
    
}
