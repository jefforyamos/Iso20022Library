﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for DividendRateType1Code.  ISO2002 ID# _pWIogfPoEd-_UpPm03UNGQ.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of dividend rate.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_pWIogfPoEd-_UpPm03UNGQ")]
[Description(@"Specifies the type of dividend rate.")]
[DerivedFrom(typeof(DividendRateTypeCode))]
public enum DividendRateType1Code
{
    /// <summary>
    /// Rate relating to the underlying security for which tax is charged.
    /// Encoded/decoded by serializers as "TaxablePortion".
    /// </summary>
    [EnumMember(Value = "TXBL")]
    [IsoId("_q3yFdGtdEeCY4-KZ9JEyUQ_-747091417")]
    [Description(@"Rate relating to the underlying security for which tax is charged.")]
    TaxablePortion,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class DividendRateType1CodeMetadataExtensions
{
    private static readonly DividendRateType1CodeDropdownSource _dropdownSource = new DividendRateType1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IDividendRateType1CodeDropdownRow GetMetadata(this DividendRateType1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


