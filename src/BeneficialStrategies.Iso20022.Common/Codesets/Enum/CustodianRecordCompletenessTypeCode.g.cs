﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for CustodianRecordCompletenessTypeCode.  ISO2002 ID# _11fptTL3EeKU9IrkkToqcw_1241268024.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the state of details of the composite record on the system. Applicable to custodian service only.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_11fptTL3EeKU9IrkkToqcw_1241268024")]
[Description(@"Specifies the state of details of the composite record on the system. Applicable to custodian service only.")]
public enum CustodianRecordCompletenessTypeCode
{
    /// <summary>
    /// Custodian record is complete.
    /// Encoded/decoded by serializers as "COMP".
    /// </summary>
    [EnumMember(Value = "COMP")]
    [IsoId("_11pasDL3EeKU9IrkkToqcw_-85851678")]
    [Description(@"Custodian record is complete.")]
    Complete,
    
    /// <summary>
    /// Custodian record is incomplete.
    /// Encoded/decoded by serializers as "INCO".
    /// </summary>
    [EnumMember(Value = "INCO")]
    [IsoId("_11pasTL3EeKU9IrkkToqcw_-167921638")]
    [Description(@"Custodian record is incomplete.")]
    Incomplete,
    
    /// <summary>
    /// Custodian record is conditionally complete.
    /// Encoded/decoded by serializers as "CCOM".
    /// </summary>
    [EnumMember(Value = "CCOM")]
    [IsoId("_11pasjL3EeKU9IrkkToqcw_-1808310521")]
    [Description(@"Custodian record is conditionally complete.")]
    ConditionallyComplete,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class CustodianRecordCompletenessTypeCodeMetadataExtensions
{
    private static readonly CustodianRecordCompletenessTypeCodeDropdownSource _dropdownSource = new CustodianRecordCompletenessTypeCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ICustodianRecordCompletenessTypeCodeDropdownRow GetMetadata(this CustodianRecordCompletenessTypeCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


