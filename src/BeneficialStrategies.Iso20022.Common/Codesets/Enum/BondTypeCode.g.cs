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
    /// </summary>
    [EnumMember(Value = "EUSB")]
    [IsoId("_BKKTQM4mEeSc85GUbgBycw")]
    [Description(@"Bond of type sovereign bond. ")]
    EUSB,
    
    /// <summary>
    /// Bond of type non-european sovereign bond.
    /// </summary>
    [EnumMember(Value = "NESB")]
    [IsoId("_BX_68M4mEeSc85GUbgBycw")]
    [Description(@"Bond of type non-european sovereign bond.")]
    NESB,
    
    /// <summary>
    /// Bond of type other public bond.
    /// </summary>
    [EnumMember(Value = "OEPB")]
    [IsoId("_BcTzMM4mEeSc85GUbgBycw")]
    [Description(@"Bond of type other public bond.")]
    OEPB,
    
    /// <summary>
    /// Bond of type convertible bond.
    /// </summary>
    [EnumMember(Value = "CVTB")]
    [IsoId("_Bfb_sM4mEeSc85GUbgBycw")]
    [Description(@"Bond of type convertible bond.")]
    CVTB,
    
    /// <summary>
    /// Bond of type covered Bond.
    /// </summary>
    [EnumMember(Value = "CVDB")]
    [IsoId("_BhhDUM4mEeSc85GUbgBycw")]
    [Description(@"Bond of type covered Bond.")]
    CVDB,
    
    /// <summary>
    /// Bond of type corporate Bond.
    /// 
    /// </summary>
    [EnumMember(Value = "CRPB")]
    [IsoId("_BkWU4M4mEeSc85GUbgBycw")]
    [Description(@"Bond of type corporate Bond. ")]
    CRPB,
    
    /// <summary>
    /// Bond of type other non-european public bond.
    /// </summary>
    [EnumMember(Value = "ONEP")]
    [IsoId("_s22aMAkBEeWGouz230Xp5Q")]
    [Description(@"Bond of type other non-european public bond.")]
    ONEP,
    
    /// <summary>
    /// Other bond type.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_ss_CcED6EeW1yage4PQ__A")]
    [Description(@"Other bond type.")]
    OTHR,
    
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


