﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for CorporateActionNotificationType1Code.  ISO2002 ID# _bK_Pxdp-Ed-ak6NoX_4Aeg_724518589.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Type of notification advice.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_bK_Pxdp-Ed-ak6NoX_4Aeg_724518589")]
[Description(@"Type of notification advice.")]
[DerivedFrom(typeof(CorporateActionNotificationTypeCode))]
public enum CorporateActionNotificationType1Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "New".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_bK_Pxtp-Ed-ak6NoX_4Aeg_724518620")]
    [Description(@"??")]
    New,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Replacement".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_bK_Px9p-Ed-ak6NoX_4Aeg_724518628")]
    [Description(@"??")]
    Replacement,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Reminder".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_bK_PyNp-Ed-ak6NoX_4Aeg_724518629")]
    [Description(@"??")]
    Reminder,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class CorporateActionNotificationType1CodeMetadataExtensions
{
    private static readonly CorporateActionNotificationType1CodeDropdownSource _dropdownSource = new CorporateActionNotificationType1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ICorporateActionNotificationType1CodeDropdownRow GetMetadata(this CorporateActionNotificationType1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}

