﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for SecuritiesLendingType1Code.  ISO2002 ID# __wINcdojEeC60axPepSq7g_2101036027.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Type of securities lending contract.
/// </summary>
[DataContract]
[Serializable]
[IsoId("__wINcdojEeC60axPepSq7g_2101036027")]
[Description(@"Type of securities lending contract.")]
[DerivedFrom(typeof(SecuritiesLendingTypeCode))]
public enum SecuritiesLendingType1Code
{
    /// <summary>
    /// Securities lending contract is new and registered.
    /// Encoded/decoded by serializers as "NewRegistration".
    /// </summary>
    [EnumMember(Value = "NWRG")]
    [IsoId("__wINctojEeC60axPepSq7g_-1300895809")]
    [Description(@"Securities lending contract is new and registered.")]
    NewRegistration,
    
    /// <summary>
    /// Securities lending contract is renewed.
    /// Encoded/decoded by serializers as "RollOverRenewal".
    /// </summary>
    [EnumMember(Value = "RENW")]
    [IsoId("__wINc9ojEeC60axPepSq7g_166252954")]
    [Description(@"Securities lending contract is renewed.")]
    RollOverRenewal,
    
    /// <summary>
    /// Securities lending contract is called back.
    /// Encoded/decoded by serializers as "CallBack".
    /// </summary>
    [EnumMember(Value = "CABK")]
    [IsoId("__wINdNojEeC60axPepSq7g_-1719429399")]
    [Description(@"Securities lending contract is called back.")]
    CallBack,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class SecuritiesLendingType1CodeMetadataExtensions
{
    private static readonly SecuritiesLendingType1CodeDropdownSource _dropdownSource = new SecuritiesLendingType1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ISecuritiesLendingType1CodeDropdownRow GetMetadata(this SecuritiesLendingType1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


