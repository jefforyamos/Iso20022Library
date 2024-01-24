﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for HoldingAccountLevel1Code.  ISO2002 ID# _VKUfkE1pEeSvz4A_x0ui8g.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the level at which the safekeeping holding account has been defined.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_VKUfkE1pEeSvz4A_x0ui8g")]
[Description(@"Specifies the level at which the safekeeping holding account has been defined.")]
[DerivedFrom(typeof(HoldingAccountLevelCode))]
public enum HoldingAccountLevel1Code
{
    /// <summary>
    /// Holding account is defined as the safekeeping account (Level 0).
    /// Encoded/decoded by serializers as "SAFE".
    /// </summary>
    [EnumMember(Value = "SAFE")]
    [IsoId("_cNACsU1qEeSvz4A_x0ui8g")]
    [Description(@"Holding account is defined as the safekeeping account (Level 0).")]
    SafekeepingAccount = HoldingAccountLevelCode.SafekeepingAccount, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Holding account is defined as the sub-level 1 account.
    /// Encoded/decoded by serializers as "LVL1".
    /// </summary>
    [EnumMember(Value = "LVL1")]
    [IsoId("_cUJMgU1qEeSvz4A_x0ui8g")]
    [Description(@"Holding account is defined as the sub-level 1 account.")]
    Level1 = HoldingAccountLevelCode.Level1, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Holding account is defined as the sub-level 2 account.
    /// Encoded/decoded by serializers as "LVL2".
    /// </summary>
    [EnumMember(Value = "LVL2")]
    [IsoId("_cbIlUU1qEeSvz4A_x0ui8g")]
    [Description(@"Holding account is defined as the sub-level 2 account.")]
    Level2 = HoldingAccountLevelCode.Level2, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Holding account is defined as the sub-level 3 account.
    /// Encoded/decoded by serializers as "LVL3".
    /// </summary>
    [EnumMember(Value = "LVL3")]
    [IsoId("_cdq78U1qEeSvz4A_x0ui8g")]
    [Description(@"Holding account is defined as the sub-level 3 account.")]
    Level3 = HoldingAccountLevelCode.Level3, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Holding account is defined as the sub-level 4 account.
    /// Encoded/decoded by serializers as "LVL4".
    /// </summary>
    [EnumMember(Value = "LVL4")]
    [IsoId("_coYXIU1qEeSvz4A_x0ui8g")]
    [Description(@"Holding account is defined as the sub-level 4 account.")]
    Level4 = HoldingAccountLevelCode.Level4, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Holding account is defined as the sub-level 5 account.
    /// Encoded/decoded by serializers as "LVL5".
    /// </summary>
    [EnumMember(Value = "LVL5")]
    [IsoId("_cvhg8U1qEeSvz4A_x0ui8g")]
    [Description(@"Holding account is defined as the sub-level 5 account.")]
    Level5 = HoldingAccountLevelCode.Level5, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Holding account is defined as the sub-level 6 account.
    /// Encoded/decoded by serializers as "LVL6".
    /// </summary>
    [EnumMember(Value = "LVL6")]
    [IsoId("_c1nh4U1qEeSvz4A_x0ui8g")]
    [Description(@"Holding account is defined as the sub-level 6 account.")]
    Level6 = HoldingAccountLevelCode.Level6, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Holding account is defined as the sub-level 7 account.
    /// Encoded/decoded by serializers as "LVL7".
    /// </summary>
    [EnumMember(Value = "LVL7")]
    [IsoId("_c8T_wU1qEeSvz4A_x0ui8g")]
    [Description(@"Holding account is defined as the sub-level 7 account.")]
    Level7 = HoldingAccountLevelCode.Level7, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Holding account is defined as the sub-level 8 account.
    /// Encoded/decoded by serializers as "LVL8".
    /// </summary>
    [EnumMember(Value = "LVL8")]
    [IsoId("_dBrA4U1qEeSvz4A_x0ui8g")]
    [Description(@"Holding account is defined as the sub-level 8 account.")]
    Level8 = HoldingAccountLevelCode.Level8, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Holding account is defined as the sub-level 9 account.
    /// Encoded/decoded by serializers as "LVL9".
    /// </summary>
    [EnumMember(Value = "LVL9")]
    [IsoId("_dHU88U1qEeSvz4A_x0ui8g")]
    [Description(@"Holding account is defined as the sub-level 9 account.")]
    Level9 = HoldingAccountLevelCode.Level9, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class HoldingAccountLevel1CodeMetadataExtensions
{
    private static readonly HoldingAccountLevel1CodeDropdownSource _dropdownSource = new HoldingAccountLevel1CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IHoldingAccountLevel1CodeDropdownRow GetMetadata(this HoldingAccountLevel1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


