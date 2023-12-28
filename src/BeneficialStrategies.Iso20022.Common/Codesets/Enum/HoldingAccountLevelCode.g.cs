﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for HoldingAccountLevelCode.  ISO2002 ID# _SvcYkU1pEeSvz4A_x0ui8g.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the level of the safekeeping holding account.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_SvcYkU1pEeSvz4A_x0ui8g")]
[Description(@"Specifies the level of the safekeeping holding account.")]
public enum HoldingAccountLevelCode
{
    /// <summary>
    /// Holding account is defined as the safekeeping account (Level 0).
    /// Encoded/decoded by serializers as "SAFE".
    /// </summary>
    [EnumMember(Value = "SAFE")]
    [IsoId("_H5588E1qEeSvz4A_x0ui8g")]
    [Description(@"Holding account is defined as the safekeeping account (Level 0).")]
    SafekeepingAccount,
    
    /// <summary>
    /// Holding account is defined as the sub-level 1 account.
    /// Encoded/decoded by serializers as "LVL1".
    /// </summary>
    [EnumMember(Value = "LVL1")]
    [IsoId("_Mx4_kU1qEeSvz4A_x0ui8g")]
    [Description(@"Holding account is defined as the sub-level 1 account.")]
    Level1,
    
    /// <summary>
    /// Holding account is defined as the sub-level 2 account.
    /// Encoded/decoded by serializers as "LVL2".
    /// </summary>
    [EnumMember(Value = "LVL2")]
    [IsoId("_NgcusU1qEeSvz4A_x0ui8g")]
    [Description(@"Holding account is defined as the sub-level 2 account.")]
    Level2,
    
    /// <summary>
    /// Holding account is defined as the sub-level 3 account.
    /// Encoded/decoded by serializers as "LVL3".
    /// </summary>
    [EnumMember(Value = "LVL3")]
    [IsoId("_N1bgMU1qEeSvz4A_x0ui8g")]
    [Description(@"Holding account is defined as the sub-level 3 account.")]
    Level3,
    
    /// <summary>
    /// Holding account is defined as the sub-level 4 account.
    /// Encoded/decoded by serializers as "LVL4".
    /// </summary>
    [EnumMember(Value = "LVL4")]
    [IsoId("_ONh3IU1qEeSvz4A_x0ui8g")]
    [Description(@"Holding account is defined as the sub-level 4 account.")]
    Level4,
    
    /// <summary>
    /// Holding account is defined as the sub-level 5 account.
    /// Encoded/decoded by serializers as "LVL5".
    /// </summary>
    [EnumMember(Value = "LVL5")]
    [IsoId("_OgblAU1qEeSvz4A_x0ui8g")]
    [Description(@"Holding account is defined as the sub-level 5 account.")]
    Level5,
    
    /// <summary>
    /// Holding account is defined as the sub-level 6 account.
    /// Encoded/decoded by serializers as "LVL6".
    /// </summary>
    [EnumMember(Value = "LVL6")]
    [IsoId("_O0z5kU1qEeSvz4A_x0ui8g")]
    [Description(@"Holding account is defined as the sub-level 6 account.")]
    Level6,
    
    /// <summary>
    /// Holding account is defined as the sub-level 7 account.
    /// Encoded/decoded by serializers as "LVL7".
    /// </summary>
    [EnumMember(Value = "LVL7")]
    [IsoId("_PFUawU1qEeSvz4A_x0ui8g")]
    [Description(@"Holding account is defined as the sub-level 7 account.")]
    Level7,
    
    /// <summary>
    /// Holding account is defined as the sub-level 8 account.
    /// Encoded/decoded by serializers as "LVL8".
    /// </summary>
    [EnumMember(Value = "LVL8")]
    [IsoId("_PUpQMU1qEeSvz4A_x0ui8g")]
    [Description(@"Holding account is defined as the sub-level 8 account.")]
    Level8,
    
    /// <summary>
    /// Holding account is defined as the sub-level 9 account.
    /// Encoded/decoded by serializers as "LVL9".
    /// </summary>
    [EnumMember(Value = "LVL9")]
    [IsoId("_Pj0UoU1qEeSvz4A_x0ui8g")]
    [Description(@"Holding account is defined as the sub-level 9 account.")]
    Level9,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class HoldingAccountLevelCodeMetadataExtensions
{
    private static readonly HoldingAccountLevelCodeDropdownSource _dropdownSource = new HoldingAccountLevelCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IHoldingAccountLevelCodeDropdownRow GetMetadata(this HoldingAccountLevelCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}

