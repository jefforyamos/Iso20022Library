﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for SecuritiesLendingType1Code.  ISO2002 ID# __wINcdojEeC60axPepSq7g_2101036027.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

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
    /// Encoded/decoded by serializers as "NWRG".
    /// </summary>
    [EnumMember(Value = "NWRG")]
    [IsoId("__wINctojEeC60axPepSq7g_-1300895809")]
    [Description(@"Securities lending contract is new and registered.")]
    NewRegistration = SecuritiesLendingTypeCode.NewRegistration, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Securities lending contract is renewed.
    /// Encoded/decoded by serializers as "RENW".
    /// </summary>
    [EnumMember(Value = "RENW")]
    [IsoId("__wINc9ojEeC60axPepSq7g_166252954")]
    [Description(@"Securities lending contract is renewed.")]
    RollOverRenewal = SecuritiesLendingTypeCode.RollOverRenewal, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Securities lending contract is called back.
    /// Encoded/decoded by serializers as "CABK".
    /// </summary>
    [EnumMember(Value = "CABK")]
    [IsoId("__wINdNojEeC60axPepSq7g_-1719429399")]
    [Description(@"Securities lending contract is called back.")]
    CallBack = SecuritiesLendingTypeCode.CallBack, // same ordinal as derivation source for type conversions
    
}
