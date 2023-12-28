﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for TaxWrapperAmountTypeCode.  ISO2002 ID# _vrqp8F24EeiFXdiLi_Nf4A.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies a type of amount.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_vrqp8F24EeiFXdiLi_Nf4A")]
[Description(@"Specifies a type of amount.")]
public enum TaxWrapperAmountTypeCode
{
    /// <summary>
    /// Type of amount is a bonus, for example, a government bonus.
    /// Encoded/decoded by serializers as "BONU".
    /// </summary>
    [EnumMember(Value = "BONU")]
    [IsoId("_yDkVcF24EeiFXdiLi_Nf4A")]
    [Description(@"Type of amount is a bonus, for example, a government bonus.")]
    Bonus,
    
    /// <summary>
    /// Type of amount is a withdrawal, for example, a withdrawal for a first time residential purchase.
    /// Encoded/decoded by serializers as "WTHD".
    /// </summary>
    [EnumMember(Value = "WTHD")]
    [IsoId("_4O2zAF24EeiFXdiLi_Nf4A")]
    [Description(@"Type of amount is a withdrawal, for example, a withdrawal for a first time residential purchase.")]
    Withdrawal,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class TaxWrapperAmountTypeCodeMetadataExtensions
{
    private static readonly TaxWrapperAmountTypeCodeDropdownSource _dropdownSource = new TaxWrapperAmountTypeCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ITaxWrapperAmountTypeCodeDropdownRow GetMetadata(this TaxWrapperAmountTypeCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


