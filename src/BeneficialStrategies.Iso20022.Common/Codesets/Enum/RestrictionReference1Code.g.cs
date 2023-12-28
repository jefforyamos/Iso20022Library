﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for RestrictionReference1Code.  ISO2002 ID# _Q1UTcNavEei60tlze8Pqbw.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the restriction references to be applied to a transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Q1UTcNavEei60tlze8Pqbw")]
[Description(@"Specifies the restriction references to be applied to a transaction.")]
[DerivedFrom(typeof(RestrictionReferenceCode))]
public enum RestrictionReference1Code
{
    /// <summary>
    /// Addition of a cash restriction reference representing a cash sub-balance to be utilised within the settlement instruction for the debiting or crediting of cash.
    /// Encoded/decoded by serializers as "AddCashRestrictionReference".
    /// </summary>
    [EnumMember(Value = "ADDC")]
    [IsoId("_jGoHcdj7EeiHnvcp3FV_5w")]
    [Description(@"Addition of a cash restriction reference representing a cash sub-balance to be utilised within the settlement instruction for the debiting or crediting of cash.")]
    AddCashRestrictionReference,
    
    /// <summary>
    /// Addition of a securities restriction reference representing a securities sub-position to be utilised within the settlement instruction for the delivery or receipt of securities.
    /// Encoded/decoded by serializers as "AddSecuritiesRestrictionReference".
    /// </summary>
    [EnumMember(Value = "ADDS")]
    [IsoId("_jNngQdj7EeiHnvcp3FV_5w")]
    [Description(@"Addition of a securities restriction reference representing a securities sub-position to be utilised within the settlement instruction for the delivery or receipt of securities.")]
    AddSecuritiesRestrictionReference,
    
    /// <summary>
    /// Removal of a cash restriction reference, already present within the settlement instruction, representing a cash sub-balance to be utilised within the settlement instruction for the debiting or crediting of cash.
    /// Encoded/decoded by serializers as "RemoveCashRestrictionReference".
    /// </summary>
    [EnumMember(Value = "REMC")]
    [IsoId("_jTuIQdj7EeiHnvcp3FV_5w")]
    [Description(@"Removal of a cash restriction reference, already present within the settlement instruction, representing a cash sub-balance to be utilised within the settlement instruction for the debiting or crediting of cash.")]
    RemoveCashRestrictionReference,
    
    /// <summary>
    /// Removal of a securities restriction reference, already present within the settlement instruction, representing a securities sub-position to be utilised within the settlement instruction for the delivery or receipt of securities. 
    /// Encoded/decoded by serializers as "RemoveSecuritiesRestrictionReference".
    /// </summary>
    [EnumMember(Value = "REMS")]
    [IsoId("_jdPQodj7EeiHnvcp3FV_5w")]
    [Description(@"Removal of a securities restriction reference, already present within the settlement instruction, representing a securities sub-position to be utilised within the settlement instruction for the delivery or receipt of securities. ")]
    RemoveSecuritiesRestrictionReference,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class RestrictionReference1CodeMetadataExtensions
{
    private static readonly RestrictionReference1CodeDropdownSource _dropdownSource = new RestrictionReference1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IRestrictionReference1CodeDropdownRow GetMetadata(this RestrictionReference1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


