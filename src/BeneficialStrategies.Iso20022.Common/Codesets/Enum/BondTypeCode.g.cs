﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for BondTypeCode.  ISO2002 ID# _5al_gc4lEeSc85GUbgBycw.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of bonds.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_5al_gc4lEeSc85GUbgBycw")]
[Description(@"Specifies the type of bonds.")]
public enum BondTypeCode
{
    /// <summary>
    /// Bond of type sovereign bond.
    /// 
    /// Encoded/decoded by serializers as "EUSB".
    /// </summary>
    [EnumMember(Value = "EUSB")]
    [IsoId("_BKKTQM4mEeSc85GUbgBycw")]
    [Description(@"Bond of type sovereign bond. ")]
    SovereignBond,
    
    /// <summary>
    /// Bond of type non-european sovereign bond.
    /// Encoded/decoded by serializers as "NESB".
    /// </summary>
    [EnumMember(Value = "NESB")]
    [IsoId("_BX_68M4mEeSc85GUbgBycw")]
    [Description(@"Bond of type non-european sovereign bond.")]
    NonEuropeanSovereignBond,
    
    /// <summary>
    /// Bond of type other public bond.
    /// Encoded/decoded by serializers as "OEPB".
    /// </summary>
    [EnumMember(Value = "OEPB")]
    [IsoId("_BcTzMM4mEeSc85GUbgBycw")]
    [Description(@"Bond of type other public bond.")]
    OtherPublicBond,
    
    /// <summary>
    /// Bond of type convertible bond.
    /// Encoded/decoded by serializers as "CVTB".
    /// </summary>
    [EnumMember(Value = "CVTB")]
    [IsoId("_Bfb_sM4mEeSc85GUbgBycw")]
    [Description(@"Bond of type convertible bond.")]
    ConvertibleBond,
    
    /// <summary>
    /// Bond of type covered Bond.
    /// Encoded/decoded by serializers as "CVDB".
    /// </summary>
    [EnumMember(Value = "CVDB")]
    [IsoId("_BhhDUM4mEeSc85GUbgBycw")]
    [Description(@"Bond of type covered Bond.")]
    CoveredBond,
    
    /// <summary>
    /// Bond of type corporate Bond.
    /// 
    /// Encoded/decoded by serializers as "CRPB".
    /// </summary>
    [EnumMember(Value = "CRPB")]
    [IsoId("_BkWU4M4mEeSc85GUbgBycw")]
    [Description(@"Bond of type corporate Bond. ")]
    CorporateBond,
    
    /// <summary>
    /// Bond of type other non-european public bond.
    /// Encoded/decoded by serializers as "ONEP".
    /// </summary>
    [EnumMember(Value = "ONEP")]
    [IsoId("_s22aMAkBEeWGouz230Xp5Q")]
    [Description(@"Bond of type other non-european public bond.")]
    OtherNonEuropeanPublicBond,
    
    /// <summary>
    /// Other bond type.
    /// Encoded/decoded by serializers as "OTHR".
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_ss_CcED6EeW1yage4PQ__A")]
    [Description(@"Other bond type.")]
    Other,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class BondTypeCodeMetadataExtensions
{
    private static readonly BondTypeCodeDropdownSource _dropdownSource = new BondTypeCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IBondTypeCodeDropdownRow GetMetadata(this BondTypeCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


