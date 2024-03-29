﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for TerminalIntegrationCategoryCode.  ISO2002 ID# _qt8lnWXOEem9Y55YJ70L8g.
// Copyright 2024 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.
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
    /// Encoded/decoded by serializers as &quot;MPOI&quot;.
    /// </summary>
    [EnumMember(Value = "MPOI")]
    [IsoId("_qt9Mq2XOEem9Y55YJ70L8g")]
    [Description(@"Multiple terminals linked to a unique sale terminal.")]
    MultiplePOITerminal,
    
    /// <summary>
    /// Terminal serving multiple sale terminals.
    /// Encoded/decoded by serializers as &quot;MSLE&quot;.
    /// </summary>
    [EnumMember(Value = "MSLE")]
    [IsoId("_qt9Mp2XOEem9Y55YJ70L8g")]
    [Description(@"Terminal serving multiple sale terminals.")]
    MultipleSaleTerminal,
    
    /// <summary>
    /// Terminal linked to a unique sale terminal.
    /// Encoded/decoded by serializers as &quot;SSLE&quot;.
    /// </summary>
    [EnumMember(Value = "SSLE")]
    [IsoId("_qt9MoWXOEem9Y55YJ70L8g")]
    [Description(@"Terminal linked to a unique sale terminal.")]
    SingleSaleTerminal,
    
}
