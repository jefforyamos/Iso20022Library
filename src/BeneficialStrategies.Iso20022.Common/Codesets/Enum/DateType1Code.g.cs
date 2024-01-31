﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for DateType1Code.  ISO2002 ID# _ayQmt9p-Ed-ak6NoX_4Aeg_-400780880.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies when date is unknown.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ayQmt9p-Ed-ak6NoX_4Aeg_-400780880")]
[Description(@"Specifies when date is unknown.")]
[DerivedFrom(typeof(DateTypeCode))]
public enum DateType1Code
{
    /// <summary>
    /// Date is unknown by the sender or has not been established.
    /// Encoded/decoded by serializers as "UKWN".
    /// </summary>
    [EnumMember(Value = "UKWN")]
    [IsoId("_ayQmuNp-Ed-ak6NoX_4Aeg_-6438361")]
    [Description(@"Date is unknown by the sender or has not been established.")]
    Unknown = DateTypeCode.Unknown, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class DateType1CodeMetadataExtensions
{
    private static readonly DateType1CodeDropdownSource _dropdownSource = new DateType1CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IDateType1CodeDropdownRow GetMetadata(this DateType1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


