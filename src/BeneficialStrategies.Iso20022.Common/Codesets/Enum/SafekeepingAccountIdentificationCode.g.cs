﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for SafekeepingAccountIdentificationCode.  ISO2002 ID# _Y-eU5dp-Ed-ak6NoX_4Aeg_1234577798.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the account identification via a code.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Y-eU5dp-Ed-ak6NoX_4Aeg_1234577798")]
[Description(@"Specifies the account identification via a code.")]
public enum SafekeepingAccountIdentificationCode
{
    /// <summary>
    /// Announcement applies to all safekeeping accounts that own underlying financial instrument. (Used for general or preliminary announcements.).
    /// </summary>
    [EnumMember(Value = "GENR")]
    [IsoId("_Y-eU5tp-Ed-ak6NoX_4Aeg_1301070404")]
    [Description(@"Announcement applies to all safekeeping accounts that own underlying financial instrument. (Used for general or preliminary announcements.).")]
    GENR,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class SafekeepingAccountIdentificationCodeMetadataExtensions
{
    private static readonly SafekeepingAccountIdentificationCodeDropdownSource _dropdownSource = new SafekeepingAccountIdentificationCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ISafekeepingAccountIdentificationCodeDropdownRow GetMetadata(this SafekeepingAccountIdentificationCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


