﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for LimitType4Code.  ISO2002 ID# _jPdhsO5NEeCisYr99QEiWA_1476260679.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of risk management limit.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_jPdhsO5NEeCisYr99QEiWA_1476260679")]
[Description(@"Specifies the type of risk management limit.")]
[DerivedFrom(typeof(LimitTypeCode))]
public enum LimitType4Code
{
    /// <summary>
    /// Limit is related to a cap amount granted by a national central bank or a settlement bank.
    /// Encoded/decoded by serializers as "ExternalGuarantee".
    /// </summary>
    [EnumMember(Value = "EXGT")]
    [IsoId("_jPdhse5NEeCisYr99QEiWA_-1234776902")]
    [Description(@"Limit is related to a cap amount granted by a national central bank or a settlement bank.")]
    ExternalGuarantee,
    
    /// <summary>
    /// Limit is related to a cap amount granted by a national central bank or a settlement bank, but generally unsecured outside of the market infrastructure.
    /// Encoded/decoded by serializers as "UnsecuredCredit".
    /// </summary>
    [EnumMember(Value = "UCDT")]
    [IsoId("_jPdhsu5NEeCisYr99QEiWA_-1814191119")]
    [Description(@"Limit is related to a cap amount granted by a national central bank or a settlement bank, but generally unsecured outside of the market infrastructure.")]
    UnsecuredCredit,
    
    /// <summary>
    /// Limit is related to a credit operation that is or can be triggered when a buyer does not have a sufficient amount of money to settle a securities transaction in order to improve its cash position for the next settlement cycle. The credit provided can be secured using securities already held by the buyer (“collateral stocks”) or the securities that are being purchased (“collateral flows”).
    /// Encoded/decoded by serializers as "AutoCollateralisation".
    /// </summary>
    [EnumMember(Value = "ACOL")]
    [IsoId("_jPdhs-5NEeCisYr99QEiWA_-1669106499")]
    [Description(@"Limit is related to a credit operation that is or can be triggered when a buyer does not have a sufficient amount of money to settle a securities transaction in order to improve its cash position for the next settlement cycle. The credit provided can be secured using securities already held by the buyer (“collateral stocks”) or the securities that are being purchased (“collateral flows”).")]
    AutoCollateralisation,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class LimitType4CodeMetadataExtensions
{
    private static readonly LimitType4CodeDropdownSource _dropdownSource = new LimitType4CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ILimitType4CodeDropdownRow GetMetadata(this LimitType4Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


