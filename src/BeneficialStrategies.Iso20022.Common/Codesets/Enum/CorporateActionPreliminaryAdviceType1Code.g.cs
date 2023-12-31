﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for CorporateActionPreliminaryAdviceType1Code.  ISO2002 ID# _bRs7x9p-Ed-ak6NoX_4Aeg_-934341596.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Type of movement preliminary advice.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_bRs7x9p-Ed-ak6NoX_4Aeg_-934341596")]
[Description(@"Type of movement preliminary advice.")]
[DerivedFrom(typeof(CorporateActionPreliminaryAdviceTypeCode))]
public enum CorporateActionPreliminaryAdviceType1Code
{
    /// <summary>
    /// New movement preliminary advice.
    /// Encoded/decoded by serializers as "New".
    /// </summary>
    [EnumMember(Value = "NEWM")]
    [IsoId("_bRs7yNp-Ed-ak6NoX_4Aeg_1528787514")]
    [Description(@"New movement preliminary advice.")]
    New,
    
    /// <summary>
    /// Movement preliminary advice replacing a previously sent preliminary advice.
    /// Encoded/decoded by serializers as "Replacement".
    /// </summary>
    [EnumMember(Value = "REPL")]
    [IsoId("_bRs7ydp-Ed-ak6NoX_4Aeg_-1299031019")]
    [Description(@"Movement preliminary advice replacing a previously sent preliminary advice.")]
    Replacement,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class CorporateActionPreliminaryAdviceType1CodeMetadataExtensions
{
    private static readonly CorporateActionPreliminaryAdviceType1CodeDropdownSource _dropdownSource = new CorporateActionPreliminaryAdviceType1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ICorporateActionPreliminaryAdviceType1CodeDropdownRow GetMetadata(this CorporateActionPreliminaryAdviceType1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


