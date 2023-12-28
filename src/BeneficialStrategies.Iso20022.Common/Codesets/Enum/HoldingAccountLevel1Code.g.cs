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
    /// ??
    /// Encoded/decoded by serializers as "SafekeepingAccount".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_cNACsU1qEeSvz4A_x0ui8g")]
    [Description(@"??")]
    SafekeepingAccount,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Level1".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_cUJMgU1qEeSvz4A_x0ui8g")]
    [Description(@"??")]
    Level1,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Level2".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_cbIlUU1qEeSvz4A_x0ui8g")]
    [Description(@"??")]
    Level2,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Level3".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_cdq78U1qEeSvz4A_x0ui8g")]
    [Description(@"??")]
    Level3,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Level4".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_coYXIU1qEeSvz4A_x0ui8g")]
    [Description(@"??")]
    Level4,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Level5".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_cvhg8U1qEeSvz4A_x0ui8g")]
    [Description(@"??")]
    Level5,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Level6".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_c1nh4U1qEeSvz4A_x0ui8g")]
    [Description(@"??")]
    Level6,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Level7".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_c8T_wU1qEeSvz4A_x0ui8g")]
    [Description(@"??")]
    Level7,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Level8".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_dBrA4U1qEeSvz4A_x0ui8g")]
    [Description(@"??")]
    Level8,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Level9".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_dHU88U1qEeSvz4A_x0ui8g")]
    [Description(@"??")]
    Level9,
    
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


