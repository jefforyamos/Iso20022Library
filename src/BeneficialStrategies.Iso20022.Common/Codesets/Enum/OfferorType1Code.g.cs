﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for OfferorType1Code.  ISO2002 ID# _1pa8lTL3EeKU9IrkkToqcw_1480504854.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies whether the offeror for the event is the issuing company or a third party.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_1pa8lTL3EeKU9IrkkToqcw_1480504854")]
[Description(@"Specifies whether the offeror for the event is the issuing company or a third party.")]
[DerivedFrom(typeof(OfferorTypeCode))]
public enum OfferorType1Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Self".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_1pa8ljL3EeKU9IrkkToqcw_2101612018")]
    [Description(@"??")]
    Self,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ThirdParty".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_1pktkDL3EeKU9IrkkToqcw_1987772952")]
    [Description(@"??")]
    ThirdParty,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class OfferorType1CodeMetadataExtensions
{
    private static readonly OfferorType1CodeDropdownSource _dropdownSource = new OfferorType1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IOfferorType1CodeDropdownRow GetMetadata(this OfferorType1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}

