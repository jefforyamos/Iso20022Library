﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for CustodianAction1Code.  ISO2002 ID# _14n2MDL3EeKU9IrkkToqcw_-767286658.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies custodian activity codes.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_14n2MDL3EeKU9IrkkToqcw_-767286658")]
[Description(@"Specifies custodian activity codes.")]
[DerivedFrom(typeof(CustodianActionCode))]
public enum CustodianAction1Code
{
    /// <summary>
    /// Custodian is researching pending issues raised by the validation service.
    /// Encoded/decoded by serializers as "RSCH".
    /// </summary>
    [EnumMember(Value = "RSCH")]
    [IsoId("_14n2MTL3EeKU9IrkkToqcw_-892224501")]
    [Description(@"Custodian is researching pending issues raised by the validation service.")]
    Research = CustodianActionCode.Research, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Custodian is expected to send updated information.
    /// Encoded/decoded by serializers as "SEND".
    /// </summary>
    [EnumMember(Value = "SEND")]
    [IsoId("_14n2MjL3EeKU9IrkkToqcw_-146179494")]
    [Description(@"Custodian is expected to send updated information.")]
    SendInfo = CustodianActionCode.SendInfo, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Custodian disagrees with the validation service and will take no further action.
    /// Encoded/decoded by serializers as "DISS".
    /// </summary>
    [EnumMember(Value = "DISS")]
    [IsoId("_14n2MzL3EeKU9IrkkToqcw_1320969269")]
    [Description(@"Custodian disagrees with the validation service and will take no further action.")]
    Disagrees = CustodianActionCode.Disagrees, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// No action required by the custodian.
    /// Encoded/decoded by serializers as "NOAC".
    /// </summary>
    [EnumMember(Value = "NOAC")]
    [IsoId("_14n2NDL3EeKU9IrkkToqcw_-1838359691")]
    [Description(@"No action required by the custodian.")]
    NoAction = CustodianActionCode.NoAction, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class CustodianAction1CodeMetadataExtensions
{
    private static readonly CustodianAction1CodeDropdownSource _dropdownSource = new CustodianAction1CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ICustodianAction1CodeDropdownRow GetMetadata(this CustodianAction1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


