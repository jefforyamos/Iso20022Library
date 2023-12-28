﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for BalanceCounterparty1Code.  ISO2002 ID# _bkBa0tp-Ed-ak6NoX_4Aeg_678189976.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of counterparty to be taken into account for calculation of the balance.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_bkBa0tp-Ed-ak6NoX_4Aeg_678189976")]
[Description(@"Specifies the type of counterparty to be taken into account for calculation of the balance.")]
[DerivedFrom(typeof(BalanceCounterpartyCode))]
public enum BalanceCounterparty1Code
{
    /// <summary>
    /// Balance calculated regarding one member in the system.
    /// Encoded/decoded by serializers as "Bilateral".
    /// </summary>
    [EnumMember(Value = "BILA")]
    [IsoId("_bkBa09p-Ed-ak6NoX_4Aeg_678189977")]
    [Description(@"Balance calculated regarding one member in the system.")]
    Bilateral,
    
    /// <summary>
    /// Balance calculated regarding all members in the system.
    /// Encoded/decoded by serializers as "Multilateral".
    /// </summary>
    [EnumMember(Value = "MULT")]
    [IsoId("_bkBa1Np-Ed-ak6NoX_4Aeg_678189978")]
    [Description(@"Balance calculated regarding all members in the system.")]
    Multilateral,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class BalanceCounterparty1CodeMetadataExtensions
{
    private static readonly BalanceCounterparty1CodeDropdownSource _dropdownSource = new BalanceCounterparty1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IBalanceCounterparty1CodeDropdownRow GetMetadata(this BalanceCounterparty1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


