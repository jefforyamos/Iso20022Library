﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for TerminalIntegrationCategoryCode.  ISO2002 ID# _qt8lnWXOEem9Y55YJ70L8g.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Terminal category code of the place where the merchant actually performed the transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_qt8lnWXOEem9Y55YJ70L8g")]
[Description(@"Terminal category code of the place where the merchant actually performed the transaction.")]
[Derivations(typeof(TerminalIntegrationCategory1Code))]
public enum TerminalIntegrationCategoryCode
{
    /// <summary>
    /// Multiple terminals linked to a unique sale terminal.
    /// Encoded/decoded by serializers as "MPOI".
    /// </summary>
    [EnumMember(Value = "MPOI")]
    [IsoId("_qt9Mq2XOEem9Y55YJ70L8g")]
    [Description(@"Multiple terminals linked to a unique sale terminal.")]
    MultiplePOITerminal,
    
    /// <summary>
    /// Terminal serving multiple sale terminals.
    /// Encoded/decoded by serializers as "MSLE".
    /// </summary>
    [EnumMember(Value = "MSLE")]
    [IsoId("_qt9Mp2XOEem9Y55YJ70L8g")]
    [Description(@"Terminal serving multiple sale terminals.")]
    MultipleSaleTerminal,
    
    /// <summary>
    /// Terminal linked to a unique sale terminal.
    /// Encoded/decoded by serializers as "SSLE".
    /// </summary>
    [EnumMember(Value = "SSLE")]
    [IsoId("_qt9MoWXOEem9Y55YJ70L8g")]
    [Description(@"Terminal linked to a unique sale terminal.")]
    SingleSaleTerminal,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class TerminalIntegrationCategoryCodeMetadataExtensions
{
    private static readonly TerminalIntegrationCategoryCodeDropdownSource _dropdownSource = new TerminalIntegrationCategoryCodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ITerminalIntegrationCategoryCodeDropdownRow GetMetadata(this TerminalIntegrationCategoryCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


