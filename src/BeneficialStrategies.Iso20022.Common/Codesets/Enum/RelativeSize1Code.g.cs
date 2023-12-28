﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for RelativeSize1Code.  ISO2002 ID# _ZsEat9p-Ed-ak6NoX_4Aeg_-1769491331.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// A type of quantity of financial instrument expressed in a relative size.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZsEat9p-Ed-ak6NoX_4Aeg_-1769491331")]
[Description(@"A type of quantity of financial instrument expressed in a relative size.")]
[DerivedFrom(typeof(RelativeSizeCode))]
public enum RelativeSize1Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Small".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_ZsEauNp-Ed-ak6NoX_4Aeg_-1702072394")]
    [Description(@"??")]
    Small,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Medium".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_ZsEaudp-Ed-ak6NoX_4Aeg_-1702072377")]
    [Description(@"??")]
    Medium,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Large".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_ZsOLsNp-Ed-ak6NoX_4Aeg_-1702072334")]
    [Description(@"??")]
    Large,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Undisclosed".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_ZsOLsdp-Ed-ak6NoX_4Aeg_-1702072317")]
    [Description(@"??")]
    Undisclosed,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class RelativeSize1CodeMetadataExtensions
{
    private static readonly RelativeSize1CodeDropdownSource _dropdownSource = new RelativeSize1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IRelativeSize1CodeDropdownRow GetMetadata(this RelativeSize1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}

