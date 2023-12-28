﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for AutoBorrowingCode.  ISO2002 ID# _bjuf5dp-Ed-ak6NoX_4Aeg_1205177778.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the condition under which automatic borrowing is allowed.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_bjuf5dp-Ed-ak6NoX_4Aeg_1205177778")]
[Description(@"Specifies the condition under which automatic borrowing is allowed.")]
[Derivations(typeof(AutoBorrowing1Code),typeof(AutoBorrowing2Code))]
// External derivations that should be provided by the proper interface are: 
public enum AutoBorrowingCode
{
    /// <summary>
    /// Only last resort borrowing should be considered to make settlement occur.
    /// Encoded/decoded by serializers as "LAMI".
    /// </summary>
    [EnumMember(Value = "LAMI")]
    [IsoId("_bjuf5tp-Ed-ak6NoX_4Aeg_1205177795")]
    [Description(@"Only last resort borrowing should be considered to make settlement occur.")]
    LastResort,
    
    /// <summary>
    /// No automatic borrowing should take place.
    /// Encoded/decoded by serializers as "NBOR".
    /// </summary>
    [EnumMember(Value = "NBOR")]
    [IsoId("_bjuf59p-Ed-ak6NoX_4Aeg_1205177796")]
    [Description(@"No automatic borrowing should take place.")]
    NoAutomatic,
    
    /// <summary>
    /// Automatic borrowing should take place.
    /// Encoded/decoded by serializers as "YBOR".
    /// </summary>
    [EnumMember(Value = "YBOR")]
    [IsoId("_bjuf6Np-Ed-ak6NoX_4Aeg_1205177813")]
    [Description(@"Automatic borrowing should take place.")]
    Automatic,
    
    /// <summary>
    /// Return of stocks should take place.
    /// Encoded/decoded by serializers as "RTRN".
    /// </summary>
    [EnumMember(Value = "RTRN")]
    [IsoId("_bjuf6dp-Ed-ak6NoX_4Aeg_-926996655")]
    [Description(@"Return of stocks should take place.")]
    Return,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class AutoBorrowingCodeMetadataExtensions
{
    private static readonly AutoBorrowingCodeDropdownSource _dropdownSource = new AutoBorrowingCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IAutoBorrowingCodeDropdownRow GetMetadata(this AutoBorrowingCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


