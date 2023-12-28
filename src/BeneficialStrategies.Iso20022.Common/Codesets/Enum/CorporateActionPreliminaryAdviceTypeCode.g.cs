﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for CorporateActionPreliminaryAdviceTypeCode.  ISO2002 ID# _bR2FsNp-Ed-ak6NoX_4Aeg_570400157.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Type of movement preliminary advice.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_bR2FsNp-Ed-ak6NoX_4Aeg_570400157")]
[Description(@"Type of movement preliminary advice.")]
public enum CorporateActionPreliminaryAdviceTypeCode
{
    /// <summary>
    /// New movement preliminary advice.
    /// Encoded/decoded by serializers as "NEWM".
    /// </summary>
    [EnumMember(Value = "NEWM")]
    [IsoId("_bR2Fsdp-Ed-ak6NoX_4Aeg_456561091")]
    [Description(@"New movement preliminary advice.")]
    New,
    
    /// <summary>
    /// Movement preliminary advice replacing a previously sent preliminary advice.
    /// Encoded/decoded by serializers as "REPL".
    /// </summary>
    [EnumMember(Value = "REPL")]
    [IsoId("_bR2Fstp-Ed-ak6NoX_4Aeg_-248553524")]
    [Description(@"Movement preliminary advice replacing a previously sent preliminary advice.")]
    Replacement,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class CorporateActionPreliminaryAdviceTypeCodeMetadataExtensions
{
    private static readonly CorporateActionPreliminaryAdviceTypeCodeDropdownSource _dropdownSource = new CorporateActionPreliminaryAdviceTypeCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ICorporateActionPreliminaryAdviceTypeCodeDropdownRow GetMetadata(this CorporateActionPreliminaryAdviceTypeCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


