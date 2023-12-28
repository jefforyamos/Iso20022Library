﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ProtectInstructionStatus4Code.  ISO2002 ID# _3EeYcLpbEeilsanBGAzy4A.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the status of the protect transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_3EeYcLpbEeilsanBGAzy4A")]
[Description(@"Specifies the status of the protect transaction.")]
[DerivedFrom(typeof(DTCInstructionStatusCode))]
public enum ProtectInstructionStatus4Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Open".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_BshVMbpcEeilsanBGAzy4A")]
    [Description(@"??")]
    Open,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ProtectInstructionStatus4CodeMetadataExtensions
{
    private static readonly ProtectInstructionStatus4CodeDropdownSource _dropdownSource = new ProtectInstructionStatus4CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IProtectInstructionStatus4CodeDropdownRow GetMetadata(this ProtectInstructionStatus4Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


