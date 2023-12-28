﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for AttendanceContextCode.  ISO2002 ID# _TVyU4gEcEeCQm6a_G2yO_w_-1187530480.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Human attendance at the POI location during the transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_TVyU4gEcEeCQm6a_G2yO_w_-1187530480")]
[Description(@"Human attendance at the POI location during the transaction.")]
public enum AttendanceContextCode
{
    /// <summary>
    /// Attended payment, with an attendant.
    /// Encoded/decoded by serializers as "ATTD".
    /// </summary>
    [EnumMember(Value = "ATTD")]
    [IsoId("_TVyU4wEcEeCQm6a_G2yO_w_446638178")]
    [Description(@"Attended payment, with an attendant.")]
    Attended,
    
    /// <summary>
    /// Semi-attended, including self checkout. An attendant supervises several payment, and could be called to help the cardholder.
    /// Encoded/decoded by serializers as "SATT".
    /// </summary>
    [EnumMember(Value = "SATT")]
    [IsoId("_TVyU5AEcEeCQm6a_G2yO_w_569194929")]
    [Description(@"Semi-attended, including self checkout. An attendant supervises several payment, and could be called to help the cardholder.")]
    SemiAttended,
    
    /// <summary>
    /// Unattended payment, no attendant present.
    /// Encoded/decoded by serializers as "UATT".
    /// </summary>
    [EnumMember(Value = "UATT")]
    [IsoId("_TVyU5QEcEeCQm6a_G2yO_w_-1522557759")]
    [Description(@"Unattended payment, no attendant present.")]
    Unattended,
    
    /// <summary>
    /// Delivery by an attendant.
    /// Encoded/decoded by serializers as "ATTL".
    /// </summary>
    [EnumMember(Value = "ATTL")]
    [IsoId("_qutPAJVIEeWu36UkS2TkoQ")]
    [Description(@"Delivery by an attendant.")]
    AttendantDelivery,
    
    /// <summary>
    /// Delivery by the customer.
    /// Encoded/decoded by serializers as "CUST".
    /// </summary>
    [EnumMember(Value = "CUST")]
    [IsoId("_vQTx8JVIEeWu36UkS2TkoQ")]
    [Description(@"Delivery by the customer.")]
    CustomerDelivery,
    
    /// <summary>
    /// Delivery by a carrier.
    /// Encoded/decoded by serializers as "CARR".
    /// </summary>
    [EnumMember(Value = "CARR")]
    [IsoId("_yfDl4JVIEeWu36UkS2TkoQ")]
    [Description(@"Delivery by a carrier.")]
    CarrierDelivery,
    
    /// <summary>
    /// Full service for fuel distribution.
    /// Encoded/decoded by serializers as "FULL".
    /// </summary>
    [EnumMember(Value = "FULL")]
    [IsoId("_1uvN8JVIEeWu36UkS2TkoQ")]
    [Description(@"Full service for fuel distribution.")]
    FullServe,
    
    /// <summary>
    /// Self service for fuel distribution.
    /// Encoded/decoded by serializers as "SELF".
    /// </summary>
    [EnumMember(Value = "SELF")]
    [IsoId("_4i_eQJVIEeWu36UkS2TkoQ")]
    [Description(@"Self service for fuel distribution.")]
    SelfServe,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class AttendanceContextCodeMetadataExtensions
{
    private static readonly AttendanceContextCodeDropdownSource _dropdownSource = new AttendanceContextCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IAttendanceContextCodeDropdownRow GetMetadata(this AttendanceContextCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


