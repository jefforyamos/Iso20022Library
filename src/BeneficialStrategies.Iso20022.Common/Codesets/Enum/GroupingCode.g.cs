﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for GroupingCode.  ISO2002 ID# _au04M9p-Ed-ak6NoX_4Aeg_-1706891243.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the grouping options of the payment transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_au04M9p-Ed-ak6NoX_4Aeg_-1706891243")]
[Description(@"Specifies the grouping options of the payment transaction.")]
[Derivations(typeof(Grouping1Code))]
// External derivations that should be provided by the proper interface are: 
public enum GroupingCode
{
    /// <summary>
    /// Indicates that for each occurrences of the payment information block, exactly one occurrence of the payment transaction block is present.
    /// Encoded/decoded by serializers as "SNGL".
    /// </summary>
    [EnumMember(Value = "SNGL")]
    [IsoId("_au04NNp-Ed-ak6NoX_4Aeg_-1661638294")]
    [Description(@"Indicates that for each occurrences of the payment information block, exactly one occurrence of the payment transaction block is present.")]
    Single,
    
    /// <summary>
    /// Indicates that there is only one occurrence of the payment information block and several occurrences of the payment transaction block.
    /// Encoded/decoded by serializers as "GRPD".
    /// </summary>
    [EnumMember(Value = "GRPD")]
    [IsoId("_au04Ndp-Ed-ak6NoX_4Aeg_-1575752625")]
    [Description(@"Indicates that there is only one occurrence of the payment information block and several occurrences of the payment transaction block.")]
    Grouped,
    
    /// <summary>
    /// Indicates that there are one or several occurrences of the payment information block where each of the occurrences might contain one or several occurrences of the payment transaction block.
    /// Encoded/decoded by serializers as "MIXD".
    /// </summary>
    [EnumMember(Value = "MIXD")]
    [IsoId("_au04Ntp-Ed-ak6NoX_4Aeg_-1530498717")]
    [Description(@"Indicates that there are one or several occurrences of the payment information block where each of the occurrences might contain one or several occurrences of the payment transaction block.")]
    Mixed,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class GroupingCodeMetadataExtensions
{
    private static readonly GroupingCodeDropdownSource _dropdownSource = new GroupingCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IGroupingCodeDropdownRow GetMetadata(this GroupingCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


