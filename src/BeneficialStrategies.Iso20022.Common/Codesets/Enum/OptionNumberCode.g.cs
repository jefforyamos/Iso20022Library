﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for OptionNumberCode.  ISO2002 ID# _aP_AENp-Ed-ak6NoX_4Aeg_1603970622.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Code identifying special corporate action option numbers.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aP_AENp-Ed-ak6NoX_4Aeg_1603970622")]
[Description(@"Code identifying special corporate action option numbers.")]
public enum OptionNumberCode
{
    /// <summary>
    /// The corporate action instruction is unsolicited, that is, the instruction has not been preceded by a corporate action notification.
    /// Encoded/decoded by serializers as "UNSO".
    /// </summary>
    [EnumMember(Value = "UNSO")]
    [IsoId("_aP_AEdp-Ed-ak6NoX_4Aeg_2061898890")]
    [Description(@"The corporate action instruction is unsolicited, that is, the instruction has not been preceded by a corporate action notification.")]
    Unsolicited,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class OptionNumberCodeMetadataExtensions
{
    private static readonly OptionNumberCodeDropdownSource _dropdownSource = new OptionNumberCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IOptionNumberCodeDropdownRow GetMetadata(this OptionNumberCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}

