﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for StandingInstructionGrossNet1Code.  ISO2002 ID# _ZPnIN9p-Ed-ak6NoX_4Aeg_977181318.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of standing instruction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZPnIN9p-Ed-ak6NoX_4Aeg_977181318")]
[Description(@"Specifies the type of standing instruction.")]
[DerivedFrom(typeof(StandingInstructionGrossNetCode))]
public enum StandingInstructionGrossNet1Code
{
    /// <summary>
    /// Gross payment.
    /// Encoded/decoded by serializers as "Gross".
    /// </summary>
    [EnumMember(Value = "GROS")]
    [IsoId("_ZPnIONp-Ed-ak6NoX_4Aeg_1018738724")]
    [Description(@"Gross payment.")]
    Gross,
    
    /// <summary>
    /// Net payment.
    /// Encoded/decoded by serializers as "Net".
    /// </summary>
    [EnumMember(Value = "NETT")]
    [IsoId("_ZPw5MNp-Ed-ak6NoX_4Aeg_1053834510")]
    [Description(@"Net payment.")]
    Net,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class StandingInstructionGrossNet1CodeMetadataExtensions
{
    private static readonly StandingInstructionGrossNet1CodeDropdownSource _dropdownSource = new StandingInstructionGrossNet1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IStandingInstructionGrossNet1CodeDropdownRow GetMetadata(this StandingInstructionGrossNet1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


