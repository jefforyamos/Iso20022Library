﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for DepositType1Code.  ISO2002 ID# _YcMuSNp-Ed-ak6NoX_4Aeg_-543523872.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies whether the deposit is fixed term or call/notice.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_YcMuSNp-Ed-ak6NoX_4Aeg_-543523872")]
[Description(@"Specifies whether the deposit is fixed term or call/notice.")]
[DerivedFrom(typeof(DepositTypeCode))]
public enum DepositType1Code
{
    /// <summary>
    /// Specifies that it is a fixed term deposit.
    /// Encoded/decoded by serializers as "FITE".
    /// </summary>
    [EnumMember(Value = "FITE")]
    [IsoId("_YcWfQNp-Ed-ak6NoX_4Aeg_-2068684174")]
    [Description(@"Specifies that it is a fixed term deposit.")]
    FixedTerm = DepositTypeCode.FixedTerm, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Specifies that it is a call/notice deposit.
    /// Encoded/decoded by serializers as "CALL".
    /// </summary>
    [EnumMember(Value = "CALL")]
    [IsoId("_YcWfQdp-Ed-ak6NoX_4Aeg_1908506461")]
    [Description(@"Specifies that it is a call/notice deposit.")]
    Call = DepositTypeCode.Call, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class DepositType1CodeMetadataExtensions
{
    private static readonly DepositType1CodeDropdownSource _dropdownSource = new DepositType1CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IDepositType1CodeDropdownRow GetMetadata(this DepositType1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


